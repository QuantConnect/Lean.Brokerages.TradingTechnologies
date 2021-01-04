// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class News : Message
        {
            public const string MsgType = "B";

            public News() : base()
            {
                this.Header.SetField(new MsgType("B"));
            }

            public News(
                    Headline aHeadline,
                    LinesOfText aLinesOfText,
                    Text aText
                ) : this()
            {
                this.Headline = aHeadline;
                this.LinesOfText = aLinesOfText;
                this.Text = aText;
            }

            public Headline Headline
            { 
                get 
                {
                    Headline val = new Headline();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Headline val) 
            { 
                this.Headline = val;
            }
            
            public Headline Get(Headline val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Headline val) 
            { 
                return IsSetHeadline();
            }
            
            public bool IsSetHeadline() 
            { 
                return IsSetField(Fields.CustomTags.Headline);
            }
            public LinesOfText LinesOfText
            { 
                get 
                {
                    LinesOfText val = new LinesOfText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(LinesOfText val) 
            { 
                this.LinesOfText = val;
            }
            
            public LinesOfText Get(LinesOfText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(LinesOfText val) 
            { 
                return IsSetLinesOfText();
            }
            
            public bool IsSetLinesOfText() 
            { 
                return IsSetField(Fields.CustomTags.LinesOfText);
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
