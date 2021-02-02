// This is a generated file.  Don't edit it directly!

using QuantConnect.Fix.TT.FIX44.Fields;
namespace QuantConnect.Fix.TT.FIX44
{
    namespace Messages
    {
        public class OrderStatusRequest : Message
        {
            public const string MsgType = "H";

            public OrderStatusRequest() : base()
            {
                this.Header.SetField(new MsgType("H"));
            }


            public Account Account
            { 
                get 
                {
                    Account val = new Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(Account val) 
            { 
                this.Account = val;
            }
            
            public Account Get(Account val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(Account val) 
            { 
                return IsSetAccount();
            }
            
            public bool IsSetAccount() 
            { 
                return IsSetField(Fields.CustomTags.Account);
            }
            public ClOrdID ClOrdID
            { 
                get 
                {
                    ClOrdID val = new ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ClOrdID val) 
            { 
                this.ClOrdID = val;
            }
            
            public ClOrdID Get(ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(Fields.CustomTags.ClOrdID);
            }
            public OrderID OrderID
            { 
                get 
                {
                    OrderID val = new OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrderID val) 
            { 
                this.OrderID = val;
            }
            
            public OrderID Get(OrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrderID val) 
            { 
                return IsSetOrderID();
            }
            
            public bool IsSetOrderID() 
            { 
                return IsSetField(Fields.CustomTags.OrderID);
            }
            public CompanyID CompanyID
            { 
                get 
                {
                    CompanyID val = new CompanyID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(CompanyID val) 
            { 
                this.CompanyID = val;
            }
            
            public CompanyID Get(CompanyID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(CompanyID val) 
            { 
                return IsSetCompanyID();
            }
            
            public bool IsSetCompanyID() 
            { 
                return IsSetField(Fields.CustomTags.CompanyID);
            }
            public ClearingAccountOverride ClearingAccountOverride
            { 
                get 
                {
                    ClearingAccountOverride val = new ClearingAccountOverride();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(ClearingAccountOverride val) 
            { 
                this.ClearingAccountOverride = val;
            }
            
            public ClearingAccountOverride Get(ClearingAccountOverride val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(ClearingAccountOverride val) 
            { 
                return IsSetClearingAccountOverride();
            }
            
            public bool IsSetClearingAccountOverride() 
            { 
                return IsSetField(Fields.CustomTags.ClearingAccountOverride);
            }
            public OrdStatusReqID OrdStatusReqID
            { 
                get 
                {
                    OrdStatusReqID val = new OrdStatusReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(OrdStatusReqID val) 
            { 
                this.OrdStatusReqID = val;
            }
            
            public OrdStatusReqID Get(OrdStatusReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(OrdStatusReqID val) 
            { 
                return IsSetOrdStatusReqID();
            }
            
            public bool IsSetOrdStatusReqID() 
            { 
                return IsSetField(Fields.CustomTags.OrdStatusReqID);
            }
        }
    }
}
