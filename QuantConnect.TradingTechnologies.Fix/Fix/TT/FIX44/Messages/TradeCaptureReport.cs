// This is a generated file.  Don't edit it directly!

using QuickFix;
using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class TradeCaptureReport : Message
        {
            public const string MsgType = "AE";

            public TradeCaptureReport() : base()
            {
                this.Header.SetField(new MsgType("AE"));
            }

            public TradeCaptureReport(
                    Symbol aSymbol
                ) : this()
            {
                this.Symbol = aSymbol;
            }

            public TradeReportID TradeReportID
            { 
                get 
                {
                    TradeReportID val = new TradeReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradeReportID val) 
            { 
                this.TradeReportID = val;
            }
            
            public TradeReportID Get(TradeReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradeReportID val) 
            { 
                return IsSetTradeReportID();
            }
            
            public bool IsSetTradeReportID() 
            { 
                return IsSetField(Fields.CustomTags.TradeReportID);
            }
            public ExecID ExecID
            { 
                get 
                {
                    ExecID val = new ExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ExecID val) 
            { 
                this.ExecID = val;
            }
            
            public ExecID Get(ExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ExecID val) 
            { 
                return IsSetExecID();
            }
            
            public bool IsSetExecID() 
            { 
                return IsSetField(Fields.CustomTags.ExecID);
            }
            public ExecType ExecType
            { 
                get 
                {
                    ExecType val = new ExecType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ExecType val) 
            { 
                this.ExecType = val;
            }
            
            public ExecType Get(ExecType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ExecType val) 
            { 
                return IsSetExecType();
            }
            
            public bool IsSetExecType() 
            { 
                return IsSetField(Fields.CustomTags.ExecType);
            }
            public TradeReportTransType TradeReportTransType
            { 
                get 
                {
                    TradeReportTransType val = new TradeReportTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradeReportTransType val) 
            { 
                this.TradeReportTransType = val;
            }
            
            public TradeReportTransType Get(TradeReportTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradeReportTransType val) 
            { 
                return IsSetTradeReportTransType();
            }
            
            public bool IsSetTradeReportTransType() 
            { 
                return IsSetField(Fields.CustomTags.TradeReportTransType);
            }
            public TradeReportType TradeReportType
            { 
                get 
                {
                    TradeReportType val = new TradeReportType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradeReportType val) 
            { 
                this.TradeReportType = val;
            }
            
            public TradeReportType Get(TradeReportType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradeReportType val) 
            { 
                return IsSetTradeReportType();
            }
            
            public bool IsSetTradeReportType() 
            { 
                return IsSetField(Fields.CustomTags.TradeReportType);
            }
            public TradeHandlingInstr TradeHandlingInstr
            { 
                get 
                {
                    TradeHandlingInstr val = new TradeHandlingInstr();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradeHandlingInstr val) 
            { 
                this.TradeHandlingInstr = val;
            }
            
            public TradeHandlingInstr Get(TradeHandlingInstr val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradeHandlingInstr val) 
            { 
                return IsSetTradeHandlingInstr();
            }
            
            public bool IsSetTradeHandlingInstr() 
            { 
                return IsSetField(Fields.CustomTags.TradeHandlingInstr);
            }
            public TrdType TrdType
            { 
                get 
                {
                    TrdType val = new TrdType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TrdType val) 
            { 
                this.TrdType = val;
            }
            
            public TrdType Get(TrdType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TrdType val) 
            { 
                return IsSetTrdType();
            }
            
            public bool IsSetTrdType() 
            { 
                return IsSetField(Fields.CustomTags.TrdType);
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
            public LastPx LastPx
            { 
                get 
                {
                    LastPx val = new LastPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LastPx val) 
            { 
                this.LastPx = val;
            }
            
            public LastPx Get(LastPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LastPx val) 
            { 
                return IsSetLastPx();
            }
            
            public bool IsSetLastPx() 
            { 
                return IsSetField(Fields.CustomTags.LastPx);
            }
            public LastShares LastShares
            { 
                get 
                {
                    LastShares val = new LastShares();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LastShares val) 
            { 
                this.LastShares = val;
            }
            
            public LastShares Get(LastShares val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LastShares val) 
            { 
                return IsSetLastShares();
            }
            
            public bool IsSetLastShares() 
            { 
                return IsSetField(Fields.CustomTags.LastShares);
            }
            public LeavesQty LeavesQty
            { 
                get 
                {
                    LeavesQty val = new LeavesQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LeavesQty val) 
            { 
                this.LeavesQty = val;
            }
            
            public LeavesQty Get(LeavesQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LeavesQty val) 
            { 
                return IsSetLeavesQty();
            }
            
            public bool IsSetLeavesQty() 
            { 
                return IsSetField(Fields.CustomTags.LeavesQty);
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
            public MultiLegReportingType MultiLegReportingType
            { 
                get 
                {
                    MultiLegReportingType val = new MultiLegReportingType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MultiLegReportingType val) 
            { 
                this.MultiLegReportingType = val;
            }
            
            public MultiLegReportingType Get(MultiLegReportingType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MultiLegReportingType val) 
            { 
                return IsSetMultiLegReportingType();
            }
            
            public bool IsSetMultiLegReportingType() 
            { 
                return IsSetField(Fields.CustomTags.MultiLegReportingType);
            }
            public TradeLinkID TradeLinkID
            { 
                get 
                {
                    TradeLinkID val = new TradeLinkID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradeLinkID val) 
            { 
                this.TradeLinkID = val;
            }
            
            public TradeLinkID Get(TradeLinkID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradeLinkID val) 
            { 
                return IsSetTradeLinkID();
            }
            
            public bool IsSetTradeLinkID() 
            { 
                return IsSetField(Fields.CustomTags.TradeLinkID);
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
            public TradeReportRefID TradeReportRefID
            { 
                get 
                {
                    TradeReportRefID val = new TradeReportRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradeReportRefID val) 
            { 
                this.TradeReportRefID = val;
            }
            
            public TradeReportRefID Get(TradeReportRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradeReportRefID val) 
            { 
                return IsSetTradeReportRefID();
            }
            
            public bool IsSetTradeReportRefID() 
            { 
                return IsSetField(Fields.CustomTags.TradeReportRefID);
            }
            public SecondaryTradeReportID SecondaryTradeReportID
            { 
                get 
                {
                    SecondaryTradeReportID val = new SecondaryTradeReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecondaryTradeReportID val) 
            { 
                this.SecondaryTradeReportID = val;
            }
            
            public SecondaryTradeReportID Get(SecondaryTradeReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecondaryTradeReportID val) 
            { 
                return IsSetSecondaryTradeReportID();
            }
            
            public bool IsSetSecondaryTradeReportID() 
            { 
                return IsSetField(Fields.CustomTags.SecondaryTradeReportID);
            }
            public TradeID TradeID
            { 
                get 
                {
                    TradeID val = new TradeID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradeID val) 
            { 
                this.TradeID = val;
            }
            
            public TradeID Get(TradeID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradeID val) 
            { 
                return IsSetTradeID();
            }
            
            public bool IsSetTradeID() 
            { 
                return IsSetField(Fields.CustomTags.TradeID);
            }
            public OrigTradeID OrigTradeID
            { 
                get 
                {
                    OrigTradeID val = new OrigTradeID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrigTradeID val) 
            { 
                this.OrigTradeID = val;
            }
            
            public OrigTradeID Get(OrigTradeID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrigTradeID val) 
            { 
                return IsSetOrigTradeID();
            }
            
            public bool IsSetOrigTradeID() 
            { 
                return IsSetField(Fields.CustomTags.OrigTradeID);
            }
            public TrdMatchID TrdMatchID
            { 
                get 
                {
                    TrdMatchID val = new TrdMatchID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TrdMatchID val) 
            { 
                this.TrdMatchID = val;
            }
            
            public TrdMatchID Get(TrdMatchID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TrdMatchID val) 
            { 
                return IsSetTrdMatchID();
            }
            
            public bool IsSetTrdMatchID() 
            { 
                return IsSetField(Fields.CustomTags.TrdMatchID);
            }
            public FutureReferencePrice FutureReferencePrice
            { 
                get 
                {
                    FutureReferencePrice val = new FutureReferencePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(FutureReferencePrice val) 
            { 
                this.FutureReferencePrice = val;
            }
            
            public FutureReferencePrice Get(FutureReferencePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(FutureReferencePrice val) 
            { 
                return IsSetFutureReferencePrice();
            }
            
            public bool IsSetFutureReferencePrice() 
            { 
                return IsSetField(Fields.CustomTags.FutureReferencePrice);
            }
            public TradeDate TradeDate
            { 
                get 
                {
                    TradeDate val = new TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradeDate val) 
            { 
                this.TradeDate = val;
            }
            
            public TradeDate Get(TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(Fields.CustomTags.TradeDate);
            }
            public OrigTradeDate OrigTradeDate
            { 
                get 
                {
                    OrigTradeDate val = new OrigTradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrigTradeDate val) 
            { 
                this.OrigTradeDate = val;
            }
            
            public OrigTradeDate Get(OrigTradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrigTradeDate val) 
            { 
                return IsSetOrigTradeDate();
            }
            
            public bool IsSetOrigTradeDate() 
            { 
                return IsSetField(Fields.CustomTags.OrigTradeDate);
            }
            public PreviouslyReported PreviouslyReported
            { 
                get 
                {
                    PreviouslyReported val = new PreviouslyReported();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(PreviouslyReported val) 
            { 
                this.PreviouslyReported = val;
            }
            
            public PreviouslyReported Get(PreviouslyReported val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(PreviouslyReported val) 
            { 
                return IsSetPreviouslyReported();
            }
            
            public bool IsSetPreviouslyReported() 
            { 
                return IsSetField(Fields.CustomTags.PreviouslyReported);
            }
            public TransBkdTime TransBkdTime
            { 
                get 
                {
                    TransBkdTime val = new TransBkdTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TransBkdTime val) 
            { 
                this.TransBkdTime = val;
            }
            
            public TransBkdTime Get(TransBkdTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TransBkdTime val) 
            { 
                return IsSetTransBkdTime();
            }
            
            public bool IsSetTransBkdTime() 
            { 
                return IsSetField(Fields.CustomTags.TransBkdTime);
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
            public AvgPx AvgPx
            { 
                get 
                {
                    AvgPx val = new AvgPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(AvgPx val) 
            { 
                this.AvgPx = val;
            }
            
            public AvgPx Get(AvgPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(AvgPx val) 
            { 
                return IsSetAvgPx();
            }
            
            public bool IsSetAvgPx() 
            { 
                return IsSetField(Fields.CustomTags.AvgPx);
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
            public NoSides NoSides
            { 
                get 
                {
                    NoSides val = new NoSides();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoSides val) 
            { 
                this.NoSides = val;
            }
            
            public NoSides Get(NoSides val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoSides val) 
            { 
                return IsSetNoSides();
            }
            
            public bool IsSetNoSides() 
            { 
                return IsSetField(Fields.CustomTags.NoSides);
            }
            public NoTCRLegs NoTCRLegs
            { 
                get 
                {
                    NoTCRLegs val = new NoTCRLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoTCRLegs val) 
            { 
                this.NoTCRLegs = val;
            }
            
            public NoTCRLegs Get(NoTCRLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoTCRLegs val) 
            { 
                return IsSetNoTCRLegs();
            }
            
            public bool IsSetNoTCRLegs() 
            { 
                return IsSetField(Fields.CustomTags.NoTCRLegs);
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
            public SecondaryExecID SecondaryExecID
            { 
                get 
                {
                    SecondaryExecID val = new SecondaryExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecondaryExecID val) 
            { 
                this.SecondaryExecID = val;
            }
            
            public SecondaryExecID Get(SecondaryExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecondaryExecID val) 
            { 
                return IsSetSecondaryExecID();
            }
            
            public bool IsSetSecondaryExecID() 
            { 
                return IsSetField(Fields.CustomTags.SecondaryExecID);
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
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.LegSymbol, Fields.CustomTags.LegSecurityID, Fields.CustomTags.LegSecurityDesc, Fields.CustomTags.LegProduct, Fields.CustomTags.LegIDSource, Fields.CustomTags.LegSecurityType, Fields.CustomTags.LegSecuritySubType, Fields.CustomTags.LegMaturityMonthYear, Fields.CustomTags.LegMaturityDate, Fields.CustomTags.LegMaturityDay, Fields.CustomTags.LegStrikePrice, Fields.CustomTags.LegPutOrCall, Fields.CustomTags.LegOptAttribute, Fields.CustomTags.LegSecurityExchange, Fields.CustomTags.LegExDestination, Fields.CustomTags.LegCFICode, Fields.CustomTags.LegSide, Fields.CustomTags.LegRatioQty, Fields.CustomTags.LegCurrency, Fields.CustomTags.LegPrice, Fields.CustomTags.LegDeliveryTerm, Fields.CustomTags.LegDeliveryDate, Fields.CustomTags.LegContractYearMonth, Fields.CustomTags.NoLegSecurityAltID, 0};
            
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
            public class NoSidesGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.NoPartyIDs, Fields.CustomTags.OrderID, Fields.CustomTags.OrderIDGUID, Fields.CustomTags.Account, Fields.CustomTags.Side, Fields.CustomTags.AllocQty, Fields.CustomTags.AllocPositionEffect, 0};
            
                public NoSidesGroup() 
                  :base( Fields.CustomTags.NoSides, Fields.CustomTags.NoPartyIDs, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSidesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                public AllocQty AllocQty
                { 
                    get 
                    {
                        AllocQty val = new AllocQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(AllocQty val) 
                { 
                    this.AllocQty = val;
                }
                
                public AllocQty Get(AllocQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(AllocQty val) 
                { 
                    return IsSetAllocQty();
                }
                
                public bool IsSetAllocQty() 
                { 
                    return IsSetField(Fields.CustomTags.AllocQty);
                }
                public AllocPositionEffect AllocPositionEffect
                { 
                    get 
                    {
                        AllocPositionEffect val = new AllocPositionEffect();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(AllocPositionEffect val) 
                { 
                    this.AllocPositionEffect = val;
                }
                
                public AllocPositionEffect Get(AllocPositionEffect val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(AllocPositionEffect val) 
                { 
                    return IsSetAllocPositionEffect();
                }
                
                public bool IsSetAllocPositionEffect() 
                { 
                    return IsSetField(Fields.CustomTags.AllocPositionEffect);
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
            }
            public class NoTCRLegsGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.LegLastPx, Fields.CustomTags.LegLastQty, Fields.CustomTags.NoSides, 0};
            
                public NoTCRLegsGroup() 
                  :base( Fields.CustomTags.NoTCRLegs, Fields.CustomTags.LegLastPx, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoTCRLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public LegLastPx LegLastPx
                { 
                    get 
                    {
                        LegLastPx val = new LegLastPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegLastPx val) 
                { 
                    this.LegLastPx = val;
                }
                
                public LegLastPx Get(LegLastPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegLastPx val) 
                { 
                    return IsSetLegLastPx();
                }
                
                public bool IsSetLegLastPx() 
                { 
                    return IsSetField(Fields.CustomTags.LegLastPx);
                }
                public LegLastQty LegLastQty
                { 
                    get 
                    {
                        LegLastQty val = new LegLastQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(LegLastQty val) 
                { 
                    this.LegLastQty = val;
                }
                
                public LegLastQty Get(LegLastQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(LegLastQty val) 
                { 
                    return IsSetLegLastQty();
                }
                
                public bool IsSetLegLastQty() 
                { 
                    return IsSetField(Fields.CustomTags.LegLastQty);
                }
                public NoSides NoSides
                { 
                    get 
                    {
                        NoSides val = new NoSides();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(NoSides val) 
                { 
                    this.NoSides = val;
                }
                
                public NoSides Get(NoSides val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(NoSides val) 
                { 
                    return IsSetNoSides();
                }
                
                public bool IsSetNoSides() 
                { 
                    return IsSetField(Fields.CustomTags.NoSides);
                }
                            public class NoSidesGroup : Group
                {
                    public static int[] fieldOrder = {Fields.CustomTags.OrderID, Fields.CustomTags.OrderIDGUID, Fields.CustomTags.Account, Fields.CustomTags.Side, Fields.CustomTags.AllocQty, Fields.CustomTags.AllocPositionEffect, 0};
                
                    public NoSidesGroup() 
                      :base( Fields.CustomTags.NoSides, Fields.CustomTags.OrderID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoSidesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
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
                    public AllocQty AllocQty
                    { 
                        get 
                        {
                            AllocQty val = new AllocQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(AllocQty val) 
                    { 
                        this.AllocQty = val;
                    }
                    
                    public AllocQty Get(AllocQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(AllocQty val) 
                    { 
                        return IsSetAllocQty();
                    }
                    
                    public bool IsSetAllocQty() 
                    { 
                        return IsSetField(Fields.CustomTags.AllocQty);
                    }
                    public AllocPositionEffect AllocPositionEffect
                    { 
                        get 
                        {
                            AllocPositionEffect val = new AllocPositionEffect();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(AllocPositionEffect val) 
                    { 
                        this.AllocPositionEffect = val;
                    }
                    
                    public AllocPositionEffect Get(AllocPositionEffect val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(AllocPositionEffect val) 
                    { 
                        return IsSetAllocPositionEffect();
                    }
                    
                    public bool IsSetAllocPositionEffect() 
                    { 
                        return IsSetField(Fields.CustomTags.AllocPositionEffect);
                    }
                
                }
            }
        }
    }
}
