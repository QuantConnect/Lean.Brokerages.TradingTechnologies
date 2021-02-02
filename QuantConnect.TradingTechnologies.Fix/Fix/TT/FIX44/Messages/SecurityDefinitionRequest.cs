// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class SecurityDefinitionRequest : Message
        {
            public const string MsgType = "c";

            public SecurityDefinitionRequest() : base()
            {
                this.Header.SetField(new MsgType("c"));
            }

            public SecurityDefinitionRequest(
                    SecurityReqID aSecurityReqID
                ) : this()
            {
                this.SecurityReqID = aSecurityReqID;
            }

            public SecurityReqID SecurityReqID
            { 
                get 
                {
                    SecurityReqID val = new SecurityReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityReqID val) 
            { 
                this.SecurityReqID = val;
            }
            
            public SecurityReqID Get(SecurityReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityReqID val) 
            { 
                return IsSetSecurityReqID();
            }
            
            public bool IsSetSecurityReqID() 
            { 
                return IsSetField(Fields.CustomTags.SecurityReqID);
            }
            public SecurityRequestType SecurityRequestType
            { 
                get 
                {
                    SecurityRequestType val = new SecurityRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SecurityRequestType val) 
            { 
                this.SecurityRequestType = val;
            }
            
            public SecurityRequestType Get(SecurityRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SecurityRequestType val) 
            { 
                return IsSetSecurityRequestType();
            }
            
            public bool IsSetSecurityRequestType() 
            { 
                return IsSetField(Fields.CustomTags.SecurityRequestType);
            }
            public RequestTickTable RequestTickTable
            { 
                get 
                {
                    RequestTickTable val = new RequestTickTable();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(RequestTickTable val) 
            { 
                this.RequestTickTable = val;
            }
            
            public RequestTickTable Get(RequestTickTable val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(RequestTickTable val) 
            { 
                return IsSetRequestTickTable();
            }
            
            public bool IsSetRequestTickTable() 
            { 
                return IsSetField(Fields.CustomTags.RequestTickTable);
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
        }
    }
}
