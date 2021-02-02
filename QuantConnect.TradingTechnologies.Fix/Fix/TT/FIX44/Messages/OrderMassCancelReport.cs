// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class OrderMassCancelReport : Message
        {
            public const string MsgType = "r";

            public OrderMassCancelReport() : base()
            {
                this.Header.SetField(new MsgType("r"));
            }

            public OrderMassCancelReport(
                    ClOrdID aClOrdID,
                    OrderID aOrderID,
                    MassCancelRequestReportType aMassCancelRequestReportType,
                    MassCancelResponse aMassCancelResponse,
                    ClientID aClientID,
                    OriginatorUserID aOriginatorUserID,
                    Symbol aSymbol,
                    MassActionReportID aMassActionReportID,
                    TransactTime aTransactTime
                ) : this()
            {
                this.ClOrdID = aClOrdID;
                this.OrderID = aOrderID;
                this.MassCancelRequestReportType = aMassCancelRequestReportType;
                this.MassCancelResponse = aMassCancelResponse;
                this.ClientID = aClientID;
                this.OriginatorUserID = aOriginatorUserID;
                this.Symbol = aSymbol;
                this.MassActionReportID = aMassActionReportID;
                this.TransactTime = aTransactTime;
            }

            public ClOrdID ClOrdID
            { 
                get 
                {
                    ClOrdID val = new ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ClOrdID val) 
            { 
                this.ClOrdID = val;
            }
            
            public ClOrdID Get(ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(Fields.CustomTags.ClOrdID);
            }
            public OrderID OrderID
            { 
                get 
                {
                    OrderID val = new OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderID val) 
            { 
                this.OrderID = val;
            }
            
            public OrderID Get(OrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderID val) 
            { 
                return IsSetOrderID();
            }
            
            public bool IsSetOrderID() 
            { 
                return IsSetField(Fields.CustomTags.OrderID);
            }
            public MassCancelRequestReportType MassCancelRequestReportType
            { 
                get 
                {
                    MassCancelRequestReportType val = new MassCancelRequestReportType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MassCancelRequestReportType val) 
            { 
                this.MassCancelRequestReportType = val;
            }
            
            public MassCancelRequestReportType Get(MassCancelRequestReportType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MassCancelRequestReportType val) 
            { 
                return IsSetMassCancelRequestReportType();
            }
            
            public bool IsSetMassCancelRequestReportType() 
            { 
                return IsSetField(Fields.CustomTags.MassCancelRequestReportType);
            }
            public MassCancelResponse MassCancelResponse
            { 
                get 
                {
                    MassCancelResponse val = new MassCancelResponse();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MassCancelResponse val) 
            { 
                this.MassCancelResponse = val;
            }
            
            public MassCancelResponse Get(MassCancelResponse val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MassCancelResponse val) 
            { 
                return IsSetMassCancelResponse();
            }
            
            public bool IsSetMassCancelResponse() 
            { 
                return IsSetField(Fields.CustomTags.MassCancelResponse);
            }
            public MassCancelRejectReason MassCancelRejectReason
            { 
                get 
                {
                    MassCancelRejectReason val = new MassCancelRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MassCancelRejectReason val) 
            { 
                this.MassCancelRejectReason = val;
            }
            
            public MassCancelRejectReason Get(MassCancelRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MassCancelRejectReason val) 
            { 
                return IsSetMassCancelRejectReason();
            }
            
            public bool IsSetMassCancelRejectReason() 
            { 
                return IsSetField(Fields.CustomTags.MassCancelRejectReason);
            }
            public TradingSessionSubID TradingSessionSubID
            { 
                get 
                {
                    TradingSessionSubID val = new TradingSessionSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradingSessionSubID val) 
            { 
                this.TradingSessionSubID = val;
            }
            
            public TradingSessionSubID Get(TradingSessionSubID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradingSessionSubID val) 
            { 
                return IsSetTradingSessionSubID();
            }
            
            public bool IsSetTradingSessionSubID() 
            { 
                return IsSetField(Fields.CustomTags.TradingSessionSubID);
            }
            public ClientID ClientID
            { 
                get 
                {
                    ClientID val = new ClientID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ClientID val) 
            { 
                this.ClientID = val;
            }
            
            public ClientID Get(ClientID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ClientID val) 
            { 
                return IsSetClientID();
            }
            
            public bool IsSetClientID() 
            { 
                return IsSetField(Fields.CustomTags.ClientID);
            }
            public OriginatorUserID OriginatorUserID
            { 
                get 
                {
                    OriginatorUserID val = new OriginatorUserID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OriginatorUserID val) 
            { 
                this.OriginatorUserID = val;
            }
            
            public OriginatorUserID Get(OriginatorUserID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OriginatorUserID val) 
            { 
                return IsSetOriginatorUserID();
            }
            
            public bool IsSetOriginatorUserID() 
            { 
                return IsSetField(Fields.CustomTags.OriginatorUserID);
            }
            public Symbol Symbol
            { 
                get 
                {
                    Symbol val = new Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Symbol val) 
            { 
                this.Symbol = val;
            }
            
            public Symbol Get(Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(Fields.CustomTags.Symbol);
            }
            public Side Side
            { 
                get 
                {
                    Side val = new Side();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Side val) 
            { 
                this.Side = val;
            }
            
            public Side Get(Side val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Side val) 
            { 
                return IsSetSide();
            }
            
            public bool IsSetSide() 
            { 
                return IsSetField(Fields.CustomTags.Side);
            }
            public Price Price
            { 
                get 
                {
                    Price val = new Price();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Price val) 
            { 
                this.Price = val;
            }
            
            public Price Get(Price val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Price val) 
            { 
                return IsSetPrice();
            }
            
            public bool IsSetPrice() 
            { 
                return IsSetField(Fields.CustomTags.Price);
            }
            public Text Text
            { 
                get 
                {
                    Text val = new Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Text val) 
            { 
                this.Text = val;
            }
            
            public Text Get(Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(Fields.CustomTags.Text);
            }
            public MassActionReportID MassActionReportID
            { 
                get 
                {
                    MassActionReportID val = new MassActionReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MassActionReportID val) 
            { 
                this.MassActionReportID = val;
            }
            
            public MassActionReportID Get(MassActionReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MassActionReportID val) 
            { 
                return IsSetMassActionReportID();
            }
            
            public bool IsSetMassActionReportID() 
            { 
                return IsSetField(Fields.CustomTags.MassActionReportID);
            }
            public TransactTime TransactTime
            { 
                get 
                {
                    TransactTime val = new TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TransactTime val) 
            { 
                this.TransactTime = val;
            }
            
            public TransactTime Get(TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(Fields.CustomTags.TransactTime);
            }
        }
    }
}
