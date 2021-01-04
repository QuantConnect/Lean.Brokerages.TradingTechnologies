// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class Logout : Message
        {
            public const string MsgType = "5";

            public Logout() : base()
            {
                this.Header.SetField(new MsgType("5"));
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
            public ForceLogout ForceLogout
            { 
                get 
                {
                    ForceLogout val = new ForceLogout();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ForceLogout val) 
            { 
                this.ForceLogout = val;
            }
            
            public ForceLogout Get(ForceLogout val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ForceLogout val) 
            { 
                return IsSetForceLogout();
            }
            
            public bool IsSetForceLogout() 
            { 
                return IsSetField(Fields.CustomTags.ForceLogout);
            }
            public NextExpectedMsgSeqNum NextExpectedMsgSeqNum
            { 
                get 
                {
                    NextExpectedMsgSeqNum val = new NextExpectedMsgSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NextExpectedMsgSeqNum val) 
            { 
                this.NextExpectedMsgSeqNum = val;
            }
            
            public NextExpectedMsgSeqNum Get(NextExpectedMsgSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NextExpectedMsgSeqNum val) 
            { 
                return IsSetNextExpectedMsgSeqNum();
            }
            
            public bool IsSetNextExpectedMsgSeqNum() 
            { 
                return IsSetField(Fields.CustomTags.NextExpectedMsgSeqNum);
            }
        }
    }
}
