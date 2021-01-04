// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class MarketDataRequestReject : Message
        {
            public const string MsgType = "Y";

            public MarketDataRequestReject() : base()
            {
                this.Header.SetField(new MsgType("Y"));
            }

            public MarketDataRequestReject(
                    MDReqID aMDReqID,
                    Text aText
                ) : this()
            {
                this.MDReqID = aMDReqID;
                this.Text = aText;
            }

            public MDReqID MDReqID
            { 
                get 
                {
                    MDReqID val = new MDReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(MDReqID val) 
            { 
                this.MDReqID = val;
            }
            
            public MDReqID Get(MDReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(MDReqID val) 
            { 
                return IsSetMDReqID();
            }
            
            public bool IsSetMDReqID() 
            { 
                return IsSetField(Fields.CustomTags.MDReqID);
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
        }
    }
}
