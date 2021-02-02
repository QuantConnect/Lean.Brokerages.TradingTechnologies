// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class SequenceReset : Message
        {
            public const string MsgType = "4";

            public SequenceReset() : base()
            {
                this.Header.SetField(new MsgType("4"));
            }

            public SequenceReset(
                    NewSeqNo aNewSeqNo
                ) : this()
            {
                this.NewSeqNo = aNewSeqNo;
            }

            public GapFillFlag GapFillFlag
            { 
                get 
                {
                    GapFillFlag val = new GapFillFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(GapFillFlag val) 
            { 
                this.GapFillFlag = val;
            }
            
            public GapFillFlag Get(GapFillFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(GapFillFlag val) 
            { 
                return IsSetGapFillFlag();
            }
            
            public bool IsSetGapFillFlag() 
            { 
                return IsSetField(Fields.CustomTags.GapFillFlag);
            }
            public NewSeqNo NewSeqNo
            { 
                get 
                {
                    NewSeqNo val = new NewSeqNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(NewSeqNo val) 
            { 
                this.NewSeqNo = val;
            }
            
            public NewSeqNo Get(NewSeqNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(NewSeqNo val) 
            { 
                return IsSetNewSeqNo();
            }
            
            public bool IsSetNewSeqNo() 
            { 
                return IsSetField(Fields.CustomTags.NewSeqNo);
            }
        }
    }
}
