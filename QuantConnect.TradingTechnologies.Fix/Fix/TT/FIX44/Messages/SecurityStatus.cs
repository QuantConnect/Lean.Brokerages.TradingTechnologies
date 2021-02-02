// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
using CFICode = QuickFix.Fields.CFICode;
using Currency = QuickFix.Fields.Currency;
using DeliveryDate = QuickFix.Fields.DeliveryDate;
using ExDestination = QuickFix.Fields.ExDestination;
using MaturityDate = QuickFix.Fields.MaturityDate;
using MaturityDay = QuickFix.Fields.MaturityDay;
using MaturityMonthYear = QuickFix.Fields.MaturityMonthYear;
using MsgType = QuickFix.Fields.MsgType;
using OptAttribute = QuickFix.Fields.OptAttribute;
using Product = QuickFix.Fields.Product;
using PutOrCall = QuickFix.Fields.PutOrCall;
using SecurityDesc = QuickFix.Fields.SecurityDesc;
using SecurityExchange = QuickFix.Fields.SecurityExchange;
using SecurityID = QuickFix.Fields.SecurityID;
using SecurityStatusReqID = QuickFix.Fields.SecurityStatusReqID;
using SecuritySubType = QuickFix.Fields.SecuritySubType;
using SecurityTradingStatus = QuickFix.Fields.SecurityTradingStatus;
using SecurityType = QuickFix.Fields.SecurityType;
using StrikePrice = QuickFix.Fields.StrikePrice;
using Symbol = QuickFix.Fields.Symbol;
using Text = QuickFix.Fields.Text;

namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class SecurityStatus : Message
        {
            public const string MsgType = "f";

            public SecurityStatus() : base()
            {
                this.Header.SetField(new MsgType("f"));
            }

            public SecurityStatus(
                    SecurityStatusReqID aSecurityStatusReqID,
                    SecurityTradingStatus aSecurityTradingStatus
                ) : this()
            {
                this.SecurityStatusReqID = aSecurityStatusReqID;
                this.SecurityTradingStatus = aSecurityTradingStatus;
            }

            public SecurityStatusReqID SecurityStatusReqID
            { 
                get 
                {
                    SecurityStatusReqID val = new SecurityStatusReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityStatusReqID val) 
            { 
                this.SecurityStatusReqID = val;
            }
            
            public SecurityStatusReqID Get(SecurityStatusReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityStatusReqID val) 
            { 
                return IsSetSecurityStatusReqID();
            }
            
            public bool IsSetSecurityStatusReqID() 
            { 
                return IsSetField(Fields.CustomTags.SecurityStatusReqID);
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
            public SecurityTradingStatus SecurityTradingStatus
            { 
                get 
                {
                    SecurityTradingStatus val = new SecurityTradingStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityTradingStatus val) 
            { 
                this.SecurityTradingStatus = val;
            }
            
            public SecurityTradingStatus Get(SecurityTradingStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityTradingStatus val) 
            { 
                return IsSetSecurityTradingStatus();
            }
            
            public bool IsSetSecurityTradingStatus() 
            { 
                return IsSetField(Fields.CustomTags.SecurityTradingStatus);
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
        }
    }
}
