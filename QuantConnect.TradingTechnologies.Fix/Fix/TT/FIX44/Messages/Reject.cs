// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class Reject : Message
        {
            public const string MsgType = "3";

            public Reject() : base()
            {
                this.Header.SetField(new MsgType("3"));
            }

            public Reject(
                    RefSeqNum aRefSeqNum
                ) : this()
            {
                this.RefSeqNum = aRefSeqNum;
            }

            public RefSeqNum RefSeqNum
            { 
                get 
                {
                    RefSeqNum val = new RefSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(RefSeqNum val) 
            { 
                this.RefSeqNum = val;
            }
            
            public RefSeqNum Get(RefSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(RefSeqNum val) 
            { 
                return IsSetRefSeqNum();
            }
            
            public bool IsSetRefSeqNum() 
            { 
                return IsSetField(Fields.CustomTags.RefSeqNum);
            }
            public RefTagID RefTagID
            { 
                get 
                {
                    RefTagID val = new RefTagID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(RefTagID val) 
            { 
                this.RefTagID = val;
            }
            
            public RefTagID Get(RefTagID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(RefTagID val) 
            { 
                return IsSetRefTagID();
            }
            
            public bool IsSetRefTagID() 
            { 
                return IsSetField(Fields.CustomTags.RefTagID);
            }
            public RefMsgType RefMsgType
            { 
                get 
                {
                    RefMsgType val = new RefMsgType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(RefMsgType val) 
            { 
                this.RefMsgType = val;
            }
            
            public RefMsgType Get(RefMsgType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(RefMsgType val) 
            { 
                return IsSetRefMsgType();
            }
            
            public bool IsSetRefMsgType() 
            { 
                return IsSetField(Fields.CustomTags.RefMsgType);
            }
            public SessionRejectReason SessionRejectReason
            { 
                get 
                {
                    SessionRejectReason val = new SessionRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(SessionRejectReason val) 
            { 
                this.SessionRejectReason = val;
            }
            
            public SessionRejectReason Get(SessionRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(SessionRejectReason val) 
            { 
                return IsSetSessionRejectReason();
            }
            
            public bool IsSetSessionRejectReason() 
            { 
                return IsSetField(Fields.CustomTags.SessionRejectReason);
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
            public StartSequenceNumber StartSequenceNumber
            { 
                get 
                {
                    StartSequenceNumber val = new StartSequenceNumber();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StartSequenceNumber val) 
            { 
                this.StartSequenceNumber = val;
            }
            
            public StartSequenceNumber Get(StartSequenceNumber val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StartSequenceNumber val) 
            { 
                return IsSetStartSequenceNumber();
            }
            
            public bool IsSetStartSequenceNumber() 
            { 
                return IsSetField(Fields.CustomTags.StartSequenceNumber);
            }
        }
    }
}
