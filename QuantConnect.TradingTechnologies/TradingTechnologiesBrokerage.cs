/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuantConnect.Data;
using QuantConnect.Fix.TT.FIX44.Messages;
using QuantConnect.Interfaces;
using QuantConnect.Logging;
using QuantConnect.Orders;
using QuantConnect.Orders.Fees;
using QuantConnect.Packets;
using QuantConnect.Securities;
using QuantConnect.Api;
using QuantConnect.Brokerages.TradingTechnologies.Fix;
using QuantConnect.Brokerages.TradingTechnologies.Fix.Core;
using QuantConnect.Brokerages.TradingTechnologies.Fix.Utils;
using QuantConnect.Brokerages.TradingTechnologies.TT;
using QuantConnect.Brokerages.TradingTechnologies.TT.Api;
using QuantConnect.Util;
using BaseData = QuantConnect.Data.BaseData;
using System.Net.Http;

namespace QuantConnect.Brokerages.TradingTechnologies
{
    [BrokerageFactory(typeof(TradingTechnologiesBrokerageFactory))]
    public class TradingTechnologiesBrokerage : Brokerage, IDataQueueHandler, IDataQueueUniverseProvider
    {
        private readonly IAlgorithm _algorithm;
        private readonly LiveNodePacket _job;
        private readonly IOrderProvider _orderProvider;
        private readonly IDataAggregator _aggregator;

        private bool _isDataQueueHandlerInitialized;

        private readonly EventBasedDataQueueHandlerSubscriptionManager _subscriptionManager;
        private readonly IFixMarketDataController _fixMarketDataController;
        private readonly FixBrokerageController _fixBrokerageController;
        private readonly FixInstance _fixInstance;

        private bool _ignorePositionsFromOtherAccountsWarning;
        private readonly TTApiClient _apiClient;
        private readonly FixConfiguration _fixConfiguration;
        private readonly TradingTechnologiesSymbolMapper _symbolMapper;
        private readonly SymbolPropertiesDatabase _symbolPropertiesDatabase = SymbolPropertiesDatabase.FromDataFolder();
        private HashSet<string> _unknownInstrumentIds = new();

        public TradingTechnologiesBrokerage(IAlgorithm algorithm, LiveNodePacket job, IOrderProvider orderProvider, IDataAggregator aggregator, FixConfiguration fixConfiguration, bool logFixMessages)
            : base("TradingTechnologies")
        {
            _algorithm = algorithm;
            _job = job;
            _orderProvider = orderProvider;
            _aggregator = aggregator;

            _fixConfiguration = fixConfiguration;
            _subscriptionManager = new EventBasedDataQueueHandlerSubscriptionManager();
            _subscriptionManager.SubscribeImpl += (s, t) => Subscribe(s);
            _subscriptionManager.UnsubscribeImpl += (s, t) => Unsubscribe(s);

            _apiClient = new TTApiClient(fixConfiguration.RestAppKey, fixConfiguration.RestAppSecret, fixConfiguration.RestEnvironment);

            _apiClient.Error += (object _, string error) =>
            {
                OnMessage(new BrokerageMessageEvent(BrokerageMessageType.Error, -1, error));
            };

            _symbolMapper = new TradingTechnologiesSymbolMapper(_apiClient);

            _fixMarketDataController = new FixMarketDataController();
            _fixMarketDataController.NewTick += OnNewTick;

            _fixBrokerageController = new FixBrokerageController(_symbolMapper, _fixConfiguration.AccountName);
            _fixBrokerageController.ExecutionReport += OnExecutionReport;
            _fixBrokerageController.Warning += (object _, string warning) =>
            {
                OnMessage(new BrokerageMessageEvent(BrokerageMessageType.Warning, -1, warning));
            };

            var fixProtocolDirector = new TTFixProtocolDirector(_symbolMapper, fixConfiguration, _fixMarketDataController, _fixBrokerageController);

            _fixInstance = new FixInstance(fixProtocolDirector, fixConfiguration, logFixMessages);

            // call home
            ValidateSubscription();
        }

        /// <summary>
        /// Subscribe to the specified configuration
        /// </summary>
        /// <param name="dataConfig">defines the parameters to subscribe to a data feed</param>
        /// <param name="newDataAvailableHandler">handler to be fired on new data available</param>
        /// <returns>The new enumerator for this subscription request</returns>
        public IEnumerator<BaseData> Subscribe(SubscriptionDataConfig dataConfig, EventHandler newDataAvailableHandler)
        {
            if (!_isDataQueueHandlerInitialized)
            {
                _isDataQueueHandlerInitialized = true;

                _fixInstance.AddMarketDataSession();
            }

            if (!CanSubscribe(dataConfig.Symbol))
            {
                return Enumerable.Empty<BaseData>().GetEnumerator();
            }

            var enumerator = _aggregator.Add(dataConfig, newDataAvailableHandler);
            _subscriptionManager.Subscribe(dataConfig);

            return enumerator;
        }

        /// <summary>
        /// Removes the specified configuration
        /// </summary>
        /// <param name="dataConfig">Subscription config to be removed</param>
        public void Unsubscribe(SubscriptionDataConfig dataConfig)
        {
            _subscriptionManager.Unsubscribe(dataConfig);
            _aggregator.Remove(dataConfig);
        }

        private bool CanSubscribe(Symbol symbol)
        {
            if (symbol.IsCanonical() || symbol.SecurityType != SecurityType.Future)
            {
                return false;
            }

            return true;
        }

        private bool Subscribe(IEnumerable<Symbol> symbols)
        {
            foreach (var symbol in symbols)
            {
                _fixMarketDataController.Subscribe(symbol);
            }

            return true;
        }

        private bool Unsubscribe(IEnumerable<Symbol> symbols)
        {
            foreach (var symbol in symbols)
            {
                _fixMarketDataController.Unsubscribe(symbol);
            }

            return true;
        }

        public void SetJob(LiveNodePacket job)
        {
        }

        public override bool IsConnected => _fixInstance.IsConnected();

        public override List<Order> GetOpenOrders()
        {
            _fixBrokerageController.RequestOpenOrders();

            return _fixBrokerageController.GetOpenOrders();
        }

        public override List<Holding> GetAccountHoldings()
        {
            var holdings = new List<Holding>();

            var positions = _apiClient.GetPositions().SynchronouslyAwaitTaskResult();
            var accountNamePerId = new Dictionary<decimal, string>();

            foreach (var position in positions)
            {
                if (!position.NetPosition.HasValue || position.NetPosition.Value == 0)
                {
                    continue;
                }

                if (position.AccountId.HasValue)
                {
                    if (!accountNamePerId.TryGetValue(position.AccountId.Value, out var accountName))
                    {
                        accountNamePerId[position.AccountId.Value] = accountName = _apiClient.GetAccountName(position.AccountId.Value).SynchronouslyAwaitTaskResult();
                    }

                    if (!string.IsNullOrEmpty(accountName) && accountName != _fixConfiguration.AccountName)
                    {
                        if (!_ignorePositionsFromOtherAccountsWarning)
                        {
                            _ignorePositionsFromOtherAccountsWarning = true;
                            OnMessage(new BrokerageMessageEvent(BrokerageMessageType.Warning, -1, $"Holdings of other accounts like {accountName} will be ignored"));
                        }
                        continue;
                    }
                }

                try
                {
                    var symbol = _symbolMapper.GetLeanSymbol(position.InstrumentId);

                    var currencySymbol = Currencies.GetCurrencySymbol(
                        _symbolPropertiesDatabase.GetSymbolProperties(symbol.ID.Market, symbol, symbol.SecurityType, Currencies.USD).QuoteCurrency);

                    var displayFactor = _symbolMapper.GetDisplayFactor(symbol);

                    var holding = new Holding
                    {
                        Symbol = symbol,
                        Quantity = position.NetPosition.Value,
                        AveragePrice = position.OpenAvgPrice * displayFactor ?? 0,
                        MarketPrice = position.PnlPrice * displayFactor ?? 0,
                        CurrencySymbol = currencySymbol
                    };

                    holdings.Add(holding);
                }
                catch (Exception ex)
                {
                    if (_algorithm?.Settings.IgnoreUnknownAssetHoldings ?? true)
                    {
                        if (_unknownInstrumentIds.Add(position.InstrumentId))
                        {
                            OnMessage(new BrokerageMessageEvent(BrokerageMessageType.Warning, -1,
                                $"Unsupported asset {position.InstrumentId} will be ignored: {ex.Message}"));
                        }
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return holdings;
        }

        public override List<CashAmount> GetCashBalance()
        {
            return GetCashBalance(_job.BrokerageData, _algorithm.Portfolio.CashBook);
        }

        public override bool PlaceOrder(Order order)
        {
            return _fixBrokerageController.PlaceOrder(order);
        }

        public override bool UpdateOrder(Order order)
        {
            return _fixBrokerageController.UpdateOrder(order);
        }

        public override bool CancelOrder(Order order)
        {
            return _fixBrokerageController.CancelOrder(order);
        }

        public override void Connect()
        {
            _fixInstance.Initialise();
        }

        public override void Disconnect()
        {
            _fixInstance.Terminate();
        }

        public override void Dispose()
        {
            _fixInstance.DisposeSafely();
        }

        public IEnumerable<Symbol> LookupSymbols(Symbol symbol, bool includeExpired, string securityCurrency = null)
        {
            if (symbol.SecurityType == SecurityType.Future)
            {
                // TODO: fetch from TT REST API

                //var productTypeId = _symbolMapper.GetBrokerageProductTypeId(symbol.SecurityType);
                //var marketId = _symbolMapper.GetBrokerageMarketId(symbol.ID.Market);

                //var products = _apiClient.GetProducts(marketId).SynchronouslyAwaitTaskResult();

                //var product = products
                //    .FirstOrDefault(x => x.Symbol == symbol.ID.Symbol && x.ProductTypeId == productTypeId);

                //if (product != null)
                //{
                //    var instruments = _apiClient.GetInstruments(product.ProductTypeId, product.Id).SynchronouslyAwaitTaskResult();

                //    foreach (var instrument in instruments)
                //    {
                //        var expiryDate = DateTime.ParseExact(
                //            instrument.ExpirationDate.ToString(CultureInfo.InvariantCulture),
                //            "yyyyMMddHHmmss",
                //            CultureInfo.InvariantCulture).Date;

                //        yield return Symbol.CreateFuture(symbol.ID.Symbol, symbol.ID.Market, expiryDate);
                //    }
                //}
            }

            return Enumerable.Empty<Symbol>();
        }

        public bool CanPerformSelection()
        {
            return true;
        }

        private void OnExecutionReport(object sender, ExecutionReport e)
        {
            var orderStatus = Utility.ConvertOrderStatus(e);

            var orderId = orderStatus == OrderStatus.Canceled || orderStatus == OrderStatus.UpdateSubmitted
                ? e.OrigClOrdID.getValue()
                : e.ClOrdID.getValue();
            var time = e.TransactTime.getValue();

            var order = _orderProvider.GetOrdersByBrokerageId(orderId)?.SingleOrDefault();
            if (order == null)
            {
                Log.Error($"TradingTechnologiesBrokerage.OnExecutionReport(): Unable to locate order with BrokerageId: {orderId}");
                return;
            }

            if (orderStatus == OrderStatus.UpdateSubmitted)
            {
                order.BrokerId[0] = e.ClOrdID.getValue();
            }

            var message = "Trading Technologies Order Event";
            if (e.IsSetText())
            {
                message += $" - {e.Text.getValue()}";
            }

            var orderEvent = new OrderEvent(order, time, OrderFee.Zero, message)
            {
                Status = orderStatus
            };

            if (orderStatus == OrderStatus.Filled || orderStatus == OrderStatus.PartiallyFilled)
            {
                var displayFactor = _symbolMapper.GetDisplayFactor(order.Symbol);

                var filledQuantity = e.LastShares.getValue();
                var remainingQuantity = order.AbsoluteQuantity - e.CumQty.getValue();

                orderEvent.FillQuantity = filledQuantity * (order.Direction == OrderDirection.Buy ? 1 : -1);
                orderEvent.FillPrice = e.LastPx.getValue() * displayFactor;

                if (remainingQuantity > 0)
                {
                    orderEvent.Message += " - " + remainingQuantity + " remaining";
                }
            }

            OnOrderEvent(orderEvent);
        }

        private void OnNewTick(object sender, Data.Market.Tick e)
        {
            _aggregator.Update(e);
        }

        private class ModulesReadLicenseRead : Api.RestResponse
        {
            [JsonProperty(PropertyName = "license")]
            public string License;
            [JsonProperty(PropertyName = "organizationId")]
            public string OrganizationId;
        }

        /// <summary>
        /// Validate the user of this project has permission to be using it via our web API.
        /// </summary>
        private static void ValidateSubscription()
        {
            try
            {
                const int productId = 64;
                var userId = Globals.UserId;
                var token = Globals.UserToken;
                var organizationId = Globals.OrganizationID;
                // Verify we can authenticate with this user and token
                var api = new ApiConnection(userId, token);
                if (!api.Connected)
                {
                    throw new ArgumentException("Invalid api user id or token, cannot authenticate subscription.");
                }
                // Compile the information we want to send when validating
                var information = new Dictionary<string, object>()
                {
                    {"productId", productId},
                    {"machineName", Environment.MachineName},
                    {"userName", Environment.UserName},
                    {"domainName", Environment.UserDomainName},
                    {"os", Environment.OSVersion}
                };
                // IP and Mac Address Information
                try
                {
                    var interfaceDictionary = new List<Dictionary<string, object>>();
                    foreach (var nic in NetworkInterface.GetAllNetworkInterfaces().Where(nic => nic.OperationalStatus == OperationalStatus.Up))
                    {
                        var interfaceInformation = new Dictionary<string, object>();
                        // Get UnicastAddresses
                        var addresses = nic.GetIPProperties().UnicastAddresses
                            .Select(uniAddress => uniAddress.Address)
                            .Where(address => !IPAddress.IsLoopback(address)).Select(x => x.ToString());
                        // If this interface has non-loopback addresses, we will include it
                        if (!addresses.IsNullOrEmpty())
                        {
                            interfaceInformation.Add("unicastAddresses", addresses);
                            // Get MAC address
                            interfaceInformation.Add("MAC", nic.GetPhysicalAddress().ToString());
                            // Add Interface name
                            interfaceInformation.Add("name", nic.Name);
                            // Add these to our dictionary
                            interfaceDictionary.Add(interfaceInformation);
                        }
                    }
                    information.Add("networkInterfaces", interfaceDictionary);
                }
                catch (Exception)
                {
                    // NOP, not necessary to crash if fails to extract and add this information
                }
                // Include our OrganizationId is specified
                if (!string.IsNullOrEmpty(organizationId))
                {
                    information.Add("organizationId", organizationId);
                }
                // Create HTTP request
                using var request = ApiUtils.CreateJsonPostRequest("modules/license/read", information);
                api.TryRequest(request, out ModulesReadLicenseRead result);
                if (!result.Success)
                {
                    throw new InvalidOperationException($"Request for subscriptions from web failed, Response Errors : {string.Join(',', result.Errors)}");
                }

                var encryptedData = result.License;
                // Decrypt the data we received
                DateTime? expirationDate = null;
                long? stamp = null;
                bool? isValid = null;
                if (encryptedData != null)
                {
                    // Fetch the org id from the response if we are null, we need it to generate our validation key
                    if (string.IsNullOrEmpty(organizationId))
                    {
                        organizationId = result.OrganizationId;
                    }
                    // Create our combination key
                    var password = $"{token}-{organizationId}";
                    var key = SHA256.HashData(Encoding.UTF8.GetBytes(password));
                    // Split the data
                    var info = encryptedData.Split("::");
                    var buffer = Convert.FromBase64String(info[0]);
                    var iv = Convert.FromBase64String(info[1]);
                    // Decrypt our information
                    using var aes = new AesManaged();
                    var decryptor = aes.CreateDecryptor(key, iv);
                    using var memoryStream = new MemoryStream(buffer);
                    using var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                    using var streamReader = new StreamReader(cryptoStream);
                    var decryptedData = streamReader.ReadToEnd();
                    if (!decryptedData.IsNullOrEmpty())
                    {
                        var jsonInfo = JsonConvert.DeserializeObject<JObject>(decryptedData);
                        expirationDate = jsonInfo["expiration"]?.Value<DateTime>();
                        isValid = jsonInfo["isValid"]?.Value<bool>();
                        stamp = jsonInfo["stamped"]?.Value<int>();
                    }
                }
                // Validate our conditions
                if (!expirationDate.HasValue || !isValid.HasValue || !stamp.HasValue)
                {
                    throw new InvalidOperationException("Failed to validate subscription.");
                }

                var nowUtc = DateTime.UtcNow;
                var timeSpan = nowUtc - Time.UnixTimeStampToDateTime(stamp.Value);
                if (timeSpan > TimeSpan.FromHours(12))
                {
                    throw new InvalidOperationException("Invalid API response.");
                }
                if (!isValid.Value)
                {
                    throw new ArgumentException($"Your subscription is not valid, please check your product subscriptions on our website.");
                }
                if (expirationDate < nowUtc)
                {
                    throw new ArgumentException($"Your subscription expired {expirationDate}, please renew in order to use this product.");
                }
            }
            catch (Exception e)
            {
                Log.Error($"ValidateSubscription(): Failed during validation, shutting down. Error : {e.Message}");
                Environment.Exit(1);
            }
        }
    }
}
