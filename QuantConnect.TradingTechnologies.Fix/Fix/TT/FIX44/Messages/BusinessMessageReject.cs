// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class BusinessMessageReject : Message
        {
            public const string MsgType = "j";

            public BusinessMessageReject() : base()
            {
                this.Header.SetField(new MsgType("j"));
            }

            public BusinessMessageReject(
                    RefMsgType aRefMsgType,
                    BusinessRejectReason aBusinessRejectReason
                ) : this()
            {
                this.RefMsgType = aRefMsgType;
                this.BusinessRejectReason = aBusinessRejectReason;
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
            public BusinessRejectRefID BusinessRejectRefID
            { 
                get 
                {
                    BusinessRejectRefID val = new BusinessRejectRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(BusinessRejectRefID val) 
            { 
                this.BusinessRejectRefID = val;
            }
            
            public BusinessRejectRefID Get(BusinessRejectRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(BusinessRejectRefID val) 
            { 
                return IsSetBusinessRejectRefID();
            }
            
            public bool IsSetBusinessRejectRefID() 
            { 
                return IsSetField(Fields.CustomTags.BusinessRejectRefID);
            }
            public BusinessRejectReason BusinessRejectReason
            { 
                get 
                {
                    BusinessRejectReason val = new BusinessRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(BusinessRejectReason val) 
            { 
                this.BusinessRejectReason = val;
            }
            
            public BusinessRejectReason Get(BusinessRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(BusinessRejectReason val) 
            { 
                return IsSetBusinessRejectReason();
            }
            
            public bool IsSetBusinessRejectReason() 
            { 
                return IsSetField(Fields.CustomTags.BusinessRejectReason);
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
