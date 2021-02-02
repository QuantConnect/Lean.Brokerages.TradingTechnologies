// This is a generated file.  Don't edit it directly!

using QuickFix;
using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class OrderMassAction : Message
        {
            public const string MsgType = "BZ";

            public OrderMassAction() : base()
            {
                this.Header.SetField(new MsgType("BZ"));
            }

            public OrderMassAction(
                    ClOrdID aClOrdID,
                    MassActionReportID aMassActionReportID,
                    MassActionType aMassActionType,
                    MassActionScope aMassActionScope,
                    MassActionResponse aMassActionResponse,
                    TotalAffectedOrders aTotalAffectedOrders,
                    TransactTime aTransactTime,
                    LastFragment aLastFragment
                ) : this()
            {
                this.ClOrdID = aClOrdID;
                this.MassActionReportID = aMassActionReportID;
                this.MassActionType = aMassActionType;
                this.MassActionScope = aMassActionScope;
                this.MassActionResponse = aMassActionResponse;
                this.TotalAffectedOrders = aTotalAffectedOrders;
                this.TransactTime = aTransactTime;
                this.LastFragment = aLastFragment;
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
            public MassActionType MassActionType
            { 
                get 
                {
                    MassActionType val = new MassActionType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MassActionType val) 
            { 
                this.MassActionType = val;
            }
            
            public MassActionType Get(MassActionType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MassActionType val) 
            { 
                return IsSetMassActionType();
            }
            
            public bool IsSetMassActionType() 
            { 
                return IsSetField(Fields.CustomTags.MassActionType);
            }
            public MassActionScope MassActionScope
            { 
                get 
                {
                    MassActionScope val = new MassActionScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MassActionScope val) 
            { 
                this.MassActionScope = val;
            }
            
            public MassActionScope Get(MassActionScope val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MassActionScope val) 
            { 
                return IsSetMassActionScope();
            }
            
            public bool IsSetMassActionScope() 
            { 
                return IsSetField(Fields.CustomTags.MassActionScope);
            }
            public MassActionResponse MassActionResponse
            { 
                get 
                {
                    MassActionResponse val = new MassActionResponse();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MassActionResponse val) 
            { 
                this.MassActionResponse = val;
            }
            
            public MassActionResponse Get(MassActionResponse val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MassActionResponse val) 
            { 
                return IsSetMassActionResponse();
            }
            
            public bool IsSetMassActionResponse() 
            { 
                return IsSetField(Fields.CustomTags.MassActionResponse);
            }
            public TotalAffectedOrders TotalAffectedOrders
            { 
                get 
                {
                    TotalAffectedOrders val = new TotalAffectedOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TotalAffectedOrders val) 
            { 
                this.TotalAffectedOrders = val;
            }
            
            public TotalAffectedOrders Get(TotalAffectedOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TotalAffectedOrders val) 
            { 
                return IsSetTotalAffectedOrders();
            }
            
            public bool IsSetTotalAffectedOrders() 
            { 
                return IsSetField(Fields.CustomTags.TotalAffectedOrders);
            }
            public NoAffectedOrders NoAffectedOrders
            { 
                get 
                {
                    NoAffectedOrders val = new NoAffectedOrders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoAffectedOrders val) 
            { 
                this.NoAffectedOrders = val;
            }
            
            public NoAffectedOrders Get(NoAffectedOrders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoAffectedOrders val) 
            { 
                return IsSetNoAffectedOrders();
            }
            
            public bool IsSetNoAffectedOrders() 
            { 
                return IsSetField(Fields.CustomTags.NoAffectedOrders);
            }
            public MarketSegmentID MarketSegmentID
            { 
                get 
                {
                    MarketSegmentID val = new MarketSegmentID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MarketSegmentID val) 
            { 
                this.MarketSegmentID = val;
            }
            
            public MarketSegmentID Get(MarketSegmentID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MarketSegmentID val) 
            { 
                return IsSetMarketSegmentID();
            }
            
            public bool IsSetMarketSegmentID() 
            { 
                return IsSetField(Fields.CustomTags.MarketSegmentID);
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
            public SecurityDesc SecurityDesc
            { 
                get 
                {
                    SecurityDesc val = new SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityDesc val) 
            { 
                this.SecurityDesc = val;
            }
            
            public SecurityDesc Get(SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(Fields.CustomTags.SecurityDesc);
            }
            public MassCancelRequestType MassCancelRequestType
            { 
                get 
                {
                    MassCancelRequestType val = new MassCancelRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MassCancelRequestType val) 
            { 
                this.MassCancelRequestType = val;
            }
            
            public MassCancelRequestType Get(MassCancelRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MassCancelRequestType val) 
            { 
                return IsSetMassCancelRequestType();
            }
            
            public bool IsSetMassCancelRequestType() 
            { 
                return IsSetField(Fields.CustomTags.MassCancelRequestType);
            }
            public Account Account
            { 
                get 
                {
                    Account val = new Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Account val) 
            { 
                this.Account = val;
            }
            
            public Account Get(Account val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Account val) 
            { 
                return IsSetAccount();
            }
            
            public bool IsSetAccount() 
            { 
                return IsSetField(Fields.CustomTags.Account);
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
            public OrdType OrdType
            { 
                get 
                {
                    OrdType val = new OrdType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrdType val) 
            { 
                this.OrdType = val;
            }
            
            public OrdType Get(OrdType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrdType val) 
            { 
                return IsSetOrdType();
            }
            
            public bool IsSetOrdType() 
            { 
                return IsSetField(Fields.CustomTags.OrdType);
            }
            public TimeInForce TimeInForce
            { 
                get 
                {
                    TimeInForce val = new TimeInForce();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TimeInForce val) 
            { 
                this.TimeInForce = val;
            }
            
            public TimeInForce Get(TimeInForce val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TimeInForce val) 
            { 
                return IsSetTimeInForce();
            }
            
            public bool IsSetTimeInForce() 
            { 
                return IsSetField(Fields.CustomTags.TimeInForce);
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
            public ManualOrderIndicator ManualOrderIndicator
            { 
                get 
                {
                    ManualOrderIndicator val = new ManualOrderIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ManualOrderIndicator val) 
            { 
                this.ManualOrderIndicator = val;
            }
            
            public ManualOrderIndicator Get(ManualOrderIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ManualOrderIndicator val) 
            { 
                return IsSetManualOrderIndicator();
            }
            
            public bool IsSetManualOrderIndicator() 
            { 
                return IsSetField(Fields.CustomTags.ManualOrderIndicator);
            }
            public LastFragment LastFragment
            { 
                get 
                {
                    LastFragment val = new LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LastFragment val) 
            { 
                this.LastFragment = val;
            }
            
            public LastFragment Get(LastFragment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LastFragment val) 
            { 
                return IsSetLastFragment();
            }
            
            public bool IsSetLastFragment() 
            { 
                return IsSetField(Fields.CustomTags.LastFragment);
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
            public RequestTime RequestTime
            { 
                get 
                {
                    RequestTime val = new RequestTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(RequestTime val) 
            { 
                this.RequestTime = val;
            }
            
            public RequestTime Get(RequestTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(RequestTime val) 
            { 
                return IsSetRequestTime();
            }
            
            public bool IsSetRequestTime() 
            { 
                return IsSetField(Fields.CustomTags.RequestTime);
            }
            public class NoAffectedOrdersGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.OrigClOrdID, Fields.CustomTags.CxlQty, Fields.CustomTags.AffectedOrderID, 0};
            
                public NoAffectedOrdersGroup() 
                  :base( Fields.CustomTags.NoAffectedOrders, Fields.CustomTags.OrigClOrdID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoAffectedOrdersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public OrigClOrdID OrigClOrdID
                { 
                    get 
                    {
                        OrigClOrdID val = new OrigClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(OrigClOrdID val) 
                { 
                    this.OrigClOrdID = val;
                }
                
                public OrigClOrdID Get(OrigClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(OrigClOrdID val) 
                { 
                    return IsSetOrigClOrdID();
                }
                
                public bool IsSetOrigClOrdID() 
                { 
                    return IsSetField(Fields.CustomTags.OrigClOrdID);
                }
                public CxlQty CxlQty
                { 
                    get 
                    {
                        CxlQty val = new CxlQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(CxlQty val) 
                { 
                    this.CxlQty = val;
                }
                
                public CxlQty Get(CxlQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(CxlQty val) 
                { 
                    return IsSetCxlQty();
                }
                
                public bool IsSetCxlQty() 
                { 
                    return IsSetField(Fields.CustomTags.CxlQty);
                }
                public AffectedOrderID AffectedOrderID
                { 
                    get 
                    {
                        AffectedOrderID val = new AffectedOrderID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(AffectedOrderID val) 
                { 
                    this.AffectedOrderID = val;
                }
                
                public AffectedOrderID Get(AffectedOrderID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(AffectedOrderID val) 
                { 
                    return IsSetAffectedOrderID();
                }
                
                public bool IsSetAffectedOrderID() 
                { 
                    return IsSetField(Fields.CustomTags.AffectedOrderID);
                }
            
            }
        }
    }
}
