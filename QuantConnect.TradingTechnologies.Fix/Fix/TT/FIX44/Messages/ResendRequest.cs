// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class ResendRequest : Message
        {
            public const string MsgType = "2";

            public ResendRequest() : base()
            {
                this.Header.SetField(new MsgType("2"));
            }

            public ResendRequest(
                    BeginSeqNo aBeginSeqNo,
                    EndSeqNo aEndSeqNo
                ) : this()
            {
                this.BeginSeqNo = aBeginSeqNo;
                this.EndSeqNo = aEndSeqNo;
            }

            public BeginSeqNo BeginSeqNo
            { 
                get 
                {
                    BeginSeqNo val = new BeginSeqNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(BeginSeqNo val) 
            { 
                this.BeginSeqNo = val;
            }
            
            public BeginSeqNo Get(BeginSeqNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(BeginSeqNo val) 
            { 
                return IsSetBeginSeqNo();
            }
            
            public bool IsSetBeginSeqNo() 
            { 
                return IsSetField(Fields.CustomTags.BeginSeqNo);
            }
            public EndSeqNo EndSeqNo
            { 
                get 
                {
                    EndSeqNo val = new EndSeqNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EndSeqNo val) 
            { 
                this.EndSeqNo = val;
            }
            
            public EndSeqNo Get(EndSeqNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EndSeqNo val) 
            { 
                return IsSetEndSeqNo();
            }
            
            public bool IsSetEndSeqNo() 
            { 
                return IsSetField(Fields.CustomTags.EndSeqNo);
            }
        }
    }
}
