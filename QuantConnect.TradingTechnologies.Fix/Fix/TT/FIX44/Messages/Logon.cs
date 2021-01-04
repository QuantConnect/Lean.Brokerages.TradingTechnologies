// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class Logon : Message
        {
            public const string MsgType = "A";

            public Logon() : base()
            {
                this.Header.SetField(new MsgType("A"));
            }

            public Logon(
                    HeartBtInt aHeartBtInt
                ) : this()
            {
                this.HeartBtInt = aHeartBtInt;
            }

            public EncryptMethod EncryptMethod
            { 
                get 
                {
                    EncryptMethod val = new EncryptMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EncryptMethod val) 
            { 
                this.EncryptMethod = val;
            }
            
            public EncryptMethod Get(EncryptMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EncryptMethod val) 
            { 
                return IsSetEncryptMethod();
            }
            
            public bool IsSetEncryptMethod() 
            { 
                return IsSetField(Fields.CustomTags.EncryptMethod);
            }
            public HeartBtInt HeartBtInt
            { 
                get 
                {
                    HeartBtInt val = new HeartBtInt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(HeartBtInt val) 
            { 
                this.HeartBtInt = val;
            }
            
            public HeartBtInt Get(HeartBtInt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(HeartBtInt val) 
            { 
                return IsSetHeartBtInt();
            }
            
            public bool IsSetHeartBtInt() 
            { 
                return IsSetField(Fields.CustomTags.HeartBtInt);
            }
            public RawData RawData
            { 
                get 
                {
                    RawData val = new RawData();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(RawData val) 
            { 
                this.RawData = val;
            }
            
            public RawData Get(RawData val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(RawData val) 
            { 
                return IsSetRawData();
            }
            
            public bool IsSetRawData() 
            { 
                return IsSetField(Fields.CustomTags.RawData);
            }
            public ResetSeqNumFlag ResetSeqNumFlag
            { 
                get 
                {
                    ResetSeqNumFlag val = new ResetSeqNumFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ResetSeqNumFlag val) 
            { 
                this.ResetSeqNumFlag = val;
            }
            
            public ResetSeqNumFlag Get(ResetSeqNumFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ResetSeqNumFlag val) 
            { 
                return IsSetResetSeqNumFlag();
            }
            
            public bool IsSetResetSeqNumFlag() 
            { 
                return IsSetField(Fields.CustomTags.ResetSeqNumFlag);
            }
            public ByPassSessionRecovery ByPassSessionRecovery
            { 
                get 
                {
                    ByPassSessionRecovery val = new ByPassSessionRecovery();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ByPassSessionRecovery val) 
            { 
                this.ByPassSessionRecovery = val;
            }
            
            public ByPassSessionRecovery Get(ByPassSessionRecovery val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ByPassSessionRecovery val) 
            { 
                return IsSetByPassSessionRecovery();
            }
            
            public bool IsSetByPassSessionRecovery() 
            { 
                return IsSetField(Fields.CustomTags.ByPassSessionRecovery);
            }
            public TradingSystemName TradingSystemName
            { 
                get 
                {
                    TradingSystemName val = new TradingSystemName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradingSystemName val) 
            { 
                this.TradingSystemName = val;
            }
            
            public TradingSystemName Get(TradingSystemName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradingSystemName val) 
            { 
                return IsSetTradingSystemName();
            }
            
            public bool IsSetTradingSystemName() 
            { 
                return IsSetField(Fields.CustomTags.TradingSystemName);
            }
            public TradingSystemVersion TradingSystemVersion
            { 
                get 
                {
                    TradingSystemVersion val = new TradingSystemVersion();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradingSystemVersion val) 
            { 
                this.TradingSystemVersion = val;
            }
            
            public TradingSystemVersion Get(TradingSystemVersion val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradingSystemVersion val) 
            { 
                return IsSetTradingSystemVersion();
            }
            
            public bool IsSetTradingSystemVersion() 
            { 
                return IsSetField(Fields.CustomTags.TradingSystemVersion);
            }
            public TradingSystemVendor TradingSystemVendor
            { 
                get 
                {
                    TradingSystemVendor val = new TradingSystemVendor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TradingSystemVendor val) 
            { 
                this.TradingSystemVendor = val;
            }
            
            public TradingSystemVendor Get(TradingSystemVendor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TradingSystemVendor val) 
            { 
                return IsSetTradingSystemVendor();
            }
            
            public bool IsSetTradingSystemVendor() 
            { 
                return IsSetField(Fields.CustomTags.TradingSystemVendor);
            }
            public EncodedTextLen EncodedTextLen
            { 
                get 
                {
                    EncodedTextLen val = new EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EncodedTextLen val) 
            { 
                this.EncodedTextLen = val;
            }
            
            public EncodedTextLen Get(EncodedTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EncodedTextLen val) 
            { 
                return IsSetEncodedTextLen();
            }
            
            public bool IsSetEncodedTextLen() 
            { 
                return IsSetField(Fields.CustomTags.EncodedTextLen);
            }
            public EncodedText EncodedText
            { 
                get 
                {
                    EncodedText val = new EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EncodedText val) 
            { 
                this.EncodedText = val;
            }
            
            public EncodedText Get(EncodedText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EncodedText val) 
            { 
                return IsSetEncodedText();
            }
            
            public bool IsSetEncodedText() 
            { 
                return IsSetField(Fields.CustomTags.EncodedText);
            }
            public EncryptedPasswordMethod EncryptedPasswordMethod
            { 
                get 
                {
                    EncryptedPasswordMethod val = new EncryptedPasswordMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EncryptedPasswordMethod val) 
            { 
                this.EncryptedPasswordMethod = val;
            }
            
            public EncryptedPasswordMethod Get(EncryptedPasswordMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EncryptedPasswordMethod val) 
            { 
                return IsSetEncryptedPasswordMethod();
            }
            
            public bool IsSetEncryptedPasswordMethod() 
            { 
                return IsSetField(Fields.CustomTags.EncryptedPasswordMethod);
            }
            public EncryptedPasswordLen EncryptedPasswordLen
            { 
                get 
                {
                    EncryptedPasswordLen val = new EncryptedPasswordLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EncryptedPasswordLen val) 
            { 
                this.EncryptedPasswordLen = val;
            }
            
            public EncryptedPasswordLen Get(EncryptedPasswordLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EncryptedPasswordLen val) 
            { 
                return IsSetEncryptedPasswordLen();
            }
            
            public bool IsSetEncryptedPasswordLen() 
            { 
                return IsSetField(Fields.CustomTags.EncryptedPasswordLen);
            }
            public EncryptedPassword EncryptedPassword
            { 
                get 
                {
                    EncryptedPassword val = new EncryptedPassword();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(EncryptedPassword val) 
            { 
                this.EncryptedPassword = val;
            }
            
            public EncryptedPassword Get(EncryptedPassword val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(EncryptedPassword val) 
            { 
                return IsSetEncryptedPassword();
            }
            
            public bool IsSetEncryptedPassword() 
            { 
                return IsSetField(Fields.CustomTags.EncryptedPassword);
            }
            public UserName UserName
            { 
                get 
                {
                    UserName val = new UserName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(UserName val) 
            { 
                this.UserName = val;
            }
            
            public UserName Get(UserName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(UserName val) 
            { 
                return IsSetUserName();
            }
            
            public bool IsSetUserName() 
            { 
                return IsSetField(Fields.CustomTags.UserName);
            }
            public UserType UserType
            { 
                get 
                {
                    UserType val = new UserType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(UserType val) 
            { 
                this.UserType = val;
            }
            
            public UserType Get(UserType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(UserType val) 
            { 
                return IsSetUserType();
            }
            
            public bool IsSetUserType() 
            { 
                return IsSetField(Fields.CustomTags.UserType);
            }
            public StrategyPreference StrategyPreference
            { 
                get 
                {
                    StrategyPreference val = new StrategyPreference();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(StrategyPreference val) 
            { 
                this.StrategyPreference = val;
            }
            
            public StrategyPreference Get(StrategyPreference val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(StrategyPreference val) 
            { 
                return IsSetStrategyPreference();
            }
            
            public bool IsSetStrategyPreference() 
            { 
                return IsSetField(Fields.CustomTags.StrategyPreference);
            }
            public TimeStampPreference TimeStampPreference
            { 
                get 
                {
                    TimeStampPreference val = new TimeStampPreference();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(TimeStampPreference val) 
            { 
                this.TimeStampPreference = val;
            }
            
            public TimeStampPreference Get(TimeStampPreference val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(TimeStampPreference val) 
            { 
                return IsSetTimeStampPreference();
            }
            
            public bool IsSetTimeStampPreference() 
            { 
                return IsSetField(Fields.CustomTags.TimeStampPreference);
            }
            public PublishClearingAllocations PublishClearingAllocations
            { 
                get 
                {
                    PublishClearingAllocations val = new PublishClearingAllocations();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(PublishClearingAllocations val) 
            { 
                this.PublishClearingAllocations = val;
            }
            
            public PublishClearingAllocations Get(PublishClearingAllocations val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(PublishClearingAllocations val) 
            { 
                return IsSetPublishClearingAllocations();
            }
            
            public bool IsSetPublishClearingAllocations() 
            { 
                return IsSetField(Fields.CustomTags.PublishClearingAllocations);
            }
            public PublishMktCreationRealtime PublishMktCreationRealtime
            { 
                get 
                {
                    PublishMktCreationRealtime val = new PublishMktCreationRealtime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(PublishMktCreationRealtime val) 
            { 
                this.PublishMktCreationRealtime = val;
            }
            
            public PublishMktCreationRealtime Get(PublishMktCreationRealtime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(PublishMktCreationRealtime val) 
            { 
                return IsSetPublishMktCreationRealtime();
            }
            
            public bool IsSetPublishMktCreationRealtime() 
            { 
                return IsSetField(Fields.CustomTags.PublishMktCreationRealtime);
            }
        }
    }
}
