// This is a generated file.  Don't edit it directly!

using QuickFix;
using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class OrderCancelReplaceRequest : Message
        {
            public const string MsgType = "G";

            public OrderCancelReplaceRequest() : base()
            {
                this.Header.SetField(new MsgType("G"));
            }

            public OrderCancelReplaceRequest(
                    ClOrdID aClOrdID,
                    Account aAccount,
                    OrderQty aOrderQty,
                    Side aSide,
                    OrdType aOrdType
                ) : this()
            {
                this.ClOrdID = aClOrdID;
                this.Account = aAccount;
                this.OrderQty = aOrderQty;
                this.Side = aSide;
                this.OrdType = aOrdType;
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
            public OrderIDGUID OrderIDGUID
            { 
                get 
                {
                    OrderIDGUID val = new OrderIDGUID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderIDGUID val) 
            { 
                this.OrderIDGUID = val;
            }
            
            public OrderIDGUID Get(OrderIDGUID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderIDGUID val) 
            { 
                return IsSetOrderIDGUID();
            }
            
            public bool IsSetOrderIDGUID() 
            { 
                return IsSetField(Fields.CustomTags.OrderIDGUID);
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
            public StopPx StopPx
            { 
                get 
                {
                    StopPx val = new StopPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StopPx val) 
            { 
                this.StopPx = val;
            }
            
            public StopPx Get(StopPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StopPx val) 
            { 
                return IsSetStopPx();
            }
            
            public bool IsSetStopPx() 
            { 
                return IsSetField(Fields.CustomTags.StopPx);
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
            public Product Product
            { 
                get 
                {
                    Product val = new Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Product val) 
            { 
                this.Product = val;
            }
            
            public Product Get(Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(Fields.CustomTags.Product);
            }
            public StrikePrice StrikePrice
            { 
                get 
                {
                    StrikePrice val = new StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StrikePrice val) 
            { 
                this.StrikePrice = val;
            }
            
            public StrikePrice Get(StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(Fields.CustomTags.StrikePrice);
            }
            public SecurityExchange SecurityExchange
            { 
                get 
                {
                    SecurityExchange val = new SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityExchange val) 
            { 
                this.SecurityExchange = val;
            }
            
            public SecurityExchange Get(SecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityExchange val) 
            { 
                return IsSetSecurityExchange();
            }
            
            public bool IsSetSecurityExchange() 
            { 
                return IsSetField(Fields.CustomTags.SecurityExchange);
            }
            public SecurityType SecurityType
            { 
                get 
                {
                    SecurityType val = new SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityType val) 
            { 
                this.SecurityType = val;
            }
            
            public SecurityType Get(SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(Fields.CustomTags.SecurityType);
            }
            public SecuritySubType SecuritySubType
            { 
                get 
                {
                    SecuritySubType val = new SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecuritySubType val) 
            { 
                this.SecuritySubType = val;
            }
            
            public SecuritySubType Get(SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(Fields.CustomTags.SecuritySubType);
            }
            public OrderQty OrderQty
            { 
                get 
                {
                    OrderQty val = new OrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderQty val) 
            { 
                this.OrderQty = val;
            }
            
            public OrderQty Get(OrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderQty val) 
            { 
                return IsSetOrderQty();
            }
            
            public bool IsSetOrderQty() 
            { 
                return IsSetField(Fields.CustomTags.OrderQty);
            }
            public MinQty MinQty
            { 
                get 
                {
                    MinQty val = new MinQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MinQty val) 
            { 
                this.MinQty = val;
            }
            
            public MinQty Get(MinQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MinQty val) 
            { 
                return IsSetMinQty();
            }
            
            public bool IsSetMinQty() 
            { 
                return IsSetField(Fields.CustomTags.MinQty);
            }
            public DisplayQty DisplayQty
            { 
                get 
                {
                    DisplayQty val = new DisplayQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DisplayQty val) 
            { 
                this.DisplayQty = val;
            }
            
            public DisplayQty Get(DisplayQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DisplayQty val) 
            { 
                return IsSetDisplayQty();
            }
            
            public bool IsSetDisplayQty() 
            { 
                return IsSetField(Fields.CustomTags.DisplayQty);
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
            public OpenClose OpenClose
            { 
                get 
                {
                    OpenClose val = new OpenClose();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OpenClose val) 
            { 
                this.OpenClose = val;
            }
            
            public OpenClose Get(OpenClose val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OpenClose val) 
            { 
                return IsSetOpenClose();
            }
            
            public bool IsSetOpenClose() 
            { 
                return IsSetField(Fields.CustomTags.OpenClose);
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
            public ExpireDate ExpireDate
            { 
                get 
                {
                    ExpireDate val = new ExpireDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ExpireDate val) 
            { 
                this.ExpireDate = val;
            }
            
            public ExpireDate Get(ExpireDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ExpireDate val) 
            { 
                return IsSetExpireDate();
            }
            
            public bool IsSetExpireDate() 
            { 
                return IsSetField(Fields.CustomTags.ExpireDate);
            }
            public ExecInst ExecInst
            { 
                get 
                {
                    ExecInst val = new ExecInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ExecInst val) 
            { 
                this.ExecInst = val;
            }
            
            public ExecInst Get(ExecInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ExecInst val) 
            { 
                return IsSetExecInst();
            }
            
            public bool IsSetExecInst() 
            { 
                return IsSetField(Fields.CustomTags.ExecInst);
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
            public NoSecurityAltID NoSecurityAltID
            { 
                get 
                {
                    NoSecurityAltID val = new NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoSecurityAltID val) 
            { 
                this.NoSecurityAltID = val;
            }
            
            public NoSecurityAltID Get(NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(Fields.CustomTags.NoSecurityAltID);
            }
            public TextA TextA
            { 
                get 
                {
                    TextA val = new TextA();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TextA val) 
            { 
                this.TextA = val;
            }
            
            public TextA Get(TextA val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TextA val) 
            { 
                return IsSetTextA();
            }
            
            public bool IsSetTextA() 
            { 
                return IsSetField(Fields.CustomTags.TextA);
            }
            public TextB TextB
            { 
                get 
                {
                    TextB val = new TextB();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TextB val) 
            { 
                this.TextB = val;
            }
            
            public TextB Get(TextB val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TextB val) 
            { 
                return IsSetTextB();
            }
            
            public bool IsSetTextB() 
            { 
                return IsSetField(Fields.CustomTags.TextB);
            }
            public NoStrategyParameters NoStrategyParameters
            { 
                get 
                {
                    NoStrategyParameters val = new NoStrategyParameters();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoStrategyParameters val) 
            { 
                this.NoStrategyParameters = val;
            }
            
            public NoStrategyParameters Get(NoStrategyParameters val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoStrategyParameters val) 
            { 
                return IsSetNoStrategyParameters();
            }
            
            public bool IsSetNoStrategyParameters() 
            { 
                return IsSetField(Fields.CustomTags.NoStrategyParameters);
            }
            public NoPartyIDs NoPartyIDs
            { 
                get 
                {
                    NoPartyIDs val = new NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoPartyIDs val) 
            { 
                this.NoPartyIDs = val;
            }
            
            public NoPartyIDs Get(NoPartyIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoPartyIDs val) 
            { 
                return IsSetNoPartyIDs();
            }
            
            public bool IsSetNoPartyIDs() 
            { 
                return IsSetField(Fields.CustomTags.NoPartyIDs);
            }
            public HandlInst HandlInst
            { 
                get 
                {
                    HandlInst val = new HandlInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(HandlInst val) 
            { 
                this.HandlInst = val;
            }
            
            public HandlInst Get(HandlInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(HandlInst val) 
            { 
                return IsSetHandlInst();
            }
            
            public bool IsSetHandlInst() 
            { 
                return IsSetField(Fields.CustomTags.HandlInst);
            }
            public StagedOrderMsg StagedOrderMsg
            { 
                get 
                {
                    StagedOrderMsg val = new StagedOrderMsg();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StagedOrderMsg val) 
            { 
                this.StagedOrderMsg = val;
            }
            
            public StagedOrderMsg Get(StagedOrderMsg val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StagedOrderMsg val) 
            { 
                return IsSetStagedOrderMsg();
            }
            
            public bool IsSetStagedOrderMsg() 
            { 
                return IsSetField(Fields.CustomTags.StagedOrderMsg);
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
            public BracketOrderType BracketOrderType
            { 
                get 
                {
                    BracketOrderType val = new BracketOrderType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(BracketOrderType val) 
            { 
                this.BracketOrderType = val;
            }
            
            public BracketOrderType Get(BracketOrderType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(BracketOrderType val) 
            { 
                return IsSetBracketOrderType();
            }
            
            public bool IsSetBracketOrderType() 
            { 
                return IsSetField(Fields.CustomTags.BracketOrderType);
            }
            public BracketStopLimitOffset BracketStopLimitOffset
            { 
                get 
                {
                    BracketStopLimitOffset val = new BracketStopLimitOffset();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(BracketStopLimitOffset val) 
            { 
                this.BracketStopLimitOffset = val;
            }
            
            public BracketStopLimitOffset Get(BracketStopLimitOffset val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(BracketStopLimitOffset val) 
            { 
                return IsSetBracketStopLimitOffset();
            }
            
            public bool IsSetBracketStopLimitOffset() 
            { 
                return IsSetField(Fields.CustomTags.BracketStopLimitOffset);
            }
            public ChildTIF ChildTIF
            { 
                get 
                {
                    ChildTIF val = new ChildTIF();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ChildTIF val) 
            { 
                this.ChildTIF = val;
            }
            
            public ChildTIF Get(ChildTIF val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ChildTIF val) 
            { 
                return IsSetChildTIF();
            }
            
            public bool IsSetChildTIF() 
            { 
                return IsSetField(Fields.CustomTags.ChildTIF);
            }
            public DiscVal DiscVal
            { 
                get 
                {
                    DiscVal val = new DiscVal();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DiscVal val) 
            { 
                this.DiscVal = val;
            }
            
            public DiscVal Get(DiscVal val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DiscVal val) 
            { 
                return IsSetDiscVal();
            }
            
            public bool IsSetDiscVal() 
            { 
                return IsSetField(Fields.CustomTags.DiscVal);
            }
            public DiscValType DiscValType
            { 
                get 
                {
                    DiscValType val = new DiscValType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DiscValType val) 
            { 
                this.DiscValType = val;
            }
            
            public DiscValType Get(DiscValType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DiscValType val) 
            { 
                return IsSetDiscValType();
            }
            
            public bool IsSetDiscValType() 
            { 
                return IsSetField(Fields.CustomTags.DiscValType);
            }
            public ETimeAct ETimeAct
            { 
                get 
                {
                    ETimeAct val = new ETimeAct();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ETimeAct val) 
            { 
                this.ETimeAct = val;
            }
            
            public ETimeAct Get(ETimeAct val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ETimeAct val) 
            { 
                return IsSetETimeAct();
            }
            
            public bool IsSetETimeAct() 
            { 
                return IsSetField(Fields.CustomTags.ETimeAct);
            }
            public Interval Interval
            { 
                get 
                {
                    Interval val = new Interval();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Interval val) 
            { 
                this.Interval = val;
            }
            
            public Interval Get(Interval val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Interval val) 
            { 
                return IsSetInterval();
            }
            
            public bool IsSetInterval() 
            { 
                return IsSetField(Fields.CustomTags.Interval);
            }
            public IsTrlTrg IsTrlTrg
            { 
                get 
                {
                    IsTrlTrg val = new IsTrlTrg();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(IsTrlTrg val) 
            { 
                this.IsTrlTrg = val;
            }
            
            public IsTrlTrg Get(IsTrlTrg val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(IsTrlTrg val) 
            { 
                return IsSetIsTrlTrg();
            }
            
            public bool IsSetIsTrlTrg() 
            { 
                return IsSetField(Fields.CustomTags.IsTrlTrg);
            }
            public LeftoverAction LeftoverAction
            { 
                get 
                {
                    LeftoverAction val = new LeftoverAction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LeftoverAction val) 
            { 
                this.LeftoverAction = val;
            }
            
            public LeftoverAction Get(LeftoverAction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LeftoverAction val) 
            { 
                return IsSetLeftoverAction();
            }
            
            public bool IsSetLeftoverAction() 
            { 
                return IsSetField(Fields.CustomTags.LeftoverAction);
            }
            public LeftoverTicks LeftoverTicks
            { 
                get 
                {
                    LeftoverTicks val = new LeftoverTicks();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LeftoverTicks val) 
            { 
                this.LeftoverTicks = val;
            }
            
            public LeftoverTicks Get(LeftoverTicks val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LeftoverTicks val) 
            { 
                return IsSetLeftoverTicks();
            }
            
            public bool IsSetLeftoverTicks() 
            { 
                return IsSetField(Fields.CustomTags.LeftoverTicks);
            }
            public LimitPriceType LimitPriceType
            { 
                get 
                {
                    LimitPriceType val = new LimitPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LimitPriceType val) 
            { 
                this.LimitPriceType = val;
            }
            
            public LimitPriceType Get(LimitPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LimitPriceType val) 
            { 
                return IsSetLimitPriceType();
            }
            
            public bool IsSetLimitPriceType() 
            { 
                return IsSetField(Fields.CustomTags.LimitPriceType);
            }
            public LimitTicksAway LimitTicksAway
            { 
                get 
                {
                    LimitTicksAway val = new LimitTicksAway();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LimitTicksAway val) 
            { 
                this.LimitTicksAway = val;
            }
            
            public LimitTicksAway Get(LimitTicksAway val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LimitTicksAway val) 
            { 
                return IsSetLimitTicksAway();
            }
            
            public bool IsSetLimitTicksAway() 
            { 
                return IsSetField(Fields.CustomTags.LimitTicksAway);
            }
            public OcoStopTriggerPrice OcoStopTriggerPrice
            { 
                get 
                {
                    OcoStopTriggerPrice val = new OcoStopTriggerPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OcoStopTriggerPrice val) 
            { 
                this.OcoStopTriggerPrice = val;
            }
            
            public OcoStopTriggerPrice Get(OcoStopTriggerPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OcoStopTriggerPrice val) 
            { 
                return IsSetOcoStopTriggerPrice();
            }
            
            public bool IsSetOcoStopTriggerPrice() 
            { 
                return IsSetField(Fields.CustomTags.OcoStopTriggerPrice);
            }
            public ProfitTarget ProfitTarget
            { 
                get 
                {
                    ProfitTarget val = new ProfitTarget();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ProfitTarget val) 
            { 
                this.ProfitTarget = val;
            }
            
            public ProfitTarget Get(ProfitTarget val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ProfitTarget val) 
            { 
                return IsSetProfitTarget();
            }
            
            public bool IsSetProfitTarget() 
            { 
                return IsSetField(Fields.CustomTags.ProfitTarget);
            }
            public StopLimitOffset StopLimitOffset
            { 
                get 
                {
                    StopLimitOffset val = new StopLimitOffset();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StopLimitOffset val) 
            { 
                this.StopLimitOffset = val;
            }
            
            public StopLimitOffset Get(StopLimitOffset val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StopLimitOffset val) 
            { 
                return IsSetStopLimitOffset();
            }
            
            public bool IsSetStopLimitOffset() 
            { 
                return IsSetField(Fields.CustomTags.StopLimitOffset);
            }
            public StopOrderType StopOrderType
            { 
                get 
                {
                    StopOrderType val = new StopOrderType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StopOrderType val) 
            { 
                this.StopOrderType = val;
            }
            
            public StopOrderType Get(StopOrderType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StopOrderType val) 
            { 
                return IsSetStopOrderType();
            }
            
            public bool IsSetStopOrderType() 
            { 
                return IsSetField(Fields.CustomTags.StopOrderType);
            }
            public StopTarget StopTarget
            { 
                get 
                {
                    StopTarget val = new StopTarget();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StopTarget val) 
            { 
                this.StopTarget = val;
            }
            
            public StopTarget Get(StopTarget val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StopTarget val) 
            { 
                return IsSetStopTarget();
            }
            
            public bool IsSetStopTarget() 
            { 
                return IsSetField(Fields.CustomTags.StopTarget);
            }
            public TriggerPriceType TriggerPriceType
            { 
                get 
                {
                    TriggerPriceType val = new TriggerPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TriggerPriceType val) 
            { 
                this.TriggerPriceType = val;
            }
            
            public TriggerPriceType Get(TriggerPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TriggerPriceType val) 
            { 
                return IsSetTriggerPriceType();
            }
            
            public bool IsSetTriggerPriceType() 
            { 
                return IsSetField(Fields.CustomTags.TriggerPriceType);
            }
            public TriggerTicksAway TriggerTicksAway
            { 
                get 
                {
                    TriggerTicksAway val = new TriggerTicksAway();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TriggerTicksAway val) 
            { 
                this.TriggerTicksAway = val;
            }
            
            public TriggerTicksAway Get(TriggerTicksAway val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TriggerTicksAway val) 
            { 
                return IsSetTriggerTicksAway();
            }
            
            public bool IsSetTriggerTicksAway() 
            { 
                return IsSetField(Fields.CustomTags.TriggerTicksAway);
            }
            public TriggerType TriggerType
            { 
                get 
                {
                    TriggerType val = new TriggerType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TriggerType val) 
            { 
                this.TriggerType = val;
            }
            
            public TriggerType Get(TriggerType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TriggerType val) 
            { 
                return IsSetTriggerType();
            }
            
            public bool IsSetTriggerType() 
            { 
                return IsSetField(Fields.CustomTags.TriggerType);
            }
            public WithATickType WithATickType
            { 
                get 
                {
                    WithATickType val = new WithATickType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(WithATickType val) 
            { 
                this.WithATickType = val;
            }
            
            public WithATickType Get(WithATickType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(WithATickType val) 
            { 
                return IsSetWithATickType();
            }
            
            public bool IsSetWithATickType() 
            { 
                return IsSetField(Fields.CustomTags.WithATickType);
            }
            public WithATick WithATick
            { 
                get 
                {
                    WithATick val = new WithATick();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(WithATick val) 
            { 
                this.WithATick = val;
            }
            
            public WithATick Get(WithATick val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(WithATick val) 
            { 
                return IsSetWithATick();
            }
            
            public bool IsSetWithATick() 
            { 
                return IsSetField(Fields.CustomTags.WithATick);
            }
            public TriggerQtyType TriggerQtyType
            { 
                get 
                {
                    TriggerQtyType val = new TriggerQtyType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TriggerQtyType val) 
            { 
                this.TriggerQtyType = val;
            }
            
            public TriggerQtyType Get(TriggerQtyType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TriggerQtyType val) 
            { 
                return IsSetTriggerQtyType();
            }
            
            public bool IsSetTriggerQtyType() 
            { 
                return IsSetField(Fields.CustomTags.TriggerQtyType);
            }
            public TriggerQtyCompare TriggerQtyCompare
            { 
                get 
                {
                    TriggerQtyCompare val = new TriggerQtyCompare();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TriggerQtyCompare val) 
            { 
                this.TriggerQtyCompare = val;
            }
            
            public TriggerQtyCompare Get(TriggerQtyCompare val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TriggerQtyCompare val) 
            { 
                return IsSetTriggerQtyCompare();
            }
            
            public bool IsSetTriggerQtyCompare() 
            { 
                return IsSetField(Fields.CustomTags.TriggerQtyCompare);
            }
            public TriggerQty TriggerQty
            { 
                get 
                {
                    TriggerQty val = new TriggerQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TriggerQty val) 
            { 
                this.TriggerQty = val;
            }
            
            public TriggerQty Get(TriggerQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TriggerQty val) 
            { 
                return IsSetTriggerQty();
            }
            
            public bool IsSetTriggerQty() 
            { 
                return IsSetField(Fields.CustomTags.TriggerQty);
            }
            public TriggerLTPReset TriggerLTPReset
            { 
                get 
                {
                    TriggerLTPReset val = new TriggerLTPReset();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TriggerLTPReset val) 
            { 
                this.TriggerLTPReset = val;
            }
            
            public TriggerLTPReset Get(TriggerLTPReset val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TriggerLTPReset val) 
            { 
                return IsSetTriggerLTPReset();
            }
            
            public bool IsSetTriggerLTPReset() 
            { 
                return IsSetField(Fields.CustomTags.TriggerLTPReset);
            }
            public TTStopLimitPriceType TTStopLimitPriceType
            { 
                get 
                {
                    TTStopLimitPriceType val = new TTStopLimitPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopLimitPriceType val) 
            { 
                this.TTStopLimitPriceType = val;
            }
            
            public TTStopLimitPriceType Get(TTStopLimitPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopLimitPriceType val) 
            { 
                return IsSetTTStopLimitPriceType();
            }
            
            public bool IsSetTTStopLimitPriceType() 
            { 
                return IsSetField(Fields.CustomTags.TTStopLimitPriceType);
            }
            public TTStopWithATickType TTStopWithATickType
            { 
                get 
                {
                    TTStopWithATickType val = new TTStopWithATickType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopWithATickType val) 
            { 
                this.TTStopWithATickType = val;
            }
            
            public TTStopWithATickType Get(TTStopWithATickType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopWithATickType val) 
            { 
                return IsSetTTStopWithATickType();
            }
            
            public bool IsSetTTStopWithATickType() 
            { 
                return IsSetField(Fields.CustomTags.TTStopWithATickType);
            }
            public TTStopWithATick TTStopWithATick
            { 
                get 
                {
                    TTStopWithATick val = new TTStopWithATick();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopWithATick val) 
            { 
                this.TTStopWithATick = val;
            }
            
            public TTStopWithATick Get(TTStopWithATick val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopWithATick val) 
            { 
                return IsSetTTStopWithATick();
            }
            
            public bool IsSetTTStopWithATick() 
            { 
                return IsSetField(Fields.CustomTags.TTStopWithATick);
            }
            public Payup Payup
            { 
                get 
                {
                    Payup val = new Payup();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Payup val) 
            { 
                this.Payup = val;
            }
            
            public Payup Get(Payup val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Payup val) 
            { 
                return IsSetPayup();
            }
            
            public bool IsSetPayup() 
            { 
                return IsSetField(Fields.CustomTags.Payup);
            }
            public TTStopTriggerPriceType TTStopTriggerPriceType
            { 
                get 
                {
                    TTStopTriggerPriceType val = new TTStopTriggerPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopTriggerPriceType val) 
            { 
                this.TTStopTriggerPriceType = val;
            }
            
            public TTStopTriggerPriceType Get(TTStopTriggerPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopTriggerPriceType val) 
            { 
                return IsSetTTStopTriggerPriceType();
            }
            
            public bool IsSetTTStopTriggerPriceType() 
            { 
                return IsSetField(Fields.CustomTags.TTStopTriggerPriceType);
            }
            public TTStopIsTrlTrg TTStopIsTrlTrg
            { 
                get 
                {
                    TTStopIsTrlTrg val = new TTStopIsTrlTrg();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopIsTrlTrg val) 
            { 
                this.TTStopIsTrlTrg = val;
            }
            
            public TTStopIsTrlTrg Get(TTStopIsTrlTrg val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopIsTrlTrg val) 
            { 
                return IsSetTTStopIsTrlTrg();
            }
            
            public bool IsSetTTStopIsTrlTrg() 
            { 
                return IsSetField(Fields.CustomTags.TTStopIsTrlTrg);
            }
            public TTStopTriggerTicksAway TTStopTriggerTicksAway
            { 
                get 
                {
                    TTStopTriggerTicksAway val = new TTStopTriggerTicksAway();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopTriggerTicksAway val) 
            { 
                this.TTStopTriggerTicksAway = val;
            }
            
            public TTStopTriggerTicksAway Get(TTStopTriggerTicksAway val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopTriggerTicksAway val) 
            { 
                return IsSetTTStopTriggerTicksAway();
            }
            
            public bool IsSetTTStopTriggerTicksAway() 
            { 
                return IsSetField(Fields.CustomTags.TTStopTriggerTicksAway);
            }
            public TTStopTriggerQtyType TTStopTriggerQtyType
            { 
                get 
                {
                    TTStopTriggerQtyType val = new TTStopTriggerQtyType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopTriggerQtyType val) 
            { 
                this.TTStopTriggerQtyType = val;
            }
            
            public TTStopTriggerQtyType Get(TTStopTriggerQtyType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopTriggerQtyType val) 
            { 
                return IsSetTTStopTriggerQtyType();
            }
            
            public bool IsSetTTStopTriggerQtyType() 
            { 
                return IsSetField(Fields.CustomTags.TTStopTriggerQtyType);
            }
            public TTStopTriggerQTyCompare TTStopTriggerQTyCompare
            { 
                get 
                {
                    TTStopTriggerQTyCompare val = new TTStopTriggerQTyCompare();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopTriggerQTyCompare val) 
            { 
                this.TTStopTriggerQTyCompare = val;
            }
            
            public TTStopTriggerQTyCompare Get(TTStopTriggerQTyCompare val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopTriggerQTyCompare val) 
            { 
                return IsSetTTStopTriggerQTyCompare();
            }
            
            public bool IsSetTTStopTriggerQTyCompare() 
            { 
                return IsSetField(Fields.CustomTags.TTStopTriggerQTyCompare);
            }
            public TTStopTriggerQty TTStopTriggerQty
            { 
                get 
                {
                    TTStopTriggerQty val = new TTStopTriggerQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopTriggerQty val) 
            { 
                this.TTStopTriggerQty = val;
            }
            
            public TTStopTriggerQty Get(TTStopTriggerQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopTriggerQty val) 
            { 
                return IsSetTTStopTriggerQty();
            }
            
            public bool IsSetTTStopTriggerQty() 
            { 
                return IsSetField(Fields.CustomTags.TTStopTriggerQty);
            }
            public TTStopTriggerLTPReset TTStopTriggerLTPReset
            { 
                get 
                {
                    TTStopTriggerLTPReset val = new TTStopTriggerLTPReset();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopTriggerLTPReset val) 
            { 
                this.TTStopTriggerLTPReset = val;
            }
            
            public TTStopTriggerLTPReset Get(TTStopTriggerLTPReset val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopTriggerLTPReset val) 
            { 
                return IsSetTTStopTriggerLTPReset();
            }
            
            public bool IsSetTTStopTriggerLTPReset() 
            { 
                return IsSetField(Fields.CustomTags.TTStopTriggerLTPReset);
            }
            public TTStopTriggeredOrderType TTStopTriggeredOrderType
            { 
                get 
                {
                    TTStopTriggeredOrderType val = new TTStopTriggeredOrderType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopTriggeredOrderType val) 
            { 
                this.TTStopTriggeredOrderType = val;
            }
            
            public TTStopTriggeredOrderType Get(TTStopTriggeredOrderType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopTriggeredOrderType val) 
            { 
                return IsSetTTStopTriggeredOrderType();
            }
            
            public bool IsSetTTStopTriggeredOrderType() 
            { 
                return IsSetField(Fields.CustomTags.TTStopTriggeredOrderType);
            }
            public TTStopTriggeredOrderPrice TTStopTriggeredOrderPrice
            { 
                get 
                {
                    TTStopTriggeredOrderPrice val = new TTStopTriggeredOrderPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopTriggeredOrderPrice val) 
            { 
                this.TTStopTriggeredOrderPrice = val;
            }
            
            public TTStopTriggeredOrderPrice Get(TTStopTriggeredOrderPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopTriggeredOrderPrice val) 
            { 
                return IsSetTTStopTriggeredOrderPrice();
            }
            
            public bool IsSetTTStopTriggeredOrderPrice() 
            { 
                return IsSetField(Fields.CustomTags.TTStopTriggeredOrderPrice);
            }
            public TTStopLimitTicksAway TTStopLimitTicksAway
            { 
                get 
                {
                    TTStopLimitTicksAway val = new TTStopLimitTicksAway();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopLimitTicksAway val) 
            { 
                this.TTStopLimitTicksAway = val;
            }
            
            public TTStopLimitTicksAway Get(TTStopLimitTicksAway val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopLimitTicksAway val) 
            { 
                return IsSetTTStopLimitTicksAway();
            }
            
            public bool IsSetTTStopLimitTicksAway() 
            { 
                return IsSetField(Fields.CustomTags.TTStopLimitTicksAway);
            }
            public TTStopPayup TTStopPayup
            { 
                get 
                {
                    TTStopPayup val = new TTStopPayup();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopPayup val) 
            { 
                this.TTStopPayup = val;
            }
            
            public TTStopPayup Get(TTStopPayup val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopPayup val) 
            { 
                return IsSetTTStopPayup();
            }
            
            public bool IsSetTTStopPayup() 
            { 
                return IsSetField(Fields.CustomTags.TTStopPayup);
            }
            public ClearingAccountOverride ClearingAccountOverride
            { 
                get 
                {
                    ClearingAccountOverride val = new ClearingAccountOverride();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ClearingAccountOverride val) 
            { 
                this.ClearingAccountOverride = val;
            }
            
            public ClearingAccountOverride Get(ClearingAccountOverride val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ClearingAccountOverride val) 
            { 
                return IsSetClearingAccountOverride();
            }
            
            public bool IsSetClearingAccountOverride() 
            { 
                return IsSetField(Fields.CustomTags.ClearingAccountOverride);
            }
            public DropCopyOrder DropCopyOrder
            { 
                get 
                {
                    DropCopyOrder val = new DropCopyOrder();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DropCopyOrder val) 
            { 
                this.DropCopyOrder = val;
            }
            
            public DropCopyOrder Get(DropCopyOrder val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DropCopyOrder val) 
            { 
                return IsSetDropCopyOrder();
            }
            
            public bool IsSetDropCopyOrder() 
            { 
                return IsSetField(Fields.CustomTags.DropCopyOrder);
            }
            public OrderCapacity OrderCapacity
            { 
                get 
                {
                    OrderCapacity val = new OrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderCapacity val) 
            { 
                this.OrderCapacity = val;
            }
            
            public OrderCapacity Get(OrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderCapacity val) 
            { 
                return IsSetOrderCapacity();
            }
            
            public bool IsSetOrderCapacity() 
            { 
                return IsSetField(Fields.CustomTags.OrderCapacity);
            }
            public CustOrderCapacity CustOrderCapacity
            { 
                get 
                {
                    CustOrderCapacity val = new CustOrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(CustOrderCapacity val) 
            { 
                this.CustOrderCapacity = val;
            }
            
            public CustOrderCapacity Get(CustOrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(CustOrderCapacity val) 
            { 
                return IsSetCustOrderCapacity();
            }
            
            public bool IsSetCustOrderCapacity() 
            { 
                return IsSetField(Fields.CustomTags.CustOrderCapacity);
            }
            public OrderOrigination OrderOrigination
            { 
                get 
                {
                    OrderOrigination val = new OrderOrigination();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderOrigination val) 
            { 
                this.OrderOrigination = val;
            }
            
            public OrderOrigination Get(OrderOrigination val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderOrigination val) 
            { 
                return IsSetOrderOrigination();
            }
            
            public bool IsSetOrderOrigination() 
            { 
                return IsSetField(Fields.CustomTags.OrderOrigination);
            }
            public NoOrderAttributes NoOrderAttributes
            { 
                get 
                {
                    NoOrderAttributes val = new NoOrderAttributes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoOrderAttributes val) 
            { 
                this.NoOrderAttributes = val;
            }
            
            public NoOrderAttributes Get(NoOrderAttributes val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoOrderAttributes val) 
            { 
                return IsSetNoOrderAttributes();
            }
            
            public bool IsSetNoOrderAttributes() 
            { 
                return IsSetField(Fields.CustomTags.NoOrderAttributes);
            }
            public TextTT TextTT
            { 
                get 
                {
                    TextTT val = new TextTT();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TextTT val) 
            { 
                this.TextTT = val;
            }
            
            public TextTT Get(TextTT val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TextTT val) 
            { 
                return IsSetTextTT();
            }
            
            public bool IsSetTextTT() 
            { 
                return IsSetField(Fields.CustomTags.TextTT);
            }
            public TextC TextC
            { 
                get 
                {
                    TextC val = new TextC();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TextC val) 
            { 
                this.TextC = val;
            }
            
            public TextC Get(TextC val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TextC val) 
            { 
                return IsSetTextC();
            }
            
            public bool IsSetTextC() 
            { 
                return IsSetField(Fields.CustomTags.TextC);
            }
            public EchoDC_01 EchoDC_01
            { 
                get 
                {
                    EchoDC_01 val = new EchoDC_01();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_01 val) 
            { 
                this.EchoDC_01 = val;
            }
            
            public EchoDC_01 Get(EchoDC_01 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_01 val) 
            { 
                return IsSetEchoDC_01();
            }
            
            public bool IsSetEchoDC_01() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_01);
            }
            public EchoDC_02 EchoDC_02
            { 
                get 
                {
                    EchoDC_02 val = new EchoDC_02();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_02 val) 
            { 
                this.EchoDC_02 = val;
            }
            
            public EchoDC_02 Get(EchoDC_02 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_02 val) 
            { 
                return IsSetEchoDC_02();
            }
            
            public bool IsSetEchoDC_02() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_02);
            }
            public EchoDC_03 EchoDC_03
            { 
                get 
                {
                    EchoDC_03 val = new EchoDC_03();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_03 val) 
            { 
                this.EchoDC_03 = val;
            }
            
            public EchoDC_03 Get(EchoDC_03 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_03 val) 
            { 
                return IsSetEchoDC_03();
            }
            
            public bool IsSetEchoDC_03() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_03);
            }
            public EchoDC_04 EchoDC_04
            { 
                get 
                {
                    EchoDC_04 val = new EchoDC_04();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_04 val) 
            { 
                this.EchoDC_04 = val;
            }
            
            public EchoDC_04 Get(EchoDC_04 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_04 val) 
            { 
                return IsSetEchoDC_04();
            }
            
            public bool IsSetEchoDC_04() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_04);
            }
            public EchoDC_05 EchoDC_05
            { 
                get 
                {
                    EchoDC_05 val = new EchoDC_05();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_05 val) 
            { 
                this.EchoDC_05 = val;
            }
            
            public EchoDC_05 Get(EchoDC_05 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_05 val) 
            { 
                return IsSetEchoDC_05();
            }
            
            public bool IsSetEchoDC_05() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_05);
            }
            public EchoDC_06 EchoDC_06
            { 
                get 
                {
                    EchoDC_06 val = new EchoDC_06();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_06 val) 
            { 
                this.EchoDC_06 = val;
            }
            
            public EchoDC_06 Get(EchoDC_06 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_06 val) 
            { 
                return IsSetEchoDC_06();
            }
            
            public bool IsSetEchoDC_06() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_06);
            }
            public EchoDC_07 EchoDC_07
            { 
                get 
                {
                    EchoDC_07 val = new EchoDC_07();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_07 val) 
            { 
                this.EchoDC_07 = val;
            }
            
            public EchoDC_07 Get(EchoDC_07 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_07 val) 
            { 
                return IsSetEchoDC_07();
            }
            
            public bool IsSetEchoDC_07() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_07);
            }
            public EchoDC_08 EchoDC_08
            { 
                get 
                {
                    EchoDC_08 val = new EchoDC_08();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_08 val) 
            { 
                this.EchoDC_08 = val;
            }
            
            public EchoDC_08 Get(EchoDC_08 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_08 val) 
            { 
                return IsSetEchoDC_08();
            }
            
            public bool IsSetEchoDC_08() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_08);
            }
            public EchoDC_09 EchoDC_09
            { 
                get 
                {
                    EchoDC_09 val = new EchoDC_09();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_09 val) 
            { 
                this.EchoDC_09 = val;
            }
            
            public EchoDC_09 Get(EchoDC_09 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_09 val) 
            { 
                return IsSetEchoDC_09();
            }
            
            public bool IsSetEchoDC_09() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_09);
            }
            public EchoDC_10 EchoDC_10
            { 
                get 
                {
                    EchoDC_10 val = new EchoDC_10();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EchoDC_10 val) 
            { 
                this.EchoDC_10 = val;
            }
            
            public EchoDC_10 Get(EchoDC_10 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EchoDC_10 val) 
            { 
                return IsSetEchoDC_10();
            }
            
            public bool IsSetEchoDC_10() 
            { 
                return IsSetField(Fields.CustomTags.EchoDC_10);
            }
            public SelfMatchPreventionID SelfMatchPreventionID
            { 
                get 
                {
                    SelfMatchPreventionID val = new SelfMatchPreventionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SelfMatchPreventionID val) 
            { 
                this.SelfMatchPreventionID = val;
            }
            
            public SelfMatchPreventionID Get(SelfMatchPreventionID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SelfMatchPreventionID val) 
            { 
                return IsSetSelfMatchPreventionID();
            }
            
            public bool IsSetSelfMatchPreventionID() 
            { 
                return IsSetField(Fields.CustomTags.SelfMatchPreventionID);
            }
            public SMPInstruction SMPInstruction
            { 
                get 
                {
                    SMPInstruction val = new SMPInstruction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SMPInstruction val) 
            { 
                this.SMPInstruction = val;
            }
            
            public SMPInstruction Get(SMPInstruction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SMPInstruction val) 
            { 
                return IsSetSMPInstruction();
            }
            
            public bool IsSetSMPInstruction() 
            { 
                return IsSetField(Fields.CustomTags.SMPInstruction);
            }
            public Duration Duration
            { 
                get 
                {
                    Duration val = new Duration();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Duration val) 
            { 
                this.Duration = val;
            }
            
            public Duration Get(Duration val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Duration val) 
            { 
                return IsSetDuration();
            }
            
            public bool IsSetDuration() 
            { 
                return IsSetField(Fields.CustomTags.Duration);
            }
            public DurationBaseUnit DurationBaseUnit
            { 
                get 
                {
                    DurationBaseUnit val = new DurationBaseUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DurationBaseUnit val) 
            { 
                this.DurationBaseUnit = val;
            }
            
            public DurationBaseUnit Get(DurationBaseUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DurationBaseUnit val) 
            { 
                return IsSetDurationBaseUnit();
            }
            
            public bool IsSetDurationBaseUnit() 
            { 
                return IsSetField(Fields.CustomTags.DurationBaseUnit);
            }
            public DurationSTime DurationSTime
            { 
                get 
                {
                    DurationSTime val = new DurationSTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DurationSTime val) 
            { 
                this.DurationSTime = val;
            }
            
            public DurationSTime Get(DurationSTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DurationSTime val) 
            { 
                return IsSetDurationSTime();
            }
            
            public bool IsSetDurationSTime() 
            { 
                return IsSetField(Fields.CustomTags.DurationSTime);
            }
            public DurationETime DurationETime
            { 
                get 
                {
                    DurationETime val = new DurationETime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DurationETime val) 
            { 
                this.DurationETime = val;
            }
            
            public DurationETime Get(DurationETime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DurationETime val) 
            { 
                return IsSetDurationETime();
            }
            
            public bool IsSetDurationETime() 
            { 
                return IsSetField(Fields.CustomTags.DurationETime);
            }
            public CompanyID CompanyID
            { 
                get 
                {
                    CompanyID val = new CompanyID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(CompanyID val) 
            { 
                this.CompanyID = val;
            }
            
            public CompanyID Get(CompanyID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(CompanyID val) 
            { 
                return IsSetCompanyID();
            }
            
            public bool IsSetCompanyID() 
            { 
                return IsSetField(Fields.CustomTags.CompanyID);
            }
            public LeftoverTimeAction LeftoverTimeAction
            { 
                get 
                {
                    LeftoverTimeAction val = new LeftoverTimeAction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LeftoverTimeAction val) 
            { 
                this.LeftoverTimeAction = val;
            }
            
            public LeftoverTimeAction Get(LeftoverTimeAction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LeftoverTimeAction val) 
            { 
                return IsSetLeftoverTimeAction();
            }
            
            public bool IsSetLeftoverTimeAction() 
            { 
                return IsSetField(Fields.CustomTags.LeftoverTimeAction);
            }
            public AutoResubExpiredGTD AutoResubExpiredGTD
            { 
                get 
                {
                    AutoResubExpiredGTD val = new AutoResubExpiredGTD();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(AutoResubExpiredGTD val) 
            { 
                this.AutoResubExpiredGTD = val;
            }
            
            public AutoResubExpiredGTD Get(AutoResubExpiredGTD val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(AutoResubExpiredGTD val) 
            { 
                return IsSetAutoResubExpiredGTD();
            }
            
            public bool IsSetAutoResubExpiredGTD() 
            { 
                return IsSetField(Fields.CustomTags.AutoResubExpiredGTD);
            }
            public ParentTIF ParentTIF
            { 
                get 
                {
                    ParentTIF val = new ParentTIF();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ParentTIF val) 
            { 
                this.ParentTIF = val;
            }
            
            public ParentTIF Get(ParentTIF val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ParentTIF val) 
            { 
                return IsSetParentTIF();
            }
            
            public bool IsSetParentTIF() 
            { 
                return IsSetField(Fields.CustomTags.ParentTIF);
            }
            public TTStopSecondConditionIsOn TTStopSecondConditionIsOn
            { 
                get 
                {
                    TTStopSecondConditionIsOn val = new TTStopSecondConditionIsOn();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopSecondConditionIsOn val) 
            { 
                this.TTStopSecondConditionIsOn = val;
            }
            
            public TTStopSecondConditionIsOn Get(TTStopSecondConditionIsOn val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopSecondConditionIsOn val) 
            { 
                return IsSetTTStopSecondConditionIsOn();
            }
            
            public bool IsSetTTStopSecondConditionIsOn() 
            { 
                return IsSetField(Fields.CustomTags.TTStopSecondConditionIsOn);
            }
            public TTStopSecondTriggerPriceType TTStopSecondTriggerPriceType
            { 
                get 
                {
                    TTStopSecondTriggerPriceType val = new TTStopSecondTriggerPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopSecondTriggerPriceType val) 
            { 
                this.TTStopSecondTriggerPriceType = val;
            }
            
            public TTStopSecondTriggerPriceType Get(TTStopSecondTriggerPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopSecondTriggerPriceType val) 
            { 
                return IsSetTTStopSecondTriggerPriceType();
            }
            
            public bool IsSetTTStopSecondTriggerPriceType() 
            { 
                return IsSetField(Fields.CustomTags.TTStopSecondTriggerPriceType);
            }
            public TTStopSecondConditionIsTrlTrg TTStopSecondConditionIsTrlTrg
            { 
                get 
                {
                    TTStopSecondConditionIsTrlTrg val = new TTStopSecondConditionIsTrlTrg();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopSecondConditionIsTrlTrg val) 
            { 
                this.TTStopSecondConditionIsTrlTrg = val;
            }
            
            public TTStopSecondConditionIsTrlTrg Get(TTStopSecondConditionIsTrlTrg val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopSecondConditionIsTrlTrg val) 
            { 
                return IsSetTTStopSecondConditionIsTrlTrg();
            }
            
            public bool IsSetTTStopSecondConditionIsTrlTrg() 
            { 
                return IsSetField(Fields.CustomTags.TTStopSecondConditionIsTrlTrg);
            }
            public TTStopSecondTriggerTicksAway TTStopSecondTriggerTicksAway
            { 
                get 
                {
                    TTStopSecondTriggerTicksAway val = new TTStopSecondTriggerTicksAway();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopSecondTriggerTicksAway val) 
            { 
                this.TTStopSecondTriggerTicksAway = val;
            }
            
            public TTStopSecondTriggerTicksAway Get(TTStopSecondTriggerTicksAway val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopSecondTriggerTicksAway val) 
            { 
                return IsSetTTStopSecondTriggerTicksAway();
            }
            
            public bool IsSetTTStopSecondTriggerTicksAway() 
            { 
                return IsSetField(Fields.CustomTags.TTStopSecondTriggerTicksAway);
            }
            public TTStopSecondTriggerQtyType TTStopSecondTriggerQtyType
            { 
                get 
                {
                    TTStopSecondTriggerQtyType val = new TTStopSecondTriggerQtyType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopSecondTriggerQtyType val) 
            { 
                this.TTStopSecondTriggerQtyType = val;
            }
            
            public TTStopSecondTriggerQtyType Get(TTStopSecondTriggerQtyType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopSecondTriggerQtyType val) 
            { 
                return IsSetTTStopSecondTriggerQtyType();
            }
            
            public bool IsSetTTStopSecondTriggerQtyType() 
            { 
                return IsSetField(Fields.CustomTags.TTStopSecondTriggerQtyType);
            }
            public TTStopSecondTriggerQtyCompare TTStopSecondTriggerQtyCompare
            { 
                get 
                {
                    TTStopSecondTriggerQtyCompare val = new TTStopSecondTriggerQtyCompare();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopSecondTriggerQtyCompare val) 
            { 
                this.TTStopSecondTriggerQtyCompare = val;
            }
            
            public TTStopSecondTriggerQtyCompare Get(TTStopSecondTriggerQtyCompare val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopSecondTriggerQtyCompare val) 
            { 
                return IsSetTTStopSecondTriggerQtyCompare();
            }
            
            public bool IsSetTTStopSecondTriggerQtyCompare() 
            { 
                return IsSetField(Fields.CustomTags.TTStopSecondTriggerQtyCompare);
            }
            public TTStopSecondTriggerQty TTStopSecondTriggerQty
            { 
                get 
                {
                    TTStopSecondTriggerQty val = new TTStopSecondTriggerQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTStopSecondTriggerQty val) 
            { 
                this.TTStopSecondTriggerQty = val;
            }
            
            public TTStopSecondTriggerQty Get(TTStopSecondTriggerQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTStopSecondTriggerQty val) 
            { 
                return IsSetTTStopSecondTriggerQty();
            }
            
            public bool IsSetTTStopSecondTriggerQty() 
            { 
                return IsSetField(Fields.CustomTags.TTStopSecondTriggerQty);
            }
            public Variance Variance
            { 
                get 
                {
                    Variance val = new Variance();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Variance val) 
            { 
                this.Variance = val;
            }
            
            public Variance Get(Variance val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Variance val) 
            { 
                return IsSetVariance();
            }
            
            public bool IsSetVariance() 
            { 
                return IsSetField(Fields.CustomTags.Variance);
            }
            public OrderSource OrderSource
            { 
                get 
                {
                    OrderSource val = new OrderSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderSource val) 
            { 
                this.OrderSource = val;
            }
            
            public OrderSource Get(OrderSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderSource val) 
            { 
                return IsSetOrderSource();
            }
            
            public bool IsSetOrderSource() 
            { 
                return IsSetField(Fields.CustomTags.OrderSource);
            }
            public TTCustomerName TTCustomerName
            { 
                get 
                {
                    TTCustomerName val = new TTCustomerName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTCustomerName val) 
            { 
                this.TTCustomerName = val;
            }
            
            public TTCustomerName Get(TTCustomerName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTCustomerName val) 
            { 
                return IsSetTTCustomerName();
            }
            
            public bool IsSetTTCustomerName() 
            { 
                return IsSetField(Fields.CustomTags.TTCustomerName);
            }
            public NoLinks NoLinks
            { 
                get 
                {
                    NoLinks val = new NoLinks();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoLinks val) 
            { 
                this.NoLinks = val;
            }
            
            public NoLinks Get(NoLinks val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoLinks val) 
            { 
                return IsSetNoLinks();
            }
            
            public bool IsSetNoLinks() 
            { 
                return IsSetField(Fields.CustomTags.NoLinks);
            }
            public MaturityMonthYear MaturityMonthYear
            { 
                get 
                {
                    MaturityMonthYear val = new MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MaturityMonthYear val) 
            { 
                this.MaturityMonthYear = val;
            }
            
            public MaturityMonthYear Get(MaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MaturityMonthYear val) 
            { 
                return IsSetMaturityMonthYear();
            }
            
            public bool IsSetMaturityMonthYear() 
            { 
                return IsSetField(Fields.CustomTags.MaturityMonthYear);
            }
            public MaturityDate MaturityDate
            { 
                get 
                {
                    MaturityDate val = new MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MaturityDate val) 
            { 
                this.MaturityDate = val;
            }
            
            public MaturityDate Get(MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(Fields.CustomTags.MaturityDate);
            }
            public MaturityDay MaturityDay
            { 
                get 
                {
                    MaturityDay val = new MaturityDay();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MaturityDay val) 
            { 
                this.MaturityDay = val;
            }
            
            public MaturityDay Get(MaturityDay val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MaturityDay val) 
            { 
                return IsSetMaturityDay();
            }
            
            public bool IsSetMaturityDay() 
            { 
                return IsSetField(Fields.CustomTags.MaturityDay);
            }
            public PutOrCall PutOrCall
            { 
                get 
                {
                    PutOrCall val = new PutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(PutOrCall val) 
            { 
                this.PutOrCall = val;
            }
            
            public PutOrCall Get(PutOrCall val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(PutOrCall val) 
            { 
                return IsSetPutOrCall();
            }
            
            public bool IsSetPutOrCall() 
            { 
                return IsSetField(Fields.CustomTags.PutOrCall);
            }
            public OptAttribute OptAttribute
            { 
                get 
                {
                    OptAttribute val = new OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OptAttribute val) 
            { 
                this.OptAttribute = val;
            }
            
            public OptAttribute Get(OptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OptAttribute val) 
            { 
                return IsSetOptAttribute();
            }
            
            public bool IsSetOptAttribute() 
            { 
                return IsSetField(Fields.CustomTags.OptAttribute);
            }
            public SecurityID SecurityID
            { 
                get 
                {
                    SecurityID val = new SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityID val) 
            { 
                this.SecurityID = val;
            }
            
            public SecurityID Get(SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(Fields.CustomTags.SecurityID);
            }
            public ExDestination ExDestination
            { 
                get 
                {
                    ExDestination val = new ExDestination();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ExDestination val) 
            { 
                this.ExDestination = val;
            }
            
            public ExDestination Get(ExDestination val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ExDestination val) 
            { 
                return IsSetExDestination();
            }
            
            public bool IsSetExDestination() 
            { 
                return IsSetField(Fields.CustomTags.ExDestination);
            }
            public CFICode CFICode
            { 
                get 
                {
                    CFICode val = new CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(CFICode val) 
            { 
                this.CFICode = val;
            }
            
            public CFICode Get(CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(Fields.CustomTags.CFICode);
            }
            public Currency Currency
            { 
                get 
                {
                    Currency val = new Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Currency val) 
            { 
                this.Currency = val;
            }
            
            public Currency Get(Currency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Currency val) 
            { 
                return IsSetCurrency();
            }
            
            public bool IsSetCurrency() 
            { 
                return IsSetField(Fields.CustomTags.Currency);
            }
            public DeliveryTerm DeliveryTerm
            { 
                get 
                {
                    DeliveryTerm val = new DeliveryTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DeliveryTerm val) 
            { 
                this.DeliveryTerm = val;
            }
            
            public DeliveryTerm Get(DeliveryTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DeliveryTerm val) 
            { 
                return IsSetDeliveryTerm();
            }
            
            public bool IsSetDeliveryTerm() 
            { 
                return IsSetField(Fields.CustomTags.DeliveryTerm);
            }
            public DeliveryDate DeliveryDate
            { 
                get 
                {
                    DeliveryDate val = new DeliveryDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(DeliveryDate val) 
            { 
                this.DeliveryDate = val;
            }
            
            public DeliveryDate Get(DeliveryDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(DeliveryDate val) 
            { 
                return IsSetDeliveryDate();
            }
            
            public bool IsSetDeliveryDate() 
            { 
                return IsSetField(Fields.CustomTags.DeliveryDate);
            }
            public ContractYearMonth ContractYearMonth
            { 
                get 
                {
                    ContractYearMonth val = new ContractYearMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ContractYearMonth val) 
            { 
                this.ContractYearMonth = val;
            }
            
            public ContractYearMonth Get(ContractYearMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ContractYearMonth val) 
            { 
                return IsSetContractYearMonth();
            }
            
            public bool IsSetContractYearMonth() 
            { 
                return IsSetField(Fields.CustomTags.ContractYearMonth);
            }
            public IDSource IDSource
            { 
                get 
                {
                    IDSource val = new IDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(IDSource val) 
            { 
                this.IDSource = val;
            }
            
            public IDSource Get(IDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(IDSource val) 
            { 
                return IsSetIDSource();
            }
            
            public bool IsSetIDSource() 
            { 
                return IsSetField(Fields.CustomTags.IDSource);
            }
            public NoLegs NoLegs
            { 
                get 
                {
                    NoLegs val = new NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoLegs val) 
            { 
                this.NoLegs = val;
            }
            
            public NoLegs Get(NoLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoLegs val) 
            { 
                return IsSetNoLegs();
            }
            
            public bool IsSetNoLegs() 
            { 
                return IsSetField(Fields.CustomTags.NoLegs);
            }
            public LastMkt LastMkt
            { 
                get 
                {
                    LastMkt val = new LastMkt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LastMkt val) 
            { 
                this.LastMkt = val;
            }
            
            public LastMkt Get(LastMkt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LastMkt val) 
            { 
                return IsSetLastMkt();
            }
            
            public bool IsSetLastMkt() 
            { 
                return IsSetField(Fields.CustomTags.LastMkt);
            }
            public ExpireTime ExpireTime
            { 
                get 
                {
                    ExpireTime val = new ExpireTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ExpireTime val) 
            { 
                this.ExpireTime = val;
            }
            
            public ExpireTime Get(ExpireTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ExpireTime val) 
            { 
                return IsSetExpireTime();
            }
            
            public bool IsSetExpireTime() 
            { 
                return IsSetField(Fields.CustomTags.ExpireTime);
            }
            public CustOrderHandlingInst CustOrderHandlingInst
            { 
                get 
                {
                    CustOrderHandlingInst val = new CustOrderHandlingInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(CustOrderHandlingInst val) 
            { 
                this.CustOrderHandlingInst = val;
            }
            
            public CustOrderHandlingInst Get(CustOrderHandlingInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(CustOrderHandlingInst val) 
            { 
                return IsSetCustOrderHandlingInst();
            }
            
            public bool IsSetCustOrderHandlingInst() 
            { 
                return IsSetField(Fields.CustomTags.CustOrderHandlingInst);
            }
            public TTSyntheticType TTSyntheticType
            { 
                get 
                {
                    TTSyntheticType val = new TTSyntheticType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TTSyntheticType val) 
            { 
                this.TTSyntheticType = val;
            }
            
            public TTSyntheticType Get(TTSyntheticType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TTSyntheticType val) 
            { 
                return IsSetTTSyntheticType();
            }
            
            public bool IsSetTTSyntheticType() 
            { 
                return IsSetField(Fields.CustomTags.TTSyntheticType);
            }
            public Organization Organization
            { 
                get 
                {
                    Organization val = new Organization();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Organization val) 
            { 
                this.Organization = val;
            }
            
            public Organization Get(Organization val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Organization val) 
            { 
                return IsSetOrganization();
            }
            
            public bool IsSetOrganization() 
            { 
                return IsSetField(Fields.CustomTags.Organization);
            }
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.SecurityAltID, Fields.CustomTags.SecurityAltIDSource, 0};
            
                public NoSecurityAltIDGroup() 
                  :base( Fields.CustomTags.NoSecurityAltID, Fields.CustomTags.SecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public SecurityAltID SecurityAltID
                { 
                    get 
                    {
                        SecurityAltID val = new SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(SecurityAltID val) 
                { 
                    this.SecurityAltID = val;
                }
                
                public SecurityAltID Get(SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(Fields.CustomTags.SecurityAltID);
                }
                public SecurityAltIDSource SecurityAltIDSource
                { 
                    get 
                    {
                        SecurityAltIDSource val = new SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(SecurityAltIDSource val) 
                { 
                    this.SecurityAltIDSource = val;
                }
                
                public SecurityAltIDSource Get(SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(Fields.CustomTags.SecurityAltIDSource);
                }
            
            }
            public class NoStrategyParametersGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.StrategyParameterName, Fields.CustomTags.StrategyParameterType, Fields.CustomTags.StrategyParameterValue, 0};
            
                public NoStrategyParametersGroup() 
                  :base( Fields.CustomTags.NoStrategyParameters, Fields.CustomTags.StrategyParameterName, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoStrategyParametersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public StrategyParameterName StrategyParameterName
                { 
                    get 
                    {
                        StrategyParameterName val = new StrategyParameterName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(StrategyParameterName val) 
                { 
                    this.StrategyParameterName = val;
                }
                
                public StrategyParameterName Get(StrategyParameterName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(StrategyParameterName val) 
                { 
                    return IsSetStrategyParameterName();
                }
                
                public bool IsSetStrategyParameterName() 
                { 
                    return IsSetField(Fields.CustomTags.StrategyParameterName);
                }
                public StrategyParameterType StrategyParameterType
                { 
                    get 
                    {
                        StrategyParameterType val = new StrategyParameterType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(StrategyParameterType val) 
                { 
                    this.StrategyParameterType = val;
                }
                
                public StrategyParameterType Get(StrategyParameterType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(StrategyParameterType val) 
                { 
                    return IsSetStrategyParameterType();
                }
                
                public bool IsSetStrategyParameterType() 
                { 
                    return IsSetField(Fields.CustomTags.StrategyParameterType);
                }
                public StrategyParameterValue StrategyParameterValue
                { 
                    get 
                    {
                        StrategyParameterValue val = new StrategyParameterValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(StrategyParameterValue val) 
                { 
                    this.StrategyParameterValue = val;
                }
                
                public StrategyParameterValue Get(StrategyParameterValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(StrategyParameterValue val) 
                { 
                    return IsSetStrategyParameterValue();
                }
                
                public bool IsSetStrategyParameterValue() 
                { 
                    return IsSetField(Fields.CustomTags.StrategyParameterValue);
                }
            
            }
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.PartyID, Fields.CustomTags.PartyRole, Fields.CustomTags.PartyRoleQualifier, Fields.CustomTags.PartyIDSource, 0};
            
                public NoPartyIDsGroup() 
                  :base( Fields.CustomTags.NoPartyIDs, Fields.CustomTags.PartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public PartyID PartyID
                { 
                    get 
                    {
                        PartyID val = new PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(PartyID val) 
                { 
                    this.PartyID = val;
                }
                
                public PartyID Get(PartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(PartyID val) 
                { 
                    return IsSetPartyID();
                }
                
                public bool IsSetPartyID() 
                { 
                    return IsSetField(Fields.CustomTags.PartyID);
                }
                public PartyRole PartyRole
                { 
                    get 
                    {
                        PartyRole val = new PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(PartyRole val) 
                { 
                    this.PartyRole = val;
                }
                
                public PartyRole Get(PartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(PartyRole val) 
                { 
                    return IsSetPartyRole();
                }
                
                public bool IsSetPartyRole() 
                { 
                    return IsSetField(Fields.CustomTags.PartyRole);
                }
                public PartyRoleQualifier PartyRoleQualifier
                { 
                    get 
                    {
                        PartyRoleQualifier val = new PartyRoleQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(PartyRoleQualifier val) 
                { 
                    this.PartyRoleQualifier = val;
                }
                
                public PartyRoleQualifier Get(PartyRoleQualifier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(PartyRoleQualifier val) 
                { 
                    return IsSetPartyRoleQualifier();
                }
                
                public bool IsSetPartyRoleQualifier() 
                { 
                    return IsSetField(Fields.CustomTags.PartyRoleQualifier);
                }
                public PartyIDSource PartyIDSource
                { 
                    get 
                    {
                        PartyIDSource val = new PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(PartyIDSource val) 
                { 
                    this.PartyIDSource = val;
                }
                
                public PartyIDSource Get(PartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(PartyIDSource val) 
                { 
                    return IsSetPartyIDSource();
                }
                
                public bool IsSetPartyIDSource() 
                { 
                    return IsSetField(Fields.CustomTags.PartyIDSource);
                }
            
            }
            public class NoOrderAttributesGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.OrderAttributeType, Fields.CustomTags.OrderAttributeValue, 0};
            
                public NoOrderAttributesGroup() 
                  :base( Fields.CustomTags.NoOrderAttributes, Fields.CustomTags.OrderAttributeType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoOrderAttributesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public OrderAttributeType OrderAttributeType
                { 
                    get 
                    {
                        OrderAttributeType val = new OrderAttributeType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(OrderAttributeType val) 
                { 
                    this.OrderAttributeType = val;
                }
                
                public OrderAttributeType Get(OrderAttributeType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(OrderAttributeType val) 
                { 
                    return IsSetOrderAttributeType();
                }
                
                public bool IsSetOrderAttributeType() 
                { 
                    return IsSetField(Fields.CustomTags.OrderAttributeType);
                }
                public OrderAttributeValue OrderAttributeValue
                { 
                    get 
                    {
                        OrderAttributeValue val = new OrderAttributeValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(OrderAttributeValue val) 
                { 
                    this.OrderAttributeValue = val;
                }
                
                public OrderAttributeValue Get(OrderAttributeValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(OrderAttributeValue val) 
                { 
                    return IsSetOrderAttributeValue();
                }
                
                public bool IsSetOrderAttributeValue() 
                { 
                    return IsSetField(Fields.CustomTags.OrderAttributeValue);
                }
            
            }
            public class NoLinksGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.LinkID, Fields.CustomTags.LinkType, 0};
            
                public NoLinksGroup() 
                  :base( Fields.CustomTags.NoLinks, Fields.CustomTags.LinkID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLinksGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public LinkID LinkID
                { 
                    get 
                    {
                        LinkID val = new LinkID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LinkID val) 
                { 
                    this.LinkID = val;
                }
                
                public LinkID Get(LinkID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LinkID val) 
                { 
                    return IsSetLinkID();
                }
                
                public bool IsSetLinkID() 
                { 
                    return IsSetField(Fields.CustomTags.LinkID);
                }
                public LinkType LinkType
                { 
                    get 
                    {
                        LinkType val = new LinkType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LinkType val) 
                { 
                    this.LinkType = val;
                }
                
                public LinkType Get(LinkType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LinkType val) 
                { 
                    return IsSetLinkType();
                }
                
                public bool IsSetLinkType() 
                { 
                    return IsSetField(Fields.CustomTags.LinkType);
                }
            
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.LegSymbol, Fields.CustomTags.LegSecurityID, Fields.CustomTags.LegProduct, Fields.CustomTags.LegSecurityDesc, Fields.CustomTags.LegIDSource, Fields.CustomTags.LegSecurityType, Fields.CustomTags.LegSecuritySubType, Fields.CustomTags.LegMaturityMonthYear, Fields.CustomTags.LegMaturityDate, Fields.CustomTags.LegMaturityDay, Fields.CustomTags.LegStrikePrice, Fields.CustomTags.LegPutOrCall, Fields.CustomTags.LegOptAttribute, Fields.CustomTags.LegSecurityExchange, Fields.CustomTags.LegExDestination, Fields.CustomTags.LegCFICode, Fields.CustomTags.LegSide, Fields.CustomTags.LegRatioQty, Fields.CustomTags.LegCurrency, Fields.CustomTags.LegPrice, Fields.CustomTags.LegDeliveryTerm, Fields.CustomTags.LegDeliveryDate, Fields.CustomTags.LegContractYearMonth, Fields.CustomTags.NoLegSecurityAltID, 0};
            
                public NoLegsGroup() 
                  :base( Fields.CustomTags.NoLegs, Fields.CustomTags.LegSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public LegSymbol LegSymbol
                { 
                    get 
                    {
                        LegSymbol val = new LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSymbol val) 
                { 
                    this.LegSymbol = val;
                }
                
                public LegSymbol Get(LegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSymbol val) 
                { 
                    return IsSetLegSymbol();
                }
                
                public bool IsSetLegSymbol() 
                { 
                    return IsSetField(Fields.CustomTags.LegSymbol);
                }
                public LegSecurityID LegSecurityID
                { 
                    get 
                    {
                        LegSecurityID val = new LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSecurityID val) 
                { 
                    this.LegSecurityID = val;
                }
                
                public LegSecurityID Get(LegSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSecurityID val) 
                { 
                    return IsSetLegSecurityID();
                }
                
                public bool IsSetLegSecurityID() 
                { 
                    return IsSetField(Fields.CustomTags.LegSecurityID);
                }
                public LegProduct LegProduct
                { 
                    get 
                    {
                        LegProduct val = new LegProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegProduct val) 
                { 
                    this.LegProduct = val;
                }
                
                public LegProduct Get(LegProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegProduct val) 
                { 
                    return IsSetLegProduct();
                }
                
                public bool IsSetLegProduct() 
                { 
                    return IsSetField(Fields.CustomTags.LegProduct);
                }
                public LegSecurityDesc LegSecurityDesc
                { 
                    get 
                    {
                        LegSecurityDesc val = new LegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSecurityDesc val) 
                { 
                    this.LegSecurityDesc = val;
                }
                
                public LegSecurityDesc Get(LegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSecurityDesc val) 
                { 
                    return IsSetLegSecurityDesc();
                }
                
                public bool IsSetLegSecurityDesc() 
                { 
                    return IsSetField(Fields.CustomTags.LegSecurityDesc);
                }
                public LegIDSource LegIDSource
                { 
                    get 
                    {
                        LegIDSource val = new LegIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegIDSource val) 
                { 
                    this.LegIDSource = val;
                }
                
                public LegIDSource Get(LegIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegIDSource val) 
                { 
                    return IsSetLegIDSource();
                }
                
                public bool IsSetLegIDSource() 
                { 
                    return IsSetField(Fields.CustomTags.LegIDSource);
                }
                public LegSecurityType LegSecurityType
                { 
                    get 
                    {
                        LegSecurityType val = new LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSecurityType val) 
                { 
                    this.LegSecurityType = val;
                }
                
                public LegSecurityType Get(LegSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSecurityType val) 
                { 
                    return IsSetLegSecurityType();
                }
                
                public bool IsSetLegSecurityType() 
                { 
                    return IsSetField(Fields.CustomTags.LegSecurityType);
                }
                public LegSecuritySubType LegSecuritySubType
                { 
                    get 
                    {
                        LegSecuritySubType val = new LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSecuritySubType val) 
                { 
                    this.LegSecuritySubType = val;
                }
                
                public LegSecuritySubType Get(LegSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSecuritySubType val) 
                { 
                    return IsSetLegSecuritySubType();
                }
                
                public bool IsSetLegSecuritySubType() 
                { 
                    return IsSetField(Fields.CustomTags.LegSecuritySubType);
                }
                public LegMaturityMonthYear LegMaturityMonthYear
                { 
                    get 
                    {
                        LegMaturityMonthYear val = new LegMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegMaturityMonthYear val) 
                { 
                    this.LegMaturityMonthYear = val;
                }
                
                public LegMaturityMonthYear Get(LegMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegMaturityMonthYear val) 
                { 
                    return IsSetLegMaturityMonthYear();
                }
                
                public bool IsSetLegMaturityMonthYear() 
                { 
                    return IsSetField(Fields.CustomTags.LegMaturityMonthYear);
                }
                public LegMaturityDate LegMaturityDate
                { 
                    get 
                    {
                        LegMaturityDate val = new LegMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegMaturityDate val) 
                { 
                    this.LegMaturityDate = val;
                }
                
                public LegMaturityDate Get(LegMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegMaturityDate val) 
                { 
                    return IsSetLegMaturityDate();
                }
                
                public bool IsSetLegMaturityDate() 
                { 
                    return IsSetField(Fields.CustomTags.LegMaturityDate);
                }
                public LegMaturityDay LegMaturityDay
                { 
                    get 
                    {
                        LegMaturityDay val = new LegMaturityDay();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegMaturityDay val) 
                { 
                    this.LegMaturityDay = val;
                }
                
                public LegMaturityDay Get(LegMaturityDay val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegMaturityDay val) 
                { 
                    return IsSetLegMaturityDay();
                }
                
                public bool IsSetLegMaturityDay() 
                { 
                    return IsSetField(Fields.CustomTags.LegMaturityDay);
                }
                public LegStrikePrice LegStrikePrice
                { 
                    get 
                    {
                        LegStrikePrice val = new LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegStrikePrice val) 
                { 
                    this.LegStrikePrice = val;
                }
                
                public LegStrikePrice Get(LegStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegStrikePrice val) 
                { 
                    return IsSetLegStrikePrice();
                }
                
                public bool IsSetLegStrikePrice() 
                { 
                    return IsSetField(Fields.CustomTags.LegStrikePrice);
                }
                public LegPutOrCall LegPutOrCall
                { 
                    get 
                    {
                        LegPutOrCall val = new LegPutOrCall();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegPutOrCall val) 
                { 
                    this.LegPutOrCall = val;
                }
                
                public LegPutOrCall Get(LegPutOrCall val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegPutOrCall val) 
                { 
                    return IsSetLegPutOrCall();
                }
                
                public bool IsSetLegPutOrCall() 
                { 
                    return IsSetField(Fields.CustomTags.LegPutOrCall);
                }
                public LegOptAttribute LegOptAttribute
                { 
                    get 
                    {
                        LegOptAttribute val = new LegOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegOptAttribute val) 
                { 
                    this.LegOptAttribute = val;
                }
                
                public LegOptAttribute Get(LegOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegOptAttribute val) 
                { 
                    return IsSetLegOptAttribute();
                }
                
                public bool IsSetLegOptAttribute() 
                { 
                    return IsSetField(Fields.CustomTags.LegOptAttribute);
                }
                public LegSecurityExchange LegSecurityExchange
                { 
                    get 
                    {
                        LegSecurityExchange val = new LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSecurityExchange val) 
                { 
                    this.LegSecurityExchange = val;
                }
                
                public LegSecurityExchange Get(LegSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSecurityExchange val) 
                { 
                    return IsSetLegSecurityExchange();
                }
                
                public bool IsSetLegSecurityExchange() 
                { 
                    return IsSetField(Fields.CustomTags.LegSecurityExchange);
                }
                public LegExDestination LegExDestination
                { 
                    get 
                    {
                        LegExDestination val = new LegExDestination();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegExDestination val) 
                { 
                    this.LegExDestination = val;
                }
                
                public LegExDestination Get(LegExDestination val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegExDestination val) 
                { 
                    return IsSetLegExDestination();
                }
                
                public bool IsSetLegExDestination() 
                { 
                    return IsSetField(Fields.CustomTags.LegExDestination);
                }
                public LegCFICode LegCFICode
                { 
                    get 
                    {
                        LegCFICode val = new LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegCFICode val) 
                { 
                    this.LegCFICode = val;
                }
                
                public LegCFICode Get(LegCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegCFICode val) 
                { 
                    return IsSetLegCFICode();
                }
                
                public bool IsSetLegCFICode() 
                { 
                    return IsSetField(Fields.CustomTags.LegCFICode);
                }
                public LegSide LegSide
                { 
                    get 
                    {
                        LegSide val = new LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegSide val) 
                { 
                    this.LegSide = val;
                }
                
                public LegSide Get(LegSide val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegSide val) 
                { 
                    return IsSetLegSide();
                }
                
                public bool IsSetLegSide() 
                { 
                    return IsSetField(Fields.CustomTags.LegSide);
                }
                public LegRatioQty LegRatioQty
                { 
                    get 
                    {
                        LegRatioQty val = new LegRatioQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegRatioQty val) 
                { 
                    this.LegRatioQty = val;
                }
                
                public LegRatioQty Get(LegRatioQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegRatioQty val) 
                { 
                    return IsSetLegRatioQty();
                }
                
                public bool IsSetLegRatioQty() 
                { 
                    return IsSetField(Fields.CustomTags.LegRatioQty);
                }
                public LegCurrency LegCurrency
                { 
                    get 
                    {
                        LegCurrency val = new LegCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegCurrency val) 
                { 
                    this.LegCurrency = val;
                }
                
                public LegCurrency Get(LegCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegCurrency val) 
                { 
                    return IsSetLegCurrency();
                }
                
                public bool IsSetLegCurrency() 
                { 
                    return IsSetField(Fields.CustomTags.LegCurrency);
                }
                public LegPrice LegPrice
                { 
                    get 
                    {
                        LegPrice val = new LegPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegPrice val) 
                { 
                    this.LegPrice = val;
                }
                
                public LegPrice Get(LegPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegPrice val) 
                { 
                    return IsSetLegPrice();
                }
                
                public bool IsSetLegPrice() 
                { 
                    return IsSetField(Fields.CustomTags.LegPrice);
                }
                public LegDeliveryTerm LegDeliveryTerm
                { 
                    get 
                    {
                        LegDeliveryTerm val = new LegDeliveryTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegDeliveryTerm val) 
                { 
                    this.LegDeliveryTerm = val;
                }
                
                public LegDeliveryTerm Get(LegDeliveryTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegDeliveryTerm val) 
                { 
                    return IsSetLegDeliveryTerm();
                }
                
                public bool IsSetLegDeliveryTerm() 
                { 
                    return IsSetField(Fields.CustomTags.LegDeliveryTerm);
                }
                public LegDeliveryDate LegDeliveryDate
                { 
                    get 
                    {
                        LegDeliveryDate val = new LegDeliveryDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegDeliveryDate val) 
                { 
                    this.LegDeliveryDate = val;
                }
                
                public LegDeliveryDate Get(LegDeliveryDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegDeliveryDate val) 
                { 
                    return IsSetLegDeliveryDate();
                }
                
                public bool IsSetLegDeliveryDate() 
                { 
                    return IsSetField(Fields.CustomTags.LegDeliveryDate);
                }
                public LegContractYearMonth LegContractYearMonth
                { 
                    get 
                    {
                        LegContractYearMonth val = new LegContractYearMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegContractYearMonth val) 
                { 
                    this.LegContractYearMonth = val;
                }
                
                public LegContractYearMonth Get(LegContractYearMonth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegContractYearMonth val) 
                { 
                    return IsSetLegContractYearMonth();
                }
                
                public bool IsSetLegContractYearMonth() 
                { 
                    return IsSetField(Fields.CustomTags.LegContractYearMonth);
                }
                public NoLegSecurityAltID NoLegSecurityAltID
                { 
                    get 
                    {
                        NoLegSecurityAltID val = new NoLegSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(NoLegSecurityAltID val) 
                { 
                    this.NoLegSecurityAltID = val;
                }
                
                public NoLegSecurityAltID Get(NoLegSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(NoLegSecurityAltID val) 
                { 
                    return IsSetNoLegSecurityAltID();
                }
                
                public bool IsSetNoLegSecurityAltID() 
                { 
                    return IsSetField(Fields.CustomTags.NoLegSecurityAltID);
                }
                            public class NoLegSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {Fields.CustomTags.LegSecurityAltID, Fields.CustomTags.LegSecurityAltIDSource, 0};
                
                    public NoLegSecurityAltIDGroup() 
                      :base( Fields.CustomTags.NoLegSecurityAltID, Fields.CustomTags.LegSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                    public LegSecurityAltID LegSecurityAltID
                    { 
                        get 
                        {
                            LegSecurityAltID val = new LegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(LegSecurityAltID val) 
                    { 
                        this.LegSecurityAltID = val;
                    }
                    
                    public LegSecurityAltID Get(LegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(LegSecurityAltID val) 
                    { 
                        return IsSetLegSecurityAltID();
                    }
                    
                    public bool IsSetLegSecurityAltID() 
                    { 
                        return IsSetField(Fields.CustomTags.LegSecurityAltID);
                    }
                    public LegSecurityAltIDSource LegSecurityAltIDSource
                    { 
                        get 
                        {
                            LegSecurityAltIDSource val = new LegSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(LegSecurityAltIDSource val) 
                    { 
                        this.LegSecurityAltIDSource = val;
                    }
                    
                    public LegSecurityAltIDSource Get(LegSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(LegSecurityAltIDSource val) 
                    { 
                        return IsSetLegSecurityAltIDSource();
                    }
                    
                    public bool IsSetLegSecurityAltIDSource() 
                    { 
                        return IsSetField(Fields.CustomTags.LegSecurityAltIDSource);
                    }
                
                }
            }
        }
    }
}
