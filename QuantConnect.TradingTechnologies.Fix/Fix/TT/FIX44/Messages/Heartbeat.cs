// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class Heartbeat : Message
        {
            public const string MsgType = "0";

            public Heartbeat() : base()
            {
                this.Header.SetField(new MsgType("0"));
            }


            public TestReqID TestReqID
            { 
                get 
                {
                    TestReqID val = new TestReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TestReqID val) 
            { 
                this.TestReqID = val;
            }
            
            public TestReqID Get(TestReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TestReqID val) 
            { 
                return IsSetTestReqID();
            }
            
            public bool IsSetTestReqID() 
            { 
                return IsSetField(Fields.CustomTags.TestReqID);
            }
        }
    }
}
