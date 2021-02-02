// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class XMLnonFIX : Message
        {
            public const string MsgType = "n";

            public XMLnonFIX() : base()
            {
                this.Header.SetField(new MsgType("n"));
            }

            public XMLnonFIX(
                    TargetLocationID aTargetLocationID,
                    XMLDataLen aXMLDataLen,
                    XMLData aXMLData
                ) : this()
            {
                this.TargetLocationID = aTargetLocationID;
                this.XMLDataLen = aXMLDataLen;
                this.XMLData = aXMLData;
            }

            public TargetLocationID TargetLocationID
            { 
                get 
                {
                    TargetLocationID val = new TargetLocationID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TargetLocationID val) 
            { 
                this.TargetLocationID = val;
            }
            
            public TargetLocationID Get(TargetLocationID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TargetLocationID val) 
            { 
                return IsSetTargetLocationID();
            }
            
            public bool IsSetTargetLocationID() 
            { 
                return IsSetField(Fields.CustomTags.TargetLocationID);
            }
            public XMLDataLen XMLDataLen
            { 
                get 
                {
                    XMLDataLen val = new XMLDataLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(XMLDataLen val) 
            { 
                this.XMLDataLen = val;
            }
            
            public XMLDataLen Get(XMLDataLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(XMLDataLen val) 
            { 
                return IsSetXMLDataLen();
            }
            
            public bool IsSetXMLDataLen() 
            { 
                return IsSetField(Fields.CustomTags.XMLDataLen);
            }
            public XMLData XMLData
            { 
                get 
                {
                    XMLData val = new XMLData();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(XMLData val) 
            { 
                this.XMLData = val;
            }
            
            public XMLData Get(XMLData val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(XMLData val) 
            { 
                return IsSetXMLData();
            }
            
            public bool IsSetXMLData() 
            { 
                return IsSetField(Fields.CustomTags.XMLData);
            }
        }
    }
}
