/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.2 Copyright 2015 QuantConnect Corporation.
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QuantConnect.Brokerages.TradingTechnologies.TT.Api
{
    [JsonObject]
    public class AccountResponse
    {
        public List<Account> Account { get; set; }
    }

    [JsonObject]
    public class Account
    {
        [JsonProperty]
        public decimal? Id { get; set; }
        [JsonProperty]
        public string Name { get; set; }
    }
}
