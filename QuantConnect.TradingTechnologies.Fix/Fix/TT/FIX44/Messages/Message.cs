// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;

namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public abstract class Message : QuickFix.Message
        {
            public Message()
                : base()
            {
                this.Header.SetField(new BeginString(QuickFix.FixValues.BeginString.FIX44));
            }
        }
    }
}
