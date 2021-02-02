// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class HistoryRequest : Message
        {
            public const string MsgType = "UHR";

            public HistoryRequest() : base()
            {
                this.Header.SetField(new MsgType("UHR"));
            }

            public HistoryRequest(
                    RequestID aRequestID,
                    ClientID aClientID
                ) : this()
            {
                this.RequestID = aRequestID;
                this.ClientID = aClientID;
            }

            public RequestID RequestID
            { 
                get 
                {
                    RequestID val = new RequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(RequestID val) 
            { 
                this.RequestID = val;
            }
            
            public RequestID Get(RequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(RequestID val) 
            { 
                return IsSetRequestID();
            }
            
            public bool IsSetRequestID() 
            { 
                return IsSetField(Fields.CustomTags.RequestID);
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
        }
    }
}
