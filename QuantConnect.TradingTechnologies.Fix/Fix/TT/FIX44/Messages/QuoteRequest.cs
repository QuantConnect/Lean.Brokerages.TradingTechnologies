// This is a generated file.  Don't edit it directly!

using QuickFix;
using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class QuoteRequest : Message
        {
            public const string MsgType = "R";

            public QuoteRequest() : base()
            {
                this.Header.SetField(new MsgType("R"));
            }


            public QuoteReqID QuoteReqID
            { 
                get 
                {
                    QuoteReqID val = new QuoteReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuoteReqID val) 
            { 
                this.QuoteReqID = val;
            }
            
            public QuoteReqID Get(QuoteReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuoteReqID val) 
            { 
                return IsSetQuoteReqID();
            }
            
            public bool IsSetQuoteReqID() 
            { 
                return IsSetField(Fields.CustomTags.QuoteReqID);
            }
            public NoRelatedSym NoRelatedSym
            { 
                get 
                {
                    NoRelatedSym val = new NoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NoRelatedSym val) 
            { 
                this.NoRelatedSym = val;
            }
            
            public NoRelatedSym Get(NoRelatedSym val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NoRelatedSym val) 
            { 
                return IsSetNoRelatedSym();
            }
            
            public bool IsSetNoRelatedSym() 
            { 
                return IsSetField(Fields.CustomTags.NoRelatedSym);
            }
            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {Fields.CustomTags.Symbol, Fields.CustomTags.SecurityDesc, Fields.CustomTags.Product, Fields.CustomTags.SecurityType, Fields.CustomTags.SecuritySubType, Fields.CustomTags.MaturityMonthYear, Fields.CustomTags.MaturityDate, Fields.CustomTags.MaturityDay, Fields.CustomTags.PutOrCall, Fields.CustomTags.StrikePrice, Fields.CustomTags.OptAttribute, Fields.CustomTags.DeliveryTerm, Fields.CustomTags.DeliveryDate, Fields.CustomTags.SecurityID, Fields.CustomTags.SecurityExchange, Fields.CustomTags.ExDestination, Fields.CustomTags.CFICode, Fields.CustomTags.Currency, Fields.CustomTags.QuoteType, Fields.CustomTags.Side, Fields.CustomTags.OrderQty, Fields.CustomTags.Price, 0};
            
                public NoRelatedSymGroup() 
                  :base( Fields.CustomTags.NoRelatedSym, Fields.CustomTags.Symbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRelatedSymGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                public QuoteType QuoteType
                { 
                    get 
                    {
                        QuoteType val = new QuoteType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuoteType val) 
                { 
                    this.QuoteType = val;
                }
                
                public QuoteType Get(QuoteType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuoteType val) 
                { 
                    return IsSetQuoteType();
                }
                
                public bool IsSetQuoteType() 
                { 
                    return IsSetField(Fields.CustomTags.QuoteType);
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
            
            }
        }
    }
}
