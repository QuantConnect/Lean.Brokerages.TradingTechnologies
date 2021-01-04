// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class OutOfBandRecoveryRequest : Message
        {
            public const string MsgType = "U2";

            public OutOfBandRecoveryRequest() : base()
            {
                this.Header.SetField(new MsgType("U2"));
            }

            public OutOfBandRecoveryRequest(
                    StartDate aStartDate,
                    EndDate aEndDate
                ) : this()
            {
                this.StartDate = aStartDate;
                this.EndDate = aEndDate;
            }

            public StartDate StartDate
            { 
                get 
                {
                    StartDate val = new StartDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StartDate val) 
            { 
                this.StartDate = val;
            }
            
            public StartDate Get(StartDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StartDate val) 
            { 
                return IsSetStartDate();
            }
            
            public bool IsSetStartDate() 
            { 
                return IsSetField(Fields.CustomTags.StartDate);
            }
            public EndDate EndDate
            { 
                get 
                {
                    EndDate val = new EndDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EndDate val) 
            { 
                this.EndDate = val;
            }
            
            public EndDate Get(EndDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EndDate val) 
            { 
                return IsSetEndDate();
            }
            
            public bool IsSetEndDate() 
            { 
                return IsSetField(Fields.CustomTags.EndDate);
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
        }
    }
}
