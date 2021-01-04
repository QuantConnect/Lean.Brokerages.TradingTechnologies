// This is a generated file.  Don't edit it directly!

using System;
using QuantConnect.Fix.TT.FIX44.Fields;

namespace QuantConnect.Fix.TT.FIX44.Fields
{
    /// <summary>
    /// Account Field
    /// </summary>/
    public sealed class Account : QuickFix.Fields.StringField
    {
        public Account()
            :base(Fields.CustomTags.Account) {}
        public Account(string val)
            :base(Fields.CustomTags.Account, val) {}

    }


    /// <summary>
    /// AdvId Field
    /// </summary>/
    public sealed class AdvId : QuickFix.Fields.StringField
    {
        public AdvId()
            :base(Fields.CustomTags.AdvId) {}
        public AdvId(string val)
            :base(Fields.CustomTags.AdvId, val) {}

    }


    /// <summary>
    /// AdvRefID Field
    /// </summary>/
    public sealed class AdvRefID : QuickFix.Fields.StringField
    {
        public AdvRefID()
            :base(Fields.CustomTags.AdvRefID) {}
        public AdvRefID(string val)
            :base(Fields.CustomTags.AdvRefID, val) {}

    }


    /// <summary>
    /// AdvSide Field
    /// </summary>/
    public sealed class AdvSide : QuickFix.Fields.CharField
    {
        public AdvSide()
            :base(Fields.CustomTags.AdvSide) {}
        public AdvSide(char val)
            :base(Fields.CustomTags.AdvSide, val) {}


        // Field Enumerations
        public const char BUY = 'B';
        public const char SELL = 'S';
        public const char TRADE = 'T';
        public const char CROSS = 'X';
    }


    /// <summary>
    /// AdvTransType Field
    /// </summary>/
    public sealed class AdvTransType : QuickFix.Fields.StringField
    {
        public AdvTransType()
            :base(Fields.CustomTags.AdvTransType) {}
        public AdvTransType(string val)
            :base(Fields.CustomTags.AdvTransType, val) {}


        // Field Enumerations
        public const string CANCEL = "C";
        public const string NEW = "N";
        public const string REPLACE = "R";
    }


    /// <summary>
    /// AvgPx Field
    /// </summary>/
    public sealed class AvgPx : QuickFix.Fields.DecimalField
    {
        public AvgPx()
            :base(Fields.CustomTags.AvgPx) {}
        public AvgPx(Decimal val)
            :base(Fields.CustomTags.AvgPx, val) {}

    }


    /// <summary>
    /// BeginSeqNo Field
    /// </summary>/
    public sealed class BeginSeqNo : QuickFix.Fields.IntField
    {
        public BeginSeqNo()
            :base(Fields.CustomTags.BeginSeqNo) {}
        public BeginSeqNo(int val)
            :base(Fields.CustomTags.BeginSeqNo, val) {}

    }


    /// <summary>
    /// BeginString Field
    /// </summary>/
    public sealed class BeginString : QuickFix.Fields.StringField
    {
        public BeginString()
            :base(Fields.CustomTags.BeginString) {}
        public BeginString(string val)
            :base(Fields.CustomTags.BeginString, val) {}

    }


    /// <summary>
    /// BodyLength Field
    /// </summary>/
    public sealed class BodyLength : QuickFix.Fields.IntField
    {
        public BodyLength()
            :base(Fields.CustomTags.BodyLength) {}
        public BodyLength(int val)
            :base(Fields.CustomTags.BodyLength, val) {}

    }


    /// <summary>
    /// CheckSum Field
    /// </summary>/
    public sealed class CheckSum : QuickFix.Fields.StringField
    {
        public CheckSum()
            :base(Fields.CustomTags.CheckSum) {}
        public CheckSum(string val)
            :base(Fields.CustomTags.CheckSum, val) {}

    }


    /// <summary>
    /// ClOrdID Field
    /// </summary>/
    public sealed class ClOrdID : QuickFix.Fields.StringField
    {
        public ClOrdID()
            :base(Fields.CustomTags.ClOrdID) {}
        public ClOrdID(string val)
            :base(Fields.CustomTags.ClOrdID, val) {}

    }


    /// <summary>
    /// Commission Field
    /// </summary>/
    public sealed class Commission : QuickFix.Fields.DecimalField
    {
        public Commission()
            :base(Fields.CustomTags.Commission) {}
        public Commission(Decimal val)
            :base(Fields.CustomTags.Commission, val) {}

    }


    /// <summary>
    /// CommType Field
    /// </summary>/
    public sealed class CommType : QuickFix.Fields.CharField
    {
        public CommType()
            :base(Fields.CustomTags.CommType) {}
        public CommType(char val)
            :base(Fields.CustomTags.CommType, val) {}


        // Field Enumerations
        public const char PER_UNIT = '1';
        public const char PERCENT = '2';
        public const char ABSOLUTE = '3';
        public const char PERCENTAGE_WAIVED_4 = '4';
        public const char PERCENTAGE_WAIVED_5 = '5';
        public const char POINTS_PER_BOND_OR_CONTRACT = '6';
        public const char PER_SHARE = '1';
        public const char PERCENTAGE = '2';
        public const char PERCENTAGE_WAIVED_CASH_DISCOUNT = '4';
        public const char PERCENTAGE_WAIVED_ENHANCED_UNITS = '5';
        public const char PER_BOND = '6';
    }


    /// <summary>
    /// CumQty Field
    /// </summary>/
    public sealed class CumQty : QuickFix.Fields.DecimalField
    {
        public CumQty()
            :base(Fields.CustomTags.CumQty) {}
        public CumQty(Decimal val)
            :base(Fields.CustomTags.CumQty, val) {}

    }


    /// <summary>
    /// Currency Field
    /// </summary>/
    public sealed class Currency : QuickFix.Fields.StringField
    {
        public Currency()
            :base(Fields.CustomTags.Currency) {}
        public Currency(string val)
            :base(Fields.CustomTags.Currency, val) {}

    }


    /// <summary>
    /// EndSeqNo Field
    /// </summary>/
    public sealed class EndSeqNo : QuickFix.Fields.IntField
    {
        public EndSeqNo()
            :base(Fields.CustomTags.EndSeqNo) {}
        public EndSeqNo(int val)
            :base(Fields.CustomTags.EndSeqNo, val) {}

    }


    /// <summary>
    /// ExecID Field
    /// </summary>/
    public sealed class ExecID : QuickFix.Fields.StringField
    {
        public ExecID()
            :base(Fields.CustomTags.ExecID) {}
        public ExecID(string val)
            :base(Fields.CustomTags.ExecID, val) {}

    }


    /// <summary>
    /// ExecInst Field
    /// </summary>/
    public sealed class ExecInst : QuickFix.Fields.StringField
    {
        public ExecInst()
            :base(Fields.CustomTags.ExecInst) {}
        public ExecInst(string val)
            :base(Fields.CustomTags.ExecInst, val) {}


        // Field Enumerations
        public const string STAY_ON_OFFER_SIDE = "0";
        public const string NOT_HELD = "1";
        public const string WORK = "2";
        public const string GO_ALONG = "3";
        public const string OVER_THE_DAY = "4";
        public const string HELD = "5";
        public const string PARTICIPANT_DONT_INITIATE = "6";
        public const string STRICT_SCALE = "7";
        public const string TRY_TO_SCALE = "8";
        public const string STAY_ON_BID_SIDE = "9";
        public const string NO_CROSS = "A";
        public const string TRAILING_STOP_PEG = "a";
        public const string OK_TO_CROSS = "B";
        public const string STRICT_LIMIT = "b";
        public const string IGNORE_PRICE_VALIDITY_CHECKS = "c";
        public const string CALL_FIRST = "C";
        public const string PEG_TO_LIMIT_PRICE = "d";
        public const string PERCENT_OF_VOLUME = "D";
        public const string DO_NOT_INCREASE = "E";
        public const string WORK_TO_TARGET_STRATEGY = "e";
        public const string DO_NOT_REDUCE = "F";
        public const string ALL_OR_NONE = "G";
        public const string REINSTATE_ON_SYSTEM_FAILURE = "H";
        public const string INSTITUTIONS_ONLY = "I";
        public const string REINSTATE_ON_TRADING_HALT = "J";
        public const string CANCEL_ON_TRADING_HALT = "K";
        public const string LAST_PEG = "L";
        public const string MID_PRICE_PEG = "M";
        public const string NON_NEGOTIABLE = "N";
        public const string OPENING_PEG = "O";
        public const string MARKET_PEG = "P";
        public const string CANCEL_ON_SYSTEM_FAILURE = "Q";
        public const string PRIMARY_PEG = "R";
        public const string SUSPEND = "S";
        public const string CUSTOMER_DISPLAY_INSTRUCTION = "U";
        public const string NETTING = "V";
        public const string PEG_TO_VWAP = "W";
        public const string TRADE_ALONG = "X";
        public const string TRY_TO_STOP = "Y";
        public const string CANCEL_IF_NOT_BEST = "Z";
        public const string INTERMARKET_SWEEP = "f";
        public const string SINGLE_EXECUTION_REQUESTED_FOR_BLOCK_TRADE = "j";
        public const string EXTERNAL_ROUTING_ALLOWED = "g";
        public const string EXTERNAL_ROUTING_NOT_ALLOWED = "h";
        public const string IMBALANCE_ONLY = "i";
        public const string FIXED_PEG_TO_LOCAL_BEST_BID_OR_OFFER_AT_TIME_OF_ORDER = "T";
        public const string BEST_EXECUTION = "k";
        public const string SUSPEND_ON_SYSTEM_FAILURE = "l";
        public const string SUSPEND_ON_TRADING_HALT = "m";
        public const string REINSTATE_ON_CONNECTION_LOSS = "n";
        public const string CANCEL_ON_CONNECTION_LOSS = "o";
        public const string SUSPEND_ON_CONNECTION_LOSS = "p";
        public const string RELEASE_FROM_SUSPENSION = "q";
        public const string EXECUTE_AS_DELTA_NEUTRAL_USING_VOLATILITY_PROVIDED = "r";
        public const string EXECUTE_AS_DURATION_NEUTRAL = "s";
        public const string EXECUTE_AS_FX_NEUTRAL = "t";
        public const string REINSTATE_ON_SYSTEM_FAILUE = "H";
        public const string PARTICIPATE_DONT_INITIATE = "6";
        public const string TEST_REQUEST = "X";
        public const string STAY_ON_BIDSIDE = "9";
        public const string STAY_ON_OFFERSIDE = "0";
        public const string FIXED_PEG = "T";
        public const string DO_NOT_INCREASE_DNI = "E";
        public const string DO_NOT_REDUCE_DNR = "F";
        public const string ALL_OR_NONE_AON = "G";
        public const string MIDPRICE_PEG = "M";
        public const string NONNEGOTIABLE = "N";
    }


    /// <summary>
    /// ExecRefID Field
    /// </summary>/
    public sealed class ExecRefID : QuickFix.Fields.StringField
    {
        public ExecRefID()
            :base(Fields.CustomTags.ExecRefID) {}
        public ExecRefID(string val)
            :base(Fields.CustomTags.ExecRefID, val) {}

    }


    /// <summary>
    /// ExecTransType Field
    /// </summary>/
    public sealed class ExecTransType : QuickFix.Fields.CharField
    {
        public ExecTransType()
            :base(Fields.CustomTags.ExecTransType) {}
        public ExecTransType(char val)
            :base(Fields.CustomTags.ExecTransType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char CANCEL = '1';
        public const char CORRECT = '2';
        public const char STATUS = '3';
    }


    /// <summary>
    /// HandlInst Field
    /// </summary>/
    public sealed class HandlInst : QuickFix.Fields.CharField
    {
        public HandlInst()
            :base(Fields.CustomTags.HandlInst) {}
        public HandlInst(char val)
            :base(Fields.CustomTags.HandlInst, val) {}


        // Field Enumerations
        public const char AUTOMATED_EXECUTION_ORDER_PRIVATE_NO_BROKER_INTERVENTION = '1';
        public const char AUTOMATED_EXECUTION_ORDER_PUBLIC_BROKER_INTERVENTION_OK = '2';
        public const char MANUAL_ORDER_BEST_EXECUTION = '3';
        public const char AUTOMATED_EXECUTION_ORDER_PRIVATE = '1';
        public const char AUTOMATED_EXECUTION_ORDER_PUBLIC = '2';
        public const char MANUAL_ORDER = '3';
    }


    /// <summary>
    /// IDSource Field
    /// </summary>/
    public sealed class IDSource : QuickFix.Fields.StringField
    {
        public IDSource()
            :base(Fields.CustomTags.IDSource) {}
        public IDSource(string val)
            :base(Fields.CustomTags.IDSource, val) {}


        // Field Enumerations
        public const string RIC_CODE = "5";
        public const string EXCHANGE_SECURITY_ID = "8";
        public const string TT_SECURITY_ID = "96";
        public const string ALIAS = "97";
        public const string NAME = "98";
        public const string SERIES_KEY = "X";
        public const string CUSIP = "1";
        public const string SEDOL = "2";
        public const string QUIK = "3";
        public const string ISIN_NUMBER = "4";
        public const string ISO_CURRENCY_CODE = "6";
        public const string ISO_COUNTRY_CODE = "7";
        public const string EXCHANGE_SYMBOL = "8";
        public const string CONSOLIDATED_TAPE_ASSOCIATION = "9";
    }


    /// <summary>
    /// IOIid Field
    /// </summary>/
    public sealed class IOIid : QuickFix.Fields.StringField
    {
        public IOIid()
            :base(Fields.CustomTags.IOIid) {}
        public IOIid(string val)
            :base(Fields.CustomTags.IOIid, val) {}

    }


    /// <summary>
    /// IOIOthSvc Field
    /// </summary>/
    public sealed class IOIOthSvc : QuickFix.Fields.CharField
    {
        public IOIOthSvc()
            :base(Fields.CustomTags.IOIOthSvc) {}
        public IOIOthSvc(char val)
            :base(Fields.CustomTags.IOIOthSvc, val) {}

    }


    /// <summary>
    /// IOIQltyInd Field
    /// </summary>/
    public sealed class IOIQltyInd : QuickFix.Fields.CharField
    {
        public IOIQltyInd()
            :base(Fields.CustomTags.IOIQltyInd) {}
        public IOIQltyInd(char val)
            :base(Fields.CustomTags.IOIQltyInd, val) {}


        // Field Enumerations
        public const char HIGH = 'H';
        public const char LOW = 'L';
        public const char MEDIUM = 'M';
    }


    /// <summary>
    /// IOIRefID Field
    /// </summary>/
    public sealed class IOIRefID : QuickFix.Fields.StringField
    {
        public IOIRefID()
            :base(Fields.CustomTags.IOIRefID) {}
        public IOIRefID(string val)
            :base(Fields.CustomTags.IOIRefID, val) {}

    }


    /// <summary>
    /// IOIShares Field
    /// </summary>/
    public sealed class IOIShares : QuickFix.Fields.StringField
    {
        public IOIShares()
            :base(Fields.CustomTags.IOIShares) {}
        public IOIShares(string val)
            :base(Fields.CustomTags.IOIShares, val) {}

    }


    /// <summary>
    /// IOITransType Field
    /// </summary>/
    public sealed class IOITransType : QuickFix.Fields.CharField
    {
        public IOITransType()
            :base(Fields.CustomTags.IOITransType) {}
        public IOITransType(char val)
            :base(Fields.CustomTags.IOITransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NEW = 'N';
        public const char REPLACE = 'R';
    }


    /// <summary>
    /// LastCapacity Field
    /// </summary>/
    public sealed class LastCapacity : QuickFix.Fields.CharField
    {
        public LastCapacity()
            :base(Fields.CustomTags.LastCapacity) {}
        public LastCapacity(char val)
            :base(Fields.CustomTags.LastCapacity, val) {}


        // Field Enumerations
        public const char AGENT = '1';
        public const char CROSS_AS_AGENT = '2';
        public const char CROSS_AS_PRINCIPAL = '3';
        public const char PRINCIPAL = '4';
    }


    /// <summary>
    /// LastMkt Field
    /// </summary>/
    public sealed class LastMkt : QuickFix.Fields.StringField
    {
        public LastMkt()
            :base(Fields.CustomTags.LastMkt) {}
        public LastMkt(string val)
            :base(Fields.CustomTags.LastMkt, val) {}

    }


    /// <summary>
    /// LastPx Field
    /// </summary>/
    public sealed class LastPx : QuickFix.Fields.DecimalField
    {
        public LastPx()
            :base(Fields.CustomTags.LastPx) {}
        public LastPx(Decimal val)
            :base(Fields.CustomTags.LastPx, val) {}

    }


    /// <summary>
    /// LastShares Field
    /// </summary>/
    public sealed class LastShares : QuickFix.Fields.DecimalField
    {
        public LastShares()
            :base(Fields.CustomTags.LastShares) {}
        public LastShares(Decimal val)
            :base(Fields.CustomTags.LastShares, val) {}

    }


    /// <summary>
    /// LinesOfText Field
    /// </summary>/
    public sealed class LinesOfText : QuickFix.Fields.IntField
    {
        public LinesOfText()
            :base(Fields.CustomTags.LinesOfText) {}
        public LinesOfText(int val)
            :base(Fields.CustomTags.LinesOfText, val) {}

    }


    /// <summary>
    /// MsgSeqNum Field
    /// </summary>/
    public sealed class MsgSeqNum : QuickFix.Fields.IntField
    {
        public MsgSeqNum()
            :base(Fields.CustomTags.MsgSeqNum) {}
        public MsgSeqNum(int val)
            :base(Fields.CustomTags.MsgSeqNum, val) {}

    }


    /// <summary>
    /// MsgType Field
    /// </summary>/
    public sealed class MsgType : QuickFix.Fields.StringField
    {
        public MsgType()
            :base(Fields.CustomTags.MsgType) {}
        public MsgType(string val)
            :base(Fields.CustomTags.MsgType, val) {}


        // Field Enumerations
        public const string HEARTBEAT = "0";
        public const string TESTREQUEST = "1";
        public const string RESENDREQUEST = "2";
        public const string REJECT = "3";
        public const string SEQUENCERESET = "4";
        public const string LOGOUT = "5";
        public const string IOI = "6";
        public const string ADVERTISEMENT = "7";
        public const string EXECUTIONREPORT = "8";
        public const string ORDERCANCELREJECT = "9";
        public const string LOGON = "A";
        public const string DERIVATIVESECURITYLIST = "AA";
        public const string NEWORDERMULTILEG = "AB";
        public const string MULTILEGORDERCANCELREPLACE = "AC";
        public const string TRADECAPTUREREPORTREQUEST = "AD";
        public const string TRADECAPTUREREPORT = "AE";
        public const string ORDERMASSSTATUSREQUEST = "AF";
        public const string QUOTEREQUESTREJECT = "AG";
        public const string RFQREQUEST = "AH";
        public const string QUOTESTATUSREPORT = "AI";
        public const string QUOTERESPONSE = "AJ";
        public const string CONFIRMATION = "AK";
        public const string POSITIONMAINTENANCEREQUEST = "AL";
        public const string POSITIONMAINTENANCEREPORT = "AM";
        public const string REQUESTFORPOSITIONS = "AN";
        public const string REQUESTFORPOSITIONSACK = "AO";
        public const string POSITIONREPORT = "AP";
        public const string TRADECAPTUREREPORTREQUESTACK = "AQ";
        public const string TRADECAPTUREREPORTACK = "AR";
        public const string ALLOCATIONREPORT = "AS";
        public const string ALLOCATIONREPORTACK = "AT";
        public const string CONFIRMATION_ACK = "AU";
        public const string SETTLEMENTINSTRUCTIONREQUEST = "AV";
        public const string ASSIGNMENTREPORT = "AW";
        public const string COLLATERALREQUEST = "AX";
        public const string COLLATERALASSIGNMENT = "AY";
        public const string COLLATERALRESPONSE = "AZ";
        public const string NEWS = "B";
        public const string COLLATERALREPORT = "BA";
        public const string COLLATERALINQUIRY = "BB";
        public const string NETWORKCOUNTERPARTYSYSTEMSTATUSREQUEST = "BC";
        public const string NETWORKCOUNTERPARTYSYSTEMSTATUSRESPONSE = "BD";
        public const string USERREQUEST = "BE";
        public const string USERRESPONSE = "BF";
        public const string COLLATERALINQUIRYACK = "BG";
        public const string CONFIRMATIONREQUEST = "BH";
        public const string TRADINGSESSIONLISTREQUEST = "BI";
        public const string TRADINGSESSIONLIST = "BJ";
        public const string SECURITYLISTUPDATEREPORT = "BK";
        public const string ADJUSTEDPOSITIONREPORT = "BL";
        public const string ALLOCATIONINSTRUCTIONALERT = "BM";
        public const string EXECUTIONACKNOWLEDGEMENT = "BN";
        public const string CONTRARYINTENTIONREPORT = "BO";
        public const string SECURITYDEFINITIONUPDATEREPORT = "BP";
        public const string SETTLEMENTOBLIGATIONREPORT = "BQ";
        public const string DERIVATIVESECURITYLISTUPDATEREPORT = "BR";
        public const string TRADINGSESSIONLISTUPDATEREPORT = "BS";
        public const string MARKETDEFINITIONREQUEST = "BT";
        public const string MARKETDEFINITION = "BU";
        public const string MARKETDEFINITIONUPDATEREPORT = "BV";
        public const string APPLICATIONMESSAGEREQUEST = "BW";
        public const string APPLICATIONMESSAGEREQUESTACK = "BX";
        public const string APPLICATIONMESSAGEREPORT = "BY";
        public const string ORDERMASSACTIONREPORT = "BZ";
        public const string EMAIL = "C";
        public const string ORDERMASSACTIONREQUEST = "CA";
        public const string USERNOTIFICATION = "CB";
        public const string STREAMASSIGNMENTREQUEST = "CC";
        public const string STREAMASSIGNMENTREPORT = "CD";
        public const string STREAMASSIGNMENTREPORTACK = "CE";
        public const string PARTYDETAILSLISTREQUEST = "CF";
        public const string PARTYDETAILSLISTREPORT = "CG";
        public const string NEWORDERSINGLE = "D";
        public const string NEWORDERLIST = "E";
        public const string ORDERCANCELREQUEST = "F";
        public const string ORDERCANCELREPLACEREQUEST = "G";
        public const string ORDERSTATUSREQUEST = "H";
        public const string ALLOCATIONINSTRUCTION = "J";
        public const string LISTCANCELREQUEST = "K";
        public const string LISTEXECUTE = "L";
        public const string LISTSTATUSREQUEST = "M";
        public const string LISTSTATUS = "N";
        public const string ALLOCATIONINSTRUCTIONACK = "P";
        public const string DONTKNOWTRADEDK = "Q";
        public const string QUOTEREQUEST = "R";
        public const string QUOTE = "S";
        public const string SETTLEMENTINSTRUCTIONS = "T";
        public const string MARKETDATAREQUEST = "V";
        public const string MARKETDATASNAPSHOTFULLREFRESH = "W";
        public const string MARKETDATAINCREMENTALREFRESH = "X";
        public const string MARKETDATAREQUESTREJECT = "Y";
        public const string QUOTECANCEL = "Z";
        public const string QUOTESTATUSREQUEST = "a";
        public const string MASSQUOTEACKNOWLEDGEMENT = "b";
        public const string SECURITYDEFINITIONREQUEST = "c";
        public const string SECURITYDEFINITION = "d";
        public const string SECURITYSTATUSREQUEST = "e";
        public const string SECURITYSTATUS = "f";
        public const string TRADINGSESSIONSTATUSREQUEST = "g";
        public const string TRADINGSESSIONSTATUS = "h";
        public const string MASSQUOTE = "i";
        public const string BUSINESSMESSAGEREJECT = "j";
        public const string BIDREQUEST = "k";
        public const string BIDRESPONSE = "l";
        public const string LISTSTRIKEPRICE = "m";
        public const string XML_NON_FIX = "n";
        public const string REGISTRATIONINSTRUCTIONS = "o";
        public const string REGISTRATIONINSTRUCTIONSRESPONSE = "p";
        public const string ORDERMASSCANCELREQUEST = "q";
        public const string ORDERMASSCANCELREPORT = "r";
        public const string NEWORDERCROSS = "s";
        public const string CROSSORDERCANCELREPLACEREQUEST = "t";
        public const string CROSSORDERCANCELREQUEST = "u";
        public const string SECURITYTYPEREQUEST = "v";
        public const string SECURITYTYPES = "w";
        public const string SECURITYLISTREQUEST = "x";
        public const string SECURITYLIST = "y";
        public const string DERIVATIVESECURITYLISTREQUEST = "z";
        public const string TEST_REQUEST = "1";
        public const string RESEND_REQUEST = "2";
        public const string SEQUENCE_RESET = "4";
        public const string INDICATION_OF_INTEREST = "6";
        public const string EXECUTION_REPORT = "8";
        public const string ORDER_CANCEL_REJECT = "9";
        public const string QUOTE_STATUS_REQUEST = "a";
        public const string DERIVATIVE_SECURITY_LIST = "AA";
        public const string NEW_ORDER_AB = "AB";
        public const string MULTILEG_ORDER_CANCEL_REPLACE = "AC";
        public const string TRADE_CAPTURE_REPORT_REQUEST = "AD";
        public const string TRADE_CAPTURE_REPORT = "AE";
        public const string ORDER_MASS_STATUS_REQUEST = "AF";
        public const string QUOTE_REQUEST_REJECT = "AG";
        public const string RFQ_REQUEST = "AH";
        public const string QUOTE_STATUS_REPORT = "AI";
        public const string QUOTE_RESPONSE = "AJ";
        public const string POSITION_MAINTENANCE_REQUEST = "AL";
        public const string POSITION_MAINTENANCE_REPORT = "AM";
        public const string REQUEST_FOR_POSITIONS = "AN";
        public const string REQUEST_FOR_POSITIONS_ACK = "AO";
        public const string POSITION_REPORT = "AP";
        public const string TRADE_CAPTURE_REPORT_REQUEST_ACK = "AQ";
        public const string TRADE_CAPTURE_REPORT_ACK = "AR";
        public const string ALLOCATION_REPORT = "AS";
        public const string ALLOCATION_REPORT_ACK = "AT";
        public const string SETTLEMENT_INSTRUCTION_REQUEST = "AV";
        public const string ASSIGNMENT_REPORT = "AW";
        public const string COLLATERAL_REQUEST = "AX";
        public const string COLLATERAL_ASSIGNMENT = "AY";
        public const string COLLATERAL_RESPONSE = "AZ";
        public const string MASS_QUOTE_ACKNOWLEDGEMENT = "b";
        public const string COLLATERAL_REPORT = "BA";
        public const string COLLATERAL_INQUIRY = "BB";
        public const string NETWORK_COUNTERPARTY_SYSTEM_STATUS_REQUEST = "BC";
        public const string NETWORK_COUNTERPARTY_SYSTEM_STATUS_RESPONSE = "BD";
        public const string USER_REQUEST = "BE";
        public const string USER_RESPONSE = "BF";
        public const string COLLATERAL_INQUIRY_ACK = "BG";
        public const string CONFIRMATION_REQUEST = "BH";
        public const string SECURITY_DEFINITION_REQUEST = "c";
        public const string SECURITY_DEFINITION = "d";
        public const string NEW_ORDER_D = "D";
        public const string SECURITY_STATUS_REQUEST = "e";
        public const string NEW_ORDER_E = "E";
        public const string ORDER_CANCEL_REQUEST = "F";
        public const string SECURITY_STATUS = "f";
        public const string ORDER_CANCEL_REPLACE_REQUEST = "G";
        public const string TRADING_SESSION_STATUS_REQUEST = "g";
        public const string ORDER_STATUS_REQUEST = "H";
        public const string TRADING_SESSION_STATUS = "h";
        public const string MASS_QUOTE = "i";
        public const string BUSINESS_MESSAGE_REJECT = "j";
        public const string ALLOCATION_INSTRUCTION = "J";
        public const string BID_REQUEST = "k";
        public const string LIST_CANCEL_REQUEST = "K";
        public const string BID_RESPONSE = "l";
        public const string LIST_EXECUTE = "L";
        public const string LIST_STRIKE_PRICE = "m";
        public const string LIST_STATUS_REQUEST = "M";
        public const string XML_MESSAGE = "n";
        public const string LIST_STATUS = "N";
        public const string REGISTRATION_INSTRUCTIONS = "o";
        public const string REGISTRATION_INSTRUCTIONS_RESPONSE = "p";
        public const string ALLOCATION_INSTRUCTION_ACK = "P";
        public const string ORDER_MASS_CANCEL_REQUEST = "q";
        public const string DONT_KNOW_TRADE = "Q";
        public const string QUOTE_REQUEST = "R";
        public const string ORDER_MASS_CANCEL_REPORT = "r";
        public const string NEW_ORDER_s = "s";
        public const string SETTLEMENT_INSTRUCTIONS = "T";
        public const string CROSS_ORDER_CANCEL_REPLACE_REQUEST = "t";
        public const string CROSS_ORDER_CANCEL_REQUEST = "u";
        public const string MARKET_DATA_REQUEST = "V";
        public const string SECURITY_TYPE_REQUEST = "v";
        public const string SECURITY_TYPES = "w";
        public const string MARKET_DATA_W = "W";
        public const string SECURITY_LIST_REQUEST = "x";
        public const string MARKET_DATA_X = "X";
        public const string MARKET_DATA_REQUEST_REJECT = "Y";
        public const string SECURITY_LIST = "y";
        public const string QUOTE_CANCEL = "Z";
        public const string DERIVATIVE_SECURITY_LIST_REQUEST = "z";
        public const string CONTRARY_INTENTION_REPORT = "BO";
        public const string SECURITY_DEFINITION_UPDATE_REPORT = "BP";
        public const string SECURITY_LIST_UPDATE_REPORT = "BK";
        public const string ADJUSTED_POSITION_REPORT = "BL";
        public const string ALLOCATION_INSTRUCTION_ALERT = "BM";
        public const string EXECUTION_ACKNOWLEDGEMENT = "BN";
        public const string TRADING_SESSION_LIST = "BJ";
        public const string TRADING_SESSION_LIST_REQUEST = "BI";
        public const string ORDER_MASS_ACTION = "BZ";
        public const string ORDER_SINGLE = "D";
        public const string ORDER_MULTI_LEG = "AB";
        public const string ORDER_MULTI_LEG_CANCEL_REPLACE_REQUEST = "AC";
        public const string XMLnonFIX = "n";
        public const string HISTORY_REQUEST = "UHR";
        public const string MARKET_DATA_SNAPSHOT_FULL_REFRESH = "W";
        public const string MARKET_DATA_INCREMENTAL_REFRESH = "X";
        public const string OUTOFBAND_RECOVERY_REQUEST = "U2";
        public const string ORDER_LIST = "E";
        public const string ORDER_CANCEL = "G";
        public const string ALLOCATION = "J";
        public const string ALLOCATION_ACK = "P";
        public const string MARKET_DATA_SNAPSHOT = "W";
        public const string NEW_ORDER_CROSS = "s";
        public const string CROSS_ORDER_CANCEL = "t";
        public const string NEW_ORDER_MULTILEG = "AB";
        public const string MULTILEG_ORDER_CANCEL = "AC";
    }


    /// <summary>
    /// NewSeqNo Field
    /// </summary>/
    public sealed class NewSeqNo : QuickFix.Fields.IntField
    {
        public NewSeqNo()
            :base(Fields.CustomTags.NewSeqNo) {}
        public NewSeqNo(int val)
            :base(Fields.CustomTags.NewSeqNo, val) {}

    }


    /// <summary>
    /// OrderID Field
    /// </summary>/
    public sealed class OrderID : QuickFix.Fields.StringField
    {
        public OrderID()
            :base(Fields.CustomTags.OrderID) {}
        public OrderID(string val)
            :base(Fields.CustomTags.OrderID, val) {}

    }


    /// <summary>
    /// OrderQty Field
    /// </summary>/
    public sealed class OrderQty : QuickFix.Fields.DecimalField
    {
        public OrderQty()
            :base(Fields.CustomTags.OrderQty) {}
        public OrderQty(Decimal val)
            :base(Fields.CustomTags.OrderQty, val) {}

    }


    /// <summary>
    /// OrdStatus Field
    /// </summary>/
    public sealed class OrdStatus : QuickFix.Fields.CharField
    {
        public OrdStatus()
            :base(Fields.CustomTags.OrdStatus) {}
        public OrdStatus(char val)
            :base(Fields.CustomTags.OrdStatus, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char PARTIALLY_FILLED = '1';
        public const char FILLED = '2';
        public const char DONE_FOR_DAY = '3';
        public const char CANCELED = '4';
        public const char PENDING_CANCEL = '6';
        public const char STOPPED = '7';
        public const char REJECTED = '8';
        public const char SUSPENDED = '9';
        public const char PENDING_NEW = 'A';
        public const char CALCULATED = 'B';
        public const char EXPIRED = 'C';
        public const char ACCEPTED_FOR_BIDDING = 'D';
        public const char PENDING_REPLACE = 'E';
        public const char REPLACED = '5';
        public const char PENDING_CANCELREPLACE = '6';
    }


    /// <summary>
    /// OrdType Field
    /// </summary>/
    public sealed class OrdType : QuickFix.Fields.CharField
    {
        public OrdType()
            :base(Fields.CustomTags.OrdType) {}
        public OrdType(char val)
            :base(Fields.CustomTags.OrdType, val) {}


        // Field Enumerations
        public const char MARKET = '1';
        public const char LIMIT = '2';
        public const char STOP = '3';
        public const char STOP_LIMIT = '4';
        public const char MARKET_ON_CLOSE = '5';
        public const char WITH_OR_WITHOUT = '6';
        public const char LIMIT_OR_BETTER = '7';
        public const char LIMIT_WITH_OR_WITHOUT = '8';
        public const char ON_BASIS = '9';
        public const char ON_CLOSE = 'A';
        public const char LIMIT_ON_CLOSE = 'B';
        public const char FOREX_MARKET = 'C';
        public const char PREVIOUSLY_QUOTED = 'D';
        public const char PREVIOUSLY_INDICATED = 'E';
        public const char FOREX_LIMIT = 'F';
        public const char FOREX_SWAP = 'G';
        public const char FOREX_PREVIOUSLY_QUOTED = 'H';
        public const char FUNARI = 'I';
        public const char MARKET_IF_TOUCHED = 'J';
        public const char MARKET_WITH_LEFT_OVER_AS_LIMIT = 'K';
        public const char PREVIOUS_FUND_VALUATION_POINT = 'L';
        public const char NEXT_FUND_VALUATION_POINT = 'M';
        public const char PEGGED = 'P';
        public const char COUNTER_ORDER_SELECTION = 'Q';
        public const char MARKET_LIMIT_MARKET_LEFT_OVER_AS_LIMIT = 'Q';
        public const char STOP_MARKET_TO_LIMIT = 'S';
        public const char IF_TOUCHED_LIMIT = 'T';
        public const char IF_TOUCHED_MARKET = 'J';
        public const char IF_TOUCHED_MARKET_TO_LIMIT = 'U';
        public const char LIMIT_POST_ONLY = 'p';
        public const char MARKET_CLOSE_TODAY = 'V';
        public const char LIMIT_CLOSE_TODAY = 'W';
        public const char MARKET_WITH_LEFTOVER_AS_LIMIT = 'K';
        public const char FOREX = 'C';
    }


    /// <summary>
    /// OrigClOrdID Field
    /// </summary>/
    public sealed class OrigClOrdID : QuickFix.Fields.StringField
    {
        public OrigClOrdID()
            :base(Fields.CustomTags.OrigClOrdID) {}
        public OrigClOrdID(string val)
            :base(Fields.CustomTags.OrigClOrdID, val) {}

    }


    /// <summary>
    /// OrigTime Field
    /// </summary>/
    public sealed class OrigTime : QuickFix.Fields.DateTimeField
    {
        public OrigTime()
            :base(Fields.CustomTags.OrigTime) {}
        public OrigTime(DateTime val)
            :base(Fields.CustomTags.OrigTime, val) {}
        public OrigTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.OrigTime, val, showMilliseconds) {}
		public OrigTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.OrigTime, val, precision) {}

    }


    /// <summary>
    /// PossDupFlag Field
    /// </summary>/
    public sealed class PossDupFlag : QuickFix.Fields.BooleanField
    {
        public PossDupFlag()
            :base(Fields.CustomTags.PossDupFlag) {}
        public PossDupFlag(Boolean val)
            :base(Fields.CustomTags.PossDupFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean POSSIBLE_DUPLICATE = true;
        public const Boolean ORIGINAL_TRANSMISSION = false;
    }


    /// <summary>
    /// Price Field
    /// </summary>/
    public sealed class Price : QuickFix.Fields.DecimalField
    {
        public Price()
            :base(Fields.CustomTags.Price) {}
        public Price(Decimal val)
            :base(Fields.CustomTags.Price, val) {}

    }


    /// <summary>
    /// RefSeqNum Field
    /// </summary>/
    public sealed class RefSeqNum : QuickFix.Fields.IntField
    {
        public RefSeqNum()
            :base(Fields.CustomTags.RefSeqNum) {}
        public RefSeqNum(int val)
            :base(Fields.CustomTags.RefSeqNum, val) {}

    }


    /// <summary>
    /// RelatdSym Field
    /// </summary>/
    public sealed class RelatdSym : QuickFix.Fields.StringField
    {
        public RelatdSym()
            :base(Fields.CustomTags.RelatdSym) {}
        public RelatdSym(string val)
            :base(Fields.CustomTags.RelatdSym, val) {}

    }


    /// <summary>
    /// Rule80A Field
    /// </summary>/
    public sealed class Rule80A : QuickFix.Fields.CharField
    {
        public Rule80A()
            :base(Fields.CustomTags.Rule80A) {}
        public Rule80A(char val)
            :base(Fields.CustomTags.Rule80A, val) {}


        // Field Enumerations
        public const char AGENCY_SINGLE_ORDER = 'A';
        public const char SHORT_EXEMPT_TRANSACTION_B = 'B';
        public const char PROPRIETARY_NON_ALGORITHMIC_PROGRAM_TRADE = 'C';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_MEMBER_FIRM_ORG = 'D';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_PRINCIPAL = 'E';
        public const char SHORT_EXEMPT_TRANSACTION_F = 'F';
        public const char SHORT_EXEMPT_TRANSACTION_H = 'H';
        public const char INDIVIDUAL_INVESTOR_SINGLE_ORDER = 'I';
        public const char PROPRIETARY_ALGORITHMIC_PROGRAM_TRADING = 'J';
        public const char AGENCY_ALGORITHMIC_PROGRAM_TRADING = 'K';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_MEMBER_COMPETING_MARKET_MAKER_AFFLIATED_WITH_THE_FIRM_CLEARING_THE_TRADE = 'L';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_OTHER_MEMBER = 'M';
        public const char AGENT_FOR_OTHER_MEMBER_NON_ALGORITHMIC_PROGRAM_TRADE = 'N';
        public const char PROPRIETARY_TRANSACTIONS_FOR_COMPETING_MARKET_MAKER_THAT_IS_AFFILIATED_WITH_THE_CLEARING_MEMBER = 'O';
        public const char PRINCIPAL = 'P';
        public const char TRANSACTIONS_FOR_THE_ACCOUNT_OF_A_NON_MEMBER_COMPTING_MARKET_MAKER = 'R';
        public const char SPECIALIST_TRADES = 'S';
        public const char TRANSACTIONS_FOR_THE_ACCOUNT_OF_AN_UNAFFILIATED_MEMBERS_COMPETING_MARKET_MAKER = 'T';
        public const char AGENCY_INDEX_ARBITRAGE = 'U';
        public const char ALL_OTHER_ORDERS_AS_AGENT_FOR_OTHER_MEMBER = 'W';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_MEMBER_COMPETING_MARKET_MAKER_NOT_AFFILIATED_WITH_THE_FIRM_CLEARING_THE_TRADE = 'X';
        public const char AGENCY_NON_ALGORITHMIC_PROGRAM_TRADE = 'Y';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_NON_MEMBER_COMPETING_MARKET_MAKER = 'Z';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_MEMBER_FIRM_ORG = 'C';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_INDIVIDUAL_CUSTOMER = 'J';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_INDIVIDUAL_CUSTOMER = 'K';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_OTHER_MEMBER = 'N';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_OTHER_AGENCY = 'U';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_OTHER_AGENCY = 'Y';
        public const char SHORT_EXEMPT_TRANSACTION_REFER_TO_A_TYPE = 'B';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_MEMBER_FIRM = 'C';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_MEMBER_FIRM = 'D';
        public const char SHORT_EXEMPT_TRANSACTION_REFER_TO_W_TYPE = 'F';
        public const char SHORT_EXEMPT_TRANSACTION_REFER_TO_I_TYPE = 'H';
        public const char INDIVIDUAL_INVESTOR = 'I';
        public const char SHORT_EXEMPT_AFFILIATED = 'L';
        public const char PROPRIETARY_AFFILIATED = 'O';
        public const char TRANSACTIONS_NON_MEMBER = 'R';
        public const char TRANSACTIONS_UNAFFILIATED_MEMBER = 'T';
        public const char SHORT_EXEMPT_NOT_AFFILIATED = 'X';
        public const char SHORT_EXEMPT_NONMEMBER = 'Z';
        public const char PROGRAM_ORDER_NONINDEX_ARB_FOR_MEMBER_FIRMORG = 'C';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_MEMBER_FIRMORG = 'D';
        public const char REGISTERED_EQUITY_MARKET_MAKER_TRADES = 'E';
        public const char PROGRAM_ORDER_NONINDEX_ARB_FOR_INDIVIDUAL_CUSTOMER = 'K';
        public const char PROGRAM_ORDER_NONINDEX_ARB_FOR_OTHER_MEMBER = 'N';
        public const char COMPETING_DEALER_TRADES_O = 'O';
        public const char COMPETING_DEALER_TRADES_R = 'R';
        public const char COMPETING_DEALER_TRADES_T = 'T';
        public const char PROGRAM_ORDER_NONINDEX_ARB_FOR_OTHER_AGENCY = 'Y';
    }


    /// <summary>
    /// SecurityID Field
    /// </summary>/
    public sealed class SecurityID : QuickFix.Fields.StringField
    {
        public SecurityID()
            :base(Fields.CustomTags.SecurityID) {}
        public SecurityID(string val)
            :base(Fields.CustomTags.SecurityID, val) {}

    }


    /// <summary>
    /// SenderCompID Field
    /// </summary>/
    public sealed class SenderCompID : QuickFix.Fields.StringField
    {
        public SenderCompID()
            :base(Fields.CustomTags.SenderCompID) {}
        public SenderCompID(string val)
            :base(Fields.CustomTags.SenderCompID, val) {}

    }


    /// <summary>
    /// SenderSubID Field
    /// </summary>/
    public sealed class SenderSubID : QuickFix.Fields.StringField
    {
        public SenderSubID()
            :base(Fields.CustomTags.SenderSubID) {}
        public SenderSubID(string val)
            :base(Fields.CustomTags.SenderSubID, val) {}

    }


    /// <summary>
    /// SendingTime Field
    /// </summary>/
    public sealed class SendingTime : QuickFix.Fields.DateTimeField
    {
        public SendingTime()
            :base(Fields.CustomTags.SendingTime) {}
        public SendingTime(DateTime val)
            :base(Fields.CustomTags.SendingTime, val) {}
        public SendingTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.SendingTime, val, showMilliseconds) {}
		public SendingTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.SendingTime, val, precision) {}

    }


    /// <summary>
    /// Shares Field
    /// </summary>/
    public sealed class Shares : QuickFix.Fields.DecimalField
    {
        public Shares()
            :base(Fields.CustomTags.Shares) {}
        public Shares(Decimal val)
            :base(Fields.CustomTags.Shares, val) {}

    }


    /// <summary>
    /// Side Field
    /// </summary>/
    public sealed class Side : QuickFix.Fields.CharField
    {
        public Side()
            :base(Fields.CustomTags.Side) {}
        public Side(char val)
            :base(Fields.CustomTags.Side, val) {}


        // Field Enumerations
        public const char BUY = '1';
        public const char SELL = '2';
        public const char BUY_MINUS = '3';
        public const char SELL_PLUS = '4';
        public const char SELL_SHORT = '5';
        public const char SELL_SHORT_EXEMPT = '6';
        public const char UNDISCLOSED = '7';
        public const char CROSS = '8';
        public const char CROSS_SHORT = '9';
        public const char CROSS_SHORT_EXEMPT = 'A';
        public const char AS_DEFINED = 'B';
        public const char OPPOSITE = 'C';
        public const char SUBSCRIBE = 'D';
        public const char REDEEM = 'E';
        public const char LEND = 'F';
        public const char BORROW = 'G';
        public const char CROSS_SHORT_EXXMPT = 'A';
        public const char D = '7';
    }


    /// <summary>
    /// Symbol Field
    /// </summary>/
    public sealed class Symbol : QuickFix.Fields.StringField
    {
        public Symbol()
            :base(Fields.CustomTags.Symbol) {}
        public Symbol(string val)
            :base(Fields.CustomTags.Symbol, val) {}

    }


    /// <summary>
    /// TargetCompID Field
    /// </summary>/
    public sealed class TargetCompID : QuickFix.Fields.StringField
    {
        public TargetCompID()
            :base(Fields.CustomTags.TargetCompID) {}
        public TargetCompID(string val)
            :base(Fields.CustomTags.TargetCompID, val) {}

    }


    /// <summary>
    /// TargetSubID Field
    /// </summary>/
    public sealed class TargetSubID : QuickFix.Fields.StringField
    {
        public TargetSubID()
            :base(Fields.CustomTags.TargetSubID) {}
        public TargetSubID(string val)
            :base(Fields.CustomTags.TargetSubID, val) {}

    }


    /// <summary>
    /// Text Field
    /// </summary>/
    public sealed class Text : QuickFix.Fields.StringField
    {
        public Text()
            :base(Fields.CustomTags.Text) {}
        public Text(string val)
            :base(Fields.CustomTags.Text, val) {}

    }


    /// <summary>
    /// TimeInForce Field
    /// </summary>/
    public sealed class TimeInForce : QuickFix.Fields.CharField
    {
        public TimeInForce()
            :base(Fields.CustomTags.TimeInForce) {}
        public TimeInForce(char val)
            :base(Fields.CustomTags.TimeInForce, val) {}


        // Field Enumerations
        public const char DAY = '0';
        public const char GOOD_TILL_CANCEL = '1';
        public const char AT_THE_OPENING = '2';
        public const char IMMEDIATE_OR_CANCEL = '3';
        public const char FILL_OR_KILL = '4';
        public const char GOOD_TILL_CROSSING = '5';
        public const char GOOD_TILL_DATE = '6';
        public const char AT_THE_CLOSE = '7';
        public const char GOOD_THROUGH_CROSSING = '8';
        public const char AT_CROSSING = '9';
        public const char AUCTION = 'A';
        public const char GOOD_IN_SESSION = 'V';
        public const char DAY_PLUS = 'W';
        public const char GOOD_TILL_CANCEL_PLUS = 'X';
        public const char GOOD_TILL_DATE_PLUS = 'Y';
    }


    /// <summary>
    /// TransactTime Field
    /// </summary>/
    public sealed class TransactTime : QuickFix.Fields.DateTimeField
    {
        public TransactTime()
            :base(Fields.CustomTags.TransactTime) {}
        public TransactTime(DateTime val)
            :base(Fields.CustomTags.TransactTime, val) {}
        public TransactTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TransactTime, val, showMilliseconds) {}
		public TransactTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TransactTime, val, precision) {}

    }


    /// <summary>
    /// Urgency Field
    /// </summary>/
    public sealed class Urgency : QuickFix.Fields.CharField
    {
        public Urgency()
            :base(Fields.CustomTags.Urgency) {}
        public Urgency(char val)
            :base(Fields.CustomTags.Urgency, val) {}


        // Field Enumerations
        public const char NORMAL = '0';
        public const char FLASH = '1';
        public const char BACKGROUND = '2';
    }


    /// <summary>
    /// ValidUntilTime Field
    /// </summary>/
    public sealed class ValidUntilTime : QuickFix.Fields.DateTimeField
    {
        public ValidUntilTime()
            :base(Fields.CustomTags.ValidUntilTime) {}
        public ValidUntilTime(DateTime val)
            :base(Fields.CustomTags.ValidUntilTime, val) {}
        public ValidUntilTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.ValidUntilTime, val, showMilliseconds) {}
		public ValidUntilTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.ValidUntilTime, val, precision) {}

    }


    /// <summary>
    /// SettlmntTyp Field
    /// </summary>/
    public sealed class SettlmntTyp : QuickFix.Fields.CharField
    {
        public SettlmntTyp()
            :base(Fields.CustomTags.SettlmntTyp) {}
        public SettlmntTyp(char val)
            :base(Fields.CustomTags.SettlmntTyp, val) {}


        // Field Enumerations
        public const char REGULAR = '0';
        public const char CASH = '1';
        public const char NEXT_DAY = '2';
        public const char T_PLUS_2 = '3';
        public const char T_PLUS_3 = '4';
        public const char T_PLUS_4 = '5';
        public const char FUTURE = '6';
        public const char WHEN_AND_IF_ISSUED = '7';
        public const char SELLERS_OPTION = '8';
        public const char T_PLUS_5 = '9';
        public const char T_PLUS_1 = 'A';
        public const char TPLUS2 = '3';
        public const char TPLUS3 = '4';
        public const char TPLUS4 = '5';
        public const char WHEN_ISSUED = '7';
        public const char TPLUS5 = '9';
    }


    /// <summary>
    /// FutSettDate Field
    /// </summary>/
    public sealed class FutSettDate : QuickFix.Fields.StringField
    {
        public FutSettDate()
            :base(Fields.CustomTags.FutSettDate) {}
        public FutSettDate(string val)
            :base(Fields.CustomTags.FutSettDate, val) {}

    }


    /// <summary>
    /// SymbolSfx Field
    /// </summary>/
    public sealed class SymbolSfx : QuickFix.Fields.StringField
    {
        public SymbolSfx()
            :base(Fields.CustomTags.SymbolSfx) {}
        public SymbolSfx(string val)
            :base(Fields.CustomTags.SymbolSfx, val) {}


        // Field Enumerations
        public const string EUCP_WITH_LUMP_SUM_INTEREST_RATHER_THAN_DISCOUNT_PRICE = "CD";
        public const string WHEN_ISSUED_FOR_A_SECURITY_TO_BE_REISSUED_UNDER_AN_OLD_CUSIP_OR_ISIN = "WI";
    }


    /// <summary>
    /// ListID Field
    /// </summary>/
    public sealed class ListID : QuickFix.Fields.StringField
    {
        public ListID()
            :base(Fields.CustomTags.ListID) {}
        public ListID(string val)
            :base(Fields.CustomTags.ListID, val) {}

    }


    /// <summary>
    /// ListSeqNo Field
    /// </summary>/
    public sealed class ListSeqNo : QuickFix.Fields.IntField
    {
        public ListSeqNo()
            :base(Fields.CustomTags.ListSeqNo) {}
        public ListSeqNo(int val)
            :base(Fields.CustomTags.ListSeqNo, val) {}

    }


    /// <summary>
    /// ListNoOrds Field
    /// </summary>/
    public sealed class ListNoOrds : QuickFix.Fields.IntField
    {
        public ListNoOrds()
            :base(Fields.CustomTags.ListNoOrds) {}
        public ListNoOrds(int val)
            :base(Fields.CustomTags.ListNoOrds, val) {}

    }


    /// <summary>
    /// ListExecInst Field
    /// </summary>/
    public sealed class ListExecInst : QuickFix.Fields.StringField
    {
        public ListExecInst()
            :base(Fields.CustomTags.ListExecInst) {}
        public ListExecInst(string val)
            :base(Fields.CustomTags.ListExecInst, val) {}

    }


    /// <summary>
    /// AllocID Field
    /// </summary>/
    public sealed class AllocID : QuickFix.Fields.StringField
    {
        public AllocID()
            :base(Fields.CustomTags.AllocID) {}
        public AllocID(string val)
            :base(Fields.CustomTags.AllocID, val) {}

    }


    /// <summary>
    /// AllocTransType Field
    /// </summary>/
    public sealed class AllocTransType : QuickFix.Fields.CharField
    {
        public AllocTransType()
            :base(Fields.CustomTags.AllocTransType) {}
        public AllocTransType(char val)
            :base(Fields.CustomTags.AllocTransType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char REPLACE = '1';
        public const char CANCEL = '2';
        public const char PRELIMINARY = '3';
        public const char CALCULATED = '4';
        public const char CALCULATED_WITHOUT_PRELIMINARY = '5';
        public const char REVERSAL = '6';
    }


    /// <summary>
    /// RefAllocID Field
    /// </summary>/
    public sealed class RefAllocID : QuickFix.Fields.StringField
    {
        public RefAllocID()
            :base(Fields.CustomTags.RefAllocID) {}
        public RefAllocID(string val)
            :base(Fields.CustomTags.RefAllocID, val) {}

    }


    /// <summary>
    /// NoOrders Field
    /// </summary>/
    public sealed class NoOrders : QuickFix.Fields.IntField
    {
        public NoOrders()
            :base(Fields.CustomTags.NoOrders) {}
        public NoOrders(int val)
            :base(Fields.CustomTags.NoOrders, val) {}

    }


    /// <summary>
    /// AvgPrxPrecision Field
    /// </summary>/
    public sealed class AvgPrxPrecision : QuickFix.Fields.IntField
    {
        public AvgPrxPrecision()
            :base(Fields.CustomTags.AvgPrxPrecision) {}
        public AvgPrxPrecision(int val)
            :base(Fields.CustomTags.AvgPrxPrecision, val) {}

    }


    /// <summary>
    /// TradeDate Field
    /// </summary>/
    public sealed class TradeDate : QuickFix.Fields.StringField
    {
        public TradeDate()
            :base(Fields.CustomTags.TradeDate) {}
        public TradeDate(string val)
            :base(Fields.CustomTags.TradeDate, val) {}

    }


    /// <summary>
    /// ExecBroker Field
    /// </summary>/
    public sealed class ExecBroker : QuickFix.Fields.StringField
    {
        public ExecBroker()
            :base(Fields.CustomTags.ExecBroker) {}
        public ExecBroker(string val)
            :base(Fields.CustomTags.ExecBroker, val) {}

    }


    /// <summary>
    /// OpenClose Field
    /// </summary>/
    public sealed class OpenClose : QuickFix.Fields.CharField
    {
        public OpenClose()
            :base(Fields.CustomTags.OpenClose) {}
        public OpenClose(char val)
            :base(Fields.CustomTags.OpenClose, val) {}


        // Field Enumerations
        public const char CLOSE = 'C';
        public const char OPEN = 'O';
    }


    /// <summary>
    /// NoAllocs Field
    /// </summary>/
    public sealed class NoAllocs : QuickFix.Fields.IntField
    {
        public NoAllocs()
            :base(Fields.CustomTags.NoAllocs) {}
        public NoAllocs(int val)
            :base(Fields.CustomTags.NoAllocs, val) {}

    }


    /// <summary>
    /// AllocAccount Field
    /// </summary>/
    public sealed class AllocAccount : QuickFix.Fields.StringField
    {
        public AllocAccount()
            :base(Fields.CustomTags.AllocAccount) {}
        public AllocAccount(string val)
            :base(Fields.CustomTags.AllocAccount, val) {}

    }


    /// <summary>
    /// AllocShares Field
    /// </summary>/
    public sealed class AllocShares : QuickFix.Fields.DecimalField
    {
        public AllocShares()
            :base(Fields.CustomTags.AllocShares) {}
        public AllocShares(Decimal val)
            :base(Fields.CustomTags.AllocShares, val) {}

    }


    /// <summary>
    /// ProcessCode Field
    /// </summary>/
    public sealed class ProcessCode : QuickFix.Fields.CharField
    {
        public ProcessCode()
            :base(Fields.CustomTags.ProcessCode) {}
        public ProcessCode(char val)
            :base(Fields.CustomTags.ProcessCode, val) {}


        // Field Enumerations
        public const char REGULAR = '0';
        public const char SOFT_DOLLAR = '1';
        public const char STEP_IN = '2';
        public const char STEP_OUT = '3';
        public const char SOFT_DOLLAR_STEP_IN = '4';
        public const char SOFT_DOLLAR_STEP_OUT = '5';
        public const char PLAN_SPONSOR = '6';
        public const char STEPIN = '2';
        public const char STEPOUT = '3';
        public const char SOFTDOLLAR_STEPIN = '4';
        public const char SOFTDOLLAR_STEPOUT = '5';
    }


    /// <summary>
    /// NoRpts Field
    /// </summary>/
    public sealed class NoRpts : QuickFix.Fields.IntField
    {
        public NoRpts()
            :base(Fields.CustomTags.NoRpts) {}
        public NoRpts(int val)
            :base(Fields.CustomTags.NoRpts, val) {}

    }


    /// <summary>
    /// RptSeq Field
    /// </summary>/
    public sealed class RptSeq : QuickFix.Fields.IntField
    {
        public RptSeq()
            :base(Fields.CustomTags.RptSeq) {}
        public RptSeq(int val)
            :base(Fields.CustomTags.RptSeq, val) {}

    }


    /// <summary>
    /// CxlQty Field
    /// </summary>/
    public sealed class CxlQty : QuickFix.Fields.DecimalField
    {
        public CxlQty()
            :base(Fields.CustomTags.CxlQty) {}
        public CxlQty(Decimal val)
            :base(Fields.CustomTags.CxlQty, val) {}

    }


    /// <summary>
    /// NoDlvyInst Field
    /// </summary>/
    public sealed class NoDlvyInst : QuickFix.Fields.IntField
    {
        public NoDlvyInst()
            :base(Fields.CustomTags.NoDlvyInst) {}
        public NoDlvyInst(int val)
            :base(Fields.CustomTags.NoDlvyInst, val) {}

    }


    /// <summary>
    /// DlvyInst Field
    /// </summary>/
    public sealed class DlvyInst : QuickFix.Fields.StringField
    {
        public DlvyInst()
            :base(Fields.CustomTags.DlvyInst) {}
        public DlvyInst(string val)
            :base(Fields.CustomTags.DlvyInst, val) {}

    }


    /// <summary>
    /// AllocStatus Field
    /// </summary>/
    public sealed class AllocStatus : QuickFix.Fields.IntField
    {
        public AllocStatus()
            :base(Fields.CustomTags.AllocStatus) {}
        public AllocStatus(int val)
            :base(Fields.CustomTags.AllocStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int BLOCK_LEVEL_REJECT = 1;
        public const int ACCOUNT_LEVEL_REJECT = 2;
        public const int RECEIVED = 3;
        public const int INCOMPLETE = 4;
        public const int REJECTED_BY_INTERMEDIARY = 5;
        public const int ALLOCATION_PENDING = 6;
        public const int REVERSED = 7;
        public const int REJECTED = 1;
        public const int PARTIAL_ACCEPT = 2;
    }


    /// <summary>
    /// AllocRejCode Field
    /// </summary>/
    public sealed class AllocRejCode : QuickFix.Fields.IntField
    {
        public AllocRejCode()
            :base(Fields.CustomTags.AllocRejCode) {}
        public AllocRejCode(int val)
            :base(Fields.CustomTags.AllocRejCode, val) {}


        // Field Enumerations
        public const int UNKNOWN_ACCOUNT = 0;
        public const int INCORRECT_QUANTITY = 1;
        public const int UNKNOWN_OR_STALE_EXECID = 10;
        public const int MISMATCHED_DATA = 11;
        public const int UNKNOWN_CLORDID = 12;
        public const int WAREHOUSE_REQUEST_REJECTED = 13;
        public const int INCORRECT_AVERAGEG_PRICE = 2;
        public const int UNKNOWN_EXECUTING_BROKER_MNEMONIC = 3;
        public const int COMMISSION_DIFFERENCE = 4;
        public const int UNKNOWN_ORDERID = 5;
        public const int UNKNOWN_LISTID = 6;
        public const int OTHER_7 = 7;
        public const int INCORRECT_ALLOCATED_QUANTITY = 8;
        public const int CALCULATION_DIFFERENCE = 9;
        public const int OTHER_99 = 99;
        public const int OTHER = 7;
        public const int INCORRECT_AVERAGE_PRICE = 2;
    }


    /// <summary>
    /// Signature Field
    /// </summary>/
    public sealed class Signature : QuickFix.Fields.StringField
    {
        public Signature()
            :base(Fields.CustomTags.Signature) {}
        public Signature(string val)
            :base(Fields.CustomTags.Signature, val) {}

    }


    /// <summary>
    /// SecureDataLen Field
    /// </summary>/
    public sealed class SecureDataLen : QuickFix.Fields.IntField
    {
        public SecureDataLen()
            :base(Fields.CustomTags.SecureDataLen) {}
        public SecureDataLen(int val)
            :base(Fields.CustomTags.SecureDataLen, val) {}

    }


    /// <summary>
    /// SecureData Field
    /// </summary>/
    public sealed class SecureData : QuickFix.Fields.StringField
    {
        public SecureData()
            :base(Fields.CustomTags.SecureData) {}
        public SecureData(string val)
            :base(Fields.CustomTags.SecureData, val) {}

    }


    /// <summary>
    /// BrokerOfCredit Field
    /// </summary>/
    public sealed class BrokerOfCredit : QuickFix.Fields.StringField
    {
        public BrokerOfCredit()
            :base(Fields.CustomTags.BrokerOfCredit) {}
        public BrokerOfCredit(string val)
            :base(Fields.CustomTags.BrokerOfCredit, val) {}

    }


    /// <summary>
    /// SignatureLength Field
    /// </summary>/
    public sealed class SignatureLength : QuickFix.Fields.IntField
    {
        public SignatureLength()
            :base(Fields.CustomTags.SignatureLength) {}
        public SignatureLength(int val)
            :base(Fields.CustomTags.SignatureLength, val) {}

    }


    /// <summary>
    /// EmailType Field
    /// </summary>/
    public sealed class EmailType : QuickFix.Fields.CharField
    {
        public EmailType()
            :base(Fields.CustomTags.EmailType) {}
        public EmailType(char val)
            :base(Fields.CustomTags.EmailType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char REPLY = '1';
        public const char ADMIN_REPLY = '2';
    }


    /// <summary>
    /// RawDataLength Field
    /// </summary>/
    public sealed class RawDataLength : QuickFix.Fields.IntField
    {
        public RawDataLength()
            :base(Fields.CustomTags.RawDataLength) {}
        public RawDataLength(int val)
            :base(Fields.CustomTags.RawDataLength, val) {}

    }


    /// <summary>
    /// RawData Field
    /// </summary>/
    public sealed class RawData : QuickFix.Fields.StringField
    {
        public RawData()
            :base(Fields.CustomTags.RawData) {}
        public RawData(string val)
            :base(Fields.CustomTags.RawData, val) {}

    }


    /// <summary>
    /// PossResend Field
    /// </summary>/
    public sealed class PossResend : QuickFix.Fields.BooleanField
    {
        public PossResend()
            :base(Fields.CustomTags.PossResend) {}
        public PossResend(Boolean val)
            :base(Fields.CustomTags.PossResend, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// EncryptMethod Field
    /// </summary>/
    public sealed class EncryptMethod : QuickFix.Fields.IntField
    {
        public EncryptMethod()
            :base(Fields.CustomTags.EncryptMethod) {}
        public EncryptMethod(int val)
            :base(Fields.CustomTags.EncryptMethod, val) {}


        // Field Enumerations
        public const int NONE = 0;
        public const int PKCS_1 = 1;
        public const int DES = 2;
        public const int PKCS_3 = 3;
        public const int PGP_4 = 4;
        public const int PGP_5 = 5;
        public const int PEM = 6;
        public const int PKCS_PROPRIETARY = 1;
        public const int PKCS_DES = 3;
        public const int PGP_DES = 4;
        public const int PGP_DES_MD5 = 5;
        public const int NONE_OTHER = 0;
        public const int PKCS = 1;
        public const int PKCSDES = 3;
        public const int PGPDES = 4;
        public const int PGPDESMD5 = 5;
        public const int PEMDESMD5 = 6;
    }


    /// <summary>
    /// StopPx Field
    /// </summary>/
    public sealed class StopPx : QuickFix.Fields.DecimalField
    {
        public StopPx()
            :base(Fields.CustomTags.StopPx) {}
        public StopPx(Decimal val)
            :base(Fields.CustomTags.StopPx, val) {}

    }


    /// <summary>
    /// ExDestination Field
    /// </summary>/
    public sealed class ExDestination : QuickFix.Fields.StringField
    {
        public ExDestination()
            :base(Fields.CustomTags.ExDestination) {}
        public ExDestination(string val)
            :base(Fields.CustomTags.ExDestination, val) {}


        // Field Enumerations
        public const string NONE = "0";
        public const string POSIT = "4";
    }


    /// <summary>
    /// CxlRejReason Field
    /// </summary>/
    public sealed class CxlRejReason : QuickFix.Fields.IntField
    {
        public CxlRejReason()
            :base(Fields.CustomTags.CxlRejReason) {}
        public CxlRejReason(int val)
            :base(Fields.CustomTags.CxlRejReason, val) {}


        // Field Enumerations
        public const int TOO_LATE_TO_CANCEL = 0;
        public const int UNKNOWN_ORDER = 1;
        public const int BROKER = 2;
        public const int ORDER_ALREADY_IN_PENDING_CANCEL_OR_PENDING_REPLACE_STATUS = 3;
        public const int UNABLE_TO_PROCESS_ORDER_MASS_CANCEL_REQUEST = 4;
        public const int ORIGORDMODTIME = 5;
        public const int DUPLICATE_CLORDID = 6;
        public const int OTHER = 99;
        public const int INVALID_PRICE_INCREMENT = 18;
        public const int PRICE_EXCEEDS_CURRENT_PRICE = 7;
        public const int PRICE_EXCEEDS_CURRENT_PRICE_BAND = 8;
        public const int BROKER_OPTION = 2;
        public const int DUPLICATE_OF_A_VERBALLY_COMMUNICATED_ORDER = 7;
        public const int STALE_ORDER = 8;
        public const int TRADE_ALONG_REQUIRED = 9;
        public const int INVALID_INVESTOR_ID = 10;
        public const int UNSUPPORTED_ORDER_CHARACTERISTIC = 11;
        public const int SURVEILLENCE_OPTION = 12;
        public const int INCORRECT_QUANTITY = 13;
        public const int INCORRECT_ALLOCATED_QUANTITY = 14;
        public const int UNKNOWN_ACCOUNT = 15;
        public const int MESSAGE_PENDING = 19;
        public const int ROUTING_ERROR = 20;
        public const int MARKET_CLOSED = 1003;
        public const int FIX_FIELD_MISSING_OR_INCORRECT = 1007;
        public const int REQUIRED_FIELD_MISSING = 1010;
        public const int FIX_FIELD_INCORRECT = 1011;
        public const int PRICE_MUST_BE_GREATER_THAN_ZERO = 1012;
        public const int INVALID_ORDER_QUALIFIER = 1013;
        public const int USER_NOT_AUTHORIZED = 1014;
        public const int MARKET_ORDERS_NOT_SUPPORTED_BY_OPPOSITE = 2013;
        public const int INVALID_EXPIRE_DATE = 2019;
        public const int ORDER_NOT_IN_BOOK = 2044;
        public const int ORDER_NOT_IN_BOOK2 = 2045;
        public const int DISCLOSED_QTY_CANNOT_BE_GREATER = 2046;
        public const int UNKNOWN_CONTRACT = 2047;
        public const int CANCEL_WITH_DIFFERENT_SENDER_COMP_ID = 2048;
        public const int CLORDID_DIFFERENT_THAN_CORRELATIONCLORDID = 2049;
        public const int CLORDID_DIFFERENT_THAN_ORIGINALCLORDID = 2050;
        public const int DIFFERENT_SIDE = 2051;
        public const int DIFFERENT_GROUP = 2052;
        public const int DIFFERENT_SECURITY_TYPE = 2053;
        public const int DIFFERENT_ACCOUNT = 2054;
        public const int DIFFERENT_QTY = 2055;
        public const int CANCEL_WITH_DIFFERENT_TRADER_ID = 2056;
        public const int STOP_PRICE_MUST_BE_GREATER = 2058;
        public const int STOP_PRICE_MUST_BE_SMALLER = 2059;
        public const int SELL_STOP_PRICE_MUST_BE_BELOW_LTP = 2060;
        public const int BUY_STOP_PRICE_MUST_BE_ABOVE_LTP = 2061;
        public const int DIFFERENT_PRODUCT = 2100;
        public const int DIFFERENT_INFLIGHT_FILL_MITIGATION = 2101;
        public const int MODIFY_WITH_DIFFERENT_SENDER_COMP_ID = 2102;
        public const int MODIFY_WITH_DIFFERENT_TRADER_ID = 2103;
        public const int ORDER_QTY_OUTSIDE_ALLOWABLE_RANGE = 2115;
        public const int INVALID_ORDER_TYPE_FOR_PCP = 2130;
        public const int ORDER_PRICE_OUTSIDE_LIMITS = 2137;
        public const int ORDER_PRICE_OUTSIDE_BANDS = 2179;
        public const int INVALID_ORDER_TYPE_FOR_GROUP = 2311;
        public const int INSTRUMENT_CROSS_REQUEST_IN_PROGRESS = 2500;
        public const int ORDER_QTY_TOO_LOW = 2501;
        public const int MARKET_MAKER_PROTECTION_HAS_TRIPPED = 2600;
        public const int ENGINE_DID_NOT_RESPOND = 4000;
        public const int EURONEXT_UNKNOWN_ORDER = 5001;
        public const int EURONEXT_OTHER = 5099;
        public const int COMP_ID_PROBLEM = 5020;
        public const int LOGON_PROBLEM = 5300;
        public const int NO_ROUTER_FOR_SECURITY_GROUP = 5313;
        public const int ROUTER_NOT_AVAILABLE_OR_CONNECTED = 5314;
        public const int INVALID_PRICE = 5318;
        public const int INVALID_ORDQTY = 5319;
        public const int INVALID_ORDTYPE = 5320;
        public const int INVALID_SIDE = 5321;
        public const int FULLY_FILLED = 6000;
        public const int PENDING_REPLACE = 6001;
        public const int PENDING_CANCEL = 6002;
        public const int ORDER_REJECTED = 7000;
        public const int CONTRACT_NOT_GTC_GTD_ELIGIBLE = 7001;
        public const int CONTRACT_PAST_EXPIRATION = 7009;
        public const int MAX_CONTRACT_WORKING_QTY_EXCEEDED = 7011;
        public const int MODIFY_WITH_DIFFERENT_SIDE = 7015;
        public const int CONTRACT_NOT_GTC_GTD_ELIGIBLE2 = 7018;
        public const int NO_TRADING_CALENDAR_FOR_EXPIRE_DATE = 7020;
        public const int EXPIRE_DATE_BEYOND_INSTRUMENT_EXPIRATION = 7021;
        public const int EXPIRE_DATE_BEYOND_LEG_INSTRUMENT_EXPIRATION = 7022;
        public const int MARKET_IN_NO_CANCEL = 7024;
        public const int INVALID_ORDER_TYPE_FOR_RESERVED_MARKET = 7027;
        public const int ORDER_SESSION_DATE_IN_PAST = 7028;
        public const int DISCLOSED_QTY_CANNOT_BE_SMALLER = 7613;
        public const int TECHNICAL_ERROR_FUNCTION_NOT_PERFORMED = 9999;
        public const int ALREADY_PENDING = 3;
        public const int ORIGORDMODTIME_DID_NOT_MATCH_LAST_TRANSACTTIME_OF_ORDER = 5;
        public const int DUPLICATE_CLORDID_RECEIVED = 6;
    }


    /// <summary>
    /// OrdRejReason Field
    /// </summary>/
    public sealed class OrdRejReason : QuickFix.Fields.IntField
    {
        public OrdRejReason()
            :base(Fields.CustomTags.OrdRejReason) {}
        public OrdRejReason(int val)
            :base(Fields.CustomTags.OrdRejReason, val) {}


        // Field Enumerations
        public const int BROKER = 0;
        public const int UNKNOWN_SYMBOL = 1;
        public const int INVALID_INVESTOR_ID = 10;
        public const int UNSUPPORTED_ORDER_CHARACTERISTIC = 11;
        public const int SURVEILLENCE_OPTION = 12;
        public const int INCORRECT_QUANTITY = 13;
        public const int INCORRECT_ALLOCATED_QUANTITY = 14;
        public const int UNKNOWN_ACCOUNT = 15;
        public const int EXCHANGE_CLOSED = 2;
        public const int ORDER_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_ORDER = 5;
        public const int DUPLICATE_ORDER = 6;
        public const int DUPLICATE_OF_A_VERBALLY_COMMUNICATED_ORDER = 7;
        public const int STALE_ORDER = 8;
        public const int TRADE_ALONG_REQUIRED = 9;
        public const int OTHER = 99;
        public const int INVALID_PRICE_INCREMENT = 18;
        public const int PRICE_EXCEEDS_CURRENT_PRICE_BAND = 16;
        public const int BROKER_OPTION = 0;
        public const int MESSAGE_PENDING = 19;
        public const int ROUTING_ERROR = 20;
        public const int MARKET_CLOSED = 1003;
        public const int FIX_FIELD_MISSING_OR_INCORRECT = 1007;
        public const int REQUIRED_FIELD_MISSING = 1010;
        public const int FIX_FIELD_INCORRECT = 1011;
        public const int PRICE_MUST_BE_GREATER_THAN_ZERO = 1012;
        public const int INVALID_ORDER_QUALIFIER = 1013;
        public const int USER_NOT_AUTHORIZED = 1014;
        public const int MARKET_HOURS_NOT_SUPORTED_BY_OPPOSITE = 2013;
        public const int INVALID_EXPIRE_DATE = 2019;
        public const int ORDER_NOT_IN_BOOK = 2044;
        public const int ORDER_NOT_IN_BOOK_2 = 2045;
        public const int DISCLOSED_QTY_CANNOT_BE_GREATER = 2046;
        public const int UNKNOWN_CONTRACT = 2047;
        public const int CANCEL_WITH_DIFFERENT_SENDER_COMP_ID = 2048;
        public const int CLORDID_DIFFERENT_THAN_CORRELEATION_CLORDID = 2049;
        public const int CLORDID_DIFFERENT_THAN_ORIGINAL_CLORDID = 2050;
        public const int DIFFERENT_SIDE = 2051;
        public const int DIFFERENT_GROUP = 2052;
        public const int DIFFERENT_SECURITY_TYPE = 2053;
        public const int DIFFERENT_ACCOUNT = 2054;
        public const int DIFFERENT_QTY = 2055;
        public const int CANCEL_WITH_DIFFERENT_TRADER_ID = 2056;
        public const int STOP_PRICE_MUST_BE_GREATER = 2058;
        public const int STOP_PRICE_MUST_BE_SMALLER = 2059;
        public const int SELL_STOP_PRICE_MUST_BE_BELOW_LTP = 2060;
        public const int BUY_STOP_PRICE_MUST_BE_ABOVE_LTP = 2061;
        public const int DIFFERENT_PRODUCT = 2100;
        public const int DIFFERENT_INFLIGHT_FILL_MODIFICATION = 2101;
        public const int MODIFY_WITH_DIFFERENT_SENDER_COMP_ID = 2102;
        public const int MODIFY_WITH_DIFFERENT_TRADER_ID = 2103;
        public const int ORDER_QTY_OUTSIDE_ALLOWABLE_RANGE = 2115;
        public const int INVALID_ORDER_TYPE_FOR_PCP = 2130;
        public const int ORDER_PRICE_OUTSIDE_LIMITS = 2137;
        public const int ORDER_PRICE_OUTSIDE_BANDS = 2179;
        public const int INVALID_ORDER_TYPE_FOR_GROUP = 2311;
        public const int INSTRUMENT_CROSS_REQUEST_IN_PROCESS = 2500;
        public const int ORDR_QTY_TOO_LOW = 2501;
        public const int MARKET_MAKER_PROTECTION_HAS_TRIPPED = 2600;
        public const int ENGINE_DID_NOT_RESPOND = 4000;
        public const int PENDING_REPLACE = 6001;
        public const int PENDING_CANCEL = 6002;
        public const int ORDER_REJECTED = 7000;
        public const int CONTRACT_NOT_GTC_GTD_ELIGIBLE = 7001;
        public const int CONTRACT_PAST_EXPIRATION = 7009;
        public const int MAX_CONTRACT_WORKING_QTY_EXCEEDED = 7011;
        public const int MODIFY_WITH_DIFFERENT_SIDE = 7015;
        public const int CONTRACT_NOT_GTC_GTD_ELIGIBLE_2 = 7018;
        public const int NO_TRADING_CALENDAR_FOR_EXPIRE_DATE = 7020;
        public const int EXPIRE_DATE_BEYOND_INSTRUMENT_EXPIRATION = 7021;
        public const int EXPIRE_DATE_BEYOND_LEG_INSTRUMENT_EXPIRATION = 7022;
        public const int MARKET_IN_NO_CANCEL = 7024;
        public const int INVALID_ORDER_TYPE_FOR_RESERVED_MARKET = 7027;
        public const int ORDER_SESSION_DATE_IN_PAST = 7028;
        public const int DISCLOSED_QTY_CANNOT_BE_SMALLER = 7613;
        public const int TECHNICAL_ERROR_FUNCTION_NOT_PERFORMED = 9999;
        public const int DUPLICATE_VERBAL = 7;
        public const int DUPLICATE_VERBALYES = 7;
    }


    /// <summary>
    /// IOIQualifier Field
    /// </summary>/
    public sealed class IOIQualifier : QuickFix.Fields.CharField
    {
        public IOIQualifier()
            :base(Fields.CustomTags.IOIQualifier) {}
        public IOIQualifier(char val)
            :base(Fields.CustomTags.IOIQualifier, val) {}


        // Field Enumerations
        public const char ALL_OR_NONE = 'A';
        public const char MARKET_ON_CLOSE = 'B';
        public const char AT_THE_CLOSE = 'C';
        public const char VWAP = 'D';
        public const char IN_TOUCH_WITH = 'I';
        public const char LIMIT = 'L';
        public const char MORE_BEHIND = 'M';
        public const char AT_THE_OPEN = 'O';
        public const char TAKING_A_POSITION = 'P';
        public const char AT_THE_MARKET = 'Q';
        public const char READY_TO_TRADE = 'R';
        public const char PORTFOLIO_SHOWN = 'S';
        public const char THROUGH_THE_DAY = 'T';
        public const char VERSUS = 'V';
        public const char INDICATION = 'W';
        public const char CROSSING_OPPORTUNITY = 'X';
        public const char AT_THE_MIDPOINT = 'Y';
        public const char PRE_OPEN = 'Z';
        public const char INDIDCATION = 'W';
        public const char INDICATION_WORKING_AWAY = 'W';
        public const char PREOPEN = 'Z';
        public const char CURRENT_QUOTE = 'Q';
    }


    /// <summary>
    /// WaveNo Field
    /// </summary>/
    public sealed class WaveNo : QuickFix.Fields.StringField
    {
        public WaveNo()
            :base(Fields.CustomTags.WaveNo) {}
        public WaveNo(string val)
            :base(Fields.CustomTags.WaveNo, val) {}

    }


    /// <summary>
    /// Issuer Field
    /// </summary>/
    public sealed class Issuer : QuickFix.Fields.StringField
    {
        public Issuer()
            :base(Fields.CustomTags.Issuer) {}
        public Issuer(string val)
            :base(Fields.CustomTags.Issuer, val) {}

    }


    /// <summary>
    /// SecurityDesc Field
    /// </summary>/
    public sealed class SecurityDesc : QuickFix.Fields.StringField
    {
        public SecurityDesc()
            :base(Fields.CustomTags.SecurityDesc) {}
        public SecurityDesc(string val)
            :base(Fields.CustomTags.SecurityDesc, val) {}

    }


    /// <summary>
    /// HeartBtInt Field
    /// </summary>/
    public sealed class HeartBtInt : QuickFix.Fields.IntField
    {
        public HeartBtInt()
            :base(Fields.CustomTags.HeartBtInt) {}
        public HeartBtInt(int val)
            :base(Fields.CustomTags.HeartBtInt, val) {}

    }


    /// <summary>
    /// ClientID Field
    /// </summary>/
    public sealed class ClientID : QuickFix.Fields.StringField
    {
        public ClientID()
            :base(Fields.CustomTags.ClientID) {}
        public ClientID(string val)
            :base(Fields.CustomTags.ClientID, val) {}

    }


    /// <summary>
    /// MinQty Field
    /// </summary>/
    public sealed class MinQty : QuickFix.Fields.DecimalField
    {
        public MinQty()
            :base(Fields.CustomTags.MinQty) {}
        public MinQty(Decimal val)
            :base(Fields.CustomTags.MinQty, val) {}

    }


    /// <summary>
    /// MaxFloor Field
    /// </summary>/
    public sealed class MaxFloor : QuickFix.Fields.DecimalField
    {
        public MaxFloor()
            :base(Fields.CustomTags.MaxFloor) {}
        public MaxFloor(Decimal val)
            :base(Fields.CustomTags.MaxFloor, val) {}

    }


    /// <summary>
    /// TestReqID Field
    /// </summary>/
    public sealed class TestReqID : QuickFix.Fields.StringField
    {
        public TestReqID()
            :base(Fields.CustomTags.TestReqID) {}
        public TestReqID(string val)
            :base(Fields.CustomTags.TestReqID, val) {}

    }


    /// <summary>
    /// ReportToExch Field
    /// </summary>/
    public sealed class ReportToExch : QuickFix.Fields.BooleanField
    {
        public ReportToExch()
            :base(Fields.CustomTags.ReportToExch) {}
        public ReportToExch(Boolean val)
            :base(Fields.CustomTags.ReportToExch, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// LocateReqd Field
    /// </summary>/
    public sealed class LocateReqd : QuickFix.Fields.BooleanField
    {
        public LocateReqd()
            :base(Fields.CustomTags.LocateReqd) {}
        public LocateReqd(Boolean val)
            :base(Fields.CustomTags.LocateReqd, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// OnBehalfOfCompID Field
    /// </summary>/
    public sealed class OnBehalfOfCompID : QuickFix.Fields.StringField
    {
        public OnBehalfOfCompID()
            :base(Fields.CustomTags.OnBehalfOfCompID) {}
        public OnBehalfOfCompID(string val)
            :base(Fields.CustomTags.OnBehalfOfCompID, val) {}

    }


    /// <summary>
    /// OnBehalfOfSubID Field
    /// </summary>/
    public sealed class OnBehalfOfSubID : QuickFix.Fields.StringField
    {
        public OnBehalfOfSubID()
            :base(Fields.CustomTags.OnBehalfOfSubID) {}
        public OnBehalfOfSubID(string val)
            :base(Fields.CustomTags.OnBehalfOfSubID, val) {}

    }


    /// <summary>
    /// QuoteID Field
    /// </summary>/
    public sealed class QuoteID : QuickFix.Fields.StringField
    {
        public QuoteID()
            :base(Fields.CustomTags.QuoteID) {}
        public QuoteID(string val)
            :base(Fields.CustomTags.QuoteID, val) {}

    }


    /// <summary>
    /// NetMoney Field
    /// </summary>/
    public sealed class NetMoney : QuickFix.Fields.DecimalField
    {
        public NetMoney()
            :base(Fields.CustomTags.NetMoney) {}
        public NetMoney(Decimal val)
            :base(Fields.CustomTags.NetMoney, val) {}

    }


    /// <summary>
    /// SettlCurrAmt Field
    /// </summary>/
    public sealed class SettlCurrAmt : QuickFix.Fields.DecimalField
    {
        public SettlCurrAmt()
            :base(Fields.CustomTags.SettlCurrAmt) {}
        public SettlCurrAmt(Decimal val)
            :base(Fields.CustomTags.SettlCurrAmt, val) {}

    }


    /// <summary>
    /// SettlCurrency Field
    /// </summary>/
    public sealed class SettlCurrency : QuickFix.Fields.StringField
    {
        public SettlCurrency()
            :base(Fields.CustomTags.SettlCurrency) {}
        public SettlCurrency(string val)
            :base(Fields.CustomTags.SettlCurrency, val) {}

    }


    /// <summary>
    /// ForexReq Field
    /// </summary>/
    public sealed class ForexReq : QuickFix.Fields.BooleanField
    {
        public ForexReq()
            :base(Fields.CustomTags.ForexReq) {}
        public ForexReq(Boolean val)
            :base(Fields.CustomTags.ForexReq, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// OrigSendingTime Field
    /// </summary>/
    public sealed class OrigSendingTime : QuickFix.Fields.DateTimeField
    {
        public OrigSendingTime()
            :base(Fields.CustomTags.OrigSendingTime) {}
        public OrigSendingTime(DateTime val)
            :base(Fields.CustomTags.OrigSendingTime, val) {}
        public OrigSendingTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.OrigSendingTime, val, showMilliseconds) {}
		public OrigSendingTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.OrigSendingTime, val, precision) {}

    }


    /// <summary>
    /// GapFillFlag Field
    /// </summary>/
    public sealed class GapFillFlag : QuickFix.Fields.BooleanField
    {
        public GapFillFlag()
            :base(Fields.CustomTags.GapFillFlag) {}
        public GapFillFlag(Boolean val)
            :base(Fields.CustomTags.GapFillFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean GAP_FILL_MESSAGE_MSGSEQNUM_FIELD_VALID = true;
        public const Boolean SEQUENCE_RESET_IGNORE_MSGSEQNUM = false;
    }


    /// <summary>
    /// NoExecs Field
    /// </summary>/
    public sealed class NoExecs : QuickFix.Fields.IntField
    {
        public NoExecs()
            :base(Fields.CustomTags.NoExecs) {}
        public NoExecs(int val)
            :base(Fields.CustomTags.NoExecs, val) {}

    }


    /// <summary>
    /// CxlType Field
    /// </summary>/
    public sealed class CxlType : QuickFix.Fields.CharField
    {
        public CxlType()
            :base(Fields.CustomTags.CxlType) {}
        public CxlType(char val)
            :base(Fields.CustomTags.CxlType, val) {}


        // Field Enumerations
        public const char PARTIAL_CANCEL = 'P';
        public const char FULL_REMAINING_QUANTITY = 'F';
    }


    /// <summary>
    /// ExpireTime Field
    /// </summary>/
    public sealed class ExpireTime : QuickFix.Fields.DateTimeField
    {
        public ExpireTime()
            :base(Fields.CustomTags.ExpireTime) {}
        public ExpireTime(DateTime val)
            :base(Fields.CustomTags.ExpireTime, val) {}
        public ExpireTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.ExpireTime, val, showMilliseconds) {}
		public ExpireTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.ExpireTime, val, precision) {}

    }


    /// <summary>
    /// DKReason Field
    /// </summary>/
    public sealed class DKReason : QuickFix.Fields.CharField
    {
        public DKReason()
            :base(Fields.CustomTags.DKReason) {}
        public DKReason(char val)
            :base(Fields.CustomTags.DKReason, val) {}


        // Field Enumerations
        public const char UNKNOWN_SYMBOL = 'A';
        public const char WRONG_SIDE = 'B';
        public const char QUANTITY_EXCEEDS_ORDER = 'C';
        public const char NO_MATCHING_ORDER = 'D';
        public const char PRICE_EXCEEDS_LIMIT = 'E';
        public const char CALCULATION_DIFFERENCE = 'F';
        public const char OTHER = 'Z';
    }


    /// <summary>
    /// DeliverToCompID Field
    /// </summary>/
    public sealed class DeliverToCompID : QuickFix.Fields.StringField
    {
        public DeliverToCompID()
            :base(Fields.CustomTags.DeliverToCompID) {}
        public DeliverToCompID(string val)
            :base(Fields.CustomTags.DeliverToCompID, val) {}

    }


    /// <summary>
    /// DeliverToSubID Field
    /// </summary>/
    public sealed class DeliverToSubID : QuickFix.Fields.StringField
    {
        public DeliverToSubID()
            :base(Fields.CustomTags.DeliverToSubID) {}
        public DeliverToSubID(string val)
            :base(Fields.CustomTags.DeliverToSubID, val) {}

    }


    /// <summary>
    /// IOINaturalFlag Field
    /// </summary>/
    public sealed class IOINaturalFlag : QuickFix.Fields.BooleanField
    {
        public IOINaturalFlag()
            :base(Fields.CustomTags.IOINaturalFlag) {}
        public IOINaturalFlag(Boolean val)
            :base(Fields.CustomTags.IOINaturalFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean NATURAL = true;
        public const Boolean NOT_NATURAL = false;
    }


    /// <summary>
    /// QuoteReqID Field
    /// </summary>/
    public sealed class QuoteReqID : QuickFix.Fields.StringField
    {
        public QuoteReqID()
            :base(Fields.CustomTags.QuoteReqID) {}
        public QuoteReqID(string val)
            :base(Fields.CustomTags.QuoteReqID, val) {}

    }


    /// <summary>
    /// BidPx Field
    /// </summary>/
    public sealed class BidPx : QuickFix.Fields.DecimalField
    {
        public BidPx()
            :base(Fields.CustomTags.BidPx) {}
        public BidPx(Decimal val)
            :base(Fields.CustomTags.BidPx, val) {}

    }


    /// <summary>
    /// OfferPx Field
    /// </summary>/
    public sealed class OfferPx : QuickFix.Fields.DecimalField
    {
        public OfferPx()
            :base(Fields.CustomTags.OfferPx) {}
        public OfferPx(Decimal val)
            :base(Fields.CustomTags.OfferPx, val) {}

    }


    /// <summary>
    /// BidSize Field
    /// </summary>/
    public sealed class BidSize : QuickFix.Fields.DecimalField
    {
        public BidSize()
            :base(Fields.CustomTags.BidSize) {}
        public BidSize(Decimal val)
            :base(Fields.CustomTags.BidSize, val) {}

    }


    /// <summary>
    /// OfferSize Field
    /// </summary>/
    public sealed class OfferSize : QuickFix.Fields.DecimalField
    {
        public OfferSize()
            :base(Fields.CustomTags.OfferSize) {}
        public OfferSize(Decimal val)
            :base(Fields.CustomTags.OfferSize, val) {}

    }


    /// <summary>
    /// NoMiscFees Field
    /// </summary>/
    public sealed class NoMiscFees : QuickFix.Fields.IntField
    {
        public NoMiscFees()
            :base(Fields.CustomTags.NoMiscFees) {}
        public NoMiscFees(int val)
            :base(Fields.CustomTags.NoMiscFees, val) {}

    }


    /// <summary>
    /// MiscFeeAmt Field
    /// </summary>/
    public sealed class MiscFeeAmt : QuickFix.Fields.DecimalField
    {
        public MiscFeeAmt()
            :base(Fields.CustomTags.MiscFeeAmt) {}
        public MiscFeeAmt(Decimal val)
            :base(Fields.CustomTags.MiscFeeAmt, val) {}

    }


    /// <summary>
    /// MiscFeeCurr Field
    /// </summary>/
    public sealed class MiscFeeCurr : QuickFix.Fields.StringField
    {
        public MiscFeeCurr()
            :base(Fields.CustomTags.MiscFeeCurr) {}
        public MiscFeeCurr(string val)
            :base(Fields.CustomTags.MiscFeeCurr, val) {}

    }


    /// <summary>
    /// MiscFeeType Field
    /// </summary>/
    public sealed class MiscFeeType : QuickFix.Fields.StringField
    {
        public MiscFeeType()
            :base(Fields.CustomTags.MiscFeeType) {}
        public MiscFeeType(string val)
            :base(Fields.CustomTags.MiscFeeType, val) {}


        // Field Enumerations
        public const string REGULATORY = "1";
        public const string PER_TRANSACTION = "10";
        public const string CONVERSION = "11";
        public const string AGENT = "12";
        public const string TAX = "2";
        public const string LOCAL_COMMISSION = "3";
        public const string EXCHANGE_FEES = "4";
        public const string STAMP = "5";
        public const string LEVY = "6";
        public const string OTHER = "7";
        public const string MARKUP = "8";
        public const string CONSUMPTION_TAX = "9";
        public const string TRANSFER_FEE = "13";
        public const string SECURITY_LENDING = "14";
    }


    /// <summary>
    /// PrevClosePx Field
    /// </summary>/
    public sealed class PrevClosePx : QuickFix.Fields.DecimalField
    {
        public PrevClosePx()
            :base(Fields.CustomTags.PrevClosePx) {}
        public PrevClosePx(Decimal val)
            :base(Fields.CustomTags.PrevClosePx, val) {}

    }


    /// <summary>
    /// ResetSeqNumFlag Field
    /// </summary>/
    public sealed class ResetSeqNumFlag : QuickFix.Fields.BooleanField
    {
        public ResetSeqNumFlag()
            :base(Fields.CustomTags.ResetSeqNumFlag) {}
        public ResetSeqNumFlag(Boolean val)
            :base(Fields.CustomTags.ResetSeqNumFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean YES_RESET_SEQUENCE_NUMBERS = true;
    }


    /// <summary>
    /// SenderLocationID Field
    /// </summary>/
    public sealed class SenderLocationID : QuickFix.Fields.StringField
    {
        public SenderLocationID()
            :base(Fields.CustomTags.SenderLocationID) {}
        public SenderLocationID(string val)
            :base(Fields.CustomTags.SenderLocationID, val) {}

    }


    /// <summary>
    /// TargetLocationID Field
    /// </summary>/
    public sealed class TargetLocationID : QuickFix.Fields.StringField
    {
        public TargetLocationID()
            :base(Fields.CustomTags.TargetLocationID) {}
        public TargetLocationID(string val)
            :base(Fields.CustomTags.TargetLocationID, val) {}

    }


    /// <summary>
    /// OnBehalfOfLocationID Field
    /// </summary>/
    public sealed class OnBehalfOfLocationID : QuickFix.Fields.StringField
    {
        public OnBehalfOfLocationID()
            :base(Fields.CustomTags.OnBehalfOfLocationID) {}
        public OnBehalfOfLocationID(string val)
            :base(Fields.CustomTags.OnBehalfOfLocationID, val) {}

    }


    /// <summary>
    /// DeliverToLocationID Field
    /// </summary>/
    public sealed class DeliverToLocationID : QuickFix.Fields.StringField
    {
        public DeliverToLocationID()
            :base(Fields.CustomTags.DeliverToLocationID) {}
        public DeliverToLocationID(string val)
            :base(Fields.CustomTags.DeliverToLocationID, val) {}

    }


    /// <summary>
    /// NoRelatedSym Field
    /// </summary>/
    public sealed class NoRelatedSym : QuickFix.Fields.IntField
    {
        public NoRelatedSym()
            :base(Fields.CustomTags.NoRelatedSym) {}
        public NoRelatedSym(int val)
            :base(Fields.CustomTags.NoRelatedSym, val) {}

    }


    /// <summary>
    /// Subject Field
    /// </summary>/
    public sealed class Subject : QuickFix.Fields.StringField
    {
        public Subject()
            :base(Fields.CustomTags.Subject) {}
        public Subject(string val)
            :base(Fields.CustomTags.Subject, val) {}

    }


    /// <summary>
    /// Headline Field
    /// </summary>/
    public sealed class Headline : QuickFix.Fields.StringField
    {
        public Headline()
            :base(Fields.CustomTags.Headline) {}
        public Headline(string val)
            :base(Fields.CustomTags.Headline, val) {}

    }


    /// <summary>
    /// URLLink Field
    /// </summary>/
    public sealed class URLLink : QuickFix.Fields.StringField
    {
        public URLLink()
            :base(Fields.CustomTags.URLLink) {}
        public URLLink(string val)
            :base(Fields.CustomTags.URLLink, val) {}

    }


    /// <summary>
    /// ExecType Field
    /// </summary>/
    public sealed class ExecType : QuickFix.Fields.CharField
    {
        public ExecType()
            :base(Fields.CustomTags.ExecType) {}
        public ExecType(char val)
            :base(Fields.CustomTags.ExecType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char DONE_FOR_DAY = '3';
        public const char CANCELED = '4';
        public const char REPLACED = '5';
        public const char PENDING_CANCEL = '6';
        public const char STOPPED = '7';
        public const char REJECTED = '8';
        public const char SUSPENDED = '9';
        public const char PENDING_NEW = 'A';
        public const char CALCULATED = 'B';
        public const char EXPIRED = 'C';
        public const char RESTATED = 'D';
        public const char PENDING_REPLACE = 'E';
        public const char TRADE = 'F';
        public const char TRADE_CORRECT = 'G';
        public const char TRADE_CANCEL = 'H';
        public const char ORDER_STATUS = 'I';
        public const char TRADE_IN_A_CLEARING_HOLD = 'J';
        public const char TRADE_HAS_BEEN_RELEASED_TO_CLEARING = 'K';
        public const char TRIGGERED_OR_ACTIVATED_BY_SYSTEM = 'L';
        public const char PARTIAL_FILL = '1';
        public const char FILL = '2';
        public const char REPLACE = '5';
        public const char CANCELLED = '4';
        public const char PENDING_CANCELREPLACE = '6';
    }


    /// <summary>
    /// LeavesQty Field
    /// </summary>/
    public sealed class LeavesQty : QuickFix.Fields.DecimalField
    {
        public LeavesQty()
            :base(Fields.CustomTags.LeavesQty) {}
        public LeavesQty(Decimal val)
            :base(Fields.CustomTags.LeavesQty, val) {}

    }


    /// <summary>
    /// CashOrderQty Field
    /// </summary>/
    public sealed class CashOrderQty : QuickFix.Fields.DecimalField
    {
        public CashOrderQty()
            :base(Fields.CustomTags.CashOrderQty) {}
        public CashOrderQty(Decimal val)
            :base(Fields.CustomTags.CashOrderQty, val) {}

    }


    /// <summary>
    /// AllocAvgPx Field
    /// </summary>/
    public sealed class AllocAvgPx : QuickFix.Fields.DecimalField
    {
        public AllocAvgPx()
            :base(Fields.CustomTags.AllocAvgPx) {}
        public AllocAvgPx(Decimal val)
            :base(Fields.CustomTags.AllocAvgPx, val) {}

    }


    /// <summary>
    /// AllocNetMoney Field
    /// </summary>/
    public sealed class AllocNetMoney : QuickFix.Fields.DecimalField
    {
        public AllocNetMoney()
            :base(Fields.CustomTags.AllocNetMoney) {}
        public AllocNetMoney(Decimal val)
            :base(Fields.CustomTags.AllocNetMoney, val) {}

    }


    /// <summary>
    /// SettlCurrFxRate Field
    /// </summary>/
    public sealed class SettlCurrFxRate : QuickFix.Fields.DecimalField
    {
        public SettlCurrFxRate()
            :base(Fields.CustomTags.SettlCurrFxRate) {}
        public SettlCurrFxRate(Decimal val)
            :base(Fields.CustomTags.SettlCurrFxRate, val) {}

    }


    /// <summary>
    /// SettlCurrFxRateCalc Field
    /// </summary>/
    public sealed class SettlCurrFxRateCalc : QuickFix.Fields.CharField
    {
        public SettlCurrFxRateCalc()
            :base(Fields.CustomTags.SettlCurrFxRateCalc) {}
        public SettlCurrFxRateCalc(char val)
            :base(Fields.CustomTags.SettlCurrFxRateCalc, val) {}


        // Field Enumerations
        public const char MULTIPLY = 'M';
        public const char DIVIDE = 'D';
    }


    /// <summary>
    /// NumDaysInterest Field
    /// </summary>/
    public sealed class NumDaysInterest : QuickFix.Fields.IntField
    {
        public NumDaysInterest()
            :base(Fields.CustomTags.NumDaysInterest) {}
        public NumDaysInterest(int val)
            :base(Fields.CustomTags.NumDaysInterest, val) {}

    }


    /// <summary>
    /// AccruedInterestRate Field
    /// </summary>/
    public sealed class AccruedInterestRate : QuickFix.Fields.DecimalField
    {
        public AccruedInterestRate()
            :base(Fields.CustomTags.AccruedInterestRate) {}
        public AccruedInterestRate(Decimal val)
            :base(Fields.CustomTags.AccruedInterestRate, val) {}

    }


    /// <summary>
    /// AccruedInterestAmt Field
    /// </summary>/
    public sealed class AccruedInterestAmt : QuickFix.Fields.DecimalField
    {
        public AccruedInterestAmt()
            :base(Fields.CustomTags.AccruedInterestAmt) {}
        public AccruedInterestAmt(Decimal val)
            :base(Fields.CustomTags.AccruedInterestAmt, val) {}

    }


    /// <summary>
    /// SettlInstMode Field
    /// </summary>/
    public sealed class SettlInstMode : QuickFix.Fields.CharField
    {
        public SettlInstMode()
            :base(Fields.CustomTags.SettlInstMode) {}
        public SettlInstMode(char val)
            :base(Fields.CustomTags.SettlInstMode, val) {}


        // Field Enumerations
        public const char DEFAULT = '0';
        public const char STANDING_INSTRUCTIONS_PROVIDED = '1';
        public const char SPECIFIC_ALLOCATION_ACCOUNT_OVERRIDING = '2';
        public const char SPECIFIC_ALLOCATION_ACCOUNT_STANDING = '3';
        public const char SPECIFIC_ORDER_FOR_A_SINGLE_ACCOUNT = '4';
        public const char REQUEST_REJECT = '5';
    }


    /// <summary>
    /// AllocText Field
    /// </summary>/
    public sealed class AllocText : QuickFix.Fields.StringField
    {
        public AllocText()
            :base(Fields.CustomTags.AllocText) {}
        public AllocText(string val)
            :base(Fields.CustomTags.AllocText, val) {}

    }


    /// <summary>
    /// SettlInstID Field
    /// </summary>/
    public sealed class SettlInstID : QuickFix.Fields.StringField
    {
        public SettlInstID()
            :base(Fields.CustomTags.SettlInstID) {}
        public SettlInstID(string val)
            :base(Fields.CustomTags.SettlInstID, val) {}

    }


    /// <summary>
    /// SettlInstTransType Field
    /// </summary>/
    public sealed class SettlInstTransType : QuickFix.Fields.CharField
    {
        public SettlInstTransType()
            :base(Fields.CustomTags.SettlInstTransType) {}
        public SettlInstTransType(char val)
            :base(Fields.CustomTags.SettlInstTransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NEW = 'N';
        public const char REPLACE = 'R';
        public const char RESTATE = 'T';
    }


    /// <summary>
    /// EmailThreadID Field
    /// </summary>/
    public sealed class EmailThreadID : QuickFix.Fields.StringField
    {
        public EmailThreadID()
            :base(Fields.CustomTags.EmailThreadID) {}
        public EmailThreadID(string val)
            :base(Fields.CustomTags.EmailThreadID, val) {}

    }


    /// <summary>
    /// SettlInstSource Field
    /// </summary>/
    public sealed class SettlInstSource : QuickFix.Fields.CharField
    {
        public SettlInstSource()
            :base(Fields.CustomTags.SettlInstSource) {}
        public SettlInstSource(char val)
            :base(Fields.CustomTags.SettlInstSource, val) {}


        // Field Enumerations
        public const char BROKERS_INSTRUCTIONS = '1';
        public const char INSTITUTIONS_INSTRUCTIONS = '2';
        public const char INVESTOR = '3';
        public const char BROKER = '1';
        public const char INSTITUTION = '2';
    }


    /// <summary>
    /// SettlLocation Field
    /// </summary>/
    public sealed class SettlLocation : QuickFix.Fields.StringField
    {
        public SettlLocation()
            :base(Fields.CustomTags.SettlLocation) {}
        public SettlLocation(string val)
            :base(Fields.CustomTags.SettlLocation, val) {}


        // Field Enumerations
        public const string CEDEL = "CED";
        public const string DEPOSITORY_TRUST_COMPANY = "DTC";
        public const string EURO_CLEAR = "EUR";
        public const string FEDERAL_BOOK_ENTRY = "FED";
        public const string LOCAL_MARKET_SETTLE_LOCATION = "ISO_Country_Code";
        public const string PHYSICAL = "PNY";
        public const string PARTICIPANT_TRUST_COMPANY = "PTC";
        public const string EUROCLEAR = "EUR";
        public const string PARTICIPANT_TRUST_COMPANY_ISO_COUNTRY = "PTC";
    }


    /// <summary>
    /// SecurityType Field
    /// </summary>/
    public sealed class SecurityType : QuickFix.Fields.StringField
    {
        public SecurityType()
            :base(Fields.CustomTags.SecurityType) {}
        public SecurityType(string val)
            :base(Fields.CustomTags.SecurityType, val) {}


        // Field Enumerations
        public const string ASSET_BACKED_SECURITIES = "ABS";
        public const string AMENDED_RESTATED = "AMENDED";
        public const string OTHER_ANTICIPATION_NOTES = "AN";
        public const string BANKERS_ACCEPTANCE = "BA";
        public const string BANK_NOTES = "BN";
        public const string BILL_OF_EXCHANGES = "BOX";
        public const string BRADY_BOND = "BRADY";
        public const string BRIDGE_LOAN = "BRIDGE";
        public const string BUY_SELLBACK = "BUYSELL";
        public const string CONVERTIBLE_BOND = "CB";
        public const string CERTIFICATE_OF_DEPOSIT = "CD";
        public const string CALL_LOANS = "CL";
        public const string CORP_MORTGAGE_BACKED_SECURITIES = "CMBS";
        public const string COLLATERALIZED_MORTGAGE_OBLIGATION = "CMO";
        public const string CERTIFICATE_OF_OBLIGATION = "COFO";
        public const string CERTIFICATE_OF_PARTICIPATION = "COFP";
        public const string CORPORATE_BOND = "CORP";
        public const string COMMERCIAL_PAPER = "CP";
        public const string CORPORATE_PRIVATE_PLACEMENT = "CPP";
        public const string COMMON_STOCK = "CS";
        public const string DEFAULTED = "DEFLTED";
        public const string DEBTOR_IN_POSSESSION = "DINP";
        public const string DEPOSIT_NOTES = "DN";
        public const string DUAL_CURRENCY = "DUAL";
        public const string EURO_CERTIFICATE_OF_DEPOSIT = "EUCD";
        public const string EURO_CORPORATE_BOND = "EUCORP";
        public const string EURO_COMMERCIAL_PAPER = "EUCP";
        public const string EURO_SOVEREIGNS = "EUSOV";
        public const string EURO_SUPRANATIONAL_COUPONS = "EUSUPRA";
        public const string FEDERAL_AGENCY_COUPON = "FAC";
        public const string FEDERAL_AGENCY_DISCOUNT_NOTE = "FADN";
        public const string FOREIGN_EXCHANGE_CONTRACT = "FOR";
        public const string FORWARD = "FORWARD";
        public const string FUTURE = "FUT";
        public const string GENERAL_OBLIGATION_BONDS = "GO";
        public const string IOETTE_MORTGAGE = "IET";
        public const string LETTER_OF_CREDIT = "LOFC";
        public const string LIQUIDITY_NOTE = "LQN";
        public const string MATURED = "MATURED";
        public const string MORTGAGE_BACKED_SECURITIES = "MBS";
        public const string MUTUAL_FUND = "MF";
        public const string MORTGAGE_INTEREST_ONLY = "MIO";
        public const string MULTILEG_INSTRUMENT = "MLEG";
        public const string MORTGAGE_PRINCIPAL_ONLY = "MPO";
        public const string MORTGAGE_PRIVATE_PLACEMENT = "MPP";
        public const string MISCELLANEOUS_PASS_THROUGH = "MPT";
        public const string MANDATORY_TENDER = "MT";
        public const string MEDIUM_TERM_NOTES = "MTN";
        public const string NO_SECURITY_TYPE = "NONE";
        public const string OVERNIGHT = "ONITE";
        public const string OPTION = "OPT";
        public const string PRIVATE_EXPORT_FUNDING = "PEF";
        public const string PFANDBRIEFE = "PFAND";
        public const string PROMISSORY_NOTE = "PN";
        public const string PREFERRED_STOCK = "PS";
        public const string PLAZOS_FIJOS = "PZFJ";
        public const string REVENUE_ANTICIPATION_NOTE = "RAN";
        public const string REPLACED = "REPLACD";
        public const string REPURCHASE = "REPO";
        public const string RETIRED = "RETIRED";
        public const string REVENUE_BONDS = "REV";
        public const string REVOLVER_LOAN = "RVLV";
        public const string REVOLVER_TERM_LOAN = "RVLVTRM";
        public const string SECURITIES_LOAN = "SECLOAN";
        public const string SECURITIES_PLEDGE = "SECPLEDGE";
        public const string SPECIAL_ASSESSMENT = "SPCLA";
        public const string SPECIAL_OBLIGATION = "SPCLO";
        public const string SPECIAL_TAX = "SPCLT";
        public const string SHORT_TERM_LOAN_NOTE = "STN";
        public const string STRUCTURED_NOTES = "STRUCT";
        public const string USD_SUPRANATIONAL_COUPONS = "SUPRA";
        public const string SWING_LINE_FACILITY = "SWING";
        public const string TAX_ANTICIPATION_NOTE = "TAN";
        public const string TAX_ALLOCATION = "TAXA";
        public const string TO_BE_ANNOUNCED = "TBA";
        public const string US_TREASURY_BILL_TBILL = "TBILL";
        public const string US_TREASURY_BOND = "TBOND";
        public const string PRINCIPAL_STRIP_OF_A_CALLABLE_BOND_OR_NOTE = "TCAL";
        public const string TIME_DEPOSIT = "TD";
        public const string TAX_EXEMPT_COMMERCIAL_PAPER = "TECP";
        public const string TERM_LOAN = "TERM";
        public const string INTEREST_STRIP_FROM_ANY_BOND_OR_NOTE = "TINT";
        public const string TREASURY_INFLATION_PROTECTED_SECURITIES = "TIPS";
        public const string US_TREASURY_NOTE_TNOTE = "TNOTE";
        public const string PRINCIPAL_STRIP_FROM_A_NON_CALLABLE_BOND_OR_NOTE = "TPRN";
        public const string TAX_REVENUE_ANTICIPATION_NOTE = "TRAN";
        public const string US_TREASURY_NOTE_UST = "UST";
        public const string US_TREASURY_BILL_USTB = "USTB";
        public const string VARIABLE_RATE_DEMAND_NOTE = "VRDN";
        public const string WARRANT = "WAR";
        public const string WITHDRAWN = "WITHDRN";
        public const string WILDCARD_ENTRY_FOR_USE_ON_SECURITY_DEFINITION_REQUEST = "?";
        public const string EXTENDED_COMM_NOTE = "XCN";
        public const string INDEXED_LINKED = "XLINKD";
        public const string YANKEE_CORPORATE_BOND = "YANK";
        public const string YANKEE_CERTIFICATE_OF_DEPOSIT = "YCD";
        public const string OPTIONS_ON_PHYSICAL = "OOP";
        public const string OPTIONS_ON_FUTURES = "OOF";
        public const string CASH = "CASH";
        public const string OPTIONS_ON_COMBO = "OOC";
        public const string INTEREST_RATE_SWAP = "IRS";
        public const string BANK_DEPOSITORY_NOTE = "BDN";
        public const string CANADIAN_MONEY_MARKETS = "CAMM";
        public const string CANADIAN_TREASURY_NOTES = "CAN";
        public const string CANADIAN_TREASURY_BILLS = "CTB";
        public const string CREDIT_DEFAULT_SWAP = "CDS";
        public const string CANADIAN_MORTGAGE_BONDS = "CMB";
        public const string EURO_CORPORATE_FLOATING_RATE_NOTES = "EUFRN";
        public const string US_CORPORATE_FLOATING_RATE_NOTES = "FRN";
        public const string CANADIAN_PROVINCIAL_BONDS = "PROV";
        public const string SECURED_LIQUIDITY_NOTE = "SLQN";
        public const string TREASURY_BILL = "TB";
        public const string TERM_LIQUIDITY_NOTE = "TLQN";
        public const string TAXABLE_MUNICIPAL_CP = "TMCP";
        public const string NON_DELIVERABLE_FORWARD = "FXNDF";
        public const string FX_SPOT = "FXSPOT";
        public const string FX_FORWARD = "FXFWD";
        public const string FX_SWAP = "FXSWAP";
        public const string WILDCARD_ENTRY = "WLD";
        public const string SPREAD = "MLEG";
        public const string SPOT = "SPOT";
        public const string TBOND = "TBOND";
        public const string CURRENCY = "CUR";
        public const string NONE = "NONE";
        public const string CONVERTABLE_BOND = "CB";
        public const string INDEX_LINKED = "XLINKD";
        public const string PREFERED_STOCK = "PS";
        public const string US_TREASURY_NOTE_BOND = "UST";
        public const string US_TREASURY_BILL = "USTB";
        public const string AMENDED_AND_RESTATED = "AMENDED";
        public const string LIQUIDITY_NOTES = "LQN";
        public const string OVERNITE = "ONITE";
        public const string PROMISSORY_NOTES = "PN";
        public const string REPURCHASE_AGREEMENT = "RP";
        public const string REVERSE_REPURCHASE_AGREEMENT = "RVRP";
        public const string AGENCY_POOLS = "POOL";
        public const string TAX_AND_REVENUE_ANTICIPATION_NOTE = "TRAN";
        public const string MULTI_LEG_INSTRUMENT = "MLEG";
        public const string WILDCARD = "?";
        public const string COLLATERALIZE_MORTGAGE_OBLIGATION = "CMO";
        public const string FEDERAL_HOUSING_AUTHORITY = "FHA";
        public const string FEDERAL_HOME_LOAN = "FHL";
        public const string FEDERAL_NATIONAL_MORTGAGE_ASSOCIATION = "FN";
        public const string GOVERNMENT_NATIONAL_MORTGAGE_ASSOCIATION = "GN";
        public const string TREASURIES_PLUS_AGENCY_DEBENTURE = "GOVT";
        public const string MISCELLANEOUS_PASSTHRU = "MPT";
        public const string MUNICIPAL_BOND = "MUNI";
        public const string NO_ISITC_SECURITY_TYPE = "NONE";
        public const string STUDENT_LOAN_MARKETING_ASSOCIATION = "SL";
        public const string CATS_TIGERS = "ZOO";
        public const string MORTGAGE_PRINCIPLE_ONLY = "MPO";
    }


    /// <summary>
    /// EffectiveTime Field
    /// </summary>/
    public sealed class EffectiveTime : QuickFix.Fields.DateTimeField
    {
        public EffectiveTime()
            :base(Fields.CustomTags.EffectiveTime) {}
        public EffectiveTime(DateTime val)
            :base(Fields.CustomTags.EffectiveTime, val) {}
        public EffectiveTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.EffectiveTime, val, showMilliseconds) {}
		public EffectiveTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.EffectiveTime, val, precision) {}

    }


    /// <summary>
    /// StandInstDbType Field
    /// </summary>/
    public sealed class StandInstDbType : QuickFix.Fields.IntField
    {
        public StandInstDbType()
            :base(Fields.CustomTags.StandInstDbType) {}
        public StandInstDbType(int val)
            :base(Fields.CustomTags.StandInstDbType, val) {}


        // Field Enumerations
        public const int OTHER = 0;
        public const int DTC_SID = 1;
        public const int THOMSON_ALERT = 2;
        public const int A_GLOBAL_CUSTODIAN = 3;
        public const int ACCOUNTNET = 4;
    }


    /// <summary>
    /// StandInstDbName Field
    /// </summary>/
    public sealed class StandInstDbName : QuickFix.Fields.StringField
    {
        public StandInstDbName()
            :base(Fields.CustomTags.StandInstDbName) {}
        public StandInstDbName(string val)
            :base(Fields.CustomTags.StandInstDbName, val) {}

    }


    /// <summary>
    /// StandInstDbID Field
    /// </summary>/
    public sealed class StandInstDbID : QuickFix.Fields.StringField
    {
        public StandInstDbID()
            :base(Fields.CustomTags.StandInstDbID) {}
        public StandInstDbID(string val)
            :base(Fields.CustomTags.StandInstDbID, val) {}

    }


    /// <summary>
    /// SettlDeliveryType Field
    /// </summary>/
    public sealed class SettlDeliveryType : QuickFix.Fields.IntField
    {
        public SettlDeliveryType()
            :base(Fields.CustomTags.SettlDeliveryType) {}
        public SettlDeliveryType(int val)
            :base(Fields.CustomTags.SettlDeliveryType, val) {}


        // Field Enumerations
        public const int VERSUS_PAYMENT_DELIVER = 0;
        public const int FREE_DELIVER = 1;
        public const int TRI_PARTY = 2;
        public const int HOLD_IN_CUSTODY = 3;
    }


    /// <summary>
    /// SettlDepositoryCode Field
    /// </summary>/
    public sealed class SettlDepositoryCode : QuickFix.Fields.StringField
    {
        public SettlDepositoryCode()
            :base(Fields.CustomTags.SettlDepositoryCode) {}
        public SettlDepositoryCode(string val)
            :base(Fields.CustomTags.SettlDepositoryCode, val) {}

    }


    /// <summary>
    /// SettlBrkrCode Field
    /// </summary>/
    public sealed class SettlBrkrCode : QuickFix.Fields.StringField
    {
        public SettlBrkrCode()
            :base(Fields.CustomTags.SettlBrkrCode) {}
        public SettlBrkrCode(string val)
            :base(Fields.CustomTags.SettlBrkrCode, val) {}

    }


    /// <summary>
    /// SettlInstCode Field
    /// </summary>/
    public sealed class SettlInstCode : QuickFix.Fields.StringField
    {
        public SettlInstCode()
            :base(Fields.CustomTags.SettlInstCode) {}
        public SettlInstCode(string val)
            :base(Fields.CustomTags.SettlInstCode, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentName Field
    /// </summary>/
    public sealed class SecuritySettlAgentName : QuickFix.Fields.StringField
    {
        public SecuritySettlAgentName()
            :base(Fields.CustomTags.SecuritySettlAgentName) {}
        public SecuritySettlAgentName(string val)
            :base(Fields.CustomTags.SecuritySettlAgentName, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentCode Field
    /// </summary>/
    public sealed class SecuritySettlAgentCode : QuickFix.Fields.StringField
    {
        public SecuritySettlAgentCode()
            :base(Fields.CustomTags.SecuritySettlAgentCode) {}
        public SecuritySettlAgentCode(string val)
            :base(Fields.CustomTags.SecuritySettlAgentCode, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentAcctNum Field
    /// </summary>/
    public sealed class SecuritySettlAgentAcctNum : QuickFix.Fields.StringField
    {
        public SecuritySettlAgentAcctNum()
            :base(Fields.CustomTags.SecuritySettlAgentAcctNum) {}
        public SecuritySettlAgentAcctNum(string val)
            :base(Fields.CustomTags.SecuritySettlAgentAcctNum, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentAcctName Field
    /// </summary>/
    public sealed class SecuritySettlAgentAcctName : QuickFix.Fields.StringField
    {
        public SecuritySettlAgentAcctName()
            :base(Fields.CustomTags.SecuritySettlAgentAcctName) {}
        public SecuritySettlAgentAcctName(string val)
            :base(Fields.CustomTags.SecuritySettlAgentAcctName, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentContactName Field
    /// </summary>/
    public sealed class SecuritySettlAgentContactName : QuickFix.Fields.StringField
    {
        public SecuritySettlAgentContactName()
            :base(Fields.CustomTags.SecuritySettlAgentContactName) {}
        public SecuritySettlAgentContactName(string val)
            :base(Fields.CustomTags.SecuritySettlAgentContactName, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentContactPhone Field
    /// </summary>/
    public sealed class SecuritySettlAgentContactPhone : QuickFix.Fields.StringField
    {
        public SecuritySettlAgentContactPhone()
            :base(Fields.CustomTags.SecuritySettlAgentContactPhone) {}
        public SecuritySettlAgentContactPhone(string val)
            :base(Fields.CustomTags.SecuritySettlAgentContactPhone, val) {}

    }


    /// <summary>
    /// CashSettlAgentName Field
    /// </summary>/
    public sealed class CashSettlAgentName : QuickFix.Fields.StringField
    {
        public CashSettlAgentName()
            :base(Fields.CustomTags.CashSettlAgentName) {}
        public CashSettlAgentName(string val)
            :base(Fields.CustomTags.CashSettlAgentName, val) {}

    }


    /// <summary>
    /// CashSettlAgentCode Field
    /// </summary>/
    public sealed class CashSettlAgentCode : QuickFix.Fields.StringField
    {
        public CashSettlAgentCode()
            :base(Fields.CustomTags.CashSettlAgentCode) {}
        public CashSettlAgentCode(string val)
            :base(Fields.CustomTags.CashSettlAgentCode, val) {}

    }


    /// <summary>
    /// CashSettlAgentAcctNum Field
    /// </summary>/
    public sealed class CashSettlAgentAcctNum : QuickFix.Fields.StringField
    {
        public CashSettlAgentAcctNum()
            :base(Fields.CustomTags.CashSettlAgentAcctNum) {}
        public CashSettlAgentAcctNum(string val)
            :base(Fields.CustomTags.CashSettlAgentAcctNum, val) {}

    }


    /// <summary>
    /// CashSettlAgentAcctName Field
    /// </summary>/
    public sealed class CashSettlAgentAcctName : QuickFix.Fields.StringField
    {
        public CashSettlAgentAcctName()
            :base(Fields.CustomTags.CashSettlAgentAcctName) {}
        public CashSettlAgentAcctName(string val)
            :base(Fields.CustomTags.CashSettlAgentAcctName, val) {}

    }


    /// <summary>
    /// CashSettlAgentContactName Field
    /// </summary>/
    public sealed class CashSettlAgentContactName : QuickFix.Fields.StringField
    {
        public CashSettlAgentContactName()
            :base(Fields.CustomTags.CashSettlAgentContactName) {}
        public CashSettlAgentContactName(string val)
            :base(Fields.CustomTags.CashSettlAgentContactName, val) {}

    }


    /// <summary>
    /// CashSettlAgentContactPhone Field
    /// </summary>/
    public sealed class CashSettlAgentContactPhone : QuickFix.Fields.StringField
    {
        public CashSettlAgentContactPhone()
            :base(Fields.CustomTags.CashSettlAgentContactPhone) {}
        public CashSettlAgentContactPhone(string val)
            :base(Fields.CustomTags.CashSettlAgentContactPhone, val) {}

    }


    /// <summary>
    /// BidSpotRate Field
    /// </summary>/
    public sealed class BidSpotRate : QuickFix.Fields.DecimalField
    {
        public BidSpotRate()
            :base(Fields.CustomTags.BidSpotRate) {}
        public BidSpotRate(Decimal val)
            :base(Fields.CustomTags.BidSpotRate, val) {}

    }


    /// <summary>
    /// BidForwardPoints Field
    /// </summary>/
    public sealed class BidForwardPoints : QuickFix.Fields.DecimalField
    {
        public BidForwardPoints()
            :base(Fields.CustomTags.BidForwardPoints) {}
        public BidForwardPoints(Decimal val)
            :base(Fields.CustomTags.BidForwardPoints, val) {}

    }


    /// <summary>
    /// OfferSpotRate Field
    /// </summary>/
    public sealed class OfferSpotRate : QuickFix.Fields.DecimalField
    {
        public OfferSpotRate()
            :base(Fields.CustomTags.OfferSpotRate) {}
        public OfferSpotRate(Decimal val)
            :base(Fields.CustomTags.OfferSpotRate, val) {}

    }


    /// <summary>
    /// OfferForwardPoints Field
    /// </summary>/
    public sealed class OfferForwardPoints : QuickFix.Fields.DecimalField
    {
        public OfferForwardPoints()
            :base(Fields.CustomTags.OfferForwardPoints) {}
        public OfferForwardPoints(Decimal val)
            :base(Fields.CustomTags.OfferForwardPoints, val) {}

    }


    /// <summary>
    /// OrderQty2 Field
    /// </summary>/
    public sealed class OrderQty2 : QuickFix.Fields.DecimalField
    {
        public OrderQty2()
            :base(Fields.CustomTags.OrderQty2) {}
        public OrderQty2(Decimal val)
            :base(Fields.CustomTags.OrderQty2, val) {}

    }


    /// <summary>
    /// FutSettDate2 Field
    /// </summary>/
    public sealed class FutSettDate2 : QuickFix.Fields.StringField
    {
        public FutSettDate2()
            :base(Fields.CustomTags.FutSettDate2) {}
        public FutSettDate2(string val)
            :base(Fields.CustomTags.FutSettDate2, val) {}

    }


    /// <summary>
    /// LastSpotRate Field
    /// </summary>/
    public sealed class LastSpotRate : QuickFix.Fields.DecimalField
    {
        public LastSpotRate()
            :base(Fields.CustomTags.LastSpotRate) {}
        public LastSpotRate(Decimal val)
            :base(Fields.CustomTags.LastSpotRate, val) {}

    }


    /// <summary>
    /// LastForwardPoints Field
    /// </summary>/
    public sealed class LastForwardPoints : QuickFix.Fields.DecimalField
    {
        public LastForwardPoints()
            :base(Fields.CustomTags.LastForwardPoints) {}
        public LastForwardPoints(Decimal val)
            :base(Fields.CustomTags.LastForwardPoints, val) {}

    }


    /// <summary>
    /// AllocLinkID Field
    /// </summary>/
    public sealed class AllocLinkID : QuickFix.Fields.StringField
    {
        public AllocLinkID()
            :base(Fields.CustomTags.AllocLinkID) {}
        public AllocLinkID(string val)
            :base(Fields.CustomTags.AllocLinkID, val) {}

    }


    /// <summary>
    /// AllocLinkType Field
    /// </summary>/
    public sealed class AllocLinkType : QuickFix.Fields.IntField
    {
        public AllocLinkType()
            :base(Fields.CustomTags.AllocLinkType) {}
        public AllocLinkType(int val)
            :base(Fields.CustomTags.AllocLinkType, val) {}


        // Field Enumerations
        public const int FX_NETTING = 0;
        public const int FX_SWAP = 1;
        public const int F_X_NETTING = 0;
        public const int F_X_SWAP = 1;
    }


    /// <summary>
    /// SecondaryOrderID Field
    /// </summary>/
    public sealed class SecondaryOrderID : QuickFix.Fields.StringField
    {
        public SecondaryOrderID()
            :base(Fields.CustomTags.SecondaryOrderID) {}
        public SecondaryOrderID(string val)
            :base(Fields.CustomTags.SecondaryOrderID, val) {}

    }


    /// <summary>
    /// NoIOIQualifiers Field
    /// </summary>/
    public sealed class NoIOIQualifiers : QuickFix.Fields.IntField
    {
        public NoIOIQualifiers()
            :base(Fields.CustomTags.NoIOIQualifiers) {}
        public NoIOIQualifiers(int val)
            :base(Fields.CustomTags.NoIOIQualifiers, val) {}

    }


    /// <summary>
    /// MaturityMonthYear Field
    /// </summary>/
    public sealed class MaturityMonthYear : QuickFix.Fields.StringField
    {
        public MaturityMonthYear()
            :base(Fields.CustomTags.MaturityMonthYear) {}
        public MaturityMonthYear(string val)
            :base(Fields.CustomTags.MaturityMonthYear, val) {}

    }


    /// <summary>
    /// PutOrCall Field
    /// </summary>/
    public sealed class PutOrCall : QuickFix.Fields.IntField
    {
        public PutOrCall()
            :base(Fields.CustomTags.PutOrCall) {}
        public PutOrCall(int val)
            :base(Fields.CustomTags.PutOrCall, val) {}


        // Field Enumerations
        public const int PUT = 0;
        public const int CALL = 1;
    }


    /// <summary>
    /// StrikePrice Field
    /// </summary>/
    public sealed class StrikePrice : QuickFix.Fields.DecimalField
    {
        public StrikePrice()
            :base(Fields.CustomTags.StrikePrice) {}
        public StrikePrice(Decimal val)
            :base(Fields.CustomTags.StrikePrice, val) {}

    }


    /// <summary>
    /// CoveredOrUncovered Field
    /// </summary>/
    public sealed class CoveredOrUncovered : QuickFix.Fields.IntField
    {
        public CoveredOrUncovered()
            :base(Fields.CustomTags.CoveredOrUncovered) {}
        public CoveredOrUncovered(int val)
            :base(Fields.CustomTags.CoveredOrUncovered, val) {}


        // Field Enumerations
        public const int COVERED = 0;
        public const int UNCOVERED = 1;
    }


    /// <summary>
    /// CustomerOrFirm Field
    /// </summary>/
    public sealed class CustomerOrFirm : QuickFix.Fields.IntField
    {
        public CustomerOrFirm()
            :base(Fields.CustomTags.CustomerOrFirm) {}
        public CustomerOrFirm(int val)
            :base(Fields.CustomTags.CustomerOrFirm, val) {}


        // Field Enumerations
        public const int CUSTOMER = 0;
        public const int FIRM = 1;
    }


    /// <summary>
    /// MaturityDay Field
    /// </summary>/
    public sealed class MaturityDay : QuickFix.Fields.StringField
    {
        public MaturityDay()
            :base(Fields.CustomTags.MaturityDay) {}
        public MaturityDay(string val)
            :base(Fields.CustomTags.MaturityDay, val) {}

    }


    /// <summary>
    /// OptAttribute Field
    /// </summary>/
    public sealed class OptAttribute : QuickFix.Fields.CharField
    {
        public OptAttribute()
            :base(Fields.CustomTags.OptAttribute) {}
        public OptAttribute(char val)
            :base(Fields.CustomTags.OptAttribute, val) {}

    }


    /// <summary>
    /// SecurityExchange Field
    /// </summary>/
    public sealed class SecurityExchange : QuickFix.Fields.StringField
    {
        public SecurityExchange()
            :base(Fields.CustomTags.SecurityExchange) {}
        public SecurityExchange(string val)
            :base(Fields.CustomTags.SecurityExchange, val) {}

    }


    /// <summary>
    /// NotifyBrokerOfCredit Field
    /// </summary>/
    public sealed class NotifyBrokerOfCredit : QuickFix.Fields.BooleanField
    {
        public NotifyBrokerOfCredit()
            :base(Fields.CustomTags.NotifyBrokerOfCredit) {}
        public NotifyBrokerOfCredit(Boolean val)
            :base(Fields.CustomTags.NotifyBrokerOfCredit, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean DETAILS_SHOULD_BE_COMMUNICATED = true;
        public const Boolean DETAILS_SHOULD_NOT_BE_COMMUNICATED = false;
    }


    /// <summary>
    /// AllocHandlInst Field
    /// </summary>/
    public sealed class AllocHandlInst : QuickFix.Fields.IntField
    {
        public AllocHandlInst()
            :base(Fields.CustomTags.AllocHandlInst) {}
        public AllocHandlInst(int val)
            :base(Fields.CustomTags.AllocHandlInst, val) {}


        // Field Enumerations
        public const int MATCH = 1;
        public const int FORWARD = 2;
        public const int FORWARD_AND_MATCH = 3;
    }


    /// <summary>
    /// MaxShow Field
    /// </summary>/
    public sealed class MaxShow : QuickFix.Fields.DecimalField
    {
        public MaxShow()
            :base(Fields.CustomTags.MaxShow) {}
        public MaxShow(Decimal val)
            :base(Fields.CustomTags.MaxShow, val) {}

    }


    /// <summary>
    /// PegDifference Field
    /// </summary>/
    public sealed class PegDifference : QuickFix.Fields.DecimalField
    {
        public PegDifference()
            :base(Fields.CustomTags.PegDifference) {}
        public PegDifference(Decimal val)
            :base(Fields.CustomTags.PegDifference, val) {}

    }


    /// <summary>
    /// TotNoOrders Field
    /// </summary>/
    public sealed class TotNoOrders : QuickFix.Fields.IntField
    {
        public TotNoOrders()
            :base(Fields.CustomTags.TotNoOrders) {}
        public TotNoOrders(int val)
            :base(Fields.CustomTags.TotNoOrders, val) {}

    }


    /// <summary>
    /// XmlDataLen Field
    /// </summary>/
    public sealed class XmlDataLen : QuickFix.Fields.IntField
    {
        public XmlDataLen()
            :base(Fields.CustomTags.XmlDataLen) {}
        public XmlDataLen(int val)
            :base(Fields.CustomTags.XmlDataLen, val) {}

    }


    /// <summary>
    /// XmlData Field
    /// </summary>/
    public sealed class XmlData : QuickFix.Fields.StringField
    {
        public XmlData()
            :base(Fields.CustomTags.XmlData) {}
        public XmlData(string val)
            :base(Fields.CustomTags.XmlData, val) {}

    }


    /// <summary>
    /// SettlInstRefID Field
    /// </summary>/
    public sealed class SettlInstRefID : QuickFix.Fields.StringField
    {
        public SettlInstRefID()
            :base(Fields.CustomTags.SettlInstRefID) {}
        public SettlInstRefID(string val)
            :base(Fields.CustomTags.SettlInstRefID, val) {}

    }


    /// <summary>
    /// NoRoutingIDs Field
    /// </summary>/
    public sealed class NoRoutingIDs : QuickFix.Fields.IntField
    {
        public NoRoutingIDs()
            :base(Fields.CustomTags.NoRoutingIDs) {}
        public NoRoutingIDs(int val)
            :base(Fields.CustomTags.NoRoutingIDs, val) {}

    }


    /// <summary>
    /// RoutingType Field
    /// </summary>/
    public sealed class RoutingType : QuickFix.Fields.IntField
    {
        public RoutingType()
            :base(Fields.CustomTags.RoutingType) {}
        public RoutingType(int val)
            :base(Fields.CustomTags.RoutingType, val) {}


        // Field Enumerations
        public const int TARGET_FIRM = 1;
        public const int TARGET_LIST = 2;
        public const int BLOCK_FIRM = 3;
        public const int BLOCK_LIST = 4;
    }


    /// <summary>
    /// RoutingID Field
    /// </summary>/
    public sealed class RoutingID : QuickFix.Fields.StringField
    {
        public RoutingID()
            :base(Fields.CustomTags.RoutingID) {}
        public RoutingID(string val)
            :base(Fields.CustomTags.RoutingID, val) {}

    }


    /// <summary>
    /// SpreadToBenchmark Field
    /// </summary>/
    public sealed class SpreadToBenchmark : QuickFix.Fields.DecimalField
    {
        public SpreadToBenchmark()
            :base(Fields.CustomTags.SpreadToBenchmark) {}
        public SpreadToBenchmark(Decimal val)
            :base(Fields.CustomTags.SpreadToBenchmark, val) {}

    }


    /// <summary>
    /// Benchmark Field
    /// </summary>/
    public sealed class Benchmark : QuickFix.Fields.CharField
    {
        public Benchmark()
            :base(Fields.CustomTags.Benchmark) {}
        public Benchmark(char val)
            :base(Fields.CustomTags.Benchmark, val) {}


        // Field Enumerations
        public const char CURVE = '1';
        public const char VAL_5YR = '2';
        public const char OLD5 = '3';
        public const char VAL_10YR = '4';
        public const char OLD10 = '5';
        public const char VAL_30YR = '6';
        public const char OLD30 = '7';
        public const char VAL_3MOLIBOR = '8';
        public const char VAL_6MOLIBOR = '9';
        public const char FIVEYR = '2';
        public const char TENYR = '4';
        public const char THIRTYYR = '6';
        public const char THREEMOLIBOR = '8';
        public const char SIXMOLIBOR = '9';
    }


    /// <summary>
    /// CouponRate Field
    /// </summary>/
    public sealed class CouponRate : QuickFix.Fields.DecimalField
    {
        public CouponRate()
            :base(Fields.CustomTags.CouponRate) {}
        public CouponRate(Decimal val)
            :base(Fields.CustomTags.CouponRate, val) {}

    }


    /// <summary>
    /// ContractMultiplier Field
    /// </summary>/
    public sealed class ContractMultiplier : QuickFix.Fields.DecimalField
    {
        public ContractMultiplier()
            :base(Fields.CustomTags.ContractMultiplier) {}
        public ContractMultiplier(Decimal val)
            :base(Fields.CustomTags.ContractMultiplier, val) {}

    }


    /// <summary>
    /// MDReqID Field
    /// </summary>/
    public sealed class MDReqID : QuickFix.Fields.StringField
    {
        public MDReqID()
            :base(Fields.CustomTags.MDReqID) {}
        public MDReqID(string val)
            :base(Fields.CustomTags.MDReqID, val) {}

    }


    /// <summary>
    /// SubscriptionRequestType Field
    /// </summary>/
    public sealed class SubscriptionRequestType : QuickFix.Fields.CharField
    {
        public SubscriptionRequestType()
            :base(Fields.CustomTags.SubscriptionRequestType) {}
        public SubscriptionRequestType(char val)
            :base(Fields.CustomTags.SubscriptionRequestType, val) {}


        // Field Enumerations
        public const char SNAPSHOT = '0';
        public const char SNAPSHOT_PLUS_UPDATES = '1';
        public const char DISABLE_PREVIOUS_SNAPSHOT_PLUS_UPDATE_REQUEST = '2';
        public const char DISABLE_PREVIOUS = '2';
    }


    /// <summary>
    /// MarketDepth Field
    /// </summary>/
    public sealed class MarketDepth : QuickFix.Fields.IntField
    {
        public MarketDepth()
            :base(Fields.CustomTags.MarketDepth) {}
        public MarketDepth(int val)
            :base(Fields.CustomTags.MarketDepth, val) {}


        // Field Enumerations
        public const int FULL_BOOK = 0;
        public const int TOP_OF_BOOK = 1;
    }


    /// <summary>
    /// MDUpdateType Field
    /// </summary>/
    public sealed class MDUpdateType : QuickFix.Fields.IntField
    {
        public MDUpdateType()
            :base(Fields.CustomTags.MDUpdateType) {}
        public MDUpdateType(int val)
            :base(Fields.CustomTags.MDUpdateType, val) {}


        // Field Enumerations
        public const int FULL_REFRESH = 0;
        public const int INCREMENTAL_REFRESH = 1;
    }


    /// <summary>
    /// AggregatedBook Field
    /// </summary>/
    public sealed class AggregatedBook : QuickFix.Fields.BooleanField
    {
        public AggregatedBook()
            :base(Fields.CustomTags.AggregatedBook) {}
        public AggregatedBook(Boolean val)
            :base(Fields.CustomTags.AggregatedBook, val) {}


        // Field Enumerations
        public const Boolean YES = true;
        public const Boolean NO = false;
        public const Boolean ONE_BOOK_ENTRY_PER_SIDE_PER_PRICE = true;
        public const Boolean MULTIPLE_ENTRIES_PER_SIDE_PER_PRICE_ALLOWED = false;
    }


    /// <summary>
    /// NoMDEntryTypes Field
    /// </summary>/
    public sealed class NoMDEntryTypes : QuickFix.Fields.IntField
    {
        public NoMDEntryTypes()
            :base(Fields.CustomTags.NoMDEntryTypes) {}
        public NoMDEntryTypes(int val)
            :base(Fields.CustomTags.NoMDEntryTypes, val) {}

    }


    /// <summary>
    /// NoMDEntries Field
    /// </summary>/
    public sealed class NoMDEntries : QuickFix.Fields.IntField
    {
        public NoMDEntries()
            :base(Fields.CustomTags.NoMDEntries) {}
        public NoMDEntries(int val)
            :base(Fields.CustomTags.NoMDEntries, val) {}

    }


    /// <summary>
    /// MDEntryType Field
    /// </summary>/
    public sealed class MDEntryType : QuickFix.Fields.CharField
    {
        public MDEntryType()
            :base(Fields.CustomTags.MDEntryType) {}
        public MDEntryType(char val)
            :base(Fields.CustomTags.MDEntryType, val) {}


        // Field Enumerations
        public const char BID = '0';
        public const char OFFER = '1';
        public const char TRADE = '2';
        public const char INDEX_VALUE = '3';
        public const char OPENING_PRICE = '4';
        public const char CLOSING_PRICE = '5';
        public const char SETTLEMENT_PRICE = '6';
        public const char TRADING_SESSION_HIGH_PRICE = '7';
        public const char TRADING_SESSION_LOW_PRICE = '8';
        public const char TRADING_SESSION_VWAP_PRICE = '9';
        public const char IMBALANCE = 'A';
        public const char TRADE_VOLUME = 'B';
        public const char OPEN_INTEREST = 'C';
        public const char COMPOSITE_UNDERLYING_PRICE = 'D';
        public const char SIMULATED_SELL_PRICE = 'E';
        public const char SIMULATED_BUY_PRICE = 'F';
        public const char MARGIN_RATE = 'G';
        public const char MID_PRICE = 'H';
        public const char EMPTY_BOOK = 'J';
        public const char SETTLE_HIGH_PRICE = 'K';
        public const char SETTLE_LOW_PRICE = 'L';
        public const char PRIOR_SETTLE_PRICE = 'M';
        public const char SESSION_HIGH_BID = 'N';
        public const char SESSION_LOW_OFFER = 'O';
        public const char EARLY_PRICES = 'P';
        public const char AUCTION_CLEARING_PRICE = 'Q';
        public const char SWAP_VALUE_FACTOR = 'S';
        public const char DAILY_VALUE_ADJUSTMENT_FOR_LONG_POSITIONS = 'R';
        public const char CUMULATIVE_VALUE_ADJUSTMENT_FOR_LONG_POSITIONS = 'T';
        public const char DAILY_VALUE_ADJUSTMENT_FOR_SHORT_POSITIONS = 'U';
        public const char CUMULATIVE_VALUE_ADJUSTMENT_FOR_SHORT_POSITIONS = 'V';
        public const char RECOVERY_RATE = 'Y';
        public const char RECOVERY_RATE_FOR_LONG = 'Z';
        public const char RECOVERY_RATE_FOR_SHORT = 'a';
        public const char FIXING_PRICE = 'W';
        public const char CASH_RATE = 'X';
        public const char ASK = '1';
        public const char IMPLIED_BID = 'Y';
        public const char IMPLIED_ASK = 'Z';
        public const char OTC_TRADE = 'm';
        public const char INDICATIVE_OPEN = 'p';
        public const char INDICATIVE_CLOSE = 'q';
        public const char INDICATIVE_BID = 'r';
        public const char INDICATIVE_ASK = 's';
        public const char INDICATIVE_SETTLEMENT = 't';
        public const char EXCHANGE_SENDING_TIME = 'u';
        public const char EXCHANGE_TRANSACT_TIME = 'v';
        public const char EXCHANGE_SEQ_NUM = 'w';
        public const char LAST_TRADED = 'x';
        public const char MARKETBIDQTY = 'o';
        public const char MARKETASKQTY = 'n';
    }


    /// <summary>
    /// MDEntryPx Field
    /// </summary>/
    public sealed class MDEntryPx : QuickFix.Fields.DecimalField
    {
        public MDEntryPx()
            :base(Fields.CustomTags.MDEntryPx) {}
        public MDEntryPx(Decimal val)
            :base(Fields.CustomTags.MDEntryPx, val) {}

    }


    /// <summary>
    /// MDEntrySize Field
    /// </summary>/
    public sealed class MDEntrySize : QuickFix.Fields.DecimalField
    {
        public MDEntrySize()
            :base(Fields.CustomTags.MDEntrySize) {}
        public MDEntrySize(Decimal val)
            :base(Fields.CustomTags.MDEntrySize, val) {}

    }


    /// <summary>
    /// MDEntryDate Field
    /// </summary>/
    public sealed class MDEntryDate : QuickFix.Fields.DateOnlyField
    {
        public MDEntryDate()
            :base(Fields.CustomTags.MDEntryDate) {}
        public MDEntryDate(DateTime val)
            :base(Fields.CustomTags.MDEntryDate, val) {}

    }


    /// <summary>
    /// MDEntryTime Field
    /// </summary>/
    public sealed class MDEntryTime : QuickFix.Fields.TimeOnlyField
    {
        public MDEntryTime()
            :base(Fields.CustomTags.MDEntryTime) {}
        public MDEntryTime(DateTime val)
            :base(Fields.CustomTags.MDEntryTime, val) {}
        public MDEntryTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.MDEntryTime, val, showMilliseconds) {}
		public MDEntryTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.MDEntryTime, val, precision) {}

    }


    /// <summary>
    /// TickDirection Field
    /// </summary>/
    public sealed class TickDirection : QuickFix.Fields.CharField
    {
        public TickDirection()
            :base(Fields.CustomTags.TickDirection) {}
        public TickDirection(char val)
            :base(Fields.CustomTags.TickDirection, val) {}


        // Field Enumerations
        public const char PLUS_TICK = '0';
        public const char ZERO_PLUS_TICK = '1';
        public const char MINUS_TICK = '2';
        public const char ZERO_MINUS_TICK = '3';
        public const char ZEROPLUS_TICK = '1';
        public const char ZEROMINUS_TICK = '3';
    }


    /// <summary>
    /// MDMkt Field
    /// </summary>/
    public sealed class MDMkt : QuickFix.Fields.StringField
    {
        public MDMkt()
            :base(Fields.CustomTags.MDMkt) {}
        public MDMkt(string val)
            :base(Fields.CustomTags.MDMkt, val) {}

    }


    /// <summary>
    /// QuoteCondition Field
    /// </summary>/
    public sealed class QuoteCondition : QuickFix.Fields.StringField
    {
        public QuoteCondition()
            :base(Fields.CustomTags.QuoteCondition) {}
        public QuoteCondition(string val)
            :base(Fields.CustomTags.QuoteCondition, val) {}


        // Field Enumerations
        public const string OPEN_ACTIVE = "A";
        public const string CLOSED_INACTIVE = "B";
        public const string EXCHANGE_BEST = "C";
        public const string CONSOLIDATED_BEST = "D";
        public const string LOCKED = "E";
        public const string CROSSED = "F";
        public const string DEPTH = "G";
        public const string FAST_TRADING = "H";
        public const string NON_FIRM = "I";
        public const string MANUAL_SLOW_QUOTE = "L";
        public const string OUTRIGHT_PRICE = "J";
        public const string IMPLIED_PRICE = "K";
        public const string DEPTH_ON_OFFER = "M";
        public const string DEPTH_ON_BID = "N";
        public const string CLOSING = "O";
        public const string NEWS_DISSEMINATION = "P";
        public const string TRADING_RANGE = "Q";
        public const string ORDER_INFLUX = "R";
        public const string DUE_TO_RELATED = "S";
        public const string NEWS_PENDING = "T";
        public const string ADDITIONAL_INFO = "U";
        public const string ADDITIONAL_INFO_DUE_TO_RELATED = "V";
        public const string RESUME = "W";
        public const string VIEW_OF_COMMON = "X";
        public const string VOLUME_ALERT = "Y";
        public const string ORDER_IMBALANCE = "Z";
        public const string EQUIPMENT_CHANGEOVER = "a";
        public const string NO_OPEN = "b";
        public const string REGULAR_ETH = "c";
        public const string AUTOMATIC_EXECUTION = "d";
        public const string AUTOMATIC_EXECUTION_ETH = "e";
        public const string FAST_MARKET_ETH = "f ";
        public const string INACTIVE_ETH = "g";
        public const string ROTATION = "h";
        public const string ROTATION_ETH = "i";
        public const string HALT = "j";
        public const string HALT_ETH = "k";
        public const string DUE_TO_NEWS_DISSEMINATION = "l";
        public const string DUE_TO_NEWS_PENDING = "m";
        public const string TRADING_RESUME = "n";
        public const string OUT_OF_SEQUENCE = "o";
        public const string BID_SPECIALIST = "p";
        public const string OFFER_SPECIALIST = "q";
        public const string BID_OFFER_SPECIALIST = "r";
        public const string END_OF_DAY_SAM = "s";
        public const string FORBIDDEN_SAM = "t";
        public const string FROZEN_SAM = "u";
        public const string PREOPENING_SAM = "v";
        public const string OPENING_SAM = "w";
        public const string OPEN_SAM = "x";
        public const string SURVEILLANCE_SAM = "y";
        public const string SUSPENDED_SAM = "z";
        public const string RESERVED_SAM = "0";
        public const string NO_ACTIVE_SAM = "1";
        public const string RESTRICTED = "2";
        public const string REST_OF_BOOK_VWAP = "3";
        public const string BETTER_PRICES_IN_CONDITIONAL_ORDERS = "4";
        public const string MEDIAN_PRICE = "5";
        public const string FULL_CURVE = "6";
        public const string FLAT_CURVE = "7";
        public const string OPEN = "A";
        public const string CLOSED = "B";
        public const string NONFIRM = "I";
    }


    /// <summary>
    /// TradeCondition Field
    /// </summary>/
    public sealed class TradeCondition : QuickFix.Fields.StringField
    {
        public TradeCondition()
            :base(Fields.CustomTags.TradeCondition) {}
        public TradeCondition(string val)
            :base(Fields.CustomTags.TradeCondition, val) {}


        // Field Enumerations
        public const string CASH = "A";
        public const string AVERAGE_PRICE_TRADE = "B";
        public const string CASH_TRADE = "C";
        public const string NEXT_DAY = "D";
        public const string OPENING_REOPENING_TRADE_DETAIL = "E";
        public const string INTRADAY_TRADE_DETAIL = "F";
        public const string RULE_127_TRADE = "G";
        public const string RULE_155_TRADE = "H";
        public const string SOLD_LAST = "I";
        public const string NEXT_DAY_TRADE = "J";
        public const string OPENED = "K";
        public const string SELLER = "L";
        public const string SOLD = "M";
        public const string STOPPED_STOCK = "N";
        public const string IMBALANCE_MORE_BUYERS = "P";
        public const string IMBALANCE_MORE_SELLERS = "Q";
        public const string OPENING_PRICE = "R";
        public const string TRADES_RESULTING_FROM_MANUAL_SLOW_QUOTE = "Y";
        public const string TRADES_RESULTING_FROM_INTERMARKET_SWEEP = "Z";
        public const string BARGAIN_CONDITION = "S";
        public const string CONVERTED_PRICE_INDICATOR = "T";
        public const string EXCHANGE_LAST = "U";
        public const string FINAL_PRICE_OF_SESSION = "V";
        public const string EX_PIT = "W";
        public const string CROSSED_X = "X";
        public const string CANCEL = "0";
        public const string VOLUME_ONLY = "a";
        public const string DIRECT_PLUS = "b";
        public const string ACQUISITION = "c";
        public const string BUNCHED = "d";
        public const string DISTRIBUTION = "e";
        public const string BUNCHED_SALE = "f";
        public const string SPLIT_TRADE = "g";
        public const string CANCEL_STOPPED = "h";
        public const string CANCEL_ETH = "i";
        public const string CANCEL_STOPPED_ETH = "j";
        public const string OUT_OF_SEQUENCE_ETH = "k";
        public const string CANCEL_LAST_ETH = "l";
        public const string SOLD_LAST_SALE_ETH = "m";
        public const string CANCEL_LAST = "n";
        public const string SOLD_LAST_SALE = "o";
        public const string CANCEL_OPEN = "p";
        public const string CANCEL_OPEN_ETH = "q";
        public const string OPENED_SALE_ETH = "r";
        public const string CANCEL_ONLY = "s";
        public const string CANCEL_ONLY_ETH = "t";
        public const string LATE_OPEN_ETH = "u";
        public const string AUTO_EXECUTION_ETH = "v";
        public const string REOPEN = "w";
        public const string REOPEN_ETH = "x";
        public const string ADJUSTED = "y";
        public const string ADJUSTED_ETH = "z";
        public const string SPREAD = "AA";
        public const string SPREAD_ETH = "AB";
        public const string STRADDLE = "AC";
        public const string STRADDLE_ETH = "AD";
        public const string STOPPED = "AE";
        public const string STOPPED_ETH = "AF";
        public const string REGULAR_ETH = "AG";
        public const string COMBO = "AH";
        public const string COMBO_ETH = "AI";
        public const string OFFICIAL_CLOSING_PRICE = "AJ";
        public const string PRIOR_REFERENCE_PRICE = "AK";
        public const string STOPPED_SOLD_LAST = "AL";
        public const string STOPPED_OUT_OF_SEQUENCE = "AM";
        public const string OFFICAL_CLOSING_PRICE = "AN";
        public const string CROSSED_AO = "AO";
        public const string FAST_MARKET = "AP";
        public const string AUTOMATIC_EXECUTION = "AQ";
        public const string FORM_T = "AR";
        public const string BASKET_INDEX = "AS";
        public const string BURST_BASKET = "AT";
        public const string IMPLIED_TRADE = "1";
        public const string OUTSIDE_SPREAD = "AV";
        public const string MARKETPLACE_ENTERED_TRADE = "2";
        public const string MULT_ASSET_CLASS_MULTILEG_TRADE = "3";
        public const string MULTILEG_TO_MULTILEG_TRADE = "4";
        public const string OPENING = "E";
    }


    /// <summary>
    /// MDEntryID Field
    /// </summary>/
    public sealed class MDEntryID : QuickFix.Fields.StringField
    {
        public MDEntryID()
            :base(Fields.CustomTags.MDEntryID) {}
        public MDEntryID(string val)
            :base(Fields.CustomTags.MDEntryID, val) {}

    }


    /// <summary>
    /// MDUpdateAction Field
    /// </summary>/
    public sealed class MDUpdateAction : QuickFix.Fields.CharField
    {
        public MDUpdateAction()
            :base(Fields.CustomTags.MDUpdateAction) {}
        public MDUpdateAction(char val)
            :base(Fields.CustomTags.MDUpdateAction, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char CHANGE = '1';
        public const char DELETE = '2';
        public const char DELETE_THRU = '3';
        public const char DELETE_FROM = '4';
        public const char OVERLAY = '5';
    }


    /// <summary>
    /// MDEntryRefID Field
    /// </summary>/
    public sealed class MDEntryRefID : QuickFix.Fields.StringField
    {
        public MDEntryRefID()
            :base(Fields.CustomTags.MDEntryRefID) {}
        public MDEntryRefID(string val)
            :base(Fields.CustomTags.MDEntryRefID, val) {}

    }


    /// <summary>
    /// MDReqRejReason Field
    /// </summary>/
    public sealed class MDReqRejReason : QuickFix.Fields.CharField
    {
        public MDReqRejReason()
            :base(Fields.CustomTags.MDReqRejReason) {}
        public MDReqRejReason(char val)
            :base(Fields.CustomTags.MDReqRejReason, val) {}


        // Field Enumerations
        public const char UNKNOWN_SYMBOL = '0';
        public const char DUPLICATE_MDREQID = '1';
        public const char INSUFFICIENT_BANDWIDTH = '2';
        public const char INSUFFICIENT_PERMISSIONS = '3';
        public const char UNSUPPORTED_SUBSCRIPTIONREQUESTTYPE = '4';
        public const char UNSUPPORTED_MARKETDEPTH = '5';
        public const char UNSUPPORTED_MDUPDATETYPE = '6';
        public const char UNSUPPORTED_AGGREGATEDBOOK = '7';
        public const char UNSUPPORTED_MDENTRYTYPE = '8';
        public const char UNSUPPORTED_TRADINGSESSIONID = '9';
        public const char UNSUPPORTED_SCOPE = 'A';
        public const char UNSUPPORTED_OPENCLOSESETTLEFLAG = 'B';
        public const char UNSUPPORTED_MDIMPLICITDELETE = 'C';
        public const char INSUFFICIENT_CREDIT = 'D';
    }


    /// <summary>
    /// MDEntryOriginator Field
    /// </summary>/
    public sealed class MDEntryOriginator : QuickFix.Fields.StringField
    {
        public MDEntryOriginator()
            :base(Fields.CustomTags.MDEntryOriginator) {}
        public MDEntryOriginator(string val)
            :base(Fields.CustomTags.MDEntryOriginator, val) {}

    }


    /// <summary>
    /// LocationID Field
    /// </summary>/
    public sealed class LocationID : QuickFix.Fields.StringField
    {
        public LocationID()
            :base(Fields.CustomTags.LocationID) {}
        public LocationID(string val)
            :base(Fields.CustomTags.LocationID, val) {}

    }


    /// <summary>
    /// DeskID Field
    /// </summary>/
    public sealed class DeskID : QuickFix.Fields.StringField
    {
        public DeskID()
            :base(Fields.CustomTags.DeskID) {}
        public DeskID(string val)
            :base(Fields.CustomTags.DeskID, val) {}

    }


    /// <summary>
    /// DeleteReason Field
    /// </summary>/
    public sealed class DeleteReason : QuickFix.Fields.CharField
    {
        public DeleteReason()
            :base(Fields.CustomTags.DeleteReason) {}
        public DeleteReason(char val)
            :base(Fields.CustomTags.DeleteReason, val) {}


        // Field Enumerations
        public const char CANCELLATION = '0';
        public const char ERROR = '1';
        public const char CANCELATION = '0';
        public const char CANCELATION_TRADE_BUST = '0';
    }


    /// <summary>
    /// OpenCloseSettleFlag Field
    /// </summary>/
    public sealed class OpenCloseSettleFlag : QuickFix.Fields.StringField
    {
        public OpenCloseSettleFlag()
            :base(Fields.CustomTags.OpenCloseSettleFlag) {}
        public OpenCloseSettleFlag(string val)
            :base(Fields.CustomTags.OpenCloseSettleFlag, val) {}


        // Field Enumerations
        public const string DAILY_OPEN = "0";
        public const string SESSION_OPEN = "1";
        public const string DELIVERY_SETTLEMENT_PRICE = "2";
        public const string EXPECTED_PRICE = "3";
        public const string PRICE_FROM_PREVIOUS_BUSINESS_DAY = "4";
        public const string DAILY_OPEN_CLOSE__SETTLEMENT_PRICE = "0";
        public const string SESSION_OPEN_CLOSE__SETTLEMENT_PRICE = "1";
    }


    /// <summary>
    /// SellerDays Field
    /// </summary>/
    public sealed class SellerDays : QuickFix.Fields.IntField
    {
        public SellerDays()
            :base(Fields.CustomTags.SellerDays) {}
        public SellerDays(int val)
            :base(Fields.CustomTags.SellerDays, val) {}

    }


    /// <summary>
    /// MDEntryBuyer Field
    /// </summary>/
    public sealed class MDEntryBuyer : QuickFix.Fields.StringField
    {
        public MDEntryBuyer()
            :base(Fields.CustomTags.MDEntryBuyer) {}
        public MDEntryBuyer(string val)
            :base(Fields.CustomTags.MDEntryBuyer, val) {}

    }


    /// <summary>
    /// MDEntrySeller Field
    /// </summary>/
    public sealed class MDEntrySeller : QuickFix.Fields.StringField
    {
        public MDEntrySeller()
            :base(Fields.CustomTags.MDEntrySeller) {}
        public MDEntrySeller(string val)
            :base(Fields.CustomTags.MDEntrySeller, val) {}

    }


    /// <summary>
    /// MDEntryPositionNo Field
    /// </summary>/
    public sealed class MDEntryPositionNo : QuickFix.Fields.IntField
    {
        public MDEntryPositionNo()
            :base(Fields.CustomTags.MDEntryPositionNo) {}
        public MDEntryPositionNo(int val)
            :base(Fields.CustomTags.MDEntryPositionNo, val) {}

    }


    /// <summary>
    /// FinancialStatus Field
    /// </summary>/
    public sealed class FinancialStatus : QuickFix.Fields.StringField
    {
        public FinancialStatus()
            :base(Fields.CustomTags.FinancialStatus) {}
        public FinancialStatus(string val)
            :base(Fields.CustomTags.FinancialStatus, val) {}


        // Field Enumerations
        public const string BANKRUPT = "1";
        public const string PENDING_DELISTING = "2";
        public const string RESTRICTED = "3";
    }


    /// <summary>
    /// CorporateAction Field
    /// </summary>/
    public sealed class CorporateAction : QuickFix.Fields.StringField
    {
        public CorporateAction()
            :base(Fields.CustomTags.CorporateAction) {}
        public CorporateAction(string val)
            :base(Fields.CustomTags.CorporateAction, val) {}


        // Field Enumerations
        public const string EX_DIVIDEND = "A";
        public const string EX_DISTRIBUTION = "B";
        public const string EX_RIGHTS = "C";
        public const string NEW = "D";
        public const string EX_INTEREST = "E";
        public const string CASH_DIVIDEND = "F";
        public const string STOCK_DIVIDEND = "G";
        public const string NON_INTEGER_STOCK_SPLIT = "H";
        public const string REVERSE_STOCK_SPLIT = "I";
        public const string STANDARD_INTEGER_STOCK_SPLIT = "J";
        public const string POSITION_CONSOLIDATION = "K";
        public const string LIQUIDATION_REORGANIZATION = "L";
        public const string MERGER_REORGANIZATION = "M";
        public const string RIGHTS_OFFERING = "N";
        public const string SHAREHOLDER_MEETING = "O";
        public const string SPINOFF = "P";
        public const string TENDER_OFFER = "Q";
        public const string WARRANT = "R";
        public const string SPECIAL_ACTION = "S";
        public const string SYMBOL_CONVERSION = "T";
        public const string CUSIP = "U";
        public const string LEAP_ROLLOVER = "V";
        public const string SUCCESSION_EVENT = "W";
        public const string EXDIVIDEND = "A";
        public const string EXDISTRIBUTION = "B";
        public const string EXRIGHTS = "C";
        public const string EXINTEREST = "E";
    }


    /// <summary>
    /// DefBidSize Field
    /// </summary>/
    public sealed class DefBidSize : QuickFix.Fields.DecimalField
    {
        public DefBidSize()
            :base(Fields.CustomTags.DefBidSize) {}
        public DefBidSize(Decimal val)
            :base(Fields.CustomTags.DefBidSize, val) {}

    }


    /// <summary>
    /// DefOfferSize Field
    /// </summary>/
    public sealed class DefOfferSize : QuickFix.Fields.DecimalField
    {
        public DefOfferSize()
            :base(Fields.CustomTags.DefOfferSize) {}
        public DefOfferSize(Decimal val)
            :base(Fields.CustomTags.DefOfferSize, val) {}

    }


    /// <summary>
    /// NoQuoteEntries Field
    /// </summary>/
    public sealed class NoQuoteEntries : QuickFix.Fields.IntField
    {
        public NoQuoteEntries()
            :base(Fields.CustomTags.NoQuoteEntries) {}
        public NoQuoteEntries(int val)
            :base(Fields.CustomTags.NoQuoteEntries, val) {}

    }


    /// <summary>
    /// NoQuoteSets Field
    /// </summary>/
    public sealed class NoQuoteSets : QuickFix.Fields.IntField
    {
        public NoQuoteSets()
            :base(Fields.CustomTags.NoQuoteSets) {}
        public NoQuoteSets(int val)
            :base(Fields.CustomTags.NoQuoteSets, val) {}

    }


    /// <summary>
    /// QuoteAckStatus Field
    /// </summary>/
    public sealed class QuoteAckStatus : QuickFix.Fields.IntField
    {
        public QuoteAckStatus()
            :base(Fields.CustomTags.QuoteAckStatus) {}
        public QuoteAckStatus(int val)
            :base(Fields.CustomTags.QuoteAckStatus, val) {}

    }


    /// <summary>
    /// QuoteCancelType Field
    /// </summary>/
    public sealed class QuoteCancelType : QuickFix.Fields.IntField
    {
        public QuoteCancelType()
            :base(Fields.CustomTags.QuoteCancelType) {}
        public QuoteCancelType(int val)
            :base(Fields.CustomTags.QuoteCancelType, val) {}


        // Field Enumerations
        public const int CANCEL_FOR_ONE_OR_MORE_SECURITIES = 1;
        public const int CANCEL_FOR_SECURITY_TYPE = 2;
        public const int CANCEL_FOR_UNDERLYING_SECURITY = 3;
        public const int CANCEL_ALL_QUOTES = 4;
        public const int CANCEL_QUOTE_SPECIFIED_IN_QUOTEID = 5;
        public const int CANCEL_BY_QUOTETYPE = 6;
        public const int CANCEL_FOR_SECURITY_ISSUER = 7;
        public const int CANCEL_FOR_ISSUER_OF_UNDERLYING_SECURITY = 8;
        public const int CANCEL_FOR_SYMBOL = 1;
        public const int CANCEL_FOR_UNDERLYING_SYMBOL = 3;
    }


    /// <summary>
    /// QuoteEntryID Field
    /// </summary>/
    public sealed class QuoteEntryID : QuickFix.Fields.StringField
    {
        public QuoteEntryID()
            :base(Fields.CustomTags.QuoteEntryID) {}
        public QuoteEntryID(string val)
            :base(Fields.CustomTags.QuoteEntryID, val) {}

    }


    /// <summary>
    /// QuoteRejectReason Field
    /// </summary>/
    public sealed class QuoteRejectReason : QuickFix.Fields.IntField
    {
        public QuoteRejectReason()
            :base(Fields.CustomTags.QuoteRejectReason) {}
        public QuoteRejectReason(int val)
            :base(Fields.CustomTags.QuoteRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_SYMBOL = 1;
        public const int EXCHANGE = 2;
        public const int QUOTE_REQUEST_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_QUOTE = 5;
        public const int DUPLICATE_QUOTE = 6;
        public const int INVALID_BID_ASK_SPREAD = 7;
        public const int INVALID_PRICE = 8;
        public const int NOT_AUTHORIZED_TO_QUOTE_SECURITY = 9;
        public const int OTHER = 99;
        public const int PRICE_EXCEEDS_CURRENT_PRICE_BAND = 10;
        public const int QUOTE_LOCKED = 11;
        public const int INVALID_OR_UNKNOWN_SECURITY_ISSUER = 12;
        public const int INVALID_OR_UNKNOWN_ISSUER_OF_UNDERLYING_SECURITY = 13;
        public const int DUPLICATE_QUOTE_7 = 6;
    }


    /// <summary>
    /// QuoteResponseLevel Field
    /// </summary>/
    public sealed class QuoteResponseLevel : QuickFix.Fields.IntField
    {
        public QuoteResponseLevel()
            :base(Fields.CustomTags.QuoteResponseLevel) {}
        public QuoteResponseLevel(int val)
            :base(Fields.CustomTags.QuoteResponseLevel, val) {}


        // Field Enumerations
        public const int NO_ACKNOWLEDGEMENT = 0;
        public const int ACKNOWLEDGE_ONLY_NEGATIVE_OR_ERRONEOUS_QUOTES = 1;
        public const int ACKNOWLEDGE_EACH_QUOTE_MESSAGE = 2;
        public const int SUMMARY_ACKNOWLEDGEMENT = 3;
        public const int ACKNOWLEDGE_EACH_QUOTE_MESSAGES = 2;
    }


    /// <summary>
    /// QuoteSetID Field
    /// </summary>/
    public sealed class QuoteSetID : QuickFix.Fields.StringField
    {
        public QuoteSetID()
            :base(Fields.CustomTags.QuoteSetID) {}
        public QuoteSetID(string val)
            :base(Fields.CustomTags.QuoteSetID, val) {}

    }


    /// <summary>
    /// QuoteRequestType Field
    /// </summary>/
    public sealed class QuoteRequestType : QuickFix.Fields.IntField
    {
        public QuoteRequestType()
            :base(Fields.CustomTags.QuoteRequestType) {}
        public QuoteRequestType(int val)
            :base(Fields.CustomTags.QuoteRequestType, val) {}


        // Field Enumerations
        public const int MANUAL = 1;
        public const int AUTOMATIC = 2;
    }


    /// <summary>
    /// TotQuoteEntries Field
    /// </summary>/
    public sealed class TotQuoteEntries : QuickFix.Fields.IntField
    {
        public TotQuoteEntries()
            :base(Fields.CustomTags.TotQuoteEntries) {}
        public TotQuoteEntries(int val)
            :base(Fields.CustomTags.TotQuoteEntries, val) {}

    }


    /// <summary>
    /// UnderlyingIDSource Field
    /// </summary>/
    public sealed class UnderlyingIDSource : QuickFix.Fields.StringField
    {
        public UnderlyingIDSource()
            :base(Fields.CustomTags.UnderlyingIDSource) {}
        public UnderlyingIDSource(string val)
            :base(Fields.CustomTags.UnderlyingIDSource, val) {}

    }


    /// <summary>
    /// UnderlyingIssuer Field
    /// </summary>/
    public sealed class UnderlyingIssuer : QuickFix.Fields.StringField
    {
        public UnderlyingIssuer()
            :base(Fields.CustomTags.UnderlyingIssuer) {}
        public UnderlyingIssuer(string val)
            :base(Fields.CustomTags.UnderlyingIssuer, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityDesc Field
    /// </summary>/
    public sealed class UnderlyingSecurityDesc : QuickFix.Fields.StringField
    {
        public UnderlyingSecurityDesc()
            :base(Fields.CustomTags.UnderlyingSecurityDesc) {}
        public UnderlyingSecurityDesc(string val)
            :base(Fields.CustomTags.UnderlyingSecurityDesc, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityExchange Field
    /// </summary>/
    public sealed class UnderlyingSecurityExchange : QuickFix.Fields.StringField
    {
        public UnderlyingSecurityExchange()
            :base(Fields.CustomTags.UnderlyingSecurityExchange) {}
        public UnderlyingSecurityExchange(string val)
            :base(Fields.CustomTags.UnderlyingSecurityExchange, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityID Field
    /// </summary>/
    public sealed class UnderlyingSecurityID : QuickFix.Fields.StringField
    {
        public UnderlyingSecurityID()
            :base(Fields.CustomTags.UnderlyingSecurityID) {}
        public UnderlyingSecurityID(string val)
            :base(Fields.CustomTags.UnderlyingSecurityID, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityType Field
    /// </summary>/
    public sealed class UnderlyingSecurityType : QuickFix.Fields.StringField
    {
        public UnderlyingSecurityType()
            :base(Fields.CustomTags.UnderlyingSecurityType) {}
        public UnderlyingSecurityType(string val)
            :base(Fields.CustomTags.UnderlyingSecurityType, val) {}

    }


    /// <summary>
    /// UnderlyingSymbol Field
    /// </summary>/
    public sealed class UnderlyingSymbol : QuickFix.Fields.StringField
    {
        public UnderlyingSymbol()
            :base(Fields.CustomTags.UnderlyingSymbol) {}
        public UnderlyingSymbol(string val)
            :base(Fields.CustomTags.UnderlyingSymbol, val) {}

    }


    /// <summary>
    /// UnderlyingSymbolSfx Field
    /// </summary>/
    public sealed class UnderlyingSymbolSfx : QuickFix.Fields.StringField
    {
        public UnderlyingSymbolSfx()
            :base(Fields.CustomTags.UnderlyingSymbolSfx) {}
        public UnderlyingSymbolSfx(string val)
            :base(Fields.CustomTags.UnderlyingSymbolSfx, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityMonthYear Field
    /// </summary>/
    public sealed class UnderlyingMaturityMonthYear : QuickFix.Fields.StringField
    {
        public UnderlyingMaturityMonthYear()
            :base(Fields.CustomTags.UnderlyingMaturityMonthYear) {}
        public UnderlyingMaturityMonthYear(string val)
            :base(Fields.CustomTags.UnderlyingMaturityMonthYear, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityDay Field
    /// </summary>/
    public sealed class UnderlyingMaturityDay : QuickFix.Fields.StringField
    {
        public UnderlyingMaturityDay()
            :base(Fields.CustomTags.UnderlyingMaturityDay) {}
        public UnderlyingMaturityDay(string val)
            :base(Fields.CustomTags.UnderlyingMaturityDay, val) {}

    }


    /// <summary>
    /// UnderlyingPutOrCall Field
    /// </summary>/
    public sealed class UnderlyingPutOrCall : QuickFix.Fields.IntField
    {
        public UnderlyingPutOrCall()
            :base(Fields.CustomTags.UnderlyingPutOrCall) {}
        public UnderlyingPutOrCall(int val)
            :base(Fields.CustomTags.UnderlyingPutOrCall, val) {}

    }


    /// <summary>
    /// UnderlyingStrikePrice Field
    /// </summary>/
    public sealed class UnderlyingStrikePrice : QuickFix.Fields.DecimalField
    {
        public UnderlyingStrikePrice()
            :base(Fields.CustomTags.UnderlyingStrikePrice) {}
        public UnderlyingStrikePrice(Decimal val)
            :base(Fields.CustomTags.UnderlyingStrikePrice, val) {}

    }


    /// <summary>
    /// UnderlyingOptAttribute Field
    /// </summary>/
    public sealed class UnderlyingOptAttribute : QuickFix.Fields.CharField
    {
        public UnderlyingOptAttribute()
            :base(Fields.CustomTags.UnderlyingOptAttribute) {}
        public UnderlyingOptAttribute(char val)
            :base(Fields.CustomTags.UnderlyingOptAttribute, val) {}

    }


    /// <summary>
    /// UnderlyingCurrency Field
    /// </summary>/
    public sealed class UnderlyingCurrency : QuickFix.Fields.StringField
    {
        public UnderlyingCurrency()
            :base(Fields.CustomTags.UnderlyingCurrency) {}
        public UnderlyingCurrency(string val)
            :base(Fields.CustomTags.UnderlyingCurrency, val) {}

    }


    /// <summary>
    /// RatioQty Field
    /// </summary>/
    public sealed class RatioQty : QuickFix.Fields.DecimalField
    {
        public RatioQty()
            :base(Fields.CustomTags.RatioQty) {}
        public RatioQty(Decimal val)
            :base(Fields.CustomTags.RatioQty, val) {}

    }


    /// <summary>
    /// SecurityReqID Field
    /// </summary>/
    public sealed class SecurityReqID : QuickFix.Fields.StringField
    {
        public SecurityReqID()
            :base(Fields.CustomTags.SecurityReqID) {}
        public SecurityReqID(string val)
            :base(Fields.CustomTags.SecurityReqID, val) {}

    }


    /// <summary>
    /// SecurityRequestType Field
    /// </summary>/
    public sealed class SecurityRequestType : QuickFix.Fields.IntField
    {
        public SecurityRequestType()
            :base(Fields.CustomTags.SecurityRequestType) {}
        public SecurityRequestType(int val)
            :base(Fields.CustomTags.SecurityRequestType, val) {}


        // Field Enumerations
        public const int REQUEST_SECURITY_IDENTITY_AND_SPECIFICATIONS = 0;
        public const int REQUEST_SECURITY_IDENTITY_FOR_THE_SPECIFICATIONS_PROVIDED = 1;
        public const int REQUEST_LIST_SECURITY_TYPES = 2;
        public const int REQUEST_LIST_SECURITIES = 3;
        public const int SYMBOL = 4;
        public const int SECURITYTYPE_AND_OR_CFICODE = 5;
        public const int PRODUCT = 6;
        public const int TRADINGSESSIONID = 7;
        public const int ALL_SECURITIES = 8;
        public const int MARKETID_OR_MARKETID_PLUS_MARKETSEGMENTID = 9;
    }


    /// <summary>
    /// SecurityResponseID Field
    /// </summary>/
    public sealed class SecurityResponseID : QuickFix.Fields.StringField
    {
        public SecurityResponseID()
            :base(Fields.CustomTags.SecurityResponseID) {}
        public SecurityResponseID(string val)
            :base(Fields.CustomTags.SecurityResponseID, val) {}

    }


    /// <summary>
    /// SecurityResponseType Field
    /// </summary>/
    public sealed class SecurityResponseType : QuickFix.Fields.IntField
    {
        public SecurityResponseType()
            :base(Fields.CustomTags.SecurityResponseType) {}
        public SecurityResponseType(int val)
            :base(Fields.CustomTags.SecurityResponseType, val) {}


        // Field Enumerations
        public const int ACCEPT_SECURITY_PROPOSAL_AS_IS = 1;
        public const int ACCEPT_SECURITY_PROPOSAL_WITH_REVISIONS_AS_INDICATED_IN_THE_MESSAGE = 2;
        public const int LIST_OF_SECURITY_TYPES_RETURNED_PER_REQUEST = 3;
        public const int LIST_OF_SECURITIES_RETURNED_PER_REQUEST = 4;
        public const int REJECT_SECURITY_PROPOSAL = 5;
        public const int CANNOT_MATCH_SELECTION_CRITERIA = 6;
        public const int CAN_NOT_MATCH_SELECTION_CRITERIA = 6;
    }


    /// <summary>
    /// SecurityStatusReqID Field
    /// </summary>/
    public sealed class SecurityStatusReqID : QuickFix.Fields.StringField
    {
        public SecurityStatusReqID()
            :base(Fields.CustomTags.SecurityStatusReqID) {}
        public SecurityStatusReqID(string val)
            :base(Fields.CustomTags.SecurityStatusReqID, val) {}

    }


    /// <summary>
    /// UnsolicitedIndicator Field
    /// </summary>/
    public sealed class UnsolicitedIndicator : QuickFix.Fields.BooleanField
    {
        public UnsolicitedIndicator()
            :base(Fields.CustomTags.UnsolicitedIndicator) {}
        public UnsolicitedIndicator(Boolean val)
            :base(Fields.CustomTags.UnsolicitedIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean MESSAGE_IS_BEING_SENT_UNSOLICITED = true;
        public const Boolean MESSAGE_IS_BEING_SENT_AS_A_RESULT_OF_A_PRIOR_REQUEST = false;
    }


    /// <summary>
    /// SecurityTradingStatus Field
    /// </summary>/
    public sealed class SecurityTradingStatus : QuickFix.Fields.IntField
    {
        public SecurityTradingStatus()
            :base(Fields.CustomTags.SecurityTradingStatus) {}
        public SecurityTradingStatus(int val)
            :base(Fields.CustomTags.SecurityTradingStatus, val) {}


        // Field Enumerations
        public const int OPENING_DELAY = 1;
        public const int MARKET_ON_CLOSE_IMBALANCE_SELL = 10;
        public const int VAL_11 = 11;
        public const int NO_MARKET_IMBALANCE = 12;
        public const int NO_MARKET_ON_CLOSE_IMBALANCE = 13;
        public const int ITS_PRE_OPENING = 14;
        public const int NEW_PRICE_INDICATION = 15;
        public const int TRADE_DISSEMINATION_TIME = 16;
        public const int READY_TO_TRADE = 17;
        public const int NOT_AVAILABLE_FOR_TRADING = 18;
        public const int NOT_TRADED_ON_THIS_MARKET = 19;
        public const int TRADING_HALT = 2;
        public const int UNKNOWN_OR_INVALID = 20;
        public const int PRE_OPEN = 21;
        public const int OPENING_ROTATION = 22;
        public const int FAST_MARKET = 23;
        public const int RESUME = 3;
        public const int NO_OPEN = 4;
        public const int PRICE_INDICATION = 5;
        public const int TRADING_RANGE_INDICATION = 6;
        public const int MARKET_IMBALANCE_BUY = 7;
        public const int MARKET_IMBALANCE_SELL = 8;
        public const int MARKET_ON_CLOSE_IMBALANCE_BUY = 9;
        public const int PRE_CROSS = 24;
        public const int CROSS = 25;
        public const int POST_CLOSE = 26;
        public const int PREOPEN = 21;
        public const int PRE_TRADE = 99;
        public const int NOT_ASSIGNED = 11;
        public const int NO_OPENNO_RESUME = 4;
        public const int ITS_PREOPENING = 14;
    }


    /// <summary>
    /// HaltReason Field
    /// </summary>/
    public sealed class HaltReason : QuickFix.Fields.CharField
    {
        public HaltReason()
            :base(Fields.CustomTags.HaltReason) {}
        public HaltReason(char val)
            :base(Fields.CustomTags.HaltReason, val) {}


        // Field Enumerations
        public const char ORDER_IMBALANCE = 'I';
        public const char EQUIPMENT_CHANGEOVER = 'X';
        public const char NEWS_PENDING = 'P';
        public const char NEWS_DISSEMINATION = 'D';
        public const char ORDER_INFLUX = 'E';
        public const char ADDITIONAL_INFORMATION = 'M';
    }


    /// <summary>
    /// InViewOfCommon Field
    /// </summary>/
    public sealed class InViewOfCommon : QuickFix.Fields.BooleanField
    {
        public InViewOfCommon()
            :base(Fields.CustomTags.InViewOfCommon) {}
        public InViewOfCommon(Boolean val)
            :base(Fields.CustomTags.InViewOfCommon, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean HALT_WAS_DUE_TO_COMMON_STOCK_BEING_HALTED = true;
        public const Boolean HALT_WAS_NOT_RELATED_TO_A_HALT_OF_THE_COMMON_STOCK = false;
    }


    /// <summary>
    /// DueToRelated Field
    /// </summary>/
    public sealed class DueToRelated : QuickFix.Fields.BooleanField
    {
        public DueToRelated()
            :base(Fields.CustomTags.DueToRelated) {}
        public DueToRelated(Boolean val)
            :base(Fields.CustomTags.DueToRelated, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean HALT_WAS_DUE_TO_RELATED_SECURITY_BEING_HALTED = true;
        public const Boolean HALT_WAS_NOT_RELATED_TO_A_HALT_OF_THE_RELATED_SECURITY = false;
    }


    /// <summary>
    /// BuyVolume Field
    /// </summary>/
    public sealed class BuyVolume : QuickFix.Fields.DecimalField
    {
        public BuyVolume()
            :base(Fields.CustomTags.BuyVolume) {}
        public BuyVolume(Decimal val)
            :base(Fields.CustomTags.BuyVolume, val) {}

    }


    /// <summary>
    /// SellVolume Field
    /// </summary>/
    public sealed class SellVolume : QuickFix.Fields.DecimalField
    {
        public SellVolume()
            :base(Fields.CustomTags.SellVolume) {}
        public SellVolume(Decimal val)
            :base(Fields.CustomTags.SellVolume, val) {}

    }


    /// <summary>
    /// HighPx Field
    /// </summary>/
    public sealed class HighPx : QuickFix.Fields.DecimalField
    {
        public HighPx()
            :base(Fields.CustomTags.HighPx) {}
        public HighPx(Decimal val)
            :base(Fields.CustomTags.HighPx, val) {}

    }


    /// <summary>
    /// LowPx Field
    /// </summary>/
    public sealed class LowPx : QuickFix.Fields.DecimalField
    {
        public LowPx()
            :base(Fields.CustomTags.LowPx) {}
        public LowPx(Decimal val)
            :base(Fields.CustomTags.LowPx, val) {}

    }


    /// <summary>
    /// Adjustment Field
    /// </summary>/
    public sealed class Adjustment : QuickFix.Fields.IntField
    {
        public Adjustment()
            :base(Fields.CustomTags.Adjustment) {}
        public Adjustment(int val)
            :base(Fields.CustomTags.Adjustment, val) {}


        // Field Enumerations
        public const int CANCEL = 1;
        public const int ERROR = 2;
        public const int CORRECTION = 3;
    }


    /// <summary>
    /// TradSesReqID Field
    /// </summary>/
    public sealed class TradSesReqID : QuickFix.Fields.StringField
    {
        public TradSesReqID()
            :base(Fields.CustomTags.TradSesReqID) {}
        public TradSesReqID(string val)
            :base(Fields.CustomTags.TradSesReqID, val) {}

    }


    /// <summary>
    /// TradingSessionID Field
    /// </summary>/
    public sealed class TradingSessionID : QuickFix.Fields.StringField
    {
        public TradingSessionID()
            :base(Fields.CustomTags.TradingSessionID) {}
        public TradingSessionID(string val)
            :base(Fields.CustomTags.TradingSessionID, val) {}


        // Field Enumerations
        public const string DAY = "1";
        public const string HALFDAY = "2";
        public const string MORNING = "3";
        public const string AFTERNOON = "4";
        public const string EVENING = "5";
        public const string AFTER_HOURS = "6";
    }


    /// <summary>
    /// ContraTrader Field
    /// </summary>/
    public sealed class ContraTrader : QuickFix.Fields.StringField
    {
        public ContraTrader()
            :base(Fields.CustomTags.ContraTrader) {}
        public ContraTrader(string val)
            :base(Fields.CustomTags.ContraTrader, val) {}

    }


    /// <summary>
    /// TradSesMethod Field
    /// </summary>/
    public sealed class TradSesMethod : QuickFix.Fields.IntField
    {
        public TradSesMethod()
            :base(Fields.CustomTags.TradSesMethod) {}
        public TradSesMethod(int val)
            :base(Fields.CustomTags.TradSesMethod, val) {}


        // Field Enumerations
        public const int ELECTRONIC = 1;
        public const int OPEN_OUTCRY = 2;
        public const int TWO_PARTY = 3;
    }


    /// <summary>
    /// TradSesMode Field
    /// </summary>/
    public sealed class TradSesMode : QuickFix.Fields.IntField
    {
        public TradSesMode()
            :base(Fields.CustomTags.TradSesMode) {}
        public TradSesMode(int val)
            :base(Fields.CustomTags.TradSesMode, val) {}


        // Field Enumerations
        public const int TESTING = 1;
        public const int SIMULATED = 2;
        public const int PRODUCTION = 3;
    }


    /// <summary>
    /// TradSesStatus Field
    /// </summary>/
    public sealed class TradSesStatus : QuickFix.Fields.IntField
    {
        public TradSesStatus()
            :base(Fields.CustomTags.TradSesStatus) {}
        public TradSesStatus(int val)
            :base(Fields.CustomTags.TradSesStatus, val) {}


        // Field Enumerations
        public const int UNKNOWN = 0;
        public const int HALTED = 1;
        public const int OPEN = 2;
        public const int CLOSED = 3;
        public const int PRE_OPEN = 4;
        public const int PRE_CLOSE = 5;
        public const int REQUEST_REJECTED = 6;
        public const int PREOPEN = 4;
        public const int PRECLOSE = 5;
    }


    /// <summary>
    /// TradSesStartTime Field
    /// </summary>/
    public sealed class TradSesStartTime : QuickFix.Fields.DateTimeField
    {
        public TradSesStartTime()
            :base(Fields.CustomTags.TradSesStartTime) {}
        public TradSesStartTime(DateTime val)
            :base(Fields.CustomTags.TradSesStartTime, val) {}
        public TradSesStartTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TradSesStartTime, val, showMilliseconds) {}
		public TradSesStartTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TradSesStartTime, val, precision) {}

    }


    /// <summary>
    /// TradSesOpenTime Field
    /// </summary>/
    public sealed class TradSesOpenTime : QuickFix.Fields.DateTimeField
    {
        public TradSesOpenTime()
            :base(Fields.CustomTags.TradSesOpenTime) {}
        public TradSesOpenTime(DateTime val)
            :base(Fields.CustomTags.TradSesOpenTime, val) {}
        public TradSesOpenTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TradSesOpenTime, val, showMilliseconds) {}
		public TradSesOpenTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TradSesOpenTime, val, precision) {}

    }


    /// <summary>
    /// TradSesPreCloseTime Field
    /// </summary>/
    public sealed class TradSesPreCloseTime : QuickFix.Fields.DateTimeField
    {
        public TradSesPreCloseTime()
            :base(Fields.CustomTags.TradSesPreCloseTime) {}
        public TradSesPreCloseTime(DateTime val)
            :base(Fields.CustomTags.TradSesPreCloseTime, val) {}
        public TradSesPreCloseTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TradSesPreCloseTime, val, showMilliseconds) {}
		public TradSesPreCloseTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TradSesPreCloseTime, val, precision) {}

    }


    /// <summary>
    /// TradSesCloseTime Field
    /// </summary>/
    public sealed class TradSesCloseTime : QuickFix.Fields.DateTimeField
    {
        public TradSesCloseTime()
            :base(Fields.CustomTags.TradSesCloseTime) {}
        public TradSesCloseTime(DateTime val)
            :base(Fields.CustomTags.TradSesCloseTime, val) {}
        public TradSesCloseTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TradSesCloseTime, val, showMilliseconds) {}
		public TradSesCloseTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TradSesCloseTime, val, precision) {}

    }


    /// <summary>
    /// TradSesEndTime Field
    /// </summary>/
    public sealed class TradSesEndTime : QuickFix.Fields.DateTimeField
    {
        public TradSesEndTime()
            :base(Fields.CustomTags.TradSesEndTime) {}
        public TradSesEndTime(DateTime val)
            :base(Fields.CustomTags.TradSesEndTime, val) {}
        public TradSesEndTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TradSesEndTime, val, showMilliseconds) {}
		public TradSesEndTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TradSesEndTime, val, precision) {}

    }


    /// <summary>
    /// NumberOfOrders Field
    /// </summary>/
    public sealed class NumberOfOrders : QuickFix.Fields.IntField
    {
        public NumberOfOrders()
            :base(Fields.CustomTags.NumberOfOrders) {}
        public NumberOfOrders(int val)
            :base(Fields.CustomTags.NumberOfOrders, val) {}

    }


    /// <summary>
    /// MessageEncoding Field
    /// </summary>/
    public sealed class MessageEncoding : QuickFix.Fields.StringField
    {
        public MessageEncoding()
            :base(Fields.CustomTags.MessageEncoding) {}
        public MessageEncoding(string val)
            :base(Fields.CustomTags.MessageEncoding, val) {}

    }


    /// <summary>
    /// EncodedIssuerLen Field
    /// </summary>/
    public sealed class EncodedIssuerLen : QuickFix.Fields.IntField
    {
        public EncodedIssuerLen()
            :base(Fields.CustomTags.EncodedIssuerLen) {}
        public EncodedIssuerLen(int val)
            :base(Fields.CustomTags.EncodedIssuerLen, val) {}

    }


    /// <summary>
    /// EncodedIssuer Field
    /// </summary>/
    public sealed class EncodedIssuer : QuickFix.Fields.StringField
    {
        public EncodedIssuer()
            :base(Fields.CustomTags.EncodedIssuer) {}
        public EncodedIssuer(string val)
            :base(Fields.CustomTags.EncodedIssuer, val) {}

    }


    /// <summary>
    /// EncodedSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedSecurityDescLen : QuickFix.Fields.IntField
    {
        public EncodedSecurityDescLen()
            :base(Fields.CustomTags.EncodedSecurityDescLen) {}
        public EncodedSecurityDescLen(int val)
            :base(Fields.CustomTags.EncodedSecurityDescLen, val) {}

    }


    /// <summary>
    /// EncodedSecurityDesc Field
    /// </summary>/
    public sealed class EncodedSecurityDesc : QuickFix.Fields.StringField
    {
        public EncodedSecurityDesc()
            :base(Fields.CustomTags.EncodedSecurityDesc) {}
        public EncodedSecurityDesc(string val)
            :base(Fields.CustomTags.EncodedSecurityDesc, val) {}

    }


    /// <summary>
    /// EncodedListExecInstLen Field
    /// </summary>/
    public sealed class EncodedListExecInstLen : QuickFix.Fields.IntField
    {
        public EncodedListExecInstLen()
            :base(Fields.CustomTags.EncodedListExecInstLen) {}
        public EncodedListExecInstLen(int val)
            :base(Fields.CustomTags.EncodedListExecInstLen, val) {}

    }


    /// <summary>
    /// EncodedListExecInst Field
    /// </summary>/
    public sealed class EncodedListExecInst : QuickFix.Fields.StringField
    {
        public EncodedListExecInst()
            :base(Fields.CustomTags.EncodedListExecInst) {}
        public EncodedListExecInst(string val)
            :base(Fields.CustomTags.EncodedListExecInst, val) {}

    }


    /// <summary>
    /// EncodedTextLen Field
    /// </summary>/
    public sealed class EncodedTextLen : QuickFix.Fields.IntField
    {
        public EncodedTextLen()
            :base(Fields.CustomTags.EncodedTextLen) {}
        public EncodedTextLen(int val)
            :base(Fields.CustomTags.EncodedTextLen, val) {}

    }


    /// <summary>
    /// EncodedText Field
    /// </summary>/
    public sealed class EncodedText : QuickFix.Fields.StringField
    {
        public EncodedText()
            :base(Fields.CustomTags.EncodedText) {}
        public EncodedText(string val)
            :base(Fields.CustomTags.EncodedText, val) {}

    }


    /// <summary>
    /// EncodedSubjectLen Field
    /// </summary>/
    public sealed class EncodedSubjectLen : QuickFix.Fields.IntField
    {
        public EncodedSubjectLen()
            :base(Fields.CustomTags.EncodedSubjectLen) {}
        public EncodedSubjectLen(int val)
            :base(Fields.CustomTags.EncodedSubjectLen, val) {}

    }


    /// <summary>
    /// EncodedSubject Field
    /// </summary>/
    public sealed class EncodedSubject : QuickFix.Fields.StringField
    {
        public EncodedSubject()
            :base(Fields.CustomTags.EncodedSubject) {}
        public EncodedSubject(string val)
            :base(Fields.CustomTags.EncodedSubject, val) {}

    }


    /// <summary>
    /// EncodedHeadlineLen Field
    /// </summary>/
    public sealed class EncodedHeadlineLen : QuickFix.Fields.IntField
    {
        public EncodedHeadlineLen()
            :base(Fields.CustomTags.EncodedHeadlineLen) {}
        public EncodedHeadlineLen(int val)
            :base(Fields.CustomTags.EncodedHeadlineLen, val) {}

    }


    /// <summary>
    /// EncodedHeadline Field
    /// </summary>/
    public sealed class EncodedHeadline : QuickFix.Fields.StringField
    {
        public EncodedHeadline()
            :base(Fields.CustomTags.EncodedHeadline) {}
        public EncodedHeadline(string val)
            :base(Fields.CustomTags.EncodedHeadline, val) {}

    }


    /// <summary>
    /// EncodedAllocTextLen Field
    /// </summary>/
    public sealed class EncodedAllocTextLen : QuickFix.Fields.IntField
    {
        public EncodedAllocTextLen()
            :base(Fields.CustomTags.EncodedAllocTextLen) {}
        public EncodedAllocTextLen(int val)
            :base(Fields.CustomTags.EncodedAllocTextLen, val) {}

    }


    /// <summary>
    /// EncodedAllocText Field
    /// </summary>/
    public sealed class EncodedAllocText : QuickFix.Fields.StringField
    {
        public EncodedAllocText()
            :base(Fields.CustomTags.EncodedAllocText) {}
        public EncodedAllocText(string val)
            :base(Fields.CustomTags.EncodedAllocText, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingIssuerLen Field
    /// </summary>/
    public sealed class EncodedUnderlyingIssuerLen : QuickFix.Fields.IntField
    {
        public EncodedUnderlyingIssuerLen()
            :base(Fields.CustomTags.EncodedUnderlyingIssuerLen) {}
        public EncodedUnderlyingIssuerLen(int val)
            :base(Fields.CustomTags.EncodedUnderlyingIssuerLen, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingIssuer Field
    /// </summary>/
    public sealed class EncodedUnderlyingIssuer : QuickFix.Fields.StringField
    {
        public EncodedUnderlyingIssuer()
            :base(Fields.CustomTags.EncodedUnderlyingIssuer) {}
        public EncodedUnderlyingIssuer(string val)
            :base(Fields.CustomTags.EncodedUnderlyingIssuer, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedUnderlyingSecurityDescLen : QuickFix.Fields.IntField
    {
        public EncodedUnderlyingSecurityDescLen()
            :base(Fields.CustomTags.EncodedUnderlyingSecurityDescLen) {}
        public EncodedUnderlyingSecurityDescLen(int val)
            :base(Fields.CustomTags.EncodedUnderlyingSecurityDescLen, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingSecurityDesc Field
    /// </summary>/
    public sealed class EncodedUnderlyingSecurityDesc : QuickFix.Fields.StringField
    {
        public EncodedUnderlyingSecurityDesc()
            :base(Fields.CustomTags.EncodedUnderlyingSecurityDesc) {}
        public EncodedUnderlyingSecurityDesc(string val)
            :base(Fields.CustomTags.EncodedUnderlyingSecurityDesc, val) {}

    }


    /// <summary>
    /// AllocPrice Field
    /// </summary>/
    public sealed class AllocPrice : QuickFix.Fields.DecimalField
    {
        public AllocPrice()
            :base(Fields.CustomTags.AllocPrice) {}
        public AllocPrice(Decimal val)
            :base(Fields.CustomTags.AllocPrice, val) {}

    }


    /// <summary>
    /// QuoteSetValidUntilTime Field
    /// </summary>/
    public sealed class QuoteSetValidUntilTime : QuickFix.Fields.DateTimeField
    {
        public QuoteSetValidUntilTime()
            :base(Fields.CustomTags.QuoteSetValidUntilTime) {}
        public QuoteSetValidUntilTime(DateTime val)
            :base(Fields.CustomTags.QuoteSetValidUntilTime, val) {}
        public QuoteSetValidUntilTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.QuoteSetValidUntilTime, val, showMilliseconds) {}
		public QuoteSetValidUntilTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.QuoteSetValidUntilTime, val, precision) {}

    }


    /// <summary>
    /// QuoteEntryRejectReason Field
    /// </summary>/
    public sealed class QuoteEntryRejectReason : QuickFix.Fields.IntField
    {
        public QuoteEntryRejectReason()
            :base(Fields.CustomTags.QuoteEntryRejectReason) {}
        public QuoteEntryRejectReason(int val)
            :base(Fields.CustomTags.QuoteEntryRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_SYMBOL = 1;
        public const int EXHCNAGE = 2;
        public const int QUOTE_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_QUOTE = 5;
        public const int DUPLICATE_QUOTE = 6;
        public const int INVALID_BID_ASK_SPREAD = 7;
        public const int INVALID_PRICE = 8;
        public const int NOT_AUTHORIZED_TO_QUOTE_SECURITY = 9;
        public const int OTHER = 99;
        public const int EXCHANGE = 2;
        public const int INVALID_BID = 7;
        public const int INVALID_BIDASK_SPREAD = 7;
    }


    /// <summary>
    /// LastMsgSeqNumProcessed Field
    /// </summary>/
    public sealed class LastMsgSeqNumProcessed : QuickFix.Fields.IntField
    {
        public LastMsgSeqNumProcessed()
            :base(Fields.CustomTags.LastMsgSeqNumProcessed) {}
        public LastMsgSeqNumProcessed(int val)
            :base(Fields.CustomTags.LastMsgSeqNumProcessed, val) {}

    }


    /// <summary>
    /// OnBehalfOfSendingTime Field
    /// </summary>/
    public sealed class OnBehalfOfSendingTime : QuickFix.Fields.DateTimeField
    {
        public OnBehalfOfSendingTime()
            :base(Fields.CustomTags.OnBehalfOfSendingTime) {}
        public OnBehalfOfSendingTime(DateTime val)
            :base(Fields.CustomTags.OnBehalfOfSendingTime, val) {}
        public OnBehalfOfSendingTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.OnBehalfOfSendingTime, val, showMilliseconds) {}
		public OnBehalfOfSendingTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.OnBehalfOfSendingTime, val, precision) {}

    }


    /// <summary>
    /// RefTagID Field
    /// </summary>/
    public sealed class RefTagID : QuickFix.Fields.IntField
    {
        public RefTagID()
            :base(Fields.CustomTags.RefTagID) {}
        public RefTagID(int val)
            :base(Fields.CustomTags.RefTagID, val) {}

    }


    /// <summary>
    /// RefMsgType Field
    /// </summary>/
    public sealed class RefMsgType : QuickFix.Fields.StringField
    {
        public RefMsgType()
            :base(Fields.CustomTags.RefMsgType) {}
        public RefMsgType(string val)
            :base(Fields.CustomTags.RefMsgType, val) {}

    }


    /// <summary>
    /// SessionRejectReason Field
    /// </summary>/
    public sealed class SessionRejectReason : QuickFix.Fields.IntField
    {
        public SessionRejectReason()
            :base(Fields.CustomTags.SessionRejectReason) {}
        public SessionRejectReason(int val)
            :base(Fields.CustomTags.SessionRejectReason, val) {}


        // Field Enumerations
        public const int INVALID_TAG_NUMBER = 0;
        public const int REQUIRED_TAG_MISSING = 1;
        public const int SENDINGTIME_ACCURACY_PROBLEM = 10;
        public const int INVALID_MSGTYPE = 11;
        public const int XML_VALIDATION_ERROR = 12;
        public const int TAG_APPEARS_MORE_THAN_ONCE = 13;
        public const int TAG_SPECIFIED_OUT_OF_REQUIRED_ORDER = 14;
        public const int REPEATING_GROUP_FIELDS_OUT_OF_ORDER = 15;
        public const int INCORRECT_NUMINGROUP_COUNT_FOR_REPEATING_GROUP = 16;
        public const int NON_DATA_VALUE_INCLUDES_FIELD_DELIMITER = 17;
        public const int TAG_NOT_DEFINED_FOR_THIS_MESSAGE_TYPE = 2;
        public const int UNDEFINED_TAG = 3;
        public const int TAG_SPECIFIED_WITHOUT_A_VALUE = 4;
        public const int VALUE_IS_INCORRECT = 5;
        public const int INCORRECT_DATA_FORMAT_FOR_VALUE = 6;
        public const int DECRYPTION_PROBLEM = 7;
        public const int SIGNATURE_PROBLEM = 8;
        public const int COMPID_PROBLEM = 9;
        public const int OTHER = 99;
        public const int INVALID_UNSUPPORTED_APPLICATION_VERSION = 18;
        public const int E = 11;
    }


    /// <summary>
    /// BidRequestTransType Field
    /// </summary>/
    public sealed class BidRequestTransType : QuickFix.Fields.CharField
    {
        public BidRequestTransType()
            :base(Fields.CustomTags.BidRequestTransType) {}
        public BidRequestTransType(char val)
            :base(Fields.CustomTags.BidRequestTransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NO = 'N';
        public const char NEW = 'N';
    }


    /// <summary>
    /// ContraBroker Field
    /// </summary>/
    public sealed class ContraBroker : QuickFix.Fields.StringField
    {
        public ContraBroker()
            :base(Fields.CustomTags.ContraBroker) {}
        public ContraBroker(string val)
            :base(Fields.CustomTags.ContraBroker, val) {}

    }


    /// <summary>
    /// ComplianceID Field
    /// </summary>/
    public sealed class ComplianceID : QuickFix.Fields.StringField
    {
        public ComplianceID()
            :base(Fields.CustomTags.ComplianceID) {}
        public ComplianceID(string val)
            :base(Fields.CustomTags.ComplianceID, val) {}

    }


    /// <summary>
    /// SolicitedFlag Field
    /// </summary>/
    public sealed class SolicitedFlag : QuickFix.Fields.BooleanField
    {
        public SolicitedFlag()
            :base(Fields.CustomTags.SolicitedFlag) {}
        public SolicitedFlag(Boolean val)
            :base(Fields.CustomTags.SolicitedFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean WAS_SOLCITIED = true;
        public const Boolean WAS_NOT_SOLICITED = false;
    }


    /// <summary>
    /// ExecRestatementReason Field
    /// </summary>/
    public sealed class ExecRestatementReason : QuickFix.Fields.IntField
    {
        public ExecRestatementReason()
            :base(Fields.CustomTags.ExecRestatementReason) {}
        public ExecRestatementReason(int val)
            :base(Fields.CustomTags.ExecRestatementReason, val) {}


        // Field Enumerations
        public const int GT_CORPORATE_ACTION = 0;
        public const int GT_RENEWAL = 1;
        public const int WAREHOUSE_RECAP = 10;
        public const int VERBAL_CHANGE = 2;
        public const int REPRICING_OF_ORDER = 3;
        public const int BROKER_OPTION = 4;
        public const int PARTIAL_DECLINE_OF_ORDERQTY = 5;
        public const int CANCEL_ON_TRADING_HALT = 6;
        public const int CANCEL_ON_SYSTEM_FAILURE = 7;
        public const int MARKET = 8;
        public const int CANCELED_NOT_BEST = 9;
        public const int OTHER = 99;
        public const int PEG_REFRESH = 11;
        public const int CANCEL_NOT_BEST = 9;
        public const int CANCEL_ON_DISCONNECT = 100;
        public const int CANCEL_RESTING_SMP = 103;
        public const int CANCEL_FROM_CREDIT_VIOLATION = 104;
        public const int CANCEL_FROM_FIRMSOFT = 105;
        public const int CANCEL_FROM_RISK = 106;
        public const int CANCEL_AGGRESSING_SMP = 107;
        public const int CANCEL_FROM_MIN_LOT_SIZE = 108;
        public const int EXEC_RESTATEMENT_REASON_CANCEL_BY_SYSTEM = 109;
        public const int EXEC_RESTATEMENT_REASON_CANCEL_BY_PROXY = 110;
        public const int EXEC_RESTATEMENT_REASON_CANCEL_ORDER_EXPIRED = 111;
        public const int EXEC_RESTATEMENT_REASON_CANCEL_OUTSIDE_PRICE_LIMITS = 112;
        public const int EXEC_RESTATEMENT_REASON_CANCEL_SESSION_TRANSITION = 113;
        public const int EXEC_RESTATEMENT_REASON_CANCEL_AUCTION_DELETE = 114;
        public const int EXEC_RESTATEMENT_REASON_CANCEL_OTHER = 115;
        public const int ORDER_PASSING_REQUEST_ACCEPTED = 116;
        public const int ORDER_PASSING_REQUEST_REJECTED = 117;
        public const int EXEC_RESTATEMENT_REASON_UNSOLICITED_ORDER_RECOVERY = 9000;
        public const int EXEC_RESTATEMENT_REASON_TIMEOUT = 9001;
        public const int GT_RENEWAL_RESTATEMENT = 1;
    }


    /// <summary>
    /// BusinessRejectRefID Field
    /// </summary>/
    public sealed class BusinessRejectRefID : QuickFix.Fields.StringField
    {
        public BusinessRejectRefID()
            :base(Fields.CustomTags.BusinessRejectRefID) {}
        public BusinessRejectRefID(string val)
            :base(Fields.CustomTags.BusinessRejectRefID, val) {}

    }


    /// <summary>
    /// BusinessRejectReason Field
    /// </summary>/
    public sealed class BusinessRejectReason : QuickFix.Fields.IntField
    {
        public BusinessRejectReason()
            :base(Fields.CustomTags.BusinessRejectReason) {}
        public BusinessRejectReason(int val)
            :base(Fields.CustomTags.BusinessRejectReason, val) {}


        // Field Enumerations
        public const int OTHER = 0;
        public const int UNKNOWN_ID = 1;
        public const int UNKNOWN_SECURITY = 2;
        public const int UNSUPPORTED_MESSAGE_TYPE = 3;
        public const int APPLICATION_NOT_AVAILABLE = 4;
        public const int CONDITIONALLY_REQUIRED_FIELD_MISSING = 5;
        public const int NOT_AUTHORIZED = 6;
        public const int DELIVERTO_FIRM_NOT_AVAILABLE_AT_THIS_TIME = 7;
        public const int INVALID_PRICE_INCREMENT = 18;
        public const int UNKNOWN_MESSAGE_TYPE = 3;
        public const int UNKOWN_ID = 1;
    }


    /// <summary>
    /// GrossTradeAmt Field
    /// </summary>/
    public sealed class GrossTradeAmt : QuickFix.Fields.DecimalField
    {
        public GrossTradeAmt()
            :base(Fields.CustomTags.GrossTradeAmt) {}
        public GrossTradeAmt(Decimal val)
            :base(Fields.CustomTags.GrossTradeAmt, val) {}

    }


    /// <summary>
    /// NoContraBrokers Field
    /// </summary>/
    public sealed class NoContraBrokers : QuickFix.Fields.IntField
    {
        public NoContraBrokers()
            :base(Fields.CustomTags.NoContraBrokers) {}
        public NoContraBrokers(int val)
            :base(Fields.CustomTags.NoContraBrokers, val) {}

    }


    /// <summary>
    /// MaxMessageSize Field
    /// </summary>/
    public sealed class MaxMessageSize : QuickFix.Fields.IntField
    {
        public MaxMessageSize()
            :base(Fields.CustomTags.MaxMessageSize) {}
        public MaxMessageSize(int val)
            :base(Fields.CustomTags.MaxMessageSize, val) {}

    }


    /// <summary>
    /// NoMsgTypes Field
    /// </summary>/
    public sealed class NoMsgTypes : QuickFix.Fields.IntField
    {
        public NoMsgTypes()
            :base(Fields.CustomTags.NoMsgTypes) {}
        public NoMsgTypes(int val)
            :base(Fields.CustomTags.NoMsgTypes, val) {}

    }


    /// <summary>
    /// MsgDirection Field
    /// </summary>/
    public sealed class MsgDirection : QuickFix.Fields.CharField
    {
        public MsgDirection()
            :base(Fields.CustomTags.MsgDirection) {}
        public MsgDirection(char val)
            :base(Fields.CustomTags.MsgDirection, val) {}


        // Field Enumerations
        public const char RECEIVE = 'R';
        public const char SEND = 'S';
    }


    /// <summary>
    /// NoTradingSessions Field
    /// </summary>/
    public sealed class NoTradingSessions : QuickFix.Fields.IntField
    {
        public NoTradingSessions()
            :base(Fields.CustomTags.NoTradingSessions) {}
        public NoTradingSessions(int val)
            :base(Fields.CustomTags.NoTradingSessions, val) {}

    }


    /// <summary>
    /// TotalVolumeTraded Field
    /// </summary>/
    public sealed class TotalVolumeTraded : QuickFix.Fields.DecimalField
    {
        public TotalVolumeTraded()
            :base(Fields.CustomTags.TotalVolumeTraded) {}
        public TotalVolumeTraded(Decimal val)
            :base(Fields.CustomTags.TotalVolumeTraded, val) {}

    }


    /// <summary>
    /// DiscretionInst Field
    /// </summary>/
    public sealed class DiscretionInst : QuickFix.Fields.CharField
    {
        public DiscretionInst()
            :base(Fields.CustomTags.DiscretionInst) {}
        public DiscretionInst(char val)
            :base(Fields.CustomTags.DiscretionInst, val) {}


        // Field Enumerations
        public const char RELATED_TO_DISPLAYED_PRICE = '0';
        public const char RELATED_TO_MARKET_PRICE = '1';
        public const char RELATED_TO_PRIMARY_PRICE = '2';
        public const char RELATED_TO_LOCAL_PRIMARY_PRICE = '3';
        public const char RELATED_TO_MIDPOINT_PRICE = '4';
        public const char RELATED_TO_LAST_TRADE_PRICE = '5';
        public const char RELATED_TO_VWAP = '6';
        public const char AVERAGE_PRICE_GUARANTEE = '7';
    }


    /// <summary>
    /// DiscretionOffset Field
    /// </summary>/
    public sealed class DiscretionOffset : QuickFix.Fields.DecimalField
    {
        public DiscretionOffset()
            :base(Fields.CustomTags.DiscretionOffset) {}
        public DiscretionOffset(Decimal val)
            :base(Fields.CustomTags.DiscretionOffset, val) {}

    }


    /// <summary>
    /// BidID Field
    /// </summary>/
    public sealed class BidID : QuickFix.Fields.StringField
    {
        public BidID()
            :base(Fields.CustomTags.BidID) {}
        public BidID(string val)
            :base(Fields.CustomTags.BidID, val) {}

    }


    /// <summary>
    /// ClientBidID Field
    /// </summary>/
    public sealed class ClientBidID : QuickFix.Fields.StringField
    {
        public ClientBidID()
            :base(Fields.CustomTags.ClientBidID) {}
        public ClientBidID(string val)
            :base(Fields.CustomTags.ClientBidID, val) {}

    }


    /// <summary>
    /// ListName Field
    /// </summary>/
    public sealed class ListName : QuickFix.Fields.StringField
    {
        public ListName()
            :base(Fields.CustomTags.ListName) {}
        public ListName(string val)
            :base(Fields.CustomTags.ListName, val) {}

    }


    /// <summary>
    /// TotalNumSecurities Field
    /// </summary>/
    public sealed class TotalNumSecurities : QuickFix.Fields.IntField
    {
        public TotalNumSecurities()
            :base(Fields.CustomTags.TotalNumSecurities) {}
        public TotalNumSecurities(int val)
            :base(Fields.CustomTags.TotalNumSecurities, val) {}

    }


    /// <summary>
    /// BidType Field
    /// </summary>/
    public sealed class BidType : QuickFix.Fields.IntField
    {
        public BidType()
            :base(Fields.CustomTags.BidType) {}
        public BidType(int val)
            :base(Fields.CustomTags.BidType, val) {}


        // Field Enumerations
        public const int NON_DISCLOSED_STYLE = 1;
        public const int DISCLOSED_SYTLE = 2;
        public const int NO_BIDDING_PROCESS = 3;
        public const int DISCLOSED_STYLE = 2;
    }


    /// <summary>
    /// NumTickets Field
    /// </summary>/
    public sealed class NumTickets : QuickFix.Fields.IntField
    {
        public NumTickets()
            :base(Fields.CustomTags.NumTickets) {}
        public NumTickets(int val)
            :base(Fields.CustomTags.NumTickets, val) {}

    }


    /// <summary>
    /// SideValue1 Field
    /// </summary>/
    public sealed class SideValue1 : QuickFix.Fields.DecimalField
    {
        public SideValue1()
            :base(Fields.CustomTags.SideValue1) {}
        public SideValue1(Decimal val)
            :base(Fields.CustomTags.SideValue1, val) {}

    }


    /// <summary>
    /// SideValue2 Field
    /// </summary>/
    public sealed class SideValue2 : QuickFix.Fields.DecimalField
    {
        public SideValue2()
            :base(Fields.CustomTags.SideValue2) {}
        public SideValue2(Decimal val)
            :base(Fields.CustomTags.SideValue2, val) {}

    }


    /// <summary>
    /// NoBidDescriptors Field
    /// </summary>/
    public sealed class NoBidDescriptors : QuickFix.Fields.IntField
    {
        public NoBidDescriptors()
            :base(Fields.CustomTags.NoBidDescriptors) {}
        public NoBidDescriptors(int val)
            :base(Fields.CustomTags.NoBidDescriptors, val) {}

    }


    /// <summary>
    /// BidDescriptorType Field
    /// </summary>/
    public sealed class BidDescriptorType : QuickFix.Fields.IntField
    {
        public BidDescriptorType()
            :base(Fields.CustomTags.BidDescriptorType) {}
        public BidDescriptorType(int val)
            :base(Fields.CustomTags.BidDescriptorType, val) {}


        // Field Enumerations
        public const int SECTOR = 1;
        public const int COUNTRY = 2;
        public const int INDEX = 3;
    }


    /// <summary>
    /// BidDescriptor Field
    /// </summary>/
    public sealed class BidDescriptor : QuickFix.Fields.StringField
    {
        public BidDescriptor()
            :base(Fields.CustomTags.BidDescriptor) {}
        public BidDescriptor(string val)
            :base(Fields.CustomTags.BidDescriptor, val) {}

    }


    /// <summary>
    /// SideValueInd Field
    /// </summary>/
    public sealed class SideValueInd : QuickFix.Fields.IntField
    {
        public SideValueInd()
            :base(Fields.CustomTags.SideValueInd) {}
        public SideValueInd(int val)
            :base(Fields.CustomTags.SideValueInd, val) {}


        // Field Enumerations
        public const int SIDE_VALUE_1 = 1;
        public const int SIDE_VALUE_2 = 2;
        public const int SIDEVALUE1 = 1;
        public const int SIDEVALUE_2 = 2;
    }


    /// <summary>
    /// LiquidityPctLow Field
    /// </summary>/
    public sealed class LiquidityPctLow : QuickFix.Fields.DecimalField
    {
        public LiquidityPctLow()
            :base(Fields.CustomTags.LiquidityPctLow) {}
        public LiquidityPctLow(Decimal val)
            :base(Fields.CustomTags.LiquidityPctLow, val) {}

    }


    /// <summary>
    /// LiquidityPctHigh Field
    /// </summary>/
    public sealed class LiquidityPctHigh : QuickFix.Fields.DecimalField
    {
        public LiquidityPctHigh()
            :base(Fields.CustomTags.LiquidityPctHigh) {}
        public LiquidityPctHigh(Decimal val)
            :base(Fields.CustomTags.LiquidityPctHigh, val) {}

    }


    /// <summary>
    /// LiquidityValue Field
    /// </summary>/
    public sealed class LiquidityValue : QuickFix.Fields.DecimalField
    {
        public LiquidityValue()
            :base(Fields.CustomTags.LiquidityValue) {}
        public LiquidityValue(Decimal val)
            :base(Fields.CustomTags.LiquidityValue, val) {}

    }


    /// <summary>
    /// EFPTrackingError Field
    /// </summary>/
    public sealed class EFPTrackingError : QuickFix.Fields.DecimalField
    {
        public EFPTrackingError()
            :base(Fields.CustomTags.EFPTrackingError) {}
        public EFPTrackingError(Decimal val)
            :base(Fields.CustomTags.EFPTrackingError, val) {}

    }


    /// <summary>
    /// FairValue Field
    /// </summary>/
    public sealed class FairValue : QuickFix.Fields.DecimalField
    {
        public FairValue()
            :base(Fields.CustomTags.FairValue) {}
        public FairValue(Decimal val)
            :base(Fields.CustomTags.FairValue, val) {}

    }


    /// <summary>
    /// OutsideIndexPct Field
    /// </summary>/
    public sealed class OutsideIndexPct : QuickFix.Fields.DecimalField
    {
        public OutsideIndexPct()
            :base(Fields.CustomTags.OutsideIndexPct) {}
        public OutsideIndexPct(Decimal val)
            :base(Fields.CustomTags.OutsideIndexPct, val) {}

    }


    /// <summary>
    /// ValueOfFutures Field
    /// </summary>/
    public sealed class ValueOfFutures : QuickFix.Fields.DecimalField
    {
        public ValueOfFutures()
            :base(Fields.CustomTags.ValueOfFutures) {}
        public ValueOfFutures(Decimal val)
            :base(Fields.CustomTags.ValueOfFutures, val) {}

    }


    /// <summary>
    /// LiquidityIndType Field
    /// </summary>/
    public sealed class LiquidityIndType : QuickFix.Fields.IntField
    {
        public LiquidityIndType()
            :base(Fields.CustomTags.LiquidityIndType) {}
        public LiquidityIndType(int val)
            :base(Fields.CustomTags.LiquidityIndType, val) {}


        // Field Enumerations
        public const int VAL_5_DAY_MOVING_AVERAGE = 1;
        public const int VAL_20_DAY_MOVING_AVERAGE = 2;
        public const int NORMAL_MARKET_SIZE = 3;
        public const int OTHER = 4;
        public const int FIVEDAY_MOVING_AVERAGE = 1;
        public const int TWENTYDAY_MOVING_AVERAGE = 2;
    }


    /// <summary>
    /// WtAverageLiquidity Field
    /// </summary>/
    public sealed class WtAverageLiquidity : QuickFix.Fields.DecimalField
    {
        public WtAverageLiquidity()
            :base(Fields.CustomTags.WtAverageLiquidity) {}
        public WtAverageLiquidity(Decimal val)
            :base(Fields.CustomTags.WtAverageLiquidity, val) {}

    }


    /// <summary>
    /// ExchangeForPhysical Field
    /// </summary>/
    public sealed class ExchangeForPhysical : QuickFix.Fields.BooleanField
    {
        public ExchangeForPhysical()
            :base(Fields.CustomTags.ExchangeForPhysical) {}
        public ExchangeForPhysical(Boolean val)
            :base(Fields.CustomTags.ExchangeForPhysical, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean TRUE = true;
        public const Boolean FALSE = false;
    }


    /// <summary>
    /// OutMainCntryUIndex Field
    /// </summary>/
    public sealed class OutMainCntryUIndex : QuickFix.Fields.DecimalField
    {
        public OutMainCntryUIndex()
            :base(Fields.CustomTags.OutMainCntryUIndex) {}
        public OutMainCntryUIndex(Decimal val)
            :base(Fields.CustomTags.OutMainCntryUIndex, val) {}

    }


    /// <summary>
    /// CrossPercent Field
    /// </summary>/
    public sealed class CrossPercent : QuickFix.Fields.DecimalField
    {
        public CrossPercent()
            :base(Fields.CustomTags.CrossPercent) {}
        public CrossPercent(Decimal val)
            :base(Fields.CustomTags.CrossPercent, val) {}

    }


    /// <summary>
    /// ProgRptReqs Field
    /// </summary>/
    public sealed class ProgRptReqs : QuickFix.Fields.IntField
    {
        public ProgRptReqs()
            :base(Fields.CustomTags.ProgRptReqs) {}
        public ProgRptReqs(int val)
            :base(Fields.CustomTags.ProgRptReqs, val) {}


        // Field Enumerations
        public const int BUY_SIDE_EXPLICITLY_REQUESTS_STATUS_USING_STATUE_REQUEST = 1;
        public const int SELL_SIDE_PERIODICALLY_SENDS_STATUS_USING_LIST_STATUS_PERIOD_OPTIONALLY_SPECIFIED_IN_PROGRESSPERIOD = 2;
        public const int REAL_TIME_EXECUTION_REPORTS = 3;
        public const int BUYSIDE_EXPLICITLY_REQUESTS_STATUS_USING_STATUSREQUEST = 1;
        public const int SELLSIDE_PERIODICALLY_SENDS_STATUS_USING_LISTSTATUS = 2;
    }


    /// <summary>
    /// ProgPeriodInterval Field
    /// </summary>/
    public sealed class ProgPeriodInterval : QuickFix.Fields.IntField
    {
        public ProgPeriodInterval()
            :base(Fields.CustomTags.ProgPeriodInterval) {}
        public ProgPeriodInterval(int val)
            :base(Fields.CustomTags.ProgPeriodInterval, val) {}

    }


    /// <summary>
    /// IncTaxInd Field
    /// </summary>/
    public sealed class IncTaxInd : QuickFix.Fields.IntField
    {
        public IncTaxInd()
            :base(Fields.CustomTags.IncTaxInd) {}
        public IncTaxInd(int val)
            :base(Fields.CustomTags.IncTaxInd, val) {}


        // Field Enumerations
        public const int NET = 1;
        public const int GROSS = 2;
    }


    /// <summary>
    /// NumBidders Field
    /// </summary>/
    public sealed class NumBidders : QuickFix.Fields.IntField
    {
        public NumBidders()
            :base(Fields.CustomTags.NumBidders) {}
        public NumBidders(int val)
            :base(Fields.CustomTags.NumBidders, val) {}

    }


    /// <summary>
    /// TradeType Field
    /// </summary>/
    public sealed class TradeType : QuickFix.Fields.CharField
    {
        public TradeType()
            :base(Fields.CustomTags.TradeType) {}
        public TradeType(char val)
            :base(Fields.CustomTags.TradeType, val) {}

    }


    /// <summary>
    /// BasisPxType Field
    /// </summary>/
    public sealed class BasisPxType : QuickFix.Fields.CharField
    {
        public BasisPxType()
            :base(Fields.CustomTags.BasisPxType) {}
        public BasisPxType(char val)
            :base(Fields.CustomTags.BasisPxType, val) {}


        // Field Enumerations
        public const char CLOSING_PRICE_AT_MORNINGN_SESSION = '2';
        public const char CLOSING_PRICE = '3';
        public const char CURRENT_PRICE = '4';
        public const char SQ = '5';
        public const char VWAP_THROUGH_A_DAY = '6';
        public const char VWAP_THROUGH_A_MORNING_SESSION = '7';
        public const char VWAP_THROUGH_AN_AFTERNOON_SESSION = '8';
        public const char VWAP_THROUGH_A_DAY_EXCEPT_YORI = '9';
        public const char VWAP_THROUGH_A_MORNING_SESSION_EXCEPT_YORI = 'A';
        public const char VWAP_THROUGH_AN_AFTERNOON_SESSION_EXCEPT_YORI = 'B';
        public const char STRIKE = 'C';
        public const char OPEN = 'D';
        public const char OTHERS = 'Z';
        public const char CLOSING_PRICE_AT_MORNING_SESSION = '2';
    }


    /// <summary>
    /// NoBidComponents Field
    /// </summary>/
    public sealed class NoBidComponents : QuickFix.Fields.IntField
    {
        public NoBidComponents()
            :base(Fields.CustomTags.NoBidComponents) {}
        public NoBidComponents(int val)
            :base(Fields.CustomTags.NoBidComponents, val) {}

    }


    /// <summary>
    /// Country Field
    /// </summary>/
    public sealed class Country : QuickFix.Fields.StringField
    {
        public Country()
            :base(Fields.CustomTags.Country) {}
        public Country(string val)
            :base(Fields.CustomTags.Country, val) {}

    }


    /// <summary>
    /// TotNoStrikes Field
    /// </summary>/
    public sealed class TotNoStrikes : QuickFix.Fields.IntField
    {
        public TotNoStrikes()
            :base(Fields.CustomTags.TotNoStrikes) {}
        public TotNoStrikes(int val)
            :base(Fields.CustomTags.TotNoStrikes, val) {}

    }


    /// <summary>
    /// PriceType Field
    /// </summary>/
    public sealed class PriceType : QuickFix.Fields.IntField
    {
        public PriceType()
            :base(Fields.CustomTags.PriceType) {}
        public PriceType(int val)
            :base(Fields.CustomTags.PriceType, val) {}


        // Field Enumerations
        public const int PERCENTAGE = 1;
        public const int FIXED_CABINET_TRADE_PRICE = 10;
        public const int VARIABLE_CABINET_TRADE_PRICE = 11;
        public const int PER_UNIT = 2;
        public const int FIXED_AMOUNT = 3;
        public const int DISCOUNT = 4;
        public const int PREMIUM = 5;
        public const int SPREAD = 6;
        public const int TED_PRICE = 7;
        public const int TED_YIELD = 8;
        public const int YIELD = 9;
        public const int PRODUCT_TICKS_IN_HALFS = 13;
        public const int PRODUCT_TICKS_IN_FOURTHS = 14;
        public const int PRODUCT_TICKS_IN_EIGHTS = 15;
        public const int PRODUCT_TICKS_IN_SIXTEENTHS = 16;
        public const int PRODUCT_TICKS_IN_THIRTY_SECONDS = 17;
        public const int PRODUCT_TICKS_IN_SIXTY_FORTHS = 18;
        public const int PRODUCT_TICKS_IN_ONE_TWENTY_EIGHTS = 19;
        public const int PER_SHARE = 2;
        public const int BASIS_POINTS_RELATIVE_TO_BENCHMARK = 6;
    }


    /// <summary>
    /// DayOrderQty Field
    /// </summary>/
    public sealed class DayOrderQty : QuickFix.Fields.DecimalField
    {
        public DayOrderQty()
            :base(Fields.CustomTags.DayOrderQty) {}
        public DayOrderQty(Decimal val)
            :base(Fields.CustomTags.DayOrderQty, val) {}

    }


    /// <summary>
    /// DayCumQty Field
    /// </summary>/
    public sealed class DayCumQty : QuickFix.Fields.DecimalField
    {
        public DayCumQty()
            :base(Fields.CustomTags.DayCumQty) {}
        public DayCumQty(Decimal val)
            :base(Fields.CustomTags.DayCumQty, val) {}

    }


    /// <summary>
    /// DayAvgPx Field
    /// </summary>/
    public sealed class DayAvgPx : QuickFix.Fields.DecimalField
    {
        public DayAvgPx()
            :base(Fields.CustomTags.DayAvgPx) {}
        public DayAvgPx(Decimal val)
            :base(Fields.CustomTags.DayAvgPx, val) {}

    }


    /// <summary>
    /// GTBookingInst Field
    /// </summary>/
    public sealed class GTBookingInst : QuickFix.Fields.IntField
    {
        public GTBookingInst()
            :base(Fields.CustomTags.GTBookingInst) {}
        public GTBookingInst(int val)
            :base(Fields.CustomTags.GTBookingInst, val) {}


        // Field Enumerations
        public const int BOOK_OUT_ALL_TRADES_ON_DAY_OF_EXECUTION = 0;
        public const int ACCUMULATE_EXECTUIONS_UNTIL_FORDER_IS_FILLED_OR_EXPIRES = 1;
        public const int ACCUMULATE_UNTIL_VERBALLLY_NOTIFIED_OTHERWISE = 2;
        public const int ACCUMULATE_EXECUTIONS_UNTIL_ORDER_IS_FILLED_OR_EXPIRES = 1;
        public const int ACCUMULATE_UNTIL_VERBALLY_NOTIFIED_OTHERWISE = 2;
    }


    /// <summary>
    /// NoStrikes Field
    /// </summary>/
    public sealed class NoStrikes : QuickFix.Fields.IntField
    {
        public NoStrikes()
            :base(Fields.CustomTags.NoStrikes) {}
        public NoStrikes(int val)
            :base(Fields.CustomTags.NoStrikes, val) {}

    }


    /// <summary>
    /// ListStatusType Field
    /// </summary>/
    public sealed class ListStatusType : QuickFix.Fields.IntField
    {
        public ListStatusType()
            :base(Fields.CustomTags.ListStatusType) {}
        public ListStatusType(int val)
            :base(Fields.CustomTags.ListStatusType, val) {}


        // Field Enumerations
        public const int ACK = 1;
        public const int RESPONSE = 2;
        public const int TIMED = 3;
        public const int EXEC_STARTED = 4;
        public const int ALL_DONE = 5;
        public const int ALERT = 6;
        public const int EXECSTARTED = 4;
        public const int ALLDONE = 5;
    }


    /// <summary>
    /// NetGrossInd Field
    /// </summary>/
    public sealed class NetGrossInd : QuickFix.Fields.IntField
    {
        public NetGrossInd()
            :base(Fields.CustomTags.NetGrossInd) {}
        public NetGrossInd(int val)
            :base(Fields.CustomTags.NetGrossInd, val) {}


        // Field Enumerations
        public const int NET = 1;
        public const int GROSS = 2;
    }


    /// <summary>
    /// ListOrderStatus Field
    /// </summary>/
    public sealed class ListOrderStatus : QuickFix.Fields.IntField
    {
        public ListOrderStatus()
            :base(Fields.CustomTags.ListOrderStatus) {}
        public ListOrderStatus(int val)
            :base(Fields.CustomTags.ListOrderStatus, val) {}


        // Field Enumerations
        public const int IN_BIDDING_PROCESS = 1;
        public const int RECEIVED_FOR_EXECUTION = 2;
        public const int EXECUTING = 3;
        public const int CANCELLING = 4;
        public const int ALERT = 5;
        public const int ALL_DONE = 6;
        public const int REJECT = 7;
        public const int INBIDDINGPROCESS = 1;
        public const int RECEIVEDFOREXECUTION = 2;
        public const int CANCELING = 4;
    }


    /// <summary>
    /// ExpireDate Field
    /// </summary>/
    public sealed class ExpireDate : QuickFix.Fields.StringField
    {
        public ExpireDate()
            :base(Fields.CustomTags.ExpireDate) {}
        public ExpireDate(string val)
            :base(Fields.CustomTags.ExpireDate, val) {}

    }


    /// <summary>
    /// ListExecInstType Field
    /// </summary>/
    public sealed class ListExecInstType : QuickFix.Fields.CharField
    {
        public ListExecInstType()
            :base(Fields.CustomTags.ListExecInstType) {}
        public ListExecInstType(char val)
            :base(Fields.CustomTags.ListExecInstType, val) {}


        // Field Enumerations
        public const char IMMEDIATE = '1';
        public const char WAIT_FOR_EXECUT_INSTRUCTION = '2';
        public const char EXCHANGE_SWITCH_CIV_ORDER_3 = '3';
        public const char EXCHANGE_SWITCH_CIV_ORDER_4 = '4';
        public const char EXCHANGE_SWITCH_CIV_ORDER_5 = '5';
        public const char WAIT_FOR_EXECUTE_INSTRUCTION = '2';
        public const char EXCHANGE_SWITCH_CIV_ORDER_SELL_DRIVEN = '3';
        public const char EXCHANGE_SWITCH_CIV_ORDER_BUY_DRIVEN_CASH_TOP_UP = '4';
        public const char EXCHANGE_SWITCH_CIV_ORDER_BUY_DRIVEN_CASH_WITHDRAW = '5';
    }


    /// <summary>
    /// CxlRejResponseTo Field
    /// </summary>/
    public sealed class CxlRejResponseTo : QuickFix.Fields.CharField
    {
        public CxlRejResponseTo()
            :base(Fields.CustomTags.CxlRejResponseTo) {}
        public CxlRejResponseTo(char val)
            :base(Fields.CustomTags.CxlRejResponseTo, val) {}


        // Field Enumerations
        public const char ORDER_CANCEL_REQUEST = '1';
        public const char ORDER_CANCEL_REPLACE_REQUEST = '2';
        public const char QUOTE_CANCEL = '3';
        public const char QUOTE_REPLACE = '4';
    }


    /// <summary>
    /// UnderlyingCouponRate Field
    /// </summary>/
    public sealed class UnderlyingCouponRate : QuickFix.Fields.DecimalField
    {
        public UnderlyingCouponRate()
            :base(Fields.CustomTags.UnderlyingCouponRate) {}
        public UnderlyingCouponRate(Decimal val)
            :base(Fields.CustomTags.UnderlyingCouponRate, val) {}

    }


    /// <summary>
    /// UnderlyingContractMultiplier Field
    /// </summary>/
    public sealed class UnderlyingContractMultiplier : QuickFix.Fields.DecimalField
    {
        public UnderlyingContractMultiplier()
            :base(Fields.CustomTags.UnderlyingContractMultiplier) {}
        public UnderlyingContractMultiplier(Decimal val)
            :base(Fields.CustomTags.UnderlyingContractMultiplier, val) {}

    }


    /// <summary>
    /// ContraTradeQty Field
    /// </summary>/
    public sealed class ContraTradeQty : QuickFix.Fields.DecimalField
    {
        public ContraTradeQty()
            :base(Fields.CustomTags.ContraTradeQty) {}
        public ContraTradeQty(Decimal val)
            :base(Fields.CustomTags.ContraTradeQty, val) {}

    }


    /// <summary>
    /// ContraTradeTime Field
    /// </summary>/
    public sealed class ContraTradeTime : QuickFix.Fields.DateTimeField
    {
        public ContraTradeTime()
            :base(Fields.CustomTags.ContraTradeTime) {}
        public ContraTradeTime(DateTime val)
            :base(Fields.CustomTags.ContraTradeTime, val) {}
        public ContraTradeTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.ContraTradeTime, val, showMilliseconds) {}
		public ContraTradeTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.ContraTradeTime, val, precision) {}

    }


    /// <summary>
    /// ClearingFirm Field
    /// </summary>/
    public sealed class ClearingFirm : QuickFix.Fields.StringField
    {
        public ClearingFirm()
            :base(Fields.CustomTags.ClearingFirm) {}
        public ClearingFirm(string val)
            :base(Fields.CustomTags.ClearingFirm, val) {}

    }


    /// <summary>
    /// ClearingAccount Field
    /// </summary>/
    public sealed class ClearingAccount : QuickFix.Fields.StringField
    {
        public ClearingAccount()
            :base(Fields.CustomTags.ClearingAccount) {}
        public ClearingAccount(string val)
            :base(Fields.CustomTags.ClearingAccount, val) {}

    }


    /// <summary>
    /// LiquidityNumSecurities Field
    /// </summary>/
    public sealed class LiquidityNumSecurities : QuickFix.Fields.IntField
    {
        public LiquidityNumSecurities()
            :base(Fields.CustomTags.LiquidityNumSecurities) {}
        public LiquidityNumSecurities(int val)
            :base(Fields.CustomTags.LiquidityNumSecurities, val) {}

    }


    /// <summary>
    /// MultiLegReportingType Field
    /// </summary>/
    public sealed class MultiLegReportingType : QuickFix.Fields.CharField
    {
        public MultiLegReportingType()
            :base(Fields.CustomTags.MultiLegReportingType) {}
        public MultiLegReportingType(char val)
            :base(Fields.CustomTags.MultiLegReportingType, val) {}


        // Field Enumerations
        public const char SINGLE_SECURITY = '1';
        public const char INDIVIDUAL_LEG_OF_A_MULTI_LEG_SECURITY = '2';
        public const char MULTI_LEG_SECURITY = '3';
        public const char INDIVIDUAL_LEG_OF_A_MULTILEG_SECURITY = '2';
    }


    /// <summary>
    /// StrikeTime Field
    /// </summary>/
    public sealed class StrikeTime : QuickFix.Fields.DateTimeField
    {
        public StrikeTime()
            :base(Fields.CustomTags.StrikeTime) {}
        public StrikeTime(DateTime val)
            :base(Fields.CustomTags.StrikeTime, val) {}
        public StrikeTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.StrikeTime, val, showMilliseconds) {}
		public StrikeTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.StrikeTime, val, precision) {}

    }


    /// <summary>
    /// ListStatusText Field
    /// </summary>/
    public sealed class ListStatusText : QuickFix.Fields.StringField
    {
        public ListStatusText()
            :base(Fields.CustomTags.ListStatusText) {}
        public ListStatusText(string val)
            :base(Fields.CustomTags.ListStatusText, val) {}

    }


    /// <summary>
    /// EncodedListStatusTextLen Field
    /// </summary>/
    public sealed class EncodedListStatusTextLen : QuickFix.Fields.IntField
    {
        public EncodedListStatusTextLen()
            :base(Fields.CustomTags.EncodedListStatusTextLen) {}
        public EncodedListStatusTextLen(int val)
            :base(Fields.CustomTags.EncodedListStatusTextLen, val) {}

    }


    /// <summary>
    /// EncodedListStatusText Field
    /// </summary>/
    public sealed class EncodedListStatusText : QuickFix.Fields.StringField
    {
        public EncodedListStatusText()
            :base(Fields.CustomTags.EncodedListStatusText) {}
        public EncodedListStatusText(string val)
            :base(Fields.CustomTags.EncodedListStatusText, val) {}

    }


    /// <summary>
    /// SecurityIDSource Field
    /// </summary>/
    public sealed class SecurityIDSource : QuickFix.Fields.StringField
    {
        public SecurityIDSource()
            :base(Fields.CustomTags.SecurityIDSource) {}
        public SecurityIDSource(string val)
            :base(Fields.CustomTags.SecurityIDSource, val) {}


        // Field Enumerations
        public const string CUSIP = "1";
        public const string SEDOL = "2";
        public const string QUIK = "3";
        public const string ISIN_NUMBER = "4";
        public const string RIC_CODE = "5";
        public const string ISO_CURRENCY_CODE = "6";
        public const string ISO_COUNTRY_CODE = "7";
        public const string EXCHANGE_SYMBOL = "8";
        public const string CONSOLIDATED_TAPE_ASSOCIATION = "9";
        public const string BLOOMBERG_SYMBOL = "A";
        public const string WERTPAPIER = "B";
        public const string DUTCH = "C";
        public const string VALOREN = "D";
        public const string SICOVAM = "E";
        public const string BELGIAN = "F";
        public const string COMMON = "G";
        public const string CLEARING_HOUSE = "H";
        public const string ISDA_FPML_PRODUCT_SPECIFICATION = "I";
        public const string OPTION_PRICE_REPORTING_AUTHORITY = "J";
        public const string LETTER_OF_CREDIT = "L";
        public const string ISDA_FPML_PRODUCT_URL = "K";
        public const string MARKETPLACE_ASSIGNED_IDENTIFIER = "M";
    }


    /// <summary>
    /// IOIQty Field
    /// </summary>/
    public sealed class IOIQty : QuickFix.Fields.StringField
    {
        public IOIQty()
            :base(Fields.CustomTags.IOIQty) {}
        public IOIQty(string val)
            :base(Fields.CustomTags.IOIQty, val) {}


        // Field Enumerations
        public const string VAL_1000000000 = "0";
        public const string SMALL = "S";
        public const string MEDIUM = "M";
        public const string LARGE = "L";
        public const string UNDISCLOSED_QUANTITY = "U";
    }


    /// <summary>
    /// LastQty Field
    /// </summary>/
    public sealed class LastQty : QuickFix.Fields.DecimalField
    {
        public LastQty()
            :base(Fields.CustomTags.LastQty) {}
        public LastQty(Decimal val)
            :base(Fields.CustomTags.LastQty, val) {}

    }


    /// <summary>
    /// SendingDate Field
    /// </summary>/
    public sealed class SendingDate : QuickFix.Fields.StringField
    {
        public SendingDate()
            :base(Fields.CustomTags.SendingDate) {}
        public SendingDate(string val)
            :base(Fields.CustomTags.SendingDate, val) {}

    }


    /// <summary>
    /// Quantity Field
    /// </summary>/
    public sealed class Quantity : QuickFix.Fields.DecimalField
    {
        public Quantity()
            :base(Fields.CustomTags.Quantity) {}
        public Quantity(Decimal val)
            :base(Fields.CustomTags.Quantity, val) {}

    }


    /// <summary>
    /// PositionEffect Field
    /// </summary>/
    public sealed class PositionEffect : QuickFix.Fields.CharField
    {
        public PositionEffect()
            :base(Fields.CustomTags.PositionEffect) {}
        public PositionEffect(char val)
            :base(Fields.CustomTags.PositionEffect, val) {}


        // Field Enumerations
        public const char CLOSE = 'C';
        public const char FIFO = 'F';
        public const char OPEN = 'O';
        public const char ROLLED = 'R';
        public const char CLOSE_BUT_NOTIFY_ON_OPEN = 'N';
        public const char DEFAULT = 'D';
    }


    /// <summary>
    /// AllocQty Field
    /// </summary>/
    public sealed class AllocQty : QuickFix.Fields.DecimalField
    {
        public AllocQty()
            :base(Fields.CustomTags.AllocQty) {}
        public AllocQty(Decimal val)
            :base(Fields.CustomTags.AllocQty, val) {}

    }


    /// <summary>
    /// Spread Field
    /// </summary>/
    public sealed class Spread : QuickFix.Fields.DecimalField
    {
        public Spread()
            :base(Fields.CustomTags.Spread) {}
        public Spread(Decimal val)
            :base(Fields.CustomTags.Spread, val) {}

    }


    /// <summary>
    /// BenchmarkCurveCurrency Field
    /// </summary>/
    public sealed class BenchmarkCurveCurrency : QuickFix.Fields.StringField
    {
        public BenchmarkCurveCurrency()
            :base(Fields.CustomTags.BenchmarkCurveCurrency) {}
        public BenchmarkCurveCurrency(string val)
            :base(Fields.CustomTags.BenchmarkCurveCurrency, val) {}

    }


    /// <summary>
    /// BenchmarkCurveName Field
    /// </summary>/
    public sealed class BenchmarkCurveName : QuickFix.Fields.StringField
    {
        public BenchmarkCurveName()
            :base(Fields.CustomTags.BenchmarkCurveName) {}
        public BenchmarkCurveName(string val)
            :base(Fields.CustomTags.BenchmarkCurveName, val) {}


        // Field Enumerations
        public const string EONIA = "EONIA";
        public const string EUREPO = "EUREPO";
        public const string EURIBOR = "Euribor";
        public const string FUTURESWAP = "FutureSWAP";
        public const string LIBID = "LIBID";
        public const string LIBOR = "LIBOR";
        public const string MUNIAAA = "MuniAAA";
        public const string OTHER = "OTHER";
        public const string PFANDBRIEFE = "Pfandbriefe";
        public const string SONIA = "SONIA";
        public const string SWAP = "SWAP";
        public const string TREASURY = "Treasury";
    }


    /// <summary>
    /// BenchmarkCurvePoint Field
    /// </summary>/
    public sealed class BenchmarkCurvePoint : QuickFix.Fields.StringField
    {
        public BenchmarkCurvePoint()
            :base(Fields.CustomTags.BenchmarkCurvePoint) {}
        public BenchmarkCurvePoint(string val)
            :base(Fields.CustomTags.BenchmarkCurvePoint, val) {}

    }


    /// <summary>
    /// CouponPaymentDate Field
    /// </summary>/
    public sealed class CouponPaymentDate : QuickFix.Fields.StringField
    {
        public CouponPaymentDate()
            :base(Fields.CustomTags.CouponPaymentDate) {}
        public CouponPaymentDate(string val)
            :base(Fields.CustomTags.CouponPaymentDate, val) {}

    }


    /// <summary>
    /// IssueDate Field
    /// </summary>/
    public sealed class IssueDate : QuickFix.Fields.StringField
    {
        public IssueDate()
            :base(Fields.CustomTags.IssueDate) {}
        public IssueDate(string val)
            :base(Fields.CustomTags.IssueDate, val) {}

    }


    /// <summary>
    /// RepurchaseTerm Field
    /// </summary>/
    public sealed class RepurchaseTerm : QuickFix.Fields.IntField
    {
        public RepurchaseTerm()
            :base(Fields.CustomTags.RepurchaseTerm) {}
        public RepurchaseTerm(int val)
            :base(Fields.CustomTags.RepurchaseTerm, val) {}

    }


    /// <summary>
    /// RepurchaseRate Field
    /// </summary>/
    public sealed class RepurchaseRate : QuickFix.Fields.DecimalField
    {
        public RepurchaseRate()
            :base(Fields.CustomTags.RepurchaseRate) {}
        public RepurchaseRate(Decimal val)
            :base(Fields.CustomTags.RepurchaseRate, val) {}

    }


    /// <summary>
    /// Factor Field
    /// </summary>/
    public sealed class Factor : QuickFix.Fields.DecimalField
    {
        public Factor()
            :base(Fields.CustomTags.Factor) {}
        public Factor(Decimal val)
            :base(Fields.CustomTags.Factor, val) {}

    }


    /// <summary>
    /// TradeOriginationDate Field
    /// </summary>/
    public sealed class TradeOriginationDate : QuickFix.Fields.StringField
    {
        public TradeOriginationDate()
            :base(Fields.CustomTags.TradeOriginationDate) {}
        public TradeOriginationDate(string val)
            :base(Fields.CustomTags.TradeOriginationDate, val) {}

    }


    /// <summary>
    /// ExDate Field
    /// </summary>/
    public sealed class ExDate : QuickFix.Fields.StringField
    {
        public ExDate()
            :base(Fields.CustomTags.ExDate) {}
        public ExDate(string val)
            :base(Fields.CustomTags.ExDate, val) {}

    }


    /// <summary>
    /// NoStipulations Field
    /// </summary>/
    public sealed class NoStipulations : QuickFix.Fields.IntField
    {
        public NoStipulations()
            :base(Fields.CustomTags.NoStipulations) {}
        public NoStipulations(int val)
            :base(Fields.CustomTags.NoStipulations, val) {}

    }


    /// <summary>
    /// StipulationType Field
    /// </summary>/
    public sealed class StipulationType : QuickFix.Fields.StringField
    {
        public StipulationType()
            :base(Fields.CustomTags.StipulationType) {}
        public StipulationType(string val)
            :base(Fields.CustomTags.StipulationType, val) {}


        // Field Enumerations
        public const string ABSOLUTE_PREPAYMENT_SPEED = "ABS";
        public const string ALTERNATIVE_MINIMUM_TAX = "AMT";
        public const string AUTO_REINVESTMENT_AT_RATE_OR_BETTER = "AUTOREINV";
        public const string BANK_QUALIFIED = "BANKQUAL";
        public const string BARGAIN_CONDITIONS = "BGNCON";
        public const string COUPON_RANGE = "COUPON";
        public const string CONSTANT_PREPAYMENT_PENALTY = "CPP";
        public const string CONSTANT_PREPAYMENT_RATE = "CPR";
        public const string CONSTANT_PREPAYMENT_YIELD = "CPY";
        public const string ISO_CURRENCY_CODE = "CURRENCY";
        public const string CUSTOM_START_END_DATE = "CUSTOMDATE";
        public const string GEOGRAPHICS_AND_RANGE = "GEOG";
        public const string VALUATION_DISCOUNT = "HAIRCUT";
        public const string FINAL_CPR_OF_HOME_EQUITY_PREPAYMENT_CURVE = "HEP";
        public const string INSURED = "INSURED";
        public const string YEAR_OR_YEAR_MONTH_OF_ISSUE = "ISSUE";
        public const string ISSUERS_TICKER = "ISSUER";
        public const string ISSUE_SIZE_RANGE = "ISSUESIZE";
        public const string LOOKBACK_DAYS = "LOOKBACK";
        public const string EXPLICIT_LOT_IDENTIFIER = "LOT";
        public const string LOT_VARIANCE = "LOTVAR";
        public const string MATURITY_YEAR_AND_MONTH = "MAT";
        public const string MATURITY_RANGE = "MATURITY";
        public const string MAXIMUM_SUBSTITUTIONS = "MAXSUBS";
        public const string PERCENT_OF_MANUFACTURED_HOUSING_PREPAYMENT_CURVE = "MHP";
        public const string MINIMUM_DENOMINATION = "MINDNOM";
        public const string MINIMUM_INCREMENT = "MININCR";
        public const string MINIMUM_QUANTITY = "MINQTY";
        public const string MONTHLY_PREPAYMENT_RATE = "MPR";
        public const string PAYMENT_FREQUENCY_CALENDAR = "PAYFREQ";
        public const string NUMBER_OF_PIECES = "PIECES";
        public const string POOLS_MAXIMUM = "PMAX";
        public const string PERCENT_OF_PROSPECTUS_PREPAYMENT_CURVE = "PPC";
        public const string POOLS_PER_LOT = "PPL";
        public const string POOLS_PER_MILLION = "PPM";
        public const string POOLS_PER_TRADE = "PPT";
        public const string PRICE_RANGE = "PRICE";
        public const string PRICING_FREQUENCY = "PRICEFREQ";
        public const string PRODUCTION_YEAR = "PROD";
        public const string CALL_PROTECTION = "PROTECT";
        public const string PERCENT_OF_BMA_PREPAYMENT_CURVE = "PSA";
        public const string PURPOSE = "PURPOSE";
        public const string BENCHMARK_PRICE_SOURCE = "PXSOURCE";
        public const string RATING_SOURCE_AND_RANGE = "RATING";
        public const string TYPE_OF_REDEMPTION = "REDEMPTION";
        public const string RESTRICTED = "RESTRICTED";
        public const string MARKET_SECTOR = "SECTOR";
        public const string SECURITY_TYPE_INCLUDED_OR_EXCLUDED = "SECTYPE";
        public const string SINGLE_MONTHLY_MORTALITY = "SMM";
        public const string STRUCTURE = "STRUCT";
        public const string SUBSTITUTIONS_FREQUENCY = "SUBSFREQ";
        public const string SUBSTITUTIONS_LEFT = "SUBSLEFT";
        public const string FREEFORM_TEXT = "TEXT";
        public const string TRADE_VARIANCE = "TRDVAR";
        public const string WEIGHTED_AVERAGE_COUPON = "WAC";
        public const string WEIGHTED_AVERAGE_LIFE_COUPON = "WAL";
        public const string WEIGHTED_AVERAGE_LOAN_AGE = "WALA";
        public const string WEIGHTED_AVERAGE_MATURITY = "WAM";
        public const string WHOLE_POOL = "WHOLE";
        public const string YIELD_RANGE = "YIELD";
        public const string AVERAGE_FICO_SCORE = "AVFICO";
        public const string AVERAGE_LOAN_SIZE = "AVSIZE";
        public const string MAXIMUM_LOAN_BALANCE = "MAXBAL";
        public const string POOL_IDENTIFIER = "POOL";
        public const string TYPE_OF_ROLL_TRADE = "ROLLTYPE";
        public const string REFERENCE_TO_ROLLING_OR_CLOSING_TRADE = "REFTRADE";
        public const string PRINCIPAL_OF_ROLLING_OR_CLOSING_TRADE = "REFPRIN";
        public const string INTEREST_OF_ROLLING_OR_CLOSING_TRADE = "REFINT";
        public const string AVAILABLE_OFFER_QUANTITY_TO_BE_SHOWN_TO_THE_STREET = "AVAILQTY";
        public const string BROKERS_SALES_CREDIT = "BROKERCREDIT";
        public const string OFFER_PRICE_TO_BE_SHOWN_TO_INTERNAL_BROKERS = "INTERNALPX";
        public const string OFFER_QUANTITY_TO_BE_SHOWN_TO_INTERNAL_BROKERS = "INTERNALQTY";
        public const string THE_MINIMUM_RESIDUAL_OFFER_QUANTITY = "LEAVEQTY";
        public const string MAXIMUM_ORDER_SIZE = "MAXORDQTY";
        public const string ORDER_QUANTITY_INCREMENT = "ORDRINCR";
        public const string PRIMARY_OR_SECONDARY_MARKET_INDICATOR = "PRIMARY";
        public const string BROKER_SALES_CREDIT_OVERRIDE = "SALESCREDITOVR";
        public const string TRADERS_CREDIT = "TRADERCREDIT";
        public const string DISCOUNT_RATE = "DISCOUNT";
        public const string YIELD_TO_MATURITY = "YTM";
    }


    /// <summary>
    /// StipulationValue Field
    /// </summary>/
    public sealed class StipulationValue : QuickFix.Fields.StringField
    {
        public StipulationValue()
            :base(Fields.CustomTags.StipulationValue) {}
        public StipulationValue(string val)
            :base(Fields.CustomTags.StipulationValue, val) {}

    }


    /// <summary>
    /// YieldType Field
    /// </summary>/
    public sealed class YieldType : QuickFix.Fields.StringField
    {
        public YieldType()
            :base(Fields.CustomTags.YieldType) {}
        public YieldType(string val)
            :base(Fields.CustomTags.YieldType, val) {}


        // Field Enumerations
        public const string AFTER_TAX_YIELD = "AFTERTAX";
        public const string ANNUAL_YIELD = "ANNUAL";
        public const string YIELD_AT_ISSUE = "ATISSUE";
        public const string YIELD_TO_AVG_MATURITY = "AVGMATURITY";
        public const string BOOK_YIELD = "BOOK";
        public const string YIELD_TO_NEXT_CALL = "CALL";
        public const string YIELD_CHANGE_SINCE_CLOSE = "CHANGE";
        public const string CLOSING_YIELD = "CLOSE";
        public const string COMPOUND_YIELD = "COMPOUND";
        public const string CURRENT_YIELD = "CURRENT";
        public const string GVNT_EQUIVALENT_YIELD = "GOVTEQUIV";
        public const string TRUE_GROSS_YIELD = "GROSS";
        public const string YIELD_WITH_INFLATION_ASSUMPTION = "INFLATION";
        public const string INVERSE_FLOATER_BOND_YIELD = "INVERSEFLOATER";
        public const string MOST_RECENT_CLOSING_YIELD = "LASTCLOSE";
        public const string CLOSING_YIELD_MOST_RECENT_MONTH = "LASTMONTH";
        public const string CLOSING_YIELD_MOST_RECENT_QUARTER = "LASTQUARTER";
        public const string CLOSING_YIELD_MOST_RECENT_YEAR = "LASTYEAR";
        public const string YIELD_TO_LONGEST_AVERAGE_LIFE = "LONGAVGLIFE";
        public const string MARK_TO_MARKET_YIELD = "MARK";
        public const string YIELD_TO_MATURITY = "MATURITY";
        public const string YIELD_TO_NEXT_REFUND = "NEXTREFUND";
        public const string OPEN_AVERAGE_YIELD = "OPENAVG";
        public const string PREVIOUS_CLOSE_YIELD = "PREVCLOSE";
        public const string PROCEEDS_YIELD = "PROCEEDS";
        public const string YIELD_TO_NEXT_PUT = "PUT";
        public const string SEMI_ANNUAL_YIELD = "SEMIANNUAL";
        public const string YIELD_TO_SHORTEST_AVERAGE_LIFE = "SHORTAVGLIFE";
        public const string SIMPLE_YIELD = "SIMPLE";
        public const string TAX_EQUIVALENT_YIELD = "TAXEQUIV";
        public const string YIELD_TO_TENDER_DATE = "TENDER";
        public const string TRUE_YIELD = "TRUE";
        public const string YIELD_VALUE_OF_1_32 = "VALUE1_32";
        public const string YIELD_TO_WORST = "WORST";
        public const string YIELD_TO_AVERAGE_LIFE = "AVGLIFE";
        public const string YIELD_TO_AVERAGE_MATURITY = "AVGMATURITY";
        public const string GOVERNMENT_EQUIVALENT_YIELD = "GOVTEQUIV";
        public const string YIELD_TO_LONGEST_AVERAGE = "LONGEST";
        public const string YIELD_TO_SHORTEST_AVERAGE = "SHORTEST";
        public const string YIELD_TO_WORST_CONVENTION = "WORST";
    }


    /// <summary>
    /// Yield Field
    /// </summary>/
    public sealed class Yield : QuickFix.Fields.DecimalField
    {
        public Yield()
            :base(Fields.CustomTags.Yield) {}
        public Yield(Decimal val)
            :base(Fields.CustomTags.Yield, val) {}

    }


    /// <summary>
    /// TotalTakedown Field
    /// </summary>/
    public sealed class TotalTakedown : QuickFix.Fields.DecimalField
    {
        public TotalTakedown()
            :base(Fields.CustomTags.TotalTakedown) {}
        public TotalTakedown(Decimal val)
            :base(Fields.CustomTags.TotalTakedown, val) {}

    }


    /// <summary>
    /// Concession Field
    /// </summary>/
    public sealed class Concession : QuickFix.Fields.DecimalField
    {
        public Concession()
            :base(Fields.CustomTags.Concession) {}
        public Concession(Decimal val)
            :base(Fields.CustomTags.Concession, val) {}

    }


    /// <summary>
    /// RepoCollateralSecurityType Field
    /// </summary>/
    public sealed class RepoCollateralSecurityType : QuickFix.Fields.IntField
    {
        public RepoCollateralSecurityType()
            :base(Fields.CustomTags.RepoCollateralSecurityType) {}
        public RepoCollateralSecurityType(int val)
            :base(Fields.CustomTags.RepoCollateralSecurityType, val) {}

    }


    /// <summary>
    /// RedemptionDate Field
    /// </summary>/
    public sealed class RedemptionDate : QuickFix.Fields.StringField
    {
        public RedemptionDate()
            :base(Fields.CustomTags.RedemptionDate) {}
        public RedemptionDate(string val)
            :base(Fields.CustomTags.RedemptionDate, val) {}

    }


    /// <summary>
    /// UnderlyingCouponPaymentDate Field
    /// </summary>/
    public sealed class UnderlyingCouponPaymentDate : QuickFix.Fields.StringField
    {
        public UnderlyingCouponPaymentDate()
            :base(Fields.CustomTags.UnderlyingCouponPaymentDate) {}
        public UnderlyingCouponPaymentDate(string val)
            :base(Fields.CustomTags.UnderlyingCouponPaymentDate, val) {}

    }


    /// <summary>
    /// UnderlyingIssueDate Field
    /// </summary>/
    public sealed class UnderlyingIssueDate : QuickFix.Fields.StringField
    {
        public UnderlyingIssueDate()
            :base(Fields.CustomTags.UnderlyingIssueDate) {}
        public UnderlyingIssueDate(string val)
            :base(Fields.CustomTags.UnderlyingIssueDate, val) {}

    }


    /// <summary>
    /// UnderlyingRepoCollateralSecurityType Field
    /// </summary>/
    public sealed class UnderlyingRepoCollateralSecurityType : QuickFix.Fields.IntField
    {
        public UnderlyingRepoCollateralSecurityType()
            :base(Fields.CustomTags.UnderlyingRepoCollateralSecurityType) {}
        public UnderlyingRepoCollateralSecurityType(int val)
            :base(Fields.CustomTags.UnderlyingRepoCollateralSecurityType, val) {}

    }


    /// <summary>
    /// UnderlyingRepurchaseTerm Field
    /// </summary>/
    public sealed class UnderlyingRepurchaseTerm : QuickFix.Fields.IntField
    {
        public UnderlyingRepurchaseTerm()
            :base(Fields.CustomTags.UnderlyingRepurchaseTerm) {}
        public UnderlyingRepurchaseTerm(int val)
            :base(Fields.CustomTags.UnderlyingRepurchaseTerm, val) {}

    }


    /// <summary>
    /// UnderlyingRepurchaseRate Field
    /// </summary>/
    public sealed class UnderlyingRepurchaseRate : QuickFix.Fields.DecimalField
    {
        public UnderlyingRepurchaseRate()
            :base(Fields.CustomTags.UnderlyingRepurchaseRate) {}
        public UnderlyingRepurchaseRate(Decimal val)
            :base(Fields.CustomTags.UnderlyingRepurchaseRate, val) {}

    }


    /// <summary>
    /// UnderlyingFactor Field
    /// </summary>/
    public sealed class UnderlyingFactor : QuickFix.Fields.DecimalField
    {
        public UnderlyingFactor()
            :base(Fields.CustomTags.UnderlyingFactor) {}
        public UnderlyingFactor(Decimal val)
            :base(Fields.CustomTags.UnderlyingFactor, val) {}

    }


    /// <summary>
    /// UnderlyingRedemptionDate Field
    /// </summary>/
    public sealed class UnderlyingRedemptionDate : QuickFix.Fields.StringField
    {
        public UnderlyingRedemptionDate()
            :base(Fields.CustomTags.UnderlyingRedemptionDate) {}
        public UnderlyingRedemptionDate(string val)
            :base(Fields.CustomTags.UnderlyingRedemptionDate, val) {}

    }


    /// <summary>
    /// LegCouponPaymentDate Field
    /// </summary>/
    public sealed class LegCouponPaymentDate : QuickFix.Fields.StringField
    {
        public LegCouponPaymentDate()
            :base(Fields.CustomTags.LegCouponPaymentDate) {}
        public LegCouponPaymentDate(string val)
            :base(Fields.CustomTags.LegCouponPaymentDate, val) {}

    }


    /// <summary>
    /// LegIssueDate Field
    /// </summary>/
    public sealed class LegIssueDate : QuickFix.Fields.StringField
    {
        public LegIssueDate()
            :base(Fields.CustomTags.LegIssueDate) {}
        public LegIssueDate(string val)
            :base(Fields.CustomTags.LegIssueDate, val) {}

    }


    /// <summary>
    /// LegRepoCollateralSecurityType Field
    /// </summary>/
    public sealed class LegRepoCollateralSecurityType : QuickFix.Fields.IntField
    {
        public LegRepoCollateralSecurityType()
            :base(Fields.CustomTags.LegRepoCollateralSecurityType) {}
        public LegRepoCollateralSecurityType(int val)
            :base(Fields.CustomTags.LegRepoCollateralSecurityType, val) {}

    }


    /// <summary>
    /// LegRepurchaseTerm Field
    /// </summary>/
    public sealed class LegRepurchaseTerm : QuickFix.Fields.IntField
    {
        public LegRepurchaseTerm()
            :base(Fields.CustomTags.LegRepurchaseTerm) {}
        public LegRepurchaseTerm(int val)
            :base(Fields.CustomTags.LegRepurchaseTerm, val) {}

    }


    /// <summary>
    /// LegRepurchaseRate Field
    /// </summary>/
    public sealed class LegRepurchaseRate : QuickFix.Fields.DecimalField
    {
        public LegRepurchaseRate()
            :base(Fields.CustomTags.LegRepurchaseRate) {}
        public LegRepurchaseRate(Decimal val)
            :base(Fields.CustomTags.LegRepurchaseRate, val) {}

    }


    /// <summary>
    /// LegFactor Field
    /// </summary>/
    public sealed class LegFactor : QuickFix.Fields.DecimalField
    {
        public LegFactor()
            :base(Fields.CustomTags.LegFactor) {}
        public LegFactor(Decimal val)
            :base(Fields.CustomTags.LegFactor, val) {}

    }


    /// <summary>
    /// LegRedemptionDate Field
    /// </summary>/
    public sealed class LegRedemptionDate : QuickFix.Fields.StringField
    {
        public LegRedemptionDate()
            :base(Fields.CustomTags.LegRedemptionDate) {}
        public LegRedemptionDate(string val)
            :base(Fields.CustomTags.LegRedemptionDate, val) {}

    }


    /// <summary>
    /// CreditRating Field
    /// </summary>/
    public sealed class CreditRating : QuickFix.Fields.StringField
    {
        public CreditRating()
            :base(Fields.CustomTags.CreditRating) {}
        public CreditRating(string val)
            :base(Fields.CustomTags.CreditRating, val) {}

    }


    /// <summary>
    /// UnderlyingCreditRating Field
    /// </summary>/
    public sealed class UnderlyingCreditRating : QuickFix.Fields.StringField
    {
        public UnderlyingCreditRating()
            :base(Fields.CustomTags.UnderlyingCreditRating) {}
        public UnderlyingCreditRating(string val)
            :base(Fields.CustomTags.UnderlyingCreditRating, val) {}

    }


    /// <summary>
    /// LegCreditRating Field
    /// </summary>/
    public sealed class LegCreditRating : QuickFix.Fields.StringField
    {
        public LegCreditRating()
            :base(Fields.CustomTags.LegCreditRating) {}
        public LegCreditRating(string val)
            :base(Fields.CustomTags.LegCreditRating, val) {}

    }


    /// <summary>
    /// TradedFlatSwitch Field
    /// </summary>/
    public sealed class TradedFlatSwitch : QuickFix.Fields.BooleanField
    {
        public TradedFlatSwitch()
            :base(Fields.CustomTags.TradedFlatSwitch) {}
        public TradedFlatSwitch(Boolean val)
            :base(Fields.CustomTags.TradedFlatSwitch, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// BasisFeatureDate Field
    /// </summary>/
    public sealed class BasisFeatureDate : QuickFix.Fields.StringField
    {
        public BasisFeatureDate()
            :base(Fields.CustomTags.BasisFeatureDate) {}
        public BasisFeatureDate(string val)
            :base(Fields.CustomTags.BasisFeatureDate, val) {}

    }


    /// <summary>
    /// BasisFeaturePrice Field
    /// </summary>/
    public sealed class BasisFeaturePrice : QuickFix.Fields.DecimalField
    {
        public BasisFeaturePrice()
            :base(Fields.CustomTags.BasisFeaturePrice) {}
        public BasisFeaturePrice(Decimal val)
            :base(Fields.CustomTags.BasisFeaturePrice, val) {}

    }


    /// <summary>
    /// QuoteStatus Field
    /// </summary>/
    public sealed class QuoteStatus : QuickFix.Fields.IntField
    {
        public QuoteStatus()
            :base(Fields.CustomTags.QuoteStatus) {}
        public QuoteStatus(int val)
            :base(Fields.CustomTags.QuoteStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int CANCEL_FOR_SYMBOL = 1;
        public const int PENDING = 10;
        public const int PASS = 11;
        public const int LOCKED_MARKET_WARNING = 12;
        public const int CROSS_MARKET_WARNING = 13;
        public const int CANCELED_DUE_TO_LOCK_MARKET = 14;
        public const int CANCELED_DUE_TO_CROSS_MARKET = 15;
        public const int CANCELED_FOR_SECURITY_TYPE = 2;
        public const int CANCELED_FOR_UNDERLYING = 3;
        public const int CANCELED_ALL = 4;
        public const int REJECTED = 5;
        public const int REMOVED_FROM_MARKET = 6;
        public const int EXPIRED = 7;
        public const int QUERY = 8;
        public const int QUOTE_NOT_FOUND = 9;
        public const int ACTIVE = 16;
        public const int CANCELED = 17;
        public const int UNSOLICITED_QUOTE_REPLENISHMENT = 18;
        public const int PENDING_END_TRADE = 19;
        public const int TOO_LATE_TO_END = 20;
        public const int CANCELED_FOR_SYMBOL = 1;
    }


    /// <summary>
    /// UnderlyingSecurityIDSource Field
    /// </summary>/
    public sealed class UnderlyingSecurityIDSource : QuickFix.Fields.StringField
    {
        public UnderlyingSecurityIDSource()
            :base(Fields.CustomTags.UnderlyingSecurityIDSource) {}
        public UnderlyingSecurityIDSource(string val)
            :base(Fields.CustomTags.UnderlyingSecurityIDSource, val) {}

    }


    /// <summary>
    /// PartyIDSource Field
    /// </summary>/
    public sealed class PartyIDSource : QuickFix.Fields.CharField
    {
        public PartyIDSource()
            :base(Fields.CustomTags.PartyIDSource) {}
        public PartyIDSource(char val)
            :base(Fields.CustomTags.PartyIDSource, val) {}


        // Field Enumerations
        public const char KOREAN_INVESTOR_ID = '1';
        public const char TAIWANESE_QUALIFIED_FOREIGN_INVESTOR_ID_QFII_FID = '2';
        public const char TAIWANESE_TRADING_ACCT = '3';
        public const char MALAYSIAN_CENTRAL_DEPOSITORY = '4';
        public const char CHINESE_INVESTOR_ID = '5';
        public const char UK_NATIONAL_INSURANCE_OR_PENSION_NUMBER = '6';
        public const char US_SOCIAL_SECURITY_NUMBER = '7';
        public const char US_EMPLOYER_OR_TAX_ID_NUMBER = '8';
        public const char AUSTRALIAN_BUSINESS_NUMBER = '9';
        public const char AUSTRALIAN_TAX_FILE_NUMBER = 'A';
        public const char BIC = 'B';
        public const char GENERALLY_ACCEPTED_MARKET_PARTICIPANT_IDENTIFIER = 'C';
        public const char PROPRIETARY = 'D';
        public const char ISO_COUNTRY_CODE = 'E';
        public const char SETTLEMENT_ENTITY_LOCATION = 'F';
        public const char MIC = 'G';
        public const char CSD_PARTICIPANT_MEMBER_CODE = 'H';
        public const char DIRECTED_BROKER_THREE_CHARACTER_ACRONYM_AS_DEFINED_IN_ISITC_ETC_BEST_PRACTICE_GUIDELINES_DOCUMENT = 'I';
        public const char SHORT_CODE_IDENTIFIER = 'P';
        public const char TAIWANESE_QUALIFIED_FOREIGN_INVESTOR_ID_QFII = '2';
        public const char TAIWANESE_TRADING_ACCOUNT = '3';
        public const char CHINESE_B_SHARE = '5';
        public const char US_EMPLOYER_IDENTIFICATION_NUMBER = '8';
    }


    /// <summary>
    /// PartyID Field
    /// </summary>/
    public sealed class PartyID : QuickFix.Fields.StringField
    {
        public PartyID()
            :base(Fields.CustomTags.PartyID) {}
        public PartyID(string val)
            :base(Fields.CustomTags.PartyID, val) {}

    }


    /// <summary>
    /// TotalVolumeTradedDate Field
    /// </summary>/
    public sealed class TotalVolumeTradedDate : QuickFix.Fields.DateOnlyField
    {
        public TotalVolumeTradedDate()
            :base(Fields.CustomTags.TotalVolumeTradedDate) {}
        public TotalVolumeTradedDate(DateTime val)
            :base(Fields.CustomTags.TotalVolumeTradedDate, val) {}

    }


    /// <summary>
    /// TotalVolumeTradedTime Field
    /// </summary>/
    public sealed class TotalVolumeTradedTime : QuickFix.Fields.TimeOnlyField
    {
        public TotalVolumeTradedTime()
            :base(Fields.CustomTags.TotalVolumeTradedTime) {}
        public TotalVolumeTradedTime(DateTime val)
            :base(Fields.CustomTags.TotalVolumeTradedTime, val) {}
        public TotalVolumeTradedTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TotalVolumeTradedTime, val, showMilliseconds) {}
		public TotalVolumeTradedTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TotalVolumeTradedTime, val, precision) {}

    }


    /// <summary>
    /// NetChgPrevDay Field
    /// </summary>/
    public sealed class NetChgPrevDay : QuickFix.Fields.DecimalField
    {
        public NetChgPrevDay()
            :base(Fields.CustomTags.NetChgPrevDay) {}
        public NetChgPrevDay(Decimal val)
            :base(Fields.CustomTags.NetChgPrevDay, val) {}

    }


    /// <summary>
    /// PartyRole Field
    /// </summary>/
    public sealed class PartyRole : QuickFix.Fields.IntField
    {
        public PartyRole()
            :base(Fields.CustomTags.PartyRole) {}
        public PartyRole(int val)
            :base(Fields.CustomTags.PartyRole, val) {}


        // Field Enumerations
        public const int EXECUTING_FIRM = 1;
        public const int SETTLEMENT_LOCATION = 10;
        public const int ORDER_ORIGINATION_TRADER = 11;
        public const int EXECUTING_TRADER = 12;
        public const int ORDER_ORIGINATION_FIRM = 13;
        public const int GIVEUP_CLEARING_FIRM = 14;
        public const int CORRESPONDANT_CLEARING_FIRM = 15;
        public const int EXECUTING_SYSTEM = 16;
        public const int CONTRA_FIRM = 17;
        public const int CONTRA_CLEARING_FIRM = 18;
        public const int SPONSORING_FIRM = 19;
        public const int BROKER_OF_CREDIT = 2;
        public const int UNDERLYING_CONTRA_FIRM = 20;
        public const int CLEARING_ORGANIZATION = 21;
        public const int EXCHANGE = 22;
        public const int CUSTOMER_ACCOUNT = 24;
        public const int CORRESPONDENT_CLEARING_ORGANIZATION = 25;
        public const int CORRESPONDENT_BROKER = 26;
        public const int BUYER_SELLER = 27;
        public const int CUSTODIAN = 28;
        public const int INTERMEDIARY = 29;
        public const int CLIENT_ID = 3;
        public const int AGENT = 30;
        public const int SUB_CUSTODIAN = 31;
        public const int BENEFICIARY = 32;
        public const int INTERESTED_PARTY = 33;
        public const int REGULATORY_BODY = 34;
        public const int LIQUIDITY_PROVIDER = 35;
        public const int ENTERING_TRADER = 36;
        public const int CONTRA_TRADER = 37;
        public const int POSITION_ACCOUNT = 38;
        public const int CLEARING_FIRM = 4;
        public const int INVESTOR_ID = 5;
        public const int INTRODUCING_FIRM = 6;
        public const int ENTERING_FIRM = 7;
        public const int LOCATE = 8;
        public const int FUND_MANAGER_CLIENT_ID = 9;
        public const int INTRODUCING_BROKER = 60;
        public const int CONTRA_POSITION_ACCOUNT = 41;
        public const int CONTRA_EXCHANGE = 42;
        public const int INTERNAL_CARRY_ACCOUNT = 43;
        public const int ORDER_ENTRY_OPERATOR_ID = 44;
        public const int SECONDARY_ACCOUNT_NUMBER = 45;
        public const int FOREIGN_FIRM = 46;
        public const int THIRD_PARTY_ALLOCATION_FIRM = 47;
        public const int CLAIMING_ACCOUNT = 48;
        public const int ASSET_MANAGER = 49;
        public const int PLEDGOR_ACCOUNT = 50;
        public const int PLEDGEE_ACCOUNT = 51;
        public const int LARGE_TRADER_REPORTABLE_ACCOUNT = 52;
        public const int TRADER_MNEMONIC = 53;
        public const int SENDER_LOCATION = 54;
        public const int SESSION_ID = 55;
        public const int ACCEPTABLE_COUNTERPARTY = 56;
        public const int UNACCEPTABLE_COUNTERPARTY = 57;
        public const int ENTERING_UNIT = 58;
        public const int EXECUTING_UNIT = 59;
        public const int CONTRA_INVESTOR_ID = 39;
        public const int TRANSFER_TO_FIRM = 40;
        public const int QUOTE_ORIGINATOR = 61;
        public const int REPORT_ORIGINATOR = 62;
        public const int SYSTEMATIC_INTERNALISER = 63;
        public const int MULTILATERAL_TRADING_FACILITY = 64;
        public const int REGULATED_MARKET = 65;
        public const int MARKET_MAKER = 66;
        public const int INVESTMENT_FIRM = 67;
        public const int HOST_COMPETENT_AUTHORITY = 68;
        public const int HOME_COMPETENT_AUTHORITY = 69;
        public const int COMPETENT_AUTHORITY_OF_THE_MOST_RELEVANT_MARKET_IN_TERMS_OF_LIQUIDITY = 70;
        public const int COMPETENT_AUTHORITY_OF_THE_TRANSACTION = 71;
        public const int REPORTING_INTERMEDIARY = 72;
        public const int EXECUTION_VENUE = 73;
        public const int MARKET_DATA_ENTRY_ORIGINATOR = 74;
        public const int LOCATION_ID = 75;
        public const int DESK_ID = 76;
        public const int MARKET_DATA_MARKET = 77;
        public const int ALLOCATION_ENTITY = 78;
        public const int PRIME_BROKER_PROVIDING_GENERAL_TRADE_SERVICES = 79;
        public const int STEP_OUT_FIRM = 80;
        public const int BROKERCLEARINGID = 81;
        public const int CENTRAL_REGISTRATION_DEPOSITORY = 82;
        public const int CLEARING_ACCOUNT = 83;
        public const int ACCEPTABLE_SETTLING_COUNTERPARTY = 84;
        public const int UNACCEPTABLE_SETTLING_COUNTERPARTY = 85;
        public const int FORIEGN_FIRM = 46;
        public const int INVESTMENT_DECISION_MAKER = 122;
        public const int ACCOUNT_CODE = 200;
        public const int TAKEUP_FIRM = 201;
        public const int CLEARING_INSTRUCTION = 202;
        public const int CUSTOMER_INFO = 203;
        public const int ALLOCATION_ENTITY_ID = 204;
        public const int ACCOUNT_TYPE = 205;
        public const int GIVEUP_FIRM = 206;
        public const int MIFID_ID = 207;
        public const int COMPOSITE_MIFID_ID = 208;
        public const int CTI_CODE = 209;
        public const int LMA_CLEARING_ACCOUNT = 210;
        public const int AUTHORIZED_TRADER_ID = 211;
        public const int FREQUENT_TRADER_ID = 212;
        public const int PARTY_ROLE_USER = 213;
        public const int PARTY_ROLE_MEMBER = 214;
        public const int PARTY_ROLE_TRADING_MEMBER = 215;
        public const int PARTY_ROLE_CLEARING_MEMBER = 216;
        public const int PARTY_ROLE_ACTING_USER = 217;
        public const int PARTY_ROLE_TRADER_ID = 218;
        public const int PARTY_ROLE_OWNER_TYPE = 219;
        public const int PARTY_ROLE_ROUTING_MEMBER_ID = 220;
        public const int GIVEUP_QUALIFIER = 221;
        public const int ALGO_STRATEGY_TYPE = 222;
    }


    /// <summary>
    /// NoPartyIDs Field
    /// </summary>/
    public sealed class NoPartyIDs : QuickFix.Fields.IntField
    {
        public NoPartyIDs()
            :base(Fields.CustomTags.NoPartyIDs) {}
        public NoPartyIDs(int val)
            :base(Fields.CustomTags.NoPartyIDs, val) {}

    }


    /// <summary>
    /// NoSecurityAltID Field
    /// </summary>/
    public sealed class NoSecurityAltID : QuickFix.Fields.IntField
    {
        public NoSecurityAltID()
            :base(Fields.CustomTags.NoSecurityAltID) {}
        public NoSecurityAltID(int val)
            :base(Fields.CustomTags.NoSecurityAltID, val) {}

    }


    /// <summary>
    /// SecurityAltID Field
    /// </summary>/
    public sealed class SecurityAltID : QuickFix.Fields.StringField
    {
        public SecurityAltID()
            :base(Fields.CustomTags.SecurityAltID) {}
        public SecurityAltID(string val)
            :base(Fields.CustomTags.SecurityAltID, val) {}

    }


    /// <summary>
    /// SecurityAltIDSource Field
    /// </summary>/
    public sealed class SecurityAltIDSource : QuickFix.Fields.StringField
    {
        public SecurityAltIDSource()
            :base(Fields.CustomTags.SecurityAltIDSource) {}
        public SecurityAltIDSource(string val)
            :base(Fields.CustomTags.SecurityAltIDSource, val) {}


        // Field Enumerations
        public const string ISIN_NUMBER = "4";
        public const string RIC_CODE = "5";
        public const string EXCHANGE_SECURITY_ID = "8";
        public const string TT_PRODUCT_FAMILY_ID = "92";
        public const string TT_Product_ID = "93";
        public const string ALT_SYMBOL = "94";
        public const string CLEARPORT = "95";
        public const string ALIAS = "97";
        public const string NAME = "98";
        public const string SECURITY_GROUP = "99";
        public const string EXCHANGE_TICKER = "91";
    }


    /// <summary>
    /// NoUnderlyingSecurityAltID Field
    /// </summary>/
    public sealed class NoUnderlyingSecurityAltID : QuickFix.Fields.IntField
    {
        public NoUnderlyingSecurityAltID()
            :base(Fields.CustomTags.NoUnderlyingSecurityAltID) {}
        public NoUnderlyingSecurityAltID(int val)
            :base(Fields.CustomTags.NoUnderlyingSecurityAltID, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityAltID Field
    /// </summary>/
    public sealed class UnderlyingSecurityAltID : QuickFix.Fields.StringField
    {
        public UnderlyingSecurityAltID()
            :base(Fields.CustomTags.UnderlyingSecurityAltID) {}
        public UnderlyingSecurityAltID(string val)
            :base(Fields.CustomTags.UnderlyingSecurityAltID, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityAltIDSource Field
    /// </summary>/
    public sealed class UnderlyingSecurityAltIDSource : QuickFix.Fields.StringField
    {
        public UnderlyingSecurityAltIDSource()
            :base(Fields.CustomTags.UnderlyingSecurityAltIDSource) {}
        public UnderlyingSecurityAltIDSource(string val)
            :base(Fields.CustomTags.UnderlyingSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// Product Field
    /// </summary>/
    public sealed class Product : QuickFix.Fields.IntField
    {
        public Product()
            :base(Fields.CustomTags.Product) {}
        public Product(int val)
            :base(Fields.CustomTags.Product, val) {}


        // Field Enumerations
        public const int AGENCY = 1;
        public const int MORTGAGE = 10;
        public const int MUNICIPAL = 11;
        public const int OTHER = 12;
        public const int FINANCING = 13;
        public const int COMMODITY = 2;
        public const int CORPORATE = 3;
        public const int CURRENCY = 4;
        public const int EQUITY = 5;
        public const int GOVERNMENT = 6;
        public const int INDEX = 7;
        public const int LOAN = 8;
        public const int MONEYMARKET = 9;
        public const int ENERGY = 14;
    }


    /// <summary>
    /// CFICode Field
    /// </summary>/
    public sealed class CFICode : QuickFix.Fields.StringField
    {
        public CFICode()
            :base(Fields.CustomTags.CFICode) {}
        public CFICode(string val)
            :base(Fields.CustomTags.CFICode, val) {}

    }


    /// <summary>
    /// UnderlyingProduct Field
    /// </summary>/
    public sealed class UnderlyingProduct : QuickFix.Fields.IntField
    {
        public UnderlyingProduct()
            :base(Fields.CustomTags.UnderlyingProduct) {}
        public UnderlyingProduct(int val)
            :base(Fields.CustomTags.UnderlyingProduct, val) {}

    }


    /// <summary>
    /// UnderlyingCFICode Field
    /// </summary>/
    public sealed class UnderlyingCFICode : QuickFix.Fields.StringField
    {
        public UnderlyingCFICode()
            :base(Fields.CustomTags.UnderlyingCFICode) {}
        public UnderlyingCFICode(string val)
            :base(Fields.CustomTags.UnderlyingCFICode, val) {}

    }


    /// <summary>
    /// TestMessageIndicator Field
    /// </summary>/
    public sealed class TestMessageIndicator : QuickFix.Fields.BooleanField
    {
        public TestMessageIndicator()
            :base(Fields.CustomTags.TestMessageIndicator) {}
        public TestMessageIndicator(Boolean val)
            :base(Fields.CustomTags.TestMessageIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// QuantityType Field
    /// </summary>/
    public sealed class QuantityType : QuickFix.Fields.IntField
    {
        public QuantityType()
            :base(Fields.CustomTags.QuantityType) {}
        public QuantityType(int val)
            :base(Fields.CustomTags.QuantityType, val) {}


        // Field Enumerations
        public const int SHARES = 1;
        public const int BONDS = 2;
        public const int CURRENTFACE = 3;
        public const int ORIGINALFACE = 4;
        public const int CURRENCY = 5;
        public const int CONTRACTS = 6;
        public const int OTHER = 7;
        public const int PAR = 8;
    }


    /// <summary>
    /// BookingRefID Field
    /// </summary>/
    public sealed class BookingRefID : QuickFix.Fields.StringField
    {
        public BookingRefID()
            :base(Fields.CustomTags.BookingRefID) {}
        public BookingRefID(string val)
            :base(Fields.CustomTags.BookingRefID, val) {}

    }


    /// <summary>
    /// IndividualAllocID Field
    /// </summary>/
    public sealed class IndividualAllocID : QuickFix.Fields.StringField
    {
        public IndividualAllocID()
            :base(Fields.CustomTags.IndividualAllocID) {}
        public IndividualAllocID(string val)
            :base(Fields.CustomTags.IndividualAllocID, val) {}

    }


    /// <summary>
    /// RoundingDirection Field
    /// </summary>/
    public sealed class RoundingDirection : QuickFix.Fields.CharField
    {
        public RoundingDirection()
            :base(Fields.CustomTags.RoundingDirection) {}
        public RoundingDirection(char val)
            :base(Fields.CustomTags.RoundingDirection, val) {}


        // Field Enumerations
        public const char ROUND_TO_NEAREST = '0';
        public const char ROUND_DOWN = '1';
        public const char ROUND_UP = '2';
    }


    /// <summary>
    /// RoundingModulus Field
    /// </summary>/
    public sealed class RoundingModulus : QuickFix.Fields.DecimalField
    {
        public RoundingModulus()
            :base(Fields.CustomTags.RoundingModulus) {}
        public RoundingModulus(Decimal val)
            :base(Fields.CustomTags.RoundingModulus, val) {}

    }


    /// <summary>
    /// CountryOfIssue Field
    /// </summary>/
    public sealed class CountryOfIssue : QuickFix.Fields.StringField
    {
        public CountryOfIssue()
            :base(Fields.CustomTags.CountryOfIssue) {}
        public CountryOfIssue(string val)
            :base(Fields.CustomTags.CountryOfIssue, val) {}

    }


    /// <summary>
    /// StateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class StateOrProvinceOfIssue : QuickFix.Fields.StringField
    {
        public StateOrProvinceOfIssue()
            :base(Fields.CustomTags.StateOrProvinceOfIssue) {}
        public StateOrProvinceOfIssue(string val)
            :base(Fields.CustomTags.StateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// LocaleOfIssue Field
    /// </summary>/
    public sealed class LocaleOfIssue : QuickFix.Fields.StringField
    {
        public LocaleOfIssue()
            :base(Fields.CustomTags.LocaleOfIssue) {}
        public LocaleOfIssue(string val)
            :base(Fields.CustomTags.LocaleOfIssue, val) {}

    }


    /// <summary>
    /// NoRegistDtls Field
    /// </summary>/
    public sealed class NoRegistDtls : QuickFix.Fields.IntField
    {
        public NoRegistDtls()
            :base(Fields.CustomTags.NoRegistDtls) {}
        public NoRegistDtls(int val)
            :base(Fields.CustomTags.NoRegistDtls, val) {}

    }


    /// <summary>
    /// MailingDtls Field
    /// </summary>/
    public sealed class MailingDtls : QuickFix.Fields.StringField
    {
        public MailingDtls()
            :base(Fields.CustomTags.MailingDtls) {}
        public MailingDtls(string val)
            :base(Fields.CustomTags.MailingDtls, val) {}

    }


    /// <summary>
    /// InvestorCountryOfResidence Field
    /// </summary>/
    public sealed class InvestorCountryOfResidence : QuickFix.Fields.StringField
    {
        public InvestorCountryOfResidence()
            :base(Fields.CustomTags.InvestorCountryOfResidence) {}
        public InvestorCountryOfResidence(string val)
            :base(Fields.CustomTags.InvestorCountryOfResidence, val) {}

    }


    /// <summary>
    /// PaymentRef Field
    /// </summary>/
    public sealed class PaymentRef : QuickFix.Fields.StringField
    {
        public PaymentRef()
            :base(Fields.CustomTags.PaymentRef) {}
        public PaymentRef(string val)
            :base(Fields.CustomTags.PaymentRef, val) {}

    }


    /// <summary>
    /// DistribPaymentMethod Field
    /// </summary>/
    public sealed class DistribPaymentMethod : QuickFix.Fields.IntField
    {
        public DistribPaymentMethod()
            :base(Fields.CustomTags.DistribPaymentMethod) {}
        public DistribPaymentMethod(int val)
            :base(Fields.CustomTags.DistribPaymentMethod, val) {}


        // Field Enumerations
        public const int CREST = 1;
        public const int BPAY = 10;
        public const int HIGH_VALUE_CLEARING_SYSTEM_HVACS = 11;
        public const int REINVEST_IN_FUND = 12;
        public const int NSCC = 2;
        public const int EUROCLEAR = 3;
        public const int CLEARSTREAM = 4;
        public const int CHEQUE = 5;
        public const int TELEGRAPHIC_TRANSFER = 6;
        public const int FED_WIRE = 7;
        public const int DIRECT_CREDIT = 8;
        public const int ACH_CREDIT = 9;
    }


    /// <summary>
    /// CashDistribCurr Field
    /// </summary>/
    public sealed class CashDistribCurr : QuickFix.Fields.StringField
    {
        public CashDistribCurr()
            :base(Fields.CustomTags.CashDistribCurr) {}
        public CashDistribCurr(string val)
            :base(Fields.CustomTags.CashDistribCurr, val) {}

    }


    /// <summary>
    /// CommCurrency Field
    /// </summary>/
    public sealed class CommCurrency : QuickFix.Fields.StringField
    {
        public CommCurrency()
            :base(Fields.CustomTags.CommCurrency) {}
        public CommCurrency(string val)
            :base(Fields.CustomTags.CommCurrency, val) {}

    }


    /// <summary>
    /// CancellationRights Field
    /// </summary>/
    public sealed class CancellationRights : QuickFix.Fields.CharField
    {
        public CancellationRights()
            :base(Fields.CustomTags.CancellationRights) {}
        public CancellationRights(char val)
            :base(Fields.CustomTags.CancellationRights, val) {}


        // Field Enumerations
        public const char NO_M = 'M';
        public const char NO_N = 'N';
        public const char NO_O = 'O';
        public const char YES = 'Y';
    }


    /// <summary>
    /// MoneyLaunderingStatus Field
    /// </summary>/
    public sealed class MoneyLaunderingStatus : QuickFix.Fields.CharField
    {
        public MoneyLaunderingStatus()
            :base(Fields.CustomTags.MoneyLaunderingStatus) {}
        public MoneyLaunderingStatus(char val)
            :base(Fields.CustomTags.MoneyLaunderingStatus, val) {}


        // Field Enumerations
        public const char EXEMPT_1 = '1';
        public const char EXEMPT_2 = '2';
        public const char EXEMPT_3 = '3';
        public const char NOT_CHECKED = 'N';
        public const char PASSED = 'Y';
        public const char EXEMPT_BELOW_THE_LIMIT = '1';
        public const char EXEMPT_CLIENT_MONEY_TYPE_EXEMPTION = '2';
        public const char EXEMPT_AUTHORISED_CREDIT_OR_FINANCIAL_INSTITUTION = '3';
    }


    /// <summary>
    /// MailingInst Field
    /// </summary>/
    public sealed class MailingInst : QuickFix.Fields.StringField
    {
        public MailingInst()
            :base(Fields.CustomTags.MailingInst) {}
        public MailingInst(string val)
            :base(Fields.CustomTags.MailingInst, val) {}

    }


    /// <summary>
    /// TransBkdTime Field
    /// </summary>/
    public sealed class TransBkdTime : QuickFix.Fields.DateTimeField
    {
        public TransBkdTime()
            :base(Fields.CustomTags.TransBkdTime) {}
        public TransBkdTime(DateTime val)
            :base(Fields.CustomTags.TransBkdTime, val) {}
        public TransBkdTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TransBkdTime, val, showMilliseconds) {}
		public TransBkdTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TransBkdTime, val, precision) {}

    }


    /// <summary>
    /// ExecPriceType Field
    /// </summary>/
    public sealed class ExecPriceType : QuickFix.Fields.CharField
    {
        public ExecPriceType()
            :base(Fields.CustomTags.ExecPriceType) {}
        public ExecPriceType(char val)
            :base(Fields.CustomTags.ExecPriceType, val) {}


        // Field Enumerations
        public const char BID_PRICE = 'B';
        public const char CREATION_PRICE = 'C';
        public const char CREATION_PRICE_PLUS_ADJUSTMENT_PERCENT = 'D';
        public const char CREATION_PRICE_PLUS_ADJUSTMENT_AMOUNT = 'E';
        public const char OFFER_PRICE = 'O';
        public const char OFFER_PRICE_MINUS_ADJUSTMENT_PERCENT = 'P';
        public const char OFFER_PRICE_MINUS_ADJUSTMENT_AMOUNT = 'Q';
        public const char SINGLE_PRICE = 'S';
    }


    /// <summary>
    /// ExecPriceAdjustment Field
    /// </summary>/
    public sealed class ExecPriceAdjustment : QuickFix.Fields.DecimalField
    {
        public ExecPriceAdjustment()
            :base(Fields.CustomTags.ExecPriceAdjustment) {}
        public ExecPriceAdjustment(Decimal val)
            :base(Fields.CustomTags.ExecPriceAdjustment, val) {}

    }


    /// <summary>
    /// DateOfBirth Field
    /// </summary>/
    public sealed class DateOfBirth : QuickFix.Fields.StringField
    {
        public DateOfBirth()
            :base(Fields.CustomTags.DateOfBirth) {}
        public DateOfBirth(string val)
            :base(Fields.CustomTags.DateOfBirth, val) {}

    }


    /// <summary>
    /// TradeReportTransType Field
    /// </summary>/
    public sealed class TradeReportTransType : QuickFix.Fields.IntField
    {
        public TradeReportTransType()
            :base(Fields.CustomTags.TradeReportTransType) {}
        public TradeReportTransType(int val)
            :base(Fields.CustomTags.TradeReportTransType, val) {}


        // Field Enumerations
        public const int NEW = 0;
        public const int CANCEL = 1;
        public const int REPLACE = 2;
        public const int RELEASE = 3;
        public const int REVERSE = 4;
        public const int CANCEL_DUE_TO_BACK_OUT_OF_TRADE = 5;
        public const int INQUIRE = 101;
        public const int ACCEPT = 102;
        public const int UNKNOWN = 999;
    }


    /// <summary>
    /// CardHolderName Field
    /// </summary>/
    public sealed class CardHolderName : QuickFix.Fields.StringField
    {
        public CardHolderName()
            :base(Fields.CustomTags.CardHolderName) {}
        public CardHolderName(string val)
            :base(Fields.CustomTags.CardHolderName, val) {}

    }


    /// <summary>
    /// CardNumber Field
    /// </summary>/
    public sealed class CardNumber : QuickFix.Fields.StringField
    {
        public CardNumber()
            :base(Fields.CustomTags.CardNumber) {}
        public CardNumber(string val)
            :base(Fields.CustomTags.CardNumber, val) {}

    }


    /// <summary>
    /// CardExpDate Field
    /// </summary>/
    public sealed class CardExpDate : QuickFix.Fields.StringField
    {
        public CardExpDate()
            :base(Fields.CustomTags.CardExpDate) {}
        public CardExpDate(string val)
            :base(Fields.CustomTags.CardExpDate, val) {}

    }


    /// <summary>
    /// CardIssNo Field
    /// </summary>/
    public sealed class CardIssNo : QuickFix.Fields.StringField
    {
        public CardIssNo()
            :base(Fields.CustomTags.CardIssNo) {}
        public CardIssNo(string val)
            :base(Fields.CustomTags.CardIssNo, val) {}

    }


    /// <summary>
    /// PaymentMethod Field
    /// </summary>/
    public sealed class PaymentMethod : QuickFix.Fields.IntField
    {
        public PaymentMethod()
            :base(Fields.CustomTags.PaymentMethod) {}
        public PaymentMethod(int val)
            :base(Fields.CustomTags.PaymentMethod, val) {}


        // Field Enumerations
        public const int CREST = 1;
        public const int DIRECT_CREDIT = 10;
        public const int CREDIT_CARD = 11;
        public const int ACH_DEBIT = 12;
        public const int ACH_CREDIT = 13;
        public const int BPAY = 14;
        public const int HIGH_VALUE_CLEARING_SYSTEM = 15;
        public const int NSCC = 2;
        public const int EUROCLEAR = 3;
        public const int CLEARSTREAM = 4;
        public const int CHEQUE = 5;
        public const int TELEGRAPHIC_TRANSFER = 6;
        public const int FED_WIRE = 7;
        public const int DEBIT_CARD = 8;
        public const int DIRECT_DEBIT = 9;
    }


    /// <summary>
    /// RegistAcctType Field
    /// </summary>/
    public sealed class RegistAcctType : QuickFix.Fields.StringField
    {
        public RegistAcctType()
            :base(Fields.CustomTags.RegistAcctType) {}
        public RegistAcctType(string val)
            :base(Fields.CustomTags.RegistAcctType, val) {}

    }


    /// <summary>
    /// Designation Field
    /// </summary>/
    public sealed class Designation : QuickFix.Fields.StringField
    {
        public Designation()
            :base(Fields.CustomTags.Designation) {}
        public Designation(string val)
            :base(Fields.CustomTags.Designation, val) {}

    }


    /// <summary>
    /// TaxAdvantageType Field
    /// </summary>/
    public sealed class TaxAdvantageType : QuickFix.Fields.IntField
    {
        public TaxAdvantageType()
            :base(Fields.CustomTags.TaxAdvantageType) {}
        public TaxAdvantageType(int val)
            :base(Fields.CustomTags.TaxAdvantageType, val) {}


        // Field Enumerations
        public const int NONE_NOT_APPLICABLE = 0;
        public const int MAXI_ISA = 1;
        public const int EMPLOYEE_10 = 10;
        public const int EMPLOYER_11 = 11;
        public const int EMPLOYER_12 = 12;
        public const int NON_FUND_PROTOTYPE_IRA = 13;
        public const int NON_FUND_QUALIFIED_PLAN = 14;
        public const int DEFINED_CONTRIBUTION_PLAN = 15;
        public const int INDIVIDUAL_RETIREMENT_ACCOUNT_16 = 16;
        public const int INDIVIDUAL_RETIREMENT_ACCOUNT_17 = 17;
        public const int KEOGH = 18;
        public const int PROFIT_SHARING_PLAN = 19;
        public const int TESSA = 2;
        public const int VAL_401 = 20;
        public const int SELF_DIRECTED_IRA = 21;
        public const int VAL_403 = 22;
        public const int VAL_457 = 23;
        public const int ROTH_IRA_24 = 24;
        public const int ROTH_IRA_25 = 25;
        public const int ROTH_CONVERSION_IRA_26 = 26;
        public const int ROTH_CONVERSION_IRA_27 = 27;
        public const int EDUCATION_IRA_28 = 28;
        public const int EDUCATION_IRA_29 = 29;
        public const int MINI_CASH_ISA = 3;
        public const int MINI_STOCKS_AND_SHARES_ISA = 4;
        public const int MINI_INSURANCE_ISA = 5;
        public const int CURRENT_YEAR_PAYMENT = 6;
        public const int PRIOR_YEAR_PAYMENT = 7;
        public const int ASSET_TRANSFER = 8;
        public const int EMPLOYEE_9 = 9;
        public const int OTHER = 999;
    }


    /// <summary>
    /// RegistRejReasonText Field
    /// </summary>/
    public sealed class RegistRejReasonText : QuickFix.Fields.StringField
    {
        public RegistRejReasonText()
            :base(Fields.CustomTags.RegistRejReasonText) {}
        public RegistRejReasonText(string val)
            :base(Fields.CustomTags.RegistRejReasonText, val) {}

    }


    /// <summary>
    /// FundRenewWaiv Field
    /// </summary>/
    public sealed class FundRenewWaiv : QuickFix.Fields.CharField
    {
        public FundRenewWaiv()
            :base(Fields.CustomTags.FundRenewWaiv) {}
        public FundRenewWaiv(char val)
            :base(Fields.CustomTags.FundRenewWaiv, val) {}


        // Field Enumerations
        public const char NO = 'N';
        public const char YES = 'Y';
    }


    /// <summary>
    /// CashDistribAgentName Field
    /// </summary>/
    public sealed class CashDistribAgentName : QuickFix.Fields.StringField
    {
        public CashDistribAgentName()
            :base(Fields.CustomTags.CashDistribAgentName) {}
        public CashDistribAgentName(string val)
            :base(Fields.CustomTags.CashDistribAgentName, val) {}

    }


    /// <summary>
    /// CashDistribAgentCode Field
    /// </summary>/
    public sealed class CashDistribAgentCode : QuickFix.Fields.StringField
    {
        public CashDistribAgentCode()
            :base(Fields.CustomTags.CashDistribAgentCode) {}
        public CashDistribAgentCode(string val)
            :base(Fields.CustomTags.CashDistribAgentCode, val) {}

    }


    /// <summary>
    /// CashDistribAgentAcctNumber Field
    /// </summary>/
    public sealed class CashDistribAgentAcctNumber : QuickFix.Fields.StringField
    {
        public CashDistribAgentAcctNumber()
            :base(Fields.CustomTags.CashDistribAgentAcctNumber) {}
        public CashDistribAgentAcctNumber(string val)
            :base(Fields.CustomTags.CashDistribAgentAcctNumber, val) {}

    }


    /// <summary>
    /// CashDistribPayRef Field
    /// </summary>/
    public sealed class CashDistribPayRef : QuickFix.Fields.StringField
    {
        public CashDistribPayRef()
            :base(Fields.CustomTags.CashDistribPayRef) {}
        public CashDistribPayRef(string val)
            :base(Fields.CustomTags.CashDistribPayRef, val) {}

    }


    /// <summary>
    /// CashDistribAgentAcctName Field
    /// </summary>/
    public sealed class CashDistribAgentAcctName : QuickFix.Fields.StringField
    {
        public CashDistribAgentAcctName()
            :base(Fields.CustomTags.CashDistribAgentAcctName) {}
        public CashDistribAgentAcctName(string val)
            :base(Fields.CustomTags.CashDistribAgentAcctName, val) {}

    }


    /// <summary>
    /// CardStartDate Field
    /// </summary>/
    public sealed class CardStartDate : QuickFix.Fields.StringField
    {
        public CardStartDate()
            :base(Fields.CustomTags.CardStartDate) {}
        public CardStartDate(string val)
            :base(Fields.CustomTags.CardStartDate, val) {}

    }


    /// <summary>
    /// PaymentDate Field
    /// </summary>/
    public sealed class PaymentDate : QuickFix.Fields.StringField
    {
        public PaymentDate()
            :base(Fields.CustomTags.PaymentDate) {}
        public PaymentDate(string val)
            :base(Fields.CustomTags.PaymentDate, val) {}

    }


    /// <summary>
    /// PaymentRemitterID Field
    /// </summary>/
    public sealed class PaymentRemitterID : QuickFix.Fields.StringField
    {
        public PaymentRemitterID()
            :base(Fields.CustomTags.PaymentRemitterID) {}
        public PaymentRemitterID(string val)
            :base(Fields.CustomTags.PaymentRemitterID, val) {}

    }


    /// <summary>
    /// RegistStatus Field
    /// </summary>/
    public sealed class RegistStatus : QuickFix.Fields.CharField
    {
        public RegistStatus()
            :base(Fields.CustomTags.RegistStatus) {}
        public RegistStatus(char val)
            :base(Fields.CustomTags.RegistStatus, val) {}


        // Field Enumerations
        public const char ACCEPTED = 'A';
        public const char HELD = 'H';
        public const char REMINDER = 'N';
        public const char REJECTED = 'R';
    }


    /// <summary>
    /// RegistRejReasonCode Field
    /// </summary>/
    public sealed class RegistRejReasonCode : QuickFix.Fields.IntField
    {
        public RegistRejReasonCode()
            :base(Fields.CustomTags.RegistRejReasonCode) {}
        public RegistRejReasonCode(int val)
            :base(Fields.CustomTags.RegistRejReasonCode, val) {}


        // Field Enumerations
        public const int INVALID_UNACCEPTABLE_ACCOUNT_TYPE = 1;
        public const int INVALID_UNACEEPTABLE_INVESTOR_ID_SOURCE = 10;
        public const int INVALID_UNACCEPTABLE_DATE_OF_BIRTH = 11;
        public const int INVALID_UNACCEPTABLE_INVESTOR_COUNTRY_OF_RESIDENCE = 12;
        public const int INVALID_UNACCEPTABLE_NO_DISTRIB_INSTNS = 13;
        public const int INVALID_UNACCEPTABLE_DISTRIB_PERCENTAGE = 14;
        public const int INVALID_UNACCEPTABLE_DISTRIB_PAYMENT_METHOD = 15;
        public const int INVALID_UNACCEPTABLE_CASH_DISTRIB_AGENT_ACCT_NAME = 16;
        public const int INVALID_UNACCEPTABLE_CASH_DISTRIB_AGENT_CODE = 17;
        public const int INVALID_UNACCEPTABLE_CASH_DISTRIB_AGENT_ACCT_NUM = 18;
        public const int INVALID_UNACCEPTABLE_TAX_EXEMPT_TYPE = 2;
        public const int INVALID_UNACCEPTABLE_OWNERSHIP_TYPE = 3;
        public const int INVALID_UNACCEPTABLE_NO_REG_DETAILS = 4;
        public const int INVALID_UNACCEPTABLE_REG_SEQ_NO = 5;
        public const int INVALID_UNACCEPTABLE_REG_DETAILS = 6;
        public const int INVALID_UNACCEPTABLE_MAILING_DETAILS = 7;
        public const int INVALID_UNACCEPTABLE_MAILING_INSTRUCTIONS = 8;
        public const int INVALID_UNACCEPTABLE_INVESTOR_ID = 9;
        public const int OTHER = 99;
    }


    /// <summary>
    /// RegistRefID Field
    /// </summary>/
    public sealed class RegistRefID : QuickFix.Fields.StringField
    {
        public RegistRefID()
            :base(Fields.CustomTags.RegistRefID) {}
        public RegistRefID(string val)
            :base(Fields.CustomTags.RegistRefID, val) {}

    }


    /// <summary>
    /// RegistDetls Field
    /// </summary>/
    public sealed class RegistDetls : QuickFix.Fields.StringField
    {
        public RegistDetls()
            :base(Fields.CustomTags.RegistDetls) {}
        public RegistDetls(string val)
            :base(Fields.CustomTags.RegistDetls, val) {}

    }


    /// <summary>
    /// NoDistribInsts Field
    /// </summary>/
    public sealed class NoDistribInsts : QuickFix.Fields.IntField
    {
        public NoDistribInsts()
            :base(Fields.CustomTags.NoDistribInsts) {}
        public NoDistribInsts(int val)
            :base(Fields.CustomTags.NoDistribInsts, val) {}

    }


    /// <summary>
    /// RegistEmail Field
    /// </summary>/
    public sealed class RegistEmail : QuickFix.Fields.StringField
    {
        public RegistEmail()
            :base(Fields.CustomTags.RegistEmail) {}
        public RegistEmail(string val)
            :base(Fields.CustomTags.RegistEmail, val) {}

    }


    /// <summary>
    /// DistribPercentage Field
    /// </summary>/
    public sealed class DistribPercentage : QuickFix.Fields.DecimalField
    {
        public DistribPercentage()
            :base(Fields.CustomTags.DistribPercentage) {}
        public DistribPercentage(Decimal val)
            :base(Fields.CustomTags.DistribPercentage, val) {}

    }


    /// <summary>
    /// RegistID Field
    /// </summary>/
    public sealed class RegistID : QuickFix.Fields.StringField
    {
        public RegistID()
            :base(Fields.CustomTags.RegistID) {}
        public RegistID(string val)
            :base(Fields.CustomTags.RegistID, val) {}

    }


    /// <summary>
    /// RegistTransType Field
    /// </summary>/
    public sealed class RegistTransType : QuickFix.Fields.CharField
    {
        public RegistTransType()
            :base(Fields.CustomTags.RegistTransType) {}
        public RegistTransType(char val)
            :base(Fields.CustomTags.RegistTransType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char REPLACE = '1';
        public const char CANCEL = '2';
    }


    /// <summary>
    /// ExecValuationPoint Field
    /// </summary>/
    public sealed class ExecValuationPoint : QuickFix.Fields.DateTimeField
    {
        public ExecValuationPoint()
            :base(Fields.CustomTags.ExecValuationPoint) {}
        public ExecValuationPoint(DateTime val)
            :base(Fields.CustomTags.ExecValuationPoint, val) {}
        public ExecValuationPoint(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.ExecValuationPoint, val, showMilliseconds) {}
		public ExecValuationPoint(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.ExecValuationPoint, val, precision) {}

    }


    /// <summary>
    /// OrderPercent Field
    /// </summary>/
    public sealed class OrderPercent : QuickFix.Fields.DecimalField
    {
        public OrderPercent()
            :base(Fields.CustomTags.OrderPercent) {}
        public OrderPercent(Decimal val)
            :base(Fields.CustomTags.OrderPercent, val) {}

    }


    /// <summary>
    /// OwnershipType Field
    /// </summary>/
    public sealed class OwnershipType : QuickFix.Fields.CharField
    {
        public OwnershipType()
            :base(Fields.CustomTags.OwnershipType) {}
        public OwnershipType(char val)
            :base(Fields.CustomTags.OwnershipType, val) {}


        // Field Enumerations
        public const char JOINT_TRUSTEES = '2';
        public const char JOINT_INVESTORS = 'J';
        public const char TENANTS_IN_COMMON = 'T';
    }


    /// <summary>
    /// NoContAmts Field
    /// </summary>/
    public sealed class NoContAmts : QuickFix.Fields.IntField
    {
        public NoContAmts()
            :base(Fields.CustomTags.NoContAmts) {}
        public NoContAmts(int val)
            :base(Fields.CustomTags.NoContAmts, val) {}

    }


    /// <summary>
    /// ContAmtType Field
    /// </summary>/
    public sealed class ContAmtType : QuickFix.Fields.IntField
    {
        public ContAmtType()
            :base(Fields.CustomTags.ContAmtType) {}
        public ContAmtType(int val)
            :base(Fields.CustomTags.ContAmtType, val) {}


        // Field Enumerations
        public const int COMMISSION_AMOUNT = 1;
        public const int EXIT_CHARGE_PERCENT = 10;
        public const int FUND_BASED_RENEWAL_COMMISSION_PERCENT = 11;
        public const int PROJECTED_FUND_VALUE = 12;
        public const int FUND_BASED_RENEWAL_COMMISSION_AMOUNT_13 = 13;
        public const int FUND_BASED_RENEWAL_COMMISSION_AMOUNT_14 = 14;
        public const int NET_SETTLEMENT_AMOUNT = 15;
        public const int COMMISSION_PERCENT = 2;
        public const int INITIAL_CHARGE_AMOUNT = 3;
        public const int INITIAL_CHARGE_PERCENT = 4;
        public const int DISCOUNT_AMOUNT = 5;
        public const int DISCOUNT_PERCENT = 6;
        public const int DILUTION_LEVY_AMOUNT = 7;
        public const int DILUTION_LEVY_PERCENT = 8;
        public const int EXIT_CHARGE_AMOUNT = 9;
    }


    /// <summary>
    /// ContAmtValue Field
    /// </summary>/
    public sealed class ContAmtValue : QuickFix.Fields.DecimalField
    {
        public ContAmtValue()
            :base(Fields.CustomTags.ContAmtValue) {}
        public ContAmtValue(Decimal val)
            :base(Fields.CustomTags.ContAmtValue, val) {}

    }


    /// <summary>
    /// ContAmtCurr Field
    /// </summary>/
    public sealed class ContAmtCurr : QuickFix.Fields.StringField
    {
        public ContAmtCurr()
            :base(Fields.CustomTags.ContAmtCurr) {}
        public ContAmtCurr(string val)
            :base(Fields.CustomTags.ContAmtCurr, val) {}

    }


    /// <summary>
    /// OwnerType Field
    /// </summary>/
    public sealed class OwnerType : QuickFix.Fields.IntField
    {
        public OwnerType()
            :base(Fields.CustomTags.OwnerType) {}
        public OwnerType(int val)
            :base(Fields.CustomTags.OwnerType, val) {}


        // Field Enumerations
        public const int INDIVIDUAL_INVESTOR = 1;
        public const int NETWORKING_SUB_ACCOUNT = 10;
        public const int NON_PROFIT_ORGANIZATION = 11;
        public const int CORPORATE_BODY = 12;
        public const int NOMINEE = 13;
        public const int PUBLIC_COMPANY = 2;
        public const int PRIVATE_COMPANY = 3;
        public const int INDIVIDUAL_TRUSTEE = 4;
        public const int COMPANY_TRUSTEE = 5;
        public const int PENSION_PLAN = 6;
        public const int CUSTODIAN_UNDER_GIFTS_TO_MINORS_ACT = 7;
        public const int TRUSTS = 8;
        public const int FIDUCIARIES = 9;
    }


    /// <summary>
    /// PartySubID Field
    /// </summary>/
    public sealed class PartySubID : QuickFix.Fields.StringField
    {
        public PartySubID()
            :base(Fields.CustomTags.PartySubID) {}
        public PartySubID(string val)
            :base(Fields.CustomTags.PartySubID, val) {}

    }


    /// <summary>
    /// NestedPartyID Field
    /// </summary>/
    public sealed class NestedPartyID : QuickFix.Fields.StringField
    {
        public NestedPartyID()
            :base(Fields.CustomTags.NestedPartyID) {}
        public NestedPartyID(string val)
            :base(Fields.CustomTags.NestedPartyID, val) {}

    }


    /// <summary>
    /// NestedPartyIDSource Field
    /// </summary>/
    public sealed class NestedPartyIDSource : QuickFix.Fields.CharField
    {
        public NestedPartyIDSource()
            :base(Fields.CustomTags.NestedPartyIDSource) {}
        public NestedPartyIDSource(char val)
            :base(Fields.CustomTags.NestedPartyIDSource, val) {}

    }


    /// <summary>
    /// SecondaryClOrdID Field
    /// </summary>/
    public sealed class SecondaryClOrdID : QuickFix.Fields.StringField
    {
        public SecondaryClOrdID()
            :base(Fields.CustomTags.SecondaryClOrdID) {}
        public SecondaryClOrdID(string val)
            :base(Fields.CustomTags.SecondaryClOrdID, val) {}

    }


    /// <summary>
    /// SecondaryExecID Field
    /// </summary>/
    public sealed class SecondaryExecID : QuickFix.Fields.StringField
    {
        public SecondaryExecID()
            :base(Fields.CustomTags.SecondaryExecID) {}
        public SecondaryExecID(string val)
            :base(Fields.CustomTags.SecondaryExecID, val) {}

    }


    /// <summary>
    /// OrderCapacity Field
    /// </summary>/
    public sealed class OrderCapacity : QuickFix.Fields.CharField
    {
        public OrderCapacity()
            :base(Fields.CustomTags.OrderCapacity) {}
        public OrderCapacity(char val)
            :base(Fields.CustomTags.OrderCapacity, val) {}


        // Field Enumerations
        public const char AGENCY = 'A';
        public const char PROPRIETARY = 'G';
        public const char INDIVIDUAL = 'I';
        public const char PRINCIPAL = 'P';
        public const char RISKLESS_PRINCIPAL = 'R';
        public const char AGENT_FOR_OTHER_MEMBER = 'W';
    }


    /// <summary>
    /// OrderRestrictions Field
    /// </summary>/
    public sealed class OrderRestrictions : QuickFix.Fields.StringField
    {
        public OrderRestrictions()
            :base(Fields.CustomTags.OrderRestrictions) {}
        public OrderRestrictions(string val)
            :base(Fields.CustomTags.OrderRestrictions, val) {}


        // Field Enumerations
        public const string PROGRAM_TRADE = "1";
        public const string INDEX_ARBITRAGE = "2";
        public const string NON_INDEX_ARBITRAGE = "3";
        public const string COMPETING_MARKET_MAKER = "4";
        public const string ACTING_AS_MARKET_MAKER_OR_SPECIALIST_IN_THE_SECURITY = "5";
        public const string ACTING_AS_MARKET_MAKER_OR_SPECIALIST_IN_THE_UNDERLYING_SECURITY_OF_A_DERIVATIVE_SECURITY = "6";
        public const string FOREIGN_ENTITY = "7";
        public const string EXTERNAL_MARKET_PARTICIPANT = "8";
        public const string EXTERNAL_INTER_CONNECTED_MARKET_LINKAGE = "9";
        public const string RISKLESS_ARBITRAGE = "A";
        public const string ISSUER_HOLDING = "B";
        public const string ISSUE_PRICE_STABILIZATION = "C";
        public const string NON_ALGORITHMIC = "D";
        public const string ALGORITHMIC = "E";
        public const string CROSS = "F";
        public const string ACTING_AS_MARKET_MAKER_OF_SPECIALIST_IN_THE_UNDERLYING_SECURITY_OF_A_DERIVATIVE_SEUCIRTY = "6";
        public const string EXTNERAL_INTER_CONNECTED_MARKET_LINKAGE = "9";
    }


    /// <summary>
    /// MassCancelRequestType Field
    /// </summary>/
    public sealed class MassCancelRequestType : QuickFix.Fields.CharField
    {
        public MassCancelRequestType()
            :base(Fields.CustomTags.MassCancelRequestType) {}
        public MassCancelRequestType(char val)
            :base(Fields.CustomTags.MassCancelRequestType, val) {}


        // Field Enumerations
        public const char CANCEL_ORDERS_FOR_A_SECURITY = '1';
        public const char CANCEL_ORDERS_FOR_AN_UNDERLYING_SECURITY = '2';
        public const char CANCEL_ORDERS_FOR_A_PRODUCT = '3';
        public const char CANCEL_ORDERS_FOR_A_CFICODE = '4';
        public const char CANCEL_ORDERS_FOR_A_SECURITYTYPE = '5';
        public const char CANCEL_ORDERS_FOR_A_TRADING_SESSION = '6';
        public const char CANCEL_ALL_ORDERS = '7';
        public const char CANCEL_ORDERS_FOR_A_MARKET = '8';
        public const char CANCEL_ORDERS_FOR_A_MARKET_SEGMENT = '9';
        public const char CANCEL_ORDERS_FOR_A_SECURITY_GROUP = 'A';
        public const char CANCEL_FOR_SECURITY_ISSUER = 'B';
        public const char CANCEL_FOR_ISSUER_OF_UNDERLYING_SECURITY = 'C';
        public const string SenderSubID = "100";
        public const string Account = "101";
    }


    /// <summary>
    /// MassCancelResponse Field
    /// </summary>/
    public sealed class MassCancelResponse : QuickFix.Fields.CharField
    {
        public MassCancelResponse()
            :base(Fields.CustomTags.MassCancelResponse) {}
        public MassCancelResponse(char val)
            :base(Fields.CustomTags.MassCancelResponse, val) {}


        // Field Enumerations
        public const char CANCEL_REQUEST_REJECTED = '0';
        public const char CANCEL_ORDERS_FOR_A_SECURITY = '1';
        public const char CANCEL_ORDERS_FOR_AN_UNDERLYING_SECURITY = '2';
        public const char CANCEL_ORDERS_FOR_A_PRODUCT = '3';
        public const char CANCEL_ORDERS_FOR_A_CFICODE = '4';
        public const char CANCEL_ORDERS_FOR_A_SECURITYTYPE = '5';
        public const char CANCEL_ORDERS_FOR_A_TRADING_SESSION = '6';
        public const char CANCEL_ALL_ORDERS = '7';
        public const char CANCEL_ORDERS_FOR_A_MARKET = '8';
        public const char CANCEL_ORDERS_FOR_A_MARKET_SEGMENT = '9';
        public const char CANCEL_ORDERS_FOR_A_SECURITY_GROUP = 'A';
        public const char CANCEL_ORDERS_FOR_A_SECURITIES_ISSUER = 'B';
        public const char CANCEL_ORDERS_FOR_ISSUER_OF_UNDERLYING_SECURITY = 'C';
    }


    /// <summary>
    /// MassCancelRejectReason Field
    /// </summary>/
    public sealed class MassCancelRejectReason : QuickFix.Fields.IntField
    {
        public MassCancelRejectReason()
            :base(Fields.CustomTags.MassCancelRejectReason) {}
        public MassCancelRejectReason(int val)
            :base(Fields.CustomTags.MassCancelRejectReason, val) {}


        // Field Enumerations
        public const int MASS_CANCEL_NOT_SUPPORTED = 0;
        public const int INVALID_OR_UNKNOWN_SECURITY = 1;
        public const int INVALID_OR_UNKOWN_UNDERLYING_SECURITY = 2;
        public const int INVALID_OR_UNKNOWN_PRODUCT = 3;
        public const int INVALID_OR_UNKNOWN_CFICODE = 4;
        public const int INVALID_OR_UNKNOWN_SECURITYTYPE = 5;
        public const int INVALID_OR_UNKNOWN_TRADING_SESSION = 6;
        public const int OTHER = 99;
        public const int INVALID_OR_UNKNOWN_MARKET = 7;
        public const int INVALID_OR_UNKOWN_MARKET_SEGMENT = 8;
        public const int INVALID_OR_UNKNOWN_SECURITY_GROUP = 9;
        public const int INVALID_OR_UNKNOWN_SECURITY_ISSUER = 10;
        public const int INVALID_OR_UNKNOWN_ISSUER_OF_UNDERLYING_SECURITY = 11;
    }


    /// <summary>
    /// TotalAffectedOrders Field
    /// </summary>/
    public sealed class TotalAffectedOrders : QuickFix.Fields.IntField
    {
        public TotalAffectedOrders()
            :base(Fields.CustomTags.TotalAffectedOrders) {}
        public TotalAffectedOrders(int val)
            :base(Fields.CustomTags.TotalAffectedOrders, val) {}

    }


    /// <summary>
    /// NoAffectedOrders Field
    /// </summary>/
    public sealed class NoAffectedOrders : QuickFix.Fields.IntField
    {
        public NoAffectedOrders()
            :base(Fields.CustomTags.NoAffectedOrders) {}
        public NoAffectedOrders(int val)
            :base(Fields.CustomTags.NoAffectedOrders, val) {}

    }


    /// <summary>
    /// AffectedOrderID Field
    /// </summary>/
    public sealed class AffectedOrderID : QuickFix.Fields.StringField
    {
        public AffectedOrderID()
            :base(Fields.CustomTags.AffectedOrderID) {}
        public AffectedOrderID(string val)
            :base(Fields.CustomTags.AffectedOrderID, val) {}

    }


    /// <summary>
    /// AffectedSecondaryOrderID Field
    /// </summary>/
    public sealed class AffectedSecondaryOrderID : QuickFix.Fields.StringField
    {
        public AffectedSecondaryOrderID()
            :base(Fields.CustomTags.AffectedSecondaryOrderID) {}
        public AffectedSecondaryOrderID(string val)
            :base(Fields.CustomTags.AffectedSecondaryOrderID, val) {}

    }


    /// <summary>
    /// QuoteType Field
    /// </summary>/
    public sealed class QuoteType : QuickFix.Fields.IntField
    {
        public QuoteType()
            :base(Fields.CustomTags.QuoteType) {}
        public QuoteType(int val)
            :base(Fields.CustomTags.QuoteType, val) {}


        // Field Enumerations
        public const int INDICATIVE = 0;
        public const int TRADEABLE = 1;
        public const int RESTRICTED_TRADEABLE = 2;
        public const int COUNTER = 3;
        public const int TRADABLE = 1;
        public const int CROSS_TRADE_REQUEST = 99;
        public const int UNKNOWN = 255;
    }


    /// <summary>
    /// NestedPartyRole Field
    /// </summary>/
    public sealed class NestedPartyRole : QuickFix.Fields.IntField
    {
        public NestedPartyRole()
            :base(Fields.CustomTags.NestedPartyRole) {}
        public NestedPartyRole(int val)
            :base(Fields.CustomTags.NestedPartyRole, val) {}

    }


    /// <summary>
    /// NoNestedPartyIDs Field
    /// </summary>/
    public sealed class NoNestedPartyIDs : QuickFix.Fields.IntField
    {
        public NoNestedPartyIDs()
            :base(Fields.CustomTags.NoNestedPartyIDs) {}
        public NoNestedPartyIDs(int val)
            :base(Fields.CustomTags.NoNestedPartyIDs, val) {}

    }


    /// <summary>
    /// TotalAccruedInterestAmt Field
    /// </summary>/
    public sealed class TotalAccruedInterestAmt : QuickFix.Fields.DecimalField
    {
        public TotalAccruedInterestAmt()
            :base(Fields.CustomTags.TotalAccruedInterestAmt) {}
        public TotalAccruedInterestAmt(Decimal val)
            :base(Fields.CustomTags.TotalAccruedInterestAmt, val) {}

    }


    /// <summary>
    /// MaturityDate Field
    /// </summary>/
    public sealed class MaturityDate : QuickFix.Fields.StringField
    {
        public MaturityDate()
            :base(Fields.CustomTags.MaturityDate) {}
        public MaturityDate(string val)
            :base(Fields.CustomTags.MaturityDate, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityDate Field
    /// </summary>/
    public sealed class UnderlyingMaturityDate : QuickFix.Fields.StringField
    {
        public UnderlyingMaturityDate()
            :base(Fields.CustomTags.UnderlyingMaturityDate) {}
        public UnderlyingMaturityDate(string val)
            :base(Fields.CustomTags.UnderlyingMaturityDate, val) {}

    }


    /// <summary>
    /// InstrRegistry Field
    /// </summary>/
    public sealed class InstrRegistry : QuickFix.Fields.StringField
    {
        public InstrRegistry()
            :base(Fields.CustomTags.InstrRegistry) {}
        public InstrRegistry(string val)
            :base(Fields.CustomTags.InstrRegistry, val) {}


        // Field Enumerations
        public const string COUNTRY_IN_WHICH_REGISTRY_IS_KEPT = "Code";
        public const string PHYSICAL_OR_BEARER = "ZZ";
    }


    /// <summary>
    /// CashMargin Field
    /// </summary>/
    public sealed class CashMargin : QuickFix.Fields.CharField
    {
        public CashMargin()
            :base(Fields.CustomTags.CashMargin) {}
        public CashMargin(char val)
            :base(Fields.CustomTags.CashMargin, val) {}


        // Field Enumerations
        public const char CASH = '1';
        public const char MARGIN_OPEN = '2';
        public const char MARGIN_CLOSE = '3';
    }


    /// <summary>
    /// NestedPartySubID Field
    /// </summary>/
    public sealed class NestedPartySubID : QuickFix.Fields.StringField
    {
        public NestedPartySubID()
            :base(Fields.CustomTags.NestedPartySubID) {}
        public NestedPartySubID(string val)
            :base(Fields.CustomTags.NestedPartySubID, val) {}

    }


    /// <summary>
    /// Scope Field
    /// </summary>/
    public sealed class Scope : QuickFix.Fields.StringField
    {
        public Scope()
            :base(Fields.CustomTags.Scope) {}
        public Scope(string val)
            :base(Fields.CustomTags.Scope, val) {}


        // Field Enumerations
        public const string LOCAL_MARKET = "1";
        public const string NATIONAL = "2";
        public const string GLOBAL = "3";
        public const string LOCAL = "1";
    }


    /// <summary>
    /// MDImplicitDelete Field
    /// </summary>/
    public sealed class MDImplicitDelete : QuickFix.Fields.BooleanField
    {
        public MDImplicitDelete()
            :base(Fields.CustomTags.MDImplicitDelete) {}
        public MDImplicitDelete(Boolean val)
            :base(Fields.CustomTags.MDImplicitDelete, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// CrossID Field
    /// </summary>/
    public sealed class CrossID : QuickFix.Fields.StringField
    {
        public CrossID()
            :base(Fields.CustomTags.CrossID) {}
        public CrossID(string val)
            :base(Fields.CustomTags.CrossID, val) {}

    }


    /// <summary>
    /// CrossType Field
    /// </summary>/
    public sealed class CrossType : QuickFix.Fields.IntField
    {
        public CrossType()
            :base(Fields.CustomTags.CrossType) {}
        public CrossType(int val)
            :base(Fields.CustomTags.CrossType, val) {}


        // Field Enumerations
        public const int CROSS_AON = 1;
        public const int CROSS_IOC = 2;
        public const int CROSS_ONE_SIDE = 3;
        public const int CROSS_SAME_PRICE = 4;
        public const int CROSS_TRADE_WHICH_IS_EXECUTED_COMPLETELY_OR_NOT = 1;
        public const int CROSS_TRADE_WHICH_IS_EXECUTED_PARTIALLY_AND_THE_REST_IS_CANCELLED = 2;
        public const int CROSS_TRADE_WHICH_IS_PARTIALLY_EXECUTED_WITH_THE_UNFILLED_PORTIONS_REMAINING_ACTIVE = 3;
        public const int CROSS_TRADE_IS_EXECUTED_WITH_EXISTING_ORDERS_WITH_THE_SAME_PRICE = 4;
    }


    /// <summary>
    /// CrossPrioritization Field
    /// </summary>/
    public sealed class CrossPrioritization : QuickFix.Fields.IntField
    {
        public CrossPrioritization()
            :base(Fields.CustomTags.CrossPrioritization) {}
        public CrossPrioritization(int val)
            :base(Fields.CustomTags.CrossPrioritization, val) {}


        // Field Enumerations
        public const int NONE = 0;
        public const int BUY_SIDE_IS_PRIORITIZED = 1;
        public const int SELL_SIDE_IS_PRIORITIZED = 2;
    }


    /// <summary>
    /// OrigCrossID Field
    /// </summary>/
    public sealed class OrigCrossID : QuickFix.Fields.StringField
    {
        public OrigCrossID()
            :base(Fields.CustomTags.OrigCrossID) {}
        public OrigCrossID(string val)
            :base(Fields.CustomTags.OrigCrossID, val) {}

    }


    /// <summary>
    /// NoSides Field
    /// </summary>/
    public sealed class NoSides : QuickFix.Fields.IntField
    {
        public NoSides()
            :base(Fields.CustomTags.NoSides) {}
        public NoSides(int val)
            :base(Fields.CustomTags.NoSides, val) {}


        // Field Enumerations
        public const int ONE_SIDE = 1;
        public const int BOTH_SIDES = 2;
    }


    /// <summary>
    /// Username Field
    /// </summary>/
    public sealed class Username : QuickFix.Fields.StringField
    {
        public Username()
            :base(Fields.CustomTags.Username) {}
        public Username(string val)
            :base(Fields.CustomTags.Username, val) {}

    }


    /// <summary>
    /// Password Field
    /// </summary>/
    public sealed class Password : QuickFix.Fields.StringField
    {
        public Password()
            :base(Fields.CustomTags.Password) {}
        public Password(string val)
            :base(Fields.CustomTags.Password, val) {}

    }


    /// <summary>
    /// NoLegs Field
    /// </summary>/
    public sealed class NoLegs : QuickFix.Fields.IntField
    {
        public NoLegs()
            :base(Fields.CustomTags.NoLegs) {}
        public NoLegs(int val)
            :base(Fields.CustomTags.NoLegs, val) {}

    }


    /// <summary>
    /// LegCurrency Field
    /// </summary>/
    public sealed class LegCurrency : QuickFix.Fields.StringField
    {
        public LegCurrency()
            :base(Fields.CustomTags.LegCurrency) {}
        public LegCurrency(string val)
            :base(Fields.CustomTags.LegCurrency, val) {}

    }


    /// <summary>
    /// TotalNumSecurityTypes Field
    /// </summary>/
    public sealed class TotalNumSecurityTypes : QuickFix.Fields.IntField
    {
        public TotalNumSecurityTypes()
            :base(Fields.CustomTags.TotalNumSecurityTypes) {}
        public TotalNumSecurityTypes(int val)
            :base(Fields.CustomTags.TotalNumSecurityTypes, val) {}

    }


    /// <summary>
    /// NoSecurityTypes Field
    /// </summary>/
    public sealed class NoSecurityTypes : QuickFix.Fields.IntField
    {
        public NoSecurityTypes()
            :base(Fields.CustomTags.NoSecurityTypes) {}
        public NoSecurityTypes(int val)
            :base(Fields.CustomTags.NoSecurityTypes, val) {}

    }


    /// <summary>
    /// SecurityListRequestType Field
    /// </summary>/
    public sealed class SecurityListRequestType : QuickFix.Fields.IntField
    {
        public SecurityListRequestType()
            :base(Fields.CustomTags.SecurityListRequestType) {}
        public SecurityListRequestType(int val)
            :base(Fields.CustomTags.SecurityListRequestType, val) {}


        // Field Enumerations
        public const int SYMBOL = 0;
        public const int SECURITYTYPE_AND_OR_CFICODE = 1;
        public const int PRODUCT = 2;
        public const int TRADINGSESSIONID = 3;
        public const int ALL_SECURITIES = 4;
        public const int MARKETID_OR_MARKETID_PLUS_MARKETSEGMENTID = 5;
        public const int SECURITYTYPE_AND = 1;
    }


    /// <summary>
    /// SecurityRequestResult Field
    /// </summary>/
    public sealed class SecurityRequestResult : QuickFix.Fields.IntField
    {
        public SecurityRequestResult()
            :base(Fields.CustomTags.SecurityRequestResult) {}
        public SecurityRequestResult(int val)
            :base(Fields.CustomTags.SecurityRequestResult, val) {}


        // Field Enumerations
        public const int VALID_REQUEST = 0;
        public const int INVALID_OR_UNSUPPORTED_REQUEST = 1;
        public const int NO_INSTRUMENTS_FOUND_THAT_MATCH_SELECTION_CRITERIA = 2;
        public const int NOT_AUTHORIZED_TO_RETRIEVE_INSTRUMENT_DATA = 3;
        public const int INSTRUMENT_DATA_TEMPORARILY_UNAVAILABLE = 4;
        public const int REQUEST_FOR_INSTRUMENT_DATA_NOT_SUPPORTED = 5;
    }


    /// <summary>
    /// RoundLot Field
    /// </summary>/
    public sealed class RoundLot : QuickFix.Fields.DecimalField
    {
        public RoundLot()
            :base(Fields.CustomTags.RoundLot) {}
        public RoundLot(Decimal val)
            :base(Fields.CustomTags.RoundLot, val) {}

    }


    /// <summary>
    /// MinTradeVol Field
    /// </summary>/
    public sealed class MinTradeVol : QuickFix.Fields.DecimalField
    {
        public MinTradeVol()
            :base(Fields.CustomTags.MinTradeVol) {}
        public MinTradeVol(Decimal val)
            :base(Fields.CustomTags.MinTradeVol, val) {}

    }


    /// <summary>
    /// MultiLegRptTypeReq Field
    /// </summary>/
    public sealed class MultiLegRptTypeReq : QuickFix.Fields.IntField
    {
        public MultiLegRptTypeReq()
            :base(Fields.CustomTags.MultiLegRptTypeReq) {}
        public MultiLegRptTypeReq(int val)
            :base(Fields.CustomTags.MultiLegRptTypeReq, val) {}


        // Field Enumerations
        public const int REPORT_BY_MULITLEG_SECURITY_ONLY = 0;
        public const int REPORT_BY_MULTILEG_SECURITY_AND_BY_INSTRUMENT_LEGS_BELONGING_TO_THE_MULTILEG_SECURITY = 1;
        public const int REPORT_BY_INSTRUMENT_LEGS_BELONGING_TO_THE_MULTILEG_SECURITY_ONLY = 2;
    }


    /// <summary>
    /// LegPositionEffect Field
    /// </summary>/
    public sealed class LegPositionEffect : QuickFix.Fields.CharField
    {
        public LegPositionEffect()
            :base(Fields.CustomTags.LegPositionEffect) {}
        public LegPositionEffect(char val)
            :base(Fields.CustomTags.LegPositionEffect, val) {}

    }


    /// <summary>
    /// LegCoveredOrUncovered Field
    /// </summary>/
    public sealed class LegCoveredOrUncovered : QuickFix.Fields.IntField
    {
        public LegCoveredOrUncovered()
            :base(Fields.CustomTags.LegCoveredOrUncovered) {}
        public LegCoveredOrUncovered(int val)
            :base(Fields.CustomTags.LegCoveredOrUncovered, val) {}

    }


    /// <summary>
    /// LegPrice Field
    /// </summary>/
    public sealed class LegPrice : QuickFix.Fields.DecimalField
    {
        public LegPrice()
            :base(Fields.CustomTags.LegPrice) {}
        public LegPrice(Decimal val)
            :base(Fields.CustomTags.LegPrice, val) {}

    }


    /// <summary>
    /// TradSesStatusRejReason Field
    /// </summary>/
    public sealed class TradSesStatusRejReason : QuickFix.Fields.IntField
    {
        public TradSesStatusRejReason()
            :base(Fields.CustomTags.TradSesStatusRejReason) {}
        public TradSesStatusRejReason(int val)
            :base(Fields.CustomTags.TradSesStatusRejReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_OR_INVALID_TRADINGSESSIONID = 1;
        public const int OTHER = 99;
    }


    /// <summary>
    /// TradeRequestID Field
    /// </summary>/
    public sealed class TradeRequestID : QuickFix.Fields.StringField
    {
        public TradeRequestID()
            :base(Fields.CustomTags.TradeRequestID) {}
        public TradeRequestID(string val)
            :base(Fields.CustomTags.TradeRequestID, val) {}

    }


    /// <summary>
    /// TradeRequestType Field
    /// </summary>/
    public sealed class TradeRequestType : QuickFix.Fields.IntField
    {
        public TradeRequestType()
            :base(Fields.CustomTags.TradeRequestType) {}
        public TradeRequestType(int val)
            :base(Fields.CustomTags.TradeRequestType, val) {}


        // Field Enumerations
        public const int ALL_TRADES = 0;
        public const int MATCHED_TRADES_MATCHING_CRITERIA_PROVIDED_ON_REQUEST = 1;
        public const int UNMATCHED_TRADES_THAT_MATCH_CRITERIA = 2;
        public const int UNREPORTED_TRADES_THAT_MATCH_CRITERIA = 3;
        public const int ADVISORIES_THAT_MATCH_CRITERIA = 4;
    }


    /// <summary>
    /// PreviouslyReported Field
    /// </summary>/
    public sealed class PreviouslyReported : QuickFix.Fields.BooleanField
    {
        public PreviouslyReported()
            :base(Fields.CustomTags.PreviouslyReported) {}
        public PreviouslyReported(Boolean val)
            :base(Fields.CustomTags.PreviouslyReported, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean NOT_REPORTED_TO_COUNTERPARTY = false;
        public const Boolean PERVIOUSLY_REPORTED_TO_COUNTERPARTY = true;
    }


    /// <summary>
    /// TradeReportID Field
    /// </summary>/
    public sealed class TradeReportID : QuickFix.Fields.StringField
    {
        public TradeReportID()
            :base(Fields.CustomTags.TradeReportID) {}
        public TradeReportID(string val)
            :base(Fields.CustomTags.TradeReportID, val) {}

    }


    /// <summary>
    /// TradeReportRefID Field
    /// </summary>/
    public sealed class TradeReportRefID : QuickFix.Fields.StringField
    {
        public TradeReportRefID()
            :base(Fields.CustomTags.TradeReportRefID) {}
        public TradeReportRefID(string val)
            :base(Fields.CustomTags.TradeReportRefID, val) {}

    }


    /// <summary>
    /// MatchStatus Field
    /// </summary>/
    public sealed class MatchStatus : QuickFix.Fields.CharField
    {
        public MatchStatus()
            :base(Fields.CustomTags.MatchStatus) {}
        public MatchStatus(char val)
            :base(Fields.CustomTags.MatchStatus, val) {}


        // Field Enumerations
        public const char COMPARED_MATCHED_OR_AFFIRMED = '0';
        public const char UNCOMPARED_UNMATCHED_OR_UNAFFIRMED = '1';
        public const char ADVISORY_OR_ALERT = '2';
        public const char UNCOMPARED_UNMATCHED_OR_UNAFFIRED = '1';
        public const char COMPARED = '0';
        public const char UNCOMPARED = '1';
    }


    /// <summary>
    /// MatchType Field
    /// </summary>/
    public sealed class MatchType : QuickFix.Fields.StringField
    {
        public MatchType()
            :base(Fields.CustomTags.MatchType) {}
        public MatchType(string val)
            :base(Fields.CustomTags.MatchType, val) {}


        // Field Enumerations
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_FOUR_BADGES_AND_EXECUTION_TIME = "A1";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_FOUR_BADGES = "A2";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_TWO_BADGES_AND_EXECUTION_TIME = "A3";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_TWO_BADGES = "A4";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADETYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_EXECUTION_TIME = "A5";
        public const string ACT_ACCEPTED_TRADE = "M3";
        public const string ACT_DEFAULT_TRADE = "M4";
        public const string ACT_DEFAULT_AFTER_M2 = "M5";
        public const string ACT_M6_MATCH = "M6";
        public const string COMPARED_RECORDS_RESULTING_FROM_STAMPED_ADVISORIES_OR_SPECIALIST_ACCEPTS_PAIR_OFFS = "AQ";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_MINUS_BADGES_AND_TIMES_ACT_M1_MATCH = "M1";
        public const string SUMMARIZED_MATCH_MINUS_BADGES_AND_TIMES_ACT_M2_MATCH = "M2";
        public const string OCS_LOCKED_IN_NON_ACT = "MT";
        public const string SUMMARIZED_MATCH_USING_A1_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIED = "S1";
        public const string SUMMARIZED_MATCH_USING_A2_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S2";
        public const string SUMMARIZED_MATCH_USING_A3_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S3";
        public const string SUMMARIZED_MATCH_USING_A4_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S4";
        public const string SUMMARIZED_MATCH_USING_A5_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S5";
        public const string ONE_PARTY_TRADE_REPORT = "1";
        public const string TWO_PARTY_TRADE_REPORT = "2";
        public const string CONFIRMED_TRADE_REPORT = "3";
        public const string AUTO_MATCH = "4";
        public const string CROSS_AUCTION = "5";
        public const string COUNTER_ORDER_SELECTION = "6";
        public const string CALL_AUCTION = "7";
        public const string ISSUING_BUY_BACK_AUCTION = "8";
        public const string ONE_PARTY_PRIVATELY_NEGOTIATED_TRADE_REPORT = "60";
        public const string TWO_PARTY_PRIVATELY_NEGOTIATED_TRADE_REPORT = "61";
        public const string CONTINUOUS_AUTO_MATCH = "62";
        public const string CROSS_AUCTION_63 = "63";
        public const string COUNTER_ORDER_SELECTION_64 = "64";
        public const string CALL_AUCTION_65 = "65";
        public const string CROSS_AUCTION_5 = "5";
        public const string COUNTER_ORDER_SELECTION_6 = "6";
        public const string CALL_AUCTION_7 = "7";
        public const string EXACT_MATCH_PLUS_FOUR_BADGES_AND_EXECUTION_TIME = "A1";
        public const string EXACT_MATCH_PLUS_FOUR_BADGES = "A2";
        public const string EXACT_MATCH_PLUS_TWO_BADGES_AND_EXECUTION_TIME = "A3";
        public const string EXACT_MATCH_PLUS_TWO_BADGES = "A4";
        public const string EXACT_MATCH_PLUS_EXECUTION_TIME = "A5";
        public const string COMPARED_RECORDS_RESULTING_FROM_STAMPED_ADVISORIES_OR_SPECIALIST_ACCEPTS = "AQ";
        public const string SUMMARIZED_MATCH_USING_A1 = "S1";
        public const string SUMMARIZED_MATCH_USING_A2 = "S2";
        public const string SUMMARIZED_MATCH_USING_A3 = "S3";
        public const string SUMMARIZED_MATCH_USING_A4 = "S4";
        public const string SUMMARIZED_MATCH_USING_A5 = "S5";
        public const string EXACT_MATCH_MINUS_BADGES_AND_EXECUTION_TIME = "M1";
        public const string SUMMARIZED_MATCH_MINUS_BADGES_AND_TIMES = "M2";
        public const string OCS_LOCKED_IN = "MT";
        public const string ACT_M1_MATCH = "M1";
        public const string ACT_M2_MATCH = "M2";
        public const string NON_ACT = "MT";
    }


    /// <summary>
    /// OddLot Field
    /// </summary>/
    public sealed class OddLot : QuickFix.Fields.BooleanField
    {
        public OddLot()
            :base(Fields.CustomTags.OddLot) {}
        public OddLot(Boolean val)
            :base(Fields.CustomTags.OddLot, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// NoClearingInstructions Field
    /// </summary>/
    public sealed class NoClearingInstructions : QuickFix.Fields.IntField
    {
        public NoClearingInstructions()
            :base(Fields.CustomTags.NoClearingInstructions) {}
        public NoClearingInstructions(int val)
            :base(Fields.CustomTags.NoClearingInstructions, val) {}

    }


    /// <summary>
    /// ClearingInstruction Field
    /// </summary>/
    public sealed class ClearingInstruction : QuickFix.Fields.IntField
    {
        public ClearingInstruction()
            :base(Fields.CustomTags.ClearingInstruction) {}
        public ClearingInstruction(int val)
            :base(Fields.CustomTags.ClearingInstruction, val) {}


        // Field Enumerations
        public const int PROCESS_NORMALLY = 0;
        public const int EXCLUDE_FROM_ALL_NETTING = 1;
        public const int AUTOMATIC_GIVE_UP_MODE = 10;
        public const int QUALIFIED_SERVICE_REPRESENTATIVE_QSR = 11;
        public const int CUSTOMER_TRADE = 12;
        public const int SELF_CLEARING = 13;
        public const int BILATERAL_NETTING_ONLY = 2;
        public const int EX_CLEARING = 3;
        public const int SPECIAL_TRADE = 4;
        public const int MULTILATERAL_NETTING = 5;
        public const int CLEAR_AGAINST_CENTRAL_COUNTERPARTY = 6;
        public const int EXCLUDE_FROM_CENTRAL_COUNTERPARTY = 7;
        public const int MANUAL_MODE = 8;
        public const int AUTOMATIC_POSTING_MODE = 9;
    }


    /// <summary>
    /// TradeInputSource Field
    /// </summary>/
    public sealed class TradeInputSource : QuickFix.Fields.StringField
    {
        public TradeInputSource()
            :base(Fields.CustomTags.TradeInputSource) {}
        public TradeInputSource(string val)
            :base(Fields.CustomTags.TradeInputSource, val) {}

    }


    /// <summary>
    /// TradeInputDevice Field
    /// </summary>/
    public sealed class TradeInputDevice : QuickFix.Fields.StringField
    {
        public TradeInputDevice()
            :base(Fields.CustomTags.TradeInputDevice) {}
        public TradeInputDevice(string val)
            :base(Fields.CustomTags.TradeInputDevice, val) {}

    }


    /// <summary>
    /// NoDates Field
    /// </summary>/
    public sealed class NoDates : QuickFix.Fields.IntField
    {
        public NoDates()
            :base(Fields.CustomTags.NoDates) {}
        public NoDates(int val)
            :base(Fields.CustomTags.NoDates, val) {}

    }


    /// <summary>
    /// AccountType Field
    /// </summary>/
    public sealed class AccountType : QuickFix.Fields.IntField
    {
        public AccountType()
            :base(Fields.CustomTags.AccountType) {}
        public AccountType(int val)
            :base(Fields.CustomTags.AccountType, val) {}


        // Field Enumerations
        public const int ACCOUNT_IS_CARRIED_ON_CUSTOMER_SIDE_OF_THE_BOOKS = 1;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS = 2;
        public const int HOUSE_TRADER = 3;
        public const int FLOOR_TRADER = 4;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS_AND_IS_CROSS_MARGINED = 6;
        public const int ACCOUNT_IS_HOUSE_TRADER_AND_IS_CROSS_MARGINED = 7;
        public const int JOINT_BACK_OFFICE_ACCOUNT = 8;
        public const int ACCOUNT_IS_CARRIED_ON_CUSTOMER_SIDE_OF_BOOKS = 1;
        public const int JOINT_BACKOFFICE_ACCOUNT = 8;
    }


    /// <summary>
    /// CustOrderCapacity Field
    /// </summary>/
    public sealed class CustOrderCapacity : QuickFix.Fields.IntField
    {
        public CustOrderCapacity()
            :base(Fields.CustomTags.CustOrderCapacity) {}
        public CustOrderCapacity(int val)
            :base(Fields.CustomTags.CustOrderCapacity, val) {}


        // Field Enumerations
        public const int MEMBER_TRADING_FOR_THEIR_OWN_ACCOUNT = 1;
        public const int CLEARING_FIRM_TRADING_FOR_ITS_PROPRIETARY_ACCOUNT = 2;
        public const int MEMBER_TRADING_FOR_ANOTHER_MEMBER = 3;
        public const int ALL_OTHER = 4;
    }


    /// <summary>
    /// ClOrdLinkID Field
    /// </summary>/
    public sealed class ClOrdLinkID : QuickFix.Fields.StringField
    {
        public ClOrdLinkID()
            :base(Fields.CustomTags.ClOrdLinkID) {}
        public ClOrdLinkID(string val)
            :base(Fields.CustomTags.ClOrdLinkID, val) {}

    }


    /// <summary>
    /// MassStatusReqID Field
    /// </summary>/
    public sealed class MassStatusReqID : QuickFix.Fields.StringField
    {
        public MassStatusReqID()
            :base(Fields.CustomTags.MassStatusReqID) {}
        public MassStatusReqID(string val)
            :base(Fields.CustomTags.MassStatusReqID, val) {}

    }


    /// <summary>
    /// MassStatusReqType Field
    /// </summary>/
    public sealed class MassStatusReqType : QuickFix.Fields.IntField
    {
        public MassStatusReqType()
            :base(Fields.CustomTags.MassStatusReqType) {}
        public MassStatusReqType(int val)
            :base(Fields.CustomTags.MassStatusReqType, val) {}


        // Field Enumerations
        public const int STATUS_FOR_ORDERS_FOR_A_SECURITY = 1;
        public const int STATUS_FOR_ORDERS_FOR_AN_UNDERLYING_SECURITY = 2;
        public const int STATUS_FOR_ORDERS_FOR_A_PRODUCT = 3;
        public const int STATUS_FOR_ORDERS_FOR_A_CFICODE = 4;
        public const int STATUS_FOR_ORDERS_FOR_A_SECURITYTYPE = 5;
        public const int STATUS_FOR_ORDERS_FOR_A_TRADING_SESSION = 6;
        public const int STATUS_FOR_ALL_ORDERS = 7;
        public const int STATUS_FOR_ORDERS_FOR_A_PARTYID = 8;
        public const int STATUS_FOR_SECURITY_ISSUER = 9;
        public const int STATUS_FOR_ISSUER_OF_UNDERLYING_SECURITY = 10;
    }


    /// <summary>
    /// OrigOrdModTime Field
    /// </summary>/
    public sealed class OrigOrdModTime : QuickFix.Fields.DateTimeField
    {
        public OrigOrdModTime()
            :base(Fields.CustomTags.OrigOrdModTime) {}
        public OrigOrdModTime(DateTime val)
            :base(Fields.CustomTags.OrigOrdModTime, val) {}
        public OrigOrdModTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.OrigOrdModTime, val, showMilliseconds) {}
		public OrigOrdModTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.OrigOrdModTime, val, precision) {}

    }


    /// <summary>
    /// LegSettlmntTyp Field
    /// </summary>/
    public sealed class LegSettlmntTyp : QuickFix.Fields.CharField
    {
        public LegSettlmntTyp()
            :base(Fields.CustomTags.LegSettlmntTyp) {}
        public LegSettlmntTyp(char val)
            :base(Fields.CustomTags.LegSettlmntTyp, val) {}

    }


    /// <summary>
    /// LegFutSettDate Field
    /// </summary>/
    public sealed class LegFutSettDate : QuickFix.Fields.StringField
    {
        public LegFutSettDate()
            :base(Fields.CustomTags.LegFutSettDate) {}
        public LegFutSettDate(string val)
            :base(Fields.CustomTags.LegFutSettDate, val) {}

    }


    /// <summary>
    /// DayBookingInst Field
    /// </summary>/
    public sealed class DayBookingInst : QuickFix.Fields.CharField
    {
        public DayBookingInst()
            :base(Fields.CustomTags.DayBookingInst) {}
        public DayBookingInst(char val)
            :base(Fields.CustomTags.DayBookingInst, val) {}


        // Field Enumerations
        public const char CAN_TRIGGER_BOOKING_WITHOUT_REFERENCE_TO_THE_ORDER_INITIATOR = '0';
        public const char SPEAK_WITH_ORDER_INITIATOR_BEFORE_BOOKING = '1';
        public const char ACCUMULATE = '2';
    }


    /// <summary>
    /// BookingUnit Field
    /// </summary>/
    public sealed class BookingUnit : QuickFix.Fields.CharField
    {
        public BookingUnit()
            :base(Fields.CustomTags.BookingUnit) {}
        public BookingUnit(char val)
            :base(Fields.CustomTags.BookingUnit, val) {}


        // Field Enumerations
        public const char EACH_PARTIAL_EXECUTION_IS_A_BOOKABLE_UNIT = '0';
        public const char AGGREGATE_PARTIAL_EXECUTIONS_ON_THIS_ORDER_AND_BOOK_ONE_TRADE_PER_ORDER = '1';
        public const char AGGREGATE_EXECUTIONS_FOR_THIS_SYMBOL_SIDE_AND_SETTLEMENT_DATE = '2';
    }


    /// <summary>
    /// PreallocMethod Field
    /// </summary>/
    public sealed class PreallocMethod : QuickFix.Fields.CharField
    {
        public PreallocMethod()
            :base(Fields.CustomTags.PreallocMethod) {}
        public PreallocMethod(char val)
            :base(Fields.CustomTags.PreallocMethod, val) {}


        // Field Enumerations
        public const char PRO_RATA = '0';
        public const char DO_NOT_PRO_RATA = '1';
    }


    /// <summary>
    /// UnderlyingCountryOfIssue Field
    /// </summary>/
    public sealed class UnderlyingCountryOfIssue : QuickFix.Fields.StringField
    {
        public UnderlyingCountryOfIssue()
            :base(Fields.CustomTags.UnderlyingCountryOfIssue) {}
        public UnderlyingCountryOfIssue(string val)
            :base(Fields.CustomTags.UnderlyingCountryOfIssue, val) {}

    }


    /// <summary>
    /// UnderlyingStateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class UnderlyingStateOrProvinceOfIssue : QuickFix.Fields.StringField
    {
        public UnderlyingStateOrProvinceOfIssue()
            :base(Fields.CustomTags.UnderlyingStateOrProvinceOfIssue) {}
        public UnderlyingStateOrProvinceOfIssue(string val)
            :base(Fields.CustomTags.UnderlyingStateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// UnderlyingLocaleOfIssue Field
    /// </summary>/
    public sealed class UnderlyingLocaleOfIssue : QuickFix.Fields.StringField
    {
        public UnderlyingLocaleOfIssue()
            :base(Fields.CustomTags.UnderlyingLocaleOfIssue) {}
        public UnderlyingLocaleOfIssue(string val)
            :base(Fields.CustomTags.UnderlyingLocaleOfIssue, val) {}

    }


    /// <summary>
    /// UnderlyingInstrRegistry Field
    /// </summary>/
    public sealed class UnderlyingInstrRegistry : QuickFix.Fields.StringField
    {
        public UnderlyingInstrRegistry()
            :base(Fields.CustomTags.UnderlyingInstrRegistry) {}
        public UnderlyingInstrRegistry(string val)
            :base(Fields.CustomTags.UnderlyingInstrRegistry, val) {}

    }


    /// <summary>
    /// LegCountryOfIssue Field
    /// </summary>/
    public sealed class LegCountryOfIssue : QuickFix.Fields.StringField
    {
        public LegCountryOfIssue()
            :base(Fields.CustomTags.LegCountryOfIssue) {}
        public LegCountryOfIssue(string val)
            :base(Fields.CustomTags.LegCountryOfIssue, val) {}

    }


    /// <summary>
    /// LegStateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class LegStateOrProvinceOfIssue : QuickFix.Fields.StringField
    {
        public LegStateOrProvinceOfIssue()
            :base(Fields.CustomTags.LegStateOrProvinceOfIssue) {}
        public LegStateOrProvinceOfIssue(string val)
            :base(Fields.CustomTags.LegStateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// LegLocaleOfIssue Field
    /// </summary>/
    public sealed class LegLocaleOfIssue : QuickFix.Fields.StringField
    {
        public LegLocaleOfIssue()
            :base(Fields.CustomTags.LegLocaleOfIssue) {}
        public LegLocaleOfIssue(string val)
            :base(Fields.CustomTags.LegLocaleOfIssue, val) {}

    }


    /// <summary>
    /// LegInstrRegistry Field
    /// </summary>/
    public sealed class LegInstrRegistry : QuickFix.Fields.StringField
    {
        public LegInstrRegistry()
            :base(Fields.CustomTags.LegInstrRegistry) {}
        public LegInstrRegistry(string val)
            :base(Fields.CustomTags.LegInstrRegistry, val) {}

    }


    /// <summary>
    /// LegSymbol Field
    /// </summary>/
    public sealed class LegSymbol : QuickFix.Fields.StringField
    {
        public LegSymbol()
            :base(Fields.CustomTags.LegSymbol) {}
        public LegSymbol(string val)
            :base(Fields.CustomTags.LegSymbol, val) {}

    }


    /// <summary>
    /// LegSymbolSfx Field
    /// </summary>/
    public sealed class LegSymbolSfx : QuickFix.Fields.StringField
    {
        public LegSymbolSfx()
            :base(Fields.CustomTags.LegSymbolSfx) {}
        public LegSymbolSfx(string val)
            :base(Fields.CustomTags.LegSymbolSfx, val) {}

    }


    /// <summary>
    /// LegSecurityID Field
    /// </summary>/
    public sealed class LegSecurityID : QuickFix.Fields.StringField
    {
        public LegSecurityID()
            :base(Fields.CustomTags.LegSecurityID) {}
        public LegSecurityID(string val)
            :base(Fields.CustomTags.LegSecurityID, val) {}

    }


    /// <summary>
    /// LegSecurityIDSource Field
    /// </summary>/
    public sealed class LegSecurityIDSource : QuickFix.Fields.StringField
    {
        public LegSecurityIDSource()
            :base(Fields.CustomTags.LegSecurityIDSource) {}
        public LegSecurityIDSource(string val)
            :base(Fields.CustomTags.LegSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoLegSecurityAltID Field
    /// </summary>/
    public sealed class NoLegSecurityAltID : QuickFix.Fields.StringField
    {
        public NoLegSecurityAltID()
            :base(Fields.CustomTags.NoLegSecurityAltID) {}
        public NoLegSecurityAltID(string val)
            :base(Fields.CustomTags.NoLegSecurityAltID, val) {}

    }


    /// <summary>
    /// LegSecurityAltID Field
    /// </summary>/
    public sealed class LegSecurityAltID : QuickFix.Fields.StringField
    {
        public LegSecurityAltID()
            :base(Fields.CustomTags.LegSecurityAltID) {}
        public LegSecurityAltID(string val)
            :base(Fields.CustomTags.LegSecurityAltID, val) {}

    }


    /// <summary>
    /// LegSecurityAltIDSource Field
    /// </summary>/
    public sealed class LegSecurityAltIDSource : QuickFix.Fields.StringField
    {
        public LegSecurityAltIDSource()
            :base(Fields.CustomTags.LegSecurityAltIDSource) {}
        public LegSecurityAltIDSource(string val)
            :base(Fields.CustomTags.LegSecurityAltIDSource, val) {}


        // Field Enumerations
        public const string ISIN_NUMBER = "4";
        public const string RIC_CODE = "5";
        public const string EXCHANGE_SECURITY_ID = "8";
        public const string ALT_SYMBOL = "94";
        public const string CLEARPORT = "95";
        public const string ALIAS = "97";
        public const string NAME = "98";
        public const string SECURITY_GROUP = "99";
        public const string EXCHANGE_TICKER = "91";
    }


    /// <summary>
    /// LegProduct Field
    /// </summary>/
    public sealed class LegProduct : QuickFix.Fields.IntField
    {
        public LegProduct()
            :base(Fields.CustomTags.LegProduct) {}
        public LegProduct(int val)
            :base(Fields.CustomTags.LegProduct, val) {}


        // Field Enumerations
        public const int AGENCY = 1;
        public const int COMMODITY = 2;
        public const int CORPORATE = 3;
        public const int CURRENCY = 4;
        public const int EQUITY = 5;
        public const int GOVERNMENT = 6;
        public const int INDEX = 7;
        public const int LOAN = 8;
        public const int MONEYMARKET = 9;
        public const int MORTGAGE = 10;
        public const int MUNICIPAL = 11;
        public const int OTHER = 12;
        public const int FINANCING = 13;
        public const int ENERGY = 14;
    }


    /// <summary>
    /// LegCFICode Field
    /// </summary>/
    public sealed class LegCFICode : QuickFix.Fields.StringField
    {
        public LegCFICode()
            :base(Fields.CustomTags.LegCFICode) {}
        public LegCFICode(string val)
            :base(Fields.CustomTags.LegCFICode, val) {}

    }


    /// <summary>
    /// LegSecurityType Field
    /// </summary>/
    public sealed class LegSecurityType : QuickFix.Fields.StringField
    {
        public LegSecurityType()
            :base(Fields.CustomTags.LegSecurityType) {}
        public LegSecurityType(string val)
            :base(Fields.CustomTags.LegSecurityType, val) {}


        // Field Enumerations
        public const string FUTURE = "FUT";
        public const string OPTION = "OPT";
        public const string SPREAD = "MLEG";
        public const string SPOT = "SPOT";
        public const string TBOND = "TBOND";
        public const string COMMON_STOCK = "CS";
        public const string NONE = "NONE";
    }


    /// <summary>
    /// LegMaturityMonthYear Field
    /// </summary>/
    public sealed class LegMaturityMonthYear : QuickFix.Fields.StringField
    {
        public LegMaturityMonthYear()
            :base(Fields.CustomTags.LegMaturityMonthYear) {}
        public LegMaturityMonthYear(string val)
            :base(Fields.CustomTags.LegMaturityMonthYear, val) {}

    }


    /// <summary>
    /// LegMaturityDate Field
    /// </summary>/
    public sealed class LegMaturityDate : QuickFix.Fields.StringField
    {
        public LegMaturityDate()
            :base(Fields.CustomTags.LegMaturityDate) {}
        public LegMaturityDate(string val)
            :base(Fields.CustomTags.LegMaturityDate, val) {}

    }


    /// <summary>
    /// LegStrikePrice Field
    /// </summary>/
    public sealed class LegStrikePrice : QuickFix.Fields.DecimalField
    {
        public LegStrikePrice()
            :base(Fields.CustomTags.LegStrikePrice) {}
        public LegStrikePrice(Decimal val)
            :base(Fields.CustomTags.LegStrikePrice, val) {}

    }


    /// <summary>
    /// LegOptAttribute Field
    /// </summary>/
    public sealed class LegOptAttribute : QuickFix.Fields.CharField
    {
        public LegOptAttribute()
            :base(Fields.CustomTags.LegOptAttribute) {}
        public LegOptAttribute(char val)
            :base(Fields.CustomTags.LegOptAttribute, val) {}

    }


    /// <summary>
    /// LegContractMultiplier Field
    /// </summary>/
    public sealed class LegContractMultiplier : QuickFix.Fields.DecimalField
    {
        public LegContractMultiplier()
            :base(Fields.CustomTags.LegContractMultiplier) {}
        public LegContractMultiplier(Decimal val)
            :base(Fields.CustomTags.LegContractMultiplier, val) {}

    }


    /// <summary>
    /// LegCouponRate Field
    /// </summary>/
    public sealed class LegCouponRate : QuickFix.Fields.DecimalField
    {
        public LegCouponRate()
            :base(Fields.CustomTags.LegCouponRate) {}
        public LegCouponRate(Decimal val)
            :base(Fields.CustomTags.LegCouponRate, val) {}

    }


    /// <summary>
    /// LegSecurityExchange Field
    /// </summary>/
    public sealed class LegSecurityExchange : QuickFix.Fields.StringField
    {
        public LegSecurityExchange()
            :base(Fields.CustomTags.LegSecurityExchange) {}
        public LegSecurityExchange(string val)
            :base(Fields.CustomTags.LegSecurityExchange, val) {}

    }


    /// <summary>
    /// LegIssuer Field
    /// </summary>/
    public sealed class LegIssuer : QuickFix.Fields.StringField
    {
        public LegIssuer()
            :base(Fields.CustomTags.LegIssuer) {}
        public LegIssuer(string val)
            :base(Fields.CustomTags.LegIssuer, val) {}

    }


    /// <summary>
    /// EncodedLegIssuerLen Field
    /// </summary>/
    public sealed class EncodedLegIssuerLen : QuickFix.Fields.IntField
    {
        public EncodedLegIssuerLen()
            :base(Fields.CustomTags.EncodedLegIssuerLen) {}
        public EncodedLegIssuerLen(int val)
            :base(Fields.CustomTags.EncodedLegIssuerLen, val) {}

    }


    /// <summary>
    /// EncodedLegIssuer Field
    /// </summary>/
    public sealed class EncodedLegIssuer : QuickFix.Fields.StringField
    {
        public EncodedLegIssuer()
            :base(Fields.CustomTags.EncodedLegIssuer) {}
        public EncodedLegIssuer(string val)
            :base(Fields.CustomTags.EncodedLegIssuer, val) {}

    }


    /// <summary>
    /// LegSecurityDesc Field
    /// </summary>/
    public sealed class LegSecurityDesc : QuickFix.Fields.StringField
    {
        public LegSecurityDesc()
            :base(Fields.CustomTags.LegSecurityDesc) {}
        public LegSecurityDesc(string val)
            :base(Fields.CustomTags.LegSecurityDesc, val) {}

    }


    /// <summary>
    /// EncodedLegSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedLegSecurityDescLen : QuickFix.Fields.IntField
    {
        public EncodedLegSecurityDescLen()
            :base(Fields.CustomTags.EncodedLegSecurityDescLen) {}
        public EncodedLegSecurityDescLen(int val)
            :base(Fields.CustomTags.EncodedLegSecurityDescLen, val) {}

    }


    /// <summary>
    /// EncodedLegSecurityDesc Field
    /// </summary>/
    public sealed class EncodedLegSecurityDesc : QuickFix.Fields.StringField
    {
        public EncodedLegSecurityDesc()
            :base(Fields.CustomTags.EncodedLegSecurityDesc) {}
        public EncodedLegSecurityDesc(string val)
            :base(Fields.CustomTags.EncodedLegSecurityDesc, val) {}

    }


    /// <summary>
    /// LegRatioQty Field
    /// </summary>/
    public sealed class LegRatioQty : QuickFix.Fields.DecimalField
    {
        public LegRatioQty()
            :base(Fields.CustomTags.LegRatioQty) {}
        public LegRatioQty(Decimal val)
            :base(Fields.CustomTags.LegRatioQty, val) {}

    }


    /// <summary>
    /// LegSide Field
    /// </summary>/
    public sealed class LegSide : QuickFix.Fields.CharField
    {
        public LegSide()
            :base(Fields.CustomTags.LegSide) {}
        public LegSide(char val)
            :base(Fields.CustomTags.LegSide, val) {}

    }


    /// <summary>
    /// TradingSessionSubID Field
    /// </summary>/
    public sealed class TradingSessionSubID : QuickFix.Fields.StringField
    {
        public TradingSessionSubID()
            :base(Fields.CustomTags.TradingSessionSubID) {}
        public TradingSessionSubID(string val)
            :base(Fields.CustomTags.TradingSessionSubID, val) {}


        // Field Enumerations
        public const string PRE_TRADING = "1";
        public const string OPENING_OR_OPENING_AUCTION = "2";
        public const string VAL_3 = "3";
        public const string CLOSING_OR_CLOSING_AUCTION = "4";
        public const string POST_TRADING = "5";
        public const string INTRADAY_AUCTION = "6";
        public const string QUIESCENT = "7";
    }


    /// <summary>
    /// AllocType Field
    /// </summary>/
    public sealed class AllocType : QuickFix.Fields.IntField
    {
        public AllocType()
            :base(Fields.CustomTags.AllocType) {}
        public AllocType(int val)
            :base(Fields.CustomTags.AllocType, val) {}


        // Field Enumerations
        public const int CALCULATED = 1;
        public const int PRELIMINARY = 2;
        public const int SELLSIDE_CALCULATED_USING_PRELIMINARY = 3;
        public const int SELLSIDE_CALCULATED_WITHOUT_PRELIMINARY = 4;
        public const int READY_TO_BOOK = 5;
        public const int BUYSIDE_READY_TO_BOOK = 6;
        public const int WAREHOUSE_INSTRUCTION = 7;
        public const int REQUEST_TO_INTERMEDIARY = 8;
        public const int ACCEPT = 9;
        public const int REJECT = 10;
        public const int ACCEPT_PENDING = 11;
        public const int INCOMPLETE_GROUP = 12;
        public const int COMPLETE_GROUP = 13;
        public const int REVERSAL_PENDING = 14;
        public const int BUYSIDE_CALCULATED = 1;
        public const int BUYSIDE_PRELIMINARY = 2;
        public const int BUYSIDE_READY_TO_BOOK_SINGLE_ORDER = 5;
        public const int BUYSIDE_READY_TO_BOOK_COMBINED_SET_OF_ORDERS = 6;
    }


    /// <summary>
    /// NoHops Field
    /// </summary>/
    public sealed class NoHops : QuickFix.Fields.IntField
    {
        public NoHops()
            :base(Fields.CustomTags.NoHops) {}
        public NoHops(int val)
            :base(Fields.CustomTags.NoHops, val) {}

    }


    /// <summary>
    /// HopCompID Field
    /// </summary>/
    public sealed class HopCompID : QuickFix.Fields.StringField
    {
        public HopCompID()
            :base(Fields.CustomTags.HopCompID) {}
        public HopCompID(string val)
            :base(Fields.CustomTags.HopCompID, val) {}

    }


    /// <summary>
    /// HopSendingTime Field
    /// </summary>/
    public sealed class HopSendingTime : QuickFix.Fields.DateTimeField
    {
        public HopSendingTime()
            :base(Fields.CustomTags.HopSendingTime) {}
        public HopSendingTime(DateTime val)
            :base(Fields.CustomTags.HopSendingTime, val) {}
        public HopSendingTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.HopSendingTime, val, showMilliseconds) {}
		public HopSendingTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.HopSendingTime, val, precision) {}

    }


    /// <summary>
    /// HopRefID Field
    /// </summary>/
    public sealed class HopRefID : QuickFix.Fields.IntField
    {
        public HopRefID()
            :base(Fields.CustomTags.HopRefID) {}
        public HopRefID(int val)
            :base(Fields.CustomTags.HopRefID, val) {}

    }


    /// <summary>
    /// MidPx Field
    /// </summary>/
    public sealed class MidPx : QuickFix.Fields.DecimalField
    {
        public MidPx()
            :base(Fields.CustomTags.MidPx) {}
        public MidPx(Decimal val)
            :base(Fields.CustomTags.MidPx, val) {}

    }


    /// <summary>
    /// BidYield Field
    /// </summary>/
    public sealed class BidYield : QuickFix.Fields.DecimalField
    {
        public BidYield()
            :base(Fields.CustomTags.BidYield) {}
        public BidYield(Decimal val)
            :base(Fields.CustomTags.BidYield, val) {}

    }


    /// <summary>
    /// MidYield Field
    /// </summary>/
    public sealed class MidYield : QuickFix.Fields.DecimalField
    {
        public MidYield()
            :base(Fields.CustomTags.MidYield) {}
        public MidYield(Decimal val)
            :base(Fields.CustomTags.MidYield, val) {}

    }


    /// <summary>
    /// OfferYield Field
    /// </summary>/
    public sealed class OfferYield : QuickFix.Fields.DecimalField
    {
        public OfferYield()
            :base(Fields.CustomTags.OfferYield) {}
        public OfferYield(Decimal val)
            :base(Fields.CustomTags.OfferYield, val) {}

    }


    /// <summary>
    /// ClearingFeeIndicator Field
    /// </summary>/
    public sealed class ClearingFeeIndicator : QuickFix.Fields.StringField
    {
        public ClearingFeeIndicator()
            :base(Fields.CustomTags.ClearingFeeIndicator) {}
        public ClearingFeeIndicator(string val)
            :base(Fields.CustomTags.ClearingFeeIndicator, val) {}


        // Field Enumerations
        public const string VAL_1ST_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "1";
        public const string VAL_2ND_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "2";
        public const string VAL_3RD_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "3";
        public const string VAL_4TH_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "4";
        public const string VAL_5TH_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "5";
        public const string VAL_6TH_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "9";
        public const string CBOE_MEMBER = "B";
        public const string NON_MEMBER_AND_CUSTOMER = "C";
        public const string EQUITY_MEMBER_AND_CLEARING_MEMBER = "E";
        public const string FULL_AND_ASSOCIATE_MEMBER_TRADING_FOR_OWN_ACCOUNT_AND_AS_FLOOR_BROKERS = "F";
        public const string VAL_106H_AND_106J_FIRMS = "H";
        public const string GIM_IDEM_AND_COM_MEMBERSHIP_INTEREST_HOLDERS = "I";
        public const string LESSEE_106F_EMPLOYEES = "L";
        public const string ALL_OTHER_OWNERSHIP_TYPES = "M";
    }


    /// <summary>
    /// WorkingIndicator Field
    /// </summary>/
    public sealed class WorkingIndicator : QuickFix.Fields.BooleanField
    {
        public WorkingIndicator()
            :base(Fields.CustomTags.WorkingIndicator) {}
        public WorkingIndicator(Boolean val)
            :base(Fields.CustomTags.WorkingIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// LegLastPx Field
    /// </summary>/
    public sealed class LegLastPx : QuickFix.Fields.DecimalField
    {
        public LegLastPx()
            :base(Fields.CustomTags.LegLastPx) {}
        public LegLastPx(Decimal val)
            :base(Fields.CustomTags.LegLastPx, val) {}

    }


    /// <summary>
    /// PriorityIndicator Field
    /// </summary>/
    public sealed class PriorityIndicator : QuickFix.Fields.IntField
    {
        public PriorityIndicator()
            :base(Fields.CustomTags.PriorityIndicator) {}
        public PriorityIndicator(int val)
            :base(Fields.CustomTags.PriorityIndicator, val) {}


        // Field Enumerations
        public const int PRIORITY_UNCHANGED = 0;
        public const int LOST_PRIORITY_AS_RESULT_OF_ORDER_CHANGE = 1;
    }


    /// <summary>
    /// PriceImprovement Field
    /// </summary>/
    public sealed class PriceImprovement : QuickFix.Fields.DecimalField
    {
        public PriceImprovement()
            :base(Fields.CustomTags.PriceImprovement) {}
        public PriceImprovement(Decimal val)
            :base(Fields.CustomTags.PriceImprovement, val) {}

    }


    /// <summary>
    /// Price2 Field
    /// </summary>/
    public sealed class Price2 : QuickFix.Fields.DecimalField
    {
        public Price2()
            :base(Fields.CustomTags.Price2) {}
        public Price2(Decimal val)
            :base(Fields.CustomTags.Price2, val) {}

    }


    /// <summary>
    /// LastForwardPoints2 Field
    /// </summary>/
    public sealed class LastForwardPoints2 : QuickFix.Fields.DecimalField
    {
        public LastForwardPoints2()
            :base(Fields.CustomTags.LastForwardPoints2) {}
        public LastForwardPoints2(Decimal val)
            :base(Fields.CustomTags.LastForwardPoints2, val) {}

    }


    /// <summary>
    /// BidForwardPoints2 Field
    /// </summary>/
    public sealed class BidForwardPoints2 : QuickFix.Fields.DecimalField
    {
        public BidForwardPoints2()
            :base(Fields.CustomTags.BidForwardPoints2) {}
        public BidForwardPoints2(Decimal val)
            :base(Fields.CustomTags.BidForwardPoints2, val) {}

    }


    /// <summary>
    /// OfferForwardPoints2 Field
    /// </summary>/
    public sealed class OfferForwardPoints2 : QuickFix.Fields.DecimalField
    {
        public OfferForwardPoints2()
            :base(Fields.CustomTags.OfferForwardPoints2) {}
        public OfferForwardPoints2(Decimal val)
            :base(Fields.CustomTags.OfferForwardPoints2, val) {}

    }


    /// <summary>
    /// RFQReqID Field
    /// </summary>/
    public sealed class RFQReqID : QuickFix.Fields.StringField
    {
        public RFQReqID()
            :base(Fields.CustomTags.RFQReqID) {}
        public RFQReqID(string val)
            :base(Fields.CustomTags.RFQReqID, val) {}

    }


    /// <summary>
    /// MktBidPx Field
    /// </summary>/
    public sealed class MktBidPx : QuickFix.Fields.DecimalField
    {
        public MktBidPx()
            :base(Fields.CustomTags.MktBidPx) {}
        public MktBidPx(Decimal val)
            :base(Fields.CustomTags.MktBidPx, val) {}

    }


    /// <summary>
    /// MktOfferPx Field
    /// </summary>/
    public sealed class MktOfferPx : QuickFix.Fields.DecimalField
    {
        public MktOfferPx()
            :base(Fields.CustomTags.MktOfferPx) {}
        public MktOfferPx(Decimal val)
            :base(Fields.CustomTags.MktOfferPx, val) {}

    }


    /// <summary>
    /// MinBidSize Field
    /// </summary>/
    public sealed class MinBidSize : QuickFix.Fields.DecimalField
    {
        public MinBidSize()
            :base(Fields.CustomTags.MinBidSize) {}
        public MinBidSize(Decimal val)
            :base(Fields.CustomTags.MinBidSize, val) {}

    }


    /// <summary>
    /// MinOfferSize Field
    /// </summary>/
    public sealed class MinOfferSize : QuickFix.Fields.DecimalField
    {
        public MinOfferSize()
            :base(Fields.CustomTags.MinOfferSize) {}
        public MinOfferSize(Decimal val)
            :base(Fields.CustomTags.MinOfferSize, val) {}

    }


    /// <summary>
    /// QuoteStatusReqID Field
    /// </summary>/
    public sealed class QuoteStatusReqID : QuickFix.Fields.StringField
    {
        public QuoteStatusReqID()
            :base(Fields.CustomTags.QuoteStatusReqID) {}
        public QuoteStatusReqID(string val)
            :base(Fields.CustomTags.QuoteStatusReqID, val) {}

    }


    /// <summary>
    /// LegalConfirm Field
    /// </summary>/
    public sealed class LegalConfirm : QuickFix.Fields.BooleanField
    {
        public LegalConfirm()
            :base(Fields.CustomTags.LegalConfirm) {}
        public LegalConfirm(Boolean val)
            :base(Fields.CustomTags.LegalConfirm, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// UnderlyingLastPx Field
    /// </summary>/
    public sealed class UnderlyingLastPx : QuickFix.Fields.DecimalField
    {
        public UnderlyingLastPx()
            :base(Fields.CustomTags.UnderlyingLastPx) {}
        public UnderlyingLastPx(Decimal val)
            :base(Fields.CustomTags.UnderlyingLastPx, val) {}

    }


    /// <summary>
    /// UnderlyingLastQty Field
    /// </summary>/
    public sealed class UnderlyingLastQty : QuickFix.Fields.DecimalField
    {
        public UnderlyingLastQty()
            :base(Fields.CustomTags.UnderlyingLastQty) {}
        public UnderlyingLastQty(Decimal val)
            :base(Fields.CustomTags.UnderlyingLastQty, val) {}

    }


    /// <summary>
    /// SecDefStatus Field
    /// </summary>/
    public sealed class SecDefStatus : QuickFix.Fields.IntField
    {
        public SecDefStatus()
            :base(Fields.CustomTags.SecDefStatus) {}
        public SecDefStatus(int val)
            :base(Fields.CustomTags.SecDefStatus, val) {}


        // Field Enumerations
        public const int PENDING_APPROVAL = 0;
        public const int APPROVED = 1;
        public const int REJECTED = 2;
        public const int UNAUTHORIZED_REQUEST = 3;
        public const int INVALID_DEFINITION_REQUEST = 4;
    }


    /// <summary>
    /// LegRefID Field
    /// </summary>/
    public sealed class LegRefID : QuickFix.Fields.StringField
    {
        public LegRefID()
            :base(Fields.CustomTags.LegRefID) {}
        public LegRefID(string val)
            :base(Fields.CustomTags.LegRefID, val) {}

    }


    /// <summary>
    /// ContraLegRefID Field
    /// </summary>/
    public sealed class ContraLegRefID : QuickFix.Fields.StringField
    {
        public ContraLegRefID()
            :base(Fields.CustomTags.ContraLegRefID) {}
        public ContraLegRefID(string val)
            :base(Fields.CustomTags.ContraLegRefID, val) {}

    }


    /// <summary>
    /// SettlCurrBidFxRate Field
    /// </summary>/
    public sealed class SettlCurrBidFxRate : QuickFix.Fields.DecimalField
    {
        public SettlCurrBidFxRate()
            :base(Fields.CustomTags.SettlCurrBidFxRate) {}
        public SettlCurrBidFxRate(Decimal val)
            :base(Fields.CustomTags.SettlCurrBidFxRate, val) {}

    }


    /// <summary>
    /// SettlCurrOfferFxRate Field
    /// </summary>/
    public sealed class SettlCurrOfferFxRate : QuickFix.Fields.DecimalField
    {
        public SettlCurrOfferFxRate()
            :base(Fields.CustomTags.SettlCurrOfferFxRate) {}
        public SettlCurrOfferFxRate(Decimal val)
            :base(Fields.CustomTags.SettlCurrOfferFxRate, val) {}

    }


    /// <summary>
    /// QuoteRequestRejectReason Field
    /// </summary>/
    public sealed class QuoteRequestRejectReason : QuickFix.Fields.IntField
    {
        public QuoteRequestRejectReason()
            :base(Fields.CustomTags.QuoteRequestRejectReason) {}
        public QuoteRequestRejectReason(int val)
            :base(Fields.CustomTags.QuoteRequestRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_SYMBOL = 1;
        public const int PASS = 10;
        public const int EXCHANGE = 2;
        public const int QUOTE_REQUEST_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int INVALID_PRICE = 5;
        public const int NOT_AUTHORIZED_TO_REQUEST_QUOTE = 6;
        public const int NO_MATCH_FOR_INQUIRY = 7;
        public const int NO_MARKET_FOR_INSTRUMENT = 8;
        public const int NO_INVENTORY = 9;
        public const int OTHER = 99;
        public const int INSUFFICIENT_CREDIT = 11;
    }


    /// <summary>
    /// SideComplianceID Field
    /// </summary>/
    public sealed class SideComplianceID : QuickFix.Fields.StringField
    {
        public SideComplianceID()
            :base(Fields.CustomTags.SideComplianceID) {}
        public SideComplianceID(string val)
            :base(Fields.CustomTags.SideComplianceID, val) {}

    }


    /// <summary>
    /// OrigTradeDate Field
    /// </summary>/
    public sealed class OrigTradeDate : QuickFix.Fields.StringField
    {
        public OrigTradeDate()
            :base(Fields.CustomTags.OrigTradeDate) {}
        public OrigTradeDate(string val)
            :base(Fields.CustomTags.OrigTradeDate, val) {}

    }


    /// <summary>
    /// NoAlloc Field
    /// </summary>/
    public sealed class NoAlloc : QuickFix.Fields.CharField
    {
        public NoAlloc()
            :base(Fields.CustomTags.NoAlloc) {}
        public NoAlloc(char val)
            :base(Fields.CustomTags.NoAlloc, val) {}

    }


    /// <summary>
    /// XMLDataLen Field
    /// </summary>/
    public sealed class XMLDataLen : QuickFix.Fields.IntField
    {
        public XMLDataLen()
            :base(Fields.CustomTags.XMLDataLen) {}
        public XMLDataLen(int val)
            :base(Fields.CustomTags.XMLDataLen, val) {}

    }


    /// <summary>
    /// XMLData Field
    /// </summary>/
    public sealed class XMLData : QuickFix.Fields.StringField
    {
        public XMLData()
            :base(Fields.CustomTags.XMLData) {}
        public XMLData(string val)
            :base(Fields.CustomTags.XMLData, val) {}

    }


    /// <summary>
    /// LastSeqNumProcessed Field
    /// </summary>/
    public sealed class LastSeqNumProcessed : QuickFix.Fields.IntField
    {
        public LastSeqNumProcessed()
            :base(Fields.CustomTags.LastSeqNumProcessed) {}
        public LastSeqNumProcessed(int val)
            :base(Fields.CustomTags.LastSeqNumProcessed, val) {}

    }


    /// <summary>
    /// MassCancelRequestReportType Field
    /// </summary>/
    public sealed class MassCancelRequestReportType : QuickFix.Fields.IntField
    {
        public MassCancelRequestReportType()
            :base(Fields.CustomTags.MassCancelRequestReportType) {}
        public MassCancelRequestReportType(int val)
            :base(Fields.CustomTags.MassCancelRequestReportType, val) {}

    }


    /// <summary>
    /// UserName Field
    /// </summary>/
    public sealed class UserName : QuickFix.Fields.StringField
    {
        public UserName()
            :base(Fields.CustomTags.UserName) {}
        public UserName(string val)
            :base(Fields.CustomTags.UserName, val) {}

    }


    /// <summary>
    /// LegSettlDate Field
    /// </summary>/
    public sealed class LegSettlDate : QuickFix.Fields.StringField
    {
        public LegSettlDate()
            :base(Fields.CustomTags.LegSettlDate) {}
        public LegSettlDate(string val)
            :base(Fields.CustomTags.LegSettlDate, val) {}

    }


    /// <summary>
    /// LegIDSource Field
    /// </summary>/
    public sealed class LegIDSource : QuickFix.Fields.StringField
    {
        public LegIDSource()
            :base(Fields.CustomTags.LegIDSource) {}
        public LegIDSource(string val)
            :base(Fields.CustomTags.LegIDSource, val) {}


        // Field Enumerations
        public const string TT_SECURITY_ID = "96";
    }


    /// <summary>
    /// LastParPx Field
    /// </summary>/
    public sealed class LastParPx : QuickFix.Fields.DecimalField
    {
        public LastParPx()
            :base(Fields.CustomTags.LastParPx) {}
        public LastParPx(Decimal val)
            :base(Fields.CustomTags.LastParPx, val) {}

    }


    /// <summary>
    /// LegQty Field
    /// </summary>/
    public sealed class LegQty : QuickFix.Fields.DecimalField
    {
        public LegQty()
            :base(Fields.CustomTags.LegQty) {}
        public LegQty(Decimal val)
            :base(Fields.CustomTags.LegQty, val) {}

    }


    /// <summary>
    /// DeliveryDate Field
    /// </summary>/
    public sealed class DeliveryDate : QuickFix.Fields.StringField
    {
        public DeliveryDate()
            :base(Fields.CustomTags.DeliveryDate) {}
        public DeliveryDate(string val)
            :base(Fields.CustomTags.DeliveryDate, val) {}

    }


    /// <summary>
    /// TradeReportRejectReason Field
    /// </summary>/
    public sealed class TradeReportRejectReason : QuickFix.Fields.IntField
    {
        public TradeReportRejectReason()
            :base(Fields.CustomTags.TradeReportRejectReason) {}
        public TradeReportRejectReason(int val)
            :base(Fields.CustomTags.TradeReportRejectReason, val) {}


        // Field Enumerations
        public const int SUCCESSFUL = 0;
        public const int INVALID_PARTY_ONFORMATION = 1;
        public const int UNKNOWN_INSTRUMENT = 2;
        public const int UNAUTHORIZED_TO_REPORT_TRADES = 3;
        public const int INVALID_TRADE_TYPE = 4;
        public const int OTHER = 99;
        public const int INVALID_PARTY_INFORMATION = 1;
    }


    /// <summary>
    /// SecuritySubType Field
    /// </summary>/
    public sealed class SecuritySubType : QuickFix.Fields.StringField
    {
        public SecuritySubType()
            :base(Fields.CustomTags.SecuritySubType) {}
        public SecuritySubType(string val)
            :base(Fields.CustomTags.SecuritySubType, val) {}

    }


    /// <summary>
    /// LegSecuritySubType Field
    /// </summary>/
    public sealed class LegSecuritySubType : QuickFix.Fields.StringField
    {
        public LegSecuritySubType()
            :base(Fields.CustomTags.LegSecuritySubType) {}
        public LegSecuritySubType(string val)
            :base(Fields.CustomTags.LegSecuritySubType, val) {}

    }


    /// <summary>
    /// NextExpectedMsgSeqNum Field
    /// </summary>/
    public sealed class NextExpectedMsgSeqNum : QuickFix.Fields.IntField
    {
        public NextExpectedMsgSeqNum()
            :base(Fields.CustomTags.NextExpectedMsgSeqNum) {}
        public NextExpectedMsgSeqNum(int val)
            :base(Fields.CustomTags.NextExpectedMsgSeqNum, val) {}

    }


    /// <summary>
    /// OrdStatusReqID Field
    /// </summary>/
    public sealed class OrdStatusReqID : QuickFix.Fields.StringField
    {
        public OrdStatusReqID()
            :base(Fields.CustomTags.OrdStatusReqID) {}
        public OrdStatusReqID(string val)
            :base(Fields.CustomTags.OrdStatusReqID, val) {}

    }


    /// <summary>
    /// UnderlyingPx Field
    /// </summary>/
    public sealed class UnderlyingPx : QuickFix.Fields.DecimalField
    {
        public UnderlyingPx()
            :base(Fields.CustomTags.UnderlyingPx) {}
        public UnderlyingPx(Decimal val)
            :base(Fields.CustomTags.UnderlyingPx, val) {}

    }


    /// <summary>
    /// OptionDelta Field
    /// </summary>/
    public sealed class OptionDelta : QuickFix.Fields.DecimalField
    {
        public OptionDelta()
            :base(Fields.CustomTags.OptionDelta) {}
        public OptionDelta(Decimal val)
            :base(Fields.CustomTags.OptionDelta, val) {}

    }


    /// <summary>
    /// SecondaryTradeReportID Field
    /// </summary>/
    public sealed class SecondaryTradeReportID : QuickFix.Fields.StringField
    {
        public SecondaryTradeReportID()
            :base(Fields.CustomTags.SecondaryTradeReportID) {}
        public SecondaryTradeReportID(string val)
            :base(Fields.CustomTags.SecondaryTradeReportID, val) {}

    }


    /// <summary>
    /// TradeLinkID Field
    /// </summary>/
    public sealed class TradeLinkID : QuickFix.Fields.StringField
    {
        public TradeLinkID()
            :base(Fields.CustomTags.TradeLinkID) {}
        public TradeLinkID(string val)
            :base(Fields.CustomTags.TradeLinkID, val) {}

    }


    /// <summary>
    /// TrdType Field
    /// </summary>/
    public sealed class TrdType : QuickFix.Fields.IntField
    {
        public TrdType()
            :base(Fields.CustomTags.TrdType) {}
        public TrdType(int val)
            :base(Fields.CustomTags.TrdType, val) {}


        // Field Enumerations
        public const int REGULAR_TRADE = 0;
        public const int BLOCK_TRADE_1 = 1;
        public const int AFTER_HOURS_TRADE = 10;
        public const int EFP = 2;
        public const int TRANSFER = 3;
        public const int LATE_TRADE = 4;
        public const int T_TRADE = 5;
        public const int WEIGHTED_AVERAGE_PRICE_TRADE = 6;
        public const int BUNCHED_TRADE = 7;
        public const int LATE_BUNCHED_TRADE = 8;
        public const int PRIOR_REFERENCE_PRICE_TRADE = 9;
        public const int EXCHANGE_FOR_RISK = 11;
        public const int EXCHANGE_FOR_SWAP = 12;
        public const int EXCHANGE_OF_FUTURES_FOR = 13;
        public const int EXCHANGE_OF_OPTIONS_FOR_OPTIONS = 14;
        public const int TRADING_AT_SETTLEMENT = 15;
        public const int ALL_OR_NONE = 16;
        public const int FUTURES_LARGE_ORDER_EXECUTION = 17;
        public const int EXCHANGE_OF_FUTURES_FOR_FUTURES = 18;
        public const int OPTION_INTERIM_TRADE = 19;
        public const int OPTION_CABINET_TRADE = 20;
        public const int PRIVATELY_NEGOTIATED_TRADES = 22;
        public const int SUBSTITUTION_OF_FUTURES_FOR_FORWARDS = 23;
        public const int ERROR_TRADE = 24;
        public const int SPECIAL_CUM_DIVIDEND = 25;
        public const int SPECIAL_EX_DIVIDEND = 26;
        public const int SPECIAL_CUM_COUPON = 27;
        public const int SPECIAL_EX_COUPON = 28;
        public const int CASH_SETTLEMENT = 29;
        public const int SPECIAL_PRICE = 30;
        public const int GUARANTEED_DELIVERY = 31;
        public const int SPECIAL_CUM_RIGHTS = 32;
        public const int SPECIAL_EX_RIGHTS = 33;
        public const int SPECIAL_CUM_CAPITAL_REPAYMENTS = 34;
        public const int SPECIAL_EX_CAPITAL_REPAYMENTS = 35;
        public const int SPECIAL_CUM_BONUS = 36;
        public const int SPECIAL_EX_BONUS = 37;
        public const int BLOCK_TRADE_38 = 38;
        public const int WORKED_PRINCIPAL_TRADE = 39;
        public const int BLOCK_TRADES = 40;
        public const int NAME_CHANGE = 41;
        public const int PORTFOLIO_TRANSFER = 42;
        public const int PROROGATION_BUY = 43;
        public const int PROROGATION_SELL = 44;
        public const int OPTION_EXERCISE = 45;
        public const int DELTA_NEUTRAL_TRANSACTION = 46;
        public const int FINANCING_TRANSACTION = 47;
        public const int NON_STANDARD_SETTLEMENT = 48;
        public const int DERIVATIVE_RELATED_TRANSACTION = 49;
        public const int PORTFOLIO_TRADE = 50;
        public const int VOLUME_WEIGHTED_AVERAGE_TRADE = 51;
        public const int EXCHANGE_GRANTED_TRADE = 52;
        public const int REPURCHASE_AGREEMENT = 53;
        public const int OTC = 54;
        public const int EXCHANGE_BASIS_FACILITY = 55;
        public const int BLOCK_TRADE = 1;
        public const int EXCHANGE_FOR_PHYSICAL = 2;
        public const int VOLATILITY = 1000;
        public const int EFP_FINANCIAL = 1001;
        public const int EFP_INDEX_FUTURES = 1002;
        public const int STRATEGY_BLOCK_TRADE = 1003;
        public const int BLOCK_STANDARD_CF = 1004;
        public const int BLOCK_COMBINATION_CF = 1005;
        public const int EFS_EFP_CF = 1006;
        public const int BLOCK_INTERNAL_CF = 1007;
        public const int PORTFOLIO_CF = 1008;
        public const int CORRECTION_CF = 1009;
        public const int BLOCK_COMBINATION_BUYER_CF = 1010;
        public const int BLOCK_COMBINATION_SELLER_CF = 1011;
        public const int EFS_EFP_COMBINATION_CF = 1012;
        public const int EFS_EFP_COMBINATION_BUYER_CF = 1013;
        public const int EFS_EFP_COMBINATION_SELLER_CF = 1014;
        public const int OTC_STANDARD_CIO = 1015;
        public const int OTC_COMBINATION_CIO = 1016;
        public const int OTC_COMBINATION_BUYER_CIO = 1017;
        public const int OTC_COMBINATION_SELLER_CIO = 1018;
        public const int STANDARD_TRADE_CD = 1019;
        public const int STANDARD_OUTSIDE_SPREAD_CD = 1020;
        public const int COMBINATION_CD = 1021;
        public const int OLD_CD = 1022;
        public const int INTERNAL_CD = 1023;
        public const int PORTFOLIO_CD = 1024;
        public const int CORRECTION_CD = 1025;
        public const int EXCHANGE_GRANTED_FD = 1026;
        public const int STANDARD_OUTSIDE_FD = 1027;
        public const int OFF_HOURS_FD = 1028;
        public const int BLOCK_FD = 1029;
        public const int EXCH_GRANTED_EXCEED_MAX_LOT_FD = 1030;
        public const int EXCH_GRANTED_EML_OFF_HOURS_FD = 1031;
        public const int EXCH_GRANTED_LATE_FD = 1032;
        public const int FLEX_CONTRACT_CONVERSION_FD = 1033;
        public const int ICE_EFRP = 1034;
        public const int ICEBLK = 1035;
        public const int BASIS = 1036;
        public const int VOLATILITY_CONTINGENT = 1037;
        public const int STOCK_CONTINGENT = 1038;
        public const int CCX_EFP = 1039;
        public const int OTHER_CLEARING_VALUE = 1040;
        public const int N2EX = 1041;
        public const int EEX = 1042;
        public const int EFS_EFP_CONTRA = 1043;
        public const int EFM = 1044;
        public const int NG_EFP_EFS = 1045;
        public const int CONTRA = 1046;
        public const int CPBLK = 1047;
        public const int BILATERAL_OFF_EXCH = 1048;
        public const int OTC_PRIVATELY_NEGOTIATED_TRADES = 1049;
        public const int OTC_LARGE_NOTIONAL_OFF_FACILITY_SWAP = 1050;
        public const int BLOCK_SWAP_TRADE = 1051;
        public const int LARGE_IN_SCALE = 1052;
        public const int AGAINST_ACTUAL = 1053;
        public const int LARGE_IN_SCALE_PACKAGE = 1054;
        public const int GUARANTEED_CROSS = 1055;
        public const int REQUEST_FOR_CROSS = 1056;
        public const int EFP_CD = 1057;
        public const int B_AND_S_NO_CLEARING_CD = 1058;
        public const int BUYER_NO_CLEARING_CD = 1059;
        public const int SELLER_NO_CLEARING_CD = 1060;
        public const int EFP_NO_FEE_CD = 1061;
        public const int MATCH_EXCH_MANUALLY_CD = 1062;
        public const int MATCH_EXCH_COMBINATION_CD = 1063;
        public const int FUT_DS_FUT_COMBO_CD = 1064;
        public const int BLOCK_NONFINANCIAL_CP_CD = 1065;
        public const int EXCH_FOR_SWAP_OPTIONS_CD = 1066;
        public const int BLOCK_NONFINANCIAL_CP_CF = 1067;
        public const int EXCH_FOR_SWAP_OPTIONS_CF = 1070;
        public const int COMMITTED = 1071;
        public const int INTERNAL = 1072;
        public const int INTERBANK = 1073;
        public const int UNKNOWN = 9999;
    }


    /// <summary>
    /// LastLiquidityIndicator Field
    /// </summary>/
    public sealed class LastLiquidityIndicator : QuickFix.Fields.IntField
    {
        public LastLiquidityIndicator()
            :base(Fields.CustomTags.LastLiquidityIndicator) {}
        public LastLiquidityIndicator(int val)
            :base(Fields.CustomTags.LastLiquidityIndicator, val) {}


        // Field Enumerations
        public const int ADDED_LIQUIDITY = 1;
        public const int REMOVED_LIQUIDITY = 2;
    }


    /// <summary>
    /// TradeReportType Field
    /// </summary>/
    public sealed class TradeReportType : QuickFix.Fields.IntField
    {
        public TradeReportType()
            :base(Fields.CustomTags.TradeReportType) {}
        public TradeReportType(int val)
            :base(Fields.CustomTags.TradeReportType, val) {}


        // Field Enumerations
        public const int SUBMIT = 0;
        public const int ALLEGED_1 = 1;
        public const int ACCEPT = 2;
        public const int DECLINE = 3;
        public const int ADDENDUM = 4;
        public const int NO_WAS = 5;
        public const int TRADE_REPORT_CANCEL = 6;
        public const int VAL_7 = 7;
        public const int DEFAULTED = 8;
        public const int INVALID_CMTA = 9;
        public const int PENDED = 10;
        public const int ALLEGED_NEW = 11;
        public const int ALLEGED_ADDENDUM = 12;
        public const int ALLEGED_NO_WAS = 13;
        public const int ALLEGED_TRADE_REPORT_CANCEL = 14;
        public const int ALLEGED_15 = 15;
        public const int ALLEGED = 1;
        public const int CANCEL = 6;
        public const int UNKNOWN = 999;
        public const int CLEARING = 1000;
    }


    /// <summary>
    /// NoEvents Field
    /// </summary>/
    public sealed class NoEvents : QuickFix.Fields.IntField
    {
        public NoEvents()
            :base(Fields.CustomTags.NoEvents) {}
        public NoEvents(int val)
            :base(Fields.CustomTags.NoEvents, val) {}

    }


    /// <summary>
    /// EventType Field
    /// </summary>/
    public sealed class EventType : QuickFix.Fields.IntField
    {
        public EventType()
            :base(Fields.CustomTags.EventType) {}
        public EventType(int val)
            :base(Fields.CustomTags.EventType, val) {}


        // Field Enumerations
        public const int PUT = 1;
        public const int CALL = 2;
        public const int TENDER = 3;
        public const int SINKING_FUND_CALL = 4;
        public const int OTHER = 99;
        public const int ACTIVATION = 5;
        public const int INACTIVIATION = 6;
        public const int LAST_ELIGIBLE_TRADE_DATE = 7;
        public const int SWAP_START_DATE = 8;
        public const int SWAP_END_DATE = 9;
        public const int SWAP_NEXT_START_DATE = 11;
        public const int SWAP_ROLL_DATE = 10;
        public const int SWAP_NEXT_ROLL_DATE = 12;
        public const int FIRST_DELIVERY_DATE = 13;
        public const int LAST_DELIVERY_DATE = 14;
        public const int INITIAL_INVENTORY_DUE_DATE = 15;
        public const int FINAL_INVENTORY_DUE_DATE = 16;
        public const int FIRST_INTENT_DATE = 17;
        public const int LAST_INTENT_DATE = 18;
        public const int POSITION_REMOVAL_DATE = 19;
        public const int EXPIRY_DATE = 5;
        public const int LAST_TRADING_DATE = 6;
    }


    /// <summary>
    /// EventDate Field
    /// </summary>/
    public sealed class EventDate : QuickFix.Fields.StringField
    {
        public EventDate()
            :base(Fields.CustomTags.EventDate) {}
        public EventDate(string val)
            :base(Fields.CustomTags.EventDate, val) {}

    }


    /// <summary>
    /// TrdMatchID Field
    /// </summary>/
    public sealed class TrdMatchID : QuickFix.Fields.StringField
    {
        public TrdMatchID()
            :base(Fields.CustomTags.TrdMatchID) {}
        public TrdMatchID(string val)
            :base(Fields.CustomTags.TrdMatchID, val) {}

    }


    /// <summary>
    /// LastFragment Field
    /// </summary>/
    public sealed class LastFragment : QuickFix.Fields.BooleanField
    {
        public LastFragment()
            :base(Fields.CustomTags.LastFragment) {}
        public LastFragment(Boolean val)
            :base(Fields.CustomTags.LastFragment, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean NOT_LAST_MESSAGE = false;
        public const Boolean LAST_MESSAGE = true;
    }


    /// <summary>
    /// LastRptRequested Field
    /// </summary>/
    public sealed class LastRptRequested : QuickFix.Fields.BooleanField
    {
        public LastRptRequested()
            :base(Fields.CustomTags.LastRptRequested) {}
        public LastRptRequested(Boolean val)
            :base(Fields.CustomTags.LastRptRequested, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// StartDate Field
    /// </summary>/
    public sealed class StartDate : QuickFix.Fields.StringField
    {
        public StartDate()
            :base(Fields.CustomTags.StartDate) {}
        public StartDate(string val)
            :base(Fields.CustomTags.StartDate, val) {}

    }


    /// <summary>
    /// EndDate Field
    /// </summary>/
    public sealed class EndDate : QuickFix.Fields.StringField
    {
        public EndDate()
            :base(Fields.CustomTags.EndDate) {}
        public EndDate(string val)
            :base(Fields.CustomTags.EndDate, val) {}

    }


    /// <summary>
    /// TrdRptStatus Field
    /// </summary>/
    public sealed class TrdRptStatus : QuickFix.Fields.IntField
    {
        public TrdRptStatus()
            :base(Fields.CustomTags.TrdRptStatus) {}
        public TrdRptStatus(int val)
            :base(Fields.CustomTags.TrdRptStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int REJECTED = 1;
        public const int ACCEPTED_WITH_ERRORS = 3;
        public const int UNKNOWN = 99;
    }


    /// <summary>
    /// NoStrategyParameters Field
    /// </summary>/
    public sealed class NoStrategyParameters : QuickFix.Fields.IntField
    {
        public NoStrategyParameters()
            :base(Fields.CustomTags.NoStrategyParameters) {}
        public NoStrategyParameters(int val)
            :base(Fields.CustomTags.NoStrategyParameters, val) {}

    }


    /// <summary>
    /// StrategyParameterName Field
    /// </summary>/
    public sealed class StrategyParameterName : QuickFix.Fields.StringField
    {
        public StrategyParameterName()
            :base(Fields.CustomTags.StrategyParameterName) {}
        public StrategyParameterName(string val)
            :base(Fields.CustomTags.StrategyParameterName, val) {}

    }


    /// <summary>
    /// StrategyParameterType Field
    /// </summary>/
    public sealed class StrategyParameterType : QuickFix.Fields.IntField
    {
        public StrategyParameterType()
            :base(Fields.CustomTags.StrategyParameterType) {}
        public StrategyParameterType(int val)
            :base(Fields.CustomTags.StrategyParameterType, val) {}


        // Field Enumerations
        public const int INT = 1;
        public const int LENGTH = 2;
        public const int NUMINGROUP = 3;
        public const int SEQNUM = 4;
        public const int TAGNUM = 5;
        public const int FLOAT = 6;
        public const int QTY = 7;
        public const int PRICE = 8;
        public const int PRICEOFFSET = 9;
        public const int AMT = 10;
        public const int PERCENTAGE = 11;
        public const int CHAR = 12;
        public const int BOOLEAN = 13;
        public const int STRING = 14;
        public const int MULTIPLECHARVALUE = 15;
        public const int CURRENCY = 16;
        public const int EXCHANGE = 17;
        public const int MONTHYEAR = 18;
        public const int UTCTIMESTAMP = 19;
        public const int UTCTIMEONLY = 20;
        public const int LOCALMKTDATE = 21;
        public const int UTCDATEONLY = 22;
        public const int DATA = 23;
        public const int MULTIPLESTRINGVALUE = 24;
        public const int COUNTRY = 25;
        public const int LANGUAGE = 26;
        public const int TZTIMEONLY = 27;
        public const int TZTIMESTAMP = 28;
        public const int TENOR = 29;
        public const int MONTH_YEAR = 18;
        public const int LOCALMKTTIME = 21;
        public const int UTCDATE = 22;
    }


    /// <summary>
    /// StrategyParameterValue Field
    /// </summary>/
    public sealed class StrategyParameterValue : QuickFix.Fields.StringField
    {
        public StrategyParameterValue()
            :base(Fields.CustomTags.StrategyParameterValue) {}
        public StrategyParameterValue(string val)
            :base(Fields.CustomTags.StrategyParameterValue, val) {}

    }


    /// <summary>
    /// HostCrossID Field
    /// </summary>/
    public sealed class HostCrossID : QuickFix.Fields.StringField
    {
        public HostCrossID()
            :base(Fields.CustomTags.HostCrossID) {}
        public HostCrossID(string val)
            :base(Fields.CustomTags.HostCrossID, val) {}

    }


    /// <summary>
    /// TradeID Field
    /// </summary>/
    public sealed class TradeID : QuickFix.Fields.StringField
    {
        public TradeID()
            :base(Fields.CustomTags.TradeID) {}
        public TradeID(string val)
            :base(Fields.CustomTags.TradeID, val) {}

    }


    /// <summary>
    /// ManualOrderIndicator Field
    /// </summary>/
    public sealed class ManualOrderIndicator : QuickFix.Fields.BooleanField
    {
        public ManualOrderIndicator()
            :base(Fields.CustomTags.ManualOrderIndicator) {}
        public ManualOrderIndicator(Boolean val)
            :base(Fields.CustomTags.ManualOrderIndicator, val) {}


        // Field Enumerations
        public const Boolean ELECTRONIC = false;
        public const Boolean MANUAL = true;
    }


    /// <summary>
    /// CustOrderHandlingInst Field
    /// </summary>/
    public sealed class CustOrderHandlingInst : QuickFix.Fields.StringField
    {
        public CustOrderHandlingInst()
            :base(Fields.CustomTags.CustOrderHandlingInst) {}
        public CustOrderHandlingInst(string val)
            :base(Fields.CustomTags.CustOrderHandlingInst, val) {}


        // Field Enumerations
        public const string ADD_ON_ORDER = "ADD";
        public const string ALL_OR_NONE = "AON";
        public const string CASH_NOT_HELD = "CNH";
        public const string DIRECTED_ORDER = "DIR";
        public const string EXCHANGE_FOR_PHYSICAL_TRANSACTION = "E.W";
        public const string FILL_OR_KILL = "FOK";
        public const string IMBALANCE_ONLY = "IO";
        public const string IMMEDIATE_OR_CANCEL = "IOC";
        public const string LIMIT_ON_OPEN = "LOO";
        public const string LIMIT_ON_CLOSE = "LOC";
        public const string MARKET_AT_OPEN = "MAO";
        public const string MARKET_AT_CLOSE = "MAC";
        public const string MARKET_ON_OPEN = "MOO";
        public const string MARKET_ON_CLOSE = "MOC";
        public const string MINIMUM_QUANTITY = "MQT";
        public const string NOT_HELD = "NH";
        public const string OVER_THE_DAY = "OVD";
        public const string PEGGED = "PEG";
        public const string RESERVE_SIZE_ORDER = "RSV";
        public const string STOP_STOCK_TRANSACTION = "S.W";
        public const string SCALE = "SCL";
        public const string TIME_ORDER = "TMO";
        public const string TRAILING_STOP = "TS";
        public const string WORK = "WRK";
        public const string DESK = "W";
        public const string ELECTRONIC = "Y";
        public const string VENDOR_PLATFORM_BILLED_BY_EXECUTING_BROKER = "C";
        public const string SPONSORED_ACCESS_VIA_API_OR_FIX_BY_EXECUTING_BROKER = "G";
        public const string PREMIUM_ALGO_TRADING_PROVIDER_BILLED_BY_EXECUTING_BROKER = "H";
        public const string OTHER = "D";
    }


    /// <summary>
    /// AllocPositionEffect Field
    /// </summary>/
    public sealed class AllocPositionEffect : QuickFix.Fields.CharField
    {
        public AllocPositionEffect()
            :base(Fields.CustomTags.AllocPositionEffect) {}
        public AllocPositionEffect(char val)
            :base(Fields.CustomTags.AllocPositionEffect, val) {}


        // Field Enumerations
        public const char OPEN = 'O';
        public const char CLOSE = 'C';
        public const char ROLLED = 'R';
        public const char FIFO = 'F';
        public const char CLOSE_BUT_NOTIFY_ON_OPEN = 'N';
        public const char DEFAULT = 'D';
    }


    /// <summary>
    /// AggressorIndicator Field
    /// </summary>/
    public sealed class AggressorIndicator : QuickFix.Fields.BooleanField
    {
        public AggressorIndicator()
            :base(Fields.CustomTags.AggressorIndicator) {}
        public AggressorIndicator(Boolean val)
            :base(Fields.CustomTags.AggressorIndicator, val) {}


        // Field Enumerations
        public const Boolean YES = true;
        public const Boolean NO = false;
    }


    /// <summary>
    /// RefreshQty Field
    /// </summary>/
    public sealed class RefreshQty : QuickFix.Fields.DecimalField
    {
        public RefreshQty()
            :base(Fields.CustomTags.RefreshQty) {}
        public RefreshQty(Decimal val)
            :base(Fields.CustomTags.RefreshQty, val) {}

    }


    /// <summary>
    /// TradeHandlingInstr Field
    /// </summary>/
    public sealed class TradeHandlingInstr : QuickFix.Fields.CharField
    {
        public TradeHandlingInstr()
            :base(Fields.CustomTags.TradeHandlingInstr) {}
        public TradeHandlingInstr(char val)
            :base(Fields.CustomTags.TradeHandlingInstr, val) {}


        // Field Enumerations
        public const char TRADE_CONFIRMATION = '0';
        public const char TWO_PARTY_REPORT = '1';
        public const char ONE_PARTY_REPORT_FOR_MATCHING = '2';
        public const char ONE_PARTY_REPORT_FOR_PASS_THROUGH = '3';
        public const char AUTOMATED_FLOOR_ORDER_ROUTING = '4';
        public const char TWO_PARTY_REPORT_FOR_CLAIM = '5';
        public const char THIRD_PARTY_REPORT_FOR_PASS_THROUGH = '7';
    }


    /// <summary>
    /// OrigTradeID Field
    /// </summary>/
    public sealed class OrigTradeID : QuickFix.Fields.StringField
    {
        public OrigTradeID()
            :base(Fields.CustomTags.OrigTradeID) {}
        public OrigTradeID(string val)
            :base(Fields.CustomTags.OrigTradeID, val) {}

    }


    /// <summary>
    /// DisplayQty Field
    /// </summary>/
    public sealed class DisplayQty : QuickFix.Fields.DecimalField
    {
        public DisplayQty()
            :base(Fields.CustomTags.DisplayQty) {}
        public DisplayQty(Decimal val)
            :base(Fields.CustomTags.DisplayQty, val) {}

    }


    /// <summary>
    /// Volatility Field
    /// </summary>/
    public sealed class Volatility : QuickFix.Fields.DecimalField
    {
        public Volatility()
            :base(Fields.CustomTags.Volatility) {}
        public Volatility(Decimal val)
            :base(Fields.CustomTags.Volatility, val) {}

    }


    /// <summary>
    /// ExpirationTimeValue Field
    /// </summary>/
    public sealed class ExpirationTimeValue : QuickFix.Fields.DecimalField
    {
        public ExpirationTimeValue()
            :base(Fields.CustomTags.ExpirationTimeValue) {}
        public ExpirationTimeValue(Decimal val)
            :base(Fields.CustomTags.ExpirationTimeValue, val) {}

    }


    /// <summary>
    /// RiskFreeRate Field
    /// </summary>/
    public sealed class RiskFreeRate : QuickFix.Fields.DecimalField
    {
        public RiskFreeRate()
            :base(Fields.CustomTags.RiskFreeRate) {}
        public RiskFreeRate(Decimal val)
            :base(Fields.CustomTags.RiskFreeRate, val) {}

    }


    /// <summary>
    /// MarketSegmentID Field
    /// </summary>/
    public sealed class MarketSegmentID : QuickFix.Fields.StringField
    {
        public MarketSegmentID()
            :base(Fields.CustomTags.MarketSegmentID) {}
        public MarketSegmentID(string val)
            :base(Fields.CustomTags.MarketSegmentID, val) {}

    }


    /// <summary>
    /// NoFills Field
    /// </summary>/
    public sealed class NoFills : QuickFix.Fields.IntField
    {
        public NoFills()
            :base(Fields.CustomTags.NoFills) {}
        public NoFills(int val)
            :base(Fields.CustomTags.NoFills, val) {}

    }


    /// <summary>
    /// FillExecID Field
    /// </summary>/
    public sealed class FillExecID : QuickFix.Fields.StringField
    {
        public FillExecID()
            :base(Fields.CustomTags.FillExecID) {}
        public FillExecID(string val)
            :base(Fields.CustomTags.FillExecID, val) {}

    }


    /// <summary>
    /// FillPx Field
    /// </summary>/
    public sealed class FillPx : QuickFix.Fields.DecimalField
    {
        public FillPx()
            :base(Fields.CustomTags.FillPx) {}
        public FillPx(Decimal val)
            :base(Fields.CustomTags.FillPx, val) {}

    }


    /// <summary>
    /// FillQty Field
    /// </summary>/
    public sealed class FillQty : QuickFix.Fields.DecimalField
    {
        public FillQty()
            :base(Fields.CustomTags.FillQty) {}
        public FillQty(Decimal val)
            :base(Fields.CustomTags.FillQty, val) {}

    }


    /// <summary>
    /// LegAllocID Field
    /// </summary>/
    public sealed class LegAllocID : QuickFix.Fields.StringField
    {
        public LegAllocID()
            :base(Fields.CustomTags.LegAllocID) {}
        public LegAllocID(string val)
            :base(Fields.CustomTags.LegAllocID, val) {}

    }


    /// <summary>
    /// LegPutOrCall Field
    /// </summary>/
    public sealed class LegPutOrCall : QuickFix.Fields.IntField
    {
        public LegPutOrCall()
            :base(Fields.CustomTags.LegPutOrCall) {}
        public LegPutOrCall(int val)
            :base(Fields.CustomTags.LegPutOrCall, val) {}

    }


    /// <summary>
    /// MassActionReportID Field
    /// </summary>/
    public sealed class MassActionReportID : QuickFix.Fields.StringField
    {
        public MassActionReportID()
            :base(Fields.CustomTags.MassActionReportID) {}
        public MassActionReportID(string val)
            :base(Fields.CustomTags.MassActionReportID, val) {}

    }


    /// <summary>
    /// MassActionType Field
    /// </summary>/
    public sealed class MassActionType : QuickFix.Fields.IntField
    {
        public MassActionType()
            :base(Fields.CustomTags.MassActionType) {}
        public MassActionType(int val)
            :base(Fields.CustomTags.MassActionType, val) {}


        // Field Enumerations
        public const int SUSPEND_ORDERS = 1;
        public const int RELEASE_ORDERS_FROM_SUSPENSION = 2;
        public const int CANCEL_ORDERS = 3;
    }


    /// <summary>
    /// MassActionScope Field
    /// </summary>/
    public sealed class MassActionScope : QuickFix.Fields.IntField
    {
        public MassActionScope()
            :base(Fields.CustomTags.MassActionScope) {}
        public MassActionScope(int val)
            :base(Fields.CustomTags.MassActionScope, val) {}


        // Field Enumerations
        public const int ALL_ORDERS_FOR_A_SECURITY = 1;
        public const int ALL_ORDERS_FOR_AN_UNDERLYING_SECURITY = 2;
        public const int ALL_ORDERS_FOR_A_PRODUCT = 3;
        public const int ALL_ORDERS_FOR_A_CFICODE = 4;
        public const int ALL_ORDERS_FOR_A_SECURITYTYPE = 5;
        public const int ALL_ORDERS_FOR_A_TRADING_SESSION = 6;
        public const int ALL_ORDERS = 7;
        public const int ALL_ORDERS_FOR_A_MARKET = 8;
        public const int ALL_ORDERS_FOR_A_MARKET_SEGMENT = 9;
        public const int ALL_ORDERS_FOR_A_SECURITY_GROUP = 10;
        public const int CANCEL_FOR_SECURITY_ISSUER = 11;
        public const int CANCEL_FOR_ISSUER_OF_UNDERLYING_SECURITY = 12;
        public const int INSTRUMENT = 1;
        public const int MARKET_SEGMENT = 9;
        public const int GROUP_ORDER = 10;
    }


    /// <summary>
    /// MassActionResponse Field
    /// </summary>/
    public sealed class MassActionResponse : QuickFix.Fields.IntField
    {
        public MassActionResponse()
            :base(Fields.CustomTags.MassActionResponse) {}
        public MassActionResponse(int val)
            :base(Fields.CustomTags.MassActionResponse, val) {}


        // Field Enumerations
        public const int REJECTED = 0;
        public const int ACCEPTED = 1;
    }


    /// <summary>
    /// ContingencyType Field
    /// </summary>/
    public sealed class ContingencyType : QuickFix.Fields.IntField
    {
        public ContingencyType()
            :base(Fields.CustomTags.ContingencyType) {}
        public ContingencyType(int val)
            :base(Fields.CustomTags.ContingencyType, val) {}


        // Field Enumerations
        public const int ONE_CANCELS_THE_OTHER = 1;
        public const int ONE_TRIGGERS_THE_OTHER = 2;
        public const int ONE_UPDATES_THE_OTHER_3 = 3;
        public const int ONE_UPDATES_THE_OTHER_4 = 4;
    }


    /// <summary>
    /// EncryptedPasswordMethod Field
    /// </summary>/
    public sealed class EncryptedPasswordMethod : QuickFix.Fields.IntField
    {
        public EncryptedPasswordMethod()
            :base(Fields.CustomTags.EncryptedPasswordMethod) {}
        public EncryptedPasswordMethod(int val)
            :base(Fields.CustomTags.EncryptedPasswordMethod, val) {}

    }


    /// <summary>
    /// EncryptedPasswordLen Field
    /// </summary>/
    public sealed class EncryptedPasswordLen : QuickFix.Fields.IntField
    {
        public EncryptedPasswordLen()
            :base(Fields.CustomTags.EncryptedPasswordLen) {}
        public EncryptedPasswordLen(int val)
            :base(Fields.CustomTags.EncryptedPasswordLen, val) {}

    }


    /// <summary>
    /// EncryptedPassword Field
    /// </summary>/
    public sealed class EncryptedPassword : QuickFix.Fields.StringField
    {
        public EncryptedPassword()
            :base(Fields.CustomTags.EncryptedPassword) {}
        public EncryptedPassword(string val)
            :base(Fields.CustomTags.EncryptedPassword, val) {}

    }


    /// <summary>
    /// LegLastQty Field
    /// </summary>/
    public sealed class LegLastQty : QuickFix.Fields.DecimalField
    {
        public LegLastQty()
            :base(Fields.CustomTags.LegLastQty) {}
        public LegLastQty(Decimal val)
            :base(Fields.CustomTags.LegLastQty, val) {}

    }


    /// <summary>
    /// TradingSystemName Field
    /// </summary>/
    public sealed class TradingSystemName : QuickFix.Fields.StringField
    {
        public TradingSystemName()
            :base(Fields.CustomTags.TradingSystemName) {}
        public TradingSystemName(string val)
            :base(Fields.CustomTags.TradingSystemName, val) {}

    }


    /// <summary>
    /// TradingSystemVersion Field
    /// </summary>/
    public sealed class TradingSystemVersion : QuickFix.Fields.StringField
    {
        public TradingSystemVersion()
            :base(Fields.CustomTags.TradingSystemVersion) {}
        public TradingSystemVersion(string val)
            :base(Fields.CustomTags.TradingSystemVersion, val) {}

    }


    /// <summary>
    /// TradingSystemVendor Field
    /// </summary>/
    public sealed class TradingSystemVendor : QuickFix.Fields.StringField
    {
        public TradingSystemVendor()
            :base(Fields.CustomTags.TradingSystemVendor) {}
        public TradingSystemVendor(string val)
            :base(Fields.CustomTags.TradingSystemVendor, val) {}

    }


    /// <summary>
    /// FillYieldType Field
    /// </summary>/
    public sealed class FillYieldType : QuickFix.Fields.StringField
    {
        public FillYieldType()
            :base(Fields.CustomTags.FillYieldType) {}
        public FillYieldType(string val)
            :base(Fields.CustomTags.FillYieldType, val) {}

    }


    /// <summary>
    /// OrderOrigination Field
    /// </summary>/
    public sealed class OrderOrigination : QuickFix.Fields.IntField
    {
        public OrderOrigination()
            :base(Fields.CustomTags.OrderOrigination) {}
        public OrderOrigination(int val)
            :base(Fields.CustomTags.OrderOrigination, val) {}


        // Field Enumerations
        public const int ORDER_RECEIVED_FROM_CUSTOMER = 1;
        public const int ORDER_RECEIVED_FROM_WITHIN_FIRM = 2;
        public const int ORDER_RECEIVED_FROM_ANOTHER_BROKER_DEALER = 3;
        public const int ORDER_RECEIVED_FROM_CUSTOMER_OR_ORIGINATED_WITHIN_FIRM = 4;
        public const int ORDER_RECEIVED_FROM_DIRECT_OR_SPONSORED_ACCESS_CUSTOMER = 5;
        public const int ORDER_RECEIVED_FROM_OTHER_NON_DEA = 99;
    }


    /// <summary>
    /// PartyRoleQualifier Field
    /// </summary>/
    public sealed class PartyRoleQualifier : QuickFix.Fields.IntField
    {
        public PartyRoleQualifier()
            :base(Fields.CustomTags.PartyRoleQualifier) {}
        public PartyRoleQualifier(int val)
            :base(Fields.CustomTags.PartyRoleQualifier, val) {}


        // Field Enumerations
        public const int ALGORITHM = 22;
        public const int FIRM_OR_LEGAL_ENTITY = 23;
        public const int NATURAL_PERSON = 24;
    }


    /// <summary>
    /// NoOrderAttributes Field
    /// </summary>/
    public sealed class NoOrderAttributes : QuickFix.Fields.IntField
    {
        public NoOrderAttributes()
            :base(Fields.CustomTags.NoOrderAttributes) {}
        public NoOrderAttributes(int val)
            :base(Fields.CustomTags.NoOrderAttributes, val) {}

    }


    /// <summary>
    /// OrderAttributeType Field
    /// </summary>/
    public sealed class OrderAttributeType : QuickFix.Fields.IntField
    {
        public OrderAttributeType()
            :base(Fields.CustomTags.OrderAttributeType) {}
        public OrderAttributeType(int val)
            :base(Fields.CustomTags.OrderAttributeType, val) {}


        // Field Enumerations
        public const int AGGREGATED_ORDER = 0;
        public const int PENDING_ALLOCATION = 1;
        public const int LIQUIDITY_PROVISION_ACTIVITY_ORDER = 2;
        public const int RISK_REDUCTION_ORDER = 3;
        public const int ALGORITHMIC_ORDER = 4;
        public const int SYSTEMATIC_INTERNALIZER_ORDER = 5;
    }


    /// <summary>
    /// OrderAttributeValue Field
    /// </summary>/
    public sealed class OrderAttributeValue : QuickFix.Fields.StringField
    {
        public OrderAttributeValue()
            :base(Fields.CustomTags.OrderAttributeValue) {}
        public OrderAttributeValue(string val)
            :base(Fields.CustomTags.OrderAttributeValue, val) {}

    }


    /// <summary>
    /// StartSequenceNumber Field
    /// </summary>/
    public sealed class StartSequenceNumber : QuickFix.Fields.IntField
    {
        public StartSequenceNumber()
            :base(Fields.CustomTags.StartSequenceNumber) {}
        public StartSequenceNumber(int val)
            :base(Fields.CustomTags.StartSequenceNumber, val) {}

    }


    /// <summary>
    /// RequestTime Field
    /// </summary>/
    public sealed class RequestTime : QuickFix.Fields.StringField
    {
        public RequestTime()
            :base(Fields.CustomTags.RequestTime) {}
        public RequestTime(string val)
            :base(Fields.CustomTags.RequestTime, val) {}

    }


    /// <summary>
    /// SelfMatchPreventionID Field
    /// </summary>/
    public sealed class SelfMatchPreventionID : QuickFix.Fields.StringField
    {
        public SelfMatchPreventionID()
            :base(Fields.CustomTags.SelfMatchPreventionID) {}
        public SelfMatchPreventionID(string val)
            :base(Fields.CustomTags.SelfMatchPreventionID, val) {}

    }


    /// <summary>
    /// SMPInstruction Field
    /// </summary>/
    public sealed class SMPInstruction : QuickFix.Fields.CharField
    {
        public SMPInstruction()
            :base(Fields.CustomTags.SMPInstruction) {}
        public SMPInstruction(char val)
            :base(Fields.CustomTags.SMPInstruction, val) {}


        // Field Enumerations
        public const char SMP_INST_TYPE_CANCEL_RESTING = 'O';
        public const char SMP_INST_TYPE_CANCEL_AGGRESSOR = 'N';
        public const char SMP_INST_TYPE_CANCEL_BOTH = 'B';
    }


    /// <summary>
    /// TrdRegPublicationReason Field
    /// </summary>/
    public sealed class TrdRegPublicationReason : QuickFix.Fields.IntField
    {
        public TrdRegPublicationReason()
            :base(Fields.CustomTags.TrdRegPublicationReason) {}
        public TrdRegPublicationReason(int val)
            :base(Fields.CustomTags.TrdRegPublicationReason, val) {}


        // Field Enumerations
        public const int ILQD = 4;
        public const int SIZE = 5;
        public const int LRGS = 6;
    }


    /// <summary>
    /// TradingVenueRegulatoryTradeID Field
    /// </summary>/
    public sealed class TradingVenueRegulatoryTradeID : QuickFix.Fields.StringField
    {
        public TradingVenueRegulatoryTradeID()
            :base(Fields.CustomTags.TradingVenueRegulatoryTradeID) {}
        public TradingVenueRegulatoryTradeID(string val)
            :base(Fields.CustomTags.TradingVenueRegulatoryTradeID, val) {}

    }


    /// <summary>
    /// UserType Field
    /// </summary>/
    public sealed class UserType : QuickFix.Fields.IntField
    {
        public UserType()
            :base(Fields.CustomTags.UserType) {}
        public UserType(int val)
            :base(Fields.CustomTags.UserType, val) {}


        // Field Enumerations
        public const int TRADING_FIRM = 1;
        public const int CLEARING_FIRM = 2;
    }


    /// <summary>
    /// StrategyPreference Field
    /// </summary>/
    public sealed class StrategyPreference : QuickFix.Fields.IntField
    {
        public StrategyPreference()
            :base(Fields.CustomTags.StrategyPreference) {}
        public StrategyPreference(int val)
            :base(Fields.CustomTags.StrategyPreference, val) {}


        // Field Enumerations
        public const int LEGACY_STRATEGY_INFORMATION = 0;
        public const int NEW_STRATEGY_INFORMATION = 1;
    }


    /// <summary>
    /// TimeStampPreference Field
    /// </summary>/
    public sealed class TimeStampPreference : QuickFix.Fields.IntField
    {
        public TimeStampPreference()
            :base(Fields.CustomTags.TimeStampPreference) {}
        public TimeStampPreference(int val)
            :base(Fields.CustomTags.TimeStampPreference, val) {}


        // Field Enumerations
        public const int STANDARD_TIME_PRECISION = 0;
        public const int INCREASED_TIME_PRECISION = 1;
    }


    /// <summary>
    /// PublishClearingAllocations Field
    /// </summary>/
    public sealed class PublishClearingAllocations : QuickFix.Fields.IntField
    {
        public PublishClearingAllocations()
            :base(Fields.CustomTags.PublishClearingAllocations) {}
        public PublishClearingAllocations(int val)
            :base(Fields.CustomTags.PublishClearingAllocations, val) {}


        // Field Enumerations
        public const int DO_NOT_SEND_CLEARING_ALLOCATION = 0;
        public const int SEND_CLEARING_ALLOCATION = 1;
    }


    /// <summary>
    /// PublishMktCreationRealtime Field
    /// </summary>/
    public sealed class PublishMktCreationRealtime : QuickFix.Fields.IntField
    {
        public PublishMktCreationRealtime()
            :base(Fields.CustomTags.PublishMktCreationRealtime) {}
        public PublishMktCreationRealtime(int val)
            :base(Fields.CustomTags.PublishMktCreationRealtime, val) {}


        // Field Enumerations
        public const int NO = 0;
        public const int YES = 1;
    }


    /// <summary>
    /// OriginatorUserID Field
    /// </summary>/
    public sealed class OriginatorUserID : QuickFix.Fields.StringField
    {
        public OriginatorUserID()
            :base(Fields.CustomTags.OriginatorUserID) {}
        public OriginatorUserID(string val)
            :base(Fields.CustomTags.OriginatorUserID, val) {}

    }


    /// <summary>
    /// CustomerAccountRefID Field
    /// </summary>/
    public sealed class CustomerAccountRefID : QuickFix.Fields.StringField
    {
        public CustomerAccountRefID()
            :base(Fields.CustomTags.CustomerAccountRefID) {}
        public CustomerAccountRefID(string val)
            :base(Fields.CustomTags.CustomerAccountRefID, val) {}

    }


    /// <summary>
    /// RequestID Field
    /// </summary>/
    public sealed class RequestID : QuickFix.Fields.StringField
    {
        public RequestID()
            :base(Fields.CustomTags.RequestID) {}
        public RequestID(string val)
            :base(Fields.CustomTags.RequestID, val) {}

    }


    /// <summary>
    /// OriginalSecondaryExecID Field
    /// </summary>/
    public sealed class OriginalSecondaryExecID : QuickFix.Fields.StringField
    {
        public OriginalSecondaryExecID()
            :base(Fields.CustomTags.OriginalSecondaryExecID) {}
        public OriginalSecondaryExecID(string val)
            :base(Fields.CustomTags.OriginalSecondaryExecID, val) {}

    }


    /// <summary>
    /// InvestmentDecision Field
    /// </summary>/
    public sealed class InvestmentDecision : QuickFix.Fields.IntField
    {
        public InvestmentDecision()
            :base(Fields.CustomTags.InvestmentDecision) {}
        public InvestmentDecision(int val)
            :base(Fields.CustomTags.InvestmentDecision, val) {}

    }


    /// <summary>
    /// ExecutionDecision Field
    /// </summary>/
    public sealed class ExecutionDecision : QuickFix.Fields.IntField
    {
        public ExecutionDecision()
            :base(Fields.CustomTags.ExecutionDecision) {}
        public ExecutionDecision(int val)
            :base(Fields.CustomTags.ExecutionDecision, val) {}

    }


    /// <summary>
    /// ClientIDCode Field
    /// </summary>/
    public sealed class ClientIDCode : QuickFix.Fields.IntField
    {
        public ClientIDCode()
            :base(Fields.CustomTags.ClientIDCode) {}
        public ClientIDCode(int val)
            :base(Fields.CustomTags.ClientIDCode, val) {}

    }


    /// <summary>
    /// CorrelationClOrdID Field
    /// </summary>/
    public sealed class CorrelationClOrdID : QuickFix.Fields.StringField
    {
        public CorrelationClOrdID()
            :base(Fields.CustomTags.CorrelationClOrdID) {}
        public CorrelationClOrdID(string val)
            :base(Fields.CustomTags.CorrelationClOrdID, val) {}

    }


    /// <summary>
    /// DisplayFactor Field
    /// </summary>/
    public sealed class DisplayFactor : QuickFix.Fields.StringField
    {
        public DisplayFactor()
            :base(Fields.CustomTags.DisplayFactor) {}
        public DisplayFactor(string val)
            :base(Fields.CustomTags.DisplayFactor, val) {}

    }


    /// <summary>
    /// TTClOrdID Field
    /// </summary>/
    public sealed class TTClOrdID : QuickFix.Fields.StringField
    {
        public TTClOrdID()
            :base(Fields.CustomTags.TTClOrdID) {}
        public TTClOrdID(string val)
            :base(Fields.CustomTags.TTClOrdID, val) {}

    }


    /// <summary>
    /// TTID Field
    /// </summary>/
    public sealed class TTID : QuickFix.Fields.StringField
    {
        public TTID()
            :base(Fields.CustomTags.TTID) {}
        public TTID(string val)
            :base(Fields.CustomTags.TTID, val) {}

    }


    /// <summary>
    /// ExchangeSendingTime Field
    /// </summary>/
    public sealed class ExchangeSendingTime : QuickFix.Fields.StringField
    {
        public ExchangeSendingTime()
            :base(Fields.CustomTags.ExchangeSendingTime) {}
        public ExchangeSendingTime(string val)
            :base(Fields.CustomTags.ExchangeSendingTime, val) {}

    }


    /// <summary>
    /// ExchangeTransactTime Field
    /// </summary>/
    public sealed class ExchangeTransactTime : QuickFix.Fields.StringField
    {
        public ExchangeTransactTime()
            :base(Fields.CustomTags.ExchangeTransactTime) {}
        public ExchangeTransactTime(string val)
            :base(Fields.CustomTags.ExchangeTransactTime, val) {}

    }


    /// <summary>
    /// StagedOrderMsg Field
    /// </summary>/
    public sealed class StagedOrderMsg : QuickFix.Fields.StringField
    {
        public StagedOrderMsg()
            :base(Fields.CustomTags.StagedOrderMsg) {}
        public StagedOrderMsg(string val)
            :base(Fields.CustomTags.StagedOrderMsg, val) {}

    }


    /// <summary>
    /// StagedOrderStatus Field
    /// </summary>/
    public sealed class StagedOrderStatus : QuickFix.Fields.CharField
    {
        public StagedOrderStatus()
            :base(Fields.CustomTags.StagedOrderStatus) {}
        public StagedOrderStatus(char val)
            :base(Fields.CustomTags.StagedOrderStatus, val) {}


        // Field Enumerations
        public const char Available = 'A';
        public const char Owned = 'O';
    }


    /// <summary>
    /// StagedOrderOwner Field
    /// </summary>/
    public sealed class StagedOrderOwner : QuickFix.Fields.StringField
    {
        public StagedOrderOwner()
            :base(Fields.CustomTags.StagedOrderOwner) {}
        public StagedOrderOwner(string val)
            :base(Fields.CustomTags.StagedOrderOwner, val) {}

    }


    /// <summary>
    /// NoLinks Field
    /// </summary>/
    public sealed class NoLinks : QuickFix.Fields.IntField
    {
        public NoLinks()
            :base(Fields.CustomTags.NoLinks) {}
        public NoLinks(int val)
            :base(Fields.CustomTags.NoLinks, val) {}

    }


    /// <summary>
    /// LinkID Field
    /// </summary>/
    public sealed class LinkID : QuickFix.Fields.StringField
    {
        public LinkID()
            :base(Fields.CustomTags.LinkID) {}
        public LinkID(string val)
            :base(Fields.CustomTags.LinkID, val) {}

    }


    /// <summary>
    /// LinkType Field
    /// </summary>/
    public sealed class LinkType : QuickFix.Fields.CharField
    {
        public LinkType()
            :base(Fields.CustomTags.LinkType) {}
        public LinkType(char val)
            :base(Fields.CustomTags.LinkType, val) {}


        // Field Enumerations
        public const char STAGED_CHILD = '7';
        public const char PARENT_ORDER_ID = 'P';
        public const char POSITION_TRANSFER_ID = 'X';
    }


    /// <summary>
    /// ExternalSource Field
    /// </summary>/
    public sealed class ExternalSource : QuickFix.Fields.BooleanField
    {
        public ExternalSource()
            :base(Fields.CustomTags.ExternalSource) {}
        public ExternalSource(Boolean val)
            :base(Fields.CustomTags.ExternalSource, val) {}

    }


    /// <summary>
    /// OrderIDGUID Field
    /// </summary>/
    public sealed class OrderIDGUID : QuickFix.Fields.StringField
    {
        public OrderIDGUID()
            :base(Fields.CustomTags.OrderIDGUID) {}
        public OrderIDGUID(string val)
            :base(Fields.CustomTags.OrderIDGUID, val) {}

    }


    /// <summary>
    /// OrderSource Field
    /// </summary>/
    public sealed class OrderSource : QuickFix.Fields.IntField
    {
        public OrderSource()
            :base(Fields.CustomTags.OrderSource) {}
        public OrderSource(int val)
            :base(Fields.CustomTags.OrderSource, val) {}


        // Field Enumerations
        public const int SOURCE_ASE = 0;
        public const int SOURCE_NTW = 2;
        public const int SOURCE_INVALID = 3;
        public const int SOURCE_T_TRADER = 4;
        public const int SOURCE_MOBILE = 6;
        public const int SOURCE_ROE = 7;
        public const int SOURCE_EXTERNAL = 9;
        public const int SOURCE_FIX_ADAPTER = 10;
        public const int SOURCE_AGGREGATOR = 11;
        public const int SOURCE_BOUNCER = 12;
        public const int SOURCE_LAMBDA_LIQUIDATOR = 13;
        public const int SOURCE_EXTERNAL_FIX_ADAPTER = 14;
        public const int SOURCE_PRIME_ASE = 15;
        public const int SOURCE_NIMBUS = 16;
        public const int SOURCE_ADL = 17;
        public const int SOURCE_TTSDK = 18;
        public const int SOURCE_TT_ALGO = 19;
        public const int SOURCE_ADL_PRIME = 20;
        public const int SOURCE_TTSDK_PRIME = 21;
        public const int SOURCE_TT_ALGO_PRIME = 22;
        public const int SOURCE_CHART = 23;
        public const int SOURCE_TTD = 24;
        public const int SOURCE_TTD_CHART = 25;
        public const int SOURCE_TTINT = 26;
        public const int SOURCE_TT_ADMIN = 27;
        public const int SOURCE_DOTNET_API_CLT = 28;
        public const int SOURCE_DOTNET_API_SRV = 29;
        public const int SOURCE_CPP_API = 30;
        public const int SOURCE_OPTIONS_RISK = 31;
        public const int SOURCE_EXTERNAL_UPLOAD = 32;
    }


    /// <summary>
    /// FillTradingVenueRegulatoryTradeID Field
    /// </summary>/
    public sealed class FillTradingVenueRegulatoryTradeID : QuickFix.Fields.StringField
    {
        public FillTradingVenueRegulatoryTradeID()
            :base(Fields.CustomTags.FillTradingVenueRegulatoryTradeID) {}
        public FillTradingVenueRegulatoryTradeID(string val)
            :base(Fields.CustomTags.FillTradingVenueRegulatoryTradeID, val) {}

    }


    /// <summary>
    /// FillLastLiquidityIndicator Field
    /// </summary>/
    public sealed class FillLastLiquidityIndicator : QuickFix.Fields.IntField
    {
        public FillLastLiquidityIndicator()
            :base(Fields.CustomTags.FillLastLiquidityIndicator) {}
        public FillLastLiquidityIndicator(int val)
            :base(Fields.CustomTags.FillLastLiquidityIndicator, val) {}


        // Field Enumerations
        public const int ADDED_LIQUIDITY = 1;
        public const int REMOVED_LIQUIDITY = 2;
    }


    /// <summary>
    /// LegNoFills Field
    /// </summary>/
    public sealed class LegNoFills : QuickFix.Fields.IntField
    {
        public LegNoFills()
            :base(Fields.CustomTags.LegNoFills) {}
        public LegNoFills(int val)
            :base(Fields.CustomTags.LegNoFills, val) {}

    }


    /// <summary>
    /// LegFillExecID Field
    /// </summary>/
    public sealed class LegFillExecID : QuickFix.Fields.StringField
    {
        public LegFillExecID()
            :base(Fields.CustomTags.LegFillExecID) {}
        public LegFillExecID(string val)
            :base(Fields.CustomTags.LegFillExecID, val) {}

    }


    /// <summary>
    /// LegFillPx Field
    /// </summary>/
    public sealed class LegFillPx : QuickFix.Fields.DecimalField
    {
        public LegFillPx()
            :base(Fields.CustomTags.LegFillPx) {}
        public LegFillPx(Decimal val)
            :base(Fields.CustomTags.LegFillPx, val) {}

    }


    /// <summary>
    /// LegFillQty Field
    /// </summary>/
    public sealed class LegFillQty : QuickFix.Fields.DecimalField
    {
        public LegFillQty()
            :base(Fields.CustomTags.LegFillQty) {}
        public LegFillQty(Decimal val)
            :base(Fields.CustomTags.LegFillQty, val) {}

    }


    /// <summary>
    /// LegFillTradingVenueRegulatoryTradeID Field
    /// </summary>/
    public sealed class LegFillTradingVenueRegulatoryTradeID : QuickFix.Fields.StringField
    {
        public LegFillTradingVenueRegulatoryTradeID()
            :base(Fields.CustomTags.LegFillTradingVenueRegulatoryTradeID) {}
        public LegFillTradingVenueRegulatoryTradeID(string val)
            :base(Fields.CustomTags.LegFillTradingVenueRegulatoryTradeID, val) {}

    }


    /// <summary>
    /// LegFillLastLiquidityIndicator Field
    /// </summary>/
    public sealed class LegFillLastLiquidityIndicator : QuickFix.Fields.IntField
    {
        public LegFillLastLiquidityIndicator()
            :base(Fields.CustomTags.LegFillLastLiquidityIndicator) {}
        public LegFillLastLiquidityIndicator(int val)
            :base(Fields.CustomTags.LegFillLastLiquidityIndicator, val) {}


        // Field Enumerations
        public const int ADDED_LIQUIDITY = 1;
        public const int REMOVED_LIQUIDITY = 2;
    }


    /// <summary>
    /// PriceDisplayType Field
    /// </summary>/
    public sealed class PriceDisplayType : QuickFix.Fields.IntField
    {
        public PriceDisplayType()
            :base(Fields.CustomTags.PriceDisplayType) {}
        public PriceDisplayType(int val)
            :base(Fields.CustomTags.PriceDisplayType, val) {}

    }


    /// <summary>
    /// NumTickTblEntries Field
    /// </summary>/
    public sealed class NumTickTblEntries : QuickFix.Fields.IntField
    {
        public NumTickTblEntries()
            :base(Fields.CustomTags.NumTickTblEntries) {}
        public NumTickTblEntries(int val)
            :base(Fields.CustomTags.NumTickTblEntries, val) {}

    }


    /// <summary>
    /// NumTicks Field
    /// </summary>/
    public sealed class NumTicks : QuickFix.Fields.IntField
    {
        public NumTicks()
            :base(Fields.CustomTags.NumTicks) {}
        public NumTicks(int val)
            :base(Fields.CustomTags.NumTicks, val) {}

    }


    /// <summary>
    /// MaxPrice Field
    /// </summary>/
    public sealed class MaxPrice : QuickFix.Fields.DecimalField
    {
        public MaxPrice()
            :base(Fields.CustomTags.MaxPrice) {}
        public MaxPrice(Decimal val)
            :base(Fields.CustomTags.MaxPrice, val) {}

    }


    /// <summary>
    /// MinLotSize Field
    /// </summary>/
    public sealed class MinLotSize : QuickFix.Fields.DecimalField
    {
        public MinLotSize()
            :base(Fields.CustomTags.MinLotSize) {}
        public MinLotSize(Decimal val)
            :base(Fields.CustomTags.MinLotSize, val) {}

    }


    /// <summary>
    /// NumberOfBlocks Field
    /// </summary>/
    public sealed class NumberOfBlocks : QuickFix.Fields.IntField
    {
        public NumberOfBlocks()
            :base(Fields.CustomTags.NumberOfBlocks) {}
        public NumberOfBlocks(int val)
            :base(Fields.CustomTags.NumberOfBlocks, val) {}

    }


    /// <summary>
    /// TradesInFlow Field
    /// </summary>/
    public sealed class TradesInFlow : QuickFix.Fields.CharField
    {
        public TradesInFlow()
            :base(Fields.CustomTags.TradesInFlow) {}
        public TradesInFlow(char val)
            :base(Fields.CustomTags.TradesInFlow, val) {}

    }


    /// <summary>
    /// ExchTickSize Field
    /// </summary>/
    public sealed class ExchTickSize : QuickFix.Fields.DecimalField
    {
        public ExchTickSize()
            :base(Fields.CustomTags.ExchTickSize) {}
        public ExchTickSize(Decimal val)
            :base(Fields.CustomTags.ExchTickSize, val) {}

    }


    /// <summary>
    /// ExchPointValue Field
    /// </summary>/
    public sealed class ExchPointValue : QuickFix.Fields.DecimalField
    {
        public ExchPointValue()
            :base(Fields.CustomTags.ExchPointValue) {}
        public ExchPointValue(Decimal val)
            :base(Fields.CustomTags.ExchPointValue, val) {}

    }


    /// <summary>
    /// TextA Field
    /// </summary>/
    public sealed class TextA : QuickFix.Fields.StringField
    {
        public TextA()
            :base(Fields.CustomTags.TextA) {}
        public TextA(string val)
            :base(Fields.CustomTags.TextA, val) {}

    }


    /// <summary>
    /// TextB Field
    /// </summary>/
    public sealed class TextB : QuickFix.Fields.StringField
    {
        public TextB()
            :base(Fields.CustomTags.TextB) {}
        public TextB(string val)
            :base(Fields.CustomTags.TextB, val) {}

    }


    /// <summary>
    /// TextTT Field
    /// </summary>/
    public sealed class TextTT : QuickFix.Fields.StringField
    {
        public TextTT()
            :base(Fields.CustomTags.TextTT) {}
        public TextTT(string val)
            :base(Fields.CustomTags.TextTT, val) {}

    }


    /// <summary>
    /// TextC Field
    /// </summary>/
    public sealed class TextC : QuickFix.Fields.StringField
    {
        public TextC()
            :base(Fields.CustomTags.TextC) {}
        public TextC(string val)
            :base(Fields.CustomTags.TextC, val) {}

    }


    /// <summary>
    /// TimeReceivedFromExchange Field
    /// </summary>/
    public sealed class TimeReceivedFromExchange : QuickFix.Fields.DateTimeField
    {
        public TimeReceivedFromExchange()
            :base(Fields.CustomTags.TimeReceivedFromExchange) {}
        public TimeReceivedFromExchange(DateTime val)
            :base(Fields.CustomTags.TimeReceivedFromExchange, val) {}
        public TimeReceivedFromExchange(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TimeReceivedFromExchange, val, showMilliseconds) {}
		public TimeReceivedFromExchange(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TimeReceivedFromExchange, val, precision) {}

    }


    /// <summary>
    /// DropCopyOrder Field
    /// </summary>/
    public sealed class DropCopyOrder : QuickFix.Fields.BooleanField
    {
        public DropCopyOrder()
            :base(Fields.CustomTags.DropCopyOrder) {}
        public DropCopyOrder(Boolean val)
            :base(Fields.CustomTags.DropCopyOrder, val) {}


        // Field Enumerations
        public const Boolean YES = true;
        public const Boolean NO = false;
    }


    /// <summary>
    /// ByPassSessionRecovery Field
    /// </summary>/
    public sealed class ByPassSessionRecovery : QuickFix.Fields.BooleanField
    {
        public ByPassSessionRecovery()
            :base(Fields.CustomTags.ByPassSessionRecovery) {}
        public ByPassSessionRecovery(Boolean val)
            :base(Fields.CustomTags.ByPassSessionRecovery, val) {}

    }


    /// <summary>
    /// EchoDC_01 Field
    /// </summary>/
    public sealed class EchoDC_01 : QuickFix.Fields.StringField
    {
        public EchoDC_01()
            :base(Fields.CustomTags.EchoDC_01) {}
        public EchoDC_01(string val)
            :base(Fields.CustomTags.EchoDC_01, val) {}

    }


    /// <summary>
    /// EchoDC_02 Field
    /// </summary>/
    public sealed class EchoDC_02 : QuickFix.Fields.StringField
    {
        public EchoDC_02()
            :base(Fields.CustomTags.EchoDC_02) {}
        public EchoDC_02(string val)
            :base(Fields.CustomTags.EchoDC_02, val) {}

    }


    /// <summary>
    /// EchoDC_03 Field
    /// </summary>/
    public sealed class EchoDC_03 : QuickFix.Fields.StringField
    {
        public EchoDC_03()
            :base(Fields.CustomTags.EchoDC_03) {}
        public EchoDC_03(string val)
            :base(Fields.CustomTags.EchoDC_03, val) {}

    }


    /// <summary>
    /// EchoDC_04 Field
    /// </summary>/
    public sealed class EchoDC_04 : QuickFix.Fields.StringField
    {
        public EchoDC_04()
            :base(Fields.CustomTags.EchoDC_04) {}
        public EchoDC_04(string val)
            :base(Fields.CustomTags.EchoDC_04, val) {}

    }


    /// <summary>
    /// EchoDC_05 Field
    /// </summary>/
    public sealed class EchoDC_05 : QuickFix.Fields.StringField
    {
        public EchoDC_05()
            :base(Fields.CustomTags.EchoDC_05) {}
        public EchoDC_05(string val)
            :base(Fields.CustomTags.EchoDC_05, val) {}

    }


    /// <summary>
    /// EchoDC_06 Field
    /// </summary>/
    public sealed class EchoDC_06 : QuickFix.Fields.StringField
    {
        public EchoDC_06()
            :base(Fields.CustomTags.EchoDC_06) {}
        public EchoDC_06(string val)
            :base(Fields.CustomTags.EchoDC_06, val) {}

    }


    /// <summary>
    /// EchoDC_07 Field
    /// </summary>/
    public sealed class EchoDC_07 : QuickFix.Fields.StringField
    {
        public EchoDC_07()
            :base(Fields.CustomTags.EchoDC_07) {}
        public EchoDC_07(string val)
            :base(Fields.CustomTags.EchoDC_07, val) {}

    }


    /// <summary>
    /// EchoDC_08 Field
    /// </summary>/
    public sealed class EchoDC_08 : QuickFix.Fields.StringField
    {
        public EchoDC_08()
            :base(Fields.CustomTags.EchoDC_08) {}
        public EchoDC_08(string val)
            :base(Fields.CustomTags.EchoDC_08, val) {}

    }


    /// <summary>
    /// EchoDC_09 Field
    /// </summary>/
    public sealed class EchoDC_09 : QuickFix.Fields.StringField
    {
        public EchoDC_09()
            :base(Fields.CustomTags.EchoDC_09) {}
        public EchoDC_09(string val)
            :base(Fields.CustomTags.EchoDC_09, val) {}

    }


    /// <summary>
    /// EchoDC_10 Field
    /// </summary>/
    public sealed class EchoDC_10 : QuickFix.Fields.StringField
    {
        public EchoDC_10()
            :base(Fields.CustomTags.EchoDC_10) {}
        public EchoDC_10(string val)
            :base(Fields.CustomTags.EchoDC_10, val) {}

    }


    /// <summary>
    /// MlegHeadExecId Field
    /// </summary>/
    public sealed class MlegHeadExecId : QuickFix.Fields.StringField
    {
        public MlegHeadExecId()
            :base(Fields.CustomTags.MlegHeadExecId) {}
        public MlegHeadExecId(string val)
            :base(Fields.CustomTags.MlegHeadExecId, val) {}

    }


    /// <summary>
    /// UniqueExecID Field
    /// </summary>/
    public sealed class UniqueExecID : QuickFix.Fields.StringField
    {
        public UniqueExecID()
            :base(Fields.CustomTags.UniqueExecID) {}
        public UniqueExecID(string val)
            :base(Fields.CustomTags.UniqueExecID, val) {}

    }


    /// <summary>
    /// SpreadLegRatioQty Field
    /// </summary>/
    public sealed class SpreadLegRatioQty : QuickFix.Fields.DecimalField
    {
        public SpreadLegRatioQty()
            :base(Fields.CustomTags.SpreadLegRatioQty) {}
        public SpreadLegRatioQty(Decimal val)
            :base(Fields.CustomTags.SpreadLegRatioQty, val) {}

    }


    /// <summary>
    /// AccountRiskGroup Field
    /// </summary>/
    public sealed class AccountRiskGroup : QuickFix.Fields.StringField
    {
        public AccountRiskGroup()
            :base(Fields.CustomTags.AccountRiskGroup) {}
        public AccountRiskGroup(string val)
            :base(Fields.CustomTags.AccountRiskGroup, val) {}

    }


    /// <summary>
    /// TotalNumOrders Field
    /// </summary>/
    public sealed class TotalNumOrders : QuickFix.Fields.IntField
    {
        public TotalNumOrders()
            :base(Fields.CustomTags.TotalNumOrders) {}
        public TotalNumOrders(int val)
            :base(Fields.CustomTags.TotalNumOrders, val) {}

    }


    /// <summary>
    /// TargetStrategyName Field
    /// </summary>/
    public sealed class TargetStrategyName : QuickFix.Fields.StringField
    {
        public TargetStrategyName()
            :base(Fields.CustomTags.TargetStrategyName) {}
        public TargetStrategyName(string val)
            :base(Fields.CustomTags.TargetStrategyName, val) {}

    }


    /// <summary>
    /// TargetStrategyType Field
    /// </summary>/
    public sealed class TargetStrategyType : QuickFix.Fields.IntField
    {
        public TargetStrategyType()
            :base(Fields.CustomTags.TargetStrategyType) {}
        public TargetStrategyType(int val)
            :base(Fields.CustomTags.TargetStrategyType, val) {}


        // Field Enumerations
        public const int ADL = 0;
        public const int SSE = 1;
        public const int BANK_ALGO = 3;
    }


    /// <summary>
    /// BracketOrderType Field
    /// </summary>/
    public sealed class BracketOrderType : QuickFix.Fields.IntField
    {
        public BracketOrderType()
            :base(Fields.CustomTags.BracketOrderType) {}
        public BracketOrderType(int val)
            :base(Fields.CustomTags.BracketOrderType, val) {}


        // Field Enumerations
        public const int LIMIT = 0;
        public const int STOP_LIMIT = 1;
        public const int STOP_MARKET = 2;
    }


    /// <summary>
    /// BracketStopLimitOffset Field
    /// </summary>/
    public sealed class BracketStopLimitOffset : QuickFix.Fields.IntField
    {
        public BracketStopLimitOffset()
            :base(Fields.CustomTags.BracketStopLimitOffset) {}
        public BracketStopLimitOffset(int val)
            :base(Fields.CustomTags.BracketStopLimitOffset, val) {}

    }


    /// <summary>
    /// ChildTIF Field
    /// </summary>/
    public sealed class ChildTIF : QuickFix.Fields.IntField
    {
        public ChildTIF()
            :base(Fields.CustomTags.ChildTIF) {}
        public ChildTIF(int val)
            :base(Fields.CustomTags.ChildTIF, val) {}


        // Field Enumerations
        public const int GTD = 1;
        public const int GTC = 2;
        public const int IOC = 4;
        public const int FOK = 5;
        public const int GTD_PLUS = 6;
        public const int GTC_PLUS = 7;
        public const int GTDATE_PLUS = 8;
    }


    /// <summary>
    /// DiscVal Field
    /// </summary>/
    public sealed class DiscVal : QuickFix.Fields.IntField
    {
        public DiscVal()
            :base(Fields.CustomTags.DiscVal) {}
        public DiscVal(int val)
            :base(Fields.CustomTags.DiscVal, val) {}

    }


    /// <summary>
    /// DiscValType Field
    /// </summary>/
    public sealed class DiscValType : QuickFix.Fields.IntField
    {
        public DiscValType()
            :base(Fields.CustomTags.DiscValType) {}
        public DiscValType(int val)
            :base(Fields.CustomTags.DiscValType, val) {}

    }


    /// <summary>
    /// ETimeAct Field
    /// </summary>/
    public sealed class ETimeAct : QuickFix.Fields.IntField
    {
        public ETimeAct()
            :base(Fields.CustomTags.ETimeAct) {}
        public ETimeAct(int val)
            :base(Fields.CustomTags.ETimeAct, val) {}


        // Field Enumerations
        public const int CANCEL = 1;
        public const int GOTOMARKET = 2;
    }


    /// <summary>
    /// Interval Field
    /// </summary>/
    public sealed class Interval : QuickFix.Fields.IntField
    {
        public Interval()
            :base(Fields.CustomTags.Interval) {}
        public Interval(int val)
            :base(Fields.CustomTags.Interval, val) {}

    }


    /// <summary>
    /// IsTrlTrg Field
    /// </summary>/
    public sealed class IsTrlTrg : QuickFix.Fields.StringField
    {
        public IsTrlTrg()
            :base(Fields.CustomTags.IsTrlTrg) {}
        public IsTrlTrg(string val)
            :base(Fields.CustomTags.IsTrlTrg, val) {}

    }


    /// <summary>
    /// LeftoverAction Field
    /// </summary>/
    public sealed class LeftoverAction : QuickFix.Fields.IntField
    {
        public LeftoverAction()
            :base(Fields.CustomTags.LeftoverAction) {}
        public LeftoverAction(int val)
            :base(Fields.CustomTags.LeftoverAction, val) {}


        // Field Enumerations
        public const int LEAVE = 0;
        public const int PAYUP = 1;
        public const int MERGE = 2;
        public const int GOTOMARKET = 3;
    }


    /// <summary>
    /// LeftoverTicks Field
    /// </summary>/
    public sealed class LeftoverTicks : QuickFix.Fields.IntField
    {
        public LeftoverTicks()
            :base(Fields.CustomTags.LeftoverTicks) {}
        public LeftoverTicks(int val)
            :base(Fields.CustomTags.LeftoverTicks, val) {}

    }


    /// <summary>
    /// LimitPriceType Field
    /// </summary>/
    public sealed class LimitPriceType : QuickFix.Fields.IntField
    {
        public LimitPriceType()
            :base(Fields.CustomTags.LimitPriceType) {}
        public LimitPriceType(int val)
            :base(Fields.CustomTags.LimitPriceType, val) {}

    }


    /// <summary>
    /// LimitTicksAway Field
    /// </summary>/
    public sealed class LimitTicksAway : QuickFix.Fields.IntField
    {
        public LimitTicksAway()
            :base(Fields.CustomTags.LimitTicksAway) {}
        public LimitTicksAway(int val)
            :base(Fields.CustomTags.LimitTicksAway, val) {}

    }


    /// <summary>
    /// OcoStopTriggerPrice Field
    /// </summary>/
    public sealed class OcoStopTriggerPrice : QuickFix.Fields.DecimalField
    {
        public OcoStopTriggerPrice()
            :base(Fields.CustomTags.OcoStopTriggerPrice) {}
        public OcoStopTriggerPrice(Decimal val)
            :base(Fields.CustomTags.OcoStopTriggerPrice, val) {}

    }


    /// <summary>
    /// ProfitTarget Field
    /// </summary>/
    public sealed class ProfitTarget : QuickFix.Fields.IntField
    {
        public ProfitTarget()
            :base(Fields.CustomTags.ProfitTarget) {}
        public ProfitTarget(int val)
            :base(Fields.CustomTags.ProfitTarget, val) {}

    }


    /// <summary>
    /// StopLimitOffset Field
    /// </summary>/
    public sealed class StopLimitOffset : QuickFix.Fields.IntField
    {
        public StopLimitOffset()
            :base(Fields.CustomTags.StopLimitOffset) {}
        public StopLimitOffset(int val)
            :base(Fields.CustomTags.StopLimitOffset, val) {}

    }


    /// <summary>
    /// StopOrderType Field
    /// </summary>/
    public sealed class StopOrderType : QuickFix.Fields.IntField
    {
        public StopOrderType()
            :base(Fields.CustomTags.StopOrderType) {}
        public StopOrderType(int val)
            :base(Fields.CustomTags.StopOrderType, val) {}


        // Field Enumerations
        public const int LIMIT = 1;
        public const int MARKET = 2;
        public const int TT_STOP = 3;
    }


    /// <summary>
    /// StopTarget Field
    /// </summary>/
    public sealed class StopTarget : QuickFix.Fields.IntField
    {
        public StopTarget()
            :base(Fields.CustomTags.StopTarget) {}
        public StopTarget(int val)
            :base(Fields.CustomTags.StopTarget, val) {}

    }


    /// <summary>
    /// TriggerPriceType Field
    /// </summary>/
    public sealed class TriggerPriceType : QuickFix.Fields.CharField
    {
        public TriggerPriceType()
            :base(Fields.CustomTags.TriggerPriceType) {}
        public TriggerPriceType(char val)
            :base(Fields.CustomTags.TriggerPriceType, val) {}


        // Field Enumerations
        public const char BEST_OFFER = '1';
        public const char LAST_TRADE = '2';
        public const char BEST_BID = '3';
        public const char BEST_BID_OR_LAST_TRADE = '4';
        public const char BEST_OFFER_OR_LAST_TRADE = '5';
        public const char BEST_MID = '6';
        public const char BID = '1';
        public const char ASK = '2';
        public const char LTP = '3';
        public const char SAMESIDE = '6';
        public const char OPPOSITESIDE = '7';
    }


    /// <summary>
    /// TriggerTicksAway Field
    /// </summary>/
    public sealed class TriggerTicksAway : QuickFix.Fields.IntField
    {
        public TriggerTicksAway()
            :base(Fields.CustomTags.TriggerTicksAway) {}
        public TriggerTicksAway(int val)
            :base(Fields.CustomTags.TriggerTicksAway, val) {}

    }


    /// <summary>
    /// TriggerType Field
    /// </summary>/
    public sealed class TriggerType : QuickFix.Fields.CharField
    {
        public TriggerType()
            :base(Fields.CustomTags.TriggerType) {}
        public TriggerType(char val)
            :base(Fields.CustomTags.TriggerType, val) {}


        // Field Enumerations
        public const char PARTIAL_EXECUTION = '1';
        public const char SPECIFIED_TRADING_SESSION = '2';
        public const char NEXT_AUCTION = '3';
        public const char PRICE_MOVEMENT = '4';
        public const char STOP = '1';
        public const char IT = '2';
    }


    /// <summary>
    /// WithATickType Field
    /// </summary>/
    public sealed class WithATickType : QuickFix.Fields.IntField
    {
        public WithATickType()
            :base(Fields.CustomTags.WithATickType) {}
        public WithATickType(int val)
            :base(Fields.CustomTags.WithATickType, val) {}


        // Field Enumerations
        public const int QTY = 1;
        public const int PERCENT = 2;
    }


    /// <summary>
    /// WithATick Field
    /// </summary>/
    public sealed class WithATick : QuickFix.Fields.IntField
    {
        public WithATick()
            :base(Fields.CustomTags.WithATick) {}
        public WithATick(int val)
            :base(Fields.CustomTags.WithATick, val) {}

    }


    /// <summary>
    /// TriggerQtyType Field
    /// </summary>/
    public sealed class TriggerQtyType : QuickFix.Fields.IntField
    {
        public TriggerQtyType()
            :base(Fields.CustomTags.TriggerQtyType) {}
        public TriggerQtyType(int val)
            :base(Fields.CustomTags.TriggerQtyType, val) {}


        // Field Enumerations
        public const int QTY = 1;
        public const int PERCENT = 2;
    }


    /// <summary>
    /// TriggerQtyCompare Field
    /// </summary>/
    public sealed class TriggerQtyCompare : QuickFix.Fields.IntField
    {
        public TriggerQtyCompare()
            :base(Fields.CustomTags.TriggerQtyCompare) {}
        public TriggerQtyCompare(int val)
            :base(Fields.CustomTags.TriggerQtyCompare, val) {}


        // Field Enumerations
        public const int LTE = 3;
        public const int GTE = 5;
    }


    /// <summary>
    /// TriggerQty Field
    /// </summary>/
    public sealed class TriggerQty : QuickFix.Fields.IntField
    {
        public TriggerQty()
            :base(Fields.CustomTags.TriggerQty) {}
        public TriggerQty(int val)
            :base(Fields.CustomTags.TriggerQty, val) {}

    }


    /// <summary>
    /// TriggerLTPReset Field
    /// </summary>/
    public sealed class TriggerLTPReset : QuickFix.Fields.BooleanField
    {
        public TriggerLTPReset()
            :base(Fields.CustomTags.TriggerLTPReset) {}
        public TriggerLTPReset(Boolean val)
            :base(Fields.CustomTags.TriggerLTPReset, val) {}

    }


    /// <summary>
    /// TTStopLimitPriceType Field
    /// </summary>/
    public sealed class TTStopLimitPriceType : QuickFix.Fields.IntField
    {
        public TTStopLimitPriceType()
            :base(Fields.CustomTags.TTStopLimitPriceType) {}
        public TTStopLimitPriceType(int val)
            :base(Fields.CustomTags.TTStopLimitPriceType, val) {}


        // Field Enumerations
        public const int BID = 1;
        public const int ASK = 2;
        public const int LTP = 3;
    }


    /// <summary>
    /// TTStopWithATickType Field
    /// </summary>/
    public sealed class TTStopWithATickType : QuickFix.Fields.IntField
    {
        public TTStopWithATickType()
            :base(Fields.CustomTags.TTStopWithATickType) {}
        public TTStopWithATickType(int val)
            :base(Fields.CustomTags.TTStopWithATickType, val) {}


        // Field Enumerations
        public const int QTY = 1;
        public const int PERCENT = 2;
    }


    /// <summary>
    /// TTStopWithATick Field
    /// </summary>/
    public sealed class TTStopWithATick : QuickFix.Fields.IntField
    {
        public TTStopWithATick()
            :base(Fields.CustomTags.TTStopWithATick) {}
        public TTStopWithATick(int val)
            :base(Fields.CustomTags.TTStopWithATick, val) {}

    }


    /// <summary>
    /// Payup Field
    /// </summary>/
    public sealed class Payup : QuickFix.Fields.IntField
    {
        public Payup()
            :base(Fields.CustomTags.Payup) {}
        public Payup(int val)
            :base(Fields.CustomTags.Payup, val) {}

    }


    /// <summary>
    /// TTStopTriggerPriceType Field
    /// </summary>/
    public sealed class TTStopTriggerPriceType : QuickFix.Fields.IntField
    {
        public TTStopTriggerPriceType()
            :base(Fields.CustomTags.TTStopTriggerPriceType) {}
        public TTStopTriggerPriceType(int val)
            :base(Fields.CustomTags.TTStopTriggerPriceType, val) {}


        // Field Enumerations
        public const int LTP = 3;
        public const int BID = 1;
        public const int ASK = 2;
    }


    /// <summary>
    /// TTStopIsTrlTrg Field
    /// </summary>/
    public sealed class TTStopIsTrlTrg : QuickFix.Fields.BooleanField
    {
        public TTStopIsTrlTrg()
            :base(Fields.CustomTags.TTStopIsTrlTrg) {}
        public TTStopIsTrlTrg(Boolean val)
            :base(Fields.CustomTags.TTStopIsTrlTrg, val) {}


        // Field Enumerations
        public const Boolean YES = true;
        public const Boolean NO = false;
    }


    /// <summary>
    /// TTStopTriggerTicksAway Field
    /// </summary>/
    public sealed class TTStopTriggerTicksAway : QuickFix.Fields.IntField
    {
        public TTStopTriggerTicksAway()
            :base(Fields.CustomTags.TTStopTriggerTicksAway) {}
        public TTStopTriggerTicksAway(int val)
            :base(Fields.CustomTags.TTStopTriggerTicksAway, val) {}

    }


    /// <summary>
    /// TTStopTriggerQtyType Field
    /// </summary>/
    public sealed class TTStopTriggerQtyType : QuickFix.Fields.IntField
    {
        public TTStopTriggerQtyType()
            :base(Fields.CustomTags.TTStopTriggerQtyType) {}
        public TTStopTriggerQtyType(int val)
            :base(Fields.CustomTags.TTStopTriggerQtyType, val) {}


        // Field Enumerations
        public const int QTY = 1;
        public const int PERCENTAGE = 2;
    }


    /// <summary>
    /// TTStopTriggerQTyCompare Field
    /// </summary>/
    public sealed class TTStopTriggerQTyCompare : QuickFix.Fields.IntField
    {
        public TTStopTriggerQTyCompare()
            :base(Fields.CustomTags.TTStopTriggerQTyCompare) {}
        public TTStopTriggerQTyCompare(int val)
            :base(Fields.CustomTags.TTStopTriggerQTyCompare, val) {}


        // Field Enumerations
        public const int LTE = 3;
        public const int GTE = 5;
    }


    /// <summary>
    /// TTStopTriggerQty Field
    /// </summary>/
    public sealed class TTStopTriggerQty : QuickFix.Fields.IntField
    {
        public TTStopTriggerQty()
            :base(Fields.CustomTags.TTStopTriggerQty) {}
        public TTStopTriggerQty(int val)
            :base(Fields.CustomTags.TTStopTriggerQty, val) {}

    }


    /// <summary>
    /// TTStopTriggerLTPReset Field
    /// </summary>/
    public sealed class TTStopTriggerLTPReset : QuickFix.Fields.BooleanField
    {
        public TTStopTriggerLTPReset()
            :base(Fields.CustomTags.TTStopTriggerLTPReset) {}
        public TTStopTriggerLTPReset(Boolean val)
            :base(Fields.CustomTags.TTStopTriggerLTPReset, val) {}


        // Field Enumerations
        public const Boolean YES = true;
        public const Boolean NO = false;
    }


    /// <summary>
    /// TTStopTriggeredOrderType Field
    /// </summary>/
    public sealed class TTStopTriggeredOrderType : QuickFix.Fields.IntField
    {
        public TTStopTriggeredOrderType()
            :base(Fields.CustomTags.TTStopTriggeredOrderType) {}
        public TTStopTriggeredOrderType(int val)
            :base(Fields.CustomTags.TTStopTriggeredOrderType, val) {}


        // Field Enumerations
        public const int MKT = 1;
        public const int LIMIT = 2;
        public const int MLM = 21;
    }


    /// <summary>
    /// TTStopTriggeredOrderPrice Field
    /// </summary>/
    public sealed class TTStopTriggeredOrderPrice : QuickFix.Fields.DecimalField
    {
        public TTStopTriggeredOrderPrice()
            :base(Fields.CustomTags.TTStopTriggeredOrderPrice) {}
        public TTStopTriggeredOrderPrice(Decimal val)
            :base(Fields.CustomTags.TTStopTriggeredOrderPrice, val) {}

    }


    /// <summary>
    /// TTStopLimitTicksAway Field
    /// </summary>/
    public sealed class TTStopLimitTicksAway : QuickFix.Fields.IntField
    {
        public TTStopLimitTicksAway()
            :base(Fields.CustomTags.TTStopLimitTicksAway) {}
        public TTStopLimitTicksAway(int val)
            :base(Fields.CustomTags.TTStopLimitTicksAway, val) {}

    }


    /// <summary>
    /// TTStopPayup Field
    /// </summary>/
    public sealed class TTStopPayup : QuickFix.Fields.IntField
    {
        public TTStopPayup()
            :base(Fields.CustomTags.TTStopPayup) {}
        public TTStopPayup(int val)
            :base(Fields.CustomTags.TTStopPayup, val) {}

    }


    /// <summary>
    /// RetryCount Field
    /// </summary>/
    public sealed class RetryCount : QuickFix.Fields.IntField
    {
        public RetryCount()
            :base(Fields.CustomTags.RetryCount) {}
        public RetryCount(int val)
            :base(Fields.CustomTags.RetryCount, val) {}

    }


    /// <summary>
    /// RetryInterval Field
    /// </summary>/
    public sealed class RetryInterval : QuickFix.Fields.IntField
    {
        public RetryInterval()
            :base(Fields.CustomTags.RetryInterval) {}
        public RetryInterval(int val)
            :base(Fields.CustomTags.RetryInterval, val) {}

    }


    /// <summary>
    /// Duration Field
    /// </summary>/
    public sealed class Duration : QuickFix.Fields.IntField
    {
        public Duration()
            :base(Fields.CustomTags.Duration) {}
        public Duration(int val)
            :base(Fields.CustomTags.Duration, val) {}

    }


    /// <summary>
    /// DurationBaseUnit Field
    /// </summary>/
    public sealed class DurationBaseUnit : QuickFix.Fields.IntField
    {
        public DurationBaseUnit()
            :base(Fields.CustomTags.DurationBaseUnit) {}
        public DurationBaseUnit(int val)
            :base(Fields.CustomTags.DurationBaseUnit, val) {}


        // Field Enumerations
        public const int HOUR = 1;
        public const int MINUTE = 2;
        public const int SECOND = 3;
    }


    /// <summary>
    /// DurationSTime Field
    /// </summary>/
    public sealed class DurationSTime : QuickFix.Fields.DateTimeField
    {
        public DurationSTime()
            :base(Fields.CustomTags.DurationSTime) {}
        public DurationSTime(DateTime val)
            :base(Fields.CustomTags.DurationSTime, val) {}
        public DurationSTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.DurationSTime, val, showMilliseconds) {}
		public DurationSTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.DurationSTime, val, precision) {}

    }


    /// <summary>
    /// DurationETime Field
    /// </summary>/
    public sealed class DurationETime : QuickFix.Fields.DateTimeField
    {
        public DurationETime()
            :base(Fields.CustomTags.DurationETime) {}
        public DurationETime(DateTime val)
            :base(Fields.CustomTags.DurationETime, val) {}
        public DurationETime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.DurationETime, val, showMilliseconds) {}
		public DurationETime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.DurationETime, val, precision) {}

    }


    /// <summary>
    /// LeftoverTimeAction Field
    /// </summary>/
    public sealed class LeftoverTimeAction : QuickFix.Fields.IntField
    {
        public LeftoverTimeAction()
            :base(Fields.CustomTags.LeftoverTimeAction) {}
        public LeftoverTimeAction(int val)
            :base(Fields.CustomTags.LeftoverTimeAction, val) {}


        // Field Enumerations
        public const int ATEND = 0;
        public const int HALFLIFE = 1;
    }


    /// <summary>
    /// AutoResubExpiredGTD Field
    /// </summary>/
    public sealed class AutoResubExpiredGTD : QuickFix.Fields.BooleanField
    {
        public AutoResubExpiredGTD()
            :base(Fields.CustomTags.AutoResubExpiredGTD) {}
        public AutoResubExpiredGTD(Boolean val)
            :base(Fields.CustomTags.AutoResubExpiredGTD, val) {}

    }


    /// <summary>
    /// ParentTIF Field
    /// </summary>/
    public sealed class ParentTIF : QuickFix.Fields.IntField
    {
        public ParentTIF()
            :base(Fields.CustomTags.ParentTIF) {}
        public ParentTIF(int val)
            :base(Fields.CustomTags.ParentTIF, val) {}


        // Field Enumerations
        public const int GTC = 2;
        public const int DAY = 1;
        public const int TIME = 7;
    }


    /// <summary>
    /// TTStopSecondConditionIsOn Field
    /// </summary>/
    public sealed class TTStopSecondConditionIsOn : QuickFix.Fields.BooleanField
    {
        public TTStopSecondConditionIsOn()
            :base(Fields.CustomTags.TTStopSecondConditionIsOn) {}
        public TTStopSecondConditionIsOn(Boolean val)
            :base(Fields.CustomTags.TTStopSecondConditionIsOn, val) {}

    }


    /// <summary>
    /// TTStopSecondTriggerPriceType Field
    /// </summary>/
    public sealed class TTStopSecondTriggerPriceType : QuickFix.Fields.IntField
    {
        public TTStopSecondTriggerPriceType()
            :base(Fields.CustomTags.TTStopSecondTriggerPriceType) {}
        public TTStopSecondTriggerPriceType(int val)
            :base(Fields.CustomTags.TTStopSecondTriggerPriceType, val) {}


        // Field Enumerations
        public const int LTP = 3;
        public const int BID = 1;
        public const int ASK = 2;
        public const int SAMESIDE = 6;
        public const int OPPOSITESIDE = 7;
    }


    /// <summary>
    /// TTStopSecondConditionIsTrlTrg Field
    /// </summary>/
    public sealed class TTStopSecondConditionIsTrlTrg : QuickFix.Fields.BooleanField
    {
        public TTStopSecondConditionIsTrlTrg()
            :base(Fields.CustomTags.TTStopSecondConditionIsTrlTrg) {}
        public TTStopSecondConditionIsTrlTrg(Boolean val)
            :base(Fields.CustomTags.TTStopSecondConditionIsTrlTrg, val) {}

    }


    /// <summary>
    /// TTStopSecondTriggerTicksAway Field
    /// </summary>/
    public sealed class TTStopSecondTriggerTicksAway : QuickFix.Fields.IntField
    {
        public TTStopSecondTriggerTicksAway()
            :base(Fields.CustomTags.TTStopSecondTriggerTicksAway) {}
        public TTStopSecondTriggerTicksAway(int val)
            :base(Fields.CustomTags.TTStopSecondTriggerTicksAway, val) {}

    }


    /// <summary>
    /// TTStopSecondTriggerQtyType Field
    /// </summary>/
    public sealed class TTStopSecondTriggerQtyType : QuickFix.Fields.IntField
    {
        public TTStopSecondTriggerQtyType()
            :base(Fields.CustomTags.TTStopSecondTriggerQtyType) {}
        public TTStopSecondTriggerQtyType(int val)
            :base(Fields.CustomTags.TTStopSecondTriggerQtyType, val) {}


        // Field Enumerations
        public const int QTY = 1;
        public const int PERCENTAGE = 2;
    }


    /// <summary>
    /// TTStopSecondTriggerQtyCompare Field
    /// </summary>/
    public sealed class TTStopSecondTriggerQtyCompare : QuickFix.Fields.IntField
    {
        public TTStopSecondTriggerQtyCompare()
            :base(Fields.CustomTags.TTStopSecondTriggerQtyCompare) {}
        public TTStopSecondTriggerQtyCompare(int val)
            :base(Fields.CustomTags.TTStopSecondTriggerQtyCompare, val) {}


        // Field Enumerations
        public const int LTE = 3;
        public const int GTE = 5;
    }


    /// <summary>
    /// TTStopSecondTriggerQty Field
    /// </summary>/
    public sealed class TTStopSecondTriggerQty : QuickFix.Fields.DecimalField
    {
        public TTStopSecondTriggerQty()
            :base(Fields.CustomTags.TTStopSecondTriggerQty) {}
        public TTStopSecondTriggerQty(Decimal val)
            :base(Fields.CustomTags.TTStopSecondTriggerQty, val) {}

    }


    /// <summary>
    /// Variance Field
    /// </summary>/
    public sealed class Variance : QuickFix.Fields.IntField
    {
        public Variance()
            :base(Fields.CustomTags.Variance) {}
        public Variance(int val)
            :base(Fields.CustomTags.Variance, val) {}

    }


    /// <summary>
    /// IncludeQuotes Field
    /// </summary>/
    public sealed class IncludeQuotes : QuickFix.Fields.BooleanField
    {
        public IncludeQuotes()
            :base(Fields.CustomTags.IncludeQuotes) {}
        public IncludeQuotes(Boolean val)
            :base(Fields.CustomTags.IncludeQuotes, val) {}

    }


    /// <summary>
    /// ETAGoToMktTicks Field
    /// </summary>/
    public sealed class ETAGoToMktTicks : QuickFix.Fields.IntField
    {
        public ETAGoToMktTicks()
            :base(Fields.CustomTags.ETAGoToMktTicks) {}
        public ETAGoToMktTicks(int val)
            :base(Fields.CustomTags.ETAGoToMktTicks, val) {}

    }


    /// <summary>
    /// WaitingOption Field
    /// </summary>/
    public sealed class WaitingOption : QuickFix.Fields.IntField
    {
        public WaitingOption()
            :base(Fields.CustomTags.WaitingOption) {}
        public WaitingOption(int val)
            :base(Fields.CustomTags.WaitingOption, val) {}

    }


    /// <summary>
    /// TTStopChildTIFOverride Field
    /// </summary>/
    public sealed class TTStopChildTIFOverride : QuickFix.Fields.IntField
    {
        public TTStopChildTIFOverride()
            :base(Fields.CustomTags.TTStopChildTIFOverride) {}
        public TTStopChildTIFOverride(int val)
            :base(Fields.CustomTags.TTStopChildTIFOverride, val) {}

    }


    /// <summary>
    /// ClearingAccountOverride Field
    /// </summary>/
    public sealed class ClearingAccountOverride : QuickFix.Fields.StringField
    {
        public ClearingAccountOverride()
            :base(Fields.CustomTags.ClearingAccountOverride) {}
        public ClearingAccountOverride(string val)
            :base(Fields.CustomTags.ClearingAccountOverride, val) {}

    }


    /// <summary>
    /// RequestTickTable Field
    /// </summary>/
    public sealed class RequestTickTable : QuickFix.Fields.BooleanField
    {
        public RequestTickTable()
            :base(Fields.CustomTags.RequestTickTable) {}
        public RequestTickTable(Boolean val)
            :base(Fields.CustomTags.RequestTickTable, val) {}


        // Field Enumerations
        public const Boolean YES = true;
        public const Boolean NO = false;
    }


    /// <summary>
    /// VendorDefinedField1 Field
    /// </summary>/
    public sealed class VendorDefinedField1 : QuickFix.Fields.StringField
    {
        public VendorDefinedField1()
            :base(Fields.CustomTags.VendorDefinedField1) {}
        public VendorDefinedField1(string val)
            :base(Fields.CustomTags.VendorDefinedField1, val) {}

    }


    /// <summary>
    /// VendorDefinedField2 Field
    /// </summary>/
    public sealed class VendorDefinedField2 : QuickFix.Fields.StringField
    {
        public VendorDefinedField2()
            :base(Fields.CustomTags.VendorDefinedField2) {}
        public VendorDefinedField2(string val)
            :base(Fields.CustomTags.VendorDefinedField2, val) {}

    }


    /// <summary>
    /// VendorDefinedField3 Field
    /// </summary>/
    public sealed class VendorDefinedField3 : QuickFix.Fields.StringField
    {
        public VendorDefinedField3()
            :base(Fields.CustomTags.VendorDefinedField3) {}
        public VendorDefinedField3(string val)
            :base(Fields.CustomTags.VendorDefinedField3, val) {}

    }


    /// <summary>
    /// VendorDefinedField4 Field
    /// </summary>/
    public sealed class VendorDefinedField4 : QuickFix.Fields.StringField
    {
        public VendorDefinedField4()
            :base(Fields.CustomTags.VendorDefinedField4) {}
        public VendorDefinedField4(string val)
            :base(Fields.CustomTags.VendorDefinedField4, val) {}

    }


    /// <summary>
    /// VendorDefinedField5 Field
    /// </summary>/
    public sealed class VendorDefinedField5 : QuickFix.Fields.StringField
    {
        public VendorDefinedField5()
            :base(Fields.CustomTags.VendorDefinedField5) {}
        public VendorDefinedField5(string val)
            :base(Fields.CustomTags.VendorDefinedField5, val) {}

    }


    /// <summary>
    /// ForceLogout Field
    /// </summary>/
    public sealed class ForceLogout : QuickFix.Fields.IntField
    {
        public ForceLogout()
            :base(Fields.CustomTags.ForceLogout) {}
        public ForceLogout(int val)
            :base(Fields.CustomTags.ForceLogout, val) {}


        // Field Enumerations
        public const int NOT_FORCED = 0;
        public const int FORCED = 1;
    }


    /// <summary>
    /// PriceFeedStatus Field
    /// </summary>/
    public sealed class PriceFeedStatus : QuickFix.Fields.IntField
    {
        public PriceFeedStatus()
            :base(Fields.CustomTags.PriceFeedStatus) {}
        public PriceFeedStatus(int val)
            :base(Fields.CustomTags.PriceFeedStatus, val) {}

    }


    /// <summary>
    /// DeliveryTerm Field
    /// </summary>/
    public sealed class DeliveryTerm : QuickFix.Fields.CharField
    {
        public DeliveryTerm()
            :base(Fields.CustomTags.DeliveryTerm) {}
        public DeliveryTerm(char val)
            :base(Fields.CustomTags.DeliveryTerm, val) {}


        // Field Enumerations
        public const char DAY = 'D';
        public const char WEEK = 'W';
        public const char BALANCE = 'B';
        public const char QUARTER = 'Q';
        public const char SEASON = 'S';
        public const char YEAR = 'Y';
        public const char VARIABLE = 'V';
        public const char BALANCE_OF_WEEK = 'L';
        public const char CUSTOM = 'X';
        public const char SAME_DAY = 'A';
        public const char NEXT_DAY = 'N';
        public const char MONTH = 'M';
        public const char WEEKLY = 'E';
        public const char PACK = 'P';
        public const char BUNDLE = 'U';
        public const char WEEKEND = 'T';
        public const char HOUR = 'H';
    }


    /// <summary>
    /// LegDeliveryTerm Field
    /// </summary>/
    public sealed class LegDeliveryTerm : QuickFix.Fields.CharField
    {
        public LegDeliveryTerm()
            :base(Fields.CustomTags.LegDeliveryTerm) {}
        public LegDeliveryTerm(char val)
            :base(Fields.CustomTags.LegDeliveryTerm, val) {}


        // Field Enumerations
        public const char DAY = 'D';
        public const char WEEK = 'W';
        public const char BALANCE = 'B';
        public const char QUARTER = 'Q';
        public const char SEASON = 'S';
        public const char YEAR = 'Y';
        public const char VARIABLE = 'V';
        public const char BALANCE_OF_WEEK = 'L';
        public const char CUSTOM = 'X';
        public const char SAME_DAY = 'A';
        public const char NEXT_DAY = 'N';
        public const char MONTH = 'M';
        public const char WEEKLY = 'E';
        public const char PACK = 'P';
        public const char BUNDLE = 'U';
        public const char HOUR = 'H';
    }


    /// <summary>
    /// LegDeliveryDate Field
    /// </summary>/
    public sealed class LegDeliveryDate : QuickFix.Fields.StringField
    {
        public LegDeliveryDate()
            :base(Fields.CustomTags.LegDeliveryDate) {}
        public LegDeliveryDate(string val)
            :base(Fields.CustomTags.LegDeliveryDate, val) {}

    }


    /// <summary>
    /// IncludeNumberOfOrders Field
    /// </summary>/
    public sealed class IncludeNumberOfOrders : QuickFix.Fields.CharField
    {
        public IncludeNumberOfOrders()
            :base(Fields.CustomTags.IncludeNumberOfOrders) {}
        public IncludeNumberOfOrders(char val)
            :base(Fields.CustomTags.IncludeNumberOfOrders, val) {}


        // Field Enumerations
        public const char NO = 'N';
        public const char YES = 'Y';
    }


    /// <summary>
    /// ExchCred Field
    /// </summary>/
    public sealed class ExchCred : QuickFix.Fields.StringField
    {
        public ExchCred()
            :base(Fields.CustomTags.ExchCred) {}
        public ExchCred(string val)
            :base(Fields.CustomTags.ExchCred, val) {}

    }


    /// <summary>
    /// RefID Field
    /// </summary>/
    public sealed class RefID : QuickFix.Fields.StringField
    {
        public RefID()
            :base(Fields.CustomTags.RefID) {}
        public RefID(string val)
            :base(Fields.CustomTags.RefID, val) {}

    }


    /// <summary>
    /// TTCustomerName Field
    /// </summary>/
    public sealed class TTCustomerName : QuickFix.Fields.StringField
    {
        public TTCustomerName()
            :base(Fields.CustomTags.TTCustomerName) {}
        public TTCustomerName(string val)
            :base(Fields.CustomTags.TTCustomerName, val) {}

    }


    /// <summary>
    /// LegMaturityDay Field
    /// </summary>/
    public sealed class LegMaturityDay : QuickFix.Fields.StringField
    {
        public LegMaturityDay()
            :base(Fields.CustomTags.LegMaturityDay) {}
        public LegMaturityDay(string val)
            :base(Fields.CustomTags.LegMaturityDay, val) {}

    }


    /// <summary>
    /// LegExDestination Field
    /// </summary>/
    public sealed class LegExDestination : QuickFix.Fields.StringField
    {
        public LegExDestination()
            :base(Fields.CustomTags.LegExDestination) {}
        public LegExDestination(string val)
            :base(Fields.CustomTags.LegExDestination, val) {}

    }


    /// <summary>
    /// AccountID Field
    /// </summary>/
    public sealed class AccountID : QuickFix.Fields.StringField
    {
        public AccountID()
            :base(Fields.CustomTags.AccountID) {}
        public AccountID(string val)
            :base(Fields.CustomTags.AccountID, val) {}

    }


    /// <summary>
    /// UserID Field
    /// </summary>/
    public sealed class UserID : QuickFix.Fields.StringField
    {
        public UserID()
            :base(Fields.CustomTags.UserID) {}
        public UserID(string val)
            :base(Fields.CustomTags.UserID, val) {}

    }


    /// <summary>
    /// SecondaryAccount Field
    /// </summary>/
    public sealed class SecondaryAccount : QuickFix.Fields.StringField
    {
        public SecondaryAccount()
            :base(Fields.CustomTags.SecondaryAccount) {}
        public SecondaryAccount(string val)
            :base(Fields.CustomTags.SecondaryAccount, val) {}

    }


    /// <summary>
    /// BrokerID Field
    /// </summary>/
    public sealed class BrokerID : QuickFix.Fields.StringField
    {
        public BrokerID()
            :base(Fields.CustomTags.BrokerID) {}
        public BrokerID(string val)
            :base(Fields.CustomTags.BrokerID, val) {}

    }


    /// <summary>
    /// CompanyID Field
    /// </summary>/
    public sealed class CompanyID : QuickFix.Fields.StringField
    {
        public CompanyID()
            :base(Fields.CustomTags.CompanyID) {}
        public CompanyID(string val)
            :base(Fields.CustomTags.CompanyID, val) {}

    }


    /// <summary>
    /// AOTCPreventionActionType Field
    /// </summary>/
    public sealed class AOTCPreventionActionType : QuickFix.Fields.CharField
    {
        public AOTCPreventionActionType()
            :base(Fields.CustomTags.AOTCPreventionActionType) {}
        public AOTCPreventionActionType(char val)
            :base(Fields.CustomTags.AOTCPreventionActionType, val) {}


        // Field Enumerations
        public const char CROSSING_ORDER_PREVENTION_NONE = '0';
        public const char CROSSING_ORDER_PREVENTION_HELD = '1';
        public const char CROSSING_ORDER_PREVENTION_CANCEL = '2';
        public const char CROSSING_ORDER_PREVENTION_FILL = '3';
        public const char CROSSING_ORDER_PREVENTION_REDUCED_ORDER = '4';
        public const char CROSSING_ORDER_PREVENTION_REDUCED_CHANGE = '5';
        public const char CROSSING_ORDER_PREVENTION_RELEASED_ORDER = '6';
        public const char CROSSING_ORDER_PREVENTION_REPLACED_ORDER = '7';
        public const char CROSSING_ORDER_PREVENTION_NO_ACTION_ON_ORDER = '8';
        public const char CROSSING_ORDER_PREVENTION_CANCEL_REPLACE = '9';
    }


    /// <summary>
    /// ContractYearMonth Field
    /// </summary>/
    public sealed class ContractYearMonth : QuickFix.Fields.StringField
    {
        public ContractYearMonth()
            :base(Fields.CustomTags.ContractYearMonth) {}
        public ContractYearMonth(string val)
            :base(Fields.CustomTags.ContractYearMonth, val) {}

    }


    /// <summary>
    /// LegContractYearMonth Field
    /// </summary>/
    public sealed class LegContractYearMonth : QuickFix.Fields.StringField
    {
        public LegContractYearMonth()
            :base(Fields.CustomTags.LegContractYearMonth) {}
        public LegContractYearMonth(string val)
            :base(Fields.CustomTags.LegContractYearMonth, val) {}

    }


    /// <summary>
    /// ExchangeSeqNum Field
    /// </summary>/
    public sealed class ExchangeSeqNum : QuickFix.Fields.IntField
    {
        public ExchangeSeqNum()
            :base(Fields.CustomTags.ExchangeSeqNum) {}
        public ExchangeSeqNum(int val)
            :base(Fields.CustomTags.ExchangeSeqNum, val) {}

    }


    /// <summary>
    /// TTSyntheticType Field
    /// </summary>/
    public sealed class TTSyntheticType : QuickFix.Fields.IntField
    {
        public TTSyntheticType()
            :base(Fields.CustomTags.TTSyntheticType) {}
        public TTSyntheticType(int val)
            :base(Fields.CustomTags.TTSyntheticType, val) {}

    }


    /// <summary>
    /// Organization Field
    /// </summary>/
    public sealed class Organization : QuickFix.Fields.StringField
    {
        public Organization()
            :base(Fields.CustomTags.Organization) {}
        public Organization(string val)
            :base(Fields.CustomTags.Organization, val) {}

    }


    /// <summary>
    /// FutureReferencePrice Field
    /// </summary>/
    public sealed class FutureReferencePrice : QuickFix.Fields.DecimalField
    {
        public FutureReferencePrice()
            :base(Fields.CustomTags.FutureReferencePrice) {}
        public FutureReferencePrice(Decimal val)
            :base(Fields.CustomTags.FutureReferencePrice, val) {}

    }


    /// <summary>
    /// NoTCRLegs Field
    /// </summary>/
    public sealed class NoTCRLegs : QuickFix.Fields.IntField
    {
        public NoTCRLegs()
            :base(Fields.CustomTags.NoTCRLegs) {}
        public NoTCRLegs(int val)
            :base(Fields.CustomTags.NoTCRLegs, val) {}

    }


    /// <summary>
    /// MDTradeEntryID Field
    /// </summary>/
    public sealed class MDTradeEntryID : QuickFix.Fields.IntField
    {
        public MDTradeEntryID()
            :base(Fields.CustomTags.MDTradeEntryID) {}
        public MDTradeEntryID(int val)
            :base(Fields.CustomTags.MDTradeEntryID, val) {}

    }


    /// <summary>
    /// IOIID Field
    /// </summary>/
    public sealed class IOIID : QuickFix.Fields.StringField
    {
        public IOIID()
            :base(Fields.CustomTags.IOIID) {}
        public IOIID(string val)
            :base(Fields.CustomTags.IOIID, val) {}

    }


    /// <summary>
    /// NoLinesOfText Field
    /// </summary>/
    public sealed class NoLinesOfText : QuickFix.Fields.IntField
    {
        public NoLinesOfText()
            :base(Fields.CustomTags.NoLinesOfText) {}
        public NoLinesOfText(int val)
            :base(Fields.CustomTags.NoLinesOfText, val) {}

    }


    /// <summary>
    /// SettlType Field
    /// </summary>/
    public sealed class SettlType : QuickFix.Fields.StringField
    {
        public SettlType()
            :base(Fields.CustomTags.SettlType) {}
        public SettlType(string val)
            :base(Fields.CustomTags.SettlType, val) {}


        // Field Enumerations
        public const string REGULAR = "0";
        public const string CASH = "1";
        public const string NEXT_DAY = "2";
        public const string T_PLUS_2 = "3";
        public const string T_PLUS_3 = "4";
        public const string T_PLUS_4 = "5";
        public const string FUTURE = "6";
        public const string WHEN_AND_IF_ISSUED = "7";
        public const string SELLERS_OPTION = "8";
        public const string T_PLUS_5 = "9";
        public const string FX_SPOT_NEXT_SETTLEMENT = "C";
        public const string BROKEN_DATE = "B";
    }


    /// <summary>
    /// SettlDate Field
    /// </summary>/
    public sealed class SettlDate : QuickFix.Fields.StringField
    {
        public SettlDate()
            :base(Fields.CustomTags.SettlDate) {}
        public SettlDate(string val)
            :base(Fields.CustomTags.SettlDate, val) {}

    }


    /// <summary>
    /// AvgPxPrecision Field
    /// </summary>/
    public sealed class AvgPxPrecision : QuickFix.Fields.IntField
    {
        public AvgPxPrecision()
            :base(Fields.CustomTags.AvgPxPrecision) {}
        public AvgPxPrecision(int val)
            :base(Fields.CustomTags.AvgPxPrecision, val) {}

    }


    /// <summary>
    /// SettlDate2 Field
    /// </summary>/
    public sealed class SettlDate2 : QuickFix.Fields.StringField
    {
        public SettlDate2()
            :base(Fields.CustomTags.SettlDate2) {}
        public SettlDate2(string val)
            :base(Fields.CustomTags.SettlDate2, val) {}

    }


    /// <summary>
    /// PegOffsetValue Field
    /// </summary>/
    public sealed class PegOffsetValue : QuickFix.Fields.DecimalField
    {
        public PegOffsetValue()
            :base(Fields.CustomTags.PegOffsetValue) {}
        public PegOffsetValue(Decimal val)
            :base(Fields.CustomTags.PegOffsetValue, val) {}

    }


    /// <summary>
    /// OpenCloseSettlFlag Field
    /// </summary>/
    public sealed class OpenCloseSettlFlag : QuickFix.Fields.StringField
    {
        public OpenCloseSettlFlag()
            :base(Fields.CustomTags.OpenCloseSettlFlag) {}
        public OpenCloseSettlFlag(string val)
            :base(Fields.CustomTags.OpenCloseSettlFlag, val) {}


        // Field Enumerations
        public const string DAILY_OPEN = "0";
        public const string SESSION_OPEN = "1";
        public const string DELIVERY_SETTLEMENT_ENTRY = "2";
        public const string EXPECTED_ENTRY = "3";
        public const string ENTRY_FROM_PREVIOUS_BUSINESS_DAY = "4";
        public const string THEORETICAL_PRICE_VALUE = "5";
    }


    /// <summary>
    /// TotNoQuoteEntries Field
    /// </summary>/
    public sealed class TotNoQuoteEntries : QuickFix.Fields.IntField
    {
        public TotNoQuoteEntries()
            :base(Fields.CustomTags.TotNoQuoteEntries) {}
        public TotNoQuoteEntries(int val)
            :base(Fields.CustomTags.TotNoQuoteEntries, val) {}

    }


    /// <summary>
    /// HaltReasonChar Field
    /// </summary>/
    public sealed class HaltReasonChar : QuickFix.Fields.CharField
    {
        public HaltReasonChar()
            :base(Fields.CustomTags.HaltReasonChar) {}
        public HaltReasonChar(char val)
            :base(Fields.CustomTags.HaltReasonChar, val) {}


        // Field Enumerations
        public const char NEWS_DISSEMINATION = 'D';
        public const char ORDER_INFLUX = 'E';
        public const char ORDER_IMBALANCE = 'I';
        public const char ADDITIONAL_INFORMATION = 'M';
        public const char NEW_PENDING = 'P';
        public const char EQUIPMENT_CHANGEOVER = 'X';
    }


    /// <summary>
    /// DiscretionOffsetValue Field
    /// </summary>/
    public sealed class DiscretionOffsetValue : QuickFix.Fields.DecimalField
    {
        public DiscretionOffsetValue()
            :base(Fields.CustomTags.DiscretionOffsetValue) {}
        public DiscretionOffsetValue(Decimal val)
            :base(Fields.CustomTags.DiscretionOffsetValue, val) {}

    }


    /// <summary>
    /// TotNoRelatedSym Field
    /// </summary>/
    public sealed class TotNoRelatedSym : QuickFix.Fields.IntField
    {
        public TotNoRelatedSym()
            :base(Fields.CustomTags.TotNoRelatedSym) {}
        public TotNoRelatedSym(int val)
            :base(Fields.CustomTags.TotNoRelatedSym, val) {}

    }


    /// <summary>
    /// BidTradeType Field
    /// </summary>/
    public sealed class BidTradeType : QuickFix.Fields.CharField
    {
        public BidTradeType()
            :base(Fields.CustomTags.BidTradeType) {}
        public BidTradeType(char val)
            :base(Fields.CustomTags.BidTradeType, val) {}


        // Field Enumerations
        public const char AGENCY = 'A';
        public const char VWAP_GUARANTEE = 'G';
        public const char GUARANTEED_CLOSE = 'J';
        public const char RISK_TRADE = 'R';
    }


    /// <summary>
    /// CardIssNum Field
    /// </summary>/
    public sealed class CardIssNum : QuickFix.Fields.StringField
    {
        public CardIssNum()
            :base(Fields.CustomTags.CardIssNum) {}
        public CardIssNum(string val)
            :base(Fields.CustomTags.CardIssNum, val) {}

    }


    /// <summary>
    /// RegistDtls Field
    /// </summary>/
    public sealed class RegistDtls : QuickFix.Fields.StringField
    {
        public RegistDtls()
            :base(Fields.CustomTags.RegistDtls) {}
        public RegistDtls(string val)
            :base(Fields.CustomTags.RegistDtls, val) {}

    }


    /// <summary>
    /// TotNoSecurityTypes Field
    /// </summary>/
    public sealed class TotNoSecurityTypes : QuickFix.Fields.IntField
    {
        public TotNoSecurityTypes()
            :base(Fields.CustomTags.TotNoSecurityTypes) {}
        public TotNoSecurityTypes(int val)
            :base(Fields.CustomTags.TotNoSecurityTypes, val) {}

    }


    /// <summary>
    /// LegSettlType Field
    /// </summary>/
    public sealed class LegSettlType : QuickFix.Fields.CharField
    {
        public LegSettlType()
            :base(Fields.CustomTags.LegSettlType) {}
        public LegSettlType(char val)
            :base(Fields.CustomTags.LegSettlType, val) {}

    }


    /// <summary>
    /// AcctIDSource Field
    /// </summary>/
    public sealed class AcctIDSource : QuickFix.Fields.IntField
    {
        public AcctIDSource()
            :base(Fields.CustomTags.AcctIDSource) {}
        public AcctIDSource(int val)
            :base(Fields.CustomTags.AcctIDSource, val) {}


        // Field Enumerations
        public const int BIC = 1;
        public const int SID_CODE = 2;
        public const int TFM = 3;
        public const int OMGEO = 4;
        public const int DTCC_CODE = 5;
        public const int OTHER = 99;
    }


    /// <summary>
    /// AllocAcctIDSource Field
    /// </summary>/
    public sealed class AllocAcctIDSource : QuickFix.Fields.IntField
    {
        public AllocAcctIDSource()
            :base(Fields.CustomTags.AllocAcctIDSource) {}
        public AllocAcctIDSource(int val)
            :base(Fields.CustomTags.AllocAcctIDSource, val) {}

    }


    /// <summary>
    /// BenchmarkPrice Field
    /// </summary>/
    public sealed class BenchmarkPrice : QuickFix.Fields.DecimalField
    {
        public BenchmarkPrice()
            :base(Fields.CustomTags.BenchmarkPrice) {}
        public BenchmarkPrice(Decimal val)
            :base(Fields.CustomTags.BenchmarkPrice, val) {}

    }


    /// <summary>
    /// BenchmarkPriceType Field
    /// </summary>/
    public sealed class BenchmarkPriceType : QuickFix.Fields.IntField
    {
        public BenchmarkPriceType()
            :base(Fields.CustomTags.BenchmarkPriceType) {}
        public BenchmarkPriceType(int val)
            :base(Fields.CustomTags.BenchmarkPriceType, val) {}

    }


    /// <summary>
    /// ConfirmID Field
    /// </summary>/
    public sealed class ConfirmID : QuickFix.Fields.StringField
    {
        public ConfirmID()
            :base(Fields.CustomTags.ConfirmID) {}
        public ConfirmID(string val)
            :base(Fields.CustomTags.ConfirmID, val) {}

    }


    /// <summary>
    /// ConfirmStatus Field
    /// </summary>/
    public sealed class ConfirmStatus : QuickFix.Fields.IntField
    {
        public ConfirmStatus()
            :base(Fields.CustomTags.ConfirmStatus) {}
        public ConfirmStatus(int val)
            :base(Fields.CustomTags.ConfirmStatus, val) {}


        // Field Enumerations
        public const int RECEIVED = 1;
        public const int MISMATCHED_ACCOUNT = 2;
        public const int MISSING_SETTLEMENT_INSTRUCTIONS = 3;
        public const int CONFIRMED = 4;
        public const int REQUEST_REJECTED = 5;
    }


    /// <summary>
    /// ConfirmTransType Field
    /// </summary>/
    public sealed class ConfirmTransType : QuickFix.Fields.IntField
    {
        public ConfirmTransType()
            :base(Fields.CustomTags.ConfirmTransType) {}
        public ConfirmTransType(int val)
            :base(Fields.CustomTags.ConfirmTransType, val) {}


        // Field Enumerations
        public const int NEW = 0;
        public const int REPLACE = 1;
        public const int CANCEL = 2;
    }


    /// <summary>
    /// ContractSettlMonth Field
    /// </summary>/
    public sealed class ContractSettlMonth : QuickFix.Fields.StringField
    {
        public ContractSettlMonth()
            :base(Fields.CustomTags.ContractSettlMonth) {}
        public ContractSettlMonth(string val)
            :base(Fields.CustomTags.ContractSettlMonth, val) {}

    }


    /// <summary>
    /// DeliveryForm Field
    /// </summary>/
    public sealed class DeliveryForm : QuickFix.Fields.IntField
    {
        public DeliveryForm()
            :base(Fields.CustomTags.DeliveryForm) {}
        public DeliveryForm(int val)
            :base(Fields.CustomTags.DeliveryForm, val) {}


        // Field Enumerations
        public const int BOOK_ENTRY = 1;
        public const int BEARER = 2;
    }


    /// <summary>
    /// NoLegAllocs Field
    /// </summary>/
    public sealed class NoLegAllocs : QuickFix.Fields.IntField
    {
        public NoLegAllocs()
            :base(Fields.CustomTags.NoLegAllocs) {}
        public NoLegAllocs(int val)
            :base(Fields.CustomTags.NoLegAllocs, val) {}

    }


    /// <summary>
    /// LegAllocAccount Field
    /// </summary>/
    public sealed class LegAllocAccount : QuickFix.Fields.StringField
    {
        public LegAllocAccount()
            :base(Fields.CustomTags.LegAllocAccount) {}
        public LegAllocAccount(string val)
            :base(Fields.CustomTags.LegAllocAccount, val) {}

    }


    /// <summary>
    /// LegIndividualAllocID Field
    /// </summary>/
    public sealed class LegIndividualAllocID : QuickFix.Fields.StringField
    {
        public LegIndividualAllocID()
            :base(Fields.CustomTags.LegIndividualAllocID) {}
        public LegIndividualAllocID(string val)
            :base(Fields.CustomTags.LegIndividualAllocID, val) {}

    }


    /// <summary>
    /// LegAllocQty Field
    /// </summary>/
    public sealed class LegAllocQty : QuickFix.Fields.DecimalField
    {
        public LegAllocQty()
            :base(Fields.CustomTags.LegAllocQty) {}
        public LegAllocQty(Decimal val)
            :base(Fields.CustomTags.LegAllocQty, val) {}

    }


    /// <summary>
    /// LegAllocAcctIDSource Field
    /// </summary>/
    public sealed class LegAllocAcctIDSource : QuickFix.Fields.StringField
    {
        public LegAllocAcctIDSource()
            :base(Fields.CustomTags.LegAllocAcctIDSource) {}
        public LegAllocAcctIDSource(string val)
            :base(Fields.CustomTags.LegAllocAcctIDSource, val) {}

    }


    /// <summary>
    /// LegSettlCurrency Field
    /// </summary>/
    public sealed class LegSettlCurrency : QuickFix.Fields.StringField
    {
        public LegSettlCurrency()
            :base(Fields.CustomTags.LegSettlCurrency) {}
        public LegSettlCurrency(string val)
            :base(Fields.CustomTags.LegSettlCurrency, val) {}

    }


    /// <summary>
    /// LegBenchmarkCurveCurrency Field
    /// </summary>/
    public sealed class LegBenchmarkCurveCurrency : QuickFix.Fields.StringField
    {
        public LegBenchmarkCurveCurrency()
            :base(Fields.CustomTags.LegBenchmarkCurveCurrency) {}
        public LegBenchmarkCurveCurrency(string val)
            :base(Fields.CustomTags.LegBenchmarkCurveCurrency, val) {}

    }


    /// <summary>
    /// LegBenchmarkCurveName Field
    /// </summary>/
    public sealed class LegBenchmarkCurveName : QuickFix.Fields.StringField
    {
        public LegBenchmarkCurveName()
            :base(Fields.CustomTags.LegBenchmarkCurveName) {}
        public LegBenchmarkCurveName(string val)
            :base(Fields.CustomTags.LegBenchmarkCurveName, val) {}

    }


    /// <summary>
    /// LegBenchmarkCurvePoint Field
    /// </summary>/
    public sealed class LegBenchmarkCurvePoint : QuickFix.Fields.StringField
    {
        public LegBenchmarkCurvePoint()
            :base(Fields.CustomTags.LegBenchmarkCurvePoint) {}
        public LegBenchmarkCurvePoint(string val)
            :base(Fields.CustomTags.LegBenchmarkCurvePoint, val) {}

    }


    /// <summary>
    /// LegBenchmarkPrice Field
    /// </summary>/
    public sealed class LegBenchmarkPrice : QuickFix.Fields.DecimalField
    {
        public LegBenchmarkPrice()
            :base(Fields.CustomTags.LegBenchmarkPrice) {}
        public LegBenchmarkPrice(Decimal val)
            :base(Fields.CustomTags.LegBenchmarkPrice, val) {}

    }


    /// <summary>
    /// LegBenchmarkPriceType Field
    /// </summary>/
    public sealed class LegBenchmarkPriceType : QuickFix.Fields.IntField
    {
        public LegBenchmarkPriceType()
            :base(Fields.CustomTags.LegBenchmarkPriceType) {}
        public LegBenchmarkPriceType(int val)
            :base(Fields.CustomTags.LegBenchmarkPriceType, val) {}

    }


    /// <summary>
    /// LegBidPx Field
    /// </summary>/
    public sealed class LegBidPx : QuickFix.Fields.DecimalField
    {
        public LegBidPx()
            :base(Fields.CustomTags.LegBidPx) {}
        public LegBidPx(Decimal val)
            :base(Fields.CustomTags.LegBidPx, val) {}

    }


    /// <summary>
    /// LegIOIQty Field
    /// </summary>/
    public sealed class LegIOIQty : QuickFix.Fields.StringField
    {
        public LegIOIQty()
            :base(Fields.CustomTags.LegIOIQty) {}
        public LegIOIQty(string val)
            :base(Fields.CustomTags.LegIOIQty, val) {}

    }


    /// <summary>
    /// NoLegStipulations Field
    /// </summary>/
    public sealed class NoLegStipulations : QuickFix.Fields.IntField
    {
        public NoLegStipulations()
            :base(Fields.CustomTags.NoLegStipulations) {}
        public NoLegStipulations(int val)
            :base(Fields.CustomTags.NoLegStipulations, val) {}

    }


    /// <summary>
    /// LegOfferPx Field
    /// </summary>/
    public sealed class LegOfferPx : QuickFix.Fields.DecimalField
    {
        public LegOfferPx()
            :base(Fields.CustomTags.LegOfferPx) {}
        public LegOfferPx(Decimal val)
            :base(Fields.CustomTags.LegOfferPx, val) {}

    }


    /// <summary>
    /// LegOrderQty Field
    /// </summary>/
    public sealed class LegOrderQty : QuickFix.Fields.DecimalField
    {
        public LegOrderQty()
            :base(Fields.CustomTags.LegOrderQty) {}
        public LegOrderQty(Decimal val)
            :base(Fields.CustomTags.LegOrderQty, val) {}

    }


    /// <summary>
    /// LegPriceType Field
    /// </summary>/
    public sealed class LegPriceType : QuickFix.Fields.IntField
    {
        public LegPriceType()
            :base(Fields.CustomTags.LegPriceType) {}
        public LegPriceType(int val)
            :base(Fields.CustomTags.LegPriceType, val) {}

    }


    /// <summary>
    /// LegStipulationType Field
    /// </summary>/
    public sealed class LegStipulationType : QuickFix.Fields.StringField
    {
        public LegStipulationType()
            :base(Fields.CustomTags.LegStipulationType) {}
        public LegStipulationType(string val)
            :base(Fields.CustomTags.LegStipulationType, val) {}

    }


    /// <summary>
    /// LegStipulationValue Field
    /// </summary>/
    public sealed class LegStipulationValue : QuickFix.Fields.StringField
    {
        public LegStipulationValue()
            :base(Fields.CustomTags.LegStipulationValue) {}
        public LegStipulationValue(string val)
            :base(Fields.CustomTags.LegStipulationValue, val) {}

    }


    /// <summary>
    /// LegSwapType Field
    /// </summary>/
    public sealed class LegSwapType : QuickFix.Fields.IntField
    {
        public LegSwapType()
            :base(Fields.CustomTags.LegSwapType) {}
        public LegSwapType(int val)
            :base(Fields.CustomTags.LegSwapType, val) {}


        // Field Enumerations
        public const int PAR_FOR_PAR = 1;
        public const int MODIFIED_DURATION = 2;
        public const int RISK = 4;
        public const int PROCEEDS = 5;
    }


    /// <summary>
    /// Pool Field
    /// </summary>/
    public sealed class Pool : QuickFix.Fields.StringField
    {
        public Pool()
            :base(Fields.CustomTags.Pool) {}
        public Pool(string val)
            :base(Fields.CustomTags.Pool, val) {}

    }


    /// <summary>
    /// QuotePriceType Field
    /// </summary>/
    public sealed class QuotePriceType : QuickFix.Fields.IntField
    {
        public QuotePriceType()
            :base(Fields.CustomTags.QuotePriceType) {}
        public QuotePriceType(int val)
            :base(Fields.CustomTags.QuotePriceType, val) {}


        // Field Enumerations
        public const int PERCENT = 1;
        public const int YIELD = 10;
        public const int PER_SHARE = 2;
        public const int FIXED_AMOUNT = 3;
        public const int DISCOUNT = 4;
        public const int PREMIUM = 5;
        public const int SPREAD = 6;
        public const int TED_PRICE = 7;
        public const int TED_YIELD = 8;
        public const int YIELD_SPREAD = 9;
    }


    /// <summary>
    /// QuoteRespID Field
    /// </summary>/
    public sealed class QuoteRespID : QuickFix.Fields.StringField
    {
        public QuoteRespID()
            :base(Fields.CustomTags.QuoteRespID) {}
        public QuoteRespID(string val)
            :base(Fields.CustomTags.QuoteRespID, val) {}

    }


    /// <summary>
    /// QuoteRespType Field
    /// </summary>/
    public sealed class QuoteRespType : QuickFix.Fields.IntField
    {
        public QuoteRespType()
            :base(Fields.CustomTags.QuoteRespType) {}
        public QuoteRespType(int val)
            :base(Fields.CustomTags.QuoteRespType, val) {}


        // Field Enumerations
        public const int HIT_LIFT = 1;
        public const int COUNTER = 2;
        public const int EXPIRED = 3;
        public const int COVER = 4;
        public const int DONE_AWAY = 5;
        public const int PASS = 6;
        public const int END_TRADE = 7;
        public const int TIMED_OUT = 8;
    }


    /// <summary>
    /// QuoteQualifier Field
    /// </summary>/
    public sealed class QuoteQualifier : QuickFix.Fields.CharField
    {
        public QuoteQualifier()
            :base(Fields.CustomTags.QuoteQualifier) {}
        public QuoteQualifier(char val)
            :base(Fields.CustomTags.QuoteQualifier, val) {}

    }


    /// <summary>
    /// YieldRedemptionDate Field
    /// </summary>/
    public sealed class YieldRedemptionDate : QuickFix.Fields.StringField
    {
        public YieldRedemptionDate()
            :base(Fields.CustomTags.YieldRedemptionDate) {}
        public YieldRedemptionDate(string val)
            :base(Fields.CustomTags.YieldRedemptionDate, val) {}

    }


    /// <summary>
    /// YieldRedemptionPrice Field
    /// </summary>/
    public sealed class YieldRedemptionPrice : QuickFix.Fields.DecimalField
    {
        public YieldRedemptionPrice()
            :base(Fields.CustomTags.YieldRedemptionPrice) {}
        public YieldRedemptionPrice(Decimal val)
            :base(Fields.CustomTags.YieldRedemptionPrice, val) {}

    }


    /// <summary>
    /// YieldRedemptionPriceType Field
    /// </summary>/
    public sealed class YieldRedemptionPriceType : QuickFix.Fields.IntField
    {
        public YieldRedemptionPriceType()
            :base(Fields.CustomTags.YieldRedemptionPriceType) {}
        public YieldRedemptionPriceType(int val)
            :base(Fields.CustomTags.YieldRedemptionPriceType, val) {}

    }


    /// <summary>
    /// BenchmarkSecurityID Field
    /// </summary>/
    public sealed class BenchmarkSecurityID : QuickFix.Fields.StringField
    {
        public BenchmarkSecurityID()
            :base(Fields.CustomTags.BenchmarkSecurityID) {}
        public BenchmarkSecurityID(string val)
            :base(Fields.CustomTags.BenchmarkSecurityID, val) {}

    }


    /// <summary>
    /// ReversalIndicator Field
    /// </summary>/
    public sealed class ReversalIndicator : QuickFix.Fields.BooleanField
    {
        public ReversalIndicator()
            :base(Fields.CustomTags.ReversalIndicator) {}
        public ReversalIndicator(Boolean val)
            :base(Fields.CustomTags.ReversalIndicator, val) {}

    }


    /// <summary>
    /// YieldCalcDate Field
    /// </summary>/
    public sealed class YieldCalcDate : QuickFix.Fields.StringField
    {
        public YieldCalcDate()
            :base(Fields.CustomTags.YieldCalcDate) {}
        public YieldCalcDate(string val)
            :base(Fields.CustomTags.YieldCalcDate, val) {}

    }


    /// <summary>
    /// NoPositions Field
    /// </summary>/
    public sealed class NoPositions : QuickFix.Fields.IntField
    {
        public NoPositions()
            :base(Fields.CustomTags.NoPositions) {}
        public NoPositions(int val)
            :base(Fields.CustomTags.NoPositions, val) {}

    }


    /// <summary>
    /// PosType Field
    /// </summary>/
    public sealed class PosType : QuickFix.Fields.StringField
    {
        public PosType()
            :base(Fields.CustomTags.PosType) {}
        public PosType(string val)
            :base(Fields.CustomTags.PosType, val) {}


        // Field Enumerations
        public const string ALLOCATION_TRADE_QTY = "ALC";
        public const string OPTION_ASSIGNMENT = "AS";
        public const string AS_OF_TRADE_QTY = "ASF";
        public const string DELIVERY_QTY = "DLV";
        public const string ELECTRONIC_TRADE_QTY = "ETR";
        public const string OPTION_EXERCISE_QTY = "EX";
        public const string END_OF_DAY_QTY = "FIN";
        public const string INTRA_SPREAD_QTY = "IAS";
        public const string INTER_SPREAD_QTY = "IES";
        public const string ADJUSTMENT_QTY = "PA";
        public const string PIT_TRADE_QTY = "PIT";
        public const string START_OF_DAY_QTY = "SOD";
        public const string INTEGRAL_SPLIT = "SPL";
        public const string TRANSACTION_FROM_ASSIGNMENT = "TA";
        public const string TOTAL_TRANSACTION_QTY = "TOT";
        public const string TRANSACTION_QUANTITY = "TQ";
        public const string TRANSFER_TRADE_QTY = "TRF";
        public const string TRANSACTION_FROM_EXERCISE = "TX";
        public const string CROSS_MARGIN_QTY = "XM";
        public const string RECEIVE_QUANTITY = "RCV";
        public const string CORPORATE_ACTION_ADJUSTMENT = "CAA";
        public const string DELIVERY_NOTICE_QTY = "DN";
        public const string EXCHANGE_FOR_PHYSICAL_QTY = "EP";
        public const string PRIVATELY_NEGOTIATED_TRADE_QTY = "PNTN";
        public const string NET_DELTA_QTY = "DLT";
        public const string CREDIT_EVENT_ADJUSTMENT = "CEA";
        public const string SUCCESSION_EVENT_ADJUSTMENT = "SEA";
    }


    /// <summary>
    /// LongQty Field
    /// </summary>/
    public sealed class LongQty : QuickFix.Fields.DecimalField
    {
        public LongQty()
            :base(Fields.CustomTags.LongQty) {}
        public LongQty(Decimal val)
            :base(Fields.CustomTags.LongQty, val) {}

    }


    /// <summary>
    /// ShortQty Field
    /// </summary>/
    public sealed class ShortQty : QuickFix.Fields.DecimalField
    {
        public ShortQty()
            :base(Fields.CustomTags.ShortQty) {}
        public ShortQty(Decimal val)
            :base(Fields.CustomTags.ShortQty, val) {}

    }


    /// <summary>
    /// PosQtyStatus Field
    /// </summary>/
    public sealed class PosQtyStatus : QuickFix.Fields.IntField
    {
        public PosQtyStatus()
            :base(Fields.CustomTags.PosQtyStatus) {}
        public PosQtyStatus(int val)
            :base(Fields.CustomTags.PosQtyStatus, val) {}


        // Field Enumerations
        public const int SUBMITTED = 0;
        public const int ACCEPTED = 1;
        public const int REJECTED = 2;
    }


    /// <summary>
    /// PosAmtType Field
    /// </summary>/
    public sealed class PosAmtType : QuickFix.Fields.StringField
    {
        public PosAmtType()
            :base(Fields.CustomTags.PosAmtType) {}
        public PosAmtType(string val)
            :base(Fields.CustomTags.PosAmtType, val) {}


        // Field Enumerations
        public const string CASH_AMOUNT = "CASH";
        public const string CASH_RESIDUAL_AMOUNT = "CRES";
        public const string FINAL_MARK_TO_MARKET_AMOUNT = "FMTM";
        public const string INCREMENTAL_MARK_TO_MARKET_AMOUNT = "IMTM";
        public const string PREMIUM_AMOUNT = "PREM";
        public const string START_OF_DAY_MARK_TO_MARKET_AMOUNT = "SMTM";
        public const string TRADE_VARIATION_AMOUNT = "TVAR";
        public const string VALUE_ADJUSTED_AMOUNT = "VADJ";
        public const string SETTLEMENT_VALUE = "SETL";
        public const string INITIAL_TRADE_COUPON_AMOUNT = "ICPN";
        public const string ACCRUED_COUPON_AMOUNT = "ACPN";
        public const string COUPON_AMOUNT = "CPN";
        public const string INCREMENTAL_ACCRUED_COUPON = "IACPN";
        public const string COLLATERALIZED_MARK_TO_MARKET = "CMTM";
        public const string INCREMENTAL_COLLATERALIZED_MARK_TO_MARKET = "ICMTM";
        public const string COMPENSATION_AMOUNT = "DLV";
        public const string TOTAL_BANKED_AMOUNT = "BANK";
        public const string TOTAL_COLLATERALIZED_AMOUNT = "COLAT";
    }


    /// <summary>
    /// PosAmt Field
    /// </summary>/
    public sealed class PosAmt : QuickFix.Fields.DecimalField
    {
        public PosAmt()
            :base(Fields.CustomTags.PosAmt) {}
        public PosAmt(Decimal val)
            :base(Fields.CustomTags.PosAmt, val) {}

    }


    /// <summary>
    /// PosTransType Field
    /// </summary>/
    public sealed class PosTransType : QuickFix.Fields.IntField
    {
        public PosTransType()
            :base(Fields.CustomTags.PosTransType) {}
        public PosTransType(int val)
            :base(Fields.CustomTags.PosTransType, val) {}


        // Field Enumerations
        public const int EXERCISE = 1;
        public const int DO_NOT_EXERCISE = 2;
        public const int POSITION_ADJUSTMENT = 3;
        public const int POSITION_CHANGE_SUBMISSION_MARGIN_DISPOSITION = 4;
        public const int PLEDGE = 5;
        public const int LARGE_TRADER_SUBMISSION = 6;
    }


    /// <summary>
    /// PosReqID Field
    /// </summary>/
    public sealed class PosReqID : QuickFix.Fields.StringField
    {
        public PosReqID()
            :base(Fields.CustomTags.PosReqID) {}
        public PosReqID(string val)
            :base(Fields.CustomTags.PosReqID, val) {}

    }


    /// <summary>
    /// NoUnderlyings Field
    /// </summary>/
    public sealed class NoUnderlyings : QuickFix.Fields.IntField
    {
        public NoUnderlyings()
            :base(Fields.CustomTags.NoUnderlyings) {}
        public NoUnderlyings(int val)
            :base(Fields.CustomTags.NoUnderlyings, val) {}

    }


    /// <summary>
    /// PosMaintAction Field
    /// </summary>/
    public sealed class PosMaintAction : QuickFix.Fields.IntField
    {
        public PosMaintAction()
            :base(Fields.CustomTags.PosMaintAction) {}
        public PosMaintAction(int val)
            :base(Fields.CustomTags.PosMaintAction, val) {}


        // Field Enumerations
        public const int NEW = 1;
        public const int REPLACE = 2;
        public const int CANCEL = 3;
        public const int REVERSE = 4;
    }


    /// <summary>
    /// OrigPosReqRefID Field
    /// </summary>/
    public sealed class OrigPosReqRefID : QuickFix.Fields.StringField
    {
        public OrigPosReqRefID()
            :base(Fields.CustomTags.OrigPosReqRefID) {}
        public OrigPosReqRefID(string val)
            :base(Fields.CustomTags.OrigPosReqRefID, val) {}

    }


    /// <summary>
    /// PosMaintRptRefID Field
    /// </summary>/
    public sealed class PosMaintRptRefID : QuickFix.Fields.StringField
    {
        public PosMaintRptRefID()
            :base(Fields.CustomTags.PosMaintRptRefID) {}
        public PosMaintRptRefID(string val)
            :base(Fields.CustomTags.PosMaintRptRefID, val) {}

    }


    /// <summary>
    /// ClearingBusinessDate Field
    /// </summary>/
    public sealed class ClearingBusinessDate : QuickFix.Fields.StringField
    {
        public ClearingBusinessDate()
            :base(Fields.CustomTags.ClearingBusinessDate) {}
        public ClearingBusinessDate(string val)
            :base(Fields.CustomTags.ClearingBusinessDate, val) {}

    }


    /// <summary>
    /// SettlSessID Field
    /// </summary>/
    public sealed class SettlSessID : QuickFix.Fields.StringField
    {
        public SettlSessID()
            :base(Fields.CustomTags.SettlSessID) {}
        public SettlSessID(string val)
            :base(Fields.CustomTags.SettlSessID, val) {}


        // Field Enumerations
        public const string INTRADAY = "ITD";
        public const string REGULAR_TRADING_HOURS = "RTH";
        public const string ELECTRONIC_TRADING_HOURS = "ETH";
        public const string END_OF_DAY = "EOD";
    }


    /// <summary>
    /// SettlSessSubID Field
    /// </summary>/
    public sealed class SettlSessSubID : QuickFix.Fields.StringField
    {
        public SettlSessSubID()
            :base(Fields.CustomTags.SettlSessSubID) {}
        public SettlSessSubID(string val)
            :base(Fields.CustomTags.SettlSessSubID, val) {}

    }


    /// <summary>
    /// AdjustmentType Field
    /// </summary>/
    public sealed class AdjustmentType : QuickFix.Fields.IntField
    {
        public AdjustmentType()
            :base(Fields.CustomTags.AdjustmentType) {}
        public AdjustmentType(int val)
            :base(Fields.CustomTags.AdjustmentType, val) {}


        // Field Enumerations
        public const int PROCESS_REQUEST_AS_MARGIN_DISPOSITION = 0;
        public const int DELTA_PLUS = 1;
        public const int DELTA_MINUS = 2;
        public const int FINAL = 3;
    }


    /// <summary>
    /// ContraryInstructionIndicator Field
    /// </summary>/
    public sealed class ContraryInstructionIndicator : QuickFix.Fields.BooleanField
    {
        public ContraryInstructionIndicator()
            :base(Fields.CustomTags.ContraryInstructionIndicator) {}
        public ContraryInstructionIndicator(Boolean val)
            :base(Fields.CustomTags.ContraryInstructionIndicator, val) {}

    }


    /// <summary>
    /// PriorSpreadIndicator Field
    /// </summary>/
    public sealed class PriorSpreadIndicator : QuickFix.Fields.BooleanField
    {
        public PriorSpreadIndicator()
            :base(Fields.CustomTags.PriorSpreadIndicator) {}
        public PriorSpreadIndicator(Boolean val)
            :base(Fields.CustomTags.PriorSpreadIndicator, val) {}

    }


    /// <summary>
    /// PosMaintRptID Field
    /// </summary>/
    public sealed class PosMaintRptID : QuickFix.Fields.StringField
    {
        public PosMaintRptID()
            :base(Fields.CustomTags.PosMaintRptID) {}
        public PosMaintRptID(string val)
            :base(Fields.CustomTags.PosMaintRptID, val) {}

    }


    /// <summary>
    /// PosMaintStatus Field
    /// </summary>/
    public sealed class PosMaintStatus : QuickFix.Fields.IntField
    {
        public PosMaintStatus()
            :base(Fields.CustomTags.PosMaintStatus) {}
        public PosMaintStatus(int val)
            :base(Fields.CustomTags.PosMaintStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int ACCEPTED_WITH_WARNINGS = 1;
        public const int REJECTED = 2;
        public const int COMPLETED = 3;
        public const int COMPLETED_WITH_WARNINGS = 4;
    }


    /// <summary>
    /// PosMaintResult Field
    /// </summary>/
    public sealed class PosMaintResult : QuickFix.Fields.IntField
    {
        public PosMaintResult()
            :base(Fields.CustomTags.PosMaintResult) {}
        public PosMaintResult(int val)
            :base(Fields.CustomTags.PosMaintResult, val) {}


        // Field Enumerations
        public const int SUCCESSFUL_COMPLETION = 0;
        public const int REJECTED = 1;
        public const int OTHER = 99;
    }


    /// <summary>
    /// PosReqType Field
    /// </summary>/
    public sealed class PosReqType : QuickFix.Fields.IntField
    {
        public PosReqType()
            :base(Fields.CustomTags.PosReqType) {}
        public PosReqType(int val)
            :base(Fields.CustomTags.PosReqType, val) {}


        // Field Enumerations
        public const int POSITIONS = 0;
        public const int TRADES = 1;
        public const int EXERCISES = 2;
        public const int ASSIGNMENTS = 3;
        public const int SETTLEMENT_ACTIVITY = 4;
        public const int BACKOUT_MESSAGE = 5;
        public const int DELTA_POSITIONS = 6;
    }


    /// <summary>
    /// ResponseTransportType Field
    /// </summary>/
    public sealed class ResponseTransportType : QuickFix.Fields.IntField
    {
        public ResponseTransportType()
            :base(Fields.CustomTags.ResponseTransportType) {}
        public ResponseTransportType(int val)
            :base(Fields.CustomTags.ResponseTransportType, val) {}


        // Field Enumerations
        public const int INBAND = 0;
        public const int OUT_OF_BAND = 1;
    }


    /// <summary>
    /// ResponseDestination Field
    /// </summary>/
    public sealed class ResponseDestination : QuickFix.Fields.StringField
    {
        public ResponseDestination()
            :base(Fields.CustomTags.ResponseDestination) {}
        public ResponseDestination(string val)
            :base(Fields.CustomTags.ResponseDestination, val) {}

    }


    /// <summary>
    /// TotalNumPosReports Field
    /// </summary>/
    public sealed class TotalNumPosReports : QuickFix.Fields.IntField
    {
        public TotalNumPosReports()
            :base(Fields.CustomTags.TotalNumPosReports) {}
        public TotalNumPosReports(int val)
            :base(Fields.CustomTags.TotalNumPosReports, val) {}

    }


    /// <summary>
    /// PosReqResult Field
    /// </summary>/
    public sealed class PosReqResult : QuickFix.Fields.IntField
    {
        public PosReqResult()
            :base(Fields.CustomTags.PosReqResult) {}
        public PosReqResult(int val)
            :base(Fields.CustomTags.PosReqResult, val) {}


        // Field Enumerations
        public const int VALID_REQUEST = 0;
        public const int INVALID_OR_UNSUPPORTED_REQUEST = 1;
        public const int NO_POSITIONS_FOUND_THAT_MATCH_CRITERIA = 2;
        public const int NOT_AUTHORIZED_TO_REQUEST_POSITIONS = 3;
        public const int REQUEST_FOR_POSITION_NOT_SUPPORTED = 4;
        public const int OTHER = 99;
    }


    /// <summary>
    /// PosReqStatus Field
    /// </summary>/
    public sealed class PosReqStatus : QuickFix.Fields.IntField
    {
        public PosReqStatus()
            :base(Fields.CustomTags.PosReqStatus) {}
        public PosReqStatus(int val)
            :base(Fields.CustomTags.PosReqStatus, val) {}


        // Field Enumerations
        public const int COMPLETED = 0;
        public const int COMPLETED_WITH_WARNINGS = 1;
        public const int REJECTED = 2;
    }


    /// <summary>
    /// SettlPrice Field
    /// </summary>/
    public sealed class SettlPrice : QuickFix.Fields.DecimalField
    {
        public SettlPrice()
            :base(Fields.CustomTags.SettlPrice) {}
        public SettlPrice(Decimal val)
            :base(Fields.CustomTags.SettlPrice, val) {}

    }


    /// <summary>
    /// SettlPriceType Field
    /// </summary>/
    public sealed class SettlPriceType : QuickFix.Fields.IntField
    {
        public SettlPriceType()
            :base(Fields.CustomTags.SettlPriceType) {}
        public SettlPriceType(int val)
            :base(Fields.CustomTags.SettlPriceType, val) {}


        // Field Enumerations
        public const int FINAL = 1;
        public const int THEORETICAL = 2;
    }


    /// <summary>
    /// UnderlyingSettlPrice Field
    /// </summary>/
    public sealed class UnderlyingSettlPrice : QuickFix.Fields.DecimalField
    {
        public UnderlyingSettlPrice()
            :base(Fields.CustomTags.UnderlyingSettlPrice) {}
        public UnderlyingSettlPrice(Decimal val)
            :base(Fields.CustomTags.UnderlyingSettlPrice, val) {}

    }


    /// <summary>
    /// UnderlyingSettlPriceType Field
    /// </summary>/
    public sealed class UnderlyingSettlPriceType : QuickFix.Fields.IntField
    {
        public UnderlyingSettlPriceType()
            :base(Fields.CustomTags.UnderlyingSettlPriceType) {}
        public UnderlyingSettlPriceType(int val)
            :base(Fields.CustomTags.UnderlyingSettlPriceType, val) {}

    }


    /// <summary>
    /// PriorSettlPrice Field
    /// </summary>/
    public sealed class PriorSettlPrice : QuickFix.Fields.DecimalField
    {
        public PriorSettlPrice()
            :base(Fields.CustomTags.PriorSettlPrice) {}
        public PriorSettlPrice(Decimal val)
            :base(Fields.CustomTags.PriorSettlPrice, val) {}

    }


    /// <summary>
    /// NoQuoteQualifiers Field
    /// </summary>/
    public sealed class NoQuoteQualifiers : QuickFix.Fields.IntField
    {
        public NoQuoteQualifiers()
            :base(Fields.CustomTags.NoQuoteQualifiers) {}
        public NoQuoteQualifiers(int val)
            :base(Fields.CustomTags.NoQuoteQualifiers, val) {}

    }


    /// <summary>
    /// AllocSettlCurrency Field
    /// </summary>/
    public sealed class AllocSettlCurrency : QuickFix.Fields.StringField
    {
        public AllocSettlCurrency()
            :base(Fields.CustomTags.AllocSettlCurrency) {}
        public AllocSettlCurrency(string val)
            :base(Fields.CustomTags.AllocSettlCurrency, val) {}

    }


    /// <summary>
    /// AllocSettlCurrAmt Field
    /// </summary>/
    public sealed class AllocSettlCurrAmt : QuickFix.Fields.DecimalField
    {
        public AllocSettlCurrAmt()
            :base(Fields.CustomTags.AllocSettlCurrAmt) {}
        public AllocSettlCurrAmt(Decimal val)
            :base(Fields.CustomTags.AllocSettlCurrAmt, val) {}

    }


    /// <summary>
    /// InterestAtMaturity Field
    /// </summary>/
    public sealed class InterestAtMaturity : QuickFix.Fields.DecimalField
    {
        public InterestAtMaturity()
            :base(Fields.CustomTags.InterestAtMaturity) {}
        public InterestAtMaturity(Decimal val)
            :base(Fields.CustomTags.InterestAtMaturity, val) {}

    }


    /// <summary>
    /// LegDatedDate Field
    /// </summary>/
    public sealed class LegDatedDate : QuickFix.Fields.StringField
    {
        public LegDatedDate()
            :base(Fields.CustomTags.LegDatedDate) {}
        public LegDatedDate(string val)
            :base(Fields.CustomTags.LegDatedDate, val) {}

    }


    /// <summary>
    /// LegPool Field
    /// </summary>/
    public sealed class LegPool : QuickFix.Fields.StringField
    {
        public LegPool()
            :base(Fields.CustomTags.LegPool) {}
        public LegPool(string val)
            :base(Fields.CustomTags.LegPool, val) {}

    }


    /// <summary>
    /// AllocInterestAtMaturity Field
    /// </summary>/
    public sealed class AllocInterestAtMaturity : QuickFix.Fields.DecimalField
    {
        public AllocInterestAtMaturity()
            :base(Fields.CustomTags.AllocInterestAtMaturity) {}
        public AllocInterestAtMaturity(Decimal val)
            :base(Fields.CustomTags.AllocInterestAtMaturity, val) {}

    }


    /// <summary>
    /// AllocAccruedInterestAmt Field
    /// </summary>/
    public sealed class AllocAccruedInterestAmt : QuickFix.Fields.DecimalField
    {
        public AllocAccruedInterestAmt()
            :base(Fields.CustomTags.AllocAccruedInterestAmt) {}
        public AllocAccruedInterestAmt(Decimal val)
            :base(Fields.CustomTags.AllocAccruedInterestAmt, val) {}

    }


    /// <summary>
    /// AssignmentMethod Field
    /// </summary>/
    public sealed class AssignmentMethod : QuickFix.Fields.CharField
    {
        public AssignmentMethod()
            :base(Fields.CustomTags.AssignmentMethod) {}
        public AssignmentMethod(char val)
            :base(Fields.CustomTags.AssignmentMethod, val) {}


        // Field Enumerations
        public const char PRO_RATA = 'P';
        public const char RANDOM = 'R';
    }


    /// <summary>
    /// AssignmentUnit Field
    /// </summary>/
    public sealed class AssignmentUnit : QuickFix.Fields.DecimalField
    {
        public AssignmentUnit()
            :base(Fields.CustomTags.AssignmentUnit) {}
        public AssignmentUnit(Decimal val)
            :base(Fields.CustomTags.AssignmentUnit, val) {}

    }


    /// <summary>
    /// OpenInterest Field
    /// </summary>/
    public sealed class OpenInterest : QuickFix.Fields.DecimalField
    {
        public OpenInterest()
            :base(Fields.CustomTags.OpenInterest) {}
        public OpenInterest(Decimal val)
            :base(Fields.CustomTags.OpenInterest, val) {}

    }


    /// <summary>
    /// ExerciseMethod Field
    /// </summary>/
    public sealed class ExerciseMethod : QuickFix.Fields.CharField
    {
        public ExerciseMethod()
            :base(Fields.CustomTags.ExerciseMethod) {}
        public ExerciseMethod(char val)
            :base(Fields.CustomTags.ExerciseMethod, val) {}


        // Field Enumerations
        public const char AUTOMATIC = 'A';
        public const char MANUAL = 'M';
    }


    /// <summary>
    /// TotNumTradeReports Field
    /// </summary>/
    public sealed class TotNumTradeReports : QuickFix.Fields.IntField
    {
        public TotNumTradeReports()
            :base(Fields.CustomTags.TotNumTradeReports) {}
        public TotNumTradeReports(int val)
            :base(Fields.CustomTags.TotNumTradeReports, val) {}

    }


    /// <summary>
    /// TradeRequestResult Field
    /// </summary>/
    public sealed class TradeRequestResult : QuickFix.Fields.IntField
    {
        public TradeRequestResult()
            :base(Fields.CustomTags.TradeRequestResult) {}
        public TradeRequestResult(int val)
            :base(Fields.CustomTags.TradeRequestResult, val) {}


        // Field Enumerations
        public const int SUCCESSFUL = 0;
        public const int INVALID_OR_UNKNOWN_INSTRUMENT = 1;
        public const int INVALID_TYPE_OF_TRADE_REQUESTED = 2;
        public const int INVALID_PARTIES = 3;
        public const int INVALID_TRANSPORT_TYPE_REQUESTED = 4;
        public const int INVALID_DESTINATION_REQUESTED = 5;
        public const int TRADEREQUESTTYPE_NOT_SUPPORTED = 8;
        public const int NOT_AUTHORIZED = 9;
        public const int OTHER = 99;
        public const int UNAUTHORIZED_ROR_TRADE_CAPTURE_REPORT_REQUEST = 9;
    }


    /// <summary>
    /// TradeRequestStatus Field
    /// </summary>/
    public sealed class TradeRequestStatus : QuickFix.Fields.IntField
    {
        public TradeRequestStatus()
            :base(Fields.CustomTags.TradeRequestStatus) {}
        public TradeRequestStatus(int val)
            :base(Fields.CustomTags.TradeRequestStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int COMPLETED = 1;
        public const int REJECTED = 2;
    }


    /// <summary>
    /// SideMultiLegReportingType Field
    /// </summary>/
    public sealed class SideMultiLegReportingType : QuickFix.Fields.IntField
    {
        public SideMultiLegReportingType()
            :base(Fields.CustomTags.SideMultiLegReportingType) {}
        public SideMultiLegReportingType(int val)
            :base(Fields.CustomTags.SideMultiLegReportingType, val) {}


        // Field Enumerations
        public const int SINGLE_SECURITY = 1;
        public const int INDIVIDUAL_LEG_OF_A_MULTILEG_SECURITY = 2;
        public const int MULTILEG_SECURITY = 3;
    }


    /// <summary>
    /// NoPosAmt Field
    /// </summary>/
    public sealed class NoPosAmt : QuickFix.Fields.IntField
    {
        public NoPosAmt()
            :base(Fields.CustomTags.NoPosAmt) {}
        public NoPosAmt(int val)
            :base(Fields.CustomTags.NoPosAmt, val) {}

    }


    /// <summary>
    /// AutoAcceptIndicator Field
    /// </summary>/
    public sealed class AutoAcceptIndicator : QuickFix.Fields.BooleanField
    {
        public AutoAcceptIndicator()
            :base(Fields.CustomTags.AutoAcceptIndicator) {}
        public AutoAcceptIndicator(Boolean val)
            :base(Fields.CustomTags.AutoAcceptIndicator, val) {}

    }


    /// <summary>
    /// AllocReportID Field
    /// </summary>/
    public sealed class AllocReportID : QuickFix.Fields.StringField
    {
        public AllocReportID()
            :base(Fields.CustomTags.AllocReportID) {}
        public AllocReportID(string val)
            :base(Fields.CustomTags.AllocReportID, val) {}

    }


    /// <summary>
    /// NoNested2PartyIDs Field
    /// </summary>/
    public sealed class NoNested2PartyIDs : QuickFix.Fields.IntField
    {
        public NoNested2PartyIDs()
            :base(Fields.CustomTags.NoNested2PartyIDs) {}
        public NoNested2PartyIDs(int val)
            :base(Fields.CustomTags.NoNested2PartyIDs, val) {}

    }


    /// <summary>
    /// Nested2PartyID Field
    /// </summary>/
    public sealed class Nested2PartyID : QuickFix.Fields.StringField
    {
        public Nested2PartyID()
            :base(Fields.CustomTags.Nested2PartyID) {}
        public Nested2PartyID(string val)
            :base(Fields.CustomTags.Nested2PartyID, val) {}

    }


    /// <summary>
    /// Nested2PartyIDSource Field
    /// </summary>/
    public sealed class Nested2PartyIDSource : QuickFix.Fields.CharField
    {
        public Nested2PartyIDSource()
            :base(Fields.CustomTags.Nested2PartyIDSource) {}
        public Nested2PartyIDSource(char val)
            :base(Fields.CustomTags.Nested2PartyIDSource, val) {}

    }


    /// <summary>
    /// Nested2PartyRole Field
    /// </summary>/
    public sealed class Nested2PartyRole : QuickFix.Fields.IntField
    {
        public Nested2PartyRole()
            :base(Fields.CustomTags.Nested2PartyRole) {}
        public Nested2PartyRole(int val)
            :base(Fields.CustomTags.Nested2PartyRole, val) {}

    }


    /// <summary>
    /// Nested2PartySubID Field
    /// </summary>/
    public sealed class Nested2PartySubID : QuickFix.Fields.StringField
    {
        public Nested2PartySubID()
            :base(Fields.CustomTags.Nested2PartySubID) {}
        public Nested2PartySubID(string val)
            :base(Fields.CustomTags.Nested2PartySubID, val) {}

    }


    /// <summary>
    /// BenchmarkSecurityIDSource Field
    /// </summary>/
    public sealed class BenchmarkSecurityIDSource : QuickFix.Fields.StringField
    {
        public BenchmarkSecurityIDSource()
            :base(Fields.CustomTags.BenchmarkSecurityIDSource) {}
        public BenchmarkSecurityIDSource(string val)
            :base(Fields.CustomTags.BenchmarkSecurityIDSource, val) {}

    }


    /// <summary>
    /// UnderlyingSecuritySubType Field
    /// </summary>/
    public sealed class UnderlyingSecuritySubType : QuickFix.Fields.StringField
    {
        public UnderlyingSecuritySubType()
            :base(Fields.CustomTags.UnderlyingSecuritySubType) {}
        public UnderlyingSecuritySubType(string val)
            :base(Fields.CustomTags.UnderlyingSecuritySubType, val) {}

    }


    /// <summary>
    /// AllowableOneSidednessPct Field
    /// </summary>/
    public sealed class AllowableOneSidednessPct : QuickFix.Fields.DecimalField
    {
        public AllowableOneSidednessPct()
            :base(Fields.CustomTags.AllowableOneSidednessPct) {}
        public AllowableOneSidednessPct(Decimal val)
            :base(Fields.CustomTags.AllowableOneSidednessPct, val) {}

    }


    /// <summary>
    /// AllowableOneSidednessValue Field
    /// </summary>/
    public sealed class AllowableOneSidednessValue : QuickFix.Fields.DecimalField
    {
        public AllowableOneSidednessValue()
            :base(Fields.CustomTags.AllowableOneSidednessValue) {}
        public AllowableOneSidednessValue(Decimal val)
            :base(Fields.CustomTags.AllowableOneSidednessValue, val) {}

    }


    /// <summary>
    /// AllowableOneSidednessCurr Field
    /// </summary>/
    public sealed class AllowableOneSidednessCurr : QuickFix.Fields.StringField
    {
        public AllowableOneSidednessCurr()
            :base(Fields.CustomTags.AllowableOneSidednessCurr) {}
        public AllowableOneSidednessCurr(string val)
            :base(Fields.CustomTags.AllowableOneSidednessCurr, val) {}

    }


    /// <summary>
    /// NoTrdRegTimestamps Field
    /// </summary>/
    public sealed class NoTrdRegTimestamps : QuickFix.Fields.IntField
    {
        public NoTrdRegTimestamps()
            :base(Fields.CustomTags.NoTrdRegTimestamps) {}
        public NoTrdRegTimestamps(int val)
            :base(Fields.CustomTags.NoTrdRegTimestamps, val) {}

    }


    /// <summary>
    /// TrdRegTimestamp Field
    /// </summary>/
    public sealed class TrdRegTimestamp : QuickFix.Fields.DateTimeField
    {
        public TrdRegTimestamp()
            :base(Fields.CustomTags.TrdRegTimestamp) {}
        public TrdRegTimestamp(DateTime val)
            :base(Fields.CustomTags.TrdRegTimestamp, val) {}
        public TrdRegTimestamp(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TrdRegTimestamp, val, showMilliseconds) {}
		public TrdRegTimestamp(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TrdRegTimestamp, val, precision) {}

    }


    /// <summary>
    /// TrdRegTimestampType Field
    /// </summary>/
    public sealed class TrdRegTimestampType : QuickFix.Fields.IntField
    {
        public TrdRegTimestampType()
            :base(Fields.CustomTags.TrdRegTimestampType) {}
        public TrdRegTimestampType(int val)
            :base(Fields.CustomTags.TrdRegTimestampType, val) {}


        // Field Enumerations
        public const int EXECUTION_TIME = 1;
        public const int TIME_IN = 2;
        public const int TIME_OUT = 3;
        public const int BROKER_RECEIPT = 4;
        public const int BROKER_EXECUTION = 5;
        public const int DESK_RECEIPT = 6;
        public const int SUBMISSION_TO_CLEARING = 7;
    }


    /// <summary>
    /// TrdRegTimestampOrigin Field
    /// </summary>/
    public sealed class TrdRegTimestampOrigin : QuickFix.Fields.StringField
    {
        public TrdRegTimestampOrigin()
            :base(Fields.CustomTags.TrdRegTimestampOrigin) {}
        public TrdRegTimestampOrigin(string val)
            :base(Fields.CustomTags.TrdRegTimestampOrigin, val) {}

    }


    /// <summary>
    /// ConfirmRefID Field
    /// </summary>/
    public sealed class ConfirmRefID : QuickFix.Fields.StringField
    {
        public ConfirmRefID()
            :base(Fields.CustomTags.ConfirmRefID) {}
        public ConfirmRefID(string val)
            :base(Fields.CustomTags.ConfirmRefID, val) {}

    }


    /// <summary>
    /// ConfirmType Field
    /// </summary>/
    public sealed class ConfirmType : QuickFix.Fields.IntField
    {
        public ConfirmType()
            :base(Fields.CustomTags.ConfirmType) {}
        public ConfirmType(int val)
            :base(Fields.CustomTags.ConfirmType, val) {}


        // Field Enumerations
        public const int STATUS = 1;
        public const int CONFIRMATION = 2;
        public const int CONFIRMATION_REQUEST_REJECTED = 3;
    }


    /// <summary>
    /// ConfirmRejReason Field
    /// </summary>/
    public sealed class ConfirmRejReason : QuickFix.Fields.IntField
    {
        public ConfirmRejReason()
            :base(Fields.CustomTags.ConfirmRejReason) {}
        public ConfirmRejReason(int val)
            :base(Fields.CustomTags.ConfirmRejReason, val) {}


        // Field Enumerations
        public const int MISMATCHED_ACCOUNT = 1;
        public const int MISSING_SETTLEMENT_INSTRUCTIONS = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// BookingType Field
    /// </summary>/
    public sealed class BookingType : QuickFix.Fields.IntField
    {
        public BookingType()
            :base(Fields.CustomTags.BookingType) {}
        public BookingType(int val)
            :base(Fields.CustomTags.BookingType, val) {}


        // Field Enumerations
        public const int REGULAR_BOOKING = 0;
        public const int CFD = 1;
        public const int TOTAL_RETURN_SWAP = 2;
    }


    /// <summary>
    /// IndividualAllocRejCode Field
    /// </summary>/
    public sealed class IndividualAllocRejCode : QuickFix.Fields.IntField
    {
        public IndividualAllocRejCode()
            :base(Fields.CustomTags.IndividualAllocRejCode) {}
        public IndividualAllocRejCode(int val)
            :base(Fields.CustomTags.IndividualAllocRejCode, val) {}

    }


    /// <summary>
    /// SettlInstMsgID Field
    /// </summary>/
    public sealed class SettlInstMsgID : QuickFix.Fields.StringField
    {
        public SettlInstMsgID()
            :base(Fields.CustomTags.SettlInstMsgID) {}
        public SettlInstMsgID(string val)
            :base(Fields.CustomTags.SettlInstMsgID, val) {}

    }


    /// <summary>
    /// NoSettlInst Field
    /// </summary>/
    public sealed class NoSettlInst : QuickFix.Fields.IntField
    {
        public NoSettlInst()
            :base(Fields.CustomTags.NoSettlInst) {}
        public NoSettlInst(int val)
            :base(Fields.CustomTags.NoSettlInst, val) {}

    }


    /// <summary>
    /// LastUpdateTime Field
    /// </summary>/
    public sealed class LastUpdateTime : QuickFix.Fields.DateTimeField
    {
        public LastUpdateTime()
            :base(Fields.CustomTags.LastUpdateTime) {}
        public LastUpdateTime(DateTime val)
            :base(Fields.CustomTags.LastUpdateTime, val) {}
        public LastUpdateTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.LastUpdateTime, val, showMilliseconds) {}
		public LastUpdateTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.LastUpdateTime, val, precision) {}

    }


    /// <summary>
    /// AllocSettlInstType Field
    /// </summary>/
    public sealed class AllocSettlInstType : QuickFix.Fields.IntField
    {
        public AllocSettlInstType()
            :base(Fields.CustomTags.AllocSettlInstType) {}
        public AllocSettlInstType(int val)
            :base(Fields.CustomTags.AllocSettlInstType, val) {}


        // Field Enumerations
        public const int USE_DEFAULT_INSTRUCTIONS = 0;
        public const int DERIVE_FROM_PARAMETERS_PROVIDED = 1;
        public const int FULL_DETAILS_PROVIDED = 2;
        public const int SSI_DB_IDS_PROVIDED = 3;
        public const int PHONE_FOR_INSTRUCTIONS = 4;
    }


    /// <summary>
    /// NoSettlPartyIDs Field
    /// </summary>/
    public sealed class NoSettlPartyIDs : QuickFix.Fields.IntField
    {
        public NoSettlPartyIDs()
            :base(Fields.CustomTags.NoSettlPartyIDs) {}
        public NoSettlPartyIDs(int val)
            :base(Fields.CustomTags.NoSettlPartyIDs, val) {}

    }


    /// <summary>
    /// SettlPartyID Field
    /// </summary>/
    public sealed class SettlPartyID : QuickFix.Fields.StringField
    {
        public SettlPartyID()
            :base(Fields.CustomTags.SettlPartyID) {}
        public SettlPartyID(string val)
            :base(Fields.CustomTags.SettlPartyID, val) {}

    }


    /// <summary>
    /// SettlPartyIDSource Field
    /// </summary>/
    public sealed class SettlPartyIDSource : QuickFix.Fields.CharField
    {
        public SettlPartyIDSource()
            :base(Fields.CustomTags.SettlPartyIDSource) {}
        public SettlPartyIDSource(char val)
            :base(Fields.CustomTags.SettlPartyIDSource, val) {}

    }


    /// <summary>
    /// SettlPartyRole Field
    /// </summary>/
    public sealed class SettlPartyRole : QuickFix.Fields.IntField
    {
        public SettlPartyRole()
            :base(Fields.CustomTags.SettlPartyRole) {}
        public SettlPartyRole(int val)
            :base(Fields.CustomTags.SettlPartyRole, val) {}

    }


    /// <summary>
    /// SettlPartySubID Field
    /// </summary>/
    public sealed class SettlPartySubID : QuickFix.Fields.StringField
    {
        public SettlPartySubID()
            :base(Fields.CustomTags.SettlPartySubID) {}
        public SettlPartySubID(string val)
            :base(Fields.CustomTags.SettlPartySubID, val) {}

    }


    /// <summary>
    /// SettlPartySubIDType Field
    /// </summary>/
    public sealed class SettlPartySubIDType : QuickFix.Fields.IntField
    {
        public SettlPartySubIDType()
            :base(Fields.CustomTags.SettlPartySubIDType) {}
        public SettlPartySubIDType(int val)
            :base(Fields.CustomTags.SettlPartySubIDType, val) {}

    }


    /// <summary>
    /// DlvyInstType Field
    /// </summary>/
    public sealed class DlvyInstType : QuickFix.Fields.CharField
    {
        public DlvyInstType()
            :base(Fields.CustomTags.DlvyInstType) {}
        public DlvyInstType(char val)
            :base(Fields.CustomTags.DlvyInstType, val) {}


        // Field Enumerations
        public const char CASH = 'C';
        public const char SECURITIES = 'S';
    }


    /// <summary>
    /// TerminationType Field
    /// </summary>/
    public sealed class TerminationType : QuickFix.Fields.IntField
    {
        public TerminationType()
            :base(Fields.CustomTags.TerminationType) {}
        public TerminationType(int val)
            :base(Fields.CustomTags.TerminationType, val) {}


        // Field Enumerations
        public const int OVERNIGHT = 1;
        public const int TERM = 2;
        public const int FLEXIBLE = 3;
        public const int OPEN = 4;
    }


    /// <summary>
    /// SettlInstReqID Field
    /// </summary>/
    public sealed class SettlInstReqID : QuickFix.Fields.StringField
    {
        public SettlInstReqID()
            :base(Fields.CustomTags.SettlInstReqID) {}
        public SettlInstReqID(string val)
            :base(Fields.CustomTags.SettlInstReqID, val) {}

    }


    /// <summary>
    /// SettlInstReqRejCode Field
    /// </summary>/
    public sealed class SettlInstReqRejCode : QuickFix.Fields.IntField
    {
        public SettlInstReqRejCode()
            :base(Fields.CustomTags.SettlInstReqRejCode) {}
        public SettlInstReqRejCode(int val)
            :base(Fields.CustomTags.SettlInstReqRejCode, val) {}


        // Field Enumerations
        public const int UNABLE_TO_PROCESS_REQUEST = 0;
        public const int UNKNOWN_ACCOUNT = 1;
        public const int NO_MATCHING_SETTLEMENT_INSTRUCTIONS_FOUND = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// SecondaryAllocID Field
    /// </summary>/
    public sealed class SecondaryAllocID : QuickFix.Fields.StringField
    {
        public SecondaryAllocID()
            :base(Fields.CustomTags.SecondaryAllocID) {}
        public SecondaryAllocID(string val)
            :base(Fields.CustomTags.SecondaryAllocID, val) {}

    }


    /// <summary>
    /// AllocReportType Field
    /// </summary>/
    public sealed class AllocReportType : QuickFix.Fields.IntField
    {
        public AllocReportType()
            :base(Fields.CustomTags.AllocReportType) {}
        public AllocReportType(int val)
            :base(Fields.CustomTags.AllocReportType, val) {}


        // Field Enumerations
        public const int SELLSIDE_CALCULATED_USING_PRELIMINARY = 3;
        public const int SELLSIDE_CALCULATED_WITHOUT_PRELIMINARY = 4;
        public const int WAREHOUSE_RECAP = 5;
        public const int REQUEST_TO_INTERMEDIARY = 8;
        public const int PRELIMINARY_REQUEST_TO_INTERMEDIARY = 2;
        public const int ACCEPT = 9;
        public const int REJECT = 10;
        public const int ACCEPT_PENDING = 11;
        public const int COMPLETE = 12;
        public const int REVERSE_PENDING = 14;
    }


    /// <summary>
    /// AllocReportRefID Field
    /// </summary>/
    public sealed class AllocReportRefID : QuickFix.Fields.StringField
    {
        public AllocReportRefID()
            :base(Fields.CustomTags.AllocReportRefID) {}
        public AllocReportRefID(string val)
            :base(Fields.CustomTags.AllocReportRefID, val) {}

    }


    /// <summary>
    /// AllocCancReplaceReason Field
    /// </summary>/
    public sealed class AllocCancReplaceReason : QuickFix.Fields.IntField
    {
        public AllocCancReplaceReason()
            :base(Fields.CustomTags.AllocCancReplaceReason) {}
        public AllocCancReplaceReason(int val)
            :base(Fields.CustomTags.AllocCancReplaceReason, val) {}


        // Field Enumerations
        public const int ORIGINAL_DETAILS_INCOMPLETE_INCORRECT = 1;
        public const int CHANGE_IN_UNDERLYING_ORDER_DETAILS = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// CopyMsgIndicator Field
    /// </summary>/
    public sealed class CopyMsgIndicator : QuickFix.Fields.BooleanField
    {
        public CopyMsgIndicator()
            :base(Fields.CustomTags.CopyMsgIndicator) {}
        public CopyMsgIndicator(Boolean val)
            :base(Fields.CustomTags.CopyMsgIndicator, val) {}

    }


    /// <summary>
    /// AllocAccountType Field
    /// </summary>/
    public sealed class AllocAccountType : QuickFix.Fields.IntField
    {
        public AllocAccountType()
            :base(Fields.CustomTags.AllocAccountType) {}
        public AllocAccountType(int val)
            :base(Fields.CustomTags.AllocAccountType, val) {}


        // Field Enumerations
        public const int ACCOUNT_IS_CARRIED_PN_CUSTOMER_SIDE_OF_BOOKS = 1;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS = 2;
        public const int HOUSE_TRADER = 3;
        public const int FLOOR_TRADER = 4;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS_AND_IS_CROSS_MARGINED = 6;
        public const int ACCOUNT_IS_HOUSE_TRADER_AND_IS_CROSS_MARGINED = 7;
        public const int JOINT_BACK_OFFICE_ACCOUNT = 8;
    }


    /// <summary>
    /// OrderAvgPx Field
    /// </summary>/
    public sealed class OrderAvgPx : QuickFix.Fields.DecimalField
    {
        public OrderAvgPx()
            :base(Fields.CustomTags.OrderAvgPx) {}
        public OrderAvgPx(Decimal val)
            :base(Fields.CustomTags.OrderAvgPx, val) {}

    }


    /// <summary>
    /// OrderBookingQty Field
    /// </summary>/
    public sealed class OrderBookingQty : QuickFix.Fields.DecimalField
    {
        public OrderBookingQty()
            :base(Fields.CustomTags.OrderBookingQty) {}
        public OrderBookingQty(Decimal val)
            :base(Fields.CustomTags.OrderBookingQty, val) {}

    }


    /// <summary>
    /// NoSettlPartySubIDs Field
    /// </summary>/
    public sealed class NoSettlPartySubIDs : QuickFix.Fields.IntField
    {
        public NoSettlPartySubIDs()
            :base(Fields.CustomTags.NoSettlPartySubIDs) {}
        public NoSettlPartySubIDs(int val)
            :base(Fields.CustomTags.NoSettlPartySubIDs, val) {}

    }


    /// <summary>
    /// NoPartySubIDs Field
    /// </summary>/
    public sealed class NoPartySubIDs : QuickFix.Fields.IntField
    {
        public NoPartySubIDs()
            :base(Fields.CustomTags.NoPartySubIDs) {}
        public NoPartySubIDs(int val)
            :base(Fields.CustomTags.NoPartySubIDs, val) {}

    }


    /// <summary>
    /// PartySubIDType Field
    /// </summary>/
    public sealed class PartySubIDType : QuickFix.Fields.IntField
    {
        public PartySubIDType()
            :base(Fields.CustomTags.PartySubIDType) {}
        public PartySubIDType(int val)
            :base(Fields.CustomTags.PartySubIDType, val) {}


        // Field Enumerations
        public const int FIRM = 1;
        public const int SECURITIES_ACCOUNT_NUMBER = 10;
        public const int REGISTRATION_NUMBER = 11;
        public const int REGISTERED_ADDRESS_12 = 12;
        public const int REGULATORY_STATUS = 13;
        public const int REGISTRATION_NAME = 14;
        public const int CASH_ACCOUNT_NUMBER = 15;
        public const int BIC = 16;
        public const int CSD_PARTICIPANT_MEMBER_CODE = 17;
        public const int REGISTERED_ADDRESS_18 = 18;
        public const int FUND_ACCOUNT_NAME = 19;
        public const int PERSON = 2;
        public const int TELEX_NUMBER = 20;
        public const int FAX_NUMBER = 21;
        public const int SECURITIES_ACCOUNT_NAME = 22;
        public const int CASH_ACCOUNT_NAME = 23;
        public const int DEPARTMENT = 24;
        public const int LOCATION_DESK = 25;
        public const int POSITION_ACCOUNT_TYPE = 26;
        public const int SYSTEM = 3;
        public const int APPLICATION = 4;
        public const int FULL_LEGAL_NAME_OF_FIRM = 5;
        public const int POSTAL_ADDRESS = 6;
        public const int PHONE_NUMBER = 7;
        public const int EMAIL_ADDRESS = 8;
        public const int CONTACT_NAME = 9;
        public const int SECURITY_LOCATE_ID = 27;
        public const int MARKET_MAKER = 28;
        public const int ELIGIBLE_COUNTERPARTY = 29;
        public const int PROFESSIONAL_CLIENT = 30;
        public const int LOCATION = 31;
        public const int EXECUTION_VENUE = 32;
        public const int CURRENCY_DELIVERY_IDENTIFIER = 33;
    }


    /// <summary>
    /// NoNestedPartySubIDs Field
    /// </summary>/
    public sealed class NoNestedPartySubIDs : QuickFix.Fields.IntField
    {
        public NoNestedPartySubIDs()
            :base(Fields.CustomTags.NoNestedPartySubIDs) {}
        public NoNestedPartySubIDs(int val)
            :base(Fields.CustomTags.NoNestedPartySubIDs, val) {}

    }


    /// <summary>
    /// NestedPartySubIDType Field
    /// </summary>/
    public sealed class NestedPartySubIDType : QuickFix.Fields.IntField
    {
        public NestedPartySubIDType()
            :base(Fields.CustomTags.NestedPartySubIDType) {}
        public NestedPartySubIDType(int val)
            :base(Fields.CustomTags.NestedPartySubIDType, val) {}

    }


    /// <summary>
    /// NoNested2PartySubIDs Field
    /// </summary>/
    public sealed class NoNested2PartySubIDs : QuickFix.Fields.IntField
    {
        public NoNested2PartySubIDs()
            :base(Fields.CustomTags.NoNested2PartySubIDs) {}
        public NoNested2PartySubIDs(int val)
            :base(Fields.CustomTags.NoNested2PartySubIDs, val) {}

    }


    /// <summary>
    /// Nested2PartySubIDType Field
    /// </summary>/
    public sealed class Nested2PartySubIDType : QuickFix.Fields.IntField
    {
        public Nested2PartySubIDType()
            :base(Fields.CustomTags.Nested2PartySubIDType) {}
        public Nested2PartySubIDType(int val)
            :base(Fields.CustomTags.Nested2PartySubIDType, val) {}

    }


    /// <summary>
    /// AllocIntermedReqType Field
    /// </summary>/
    public sealed class AllocIntermedReqType : QuickFix.Fields.IntField
    {
        public AllocIntermedReqType()
            :base(Fields.CustomTags.AllocIntermedReqType) {}
        public AllocIntermedReqType(int val)
            :base(Fields.CustomTags.AllocIntermedReqType, val) {}


        // Field Enumerations
        public const int PENDING_ACCEPT = 1;
        public const int PENDING_RELEASE = 2;
        public const int PENDING_REVERSAL = 3;
        public const int ACCEPT = 4;
        public const int BLOCK_LEVEL_REJECT = 5;
        public const int ACCOUNT_LEVEL_REJECT = 6;
    }


    /// <summary>
    /// PriceDelta Field
    /// </summary>/
    public sealed class PriceDelta : QuickFix.Fields.DecimalField
    {
        public PriceDelta()
            :base(Fields.CustomTags.PriceDelta) {}
        public PriceDelta(Decimal val)
            :base(Fields.CustomTags.PriceDelta, val) {}

    }


    /// <summary>
    /// ApplQueueMax Field
    /// </summary>/
    public sealed class ApplQueueMax : QuickFix.Fields.IntField
    {
        public ApplQueueMax()
            :base(Fields.CustomTags.ApplQueueMax) {}
        public ApplQueueMax(int val)
            :base(Fields.CustomTags.ApplQueueMax, val) {}

    }


    /// <summary>
    /// ApplQueueDepth Field
    /// </summary>/
    public sealed class ApplQueueDepth : QuickFix.Fields.IntField
    {
        public ApplQueueDepth()
            :base(Fields.CustomTags.ApplQueueDepth) {}
        public ApplQueueDepth(int val)
            :base(Fields.CustomTags.ApplQueueDepth, val) {}

    }


    /// <summary>
    /// ApplQueueResolution Field
    /// </summary>/
    public sealed class ApplQueueResolution : QuickFix.Fields.IntField
    {
        public ApplQueueResolution()
            :base(Fields.CustomTags.ApplQueueResolution) {}
        public ApplQueueResolution(int val)
            :base(Fields.CustomTags.ApplQueueResolution, val) {}


        // Field Enumerations
        public const int NO_ACTION_TAKEN = 0;
        public const int QUEUE_FLUSHED = 1;
        public const int OVERLAY_LAST = 2;
        public const int END_SESSION = 3;
    }


    /// <summary>
    /// ApplQueueAction Field
    /// </summary>/
    public sealed class ApplQueueAction : QuickFix.Fields.IntField
    {
        public ApplQueueAction()
            :base(Fields.CustomTags.ApplQueueAction) {}
        public ApplQueueAction(int val)
            :base(Fields.CustomTags.ApplQueueAction, val) {}


        // Field Enumerations
        public const int NO_ACTION_TAKEN = 0;
        public const int QUEUE_FLUSHED = 1;
        public const int OVERLAY_LAST = 2;
        public const int END_SESSION = 3;
    }


    /// <summary>
    /// NoAltMDSource Field
    /// </summary>/
    public sealed class NoAltMDSource : QuickFix.Fields.IntField
    {
        public NoAltMDSource()
            :base(Fields.CustomTags.NoAltMDSource) {}
        public NoAltMDSource(int val)
            :base(Fields.CustomTags.NoAltMDSource, val) {}

    }


    /// <summary>
    /// AltMDSourceID Field
    /// </summary>/
    public sealed class AltMDSourceID : QuickFix.Fields.StringField
    {
        public AltMDSourceID()
            :base(Fields.CustomTags.AltMDSourceID) {}
        public AltMDSourceID(string val)
            :base(Fields.CustomTags.AltMDSourceID, val) {}

    }


    /// <summary>
    /// AvgPxIndicator Field
    /// </summary>/
    public sealed class AvgPxIndicator : QuickFix.Fields.IntField
    {
        public AvgPxIndicator()
            :base(Fields.CustomTags.AvgPxIndicator) {}
        public AvgPxIndicator(int val)
            :base(Fields.CustomTags.AvgPxIndicator, val) {}


        // Field Enumerations
        public const int NO_AVERAGE_PRICING = 0;
        public const int TRADE_IS_PART_OF_AN_AVERAGE_PRICE_GROUP_IDENTIFIED_BY_THE_TRADELINKID = 1;
        public const int LAST_TRADE_IS_THE_AVERAGE_PRICE_GROUP_IDENTIFIED_BY_THE_TRADELINKID = 2;
    }


    /// <summary>
    /// OrderInputDevice Field
    /// </summary>/
    public sealed class OrderInputDevice : QuickFix.Fields.StringField
    {
        public OrderInputDevice()
            :base(Fields.CustomTags.OrderInputDevice) {}
        public OrderInputDevice(string val)
            :base(Fields.CustomTags.OrderInputDevice, val) {}

    }


    /// <summary>
    /// UnderlyingTradingSessionID Field
    /// </summary>/
    public sealed class UnderlyingTradingSessionID : QuickFix.Fields.StringField
    {
        public UnderlyingTradingSessionID()
            :base(Fields.CustomTags.UnderlyingTradingSessionID) {}
        public UnderlyingTradingSessionID(string val)
            :base(Fields.CustomTags.UnderlyingTradingSessionID, val) {}

    }


    /// <summary>
    /// UnderlyingTradingSessionSubID Field
    /// </summary>/
    public sealed class UnderlyingTradingSessionSubID : QuickFix.Fields.StringField
    {
        public UnderlyingTradingSessionSubID()
            :base(Fields.CustomTags.UnderlyingTradingSessionSubID) {}
        public UnderlyingTradingSessionSubID(string val)
            :base(Fields.CustomTags.UnderlyingTradingSessionSubID, val) {}

    }


    /// <summary>
    /// TradeLegRefID Field
    /// </summary>/
    public sealed class TradeLegRefID : QuickFix.Fields.StringField
    {
        public TradeLegRefID()
            :base(Fields.CustomTags.TradeLegRefID) {}
        public TradeLegRefID(string val)
            :base(Fields.CustomTags.TradeLegRefID, val) {}

    }


    /// <summary>
    /// ExchangeRule Field
    /// </summary>/
    public sealed class ExchangeRule : QuickFix.Fields.StringField
    {
        public ExchangeRule()
            :base(Fields.CustomTags.ExchangeRule) {}
        public ExchangeRule(string val)
            :base(Fields.CustomTags.ExchangeRule, val) {}

    }


    /// <summary>
    /// TradeAllocIndicator Field
    /// </summary>/
    public sealed class TradeAllocIndicator : QuickFix.Fields.IntField
    {
        public TradeAllocIndicator()
            :base(Fields.CustomTags.TradeAllocIndicator) {}
        public TradeAllocIndicator(int val)
            :base(Fields.CustomTags.TradeAllocIndicator, val) {}


        // Field Enumerations
        public const int ALLOCATION_NOT_REQUIRED = 0;
        public const int ALLOCATION_REQUIRED = 1;
        public const int USE_ALLOCATION_PROVIDED_WITH_THE_TRADE = 2;
        public const int ALLOCATION_GIVE_UP_EXECUTOR = 3;
        public const int ALLOCATION_FROM_EXECUTOR = 4;
        public const int ALLOCATION_TO_CLAIM_ACCOUNT = 5;
    }


    /// <summary>
    /// ExpirationCycle Field
    /// </summary>/
    public sealed class ExpirationCycle : QuickFix.Fields.IntField
    {
        public ExpirationCycle()
            :base(Fields.CustomTags.ExpirationCycle) {}
        public ExpirationCycle(int val)
            :base(Fields.CustomTags.ExpirationCycle, val) {}


        // Field Enumerations
        public const int EXPIRE_ON_TRADING_SESSION_CLOSE = 0;
        public const int EXPIRE_ON_TRADING_SESSION_OPEN = 1;
        public const int TRADING_ELIGIBILITY_EXPIRATION_SPECIFIED_IN_THE_DATE_AND_TIME_FIELDS_EVENTDATE = 2;
    }


    /// <summary>
    /// TrdSubType Field
    /// </summary>/
    public sealed class TrdSubType : QuickFix.Fields.IntField
    {
        public TrdSubType()
            :base(Fields.CustomTags.TrdSubType) {}
        public TrdSubType(int val)
            :base(Fields.CustomTags.TrdSubType, val) {}


        // Field Enumerations
        public const int CMTA = 0;
        public const int INTERNAL_TRANSFER_OR_ADJUSTMENT = 1;
        public const int EXTERNAL_TRANSFER_OR_TRANSFER_OF_ACCOUNT = 2;
        public const int REJECT_FOR_SUBMITTING_SIDE = 3;
        public const int ADVISORY_FOR_CONTRA_SIDE = 4;
        public const int OFFSET_DUE_TO_AN_ALLOCATION = 5;
        public const int ONSET_DUE_TO_AN_ALLOCATION = 6;
        public const int DIFFERENTIAL_SPREAD = 7;
        public const int IMPLIED_SPREAD_LEG_EXECUTED_AGAINST_AN_OUTRIGHT = 8;
        public const int TRANSACTION_FROM_EXERCISE = 9;
        public const int TRANSACTION_FROM_ASSIGNMENT = 10;
        public const int ACATS = 11;
        public const int AI = 14;
        public const int B = 15;
        public const int K = 16;
        public const int LC = 17;
        public const int M = 18;
        public const int N = 19;
        public const int NM = 20;
        public const int NR = 21;
        public const int P = 22;
        public const int PA = 23;
        public const int PC = 24;
        public const int PN = 25;
        public const int R = 26;
        public const int RO = 27;
        public const int RT = 28;
        public const int SW = 29;
        public const int T = 30;
        public const int WN = 31;
        public const int WT = 32;
        public const int OFF_HOURS_TRADE = 33;
        public const int ON_HOURS_TRADE = 34;
        public const int OTC_QUOTE = 35;
        public const int CONVERTED_SWAP = 36;
        public const int CROSSED_TRADE = 37;
        public const int INTERIM_PROTECTED_TRADE = 38;
        public const int LARGE_IN_SCALE = 39;
        public const int ONSET_DUT_TO_AN_ALLOCATION = 6;
    }


    /// <summary>
    /// TransferReason Field
    /// </summary>/
    public sealed class TransferReason : QuickFix.Fields.StringField
    {
        public TransferReason()
            :base(Fields.CustomTags.TransferReason) {}
        public TransferReason(string val)
            :base(Fields.CustomTags.TransferReason, val) {}

    }


    /// <summary>
    /// AsgnReqID Field
    /// </summary>/
    public sealed class AsgnReqID : QuickFix.Fields.StringField
    {
        public AsgnReqID()
            :base(Fields.CustomTags.AsgnReqID) {}
        public AsgnReqID(string val)
            :base(Fields.CustomTags.AsgnReqID, val) {}

    }


    /// <summary>
    /// TotNumAssignmentReports Field
    /// </summary>/
    public sealed class TotNumAssignmentReports : QuickFix.Fields.IntField
    {
        public TotNumAssignmentReports()
            :base(Fields.CustomTags.TotNumAssignmentReports) {}
        public TotNumAssignmentReports(int val)
            :base(Fields.CustomTags.TotNumAssignmentReports, val) {}

    }


    /// <summary>
    /// AsgnRptID Field
    /// </summary>/
    public sealed class AsgnRptID : QuickFix.Fields.StringField
    {
        public AsgnRptID()
            :base(Fields.CustomTags.AsgnRptID) {}
        public AsgnRptID(string val)
            :base(Fields.CustomTags.AsgnRptID, val) {}

    }


    /// <summary>
    /// ThresholdAmount Field
    /// </summary>/
    public sealed class ThresholdAmount : QuickFix.Fields.DecimalField
    {
        public ThresholdAmount()
            :base(Fields.CustomTags.ThresholdAmount) {}
        public ThresholdAmount(Decimal val)
            :base(Fields.CustomTags.ThresholdAmount, val) {}

    }


    /// <summary>
    /// PegMoveType Field
    /// </summary>/
    public sealed class PegMoveType : QuickFix.Fields.IntField
    {
        public PegMoveType()
            :base(Fields.CustomTags.PegMoveType) {}
        public PegMoveType(int val)
            :base(Fields.CustomTags.PegMoveType, val) {}


        // Field Enumerations
        public const int FLOATING = 0;
        public const int FIXED = 1;
    }


    /// <summary>
    /// PegOffsetType Field
    /// </summary>/
    public sealed class PegOffsetType : QuickFix.Fields.IntField
    {
        public PegOffsetType()
            :base(Fields.CustomTags.PegOffsetType) {}
        public PegOffsetType(int val)
            :base(Fields.CustomTags.PegOffsetType, val) {}


        // Field Enumerations
        public const int PRICE = 0;
        public const int BASIS_POINTS = 1;
        public const int TICKS = 2;
        public const int PRICE_TIER = 3;
    }


    /// <summary>
    /// PegLimitType Field
    /// </summary>/
    public sealed class PegLimitType : QuickFix.Fields.IntField
    {
        public PegLimitType()
            :base(Fields.CustomTags.PegLimitType) {}
        public PegLimitType(int val)
            :base(Fields.CustomTags.PegLimitType, val) {}


        // Field Enumerations
        public const int OR_BETTER = 0;
        public const int STRICT = 1;
        public const int OR_WORSE = 2;
    }


    /// <summary>
    /// PegRoundDirection Field
    /// </summary>/
    public sealed class PegRoundDirection : QuickFix.Fields.IntField
    {
        public PegRoundDirection()
            :base(Fields.CustomTags.PegRoundDirection) {}
        public PegRoundDirection(int val)
            :base(Fields.CustomTags.PegRoundDirection, val) {}


        // Field Enumerations
        public const int MORE_AGGRESSIVE = 1;
        public const int MORE_PASSIVE = 2;
    }


    /// <summary>
    /// PeggedPrice Field
    /// </summary>/
    public sealed class PeggedPrice : QuickFix.Fields.DecimalField
    {
        public PeggedPrice()
            :base(Fields.CustomTags.PeggedPrice) {}
        public PeggedPrice(Decimal val)
            :base(Fields.CustomTags.PeggedPrice, val) {}

    }


    /// <summary>
    /// PegScope Field
    /// </summary>/
    public sealed class PegScope : QuickFix.Fields.IntField
    {
        public PegScope()
            :base(Fields.CustomTags.PegScope) {}
        public PegScope(int val)
            :base(Fields.CustomTags.PegScope, val) {}


        // Field Enumerations
        public const int LOCAL = 1;
        public const int NATIONAL = 2;
        public const int GLOBAL = 3;
        public const int NATIONAL_EXCLUDING_LOCAL = 4;
        public const int NATIONAL_XXCLUDING_LOCAL = 4;
    }


    /// <summary>
    /// DiscretionMoveType Field
    /// </summary>/
    public sealed class DiscretionMoveType : QuickFix.Fields.IntField
    {
        public DiscretionMoveType()
            :base(Fields.CustomTags.DiscretionMoveType) {}
        public DiscretionMoveType(int val)
            :base(Fields.CustomTags.DiscretionMoveType, val) {}


        // Field Enumerations
        public const int FLOATING = 0;
        public const int FIXED = 1;
    }


    /// <summary>
    /// DiscretionOffsetType Field
    /// </summary>/
    public sealed class DiscretionOffsetType : QuickFix.Fields.IntField
    {
        public DiscretionOffsetType()
            :base(Fields.CustomTags.DiscretionOffsetType) {}
        public DiscretionOffsetType(int val)
            :base(Fields.CustomTags.DiscretionOffsetType, val) {}


        // Field Enumerations
        public const int PRICE = 0;
        public const int BASIS_POINTS = 1;
        public const int TICKS = 2;
        public const int PRICE_TIER = 3;
    }


    /// <summary>
    /// DiscretionLimitType Field
    /// </summary>/
    public sealed class DiscretionLimitType : QuickFix.Fields.IntField
    {
        public DiscretionLimitType()
            :base(Fields.CustomTags.DiscretionLimitType) {}
        public DiscretionLimitType(int val)
            :base(Fields.CustomTags.DiscretionLimitType, val) {}


        // Field Enumerations
        public const int OR_BETTER = 0;
        public const int STRICT = 1;
        public const int OR_WORSE = 2;
    }


    /// <summary>
    /// DiscretionRoundDirection Field
    /// </summary>/
    public sealed class DiscretionRoundDirection : QuickFix.Fields.IntField
    {
        public DiscretionRoundDirection()
            :base(Fields.CustomTags.DiscretionRoundDirection) {}
        public DiscretionRoundDirection(int val)
            :base(Fields.CustomTags.DiscretionRoundDirection, val) {}


        // Field Enumerations
        public const int MORE_AGGRESSIVE = 1;
        public const int MORE_PASSIVE = 2;
    }


    /// <summary>
    /// DiscretionPrice Field
    /// </summary>/
    public sealed class DiscretionPrice : QuickFix.Fields.DecimalField
    {
        public DiscretionPrice()
            :base(Fields.CustomTags.DiscretionPrice) {}
        public DiscretionPrice(Decimal val)
            :base(Fields.CustomTags.DiscretionPrice, val) {}

    }


    /// <summary>
    /// DiscretionScope Field
    /// </summary>/
    public sealed class DiscretionScope : QuickFix.Fields.IntField
    {
        public DiscretionScope()
            :base(Fields.CustomTags.DiscretionScope) {}
        public DiscretionScope(int val)
            :base(Fields.CustomTags.DiscretionScope, val) {}


        // Field Enumerations
        public const int LOCAL = 1;
        public const int NATIONAL = 2;
        public const int GLOBAL = 3;
        public const int NATIONAL_EXCLUDING_LOCAL = 4;
    }


    /// <summary>
    /// TargetStrategy Field
    /// </summary>/
    public sealed class TargetStrategy : QuickFix.Fields.IntField
    {
        public TargetStrategy()
            :base(Fields.CustomTags.TargetStrategy) {}
        public TargetStrategy(int val)
            :base(Fields.CustomTags.TargetStrategy, val) {}


        // Field Enumerations
        public const int VWAP = 1;
        public const int PARTICIPATE = 2;
        public const int MININIZE_MARKET_IMPACT = 3;
    }


    /// <summary>
    /// TargetStrategyParameters Field
    /// </summary>/
    public sealed class TargetStrategyParameters : QuickFix.Fields.StringField
    {
        public TargetStrategyParameters()
            :base(Fields.CustomTags.TargetStrategyParameters) {}
        public TargetStrategyParameters(string val)
            :base(Fields.CustomTags.TargetStrategyParameters, val) {}

    }


    /// <summary>
    /// ParticipationRate Field
    /// </summary>/
    public sealed class ParticipationRate : QuickFix.Fields.DecimalField
    {
        public ParticipationRate()
            :base(Fields.CustomTags.ParticipationRate) {}
        public ParticipationRate(Decimal val)
            :base(Fields.CustomTags.ParticipationRate, val) {}

    }


    /// <summary>
    /// TargetStrategyPerformance Field
    /// </summary>/
    public sealed class TargetStrategyPerformance : QuickFix.Fields.DecimalField
    {
        public TargetStrategyPerformance()
            :base(Fields.CustomTags.TargetStrategyPerformance) {}
        public TargetStrategyPerformance(Decimal val)
            :base(Fields.CustomTags.TargetStrategyPerformance, val) {}

    }


    /// <summary>
    /// LastLiquidityInd Field
    /// </summary>/
    public sealed class LastLiquidityInd : QuickFix.Fields.IntField
    {
        public LastLiquidityInd()
            :base(Fields.CustomTags.LastLiquidityInd) {}
        public LastLiquidityInd(int val)
            :base(Fields.CustomTags.LastLiquidityInd, val) {}


        // Field Enumerations
        public const int ADDED_LIQUIDITY = 1;
        public const int REMOVED_LIQUIDITY = 2;
        public const int LIQUIDITY_ROUTED_OUT = 3;
        public const int AUCTION = 4;
    }


    /// <summary>
    /// PublishTrdIndicator Field
    /// </summary>/
    public sealed class PublishTrdIndicator : QuickFix.Fields.BooleanField
    {
        public PublishTrdIndicator()
            :base(Fields.CustomTags.PublishTrdIndicator) {}
        public PublishTrdIndicator(Boolean val)
            :base(Fields.CustomTags.PublishTrdIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// ShortSaleReason Field
    /// </summary>/
    public sealed class ShortSaleReason : QuickFix.Fields.IntField
    {
        public ShortSaleReason()
            :base(Fields.CustomTags.ShortSaleReason) {}
        public ShortSaleReason(int val)
            :base(Fields.CustomTags.ShortSaleReason, val) {}


        // Field Enumerations
        public const int DEALER_SOLD_SHORT = 0;
        public const int DEALER_SOLD_SHORT_EXEMPT = 1;
        public const int SELLING_CUSTOMER_SOLD_SHORT = 2;
        public const int SELLING_CUSTOMER_SOLD_SHORT_EXEMPT = 3;
        public const int QUALIFIED_SERVICE_REPRESENTATIVE = 4;
        public const int QSR_OR_AGU_CONTRA_SIDE_SOLD_SHORT_EXEMPT = 5;
    }


    /// <summary>
    /// QtyType Field
    /// </summary>/
    public sealed class QtyType : QuickFix.Fields.IntField
    {
        public QtyType()
            :base(Fields.CustomTags.QtyType) {}
        public QtyType(int val)
            :base(Fields.CustomTags.QtyType, val) {}


        // Field Enumerations
        public const int UNITS = 0;
        public const int CONTRACTS = 1;
        public const int UNITS_OF_MEASURE_PER_TIME_UNIT = 2;
    }


    /// <summary>
    /// SecondaryTrdType Field
    /// </summary>/
    public sealed class SecondaryTrdType : QuickFix.Fields.IntField
    {
        public SecondaryTrdType()
            :base(Fields.CustomTags.SecondaryTrdType) {}
        public SecondaryTrdType(int val)
            :base(Fields.CustomTags.SecondaryTrdType, val) {}

    }


    /// <summary>
    /// AllocNoOrdersType Field
    /// </summary>/
    public sealed class AllocNoOrdersType : QuickFix.Fields.IntField
    {
        public AllocNoOrdersType()
            :base(Fields.CustomTags.AllocNoOrdersType) {}
        public AllocNoOrdersType(int val)
            :base(Fields.CustomTags.AllocNoOrdersType, val) {}


        // Field Enumerations
        public const int NOT_SPECIFIED = 0;
        public const int EXPLICIT_LIST_PROVIDED = 1;
    }


    /// <summary>
    /// SharedCommission Field
    /// </summary>/
    public sealed class SharedCommission : QuickFix.Fields.DecimalField
    {
        public SharedCommission()
            :base(Fields.CustomTags.SharedCommission) {}
        public SharedCommission(Decimal val)
            :base(Fields.CustomTags.SharedCommission, val) {}

    }


    /// <summary>
    /// ConfirmReqID Field
    /// </summary>/
    public sealed class ConfirmReqID : QuickFix.Fields.StringField
    {
        public ConfirmReqID()
            :base(Fields.CustomTags.ConfirmReqID) {}
        public ConfirmReqID(string val)
            :base(Fields.CustomTags.ConfirmReqID, val) {}

    }


    /// <summary>
    /// AvgParPx Field
    /// </summary>/
    public sealed class AvgParPx : QuickFix.Fields.DecimalField
    {
        public AvgParPx()
            :base(Fields.CustomTags.AvgParPx) {}
        public AvgParPx(Decimal val)
            :base(Fields.CustomTags.AvgParPx, val) {}

    }


    /// <summary>
    /// ReportedPx Field
    /// </summary>/
    public sealed class ReportedPx : QuickFix.Fields.DecimalField
    {
        public ReportedPx()
            :base(Fields.CustomTags.ReportedPx) {}
        public ReportedPx(Decimal val)
            :base(Fields.CustomTags.ReportedPx, val) {}

    }


    /// <summary>
    /// NoCapacities Field
    /// </summary>/
    public sealed class NoCapacities : QuickFix.Fields.IntField
    {
        public NoCapacities()
            :base(Fields.CustomTags.NoCapacities) {}
        public NoCapacities(int val)
            :base(Fields.CustomTags.NoCapacities, val) {}

    }


    /// <summary>
    /// OrderCapacityQty Field
    /// </summary>/
    public sealed class OrderCapacityQty : QuickFix.Fields.DecimalField
    {
        public OrderCapacityQty()
            :base(Fields.CustomTags.OrderCapacityQty) {}
        public OrderCapacityQty(Decimal val)
            :base(Fields.CustomTags.OrderCapacityQty, val) {}

    }


    /// <summary>
    /// EventPx Field
    /// </summary>/
    public sealed class EventPx : QuickFix.Fields.DecimalField
    {
        public EventPx()
            :base(Fields.CustomTags.EventPx) {}
        public EventPx(Decimal val)
            :base(Fields.CustomTags.EventPx, val) {}

    }


    /// <summary>
    /// EventText Field
    /// </summary>/
    public sealed class EventText : QuickFix.Fields.StringField
    {
        public EventText()
            :base(Fields.CustomTags.EventText) {}
        public EventText(string val)
            :base(Fields.CustomTags.EventText, val) {}

    }


    /// <summary>
    /// PctAtRisk Field
    /// </summary>/
    public sealed class PctAtRisk : QuickFix.Fields.DecimalField
    {
        public PctAtRisk()
            :base(Fields.CustomTags.PctAtRisk) {}
        public PctAtRisk(Decimal val)
            :base(Fields.CustomTags.PctAtRisk, val) {}

    }


    /// <summary>
    /// NoInstrAttrib Field
    /// </summary>/
    public sealed class NoInstrAttrib : QuickFix.Fields.IntField
    {
        public NoInstrAttrib()
            :base(Fields.CustomTags.NoInstrAttrib) {}
        public NoInstrAttrib(int val)
            :base(Fields.CustomTags.NoInstrAttrib, val) {}

    }


    /// <summary>
    /// InstrAttribType Field
    /// </summary>/
    public sealed class InstrAttribType : QuickFix.Fields.IntField
    {
        public InstrAttribType()
            :base(Fields.CustomTags.InstrAttribType) {}
        public InstrAttribType(int val)
            :base(Fields.CustomTags.InstrAttribType, val) {}


        // Field Enumerations
        public const int FLAT = 1;
        public const int ORIGINAL_ISSUE_DISCOUNT = 10;
        public const int CALLABLE_PUTTABLE = 11;
        public const int ESCROWED_TO_MATURITY = 12;
        public const int ESCROWED_TO_REDEMPTION_DATE = 13;
        public const int PRE_REFUNDED = 14;
        public const int IN_DEFAULT = 15;
        public const int UNRATED = 16;
        public const int TAXABLE = 17;
        public const int INDEXED = 18;
        public const int SUBJECT_TO_ALTERNATIVE_MINIMUM_TAX = 19;
        public const int ZERO_COUPON = 2;
        public const int ORIGINAL_ISSUE_DISCOUNT_PRICE_SUPPLY_PRICE_IN_THE_INSTRATTRIBVALUE = 20;
        public const int CALLABLE_BELOW_MATURITY_VALUE = 21;
        public const int CALLABLE_WITHOUT_NOTICE_BY_MAIL_TO_HOLDER_UNLESS_REGISTERED = 22;
        public const int INTEREST_BEARING = 3;
        public const int NO_PERIODIC_PAYMENTS = 4;
        public const int VARIABLE_RATE = 5;
        public const int LESS_FEE_FOR_PUT = 6;
        public const int STEPPED_COUPON = 7;
        public const int COUPON_PERIOD = 8;
        public const int WHEN_AND_IF_ISSUED = 9;
        public const int TEXT_SUPPLY_THE_TEXT_OF_THE_ATTRIBUTE_OR_DISCLAIMER_IN_THE_INSTRATTRIBVALUE = 99;
        public const int PRICE_TICK_RULES_FOR_SECURITY = 23;
        public const int TRADE_TYPE_ELIGIBILITY_DETAILS_FOR_SECURITY = 24;
        public const int INSTRUMENT_DENOMINATOR = 25;
        public const int INSTRUMENT_NUMERATOR = 26;
        public const int INSTRUMENT_PRICE_PRECISION = 27;
        public const int INSTRUMENT_STRIKE_PRICE = 28;
        public const int TRADEABLE_INDICATOR = 29;
    }


    /// <summary>
    /// InstrAttribValue Field
    /// </summary>/
    public sealed class InstrAttribValue : QuickFix.Fields.StringField
    {
        public InstrAttribValue()
            :base(Fields.CustomTags.InstrAttribValue) {}
        public InstrAttribValue(string val)
            :base(Fields.CustomTags.InstrAttribValue, val) {}

    }


    /// <summary>
    /// DatedDate Field
    /// </summary>/
    public sealed class DatedDate : QuickFix.Fields.StringField
    {
        public DatedDate()
            :base(Fields.CustomTags.DatedDate) {}
        public DatedDate(string val)
            :base(Fields.CustomTags.DatedDate, val) {}

    }


    /// <summary>
    /// InterestAccrualDate Field
    /// </summary>/
    public sealed class InterestAccrualDate : QuickFix.Fields.StringField
    {
        public InterestAccrualDate()
            :base(Fields.CustomTags.InterestAccrualDate) {}
        public InterestAccrualDate(string val)
            :base(Fields.CustomTags.InterestAccrualDate, val) {}

    }


    /// <summary>
    /// CPProgram Field
    /// </summary>/
    public sealed class CPProgram : QuickFix.Fields.IntField
    {
        public CPProgram()
            :base(Fields.CustomTags.CPProgram) {}
        public CPProgram(int val)
            :base(Fields.CustomTags.CPProgram, val) {}


        // Field Enumerations
        public const int VAL_3 = 1;
        public const int VAL_4 = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// CPRegType Field
    /// </summary>/
    public sealed class CPRegType : QuickFix.Fields.StringField
    {
        public CPRegType()
            :base(Fields.CustomTags.CPRegType) {}
        public CPRegType(string val)
            :base(Fields.CustomTags.CPRegType, val) {}

    }


    /// <summary>
    /// UnderlyingCPProgram Field
    /// </summary>/
    public sealed class UnderlyingCPProgram : QuickFix.Fields.StringField
    {
        public UnderlyingCPProgram()
            :base(Fields.CustomTags.UnderlyingCPProgram) {}
        public UnderlyingCPProgram(string val)
            :base(Fields.CustomTags.UnderlyingCPProgram, val) {}

    }


    /// <summary>
    /// UnderlyingCPRegType Field
    /// </summary>/
    public sealed class UnderlyingCPRegType : QuickFix.Fields.StringField
    {
        public UnderlyingCPRegType()
            :base(Fields.CustomTags.UnderlyingCPRegType) {}
        public UnderlyingCPRegType(string val)
            :base(Fields.CustomTags.UnderlyingCPRegType, val) {}

    }


    /// <summary>
    /// UnderlyingQty Field
    /// </summary>/
    public sealed class UnderlyingQty : QuickFix.Fields.DecimalField
    {
        public UnderlyingQty()
            :base(Fields.CustomTags.UnderlyingQty) {}
        public UnderlyingQty(Decimal val)
            :base(Fields.CustomTags.UnderlyingQty, val) {}

    }


    /// <summary>
    /// SecondaryTradeReportRefID Field
    /// </summary>/
    public sealed class SecondaryTradeReportRefID : QuickFix.Fields.StringField
    {
        public SecondaryTradeReportRefID()
            :base(Fields.CustomTags.SecondaryTradeReportRefID) {}
        public SecondaryTradeReportRefID(string val)
            :base(Fields.CustomTags.SecondaryTradeReportRefID, val) {}

    }


    /// <summary>
    /// UnderlyingDirtyPrice Field
    /// </summary>/
    public sealed class UnderlyingDirtyPrice : QuickFix.Fields.DecimalField
    {
        public UnderlyingDirtyPrice()
            :base(Fields.CustomTags.UnderlyingDirtyPrice) {}
        public UnderlyingDirtyPrice(Decimal val)
            :base(Fields.CustomTags.UnderlyingDirtyPrice, val) {}

    }


    /// <summary>
    /// UnderlyingEndPrice Field
    /// </summary>/
    public sealed class UnderlyingEndPrice : QuickFix.Fields.DecimalField
    {
        public UnderlyingEndPrice()
            :base(Fields.CustomTags.UnderlyingEndPrice) {}
        public UnderlyingEndPrice(Decimal val)
            :base(Fields.CustomTags.UnderlyingEndPrice, val) {}

    }


    /// <summary>
    /// UnderlyingStartValue Field
    /// </summary>/
    public sealed class UnderlyingStartValue : QuickFix.Fields.DecimalField
    {
        public UnderlyingStartValue()
            :base(Fields.CustomTags.UnderlyingStartValue) {}
        public UnderlyingStartValue(Decimal val)
            :base(Fields.CustomTags.UnderlyingStartValue, val) {}

    }


    /// <summary>
    /// UnderlyingCurrentValue Field
    /// </summary>/
    public sealed class UnderlyingCurrentValue : QuickFix.Fields.DecimalField
    {
        public UnderlyingCurrentValue()
            :base(Fields.CustomTags.UnderlyingCurrentValue) {}
        public UnderlyingCurrentValue(Decimal val)
            :base(Fields.CustomTags.UnderlyingCurrentValue, val) {}

    }


    /// <summary>
    /// UnderlyingEndValue Field
    /// </summary>/
    public sealed class UnderlyingEndValue : QuickFix.Fields.DecimalField
    {
        public UnderlyingEndValue()
            :base(Fields.CustomTags.UnderlyingEndValue) {}
        public UnderlyingEndValue(Decimal val)
            :base(Fields.CustomTags.UnderlyingEndValue, val) {}

    }


    /// <summary>
    /// NoUnderlyingStips Field
    /// </summary>/
    public sealed class NoUnderlyingStips : QuickFix.Fields.IntField
    {
        public NoUnderlyingStips()
            :base(Fields.CustomTags.NoUnderlyingStips) {}
        public NoUnderlyingStips(int val)
            :base(Fields.CustomTags.NoUnderlyingStips, val) {}

    }


    /// <summary>
    /// UnderlyingStipType Field
    /// </summary>/
    public sealed class UnderlyingStipType : QuickFix.Fields.StringField
    {
        public UnderlyingStipType()
            :base(Fields.CustomTags.UnderlyingStipType) {}
        public UnderlyingStipType(string val)
            :base(Fields.CustomTags.UnderlyingStipType, val) {}

    }


    /// <summary>
    /// UnderlyingStipValue Field
    /// </summary>/
    public sealed class UnderlyingStipValue : QuickFix.Fields.StringField
    {
        public UnderlyingStipValue()
            :base(Fields.CustomTags.UnderlyingStipValue) {}
        public UnderlyingStipValue(string val)
            :base(Fields.CustomTags.UnderlyingStipValue, val) {}

    }


    /// <summary>
    /// MaturityNetMoney Field
    /// </summary>/
    public sealed class MaturityNetMoney : QuickFix.Fields.DecimalField
    {
        public MaturityNetMoney()
            :base(Fields.CustomTags.MaturityNetMoney) {}
        public MaturityNetMoney(Decimal val)
            :base(Fields.CustomTags.MaturityNetMoney, val) {}

    }


    /// <summary>
    /// MiscFeeBasis Field
    /// </summary>/
    public sealed class MiscFeeBasis : QuickFix.Fields.IntField
    {
        public MiscFeeBasis()
            :base(Fields.CustomTags.MiscFeeBasis) {}
        public MiscFeeBasis(int val)
            :base(Fields.CustomTags.MiscFeeBasis, val) {}


        // Field Enumerations
        public const int ABSOLUTE = 0;
        public const int PER_UNIT = 1;
        public const int PERCENTAGE = 2;
    }


    /// <summary>
    /// TotNoAllocs Field
    /// </summary>/
    public sealed class TotNoAllocs : QuickFix.Fields.IntField
    {
        public TotNoAllocs()
            :base(Fields.CustomTags.TotNoAllocs) {}
        public TotNoAllocs(int val)
            :base(Fields.CustomTags.TotNoAllocs, val) {}

    }


    /// <summary>
    /// CollReqID Field
    /// </summary>/
    public sealed class CollReqID : QuickFix.Fields.StringField
    {
        public CollReqID()
            :base(Fields.CustomTags.CollReqID) {}
        public CollReqID(string val)
            :base(Fields.CustomTags.CollReqID, val) {}

    }


    /// <summary>
    /// CollAsgnReason Field
    /// </summary>/
    public sealed class CollAsgnReason : QuickFix.Fields.IntField
    {
        public CollAsgnReason()
            :base(Fields.CustomTags.CollAsgnReason) {}
        public CollAsgnReason(int val)
            :base(Fields.CustomTags.CollAsgnReason, val) {}


        // Field Enumerations
        public const int INITIAL = 0;
        public const int SCHEDULED = 1;
        public const int TIME_WARNING = 2;
        public const int MARGIN_DEFICIENCY = 3;
        public const int MARGIN_EXCESS = 4;
        public const int FORWARD_COLLATERAL_DEMAND = 5;
        public const int EVENT_OF_DEFAULT = 6;
        public const int ADVERSE_TAX_EVENT = 7;
    }


    /// <summary>
    /// CollInquiryQualifier Field
    /// </summary>/
    public sealed class CollInquiryQualifier : QuickFix.Fields.IntField
    {
        public CollInquiryQualifier()
            :base(Fields.CustomTags.CollInquiryQualifier) {}
        public CollInquiryQualifier(int val)
            :base(Fields.CustomTags.CollInquiryQualifier, val) {}


        // Field Enumerations
        public const int TRADE_DATE = 0;
        public const int GC_INSTRUMENT = 1;
        public const int COLLATERAL_INSTRUMENT = 2;
        public const int SUBSTITUTION_ELIGIBLE = 3;
        public const int NOT_ASSIGNED = 4;
        public const int PARTIALLY_ASSIGNED = 5;
        public const int FULLY_ASSIGNED = 6;
        public const int OUTSTANDING_TRADES = 7;
    }


    /// <summary>
    /// NoTrades Field
    /// </summary>/
    public sealed class NoTrades : QuickFix.Fields.IntField
    {
        public NoTrades()
            :base(Fields.CustomTags.NoTrades) {}
        public NoTrades(int val)
            :base(Fields.CustomTags.NoTrades, val) {}

    }


    /// <summary>
    /// MarginRatio Field
    /// </summary>/
    public sealed class MarginRatio : QuickFix.Fields.DecimalField
    {
        public MarginRatio()
            :base(Fields.CustomTags.MarginRatio) {}
        public MarginRatio(Decimal val)
            :base(Fields.CustomTags.MarginRatio, val) {}

    }


    /// <summary>
    /// MarginExcess Field
    /// </summary>/
    public sealed class MarginExcess : QuickFix.Fields.DecimalField
    {
        public MarginExcess()
            :base(Fields.CustomTags.MarginExcess) {}
        public MarginExcess(Decimal val)
            :base(Fields.CustomTags.MarginExcess, val) {}

    }


    /// <summary>
    /// TotalNetValue Field
    /// </summary>/
    public sealed class TotalNetValue : QuickFix.Fields.DecimalField
    {
        public TotalNetValue()
            :base(Fields.CustomTags.TotalNetValue) {}
        public TotalNetValue(Decimal val)
            :base(Fields.CustomTags.TotalNetValue, val) {}

    }


    /// <summary>
    /// CashOutstanding Field
    /// </summary>/
    public sealed class CashOutstanding : QuickFix.Fields.DecimalField
    {
        public CashOutstanding()
            :base(Fields.CustomTags.CashOutstanding) {}
        public CashOutstanding(Decimal val)
            :base(Fields.CustomTags.CashOutstanding, val) {}

    }


    /// <summary>
    /// CollAsgnID Field
    /// </summary>/
    public sealed class CollAsgnID : QuickFix.Fields.StringField
    {
        public CollAsgnID()
            :base(Fields.CustomTags.CollAsgnID) {}
        public CollAsgnID(string val)
            :base(Fields.CustomTags.CollAsgnID, val) {}

    }


    /// <summary>
    /// CollAsgnTransType Field
    /// </summary>/
    public sealed class CollAsgnTransType : QuickFix.Fields.IntField
    {
        public CollAsgnTransType()
            :base(Fields.CustomTags.CollAsgnTransType) {}
        public CollAsgnTransType(int val)
            :base(Fields.CustomTags.CollAsgnTransType, val) {}


        // Field Enumerations
        public const int NEW = 0;
        public const int REPLACE = 1;
        public const int CANCEL = 2;
        public const int RELEASE = 3;
        public const int REVERSE = 4;
    }


    /// <summary>
    /// CollRespID Field
    /// </summary>/
    public sealed class CollRespID : QuickFix.Fields.StringField
    {
        public CollRespID()
            :base(Fields.CustomTags.CollRespID) {}
        public CollRespID(string val)
            :base(Fields.CustomTags.CollRespID, val) {}

    }


    /// <summary>
    /// CollAsgnRespType Field
    /// </summary>/
    public sealed class CollAsgnRespType : QuickFix.Fields.IntField
    {
        public CollAsgnRespType()
            :base(Fields.CustomTags.CollAsgnRespType) {}
        public CollAsgnRespType(int val)
            :base(Fields.CustomTags.CollAsgnRespType, val) {}


        // Field Enumerations
        public const int RECEIVED = 0;
        public const int ACCEPTED = 1;
        public const int DECLINED = 2;
        public const int REJECTED = 3;
    }


    /// <summary>
    /// CollAsgnRejectReason Field
    /// </summary>/
    public sealed class CollAsgnRejectReason : QuickFix.Fields.IntField
    {
        public CollAsgnRejectReason()
            :base(Fields.CustomTags.CollAsgnRejectReason) {}
        public CollAsgnRejectReason(int val)
            :base(Fields.CustomTags.CollAsgnRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_DEAL = 0;
        public const int UNKNOWN_OR_INVALID_INSTRUMENT = 1;
        public const int UNAUTHORIZED_TRANSACTION = 2;
        public const int INSUFFICIENT_COLLATERAL = 3;
        public const int INVALID_TYPE_OF_COLLATERAL = 4;
        public const int EXCESSIVE_SUBSTITUTION = 5;
        public const int OTHER = 99;
    }


    /// <summary>
    /// CollAsgnRefID Field
    /// </summary>/
    public sealed class CollAsgnRefID : QuickFix.Fields.StringField
    {
        public CollAsgnRefID()
            :base(Fields.CustomTags.CollAsgnRefID) {}
        public CollAsgnRefID(string val)
            :base(Fields.CustomTags.CollAsgnRefID, val) {}

    }


    /// <summary>
    /// CollRptID Field
    /// </summary>/
    public sealed class CollRptID : QuickFix.Fields.StringField
    {
        public CollRptID()
            :base(Fields.CustomTags.CollRptID) {}
        public CollRptID(string val)
            :base(Fields.CustomTags.CollRptID, val) {}

    }


    /// <summary>
    /// CollInquiryID Field
    /// </summary>/
    public sealed class CollInquiryID : QuickFix.Fields.StringField
    {
        public CollInquiryID()
            :base(Fields.CustomTags.CollInquiryID) {}
        public CollInquiryID(string val)
            :base(Fields.CustomTags.CollInquiryID, val) {}

    }


    /// <summary>
    /// CollStatus Field
    /// </summary>/
    public sealed class CollStatus : QuickFix.Fields.IntField
    {
        public CollStatus()
            :base(Fields.CustomTags.CollStatus) {}
        public CollStatus(int val)
            :base(Fields.CustomTags.CollStatus, val) {}


        // Field Enumerations
        public const int UNASSIGNED = 0;
        public const int PARTIALLY_ASSIGNED = 1;
        public const int ASSIGNMENT_PROPOSED = 2;
        public const int ASSIGNED = 3;
        public const int CHALLENGED = 4;
    }


    /// <summary>
    /// TotNumReports Field
    /// </summary>/
    public sealed class TotNumReports : QuickFix.Fields.IntField
    {
        public TotNumReports()
            :base(Fields.CustomTags.TotNumReports) {}
        public TotNumReports(int val)
            :base(Fields.CustomTags.TotNumReports, val) {}

    }


    /// <summary>
    /// AgreementDesc Field
    /// </summary>/
    public sealed class AgreementDesc : QuickFix.Fields.StringField
    {
        public AgreementDesc()
            :base(Fields.CustomTags.AgreementDesc) {}
        public AgreementDesc(string val)
            :base(Fields.CustomTags.AgreementDesc, val) {}

    }


    /// <summary>
    /// AgreementID Field
    /// </summary>/
    public sealed class AgreementID : QuickFix.Fields.StringField
    {
        public AgreementID()
            :base(Fields.CustomTags.AgreementID) {}
        public AgreementID(string val)
            :base(Fields.CustomTags.AgreementID, val) {}

    }


    /// <summary>
    /// AgreementDate Field
    /// </summary>/
    public sealed class AgreementDate : QuickFix.Fields.StringField
    {
        public AgreementDate()
            :base(Fields.CustomTags.AgreementDate) {}
        public AgreementDate(string val)
            :base(Fields.CustomTags.AgreementDate, val) {}

    }


    /// <summary>
    /// AgreementCurrency Field
    /// </summary>/
    public sealed class AgreementCurrency : QuickFix.Fields.StringField
    {
        public AgreementCurrency()
            :base(Fields.CustomTags.AgreementCurrency) {}
        public AgreementCurrency(string val)
            :base(Fields.CustomTags.AgreementCurrency, val) {}

    }


    /// <summary>
    /// DeliveryType Field
    /// </summary>/
    public sealed class DeliveryType : QuickFix.Fields.IntField
    {
        public DeliveryType()
            :base(Fields.CustomTags.DeliveryType) {}
        public DeliveryType(int val)
            :base(Fields.CustomTags.DeliveryType, val) {}


        // Field Enumerations
        public const int VERSUS_PAYMENT_DELIVER = 0;
        public const int FREE_DELIVER = 1;
        public const int TRI_PARTY = 2;
        public const int HOLD_IN_CUSTODY = 3;
    }


    /// <summary>
    /// EndAccruedInterestAmt Field
    /// </summary>/
    public sealed class EndAccruedInterestAmt : QuickFix.Fields.DecimalField
    {
        public EndAccruedInterestAmt()
            :base(Fields.CustomTags.EndAccruedInterestAmt) {}
        public EndAccruedInterestAmt(Decimal val)
            :base(Fields.CustomTags.EndAccruedInterestAmt, val) {}

    }


    /// <summary>
    /// StartCash Field
    /// </summary>/
    public sealed class StartCash : QuickFix.Fields.DecimalField
    {
        public StartCash()
            :base(Fields.CustomTags.StartCash) {}
        public StartCash(Decimal val)
            :base(Fields.CustomTags.StartCash, val) {}

    }


    /// <summary>
    /// EndCash Field
    /// </summary>/
    public sealed class EndCash : QuickFix.Fields.DecimalField
    {
        public EndCash()
            :base(Fields.CustomTags.EndCash) {}
        public EndCash(Decimal val)
            :base(Fields.CustomTags.EndCash, val) {}

    }


    /// <summary>
    /// UserRequestID Field
    /// </summary>/
    public sealed class UserRequestID : QuickFix.Fields.StringField
    {
        public UserRequestID()
            :base(Fields.CustomTags.UserRequestID) {}
        public UserRequestID(string val)
            :base(Fields.CustomTags.UserRequestID, val) {}

    }


    /// <summary>
    /// UserRequestType Field
    /// </summary>/
    public sealed class UserRequestType : QuickFix.Fields.IntField
    {
        public UserRequestType()
            :base(Fields.CustomTags.UserRequestType) {}
        public UserRequestType(int val)
            :base(Fields.CustomTags.UserRequestType, val) {}


        // Field Enumerations
        public const int LOG_ON_USER = 1;
        public const int LOG_OFF_USER = 2;
        public const int CHANGE_PASSWORD_FOR_USER = 3;
        public const int REQUEST_INDIVIDUAL_USER_STATUS = 4;
    }


    /// <summary>
    /// NewPassword Field
    /// </summary>/
    public sealed class NewPassword : QuickFix.Fields.StringField
    {
        public NewPassword()
            :base(Fields.CustomTags.NewPassword) {}
        public NewPassword(string val)
            :base(Fields.CustomTags.NewPassword, val) {}

    }


    /// <summary>
    /// UserStatus Field
    /// </summary>/
    public sealed class UserStatus : QuickFix.Fields.IntField
    {
        public UserStatus()
            :base(Fields.CustomTags.UserStatus) {}
        public UserStatus(int val)
            :base(Fields.CustomTags.UserStatus, val) {}


        // Field Enumerations
        public const int LOGGED_IN = 1;
        public const int NOT_LOGGED_IN = 2;
        public const int USER_NOT_RECOGNISED = 3;
        public const int PASSWORD_INCORRECT = 4;
        public const int PASSWORD_CHANGED = 5;
        public const int OTHER = 6;
        public const int FORCED_USER_LOGOUT_BY_EXCHANGE = 7;
        public const int SESSION_SHUTDOWN_WARNING = 8;
    }


    /// <summary>
    /// UserStatusText Field
    /// </summary>/
    public sealed class UserStatusText : QuickFix.Fields.StringField
    {
        public UserStatusText()
            :base(Fields.CustomTags.UserStatusText) {}
        public UserStatusText(string val)
            :base(Fields.CustomTags.UserStatusText, val) {}

    }


    /// <summary>
    /// StatusValue Field
    /// </summary>/
    public sealed class StatusValue : QuickFix.Fields.IntField
    {
        public StatusValue()
            :base(Fields.CustomTags.StatusValue) {}
        public StatusValue(int val)
            :base(Fields.CustomTags.StatusValue, val) {}


        // Field Enumerations
        public const int CONNECTED = 1;
        public const int NOT_CONNECTED_2 = 2;
        public const int NOT_CONNECTED_3 = 3;
        public const int IN_PROCESS = 4;
    }


    /// <summary>
    /// StatusText Field
    /// </summary>/
    public sealed class StatusText : QuickFix.Fields.StringField
    {
        public StatusText()
            :base(Fields.CustomTags.StatusText) {}
        public StatusText(string val)
            :base(Fields.CustomTags.StatusText, val) {}

    }


    /// <summary>
    /// RefCompID Field
    /// </summary>/
    public sealed class RefCompID : QuickFix.Fields.StringField
    {
        public RefCompID()
            :base(Fields.CustomTags.RefCompID) {}
        public RefCompID(string val)
            :base(Fields.CustomTags.RefCompID, val) {}

    }


    /// <summary>
    /// RefSubID Field
    /// </summary>/
    public sealed class RefSubID : QuickFix.Fields.StringField
    {
        public RefSubID()
            :base(Fields.CustomTags.RefSubID) {}
        public RefSubID(string val)
            :base(Fields.CustomTags.RefSubID, val) {}

    }


    /// <summary>
    /// NetworkResponseID Field
    /// </summary>/
    public sealed class NetworkResponseID : QuickFix.Fields.StringField
    {
        public NetworkResponseID()
            :base(Fields.CustomTags.NetworkResponseID) {}
        public NetworkResponseID(string val)
            :base(Fields.CustomTags.NetworkResponseID, val) {}

    }


    /// <summary>
    /// NetworkRequestID Field
    /// </summary>/
    public sealed class NetworkRequestID : QuickFix.Fields.StringField
    {
        public NetworkRequestID()
            :base(Fields.CustomTags.NetworkRequestID) {}
        public NetworkRequestID(string val)
            :base(Fields.CustomTags.NetworkRequestID, val) {}

    }


    /// <summary>
    /// LastNetworkResponseID Field
    /// </summary>/
    public sealed class LastNetworkResponseID : QuickFix.Fields.StringField
    {
        public LastNetworkResponseID()
            :base(Fields.CustomTags.LastNetworkResponseID) {}
        public LastNetworkResponseID(string val)
            :base(Fields.CustomTags.LastNetworkResponseID, val) {}

    }


    /// <summary>
    /// NetworkRequestType Field
    /// </summary>/
    public sealed class NetworkRequestType : QuickFix.Fields.IntField
    {
        public NetworkRequestType()
            :base(Fields.CustomTags.NetworkRequestType) {}
        public NetworkRequestType(int val)
            :base(Fields.CustomTags.NetworkRequestType, val) {}


        // Field Enumerations
        public const int SNAPSHOT = 1;
        public const int SUBSCRIBE = 2;
        public const int STOP_SUBSCRIBING = 4;
        public const int LEVEL_OF_DETAIL_THEN_NOCOMPIDS_BECOMES_REQUIRED = 8;
    }


    /// <summary>
    /// NoCompIDs Field
    /// </summary>/
    public sealed class NoCompIDs : QuickFix.Fields.IntField
    {
        public NoCompIDs()
            :base(Fields.CustomTags.NoCompIDs) {}
        public NoCompIDs(int val)
            :base(Fields.CustomTags.NoCompIDs, val) {}

    }


    /// <summary>
    /// NetworkStatusResponseType Field
    /// </summary>/
    public sealed class NetworkStatusResponseType : QuickFix.Fields.IntField
    {
        public NetworkStatusResponseType()
            :base(Fields.CustomTags.NetworkStatusResponseType) {}
        public NetworkStatusResponseType(int val)
            :base(Fields.CustomTags.NetworkStatusResponseType, val) {}


        // Field Enumerations
        public const int FULL = 1;
        public const int INCREMENTAL_UPDATE = 2;
    }


    /// <summary>
    /// NoCollInquiryQualifier Field
    /// </summary>/
    public sealed class NoCollInquiryQualifier : QuickFix.Fields.IntField
    {
        public NoCollInquiryQualifier()
            :base(Fields.CustomTags.NoCollInquiryQualifier) {}
        public NoCollInquiryQualifier(int val)
            :base(Fields.CustomTags.NoCollInquiryQualifier, val) {}

    }


    /// <summary>
    /// AffirmStatus Field
    /// </summary>/
    public sealed class AffirmStatus : QuickFix.Fields.IntField
    {
        public AffirmStatus()
            :base(Fields.CustomTags.AffirmStatus) {}
        public AffirmStatus(int val)
            :base(Fields.CustomTags.AffirmStatus, val) {}


        // Field Enumerations
        public const int RECEIVED = 1;
        public const int CONFIRM_REJECTED_IE_NOT_AFFIRMED = 2;
        public const int AFFIRMED = 3;
    }


    /// <summary>
    /// UnderlyingStrikeCurrency Field
    /// </summary>/
    public sealed class UnderlyingStrikeCurrency : QuickFix.Fields.StringField
    {
        public UnderlyingStrikeCurrency()
            :base(Fields.CustomTags.UnderlyingStrikeCurrency) {}
        public UnderlyingStrikeCurrency(string val)
            :base(Fields.CustomTags.UnderlyingStrikeCurrency, val) {}

    }


    /// <summary>
    /// LegStrikeCurrency Field
    /// </summary>/
    public sealed class LegStrikeCurrency : QuickFix.Fields.StringField
    {
        public LegStrikeCurrency()
            :base(Fields.CustomTags.LegStrikeCurrency) {}
        public LegStrikeCurrency(string val)
            :base(Fields.CustomTags.LegStrikeCurrency, val) {}

    }


    /// <summary>
    /// TimeBracket Field
    /// </summary>/
    public sealed class TimeBracket : QuickFix.Fields.StringField
    {
        public TimeBracket()
            :base(Fields.CustomTags.TimeBracket) {}
        public TimeBracket(string val)
            :base(Fields.CustomTags.TimeBracket, val) {}

    }


    /// <summary>
    /// CollAction Field
    /// </summary>/
    public sealed class CollAction : QuickFix.Fields.IntField
    {
        public CollAction()
            :base(Fields.CustomTags.CollAction) {}
        public CollAction(int val)
            :base(Fields.CustomTags.CollAction, val) {}


        // Field Enumerations
        public const int RETAIN = 0;
        public const int ADD = 1;
        public const int REMOVE = 2;
    }


    /// <summary>
    /// CollInquiryStatus Field
    /// </summary>/
    public sealed class CollInquiryStatus : QuickFix.Fields.IntField
    {
        public CollInquiryStatus()
            :base(Fields.CustomTags.CollInquiryStatus) {}
        public CollInquiryStatus(int val)
            :base(Fields.CustomTags.CollInquiryStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int ACCEPTED_WITH_WARNINGS = 1;
        public const int COMPLETED = 2;
        public const int COMPLETED_WITH_WARNINGS = 3;
        public const int REJECTED = 4;
    }


    /// <summary>
    /// CollInquiryResult Field
    /// </summary>/
    public sealed class CollInquiryResult : QuickFix.Fields.IntField
    {
        public CollInquiryResult()
            :base(Fields.CustomTags.CollInquiryResult) {}
        public CollInquiryResult(int val)
            :base(Fields.CustomTags.CollInquiryResult, val) {}


        // Field Enumerations
        public const int SUCCESSFUL = 0;
        public const int INVALID_OR_UNKNOWN_INSTRUMENT = 1;
        public const int INVALID_OR_UNKNOWN_COLLATERAL_TYPE = 2;
        public const int INVALID_PARTIES = 3;
        public const int INVALID_TRANSPORT_TYPE_REQUESTED = 4;
        public const int INVALID_DESTINATION_REQUESTED = 5;
        public const int NO_COLLATERAL_FOUND_FOR_THE_TRADE_SPECIFIED = 6;
        public const int NO_COLLATERAL_FOUND_FOR_THE_ORDER_SPECIFIED = 7;
        public const int COLLATERAL_INQUIRY_TYPE_NOT_SUPPORTED = 8;
        public const int UNAUTHORIZED_FOR_COLLATERAL_INQUIRY = 9;
        public const int OTHER = 99;
    }


    /// <summary>
    /// StrikeCurrency Field
    /// </summary>/
    public sealed class StrikeCurrency : QuickFix.Fields.StringField
    {
        public StrikeCurrency()
            :base(Fields.CustomTags.StrikeCurrency) {}
        public StrikeCurrency(string val)
            :base(Fields.CustomTags.StrikeCurrency, val) {}

    }


    /// <summary>
    /// NoNested3PartyIDs Field
    /// </summary>/
    public sealed class NoNested3PartyIDs : QuickFix.Fields.IntField
    {
        public NoNested3PartyIDs()
            :base(Fields.CustomTags.NoNested3PartyIDs) {}
        public NoNested3PartyIDs(int val)
            :base(Fields.CustomTags.NoNested3PartyIDs, val) {}

    }


    /// <summary>
    /// Nested3PartyID Field
    /// </summary>/
    public sealed class Nested3PartyID : QuickFix.Fields.StringField
    {
        public Nested3PartyID()
            :base(Fields.CustomTags.Nested3PartyID) {}
        public Nested3PartyID(string val)
            :base(Fields.CustomTags.Nested3PartyID, val) {}

    }


    /// <summary>
    /// Nested3PartyIDSource Field
    /// </summary>/
    public sealed class Nested3PartyIDSource : QuickFix.Fields.CharField
    {
        public Nested3PartyIDSource()
            :base(Fields.CustomTags.Nested3PartyIDSource) {}
        public Nested3PartyIDSource(char val)
            :base(Fields.CustomTags.Nested3PartyIDSource, val) {}

    }


    /// <summary>
    /// Nested3PartyRole Field
    /// </summary>/
    public sealed class Nested3PartyRole : QuickFix.Fields.IntField
    {
        public Nested3PartyRole()
            :base(Fields.CustomTags.Nested3PartyRole) {}
        public Nested3PartyRole(int val)
            :base(Fields.CustomTags.Nested3PartyRole, val) {}

    }


    /// <summary>
    /// NoNested3PartySubIDs Field
    /// </summary>/
    public sealed class NoNested3PartySubIDs : QuickFix.Fields.IntField
    {
        public NoNested3PartySubIDs()
            :base(Fields.CustomTags.NoNested3PartySubIDs) {}
        public NoNested3PartySubIDs(int val)
            :base(Fields.CustomTags.NoNested3PartySubIDs, val) {}

    }


    /// <summary>
    /// Nested3PartySubID Field
    /// </summary>/
    public sealed class Nested3PartySubID : QuickFix.Fields.StringField
    {
        public Nested3PartySubID()
            :base(Fields.CustomTags.Nested3PartySubID) {}
        public Nested3PartySubID(string val)
            :base(Fields.CustomTags.Nested3PartySubID, val) {}

    }


    /// <summary>
    /// Nested3PartySubIDType Field
    /// </summary>/
    public sealed class Nested3PartySubIDType : QuickFix.Fields.IntField
    {
        public Nested3PartySubIDType()
            :base(Fields.CustomTags.Nested3PartySubIDType) {}
        public Nested3PartySubIDType(int val)
            :base(Fields.CustomTags.Nested3PartySubIDType, val) {}

    }


    /// <summary>
    /// LegContractSettlMonth Field
    /// </summary>/
    public sealed class LegContractSettlMonth : QuickFix.Fields.StringField
    {
        public LegContractSettlMonth()
            :base(Fields.CustomTags.LegContractSettlMonth) {}
        public LegContractSettlMonth(string val)
            :base(Fields.CustomTags.LegContractSettlMonth, val) {}

    }


    /// <summary>
    /// LegInterestAccrualDate Field
    /// </summary>/
    public sealed class LegInterestAccrualDate : QuickFix.Fields.StringField
    {
        public LegInterestAccrualDate()
            :base(Fields.CustomTags.LegInterestAccrualDate) {}
        public LegInterestAccrualDate(string val)
            :base(Fields.CustomTags.LegInterestAccrualDate, val) {}

    }


    /// <summary>
    /// SideTimeInForce Field
    /// </summary>/
    public sealed class SideTimeInForce : QuickFix.Fields.DateTimeField
    {
        public SideTimeInForce()
            :base(Fields.CustomTags.SideTimeInForce) {}
        public SideTimeInForce(DateTime val)
            :base(Fields.CustomTags.SideTimeInForce, val) {}
        public SideTimeInForce(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.SideTimeInForce, val, showMilliseconds) {}
		public SideTimeInForce(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.SideTimeInForce, val, precision) {}

    }


    /// <summary>
    /// MDReportID Field
    /// </summary>/
    public sealed class MDReportID : QuickFix.Fields.IntField
    {
        public MDReportID()
            :base(Fields.CustomTags.MDReportID) {}
        public MDReportID(int val)
            :base(Fields.CustomTags.MDReportID, val) {}

    }


    /// <summary>
    /// SecurityReportID Field
    /// </summary>/
    public sealed class SecurityReportID : QuickFix.Fields.IntField
    {
        public SecurityReportID()
            :base(Fields.CustomTags.SecurityReportID) {}
        public SecurityReportID(int val)
            :base(Fields.CustomTags.SecurityReportID, val) {}

    }


    /// <summary>
    /// SecurityStat Field
    /// </summary>/
    public sealed class SecurityStat : QuickFix.Fields.StringField
    {
        public SecurityStat()
            :base(Fields.CustomTags.SecurityStat) {}
        public SecurityStat(string val)
            :base(Fields.CustomTags.SecurityStat, val) {}


        // Field Enumerations
        public const string ACTIVE = "1";
        public const string INACTIVE = "2";
    }


    /// <summary>
    /// SettleOnOpenFlag Field
    /// </summary>/
    public sealed class SettleOnOpenFlag : QuickFix.Fields.StringField
    {
        public SettleOnOpenFlag()
            :base(Fields.CustomTags.SettleOnOpenFlag) {}
        public SettleOnOpenFlag(string val)
            :base(Fields.CustomTags.SettleOnOpenFlag, val) {}

    }


    /// <summary>
    /// StrikeMultiplier Field
    /// </summary>/
    public sealed class StrikeMultiplier : QuickFix.Fields.DecimalField
    {
        public StrikeMultiplier()
            :base(Fields.CustomTags.StrikeMultiplier) {}
        public StrikeMultiplier(Decimal val)
            :base(Fields.CustomTags.StrikeMultiplier, val) {}

    }


    /// <summary>
    /// StrikeValue Field
    /// </summary>/
    public sealed class StrikeValue : QuickFix.Fields.DecimalField
    {
        public StrikeValue()
            :base(Fields.CustomTags.StrikeValue) {}
        public StrikeValue(Decimal val)
            :base(Fields.CustomTags.StrikeValue, val) {}

    }


    /// <summary>
    /// MinPriceIncrement Field
    /// </summary>/
    public sealed class MinPriceIncrement : QuickFix.Fields.DecimalField
    {
        public MinPriceIncrement()
            :base(Fields.CustomTags.MinPriceIncrement) {}
        public MinPriceIncrement(Decimal val)
            :base(Fields.CustomTags.MinPriceIncrement, val) {}

    }


    /// <summary>
    /// PositionLimit Field
    /// </summary>/
    public sealed class PositionLimit : QuickFix.Fields.IntField
    {
        public PositionLimit()
            :base(Fields.CustomTags.PositionLimit) {}
        public PositionLimit(int val)
            :base(Fields.CustomTags.PositionLimit, val) {}

    }


    /// <summary>
    /// NTPositionLimit Field
    /// </summary>/
    public sealed class NTPositionLimit : QuickFix.Fields.IntField
    {
        public NTPositionLimit()
            :base(Fields.CustomTags.NTPositionLimit) {}
        public NTPositionLimit(int val)
            :base(Fields.CustomTags.NTPositionLimit, val) {}

    }


    /// <summary>
    /// UnderlyingAllocationPercent Field
    /// </summary>/
    public sealed class UnderlyingAllocationPercent : QuickFix.Fields.DecimalField
    {
        public UnderlyingAllocationPercent()
            :base(Fields.CustomTags.UnderlyingAllocationPercent) {}
        public UnderlyingAllocationPercent(Decimal val)
            :base(Fields.CustomTags.UnderlyingAllocationPercent, val) {}

    }


    /// <summary>
    /// UnderlyingCashAmount Field
    /// </summary>/
    public sealed class UnderlyingCashAmount : QuickFix.Fields.DecimalField
    {
        public UnderlyingCashAmount()
            :base(Fields.CustomTags.UnderlyingCashAmount) {}
        public UnderlyingCashAmount(Decimal val)
            :base(Fields.CustomTags.UnderlyingCashAmount, val) {}

    }


    /// <summary>
    /// UnderlyingCashType Field
    /// </summary>/
    public sealed class UnderlyingCashType : QuickFix.Fields.StringField
    {
        public UnderlyingCashType()
            :base(Fields.CustomTags.UnderlyingCashType) {}
        public UnderlyingCashType(string val)
            :base(Fields.CustomTags.UnderlyingCashType, val) {}


        // Field Enumerations
        public const string FIXED = "FIXED";
        public const string DIFF = "DIFF";
    }


    /// <summary>
    /// UnderlyingSettlementType Field
    /// </summary>/
    public sealed class UnderlyingSettlementType : QuickFix.Fields.IntField
    {
        public UnderlyingSettlementType()
            :base(Fields.CustomTags.UnderlyingSettlementType) {}
        public UnderlyingSettlementType(int val)
            :base(Fields.CustomTags.UnderlyingSettlementType, val) {}


        // Field Enumerations
        public const int T_PLUS_1 = 2;
        public const int T_PLUS_3 = 4;
        public const int T_PLUS_4 = 5;
    }


    /// <summary>
    /// QuantityDate Field
    /// </summary>/
    public sealed class QuantityDate : QuickFix.Fields.StringField
    {
        public QuantityDate()
            :base(Fields.CustomTags.QuantityDate) {}
        public QuantityDate(string val)
            :base(Fields.CustomTags.QuantityDate, val) {}

    }


    /// <summary>
    /// ContIntRptID Field
    /// </summary>/
    public sealed class ContIntRptID : QuickFix.Fields.StringField
    {
        public ContIntRptID()
            :base(Fields.CustomTags.ContIntRptID) {}
        public ContIntRptID(string val)
            :base(Fields.CustomTags.ContIntRptID, val) {}

    }


    /// <summary>
    /// LateIndicator Field
    /// </summary>/
    public sealed class LateIndicator : QuickFix.Fields.BooleanField
    {
        public LateIndicator()
            :base(Fields.CustomTags.LateIndicator) {}
        public LateIndicator(Boolean val)
            :base(Fields.CustomTags.LateIndicator, val) {}

    }


    /// <summary>
    /// InputSource Field
    /// </summary>/
    public sealed class InputSource : QuickFix.Fields.StringField
    {
        public InputSource()
            :base(Fields.CustomTags.InputSource) {}
        public InputSource(string val)
            :base(Fields.CustomTags.InputSource, val) {}

    }


    /// <summary>
    /// SecurityUpdateAction Field
    /// </summary>/
    public sealed class SecurityUpdateAction : QuickFix.Fields.CharField
    {
        public SecurityUpdateAction()
            :base(Fields.CustomTags.SecurityUpdateAction) {}
        public SecurityUpdateAction(char val)
            :base(Fields.CustomTags.SecurityUpdateAction, val) {}


        // Field Enumerations
        public const char ADD = 'A';
        public const char DELETE = 'D';
        public const char MODIFY = 'M';
    }


    /// <summary>
    /// NoExpiration Field
    /// </summary>/
    public sealed class NoExpiration : QuickFix.Fields.IntField
    {
        public NoExpiration()
            :base(Fields.CustomTags.NoExpiration) {}
        public NoExpiration(int val)
            :base(Fields.CustomTags.NoExpiration, val) {}

    }


    /// <summary>
    /// ExpType Field
    /// </summary>/
    public sealed class ExpType : QuickFix.Fields.IntField
    {
        public ExpType()
            :base(Fields.CustomTags.ExpType) {}
        public ExpType(int val)
            :base(Fields.CustomTags.ExpType, val) {}


        // Field Enumerations
        public const int AUTO_EXERCISE = 1;
        public const int NON_AUTO_EXERCISE = 2;
        public const int FINAL_WILL_BE_EXERCISED = 3;
        public const int CONTRARY_INTENTION = 4;
        public const int DIFFERENCE = 5;
    }


    /// <summary>
    /// ExpQty Field
    /// </summary>/
    public sealed class ExpQty : QuickFix.Fields.DecimalField
    {
        public ExpQty()
            :base(Fields.CustomTags.ExpQty) {}
        public ExpQty(Decimal val)
            :base(Fields.CustomTags.ExpQty, val) {}

    }


    /// <summary>
    /// NoUnderlyingAmounts Field
    /// </summary>/
    public sealed class NoUnderlyingAmounts : QuickFix.Fields.IntField
    {
        public NoUnderlyingAmounts()
            :base(Fields.CustomTags.NoUnderlyingAmounts) {}
        public NoUnderlyingAmounts(int val)
            :base(Fields.CustomTags.NoUnderlyingAmounts, val) {}

    }


    /// <summary>
    /// UnderlyingPayAmount Field
    /// </summary>/
    public sealed class UnderlyingPayAmount : QuickFix.Fields.DecimalField
    {
        public UnderlyingPayAmount()
            :base(Fields.CustomTags.UnderlyingPayAmount) {}
        public UnderlyingPayAmount(Decimal val)
            :base(Fields.CustomTags.UnderlyingPayAmount, val) {}

    }


    /// <summary>
    /// UnderlyingCollectAmount Field
    /// </summary>/
    public sealed class UnderlyingCollectAmount : QuickFix.Fields.DecimalField
    {
        public UnderlyingCollectAmount()
            :base(Fields.CustomTags.UnderlyingCollectAmount) {}
        public UnderlyingCollectAmount(Decimal val)
            :base(Fields.CustomTags.UnderlyingCollectAmount, val) {}

    }


    /// <summary>
    /// UnderlyingSettlementDate Field
    /// </summary>/
    public sealed class UnderlyingSettlementDate : QuickFix.Fields.StringField
    {
        public UnderlyingSettlementDate()
            :base(Fields.CustomTags.UnderlyingSettlementDate) {}
        public UnderlyingSettlementDate(string val)
            :base(Fields.CustomTags.UnderlyingSettlementDate, val) {}

    }


    /// <summary>
    /// UnderlyingSettlementStatus Field
    /// </summary>/
    public sealed class UnderlyingSettlementStatus : QuickFix.Fields.StringField
    {
        public UnderlyingSettlementStatus()
            :base(Fields.CustomTags.UnderlyingSettlementStatus) {}
        public UnderlyingSettlementStatus(string val)
            :base(Fields.CustomTags.UnderlyingSettlementStatus, val) {}

    }


    /// <summary>
    /// SecondaryIndividualAllocID Field
    /// </summary>/
    public sealed class SecondaryIndividualAllocID : QuickFix.Fields.StringField
    {
        public SecondaryIndividualAllocID()
            :base(Fields.CustomTags.SecondaryIndividualAllocID) {}
        public SecondaryIndividualAllocID(string val)
            :base(Fields.CustomTags.SecondaryIndividualAllocID, val) {}

    }


    /// <summary>
    /// LegReportID Field
    /// </summary>/
    public sealed class LegReportID : QuickFix.Fields.StringField
    {
        public LegReportID()
            :base(Fields.CustomTags.LegReportID) {}
        public LegReportID(string val)
            :base(Fields.CustomTags.LegReportID, val) {}

    }


    /// <summary>
    /// RndPx Field
    /// </summary>/
    public sealed class RndPx : QuickFix.Fields.DecimalField
    {
        public RndPx()
            :base(Fields.CustomTags.RndPx) {}
        public RndPx(Decimal val)
            :base(Fields.CustomTags.RndPx, val) {}

    }


    /// <summary>
    /// IndividualAllocType Field
    /// </summary>/
    public sealed class IndividualAllocType : QuickFix.Fields.IntField
    {
        public IndividualAllocType()
            :base(Fields.CustomTags.IndividualAllocType) {}
        public IndividualAllocType(int val)
            :base(Fields.CustomTags.IndividualAllocType, val) {}


        // Field Enumerations
        public const int SUB_ALLOCATE = 1;
        public const int THIRD_PARTY_ALLOCATION = 2;
    }


    /// <summary>
    /// AllocCustomerCapacity Field
    /// </summary>/
    public sealed class AllocCustomerCapacity : QuickFix.Fields.StringField
    {
        public AllocCustomerCapacity()
            :base(Fields.CustomTags.AllocCustomerCapacity) {}
        public AllocCustomerCapacity(string val)
            :base(Fields.CustomTags.AllocCustomerCapacity, val) {}

    }


    /// <summary>
    /// TierCode Field
    /// </summary>/
    public sealed class TierCode : QuickFix.Fields.StringField
    {
        public TierCode()
            :base(Fields.CustomTags.TierCode) {}
        public TierCode(string val)
            :base(Fields.CustomTags.TierCode, val) {}

    }


    /// <summary>
    /// UnitOfMeasure Field
    /// </summary>/
    public sealed class UnitOfMeasure : QuickFix.Fields.StringField
    {
        public UnitOfMeasure()
            :base(Fields.CustomTags.UnitOfMeasure) {}
        public UnitOfMeasure(string val)
            :base(Fields.CustomTags.UnitOfMeasure, val) {}


        // Field Enumerations
        public const string MEGAWATT_HOURS = "MWh";
        public const string ONE_MILLION_BTU = "MMBtu";
        public const string BARRELS = "Bbl";
        public const string GALLONS = "Gal";
        public const string METRIC_TONS = "t";
        public const string TONS = "tn";
        public const string MILLION_BARRELS = "MMbbl";
        public const string POUNDS = "lbs";
        public const string TROY_OUNCES = "oz_tr";
        public const string US_DOLLARS = "USD";
        public const string BILLION_CUBIC_FEET = "Bcf";
        public const string BUSHELS = "Bu";
        public const string ALLOWANCES = "Alw";
    }


    /// <summary>
    /// TimeUnit Field
    /// </summary>/
    public sealed class TimeUnit : QuickFix.Fields.StringField
    {
        public TimeUnit()
            :base(Fields.CustomTags.TimeUnit) {}
        public TimeUnit(string val)
            :base(Fields.CustomTags.TimeUnit, val) {}


        // Field Enumerations
        public const string SECOND = "S";
        public const string MINUTE = "Min";
        public const string HOUR = "H";
        public const string DAY = "D";
        public const string WEEK = "Wk";
        public const string MONTH = "Mo";
        public const string YEAR = "Yr";
    }


    /// <summary>
    /// UnderlyingUnitOfMeasure Field
    /// </summary>/
    public sealed class UnderlyingUnitOfMeasure : QuickFix.Fields.StringField
    {
        public UnderlyingUnitOfMeasure()
            :base(Fields.CustomTags.UnderlyingUnitOfMeasure) {}
        public UnderlyingUnitOfMeasure(string val)
            :base(Fields.CustomTags.UnderlyingUnitOfMeasure, val) {}

    }


    /// <summary>
    /// LegUnitOfMeasure Field
    /// </summary>/
    public sealed class LegUnitOfMeasure : QuickFix.Fields.StringField
    {
        public LegUnitOfMeasure()
            :base(Fields.CustomTags.LegUnitOfMeasure) {}
        public LegUnitOfMeasure(string val)
            :base(Fields.CustomTags.LegUnitOfMeasure, val) {}

    }


    /// <summary>
    /// UnderlyingTimeUnit Field
    /// </summary>/
    public sealed class UnderlyingTimeUnit : QuickFix.Fields.StringField
    {
        public UnderlyingTimeUnit()
            :base(Fields.CustomTags.UnderlyingTimeUnit) {}
        public UnderlyingTimeUnit(string val)
            :base(Fields.CustomTags.UnderlyingTimeUnit, val) {}

    }


    /// <summary>
    /// LegTimeUnit Field
    /// </summary>/
    public sealed class LegTimeUnit : QuickFix.Fields.StringField
    {
        public LegTimeUnit()
            :base(Fields.CustomTags.LegTimeUnit) {}
        public LegTimeUnit(string val)
            :base(Fields.CustomTags.LegTimeUnit, val) {}

    }


    /// <summary>
    /// AllocMethod Field
    /// </summary>/
    public sealed class AllocMethod : QuickFix.Fields.IntField
    {
        public AllocMethod()
            :base(Fields.CustomTags.AllocMethod) {}
        public AllocMethod(int val)
            :base(Fields.CustomTags.AllocMethod, val) {}


        // Field Enumerations
        public const int AUTOMATIC = 1;
        public const int GUARANTOR = 2;
        public const int MANUAL = 3;
    }


    /// <summary>
    /// SideTradeReportID Field
    /// </summary>/
    public sealed class SideTradeReportID : QuickFix.Fields.StringField
    {
        public SideTradeReportID()
            :base(Fields.CustomTags.SideTradeReportID) {}
        public SideTradeReportID(string val)
            :base(Fields.CustomTags.SideTradeReportID, val) {}

    }


    /// <summary>
    /// SideFillStationCd Field
    /// </summary>/
    public sealed class SideFillStationCd : QuickFix.Fields.StringField
    {
        public SideFillStationCd()
            :base(Fields.CustomTags.SideFillStationCd) {}
        public SideFillStationCd(string val)
            :base(Fields.CustomTags.SideFillStationCd, val) {}

    }


    /// <summary>
    /// SideReasonCd Field
    /// </summary>/
    public sealed class SideReasonCd : QuickFix.Fields.StringField
    {
        public SideReasonCd()
            :base(Fields.CustomTags.SideReasonCd) {}
        public SideReasonCd(string val)
            :base(Fields.CustomTags.SideReasonCd, val) {}

    }


    /// <summary>
    /// SideTrdSubTyp Field
    /// </summary>/
    public sealed class SideTrdSubTyp : QuickFix.Fields.IntField
    {
        public SideTrdSubTyp()
            :base(Fields.CustomTags.SideTrdSubTyp) {}
        public SideTrdSubTyp(int val)
            :base(Fields.CustomTags.SideTrdSubTyp, val) {}


        // Field Enumerations
        public const int CMTA = 0;
        public const int INTERNAL_TRANSFER = 1;
        public const int EXTERNAL_TRANSFER = 2;
        public const int REJECT_FOR_SUBMITTING_TRADE = 3;
        public const int ADVISORY_FOR_CONTRA_SIDE = 4;
        public const int OFFSET_DUE_TO_AN_ALLOCATION = 5;
        public const int ONSET_DUE_TO_AN_ALLOCATION = 6;
        public const int DIFFERENTIAL_SPREAD = 7;
        public const int IMPLIED_SPREAD_LEG_EXECUTED_AGAINST_AN_OUTRIGHT = 8;
        public const int TRANSACTION_FROM_EXERCISE = 9;
        public const int TRANSACTION_FROM_ASSIGNMENT = 10;
    }


    /// <summary>
    /// SideQty Field
    /// </summary>/
    public sealed class SideQty : QuickFix.Fields.IntField
    {
        public SideQty()
            :base(Fields.CustomTags.SideQty) {}
        public SideQty(int val)
            :base(Fields.CustomTags.SideQty, val) {}

    }


    /// <summary>
    /// MessageEventSource Field
    /// </summary>/
    public sealed class MessageEventSource : QuickFix.Fields.StringField
    {
        public MessageEventSource()
            :base(Fields.CustomTags.MessageEventSource) {}
        public MessageEventSource(string val)
            :base(Fields.CustomTags.MessageEventSource, val) {}

    }


    /// <summary>
    /// SideTrdRegTimestamp Field
    /// </summary>/
    public sealed class SideTrdRegTimestamp : QuickFix.Fields.DateTimeField
    {
        public SideTrdRegTimestamp()
            :base(Fields.CustomTags.SideTrdRegTimestamp) {}
        public SideTrdRegTimestamp(DateTime val)
            :base(Fields.CustomTags.SideTrdRegTimestamp, val) {}
        public SideTrdRegTimestamp(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.SideTrdRegTimestamp, val, showMilliseconds) {}
		public SideTrdRegTimestamp(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.SideTrdRegTimestamp, val, precision) {}

    }


    /// <summary>
    /// SideTrdRegTimestampType Field
    /// </summary>/
    public sealed class SideTrdRegTimestampType : QuickFix.Fields.IntField
    {
        public SideTrdRegTimestampType()
            :base(Fields.CustomTags.SideTrdRegTimestampType) {}
        public SideTrdRegTimestampType(int val)
            :base(Fields.CustomTags.SideTrdRegTimestampType, val) {}

    }


    /// <summary>
    /// SideTrdRegTimestampSrc Field
    /// </summary>/
    public sealed class SideTrdRegTimestampSrc : QuickFix.Fields.StringField
    {
        public SideTrdRegTimestampSrc()
            :base(Fields.CustomTags.SideTrdRegTimestampSrc) {}
        public SideTrdRegTimestampSrc(string val)
            :base(Fields.CustomTags.SideTrdRegTimestampSrc, val) {}

    }


    /// <summary>
    /// AsOfIndicator Field
    /// </summary>/
    public sealed class AsOfIndicator : QuickFix.Fields.CharField
    {
        public AsOfIndicator()
            :base(Fields.CustomTags.AsOfIndicator) {}
        public AsOfIndicator(char val)
            :base(Fields.CustomTags.AsOfIndicator, val) {}


        // Field Enumerations
        public const char FALSE = '0';
        public const char TRUE = '1';
    }


    /// <summary>
    /// NoSideTrdRegTS Field
    /// </summary>/
    public sealed class NoSideTrdRegTS : QuickFix.Fields.IntField
    {
        public NoSideTrdRegTS()
            :base(Fields.CustomTags.NoSideTrdRegTS) {}
        public NoSideTrdRegTS(int val)
            :base(Fields.CustomTags.NoSideTrdRegTS, val) {}

    }


    /// <summary>
    /// LegOptionRatio Field
    /// </summary>/
    public sealed class LegOptionRatio : QuickFix.Fields.DecimalField
    {
        public LegOptionRatio()
            :base(Fields.CustomTags.LegOptionRatio) {}
        public LegOptionRatio(Decimal val)
            :base(Fields.CustomTags.LegOptionRatio, val) {}

    }


    /// <summary>
    /// NoInstrumentParties Field
    /// </summary>/
    public sealed class NoInstrumentParties : QuickFix.Fields.IntField
    {
        public NoInstrumentParties()
            :base(Fields.CustomTags.NoInstrumentParties) {}
        public NoInstrumentParties(int val)
            :base(Fields.CustomTags.NoInstrumentParties, val) {}

    }


    /// <summary>
    /// InstrumentPartyID Field
    /// </summary>/
    public sealed class InstrumentPartyID : QuickFix.Fields.StringField
    {
        public InstrumentPartyID()
            :base(Fields.CustomTags.InstrumentPartyID) {}
        public InstrumentPartyID(string val)
            :base(Fields.CustomTags.InstrumentPartyID, val) {}

    }


    /// <summary>
    /// TradeVolume Field
    /// </summary>/
    public sealed class TradeVolume : QuickFix.Fields.DecimalField
    {
        public TradeVolume()
            :base(Fields.CustomTags.TradeVolume) {}
        public TradeVolume(Decimal val)
            :base(Fields.CustomTags.TradeVolume, val) {}

    }


    /// <summary>
    /// MDBookType Field
    /// </summary>/
    public sealed class MDBookType : QuickFix.Fields.IntField
    {
        public MDBookType()
            :base(Fields.CustomTags.MDBookType) {}
        public MDBookType(int val)
            :base(Fields.CustomTags.MDBookType, val) {}


        // Field Enumerations
        public const int TOP_OF_BOOK = 1;
        public const int PRICE_DEPTH = 2;
        public const int ORDER_DEPTH = 3;
    }


    /// <summary>
    /// MDFeedType Field
    /// </summary>/
    public sealed class MDFeedType : QuickFix.Fields.StringField
    {
        public MDFeedType()
            :base(Fields.CustomTags.MDFeedType) {}
        public MDFeedType(string val)
            :base(Fields.CustomTags.MDFeedType, val) {}

    }


    /// <summary>
    /// MDPriceLevel Field
    /// </summary>/
    public sealed class MDPriceLevel : QuickFix.Fields.IntField
    {
        public MDPriceLevel()
            :base(Fields.CustomTags.MDPriceLevel) {}
        public MDPriceLevel(int val)
            :base(Fields.CustomTags.MDPriceLevel, val) {}

    }


    /// <summary>
    /// MDOriginType Field
    /// </summary>/
    public sealed class MDOriginType : QuickFix.Fields.IntField
    {
        public MDOriginType()
            :base(Fields.CustomTags.MDOriginType) {}
        public MDOriginType(int val)
            :base(Fields.CustomTags.MDOriginType, val) {}


        // Field Enumerations
        public const int BOOK = 0;
        public const int OFF_BOOK = 1;
        public const int CROSS = 2;
    }


    /// <summary>
    /// FirstPx Field
    /// </summary>/
    public sealed class FirstPx : QuickFix.Fields.DecimalField
    {
        public FirstPx()
            :base(Fields.CustomTags.FirstPx) {}
        public FirstPx(Decimal val)
            :base(Fields.CustomTags.FirstPx, val) {}

    }


    /// <summary>
    /// MDEntrySpotRate Field
    /// </summary>/
    public sealed class MDEntrySpotRate : QuickFix.Fields.DecimalField
    {
        public MDEntrySpotRate()
            :base(Fields.CustomTags.MDEntrySpotRate) {}
        public MDEntrySpotRate(Decimal val)
            :base(Fields.CustomTags.MDEntrySpotRate, val) {}

    }


    /// <summary>
    /// MDEntryForwardPoints Field
    /// </summary>/
    public sealed class MDEntryForwardPoints : QuickFix.Fields.DecimalField
    {
        public MDEntryForwardPoints()
            :base(Fields.CustomTags.MDEntryForwardPoints) {}
        public MDEntryForwardPoints(Decimal val)
            :base(Fields.CustomTags.MDEntryForwardPoints, val) {}

    }


    /// <summary>
    /// CustDirectedOrder Field
    /// </summary>/
    public sealed class CustDirectedOrder : QuickFix.Fields.BooleanField
    {
        public CustDirectedOrder()
            :base(Fields.CustomTags.CustDirectedOrder) {}
        public CustDirectedOrder(Boolean val)
            :base(Fields.CustomTags.CustDirectedOrder, val) {}

    }


    /// <summary>
    /// ReceivedDeptID Field
    /// </summary>/
    public sealed class ReceivedDeptID : QuickFix.Fields.StringField
    {
        public ReceivedDeptID()
            :base(Fields.CustomTags.ReceivedDeptID) {}
        public ReceivedDeptID(string val)
            :base(Fields.CustomTags.ReceivedDeptID, val) {}

    }


    /// <summary>
    /// OrderHandlingInstSource Field
    /// </summary>/
    public sealed class OrderHandlingInstSource : QuickFix.Fields.IntField
    {
        public OrderHandlingInstSource()
            :base(Fields.CustomTags.OrderHandlingInstSource) {}
        public OrderHandlingInstSource(int val)
            :base(Fields.CustomTags.OrderHandlingInstSource, val) {}


        // Field Enumerations
        public const int NASD_OATS = 1;
    }


    /// <summary>
    /// DeskType Field
    /// </summary>/
    public sealed class DeskType : QuickFix.Fields.StringField
    {
        public DeskType()
            :base(Fields.CustomTags.DeskType) {}
        public DeskType(string val)
            :base(Fields.CustomTags.DeskType, val) {}


        // Field Enumerations
        public const string AGENCY = "A";
        public const string ARBITRAGE = "AR";
        public const string DERIVATIVES = "D";
        public const string INTERNATIONAL = "IN";
        public const string INSTITUTIONAL = "IS";
        public const string OTHER = "O";
        public const string PREFERRED_TRADING = "PF";
        public const string PROPRIETARY = "PR";
        public const string PROGRAM_TRADING = "PT";
        public const string SALES = "S";
        public const string TRADING = "T";
    }


    /// <summary>
    /// DeskTypeSource Field
    /// </summary>/
    public sealed class DeskTypeSource : QuickFix.Fields.IntField
    {
        public DeskTypeSource()
            :base(Fields.CustomTags.DeskTypeSource) {}
        public DeskTypeSource(int val)
            :base(Fields.CustomTags.DeskTypeSource, val) {}


        // Field Enumerations
        public const int NASD_OATS = 1;
    }


    /// <summary>
    /// DeskOrderHandlingInst Field
    /// </summary>/
    public sealed class DeskOrderHandlingInst : QuickFix.Fields.StringField
    {
        public DeskOrderHandlingInst()
            :base(Fields.CustomTags.DeskOrderHandlingInst) {}
        public DeskOrderHandlingInst(string val)
            :base(Fields.CustomTags.DeskOrderHandlingInst, val) {}


        // Field Enumerations
        public const string ADD_ON_ORDER = "ADD";
        public const string ALL_OR_NONE = "AON";
        public const string CASH_NOT_HELD = "CNH";
        public const string DIRECTED_ORDER = "DIR";
        public const string EXCHANGE_FOR_PHYSICAL_TRANSACTION = "E.W";
        public const string FILL_OR_KILL = "FOK";
        public const string IMBALANCE_ONLY = "IO";
        public const string IMMEDIATE_OR_CANCEL = "IOC";
        public const string LIMIT_ON_OPEN = "LOO";
        public const string LIMIT_ON_CLOSE = "LOC";
        public const string MARKET_AT_OPEN = "MAO";
        public const string MARKET_AT_CLOSE = "MAC";
        public const string MARKET_ON_OPEN = "MOO";
        public const string MARKET_ON_CLOSE = "MOC";
        public const string MINIMUM_QUANTITY = "MQT";
        public const string NOT_HELD = "NH";
        public const string OVER_THE_DAY = "OVD";
        public const string PEGGED = "PEG";
        public const string RESERVE_SIZE_ORDER = "RSV";
        public const string STOP_STOCK_TRANSACTION = "S.W";
        public const string SCALE = "SCL";
        public const string TIME_ORDER = "TMO";
        public const string TRAILING_STOP = "TS";
        public const string WORK = "WRK";
    }


    /// <summary>
    /// ExecAckStatus Field
    /// </summary>/
    public sealed class ExecAckStatus : QuickFix.Fields.CharField
    {
        public ExecAckStatus()
            :base(Fields.CustomTags.ExecAckStatus) {}
        public ExecAckStatus(char val)
            :base(Fields.CustomTags.ExecAckStatus, val) {}


        // Field Enumerations
        public const char RECEIVED_NOT_YET_PROCESSED = '0';
        public const char ACCEPTED = '1';
        public const char DONT_KNOW = '2';
    }


    /// <summary>
    /// UnderlyingDeliveryAmount Field
    /// </summary>/
    public sealed class UnderlyingDeliveryAmount : QuickFix.Fields.DecimalField
    {
        public UnderlyingDeliveryAmount()
            :base(Fields.CustomTags.UnderlyingDeliveryAmount) {}
        public UnderlyingDeliveryAmount(Decimal val)
            :base(Fields.CustomTags.UnderlyingDeliveryAmount, val) {}

    }


    /// <summary>
    /// UnderlyingCapValue Field
    /// </summary>/
    public sealed class UnderlyingCapValue : QuickFix.Fields.DecimalField
    {
        public UnderlyingCapValue()
            :base(Fields.CustomTags.UnderlyingCapValue) {}
        public UnderlyingCapValue(Decimal val)
            :base(Fields.CustomTags.UnderlyingCapValue, val) {}

    }


    /// <summary>
    /// UnderlyingSettlMethod Field
    /// </summary>/
    public sealed class UnderlyingSettlMethod : QuickFix.Fields.StringField
    {
        public UnderlyingSettlMethod()
            :base(Fields.CustomTags.UnderlyingSettlMethod) {}
        public UnderlyingSettlMethod(string val)
            :base(Fields.CustomTags.UnderlyingSettlMethod, val) {}

    }


    /// <summary>
    /// SecondaryTradeID Field
    /// </summary>/
    public sealed class SecondaryTradeID : QuickFix.Fields.StringField
    {
        public SecondaryTradeID()
            :base(Fields.CustomTags.SecondaryTradeID) {}
        public SecondaryTradeID(string val)
            :base(Fields.CustomTags.SecondaryTradeID, val) {}

    }


    /// <summary>
    /// FirmTradeID Field
    /// </summary>/
    public sealed class FirmTradeID : QuickFix.Fields.StringField
    {
        public FirmTradeID()
            :base(Fields.CustomTags.FirmTradeID) {}
        public FirmTradeID(string val)
            :base(Fields.CustomTags.FirmTradeID, val) {}

    }


    /// <summary>
    /// SecondaryFirmTradeID Field
    /// </summary>/
    public sealed class SecondaryFirmTradeID : QuickFix.Fields.StringField
    {
        public SecondaryFirmTradeID()
            :base(Fields.CustomTags.SecondaryFirmTradeID) {}
        public SecondaryFirmTradeID(string val)
            :base(Fields.CustomTags.SecondaryFirmTradeID, val) {}

    }


    /// <summary>
    /// CollApplType Field
    /// </summary>/
    public sealed class CollApplType : QuickFix.Fields.IntField
    {
        public CollApplType()
            :base(Fields.CustomTags.CollApplType) {}
        public CollApplType(int val)
            :base(Fields.CustomTags.CollApplType, val) {}


        // Field Enumerations
        public const int SPECIFIC_DEPOSIT = 0;
        public const int GENERAL = 1;
    }


    /// <summary>
    /// UnderlyingAdjustedQuantity Field
    /// </summary>/
    public sealed class UnderlyingAdjustedQuantity : QuickFix.Fields.DecimalField
    {
        public UnderlyingAdjustedQuantity()
            :base(Fields.CustomTags.UnderlyingAdjustedQuantity) {}
        public UnderlyingAdjustedQuantity(Decimal val)
            :base(Fields.CustomTags.UnderlyingAdjustedQuantity, val) {}

    }


    /// <summary>
    /// UnderlyingFXRate Field
    /// </summary>/
    public sealed class UnderlyingFXRate : QuickFix.Fields.DecimalField
    {
        public UnderlyingFXRate()
            :base(Fields.CustomTags.UnderlyingFXRate) {}
        public UnderlyingFXRate(Decimal val)
            :base(Fields.CustomTags.UnderlyingFXRate, val) {}

    }


    /// <summary>
    /// UnderlyingFXRateCalc Field
    /// </summary>/
    public sealed class UnderlyingFXRateCalc : QuickFix.Fields.CharField
    {
        public UnderlyingFXRateCalc()
            :base(Fields.CustomTags.UnderlyingFXRateCalc) {}
        public UnderlyingFXRateCalc(char val)
            :base(Fields.CustomTags.UnderlyingFXRateCalc, val) {}


        // Field Enumerations
        public const char MULTIPLY = 'M';
        public const char DIVIDE = 'D';
    }


    /// <summary>
    /// DealingCapacity Field
    /// </summary>/
    public sealed class DealingCapacity : QuickFix.Fields.CharField
    {
        public DealingCapacity()
            :base(Fields.CustomTags.DealingCapacity) {}
        public DealingCapacity(char val)
            :base(Fields.CustomTags.DealingCapacity, val) {}


        // Field Enumerations
        public const char AGENT = 'A';
        public const char PRINCIPAL = 'P';
        public const char RISKLESS_PRINCIPAL = 'R';
    }


    /// <summary>
    /// InstrmtAssignmentMethod Field
    /// </summary>/
    public sealed class InstrmtAssignmentMethod : QuickFix.Fields.CharField
    {
        public InstrmtAssignmentMethod()
            :base(Fields.CustomTags.InstrmtAssignmentMethod) {}
        public InstrmtAssignmentMethod(char val)
            :base(Fields.CustomTags.InstrmtAssignmentMethod, val) {}

    }


    /// <summary>
    /// InstrumentPartyIDSource Field
    /// </summary>/
    public sealed class InstrumentPartyIDSource : QuickFix.Fields.CharField
    {
        public InstrumentPartyIDSource()
            :base(Fields.CustomTags.InstrumentPartyIDSource) {}
        public InstrumentPartyIDSource(char val)
            :base(Fields.CustomTags.InstrumentPartyIDSource, val) {}

    }


    /// <summary>
    /// InstrumentPartyRole Field
    /// </summary>/
    public sealed class InstrumentPartyRole : QuickFix.Fields.IntField
    {
        public InstrumentPartyRole()
            :base(Fields.CustomTags.InstrumentPartyRole) {}
        public InstrumentPartyRole(int val)
            :base(Fields.CustomTags.InstrumentPartyRole, val) {}

    }


    /// <summary>
    /// NoInstrumentPartySubIDs Field
    /// </summary>/
    public sealed class NoInstrumentPartySubIDs : QuickFix.Fields.IntField
    {
        public NoInstrumentPartySubIDs()
            :base(Fields.CustomTags.NoInstrumentPartySubIDs) {}
        public NoInstrumentPartySubIDs(int val)
            :base(Fields.CustomTags.NoInstrumentPartySubIDs, val) {}

    }


    /// <summary>
    /// InstrumentPartySubID Field
    /// </summary>/
    public sealed class InstrumentPartySubID : QuickFix.Fields.StringField
    {
        public InstrumentPartySubID()
            :base(Fields.CustomTags.InstrumentPartySubID) {}
        public InstrumentPartySubID(string val)
            :base(Fields.CustomTags.InstrumentPartySubID, val) {}

    }


    /// <summary>
    /// InstrumentPartySubIDType Field
    /// </summary>/
    public sealed class InstrumentPartySubIDType : QuickFix.Fields.IntField
    {
        public InstrumentPartySubIDType()
            :base(Fields.CustomTags.InstrumentPartySubIDType) {}
        public InstrumentPartySubIDType(int val)
            :base(Fields.CustomTags.InstrumentPartySubIDType, val) {}

    }


    /// <summary>
    /// PositionCurrency Field
    /// </summary>/
    public sealed class PositionCurrency : QuickFix.Fields.StringField
    {
        public PositionCurrency()
            :base(Fields.CustomTags.PositionCurrency) {}
        public PositionCurrency(string val)
            :base(Fields.CustomTags.PositionCurrency, val) {}

    }


    /// <summary>
    /// CalculatedCcyLastQty Field
    /// </summary>/
    public sealed class CalculatedCcyLastQty : QuickFix.Fields.DecimalField
    {
        public CalculatedCcyLastQty()
            :base(Fields.CustomTags.CalculatedCcyLastQty) {}
        public CalculatedCcyLastQty(Decimal val)
            :base(Fields.CustomTags.CalculatedCcyLastQty, val) {}

    }


    /// <summary>
    /// NoUndlyInstrumentParties Field
    /// </summary>/
    public sealed class NoUndlyInstrumentParties : QuickFix.Fields.IntField
    {
        public NoUndlyInstrumentParties()
            :base(Fields.CustomTags.NoUndlyInstrumentParties) {}
        public NoUndlyInstrumentParties(int val)
            :base(Fields.CustomTags.NoUndlyInstrumentParties, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartyID Field
    /// </summary>/
    public sealed class UndlyInstrumentPartyID : QuickFix.Fields.StringField
    {
        public UndlyInstrumentPartyID()
            :base(Fields.CustomTags.UndlyInstrumentPartyID) {}
        public UndlyInstrumentPartyID(string val)
            :base(Fields.CustomTags.UndlyInstrumentPartyID, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartyIDSource Field
    /// </summary>/
    public sealed class UndlyInstrumentPartyIDSource : QuickFix.Fields.CharField
    {
        public UndlyInstrumentPartyIDSource()
            :base(Fields.CustomTags.UndlyInstrumentPartyIDSource) {}
        public UndlyInstrumentPartyIDSource(char val)
            :base(Fields.CustomTags.UndlyInstrumentPartyIDSource, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartyRole Field
    /// </summary>/
    public sealed class UndlyInstrumentPartyRole : QuickFix.Fields.IntField
    {
        public UndlyInstrumentPartyRole()
            :base(Fields.CustomTags.UndlyInstrumentPartyRole) {}
        public UndlyInstrumentPartyRole(int val)
            :base(Fields.CustomTags.UndlyInstrumentPartyRole, val) {}

    }


    /// <summary>
    /// NoUndlyInstrumentPartySubIDs Field
    /// </summary>/
    public sealed class NoUndlyInstrumentPartySubIDs : QuickFix.Fields.IntField
    {
        public NoUndlyInstrumentPartySubIDs()
            :base(Fields.CustomTags.NoUndlyInstrumentPartySubIDs) {}
        public NoUndlyInstrumentPartySubIDs(int val)
            :base(Fields.CustomTags.NoUndlyInstrumentPartySubIDs, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartySubID Field
    /// </summary>/
    public sealed class UndlyInstrumentPartySubID : QuickFix.Fields.StringField
    {
        public UndlyInstrumentPartySubID()
            :base(Fields.CustomTags.UndlyInstrumentPartySubID) {}
        public UndlyInstrumentPartySubID(string val)
            :base(Fields.CustomTags.UndlyInstrumentPartySubID, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartySubIDType Field
    /// </summary>/
    public sealed class UndlyInstrumentPartySubIDType : QuickFix.Fields.IntField
    {
        public UndlyInstrumentPartySubIDType()
            :base(Fields.CustomTags.UndlyInstrumentPartySubIDType) {}
        public UndlyInstrumentPartySubIDType(int val)
            :base(Fields.CustomTags.UndlyInstrumentPartySubIDType, val) {}

    }


    /// <summary>
    /// BidSwapPoints Field
    /// </summary>/
    public sealed class BidSwapPoints : QuickFix.Fields.DecimalField
    {
        public BidSwapPoints()
            :base(Fields.CustomTags.BidSwapPoints) {}
        public BidSwapPoints(Decimal val)
            :base(Fields.CustomTags.BidSwapPoints, val) {}

    }


    /// <summary>
    /// OfferSwapPoints Field
    /// </summary>/
    public sealed class OfferSwapPoints : QuickFix.Fields.DecimalField
    {
        public OfferSwapPoints()
            :base(Fields.CustomTags.OfferSwapPoints) {}
        public OfferSwapPoints(Decimal val)
            :base(Fields.CustomTags.OfferSwapPoints, val) {}

    }


    /// <summary>
    /// LegBidForwardPoints Field
    /// </summary>/
    public sealed class LegBidForwardPoints : QuickFix.Fields.DecimalField
    {
        public LegBidForwardPoints()
            :base(Fields.CustomTags.LegBidForwardPoints) {}
        public LegBidForwardPoints(Decimal val)
            :base(Fields.CustomTags.LegBidForwardPoints, val) {}

    }


    /// <summary>
    /// LegOfferForwardPoints Field
    /// </summary>/
    public sealed class LegOfferForwardPoints : QuickFix.Fields.DecimalField
    {
        public LegOfferForwardPoints()
            :base(Fields.CustomTags.LegOfferForwardPoints) {}
        public LegOfferForwardPoints(Decimal val)
            :base(Fields.CustomTags.LegOfferForwardPoints, val) {}

    }


    /// <summary>
    /// SwapPoints Field
    /// </summary>/
    public sealed class SwapPoints : QuickFix.Fields.DecimalField
    {
        public SwapPoints()
            :base(Fields.CustomTags.SwapPoints) {}
        public SwapPoints(Decimal val)
            :base(Fields.CustomTags.SwapPoints, val) {}

    }


    /// <summary>
    /// MDQuoteType Field
    /// </summary>/
    public sealed class MDQuoteType : QuickFix.Fields.IntField
    {
        public MDQuoteType()
            :base(Fields.CustomTags.MDQuoteType) {}
        public MDQuoteType(int val)
            :base(Fields.CustomTags.MDQuoteType, val) {}


        // Field Enumerations
        public const int INDICATIVE = 0;
        public const int TRADEABLE = 1;
        public const int RESTRICTED_TRADEABLE = 2;
        public const int COUNTER = 3;
        public const int INDICATIVE_AND_TRADEABLE = 4;
    }


    /// <summary>
    /// LastSwapPoints Field
    /// </summary>/
    public sealed class LastSwapPoints : QuickFix.Fields.DecimalField
    {
        public LastSwapPoints()
            :base(Fields.CustomTags.LastSwapPoints) {}
        public LastSwapPoints(Decimal val)
            :base(Fields.CustomTags.LastSwapPoints, val) {}

    }


    /// <summary>
    /// SideGrossTradeAmt Field
    /// </summary>/
    public sealed class SideGrossTradeAmt : QuickFix.Fields.DecimalField
    {
        public SideGrossTradeAmt()
            :base(Fields.CustomTags.SideGrossTradeAmt) {}
        public SideGrossTradeAmt(Decimal val)
            :base(Fields.CustomTags.SideGrossTradeAmt, val) {}

    }


    /// <summary>
    /// LegLastForwardPoints Field
    /// </summary>/
    public sealed class LegLastForwardPoints : QuickFix.Fields.DecimalField
    {
        public LegLastForwardPoints()
            :base(Fields.CustomTags.LegLastForwardPoints) {}
        public LegLastForwardPoints(Decimal val)
            :base(Fields.CustomTags.LegLastForwardPoints, val) {}

    }


    /// <summary>
    /// LegCalculatedCcyLastQty Field
    /// </summary>/
    public sealed class LegCalculatedCcyLastQty : QuickFix.Fields.DecimalField
    {
        public LegCalculatedCcyLastQty()
            :base(Fields.CustomTags.LegCalculatedCcyLastQty) {}
        public LegCalculatedCcyLastQty(Decimal val)
            :base(Fields.CustomTags.LegCalculatedCcyLastQty, val) {}

    }


    /// <summary>
    /// LegGrossTradeAmt Field
    /// </summary>/
    public sealed class LegGrossTradeAmt : QuickFix.Fields.DecimalField
    {
        public LegGrossTradeAmt()
            :base(Fields.CustomTags.LegGrossTradeAmt) {}
        public LegGrossTradeAmt(Decimal val)
            :base(Fields.CustomTags.LegGrossTradeAmt, val) {}

    }


    /// <summary>
    /// MaturityTime Field
    /// </summary>/
    public sealed class MaturityTime : QuickFix.Fields.StringField
    {
        public MaturityTime()
            :base(Fields.CustomTags.MaturityTime) {}
        public MaturityTime(string val)
            :base(Fields.CustomTags.MaturityTime, val) {}

    }


    /// <summary>
    /// RefOrderID Field
    /// </summary>/
    public sealed class RefOrderID : QuickFix.Fields.StringField
    {
        public RefOrderID()
            :base(Fields.CustomTags.RefOrderID) {}
        public RefOrderID(string val)
            :base(Fields.CustomTags.RefOrderID, val) {}

    }


    /// <summary>
    /// RefOrderIDSource Field
    /// </summary>/
    public sealed class RefOrderIDSource : QuickFix.Fields.CharField
    {
        public RefOrderIDSource()
            :base(Fields.CustomTags.RefOrderIDSource) {}
        public RefOrderIDSource(char val)
            :base(Fields.CustomTags.RefOrderIDSource, val) {}


        // Field Enumerations
        public const char SECONDARYORDERID = '0';
        public const char ORDERID = '1';
        public const char MDENTRYID = '2';
        public const char QUOTEENTRYID = '3';
        public const char ORIGINAL_ORDER_ID = '4';
        public const char SECONDARYORDEID = '0';
        public const char ORDEID = '1';
        public const char MENTRYID = '2';
        public const char QUOTENTRYID = '3';
    }


    /// <summary>
    /// SecondaryDisplayQty Field
    /// </summary>/
    public sealed class SecondaryDisplayQty : QuickFix.Fields.DecimalField
    {
        public SecondaryDisplayQty()
            :base(Fields.CustomTags.SecondaryDisplayQty) {}
        public SecondaryDisplayQty(Decimal val)
            :base(Fields.CustomTags.SecondaryDisplayQty, val) {}

    }


    /// <summary>
    /// DisplayWhen Field
    /// </summary>/
    public sealed class DisplayWhen : QuickFix.Fields.CharField
    {
        public DisplayWhen()
            :base(Fields.CustomTags.DisplayWhen) {}
        public DisplayWhen(char val)
            :base(Fields.CustomTags.DisplayWhen, val) {}


        // Field Enumerations
        public const char IMMEDIATE = '1';
        public const char EXHAUST = '2';
    }


    /// <summary>
    /// DisplayMethod Field
    /// </summary>/
    public sealed class DisplayMethod : QuickFix.Fields.CharField
    {
        public DisplayMethod()
            :base(Fields.CustomTags.DisplayMethod) {}
        public DisplayMethod(char val)
            :base(Fields.CustomTags.DisplayMethod, val) {}


        // Field Enumerations
        public const char INITIAL = '1';
        public const char NEW = '2';
        public const char RANDOM = '3';
        public const char UNDISCLOSED = '4';
    }


    /// <summary>
    /// DisplayLowQty Field
    /// </summary>/
    public sealed class DisplayLowQty : QuickFix.Fields.DecimalField
    {
        public DisplayLowQty()
            :base(Fields.CustomTags.DisplayLowQty) {}
        public DisplayLowQty(Decimal val)
            :base(Fields.CustomTags.DisplayLowQty, val) {}

    }


    /// <summary>
    /// DisplayHighQty Field
    /// </summary>/
    public sealed class DisplayHighQty : QuickFix.Fields.DecimalField
    {
        public DisplayHighQty()
            :base(Fields.CustomTags.DisplayHighQty) {}
        public DisplayHighQty(Decimal val)
            :base(Fields.CustomTags.DisplayHighQty, val) {}

    }


    /// <summary>
    /// DisplayMinIncr Field
    /// </summary>/
    public sealed class DisplayMinIncr : QuickFix.Fields.DecimalField
    {
        public DisplayMinIncr()
            :base(Fields.CustomTags.DisplayMinIncr) {}
        public DisplayMinIncr(Decimal val)
            :base(Fields.CustomTags.DisplayMinIncr, val) {}

    }


    /// <summary>
    /// MatchIncrement Field
    /// </summary>/
    public sealed class MatchIncrement : QuickFix.Fields.DecimalField
    {
        public MatchIncrement()
            :base(Fields.CustomTags.MatchIncrement) {}
        public MatchIncrement(Decimal val)
            :base(Fields.CustomTags.MatchIncrement, val) {}

    }


    /// <summary>
    /// MaxPriceLevels Field
    /// </summary>/
    public sealed class MaxPriceLevels : QuickFix.Fields.IntField
    {
        public MaxPriceLevels()
            :base(Fields.CustomTags.MaxPriceLevels) {}
        public MaxPriceLevels(int val)
            :base(Fields.CustomTags.MaxPriceLevels, val) {}

    }


    /// <summary>
    /// PreTradeAnonymity Field
    /// </summary>/
    public sealed class PreTradeAnonymity : QuickFix.Fields.BooleanField
    {
        public PreTradeAnonymity()
            :base(Fields.CustomTags.PreTradeAnonymity) {}
        public PreTradeAnonymity(Boolean val)
            :base(Fields.CustomTags.PreTradeAnonymity, val) {}

    }


    /// <summary>
    /// PriceProtectionScope Field
    /// </summary>/
    public sealed class PriceProtectionScope : QuickFix.Fields.CharField
    {
        public PriceProtectionScope()
            :base(Fields.CustomTags.PriceProtectionScope) {}
        public PriceProtectionScope(char val)
            :base(Fields.CustomTags.PriceProtectionScope, val) {}


        // Field Enumerations
        public const char NONE = '0';
        public const char LOCAL = '1';
        public const char NATIONAL = '2';
        public const char GLOBAL = '3';
    }


    /// <summary>
    /// LotType Field
    /// </summary>/
    public sealed class LotType : QuickFix.Fields.CharField
    {
        public LotType()
            :base(Fields.CustomTags.LotType) {}
        public LotType(char val)
            :base(Fields.CustomTags.LotType, val) {}


        // Field Enumerations
        public const char ODD_LOT = '1';
        public const char ROUND_LOT = '2';
        public const char BLOCK_LOT = '3';
        public const char ROUND_LOT_BASED_UPON_UNITOFMEASURE = '4';
    }


    /// <summary>
    /// PegPriceType Field
    /// </summary>/
    public sealed class PegPriceType : QuickFix.Fields.IntField
    {
        public PegPriceType()
            :base(Fields.CustomTags.PegPriceType) {}
        public PegPriceType(int val)
            :base(Fields.CustomTags.PegPriceType, val) {}


        // Field Enumerations
        public const int LAST_PEG = 1;
        public const int MID_PRICE_PEG = 2;
        public const int OPENING_PEG = 3;
        public const int MARKET_PEG = 4;
        public const int PRIMARY_PEG = 5;
        public const int PEG_TO_VWAP = 7;
        public const int TRAILING_STOP_PEG = 8;
        public const int PEG_TO_LIMIT_PRICE = 9;
        public const int FIXED_PEG_TO_LOCAL_BEST_BID_OR_OFFER_AT_TIME_OF_ORDER = 6;
    }


    /// <summary>
    /// PeggedRefPrice Field
    /// </summary>/
    public sealed class PeggedRefPrice : QuickFix.Fields.DecimalField
    {
        public PeggedRefPrice()
            :base(Fields.CustomTags.PeggedRefPrice) {}
        public PeggedRefPrice(Decimal val)
            :base(Fields.CustomTags.PeggedRefPrice, val) {}

    }


    /// <summary>
    /// PegSecurityIDSource Field
    /// </summary>/
    public sealed class PegSecurityIDSource : QuickFix.Fields.StringField
    {
        public PegSecurityIDSource()
            :base(Fields.CustomTags.PegSecurityIDSource) {}
        public PegSecurityIDSource(string val)
            :base(Fields.CustomTags.PegSecurityIDSource, val) {}

    }


    /// <summary>
    /// PegSecurityID Field
    /// </summary>/
    public sealed class PegSecurityID : QuickFix.Fields.StringField
    {
        public PegSecurityID()
            :base(Fields.CustomTags.PegSecurityID) {}
        public PegSecurityID(string val)
            :base(Fields.CustomTags.PegSecurityID, val) {}

    }


    /// <summary>
    /// PegSymbol Field
    /// </summary>/
    public sealed class PegSymbol : QuickFix.Fields.StringField
    {
        public PegSymbol()
            :base(Fields.CustomTags.PegSymbol) {}
        public PegSymbol(string val)
            :base(Fields.CustomTags.PegSymbol, val) {}

    }


    /// <summary>
    /// PegSecurityDesc Field
    /// </summary>/
    public sealed class PegSecurityDesc : QuickFix.Fields.StringField
    {
        public PegSecurityDesc()
            :base(Fields.CustomTags.PegSecurityDesc) {}
        public PegSecurityDesc(string val)
            :base(Fields.CustomTags.PegSecurityDesc, val) {}

    }


    /// <summary>
    /// TriggerAction Field
    /// </summary>/
    public sealed class TriggerAction : QuickFix.Fields.CharField
    {
        public TriggerAction()
            :base(Fields.CustomTags.TriggerAction) {}
        public TriggerAction(char val)
            :base(Fields.CustomTags.TriggerAction, val) {}


        // Field Enumerations
        public const char ACTIVATE = '1';
        public const char MODIFY = '2';
        public const char CANCEL = '3';
    }


    /// <summary>
    /// TriggerPrice Field
    /// </summary>/
    public sealed class TriggerPrice : QuickFix.Fields.DecimalField
    {
        public TriggerPrice()
            :base(Fields.CustomTags.TriggerPrice) {}
        public TriggerPrice(Decimal val)
            :base(Fields.CustomTags.TriggerPrice, val) {}

    }


    /// <summary>
    /// TriggerSymbol Field
    /// </summary>/
    public sealed class TriggerSymbol : QuickFix.Fields.StringField
    {
        public TriggerSymbol()
            :base(Fields.CustomTags.TriggerSymbol) {}
        public TriggerSymbol(string val)
            :base(Fields.CustomTags.TriggerSymbol, val) {}

    }


    /// <summary>
    /// TriggerSecurityID Field
    /// </summary>/
    public sealed class TriggerSecurityID : QuickFix.Fields.StringField
    {
        public TriggerSecurityID()
            :base(Fields.CustomTags.TriggerSecurityID) {}
        public TriggerSecurityID(string val)
            :base(Fields.CustomTags.TriggerSecurityID, val) {}

    }


    /// <summary>
    /// TriggerSecurityIDSource Field
    /// </summary>/
    public sealed class TriggerSecurityIDSource : QuickFix.Fields.StringField
    {
        public TriggerSecurityIDSource()
            :base(Fields.CustomTags.TriggerSecurityIDSource) {}
        public TriggerSecurityIDSource(string val)
            :base(Fields.CustomTags.TriggerSecurityIDSource, val) {}

    }


    /// <summary>
    /// TriggerSecurityDesc Field
    /// </summary>/
    public sealed class TriggerSecurityDesc : QuickFix.Fields.StringField
    {
        public TriggerSecurityDesc()
            :base(Fields.CustomTags.TriggerSecurityDesc) {}
        public TriggerSecurityDesc(string val)
            :base(Fields.CustomTags.TriggerSecurityDesc, val) {}

    }


    /// <summary>
    /// TriggerPriceTypeScope Field
    /// </summary>/
    public sealed class TriggerPriceTypeScope : QuickFix.Fields.CharField
    {
        public TriggerPriceTypeScope()
            :base(Fields.CustomTags.TriggerPriceTypeScope) {}
        public TriggerPriceTypeScope(char val)
            :base(Fields.CustomTags.TriggerPriceTypeScope, val) {}


        // Field Enumerations
        public const char NONE = '0';
        public const char LOCAL = '1';
        public const char NATIONAL = '2';
        public const char GLOBAL = '3';
    }


    /// <summary>
    /// TriggerPriceDirection Field
    /// </summary>/
    public sealed class TriggerPriceDirection : QuickFix.Fields.CharField
    {
        public TriggerPriceDirection()
            :base(Fields.CustomTags.TriggerPriceDirection) {}
        public TriggerPriceDirection(char val)
            :base(Fields.CustomTags.TriggerPriceDirection, val) {}


        // Field Enumerations
        public const char TRIGGER_IF_THE_PRICE_OF_THE_SPECIFIED_TYPE_GOES_UP_TO_OR_THROUGH_THE_SPECIFIED_TRIGGER_PRICE = 'U';
        public const char TRIGGER_IF_THE_PRICE_OF_THE_SPECIFIED_TYPE_GOES_DOWN_TO_OR_THROUGH_THE_SPECIFIED_TRIGGER_PRICE = 'D';
    }


    /// <summary>
    /// TriggerNewPrice Field
    /// </summary>/
    public sealed class TriggerNewPrice : QuickFix.Fields.DecimalField
    {
        public TriggerNewPrice()
            :base(Fields.CustomTags.TriggerNewPrice) {}
        public TriggerNewPrice(Decimal val)
            :base(Fields.CustomTags.TriggerNewPrice, val) {}

    }


    /// <summary>
    /// TriggerOrderType Field
    /// </summary>/
    public sealed class TriggerOrderType : QuickFix.Fields.CharField
    {
        public TriggerOrderType()
            :base(Fields.CustomTags.TriggerOrderType) {}
        public TriggerOrderType(char val)
            :base(Fields.CustomTags.TriggerOrderType, val) {}


        // Field Enumerations
        public const char MARKET = '1';
        public const char LIMIT = '2';
    }


    /// <summary>
    /// TriggerNewQty Field
    /// </summary>/
    public sealed class TriggerNewQty : QuickFix.Fields.DecimalField
    {
        public TriggerNewQty()
            :base(Fields.CustomTags.TriggerNewQty) {}
        public TriggerNewQty(Decimal val)
            :base(Fields.CustomTags.TriggerNewQty, val) {}

    }


    /// <summary>
    /// TriggerTradingSessionID Field
    /// </summary>/
    public sealed class TriggerTradingSessionID : QuickFix.Fields.StringField
    {
        public TriggerTradingSessionID()
            :base(Fields.CustomTags.TriggerTradingSessionID) {}
        public TriggerTradingSessionID(string val)
            :base(Fields.CustomTags.TriggerTradingSessionID, val) {}

    }


    /// <summary>
    /// TriggerTradingSessionSubID Field
    /// </summary>/
    public sealed class TriggerTradingSessionSubID : QuickFix.Fields.StringField
    {
        public TriggerTradingSessionSubID()
            :base(Fields.CustomTags.TriggerTradingSessionSubID) {}
        public TriggerTradingSessionSubID(string val)
            :base(Fields.CustomTags.TriggerTradingSessionSubID, val) {}

    }


    /// <summary>
    /// OrderCategory Field
    /// </summary>/
    public sealed class OrderCategory : QuickFix.Fields.CharField
    {
        public OrderCategory()
            :base(Fields.CustomTags.OrderCategory) {}
        public OrderCategory(char val)
            :base(Fields.CustomTags.OrderCategory, val) {}


        // Field Enumerations
        public const char ORDER = '1';
        public const char QUOTE = '2';
        public const char PRIVATELY_NEGOTIATED_TRADE = '3';
        public const char MULTILEG_ORDER = '4';
        public const char LINKED_ORDER = '5';
        public const char QUOTE_REQUEST = '6';
        public const char IMPLIED_ORDER = '7';
        public const char CROSS_ORDER = '8';
        public const char STREAMING_PRICE = '9';
    }


    /// <summary>
    /// NoRootPartyIDs Field
    /// </summary>/
    public sealed class NoRootPartyIDs : QuickFix.Fields.IntField
    {
        public NoRootPartyIDs()
            :base(Fields.CustomTags.NoRootPartyIDs) {}
        public NoRootPartyIDs(int val)
            :base(Fields.CustomTags.NoRootPartyIDs, val) {}

    }


    /// <summary>
    /// RootPartyID Field
    /// </summary>/
    public sealed class RootPartyID : QuickFix.Fields.StringField
    {
        public RootPartyID()
            :base(Fields.CustomTags.RootPartyID) {}
        public RootPartyID(string val)
            :base(Fields.CustomTags.RootPartyID, val) {}

    }


    /// <summary>
    /// RootPartyIDSource Field
    /// </summary>/
    public sealed class RootPartyIDSource : QuickFix.Fields.CharField
    {
        public RootPartyIDSource()
            :base(Fields.CustomTags.RootPartyIDSource) {}
        public RootPartyIDSource(char val)
            :base(Fields.CustomTags.RootPartyIDSource, val) {}

    }


    /// <summary>
    /// RootPartyRole Field
    /// </summary>/
    public sealed class RootPartyRole : QuickFix.Fields.IntField
    {
        public RootPartyRole()
            :base(Fields.CustomTags.RootPartyRole) {}
        public RootPartyRole(int val)
            :base(Fields.CustomTags.RootPartyRole, val) {}

    }


    /// <summary>
    /// NoRootPartySubIDs Field
    /// </summary>/
    public sealed class NoRootPartySubIDs : QuickFix.Fields.IntField
    {
        public NoRootPartySubIDs()
            :base(Fields.CustomTags.NoRootPartySubIDs) {}
        public NoRootPartySubIDs(int val)
            :base(Fields.CustomTags.NoRootPartySubIDs, val) {}

    }


    /// <summary>
    /// RootPartySubID Field
    /// </summary>/
    public sealed class RootPartySubID : QuickFix.Fields.StringField
    {
        public RootPartySubID()
            :base(Fields.CustomTags.RootPartySubID) {}
        public RootPartySubID(string val)
            :base(Fields.CustomTags.RootPartySubID, val) {}

    }


    /// <summary>
    /// RootPartySubIDType Field
    /// </summary>/
    public sealed class RootPartySubIDType : QuickFix.Fields.IntField
    {
        public RootPartySubIDType()
            :base(Fields.CustomTags.RootPartySubIDType) {}
        public RootPartySubIDType(int val)
            :base(Fields.CustomTags.RootPartySubIDType, val) {}

    }


    /// <summary>
    /// OrigTradeHandlingInstr Field
    /// </summary>/
    public sealed class OrigTradeHandlingInstr : QuickFix.Fields.CharField
    {
        public OrigTradeHandlingInstr()
            :base(Fields.CustomTags.OrigTradeHandlingInstr) {}
        public OrigTradeHandlingInstr(char val)
            :base(Fields.CustomTags.OrigTradeHandlingInstr, val) {}

    }


    /// <summary>
    /// OrigSecondaryTradeID Field
    /// </summary>/
    public sealed class OrigSecondaryTradeID : QuickFix.Fields.StringField
    {
        public OrigSecondaryTradeID()
            :base(Fields.CustomTags.OrigSecondaryTradeID) {}
        public OrigSecondaryTradeID(string val)
            :base(Fields.CustomTags.OrigSecondaryTradeID, val) {}

    }


    /// <summary>
    /// ApplVerID Field
    /// </summary>/
    public sealed class ApplVerID : QuickFix.Fields.StringField
    {
        public ApplVerID()
            :base(Fields.CustomTags.ApplVerID) {}
        public ApplVerID(string val)
            :base(Fields.CustomTags.ApplVerID, val) {}


        // Field Enumerations
        public const string FIX27 = "0";
        public const string FIX30 = "1";
        public const string FIX40 = "2";
        public const string FIX41 = "3";
        public const string FIX42 = "4";
        public const string FIX43 = "5";
        public const string FIX44 = "6";
        public const string FIX50 = "7";
        public const string FIX50SP1 = "8";
        public const string FIX50SP2 = "9";
    }


    /// <summary>
    /// CstmApplVerID Field
    /// </summary>/
    public sealed class CstmApplVerID : QuickFix.Fields.StringField
    {
        public CstmApplVerID()
            :base(Fields.CustomTags.CstmApplVerID) {}
        public CstmApplVerID(string val)
            :base(Fields.CustomTags.CstmApplVerID, val) {}

    }


    /// <summary>
    /// RefApplVerID Field
    /// </summary>/
    public sealed class RefApplVerID : QuickFix.Fields.StringField
    {
        public RefApplVerID()
            :base(Fields.CustomTags.RefApplVerID) {}
        public RefApplVerID(string val)
            :base(Fields.CustomTags.RefApplVerID, val) {}

    }


    /// <summary>
    /// RefCstmApplVerID Field
    /// </summary>/
    public sealed class RefCstmApplVerID : QuickFix.Fields.StringField
    {
        public RefCstmApplVerID()
            :base(Fields.CustomTags.RefCstmApplVerID) {}
        public RefCstmApplVerID(string val)
            :base(Fields.CustomTags.RefCstmApplVerID, val) {}

    }


    /// <summary>
    /// TZTransactTime Field
    /// </summary>/
    public sealed class TZTransactTime : QuickFix.Fields.DateTimeField
    {
        public TZTransactTime()
            :base(Fields.CustomTags.TZTransactTime) {}
        public TZTransactTime(DateTime val)
            :base(Fields.CustomTags.TZTransactTime, val) {}
        public TZTransactTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.TZTransactTime, val, showMilliseconds) {}
		public TZTransactTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.TZTransactTime, val, precision) {}

    }


    /// <summary>
    /// ExDestinationIDSource Field
    /// </summary>/
    public sealed class ExDestinationIDSource : QuickFix.Fields.CharField
    {
        public ExDestinationIDSource()
            :base(Fields.CustomTags.ExDestinationIDSource) {}
        public ExDestinationIDSource(char val)
            :base(Fields.CustomTags.ExDestinationIDSource, val) {}


        // Field Enumerations
        public const char BIC = 'B';
        public const char GENERALLY_ACCEPTED_MARKET_PARTICIPANT_IDENTIFIER = 'C';
        public const char PROPRIETARY = 'D';
        public const char ISO_COUNTRY_CODE = 'E';
        public const char MIC = 'G';
    }


    /// <summary>
    /// ReportedPxDiff Field
    /// </summary>/
    public sealed class ReportedPxDiff : QuickFix.Fields.BooleanField
    {
        public ReportedPxDiff()
            :base(Fields.CustomTags.ReportedPxDiff) {}
        public ReportedPxDiff(Boolean val)
            :base(Fields.CustomTags.ReportedPxDiff, val) {}

    }


    /// <summary>
    /// RptSys Field
    /// </summary>/
    public sealed class RptSys : QuickFix.Fields.StringField
    {
        public RptSys()
            :base(Fields.CustomTags.RptSys) {}
        public RptSys(string val)
            :base(Fields.CustomTags.RptSys, val) {}

    }


    /// <summary>
    /// AllocClearingFeeIndicator Field
    /// </summary>/
    public sealed class AllocClearingFeeIndicator : QuickFix.Fields.StringField
    {
        public AllocClearingFeeIndicator()
            :base(Fields.CustomTags.AllocClearingFeeIndicator) {}
        public AllocClearingFeeIndicator(string val)
            :base(Fields.CustomTags.AllocClearingFeeIndicator, val) {}

    }


    /// <summary>
    /// DefaultApplVerID Field
    /// </summary>/
    public sealed class DefaultApplVerID : QuickFix.Fields.StringField
    {
        public DefaultApplVerID()
            :base(Fields.CustomTags.DefaultApplVerID) {}
        public DefaultApplVerID(string val)
            :base(Fields.CustomTags.DefaultApplVerID, val) {}

    }


    /// <summary>
    /// ExchangeSpecialInstructions Field
    /// </summary>/
    public sealed class ExchangeSpecialInstructions : QuickFix.Fields.StringField
    {
        public ExchangeSpecialInstructions()
            :base(Fields.CustomTags.ExchangeSpecialInstructions) {}
        public ExchangeSpecialInstructions(string val)
            :base(Fields.CustomTags.ExchangeSpecialInstructions, val) {}

    }


    /// <summary>
    /// SecurityStatus Field
    /// </summary>/
    public sealed class SecurityStatus : QuickFix.Fields.StringField
    {
        public SecurityStatus()
            :base(Fields.CustomTags.SecurityStatus) {}
        public SecurityStatus(string val)
            :base(Fields.CustomTags.SecurityStatus, val) {}


        // Field Enumerations
        public const string ACTIVE = "1";
        public const string INACTIVE = "2";
    }


    /// <summary>
    /// ExpirationQtyType Field
    /// </summary>/
    public sealed class ExpirationQtyType : QuickFix.Fields.IntField
    {
        public ExpirationQtyType()
            :base(Fields.CustomTags.ExpirationQtyType) {}
        public ExpirationQtyType(int val)
            :base(Fields.CustomTags.ExpirationQtyType, val) {}


        // Field Enumerations
        public const int AUTO_EXERCISE = 1;
        public const int NON_AUTO_EXERCISE = 2;
        public const int FINAL_WILL_BE_EXERCISED = 3;
        public const int CONTRARY_INTENTION = 4;
        public const int DIFFERENCE = 5;
    }


    /// <summary>
    /// MaxTradeVol Field
    /// </summary>/
    public sealed class MaxTradeVol : QuickFix.Fields.DecimalField
    {
        public MaxTradeVol()
            :base(Fields.CustomTags.MaxTradeVol) {}
        public MaxTradeVol(Decimal val)
            :base(Fields.CustomTags.MaxTradeVol, val) {}

    }


    /// <summary>
    /// NoMDFeedTypes Field
    /// </summary>/
    public sealed class NoMDFeedTypes : QuickFix.Fields.IntField
    {
        public NoMDFeedTypes()
            :base(Fields.CustomTags.NoMDFeedTypes) {}
        public NoMDFeedTypes(int val)
            :base(Fields.CustomTags.NoMDFeedTypes, val) {}

    }


    /// <summary>
    /// MatchAlgorithm Field
    /// </summary>/
    public sealed class MatchAlgorithm : QuickFix.Fields.StringField
    {
        public MatchAlgorithm()
            :base(Fields.CustomTags.MatchAlgorithm) {}
        public MatchAlgorithm(string val)
            :base(Fields.CustomTags.MatchAlgorithm, val) {}

    }


    /// <summary>
    /// MaxPriceVariation Field
    /// </summary>/
    public sealed class MaxPriceVariation : QuickFix.Fields.DecimalField
    {
        public MaxPriceVariation()
            :base(Fields.CustomTags.MaxPriceVariation) {}
        public MaxPriceVariation(Decimal val)
            :base(Fields.CustomTags.MaxPriceVariation, val) {}

    }


    /// <summary>
    /// ImpliedMarketIndicator Field
    /// </summary>/
    public sealed class ImpliedMarketIndicator : QuickFix.Fields.IntField
    {
        public ImpliedMarketIndicator()
            :base(Fields.CustomTags.ImpliedMarketIndicator) {}
        public ImpliedMarketIndicator(int val)
            :base(Fields.CustomTags.ImpliedMarketIndicator, val) {}


        // Field Enumerations
        public const int NOT_IMPLIED = 0;
        public const int IMPLIED_IN = 1;
        public const int IMPLIED_OUT = 2;
        public const int BOTH_IMPLIED_IN_AND_IMPLIED_OUT = 3;
    }


    /// <summary>
    /// EventTime Field
    /// </summary>/
    public sealed class EventTime : QuickFix.Fields.DateTimeField
    {
        public EventTime()
            :base(Fields.CustomTags.EventTime) {}
        public EventTime(DateTime val)
            :base(Fields.CustomTags.EventTime, val) {}
        public EventTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.EventTime, val, showMilliseconds) {}
		public EventTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.EventTime, val, precision) {}

    }


    /// <summary>
    /// MinPriceIncrementAmount Field
    /// </summary>/
    public sealed class MinPriceIncrementAmount : QuickFix.Fields.DecimalField
    {
        public MinPriceIncrementAmount()
            :base(Fields.CustomTags.MinPriceIncrementAmount) {}
        public MinPriceIncrementAmount(Decimal val)
            :base(Fields.CustomTags.MinPriceIncrementAmount, val) {}

    }


    /// <summary>
    /// UnitOfMeasureQty Field
    /// </summary>/
    public sealed class UnitOfMeasureQty : QuickFix.Fields.DecimalField
    {
        public UnitOfMeasureQty()
            :base(Fields.CustomTags.UnitOfMeasureQty) {}
        public UnitOfMeasureQty(Decimal val)
            :base(Fields.CustomTags.UnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// LowLimitPrice Field
    /// </summary>/
    public sealed class LowLimitPrice : QuickFix.Fields.DecimalField
    {
        public LowLimitPrice()
            :base(Fields.CustomTags.LowLimitPrice) {}
        public LowLimitPrice(Decimal val)
            :base(Fields.CustomTags.LowLimitPrice, val) {}

    }


    /// <summary>
    /// HighLimitPrice Field
    /// </summary>/
    public sealed class HighLimitPrice : QuickFix.Fields.DecimalField
    {
        public HighLimitPrice()
            :base(Fields.CustomTags.HighLimitPrice) {}
        public HighLimitPrice(Decimal val)
            :base(Fields.CustomTags.HighLimitPrice, val) {}

    }


    /// <summary>
    /// TradingReferencePrice Field
    /// </summary>/
    public sealed class TradingReferencePrice : QuickFix.Fields.DecimalField
    {
        public TradingReferencePrice()
            :base(Fields.CustomTags.TradingReferencePrice) {}
        public TradingReferencePrice(Decimal val)
            :base(Fields.CustomTags.TradingReferencePrice, val) {}

    }


    /// <summary>
    /// SecurityGroup Field
    /// </summary>/
    public sealed class SecurityGroup : QuickFix.Fields.StringField
    {
        public SecurityGroup()
            :base(Fields.CustomTags.SecurityGroup) {}
        public SecurityGroup(string val)
            :base(Fields.CustomTags.SecurityGroup, val) {}

    }


    /// <summary>
    /// LegNumber Field
    /// </summary>/
    public sealed class LegNumber : QuickFix.Fields.IntField
    {
        public LegNumber()
            :base(Fields.CustomTags.LegNumber) {}
        public LegNumber(int val)
            :base(Fields.CustomTags.LegNumber, val) {}

    }


    /// <summary>
    /// SettlementCycleNo Field
    /// </summary>/
    public sealed class SettlementCycleNo : QuickFix.Fields.IntField
    {
        public SettlementCycleNo()
            :base(Fields.CustomTags.SettlementCycleNo) {}
        public SettlementCycleNo(int val)
            :base(Fields.CustomTags.SettlementCycleNo, val) {}

    }


    /// <summary>
    /// SideCurrency Field
    /// </summary>/
    public sealed class SideCurrency : QuickFix.Fields.StringField
    {
        public SideCurrency()
            :base(Fields.CustomTags.SideCurrency) {}
        public SideCurrency(string val)
            :base(Fields.CustomTags.SideCurrency, val) {}

    }


    /// <summary>
    /// SideSettlCurrency Field
    /// </summary>/
    public sealed class SideSettlCurrency : QuickFix.Fields.StringField
    {
        public SideSettlCurrency()
            :base(Fields.CustomTags.SideSettlCurrency) {}
        public SideSettlCurrency(string val)
            :base(Fields.CustomTags.SideSettlCurrency, val) {}

    }


    /// <summary>
    /// ApplExtID Field
    /// </summary>/
    public sealed class ApplExtID : QuickFix.Fields.IntField
    {
        public ApplExtID()
            :base(Fields.CustomTags.ApplExtID) {}
        public ApplExtID(int val)
            :base(Fields.CustomTags.ApplExtID, val) {}

    }


    /// <summary>
    /// CcyAmt Field
    /// </summary>/
    public sealed class CcyAmt : QuickFix.Fields.DecimalField
    {
        public CcyAmt()
            :base(Fields.CustomTags.CcyAmt) {}
        public CcyAmt(Decimal val)
            :base(Fields.CustomTags.CcyAmt, val) {}

    }


    /// <summary>
    /// NoSettlDetails Field
    /// </summary>/
    public sealed class NoSettlDetails : QuickFix.Fields.IntField
    {
        public NoSettlDetails()
            :base(Fields.CustomTags.NoSettlDetails) {}
        public NoSettlDetails(int val)
            :base(Fields.CustomTags.NoSettlDetails, val) {}

    }


    /// <summary>
    /// SettlObligMode Field
    /// </summary>/
    public sealed class SettlObligMode : QuickFix.Fields.IntField
    {
        public SettlObligMode()
            :base(Fields.CustomTags.SettlObligMode) {}
        public SettlObligMode(int val)
            :base(Fields.CustomTags.SettlObligMode, val) {}


        // Field Enumerations
        public const int PRELIMINARY = 1;
        public const int FINAL = 2;
    }


    /// <summary>
    /// SettlObligMsgID Field
    /// </summary>/
    public sealed class SettlObligMsgID : QuickFix.Fields.StringField
    {
        public SettlObligMsgID()
            :base(Fields.CustomTags.SettlObligMsgID) {}
        public SettlObligMsgID(string val)
            :base(Fields.CustomTags.SettlObligMsgID, val) {}

    }


    /// <summary>
    /// SettlObligID Field
    /// </summary>/
    public sealed class SettlObligID : QuickFix.Fields.StringField
    {
        public SettlObligID()
            :base(Fields.CustomTags.SettlObligID) {}
        public SettlObligID(string val)
            :base(Fields.CustomTags.SettlObligID, val) {}

    }


    /// <summary>
    /// SettlObligTransType Field
    /// </summary>/
    public sealed class SettlObligTransType : QuickFix.Fields.CharField
    {
        public SettlObligTransType()
            :base(Fields.CustomTags.SettlObligTransType) {}
        public SettlObligTransType(char val)
            :base(Fields.CustomTags.SettlObligTransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NEW = 'N';
        public const char REPLACE = 'R';
        public const char RESTATE = 'T';
    }


    /// <summary>
    /// SettlObligRefID Field
    /// </summary>/
    public sealed class SettlObligRefID : QuickFix.Fields.StringField
    {
        public SettlObligRefID()
            :base(Fields.CustomTags.SettlObligRefID) {}
        public SettlObligRefID(string val)
            :base(Fields.CustomTags.SettlObligRefID, val) {}

    }


    /// <summary>
    /// SettlObligSource Field
    /// </summary>/
    public sealed class SettlObligSource : QuickFix.Fields.CharField
    {
        public SettlObligSource()
            :base(Fields.CustomTags.SettlObligSource) {}
        public SettlObligSource(char val)
            :base(Fields.CustomTags.SettlObligSource, val) {}


        // Field Enumerations
        public const char INSTRUCTIONS_OF_BROKER = '1';
        public const char INSTRUCTIONS_FOR_INSTITUTION = '2';
        public const char INVESTOR = '3';
    }


    /// <summary>
    /// NoSettlOblig Field
    /// </summary>/
    public sealed class NoSettlOblig : QuickFix.Fields.IntField
    {
        public NoSettlOblig()
            :base(Fields.CustomTags.NoSettlOblig) {}
        public NoSettlOblig(int val)
            :base(Fields.CustomTags.NoSettlOblig, val) {}

    }


    /// <summary>
    /// QuoteMsgID Field
    /// </summary>/
    public sealed class QuoteMsgID : QuickFix.Fields.StringField
    {
        public QuoteMsgID()
            :base(Fields.CustomTags.QuoteMsgID) {}
        public QuoteMsgID(string val)
            :base(Fields.CustomTags.QuoteMsgID, val) {}

    }


    /// <summary>
    /// QuoteEntryStatus Field
    /// </summary>/
    public sealed class QuoteEntryStatus : QuickFix.Fields.IntField
    {
        public QuoteEntryStatus()
            :base(Fields.CustomTags.QuoteEntryStatus) {}
        public QuoteEntryStatus(int val)
            :base(Fields.CustomTags.QuoteEntryStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int REJECTED = 5;
        public const int REMOVED_FROM_MARKET = 6;
        public const int EXPIRED = 7;
        public const int LOCKED_MARKET_WARNING = 12;
        public const int CROSS_MARKET_WARNING = 13;
        public const int CANCELED_DUE_TO_LOCK_MARKET = 14;
        public const int CANCELED_DUE_TO_CROSS_MARKET = 15;
        public const int ACTIVE = 16;
    }


    /// <summary>
    /// TotNoCxldQuotes Field
    /// </summary>/
    public sealed class TotNoCxldQuotes : QuickFix.Fields.IntField
    {
        public TotNoCxldQuotes()
            :base(Fields.CustomTags.TotNoCxldQuotes) {}
        public TotNoCxldQuotes(int val)
            :base(Fields.CustomTags.TotNoCxldQuotes, val) {}

    }


    /// <summary>
    /// TotNoAccQuotes Field
    /// </summary>/
    public sealed class TotNoAccQuotes : QuickFix.Fields.IntField
    {
        public TotNoAccQuotes()
            :base(Fields.CustomTags.TotNoAccQuotes) {}
        public TotNoAccQuotes(int val)
            :base(Fields.CustomTags.TotNoAccQuotes, val) {}

    }


    /// <summary>
    /// TotNoRejQuotes Field
    /// </summary>/
    public sealed class TotNoRejQuotes : QuickFix.Fields.IntField
    {
        public TotNoRejQuotes()
            :base(Fields.CustomTags.TotNoRejQuotes) {}
        public TotNoRejQuotes(int val)
            :base(Fields.CustomTags.TotNoRejQuotes, val) {}

    }


    /// <summary>
    /// PrivateQuote Field
    /// </summary>/
    public sealed class PrivateQuote : QuickFix.Fields.BooleanField
    {
        public PrivateQuote()
            :base(Fields.CustomTags.PrivateQuote) {}
        public PrivateQuote(Boolean val)
            :base(Fields.CustomTags.PrivateQuote, val) {}

    }


    /// <summary>
    /// RespondentType Field
    /// </summary>/
    public sealed class RespondentType : QuickFix.Fields.IntField
    {
        public RespondentType()
            :base(Fields.CustomTags.RespondentType) {}
        public RespondentType(int val)
            :base(Fields.CustomTags.RespondentType, val) {}


        // Field Enumerations
        public const int ALL_MARKET_PARTICIPANTS = 1;
        public const int SPECIFIED_MARKET_PARTICIPANTS = 2;
        public const int ALL_MARKET_MAKERS = 3;
        public const int PRIMARY_MARKET_MAKER = 4;
    }


    /// <summary>
    /// MDSubBookType Field
    /// </summary>/
    public sealed class MDSubBookType : QuickFix.Fields.IntField
    {
        public MDSubBookType()
            :base(Fields.CustomTags.MDSubBookType) {}
        public MDSubBookType(int val)
            :base(Fields.CustomTags.MDSubBookType, val) {}

    }


    /// <summary>
    /// SecurityTradingEvent Field
    /// </summary>/
    public sealed class SecurityTradingEvent : QuickFix.Fields.IntField
    {
        public SecurityTradingEvent()
            :base(Fields.CustomTags.SecurityTradingEvent) {}
        public SecurityTradingEvent(int val)
            :base(Fields.CustomTags.SecurityTradingEvent, val) {}


        // Field Enumerations
        public const int ORDER_IMBALANCE_AUCTION_IS_EXTENDED = 1;
        public const int TRADING_RESUMES = 2;
        public const int PRICE_VOLATILITY_INTERRUPTION = 3;
        public const int CHANGE_OF_TRADING_SESSION = 4;
        public const int CHANGE_OF_TRADING_SUBSESSION = 5;
        public const int CHANGE_OF_SECURITY_TRADING_STATUS = 6;
        public const int CHANGE_OF_BOOK_TYPE = 7;
        public const int CHANGE_OF_MARKET_DEPTH = 8;
        public const int CHANGE_OF_SECURITY_STATUS = 6;
    }


    /// <summary>
    /// NoStatsIndicators Field
    /// </summary>/
    public sealed class NoStatsIndicators : QuickFix.Fields.IntField
    {
        public NoStatsIndicators()
            :base(Fields.CustomTags.NoStatsIndicators) {}
        public NoStatsIndicators(int val)
            :base(Fields.CustomTags.NoStatsIndicators, val) {}

    }


    /// <summary>
    /// StatsType Field
    /// </summary>/
    public sealed class StatsType : QuickFix.Fields.IntField
    {
        public StatsType()
            :base(Fields.CustomTags.StatsType) {}
        public StatsType(int val)
            :base(Fields.CustomTags.StatsType, val) {}


        // Field Enumerations
        public const int EXCHANGE_LAST = 1;
        public const int HIGH = 2;
        public const int AVERAGE_PRICE = 3;
        public const int TURNOVER = 4;
    }


    /// <summary>
    /// NoOfSecSizes Field
    /// </summary>/
    public sealed class NoOfSecSizes : QuickFix.Fields.IntField
    {
        public NoOfSecSizes()
            :base(Fields.CustomTags.NoOfSecSizes) {}
        public NoOfSecSizes(int val)
            :base(Fields.CustomTags.NoOfSecSizes, val) {}

    }


    /// <summary>
    /// MDSecSizeType Field
    /// </summary>/
    public sealed class MDSecSizeType : QuickFix.Fields.IntField
    {
        public MDSecSizeType()
            :base(Fields.CustomTags.MDSecSizeType) {}
        public MDSecSizeType(int val)
            :base(Fields.CustomTags.MDSecSizeType, val) {}


        // Field Enumerations
        public const int CUSTOMER = 1;
    }


    /// <summary>
    /// MDSecSize Field
    /// </summary>/
    public sealed class MDSecSize : QuickFix.Fields.DecimalField
    {
        public MDSecSize()
            :base(Fields.CustomTags.MDSecSize) {}
        public MDSecSize(Decimal val)
            :base(Fields.CustomTags.MDSecSize, val) {}

    }


    /// <summary>
    /// ApplID Field
    /// </summary>/
    public sealed class ApplID : QuickFix.Fields.StringField
    {
        public ApplID()
            :base(Fields.CustomTags.ApplID) {}
        public ApplID(string val)
            :base(Fields.CustomTags.ApplID, val) {}

    }


    /// <summary>
    /// ApplSeqNum Field
    /// </summary>/
    public sealed class ApplSeqNum : QuickFix.Fields.IntField
    {
        public ApplSeqNum()
            :base(Fields.CustomTags.ApplSeqNum) {}
        public ApplSeqNum(int val)
            :base(Fields.CustomTags.ApplSeqNum, val) {}

    }


    /// <summary>
    /// ApplBegSeqNum Field
    /// </summary>/
    public sealed class ApplBegSeqNum : QuickFix.Fields.IntField
    {
        public ApplBegSeqNum()
            :base(Fields.CustomTags.ApplBegSeqNum) {}
        public ApplBegSeqNum(int val)
            :base(Fields.CustomTags.ApplBegSeqNum, val) {}

    }


    /// <summary>
    /// ApplEndSeqNum Field
    /// </summary>/
    public sealed class ApplEndSeqNum : QuickFix.Fields.IntField
    {
        public ApplEndSeqNum()
            :base(Fields.CustomTags.ApplEndSeqNum) {}
        public ApplEndSeqNum(int val)
            :base(Fields.CustomTags.ApplEndSeqNum, val) {}

    }


    /// <summary>
    /// SecurityXMLLen Field
    /// </summary>/
    public sealed class SecurityXMLLen : QuickFix.Fields.IntField
    {
        public SecurityXMLLen()
            :base(Fields.CustomTags.SecurityXMLLen) {}
        public SecurityXMLLen(int val)
            :base(Fields.CustomTags.SecurityXMLLen, val) {}

    }


    /// <summary>
    /// SecurityXML Field
    /// </summary>/
    public sealed class SecurityXML : QuickFix.Fields.StringField
    {
        public SecurityXML()
            :base(Fields.CustomTags.SecurityXML) {}
        public SecurityXML(string val)
            :base(Fields.CustomTags.SecurityXML, val) {}

    }


    /// <summary>
    /// SecurityXMLSchema Field
    /// </summary>/
    public sealed class SecurityXMLSchema : QuickFix.Fields.StringField
    {
        public SecurityXMLSchema()
            :base(Fields.CustomTags.SecurityXMLSchema) {}
        public SecurityXMLSchema(string val)
            :base(Fields.CustomTags.SecurityXMLSchema, val) {}

    }


    /// <summary>
    /// RefreshIndicator Field
    /// </summary>/
    public sealed class RefreshIndicator : QuickFix.Fields.BooleanField
    {
        public RefreshIndicator()
            :base(Fields.CustomTags.RefreshIndicator) {}
        public RefreshIndicator(Boolean val)
            :base(Fields.CustomTags.RefreshIndicator, val) {}

    }


    /// <summary>
    /// TimeToExpiration Field
    /// </summary>/
    public sealed class TimeToExpiration : QuickFix.Fields.DecimalField
    {
        public TimeToExpiration()
            :base(Fields.CustomTags.TimeToExpiration) {}
        public TimeToExpiration(Decimal val)
            :base(Fields.CustomTags.TimeToExpiration, val) {}

    }


    /// <summary>
    /// PriceUnitOfMeasure Field
    /// </summary>/
    public sealed class PriceUnitOfMeasure : QuickFix.Fields.StringField
    {
        public PriceUnitOfMeasure()
            :base(Fields.CustomTags.PriceUnitOfMeasure) {}
        public PriceUnitOfMeasure(string val)
            :base(Fields.CustomTags.PriceUnitOfMeasure, val) {}

    }


    /// <summary>
    /// PriceUnitOfMeasureQty Field
    /// </summary>/
    public sealed class PriceUnitOfMeasureQty : QuickFix.Fields.DecimalField
    {
        public PriceUnitOfMeasureQty()
            :base(Fields.CustomTags.PriceUnitOfMeasureQty) {}
        public PriceUnitOfMeasureQty(Decimal val)
            :base(Fields.CustomTags.PriceUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// SettlMethod Field
    /// </summary>/
    public sealed class SettlMethod : QuickFix.Fields.CharField
    {
        public SettlMethod()
            :base(Fields.CustomTags.SettlMethod) {}
        public SettlMethod(char val)
            :base(Fields.CustomTags.SettlMethod, val) {}


        // Field Enumerations
        public const char CASH_SETTLEMENT_REQUIRED = 'C';
        public const char PHYSICAL_SETTLEMENT_REQUIRED = 'P';
    }


    /// <summary>
    /// ExerciseStyle Field
    /// </summary>/
    public sealed class ExerciseStyle : QuickFix.Fields.IntField
    {
        public ExerciseStyle()
            :base(Fields.CustomTags.ExerciseStyle) {}
        public ExerciseStyle(int val)
            :base(Fields.CustomTags.ExerciseStyle, val) {}


        // Field Enumerations
        public const int EUROPEAN = 0;
        public const int AMERICAN = 1;
        public const int BERMUDA = 2;
    }


    /// <summary>
    /// OptPayAmount Field
    /// </summary>/
    public sealed class OptPayAmount : QuickFix.Fields.DecimalField
    {
        public OptPayAmount()
            :base(Fields.CustomTags.OptPayAmount) {}
        public OptPayAmount(Decimal val)
            :base(Fields.CustomTags.OptPayAmount, val) {}

    }


    /// <summary>
    /// PriceQuoteMethod Field
    /// </summary>/
    public sealed class PriceQuoteMethod : QuickFix.Fields.StringField
    {
        public PriceQuoteMethod()
            :base(Fields.CustomTags.PriceQuoteMethod) {}
        public PriceQuoteMethod(string val)
            :base(Fields.CustomTags.PriceQuoteMethod, val) {}


        // Field Enumerations
        public const string STANDARD = "STD";
        public const string INDEX = "INX";
        public const string INTEREST_RATE_INDEX = "INT";
        public const string PERCENT_OF_PAR = "PCTPAR";
    }


    /// <summary>
    /// FuturesValuationMethod Field
    /// </summary>/
    public sealed class FuturesValuationMethod : QuickFix.Fields.StringField
    {
        public FuturesValuationMethod()
            :base(Fields.CustomTags.FuturesValuationMethod) {}
        public FuturesValuationMethod(string val)
            :base(Fields.CustomTags.FuturesValuationMethod, val) {}


        // Field Enumerations
        public const string PREMIUM_STYLE = "EQTY";
        public const string FUTURES_STYLE_MARK_TO_MARKET = "FUT";
        public const string FUTURES_STYLE_WITH_AN_ATTACHED_CASH_ADJUSTMENT = "FUTDA";
    }


    /// <summary>
    /// ListMethod Field
    /// </summary>/
    public sealed class ListMethod : QuickFix.Fields.IntField
    {
        public ListMethod()
            :base(Fields.CustomTags.ListMethod) {}
        public ListMethod(int val)
            :base(Fields.CustomTags.ListMethod, val) {}


        // Field Enumerations
        public const int PRE_LISTED_ONLY = 0;
        public const int USER_REQUESTED = 1;
    }


    /// <summary>
    /// CapPrice Field
    /// </summary>/
    public sealed class CapPrice : QuickFix.Fields.DecimalField
    {
        public CapPrice()
            :base(Fields.CustomTags.CapPrice) {}
        public CapPrice(Decimal val)
            :base(Fields.CustomTags.CapPrice, val) {}

    }


    /// <summary>
    /// FloorPrice Field
    /// </summary>/
    public sealed class FloorPrice : QuickFix.Fields.DecimalField
    {
        public FloorPrice()
            :base(Fields.CustomTags.FloorPrice) {}
        public FloorPrice(Decimal val)
            :base(Fields.CustomTags.FloorPrice, val) {}

    }


    /// <summary>
    /// NoStrikeRules Field
    /// </summary>/
    public sealed class NoStrikeRules : QuickFix.Fields.IntField
    {
        public NoStrikeRules()
            :base(Fields.CustomTags.NoStrikeRules) {}
        public NoStrikeRules(int val)
            :base(Fields.CustomTags.NoStrikeRules, val) {}

    }


    /// <summary>
    /// StartStrikePxRange Field
    /// </summary>/
    public sealed class StartStrikePxRange : QuickFix.Fields.DecimalField
    {
        public StartStrikePxRange()
            :base(Fields.CustomTags.StartStrikePxRange) {}
        public StartStrikePxRange(Decimal val)
            :base(Fields.CustomTags.StartStrikePxRange, val) {}

    }


    /// <summary>
    /// EndStrikePxRange Field
    /// </summary>/
    public sealed class EndStrikePxRange : QuickFix.Fields.DecimalField
    {
        public EndStrikePxRange()
            :base(Fields.CustomTags.EndStrikePxRange) {}
        public EndStrikePxRange(Decimal val)
            :base(Fields.CustomTags.EndStrikePxRange, val) {}

    }


    /// <summary>
    /// StrikeIncrement Field
    /// </summary>/
    public sealed class StrikeIncrement : QuickFix.Fields.DecimalField
    {
        public StrikeIncrement()
            :base(Fields.CustomTags.StrikeIncrement) {}
        public StrikeIncrement(Decimal val)
            :base(Fields.CustomTags.StrikeIncrement, val) {}

    }


    /// <summary>
    /// NoTickRules Field
    /// </summary>/
    public sealed class NoTickRules : QuickFix.Fields.IntField
    {
        public NoTickRules()
            :base(Fields.CustomTags.NoTickRules) {}
        public NoTickRules(int val)
            :base(Fields.CustomTags.NoTickRules, val) {}

    }


    /// <summary>
    /// StartTickPriceRange Field
    /// </summary>/
    public sealed class StartTickPriceRange : QuickFix.Fields.DecimalField
    {
        public StartTickPriceRange()
            :base(Fields.CustomTags.StartTickPriceRange) {}
        public StartTickPriceRange(Decimal val)
            :base(Fields.CustomTags.StartTickPriceRange, val) {}

    }


    /// <summary>
    /// EndTickPriceRange Field
    /// </summary>/
    public sealed class EndTickPriceRange : QuickFix.Fields.DecimalField
    {
        public EndTickPriceRange()
            :base(Fields.CustomTags.EndTickPriceRange) {}
        public EndTickPriceRange(Decimal val)
            :base(Fields.CustomTags.EndTickPriceRange, val) {}

    }


    /// <summary>
    /// TickIncrement Field
    /// </summary>/
    public sealed class TickIncrement : QuickFix.Fields.DecimalField
    {
        public TickIncrement()
            :base(Fields.CustomTags.TickIncrement) {}
        public TickIncrement(Decimal val)
            :base(Fields.CustomTags.TickIncrement, val) {}

    }


    /// <summary>
    /// TickRuleType Field
    /// </summary>/
    public sealed class TickRuleType : QuickFix.Fields.IntField
    {
        public TickRuleType()
            :base(Fields.CustomTags.TickRuleType) {}
        public TickRuleType(int val)
            :base(Fields.CustomTags.TickRuleType, val) {}


        // Field Enumerations
        public const int REGULAR = 0;
        public const int VARIABLE = 1;
        public const int FIXED = 2;
        public const int TRADED_AS_A_SPREAD_LEG = 3;
        public const int SETTLED_AS_A_SPREAD_LEG = 4;
    }


    /// <summary>
    /// NestedInstrAttribType Field
    /// </summary>/
    public sealed class NestedInstrAttribType : QuickFix.Fields.IntField
    {
        public NestedInstrAttribType()
            :base(Fields.CustomTags.NestedInstrAttribType) {}
        public NestedInstrAttribType(int val)
            :base(Fields.CustomTags.NestedInstrAttribType, val) {}

    }


    /// <summary>
    /// NestedInstrAttribValue Field
    /// </summary>/
    public sealed class NestedInstrAttribValue : QuickFix.Fields.StringField
    {
        public NestedInstrAttribValue()
            :base(Fields.CustomTags.NestedInstrAttribValue) {}
        public NestedInstrAttribValue(string val)
            :base(Fields.CustomTags.NestedInstrAttribValue, val) {}

    }


    /// <summary>
    /// LegMaturityTime Field
    /// </summary>/
    public sealed class LegMaturityTime : QuickFix.Fields.StringField
    {
        public LegMaturityTime()
            :base(Fields.CustomTags.LegMaturityTime) {}
        public LegMaturityTime(string val)
            :base(Fields.CustomTags.LegMaturityTime, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityTime Field
    /// </summary>/
    public sealed class UnderlyingMaturityTime : QuickFix.Fields.StringField
    {
        public UnderlyingMaturityTime()
            :base(Fields.CustomTags.UnderlyingMaturityTime) {}
        public UnderlyingMaturityTime(string val)
            :base(Fields.CustomTags.UnderlyingMaturityTime, val) {}

    }


    /// <summary>
    /// DerivativeSymbol Field
    /// </summary>/
    public sealed class DerivativeSymbol : QuickFix.Fields.StringField
    {
        public DerivativeSymbol()
            :base(Fields.CustomTags.DerivativeSymbol) {}
        public DerivativeSymbol(string val)
            :base(Fields.CustomTags.DerivativeSymbol, val) {}

    }


    /// <summary>
    /// DerivativeSymbolSfx Field
    /// </summary>/
    public sealed class DerivativeSymbolSfx : QuickFix.Fields.StringField
    {
        public DerivativeSymbolSfx()
            :base(Fields.CustomTags.DerivativeSymbolSfx) {}
        public DerivativeSymbolSfx(string val)
            :base(Fields.CustomTags.DerivativeSymbolSfx, val) {}

    }


    /// <summary>
    /// DerivativeSecurityID Field
    /// </summary>/
    public sealed class DerivativeSecurityID : QuickFix.Fields.StringField
    {
        public DerivativeSecurityID()
            :base(Fields.CustomTags.DerivativeSecurityID) {}
        public DerivativeSecurityID(string val)
            :base(Fields.CustomTags.DerivativeSecurityID, val) {}

    }


    /// <summary>
    /// DerivativeSecurityIDSource Field
    /// </summary>/
    public sealed class DerivativeSecurityIDSource : QuickFix.Fields.StringField
    {
        public DerivativeSecurityIDSource()
            :base(Fields.CustomTags.DerivativeSecurityIDSource) {}
        public DerivativeSecurityIDSource(string val)
            :base(Fields.CustomTags.DerivativeSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoDerivativeSecurityAltID Field
    /// </summary>/
    public sealed class NoDerivativeSecurityAltID : QuickFix.Fields.IntField
    {
        public NoDerivativeSecurityAltID()
            :base(Fields.CustomTags.NoDerivativeSecurityAltID) {}
        public NoDerivativeSecurityAltID(int val)
            :base(Fields.CustomTags.NoDerivativeSecurityAltID, val) {}

    }


    /// <summary>
    /// DerivativeSecurityAltID Field
    /// </summary>/
    public sealed class DerivativeSecurityAltID : QuickFix.Fields.StringField
    {
        public DerivativeSecurityAltID()
            :base(Fields.CustomTags.DerivativeSecurityAltID) {}
        public DerivativeSecurityAltID(string val)
            :base(Fields.CustomTags.DerivativeSecurityAltID, val) {}

    }


    /// <summary>
    /// DerivativeSecurityAltIDSource Field
    /// </summary>/
    public sealed class DerivativeSecurityAltIDSource : QuickFix.Fields.StringField
    {
        public DerivativeSecurityAltIDSource()
            :base(Fields.CustomTags.DerivativeSecurityAltIDSource) {}
        public DerivativeSecurityAltIDSource(string val)
            :base(Fields.CustomTags.DerivativeSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// SecondaryLowLimitPrice Field
    /// </summary>/
    public sealed class SecondaryLowLimitPrice : QuickFix.Fields.DecimalField
    {
        public SecondaryLowLimitPrice()
            :base(Fields.CustomTags.SecondaryLowLimitPrice) {}
        public SecondaryLowLimitPrice(Decimal val)
            :base(Fields.CustomTags.SecondaryLowLimitPrice, val) {}

    }


    /// <summary>
    /// MaturityRuleID Field
    /// </summary>/
    public sealed class MaturityRuleID : QuickFix.Fields.StringField
    {
        public MaturityRuleID()
            :base(Fields.CustomTags.MaturityRuleID) {}
        public MaturityRuleID(string val)
            :base(Fields.CustomTags.MaturityRuleID, val) {}

    }


    /// <summary>
    /// StrikeRuleID Field
    /// </summary>/
    public sealed class StrikeRuleID : QuickFix.Fields.StringField
    {
        public StrikeRuleID()
            :base(Fields.CustomTags.StrikeRuleID) {}
        public StrikeRuleID(string val)
            :base(Fields.CustomTags.StrikeRuleID, val) {}

    }


    /// <summary>
    /// LegUnitOfMeasureQty Field
    /// </summary>/
    public sealed class LegUnitOfMeasureQty : QuickFix.Fields.DecimalField
    {
        public LegUnitOfMeasureQty()
            :base(Fields.CustomTags.LegUnitOfMeasureQty) {}
        public LegUnitOfMeasureQty(Decimal val)
            :base(Fields.CustomTags.LegUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// DerivativeOptPayAmount Field
    /// </summary>/
    public sealed class DerivativeOptPayAmount : QuickFix.Fields.DecimalField
    {
        public DerivativeOptPayAmount()
            :base(Fields.CustomTags.DerivativeOptPayAmount) {}
        public DerivativeOptPayAmount(Decimal val)
            :base(Fields.CustomTags.DerivativeOptPayAmount, val) {}

    }


    /// <summary>
    /// EndMaturityMonthYear Field
    /// </summary>/
    public sealed class EndMaturityMonthYear : QuickFix.Fields.StringField
    {
        public EndMaturityMonthYear()
            :base(Fields.CustomTags.EndMaturityMonthYear) {}
        public EndMaturityMonthYear(string val)
            :base(Fields.CustomTags.EndMaturityMonthYear, val) {}

    }


    /// <summary>
    /// ProductComplex Field
    /// </summary>/
    public sealed class ProductComplex : QuickFix.Fields.StringField
    {
        public ProductComplex()
            :base(Fields.CustomTags.ProductComplex) {}
        public ProductComplex(string val)
            :base(Fields.CustomTags.ProductComplex, val) {}

    }


    /// <summary>
    /// DerivativeProductComplex Field
    /// </summary>/
    public sealed class DerivativeProductComplex : QuickFix.Fields.StringField
    {
        public DerivativeProductComplex()
            :base(Fields.CustomTags.DerivativeProductComplex) {}
        public DerivativeProductComplex(string val)
            :base(Fields.CustomTags.DerivativeProductComplex, val) {}

    }


    /// <summary>
    /// MaturityMonthYearIncrement Field
    /// </summary>/
    public sealed class MaturityMonthYearIncrement : QuickFix.Fields.IntField
    {
        public MaturityMonthYearIncrement()
            :base(Fields.CustomTags.MaturityMonthYearIncrement) {}
        public MaturityMonthYearIncrement(int val)
            :base(Fields.CustomTags.MaturityMonthYearIncrement, val) {}

    }


    /// <summary>
    /// SecondaryHighLimitPrice Field
    /// </summary>/
    public sealed class SecondaryHighLimitPrice : QuickFix.Fields.DecimalField
    {
        public SecondaryHighLimitPrice()
            :base(Fields.CustomTags.SecondaryHighLimitPrice) {}
        public SecondaryHighLimitPrice(Decimal val)
            :base(Fields.CustomTags.SecondaryHighLimitPrice, val) {}

    }


    /// <summary>
    /// NoExecInstRules Field
    /// </summary>/
    public sealed class NoExecInstRules : QuickFix.Fields.IntField
    {
        public NoExecInstRules()
            :base(Fields.CustomTags.NoExecInstRules) {}
        public NoExecInstRules(int val)
            :base(Fields.CustomTags.NoExecInstRules, val) {}

    }


    /// <summary>
    /// NoLotTypeRules Field
    /// </summary>/
    public sealed class NoLotTypeRules : QuickFix.Fields.IntField
    {
        public NoLotTypeRules()
            :base(Fields.CustomTags.NoLotTypeRules) {}
        public NoLotTypeRules(int val)
            :base(Fields.CustomTags.NoLotTypeRules, val) {}

    }


    /// <summary>
    /// NoMatchRules Field
    /// </summary>/
    public sealed class NoMatchRules : QuickFix.Fields.IntField
    {
        public NoMatchRules()
            :base(Fields.CustomTags.NoMatchRules) {}
        public NoMatchRules(int val)
            :base(Fields.CustomTags.NoMatchRules, val) {}

    }


    /// <summary>
    /// NoMaturityRules Field
    /// </summary>/
    public sealed class NoMaturityRules : QuickFix.Fields.IntField
    {
        public NoMaturityRules()
            :base(Fields.CustomTags.NoMaturityRules) {}
        public NoMaturityRules(int val)
            :base(Fields.CustomTags.NoMaturityRules, val) {}

    }


    /// <summary>
    /// NoOrdTypeRules Field
    /// </summary>/
    public sealed class NoOrdTypeRules : QuickFix.Fields.IntField
    {
        public NoOrdTypeRules()
            :base(Fields.CustomTags.NoOrdTypeRules) {}
        public NoOrdTypeRules(int val)
            :base(Fields.CustomTags.NoOrdTypeRules, val) {}

    }


    /// <summary>
    /// NoTimeInForceRules Field
    /// </summary>/
    public sealed class NoTimeInForceRules : QuickFix.Fields.IntField
    {
        public NoTimeInForceRules()
            :base(Fields.CustomTags.NoTimeInForceRules) {}
        public NoTimeInForceRules(int val)
            :base(Fields.CustomTags.NoTimeInForceRules, val) {}

    }


    /// <summary>
    /// SecondaryTradingReferencePrice Field
    /// </summary>/
    public sealed class SecondaryTradingReferencePrice : QuickFix.Fields.DecimalField
    {
        public SecondaryTradingReferencePrice()
            :base(Fields.CustomTags.SecondaryTradingReferencePrice) {}
        public SecondaryTradingReferencePrice(Decimal val)
            :base(Fields.CustomTags.SecondaryTradingReferencePrice, val) {}

    }


    /// <summary>
    /// StartMaturityMonthYear Field
    /// </summary>/
    public sealed class StartMaturityMonthYear : QuickFix.Fields.StringField
    {
        public StartMaturityMonthYear()
            :base(Fields.CustomTags.StartMaturityMonthYear) {}
        public StartMaturityMonthYear(string val)
            :base(Fields.CustomTags.StartMaturityMonthYear, val) {}

    }


    /// <summary>
    /// FlexProductEligibilityIndicator Field
    /// </summary>/
    public sealed class FlexProductEligibilityIndicator : QuickFix.Fields.BooleanField
    {
        public FlexProductEligibilityIndicator()
            :base(Fields.CustomTags.FlexProductEligibilityIndicator) {}
        public FlexProductEligibilityIndicator(Boolean val)
            :base(Fields.CustomTags.FlexProductEligibilityIndicator, val) {}

    }


    /// <summary>
    /// DerivFlexProductEligibilityIndicator Field
    /// </summary>/
    public sealed class DerivFlexProductEligibilityIndicator : QuickFix.Fields.BooleanField
    {
        public DerivFlexProductEligibilityIndicator()
            :base(Fields.CustomTags.DerivFlexProductEligibilityIndicator) {}
        public DerivFlexProductEligibilityIndicator(Boolean val)
            :base(Fields.CustomTags.DerivFlexProductEligibilityIndicator, val) {}

    }


    /// <summary>
    /// FlexibleIndicator Field
    /// </summary>/
    public sealed class FlexibleIndicator : QuickFix.Fields.BooleanField
    {
        public FlexibleIndicator()
            :base(Fields.CustomTags.FlexibleIndicator) {}
        public FlexibleIndicator(Boolean val)
            :base(Fields.CustomTags.FlexibleIndicator, val) {}

    }


    /// <summary>
    /// TradingCurrency Field
    /// </summary>/
    public sealed class TradingCurrency : QuickFix.Fields.StringField
    {
        public TradingCurrency()
            :base(Fields.CustomTags.TradingCurrency) {}
        public TradingCurrency(string val)
            :base(Fields.CustomTags.TradingCurrency, val) {}

    }


    /// <summary>
    /// DerivativeProduct Field
    /// </summary>/
    public sealed class DerivativeProduct : QuickFix.Fields.IntField
    {
        public DerivativeProduct()
            :base(Fields.CustomTags.DerivativeProduct) {}
        public DerivativeProduct(int val)
            :base(Fields.CustomTags.DerivativeProduct, val) {}

    }


    /// <summary>
    /// DerivativeSecurityGroup Field
    /// </summary>/
    public sealed class DerivativeSecurityGroup : QuickFix.Fields.StringField
    {
        public DerivativeSecurityGroup()
            :base(Fields.CustomTags.DerivativeSecurityGroup) {}
        public DerivativeSecurityGroup(string val)
            :base(Fields.CustomTags.DerivativeSecurityGroup, val) {}

    }


    /// <summary>
    /// DerivativeCFICode Field
    /// </summary>/
    public sealed class DerivativeCFICode : QuickFix.Fields.StringField
    {
        public DerivativeCFICode()
            :base(Fields.CustomTags.DerivativeCFICode) {}
        public DerivativeCFICode(string val)
            :base(Fields.CustomTags.DerivativeCFICode, val) {}

    }


    /// <summary>
    /// DerivativeSecurityType Field
    /// </summary>/
    public sealed class DerivativeSecurityType : QuickFix.Fields.StringField
    {
        public DerivativeSecurityType()
            :base(Fields.CustomTags.DerivativeSecurityType) {}
        public DerivativeSecurityType(string val)
            :base(Fields.CustomTags.DerivativeSecurityType, val) {}

    }


    /// <summary>
    /// DerivativeSecuritySubType Field
    /// </summary>/
    public sealed class DerivativeSecuritySubType : QuickFix.Fields.StringField
    {
        public DerivativeSecuritySubType()
            :base(Fields.CustomTags.DerivativeSecuritySubType) {}
        public DerivativeSecuritySubType(string val)
            :base(Fields.CustomTags.DerivativeSecuritySubType, val) {}

    }


    /// <summary>
    /// DerivativeMaturityMonthYear Field
    /// </summary>/
    public sealed class DerivativeMaturityMonthYear : QuickFix.Fields.StringField
    {
        public DerivativeMaturityMonthYear()
            :base(Fields.CustomTags.DerivativeMaturityMonthYear) {}
        public DerivativeMaturityMonthYear(string val)
            :base(Fields.CustomTags.DerivativeMaturityMonthYear, val) {}

    }


    /// <summary>
    /// DerivativeMaturityDate Field
    /// </summary>/
    public sealed class DerivativeMaturityDate : QuickFix.Fields.StringField
    {
        public DerivativeMaturityDate()
            :base(Fields.CustomTags.DerivativeMaturityDate) {}
        public DerivativeMaturityDate(string val)
            :base(Fields.CustomTags.DerivativeMaturityDate, val) {}

    }


    /// <summary>
    /// DerivativeMaturityTime Field
    /// </summary>/
    public sealed class DerivativeMaturityTime : QuickFix.Fields.StringField
    {
        public DerivativeMaturityTime()
            :base(Fields.CustomTags.DerivativeMaturityTime) {}
        public DerivativeMaturityTime(string val)
            :base(Fields.CustomTags.DerivativeMaturityTime, val) {}

    }


    /// <summary>
    /// DerivativeSettleOnOpenFlag Field
    /// </summary>/
    public sealed class DerivativeSettleOnOpenFlag : QuickFix.Fields.StringField
    {
        public DerivativeSettleOnOpenFlag()
            :base(Fields.CustomTags.DerivativeSettleOnOpenFlag) {}
        public DerivativeSettleOnOpenFlag(string val)
            :base(Fields.CustomTags.DerivativeSettleOnOpenFlag, val) {}

    }


    /// <summary>
    /// DerivativeInstrmtAssignmentMethod Field
    /// </summary>/
    public sealed class DerivativeInstrmtAssignmentMethod : QuickFix.Fields.CharField
    {
        public DerivativeInstrmtAssignmentMethod()
            :base(Fields.CustomTags.DerivativeInstrmtAssignmentMethod) {}
        public DerivativeInstrmtAssignmentMethod(char val)
            :base(Fields.CustomTags.DerivativeInstrmtAssignmentMethod, val) {}

    }


    /// <summary>
    /// DerivativeSecurityStatus Field
    /// </summary>/
    public sealed class DerivativeSecurityStatus : QuickFix.Fields.StringField
    {
        public DerivativeSecurityStatus()
            :base(Fields.CustomTags.DerivativeSecurityStatus) {}
        public DerivativeSecurityStatus(string val)
            :base(Fields.CustomTags.DerivativeSecurityStatus, val) {}

    }


    /// <summary>
    /// DerivativeInstrRegistry Field
    /// </summary>/
    public sealed class DerivativeInstrRegistry : QuickFix.Fields.StringField
    {
        public DerivativeInstrRegistry()
            :base(Fields.CustomTags.DerivativeInstrRegistry) {}
        public DerivativeInstrRegistry(string val)
            :base(Fields.CustomTags.DerivativeInstrRegistry, val) {}

    }


    /// <summary>
    /// DerivativeCountryOfIssue Field
    /// </summary>/
    public sealed class DerivativeCountryOfIssue : QuickFix.Fields.StringField
    {
        public DerivativeCountryOfIssue()
            :base(Fields.CustomTags.DerivativeCountryOfIssue) {}
        public DerivativeCountryOfIssue(string val)
            :base(Fields.CustomTags.DerivativeCountryOfIssue, val) {}

    }


    /// <summary>
    /// DerivativeStateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class DerivativeStateOrProvinceOfIssue : QuickFix.Fields.StringField
    {
        public DerivativeStateOrProvinceOfIssue()
            :base(Fields.CustomTags.DerivativeStateOrProvinceOfIssue) {}
        public DerivativeStateOrProvinceOfIssue(string val)
            :base(Fields.CustomTags.DerivativeStateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// DerivativeLocaleOfIssue Field
    /// </summary>/
    public sealed class DerivativeLocaleOfIssue : QuickFix.Fields.StringField
    {
        public DerivativeLocaleOfIssue()
            :base(Fields.CustomTags.DerivativeLocaleOfIssue) {}
        public DerivativeLocaleOfIssue(string val)
            :base(Fields.CustomTags.DerivativeLocaleOfIssue, val) {}

    }


    /// <summary>
    /// DerivativeStrikePrice Field
    /// </summary>/
    public sealed class DerivativeStrikePrice : QuickFix.Fields.DecimalField
    {
        public DerivativeStrikePrice()
            :base(Fields.CustomTags.DerivativeStrikePrice) {}
        public DerivativeStrikePrice(Decimal val)
            :base(Fields.CustomTags.DerivativeStrikePrice, val) {}

    }


    /// <summary>
    /// DerivativeStrikeCurrency Field
    /// </summary>/
    public sealed class DerivativeStrikeCurrency : QuickFix.Fields.StringField
    {
        public DerivativeStrikeCurrency()
            :base(Fields.CustomTags.DerivativeStrikeCurrency) {}
        public DerivativeStrikeCurrency(string val)
            :base(Fields.CustomTags.DerivativeStrikeCurrency, val) {}

    }


    /// <summary>
    /// DerivativeStrikeMultiplier Field
    /// </summary>/
    public sealed class DerivativeStrikeMultiplier : QuickFix.Fields.DecimalField
    {
        public DerivativeStrikeMultiplier()
            :base(Fields.CustomTags.DerivativeStrikeMultiplier) {}
        public DerivativeStrikeMultiplier(Decimal val)
            :base(Fields.CustomTags.DerivativeStrikeMultiplier, val) {}

    }


    /// <summary>
    /// DerivativeStrikeValue Field
    /// </summary>/
    public sealed class DerivativeStrikeValue : QuickFix.Fields.DecimalField
    {
        public DerivativeStrikeValue()
            :base(Fields.CustomTags.DerivativeStrikeValue) {}
        public DerivativeStrikeValue(Decimal val)
            :base(Fields.CustomTags.DerivativeStrikeValue, val) {}

    }


    /// <summary>
    /// DerivativeOptAttribute Field
    /// </summary>/
    public sealed class DerivativeOptAttribute : QuickFix.Fields.CharField
    {
        public DerivativeOptAttribute()
            :base(Fields.CustomTags.DerivativeOptAttribute) {}
        public DerivativeOptAttribute(char val)
            :base(Fields.CustomTags.DerivativeOptAttribute, val) {}

    }


    /// <summary>
    /// DerivativeContractMultiplier Field
    /// </summary>/
    public sealed class DerivativeContractMultiplier : QuickFix.Fields.DecimalField
    {
        public DerivativeContractMultiplier()
            :base(Fields.CustomTags.DerivativeContractMultiplier) {}
        public DerivativeContractMultiplier(Decimal val)
            :base(Fields.CustomTags.DerivativeContractMultiplier, val) {}

    }


    /// <summary>
    /// DerivativeMinPriceIncrement Field
    /// </summary>/
    public sealed class DerivativeMinPriceIncrement : QuickFix.Fields.DecimalField
    {
        public DerivativeMinPriceIncrement()
            :base(Fields.CustomTags.DerivativeMinPriceIncrement) {}
        public DerivativeMinPriceIncrement(Decimal val)
            :base(Fields.CustomTags.DerivativeMinPriceIncrement, val) {}

    }


    /// <summary>
    /// DerivativeMinPriceIncrementAmount Field
    /// </summary>/
    public sealed class DerivativeMinPriceIncrementAmount : QuickFix.Fields.DecimalField
    {
        public DerivativeMinPriceIncrementAmount()
            :base(Fields.CustomTags.DerivativeMinPriceIncrementAmount) {}
        public DerivativeMinPriceIncrementAmount(Decimal val)
            :base(Fields.CustomTags.DerivativeMinPriceIncrementAmount, val) {}

    }


    /// <summary>
    /// DerivativeUnitOfMeasure Field
    /// </summary>/
    public sealed class DerivativeUnitOfMeasure : QuickFix.Fields.StringField
    {
        public DerivativeUnitOfMeasure()
            :base(Fields.CustomTags.DerivativeUnitOfMeasure) {}
        public DerivativeUnitOfMeasure(string val)
            :base(Fields.CustomTags.DerivativeUnitOfMeasure, val) {}

    }


    /// <summary>
    /// DerivativeUnitOfMeasureQty Field
    /// </summary>/
    public sealed class DerivativeUnitOfMeasureQty : QuickFix.Fields.DecimalField
    {
        public DerivativeUnitOfMeasureQty()
            :base(Fields.CustomTags.DerivativeUnitOfMeasureQty) {}
        public DerivativeUnitOfMeasureQty(Decimal val)
            :base(Fields.CustomTags.DerivativeUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// DerivativeTimeUnit Field
    /// </summary>/
    public sealed class DerivativeTimeUnit : QuickFix.Fields.StringField
    {
        public DerivativeTimeUnit()
            :base(Fields.CustomTags.DerivativeTimeUnit) {}
        public DerivativeTimeUnit(string val)
            :base(Fields.CustomTags.DerivativeTimeUnit, val) {}

    }


    /// <summary>
    /// DerivativeSecurityExchange Field
    /// </summary>/
    public sealed class DerivativeSecurityExchange : QuickFix.Fields.StringField
    {
        public DerivativeSecurityExchange()
            :base(Fields.CustomTags.DerivativeSecurityExchange) {}
        public DerivativeSecurityExchange(string val)
            :base(Fields.CustomTags.DerivativeSecurityExchange, val) {}

    }


    /// <summary>
    /// DerivativePositionLimit Field
    /// </summary>/
    public sealed class DerivativePositionLimit : QuickFix.Fields.IntField
    {
        public DerivativePositionLimit()
            :base(Fields.CustomTags.DerivativePositionLimit) {}
        public DerivativePositionLimit(int val)
            :base(Fields.CustomTags.DerivativePositionLimit, val) {}

    }


    /// <summary>
    /// DerivativeNTPositionLimit Field
    /// </summary>/
    public sealed class DerivativeNTPositionLimit : QuickFix.Fields.IntField
    {
        public DerivativeNTPositionLimit()
            :base(Fields.CustomTags.DerivativeNTPositionLimit) {}
        public DerivativeNTPositionLimit(int val)
            :base(Fields.CustomTags.DerivativeNTPositionLimit, val) {}

    }


    /// <summary>
    /// DerivativeIssuer Field
    /// </summary>/
    public sealed class DerivativeIssuer : QuickFix.Fields.StringField
    {
        public DerivativeIssuer()
            :base(Fields.CustomTags.DerivativeIssuer) {}
        public DerivativeIssuer(string val)
            :base(Fields.CustomTags.DerivativeIssuer, val) {}

    }


    /// <summary>
    /// DerivativeIssueDate Field
    /// </summary>/
    public sealed class DerivativeIssueDate : QuickFix.Fields.StringField
    {
        public DerivativeIssueDate()
            :base(Fields.CustomTags.DerivativeIssueDate) {}
        public DerivativeIssueDate(string val)
            :base(Fields.CustomTags.DerivativeIssueDate, val) {}

    }


    /// <summary>
    /// DerivativeEncodedIssuerLen Field
    /// </summary>/
    public sealed class DerivativeEncodedIssuerLen : QuickFix.Fields.IntField
    {
        public DerivativeEncodedIssuerLen()
            :base(Fields.CustomTags.DerivativeEncodedIssuerLen) {}
        public DerivativeEncodedIssuerLen(int val)
            :base(Fields.CustomTags.DerivativeEncodedIssuerLen, val) {}

    }


    /// <summary>
    /// DerivativeEncodedIssuer Field
    /// </summary>/
    public sealed class DerivativeEncodedIssuer : QuickFix.Fields.StringField
    {
        public DerivativeEncodedIssuer()
            :base(Fields.CustomTags.DerivativeEncodedIssuer) {}
        public DerivativeEncodedIssuer(string val)
            :base(Fields.CustomTags.DerivativeEncodedIssuer, val) {}

    }


    /// <summary>
    /// DerivativeSecurityDesc Field
    /// </summary>/
    public sealed class DerivativeSecurityDesc : QuickFix.Fields.StringField
    {
        public DerivativeSecurityDesc()
            :base(Fields.CustomTags.DerivativeSecurityDesc) {}
        public DerivativeSecurityDesc(string val)
            :base(Fields.CustomTags.DerivativeSecurityDesc, val) {}

    }


    /// <summary>
    /// DerivativeEncodedSecurityDescLen Field
    /// </summary>/
    public sealed class DerivativeEncodedSecurityDescLen : QuickFix.Fields.IntField
    {
        public DerivativeEncodedSecurityDescLen()
            :base(Fields.CustomTags.DerivativeEncodedSecurityDescLen) {}
        public DerivativeEncodedSecurityDescLen(int val)
            :base(Fields.CustomTags.DerivativeEncodedSecurityDescLen, val) {}

    }


    /// <summary>
    /// DerivativeEncodedSecurityDesc Field
    /// </summary>/
    public sealed class DerivativeEncodedSecurityDesc : QuickFix.Fields.StringField
    {
        public DerivativeEncodedSecurityDesc()
            :base(Fields.CustomTags.DerivativeEncodedSecurityDesc) {}
        public DerivativeEncodedSecurityDesc(string val)
            :base(Fields.CustomTags.DerivativeEncodedSecurityDesc, val) {}

    }


    /// <summary>
    /// DerivativeSecurityXMLLen Field
    /// </summary>/
    public sealed class DerivativeSecurityXMLLen : QuickFix.Fields.IntField
    {
        public DerivativeSecurityXMLLen()
            :base(Fields.CustomTags.DerivativeSecurityXMLLen) {}
        public DerivativeSecurityXMLLen(int val)
            :base(Fields.CustomTags.DerivativeSecurityXMLLen, val) {}

    }


    /// <summary>
    /// DerivativeSecurityXML Field
    /// </summary>/
    public sealed class DerivativeSecurityXML : QuickFix.Fields.StringField
    {
        public DerivativeSecurityXML()
            :base(Fields.CustomTags.DerivativeSecurityXML) {}
        public DerivativeSecurityXML(string val)
            :base(Fields.CustomTags.DerivativeSecurityXML, val) {}

    }


    /// <summary>
    /// DerivativeSecurityXMLSchema Field
    /// </summary>/
    public sealed class DerivativeSecurityXMLSchema : QuickFix.Fields.StringField
    {
        public DerivativeSecurityXMLSchema()
            :base(Fields.CustomTags.DerivativeSecurityXMLSchema) {}
        public DerivativeSecurityXMLSchema(string val)
            :base(Fields.CustomTags.DerivativeSecurityXMLSchema, val) {}

    }


    /// <summary>
    /// DerivativeContractSettlMonth Field
    /// </summary>/
    public sealed class DerivativeContractSettlMonth : QuickFix.Fields.StringField
    {
        public DerivativeContractSettlMonth()
            :base(Fields.CustomTags.DerivativeContractSettlMonth) {}
        public DerivativeContractSettlMonth(string val)
            :base(Fields.CustomTags.DerivativeContractSettlMonth, val) {}

    }


    /// <summary>
    /// NoDerivativeEvents Field
    /// </summary>/
    public sealed class NoDerivativeEvents : QuickFix.Fields.IntField
    {
        public NoDerivativeEvents()
            :base(Fields.CustomTags.NoDerivativeEvents) {}
        public NoDerivativeEvents(int val)
            :base(Fields.CustomTags.NoDerivativeEvents, val) {}

    }


    /// <summary>
    /// DerivativeEventType Field
    /// </summary>/
    public sealed class DerivativeEventType : QuickFix.Fields.IntField
    {
        public DerivativeEventType()
            :base(Fields.CustomTags.DerivativeEventType) {}
        public DerivativeEventType(int val)
            :base(Fields.CustomTags.DerivativeEventType, val) {}

    }


    /// <summary>
    /// DerivativeEventDate Field
    /// </summary>/
    public sealed class DerivativeEventDate : QuickFix.Fields.StringField
    {
        public DerivativeEventDate()
            :base(Fields.CustomTags.DerivativeEventDate) {}
        public DerivativeEventDate(string val)
            :base(Fields.CustomTags.DerivativeEventDate, val) {}

    }


    /// <summary>
    /// DerivativeEventTime Field
    /// </summary>/
    public sealed class DerivativeEventTime : QuickFix.Fields.DateTimeField
    {
        public DerivativeEventTime()
            :base(Fields.CustomTags.DerivativeEventTime) {}
        public DerivativeEventTime(DateTime val)
            :base(Fields.CustomTags.DerivativeEventTime, val) {}
        public DerivativeEventTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.DerivativeEventTime, val, showMilliseconds) {}
		public DerivativeEventTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.DerivativeEventTime, val, precision) {}

    }


    /// <summary>
    /// DerivativeEventPx Field
    /// </summary>/
    public sealed class DerivativeEventPx : QuickFix.Fields.DecimalField
    {
        public DerivativeEventPx()
            :base(Fields.CustomTags.DerivativeEventPx) {}
        public DerivativeEventPx(Decimal val)
            :base(Fields.CustomTags.DerivativeEventPx, val) {}

    }


    /// <summary>
    /// DerivativeEventText Field
    /// </summary>/
    public sealed class DerivativeEventText : QuickFix.Fields.StringField
    {
        public DerivativeEventText()
            :base(Fields.CustomTags.DerivativeEventText) {}
        public DerivativeEventText(string val)
            :base(Fields.CustomTags.DerivativeEventText, val) {}

    }


    /// <summary>
    /// NoDerivativeInstrumentParties Field
    /// </summary>/
    public sealed class NoDerivativeInstrumentParties : QuickFix.Fields.IntField
    {
        public NoDerivativeInstrumentParties()
            :base(Fields.CustomTags.NoDerivativeInstrumentParties) {}
        public NoDerivativeInstrumentParties(int val)
            :base(Fields.CustomTags.NoDerivativeInstrumentParties, val) {}

    }


    /// <summary>
    /// DerivativeInstrumentPartyID Field
    /// </summary>/
    public sealed class DerivativeInstrumentPartyID : QuickFix.Fields.StringField
    {
        public DerivativeInstrumentPartyID()
            :base(Fields.CustomTags.DerivativeInstrumentPartyID) {}
        public DerivativeInstrumentPartyID(string val)
            :base(Fields.CustomTags.DerivativeInstrumentPartyID, val) {}

    }


    /// <summary>
    /// DerivativeInstrumentPartyIDSource Field
    /// </summary>/
    public sealed class DerivativeInstrumentPartyIDSource : QuickFix.Fields.StringField
    {
        public DerivativeInstrumentPartyIDSource()
            :base(Fields.CustomTags.DerivativeInstrumentPartyIDSource) {}
        public DerivativeInstrumentPartyIDSource(string val)
            :base(Fields.CustomTags.DerivativeInstrumentPartyIDSource, val) {}

    }


    /// <summary>
    /// DerivativeInstrumentPartyRole Field
    /// </summary>/
    public sealed class DerivativeInstrumentPartyRole : QuickFix.Fields.IntField
    {
        public DerivativeInstrumentPartyRole()
            :base(Fields.CustomTags.DerivativeInstrumentPartyRole) {}
        public DerivativeInstrumentPartyRole(int val)
            :base(Fields.CustomTags.DerivativeInstrumentPartyRole, val) {}

    }


    /// <summary>
    /// NoDerivativeInstrumentPartySubIDs Field
    /// </summary>/
    public sealed class NoDerivativeInstrumentPartySubIDs : QuickFix.Fields.IntField
    {
        public NoDerivativeInstrumentPartySubIDs()
            :base(Fields.CustomTags.NoDerivativeInstrumentPartySubIDs) {}
        public NoDerivativeInstrumentPartySubIDs(int val)
            :base(Fields.CustomTags.NoDerivativeInstrumentPartySubIDs, val) {}

    }


    /// <summary>
    /// DerivativeInstrumentPartySubID Field
    /// </summary>/
    public sealed class DerivativeInstrumentPartySubID : QuickFix.Fields.StringField
    {
        public DerivativeInstrumentPartySubID()
            :base(Fields.CustomTags.DerivativeInstrumentPartySubID) {}
        public DerivativeInstrumentPartySubID(string val)
            :base(Fields.CustomTags.DerivativeInstrumentPartySubID, val) {}

    }


    /// <summary>
    /// DerivativeInstrumentPartySubIDType Field
    /// </summary>/
    public sealed class DerivativeInstrumentPartySubIDType : QuickFix.Fields.IntField
    {
        public DerivativeInstrumentPartySubIDType()
            :base(Fields.CustomTags.DerivativeInstrumentPartySubIDType) {}
        public DerivativeInstrumentPartySubIDType(int val)
            :base(Fields.CustomTags.DerivativeInstrumentPartySubIDType, val) {}

    }


    /// <summary>
    /// DerivativeExerciseStyle Field
    /// </summary>/
    public sealed class DerivativeExerciseStyle : QuickFix.Fields.CharField
    {
        public DerivativeExerciseStyle()
            :base(Fields.CustomTags.DerivativeExerciseStyle) {}
        public DerivativeExerciseStyle(char val)
            :base(Fields.CustomTags.DerivativeExerciseStyle, val) {}

    }


    /// <summary>
    /// MarketID Field
    /// </summary>/
    public sealed class MarketID : QuickFix.Fields.StringField
    {
        public MarketID()
            :base(Fields.CustomTags.MarketID) {}
        public MarketID(string val)
            :base(Fields.CustomTags.MarketID, val) {}

    }


    /// <summary>
    /// MaturityMonthYearIncrementUnits Field
    /// </summary>/
    public sealed class MaturityMonthYearIncrementUnits : QuickFix.Fields.IntField
    {
        public MaturityMonthYearIncrementUnits()
            :base(Fields.CustomTags.MaturityMonthYearIncrementUnits) {}
        public MaturityMonthYearIncrementUnits(int val)
            :base(Fields.CustomTags.MaturityMonthYearIncrementUnits, val) {}


        // Field Enumerations
        public const int MONTHS = 0;
        public const int DAYS = 1;
        public const int WEEKS = 2;
        public const int YEARS = 3;
    }


    /// <summary>
    /// MaturityMonthYearFormat Field
    /// </summary>/
    public sealed class MaturityMonthYearFormat : QuickFix.Fields.IntField
    {
        public MaturityMonthYearFormat()
            :base(Fields.CustomTags.MaturityMonthYearFormat) {}
        public MaturityMonthYearFormat(int val)
            :base(Fields.CustomTags.MaturityMonthYearFormat, val) {}


        // Field Enumerations
        public const int YEARMONTH_ONLY = 0;
        public const int YEARMONTHDAY = 1;
        public const int YEARMONTHWEEK = 2;
    }


    /// <summary>
    /// StrikeExerciseStyle Field
    /// </summary>/
    public sealed class StrikeExerciseStyle : QuickFix.Fields.IntField
    {
        public StrikeExerciseStyle()
            :base(Fields.CustomTags.StrikeExerciseStyle) {}
        public StrikeExerciseStyle(int val)
            :base(Fields.CustomTags.StrikeExerciseStyle, val) {}

    }


    /// <summary>
    /// SecondaryPriceLimitType Field
    /// </summary>/
    public sealed class SecondaryPriceLimitType : QuickFix.Fields.IntField
    {
        public SecondaryPriceLimitType()
            :base(Fields.CustomTags.SecondaryPriceLimitType) {}
        public SecondaryPriceLimitType(int val)
            :base(Fields.CustomTags.SecondaryPriceLimitType, val) {}

    }


    /// <summary>
    /// PriceLimitType Field
    /// </summary>/
    public sealed class PriceLimitType : QuickFix.Fields.IntField
    {
        public PriceLimitType()
            :base(Fields.CustomTags.PriceLimitType) {}
        public PriceLimitType(int val)
            :base(Fields.CustomTags.PriceLimitType, val) {}


        // Field Enumerations
        public const int PRICE = 0;
        public const int TICKS = 1;
        public const int PERCENTAGE = 2;
    }


    /// <summary>
    /// DerivativeSecurityListRequestType Field
    /// </summary>/
    public sealed class DerivativeSecurityListRequestType : QuickFix.Fields.IntField
    {
        public DerivativeSecurityListRequestType()
            :base(Fields.CustomTags.DerivativeSecurityListRequestType) {}
        public DerivativeSecurityListRequestType(int val)
            :base(Fields.CustomTags.DerivativeSecurityListRequestType, val) {}


        // Field Enumerations
        public const int SYMBOL = 0;
        public const int SECURITYTYPE_AND_OR_CFICODE = 1;
        public const int PRODUCT = 2;
        public const int TRADINGSESSIONID = 3;
        public const int ALL_SECURITIES = 4;
        public const int UNDELYINGSYMBOL = 5;
        public const int UNDERLYING_SECURITYTYPE_AND_OR_CFICODE = 6;
        public const int UNDERLYING_PRODUCT = 7;
        public const int MARKETID_OR_MARKETID_PLUS_MARKETSEGMENTID = 8;
    }


    /// <summary>
    /// ExecInstValue Field
    /// </summary>/
    public sealed class ExecInstValue : QuickFix.Fields.CharField
    {
        public ExecInstValue()
            :base(Fields.CustomTags.ExecInstValue) {}
        public ExecInstValue(char val)
            :base(Fields.CustomTags.ExecInstValue, val) {}

    }


    /// <summary>
    /// NoTradingSessionRules Field
    /// </summary>/
    public sealed class NoTradingSessionRules : QuickFix.Fields.IntField
    {
        public NoTradingSessionRules()
            :base(Fields.CustomTags.NoTradingSessionRules) {}
        public NoTradingSessionRules(int val)
            :base(Fields.CustomTags.NoTradingSessionRules, val) {}

    }


    /// <summary>
    /// NoMarketSegments Field
    /// </summary>/
    public sealed class NoMarketSegments : QuickFix.Fields.IntField
    {
        public NoMarketSegments()
            :base(Fields.CustomTags.NoMarketSegments) {}
        public NoMarketSegments(int val)
            :base(Fields.CustomTags.NoMarketSegments, val) {}

    }


    /// <summary>
    /// NoDerivativeInstrAttrib Field
    /// </summary>/
    public sealed class NoDerivativeInstrAttrib : QuickFix.Fields.IntField
    {
        public NoDerivativeInstrAttrib()
            :base(Fields.CustomTags.NoDerivativeInstrAttrib) {}
        public NoDerivativeInstrAttrib(int val)
            :base(Fields.CustomTags.NoDerivativeInstrAttrib, val) {}

    }


    /// <summary>
    /// NoNestedInstrAttrib Field
    /// </summary>/
    public sealed class NoNestedInstrAttrib : QuickFix.Fields.IntField
    {
        public NoNestedInstrAttrib()
            :base(Fields.CustomTags.NoNestedInstrAttrib) {}
        public NoNestedInstrAttrib(int val)
            :base(Fields.CustomTags.NoNestedInstrAttrib, val) {}

    }


    /// <summary>
    /// DerivativeInstrAttribType Field
    /// </summary>/
    public sealed class DerivativeInstrAttribType : QuickFix.Fields.IntField
    {
        public DerivativeInstrAttribType()
            :base(Fields.CustomTags.DerivativeInstrAttribType) {}
        public DerivativeInstrAttribType(int val)
            :base(Fields.CustomTags.DerivativeInstrAttribType, val) {}

    }


    /// <summary>
    /// DerivativeInstrAttribValue Field
    /// </summary>/
    public sealed class DerivativeInstrAttribValue : QuickFix.Fields.StringField
    {
        public DerivativeInstrAttribValue()
            :base(Fields.CustomTags.DerivativeInstrAttribValue) {}
        public DerivativeInstrAttribValue(string val)
            :base(Fields.CustomTags.DerivativeInstrAttribValue, val) {}

    }


    /// <summary>
    /// DerivativePriceUnitOfMeasure Field
    /// </summary>/
    public sealed class DerivativePriceUnitOfMeasure : QuickFix.Fields.StringField
    {
        public DerivativePriceUnitOfMeasure()
            :base(Fields.CustomTags.DerivativePriceUnitOfMeasure) {}
        public DerivativePriceUnitOfMeasure(string val)
            :base(Fields.CustomTags.DerivativePriceUnitOfMeasure, val) {}

    }


    /// <summary>
    /// DerivativePriceUnitOfMeasureQty Field
    /// </summary>/
    public sealed class DerivativePriceUnitOfMeasureQty : QuickFix.Fields.DecimalField
    {
        public DerivativePriceUnitOfMeasureQty()
            :base(Fields.CustomTags.DerivativePriceUnitOfMeasureQty) {}
        public DerivativePriceUnitOfMeasureQty(Decimal val)
            :base(Fields.CustomTags.DerivativePriceUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// DerivativeSettlMethod Field
    /// </summary>/
    public sealed class DerivativeSettlMethod : QuickFix.Fields.CharField
    {
        public DerivativeSettlMethod()
            :base(Fields.CustomTags.DerivativeSettlMethod) {}
        public DerivativeSettlMethod(char val)
            :base(Fields.CustomTags.DerivativeSettlMethod, val) {}

    }


    /// <summary>
    /// DerivativePriceQuoteMethod Field
    /// </summary>/
    public sealed class DerivativePriceQuoteMethod : QuickFix.Fields.StringField
    {
        public DerivativePriceQuoteMethod()
            :base(Fields.CustomTags.DerivativePriceQuoteMethod) {}
        public DerivativePriceQuoteMethod(string val)
            :base(Fields.CustomTags.DerivativePriceQuoteMethod, val) {}

    }


    /// <summary>
    /// DerivativeFuturesValuationMethod Field
    /// </summary>/
    public sealed class DerivativeFuturesValuationMethod : QuickFix.Fields.StringField
    {
        public DerivativeFuturesValuationMethod()
            :base(Fields.CustomTags.DerivativeFuturesValuationMethod) {}
        public DerivativeFuturesValuationMethod(string val)
            :base(Fields.CustomTags.DerivativeFuturesValuationMethod, val) {}

    }


    /// <summary>
    /// DerivativeListMethod Field
    /// </summary>/
    public sealed class DerivativeListMethod : QuickFix.Fields.IntField
    {
        public DerivativeListMethod()
            :base(Fields.CustomTags.DerivativeListMethod) {}
        public DerivativeListMethod(int val)
            :base(Fields.CustomTags.DerivativeListMethod, val) {}

    }


    /// <summary>
    /// DerivativeCapPrice Field
    /// </summary>/
    public sealed class DerivativeCapPrice : QuickFix.Fields.DecimalField
    {
        public DerivativeCapPrice()
            :base(Fields.CustomTags.DerivativeCapPrice) {}
        public DerivativeCapPrice(Decimal val)
            :base(Fields.CustomTags.DerivativeCapPrice, val) {}

    }


    /// <summary>
    /// DerivativeFloorPrice Field
    /// </summary>/
    public sealed class DerivativeFloorPrice : QuickFix.Fields.DecimalField
    {
        public DerivativeFloorPrice()
            :base(Fields.CustomTags.DerivativeFloorPrice) {}
        public DerivativeFloorPrice(Decimal val)
            :base(Fields.CustomTags.DerivativeFloorPrice, val) {}

    }


    /// <summary>
    /// DerivativePutOrCall Field
    /// </summary>/
    public sealed class DerivativePutOrCall : QuickFix.Fields.IntField
    {
        public DerivativePutOrCall()
            :base(Fields.CustomTags.DerivativePutOrCall) {}
        public DerivativePutOrCall(int val)
            :base(Fields.CustomTags.DerivativePutOrCall, val) {}

    }


    /// <summary>
    /// ListUpdateAction Field
    /// </summary>/
    public sealed class ListUpdateAction : QuickFix.Fields.CharField
    {
        public ListUpdateAction()
            :base(Fields.CustomTags.ListUpdateAction) {}
        public ListUpdateAction(char val)
            :base(Fields.CustomTags.ListUpdateAction, val) {}

    }


    /// <summary>
    /// ParentMktSegmID Field
    /// </summary>/
    public sealed class ParentMktSegmID : QuickFix.Fields.StringField
    {
        public ParentMktSegmID()
            :base(Fields.CustomTags.ParentMktSegmID) {}
        public ParentMktSegmID(string val)
            :base(Fields.CustomTags.ParentMktSegmID, val) {}

    }


    /// <summary>
    /// TradingSessionDesc Field
    /// </summary>/
    public sealed class TradingSessionDesc : QuickFix.Fields.StringField
    {
        public TradingSessionDesc()
            :base(Fields.CustomTags.TradingSessionDesc) {}
        public TradingSessionDesc(string val)
            :base(Fields.CustomTags.TradingSessionDesc, val) {}

    }


    /// <summary>
    /// TradSesUpdateAction Field
    /// </summary>/
    public sealed class TradSesUpdateAction : QuickFix.Fields.CharField
    {
        public TradSesUpdateAction()
            :base(Fields.CustomTags.TradSesUpdateAction) {}
        public TradSesUpdateAction(char val)
            :base(Fields.CustomTags.TradSesUpdateAction, val) {}

    }


    /// <summary>
    /// RejectText Field
    /// </summary>/
    public sealed class RejectText : QuickFix.Fields.StringField
    {
        public RejectText()
            :base(Fields.CustomTags.RejectText) {}
        public RejectText(string val)
            :base(Fields.CustomTags.RejectText, val) {}

    }


    /// <summary>
    /// FeeMultiplier Field
    /// </summary>/
    public sealed class FeeMultiplier : QuickFix.Fields.DecimalField
    {
        public FeeMultiplier()
            :base(Fields.CustomTags.FeeMultiplier) {}
        public FeeMultiplier(Decimal val)
            :base(Fields.CustomTags.FeeMultiplier, val) {}

    }


    /// <summary>
    /// UnderlyingLegSymbol Field
    /// </summary>/
    public sealed class UnderlyingLegSymbol : QuickFix.Fields.StringField
    {
        public UnderlyingLegSymbol()
            :base(Fields.CustomTags.UnderlyingLegSymbol) {}
        public UnderlyingLegSymbol(string val)
            :base(Fields.CustomTags.UnderlyingLegSymbol, val) {}

    }


    /// <summary>
    /// UnderlyingLegSymbolSfx Field
    /// </summary>/
    public sealed class UnderlyingLegSymbolSfx : QuickFix.Fields.StringField
    {
        public UnderlyingLegSymbolSfx()
            :base(Fields.CustomTags.UnderlyingLegSymbolSfx) {}
        public UnderlyingLegSymbolSfx(string val)
            :base(Fields.CustomTags.UnderlyingLegSymbolSfx, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityID Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityID : QuickFix.Fields.StringField
    {
        public UnderlyingLegSecurityID()
            :base(Fields.CustomTags.UnderlyingLegSecurityID) {}
        public UnderlyingLegSecurityID(string val)
            :base(Fields.CustomTags.UnderlyingLegSecurityID, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityIDSource Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityIDSource : QuickFix.Fields.StringField
    {
        public UnderlyingLegSecurityIDSource()
            :base(Fields.CustomTags.UnderlyingLegSecurityIDSource) {}
        public UnderlyingLegSecurityIDSource(string val)
            :base(Fields.CustomTags.UnderlyingLegSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoUnderlyingLegSecurityAltID Field
    /// </summary>/
    public sealed class NoUnderlyingLegSecurityAltID : QuickFix.Fields.IntField
    {
        public NoUnderlyingLegSecurityAltID()
            :base(Fields.CustomTags.NoUnderlyingLegSecurityAltID) {}
        public NoUnderlyingLegSecurityAltID(int val)
            :base(Fields.CustomTags.NoUnderlyingLegSecurityAltID, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityAltID Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityAltID : QuickFix.Fields.StringField
    {
        public UnderlyingLegSecurityAltID()
            :base(Fields.CustomTags.UnderlyingLegSecurityAltID) {}
        public UnderlyingLegSecurityAltID(string val)
            :base(Fields.CustomTags.UnderlyingLegSecurityAltID, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityAltIDSource Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityAltIDSource : QuickFix.Fields.StringField
    {
        public UnderlyingLegSecurityAltIDSource()
            :base(Fields.CustomTags.UnderlyingLegSecurityAltIDSource) {}
        public UnderlyingLegSecurityAltIDSource(string val)
            :base(Fields.CustomTags.UnderlyingLegSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityType Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityType : QuickFix.Fields.StringField
    {
        public UnderlyingLegSecurityType()
            :base(Fields.CustomTags.UnderlyingLegSecurityType) {}
        public UnderlyingLegSecurityType(string val)
            :base(Fields.CustomTags.UnderlyingLegSecurityType, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecuritySubType Field
    /// </summary>/
    public sealed class UnderlyingLegSecuritySubType : QuickFix.Fields.StringField
    {
        public UnderlyingLegSecuritySubType()
            :base(Fields.CustomTags.UnderlyingLegSecuritySubType) {}
        public UnderlyingLegSecuritySubType(string val)
            :base(Fields.CustomTags.UnderlyingLegSecuritySubType, val) {}

    }


    /// <summary>
    /// UnderlyingLegMaturityMonthYear Field
    /// </summary>/
    public sealed class UnderlyingLegMaturityMonthYear : QuickFix.Fields.StringField
    {
        public UnderlyingLegMaturityMonthYear()
            :base(Fields.CustomTags.UnderlyingLegMaturityMonthYear) {}
        public UnderlyingLegMaturityMonthYear(string val)
            :base(Fields.CustomTags.UnderlyingLegMaturityMonthYear, val) {}

    }


    /// <summary>
    /// UnderlyingLegStrikePrice Field
    /// </summary>/
    public sealed class UnderlyingLegStrikePrice : QuickFix.Fields.DecimalField
    {
        public UnderlyingLegStrikePrice()
            :base(Fields.CustomTags.UnderlyingLegStrikePrice) {}
        public UnderlyingLegStrikePrice(Decimal val)
            :base(Fields.CustomTags.UnderlyingLegStrikePrice, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityExchange Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityExchange : QuickFix.Fields.StringField
    {
        public UnderlyingLegSecurityExchange()
            :base(Fields.CustomTags.UnderlyingLegSecurityExchange) {}
        public UnderlyingLegSecurityExchange(string val)
            :base(Fields.CustomTags.UnderlyingLegSecurityExchange, val) {}

    }


    /// <summary>
    /// NoOfLegUnderlyings Field
    /// </summary>/
    public sealed class NoOfLegUnderlyings : QuickFix.Fields.IntField
    {
        public NoOfLegUnderlyings()
            :base(Fields.CustomTags.NoOfLegUnderlyings) {}
        public NoOfLegUnderlyings(int val)
            :base(Fields.CustomTags.NoOfLegUnderlyings, val) {}

    }


    /// <summary>
    /// UnderlyingLegPutOrCall Field
    /// </summary>/
    public sealed class UnderlyingLegPutOrCall : QuickFix.Fields.IntField
    {
        public UnderlyingLegPutOrCall()
            :base(Fields.CustomTags.UnderlyingLegPutOrCall) {}
        public UnderlyingLegPutOrCall(int val)
            :base(Fields.CustomTags.UnderlyingLegPutOrCall, val) {}

    }


    /// <summary>
    /// UnderlyingLegCFICode Field
    /// </summary>/
    public sealed class UnderlyingLegCFICode : QuickFix.Fields.StringField
    {
        public UnderlyingLegCFICode()
            :base(Fields.CustomTags.UnderlyingLegCFICode) {}
        public UnderlyingLegCFICode(string val)
            :base(Fields.CustomTags.UnderlyingLegCFICode, val) {}

    }


    /// <summary>
    /// UnderlyingLegMaturityDate Field
    /// </summary>/
    public sealed class UnderlyingLegMaturityDate : QuickFix.Fields.StringField
    {
        public UnderlyingLegMaturityDate()
            :base(Fields.CustomTags.UnderlyingLegMaturityDate) {}
        public UnderlyingLegMaturityDate(string val)
            :base(Fields.CustomTags.UnderlyingLegMaturityDate, val) {}

    }


    /// <summary>
    /// ApplReqID Field
    /// </summary>/
    public sealed class ApplReqID : QuickFix.Fields.StringField
    {
        public ApplReqID()
            :base(Fields.CustomTags.ApplReqID) {}
        public ApplReqID(string val)
            :base(Fields.CustomTags.ApplReqID, val) {}

    }


    /// <summary>
    /// ApplReqType Field
    /// </summary>/
    public sealed class ApplReqType : QuickFix.Fields.IntField
    {
        public ApplReqType()
            :base(Fields.CustomTags.ApplReqType) {}
        public ApplReqType(int val)
            :base(Fields.CustomTags.ApplReqType, val) {}


        // Field Enumerations
        public const int RETRANSMISSION_OF_APPLICATION_MESSAGES_FOR_THE_SPECIFIED_APPLICATIONS = 0;
        public const int SUBSCRIPTION_TO_THE_SPECIFIED_APPLICATIONS = 1;
        public const int REQUEST_FOR_THE_LAST_APPLLASTSEQNUM_PUBLISHED_FOR_THE_SPECIFIED_APPLICATIONS = 2;
        public const int REQUEST_VALID_SET_OF_APPLICATIONS = 3;
        public const int UNSUBSCRIBE_TO_THE_SPECIFIED_APPLICATIONS = 4;
        public const int CANCEL_RETRANSMISSION = 5;
        public const int CANCEL_RETRANSMISSION_AND_UNSUBSCRIBE_TO_THE_SPECIFIED_APPLICATIONS = 6;
    }


    /// <summary>
    /// ApplResponseType Field
    /// </summary>/
    public sealed class ApplResponseType : QuickFix.Fields.IntField
    {
        public ApplResponseType()
            :base(Fields.CustomTags.ApplResponseType) {}
        public ApplResponseType(int val)
            :base(Fields.CustomTags.ApplResponseType, val) {}


        // Field Enumerations
        public const int REQUEST_SUCCESSFULLY_PROCESSED = 0;
        public const int APPLICATION_DOES_NOT_EXIST = 1;
        public const int MESSAGES_NOT_AVAILABLE = 2;
    }


    /// <summary>
    /// ApplTotalMessageCount Field
    /// </summary>/
    public sealed class ApplTotalMessageCount : QuickFix.Fields.IntField
    {
        public ApplTotalMessageCount()
            :base(Fields.CustomTags.ApplTotalMessageCount) {}
        public ApplTotalMessageCount(int val)
            :base(Fields.CustomTags.ApplTotalMessageCount, val) {}

    }


    /// <summary>
    /// ApplLastSeqNum Field
    /// </summary>/
    public sealed class ApplLastSeqNum : QuickFix.Fields.IntField
    {
        public ApplLastSeqNum()
            :base(Fields.CustomTags.ApplLastSeqNum) {}
        public ApplLastSeqNum(int val)
            :base(Fields.CustomTags.ApplLastSeqNum, val) {}

    }


    /// <summary>
    /// NoApplIDs Field
    /// </summary>/
    public sealed class NoApplIDs : QuickFix.Fields.IntField
    {
        public NoApplIDs()
            :base(Fields.CustomTags.NoApplIDs) {}
        public NoApplIDs(int val)
            :base(Fields.CustomTags.NoApplIDs, val) {}

    }


    /// <summary>
    /// ApplResendFlag Field
    /// </summary>/
    public sealed class ApplResendFlag : QuickFix.Fields.BooleanField
    {
        public ApplResendFlag()
            :base(Fields.CustomTags.ApplResendFlag) {}
        public ApplResendFlag(Boolean val)
            :base(Fields.CustomTags.ApplResendFlag, val) {}

    }


    /// <summary>
    /// ApplResponseID Field
    /// </summary>/
    public sealed class ApplResponseID : QuickFix.Fields.StringField
    {
        public ApplResponseID()
            :base(Fields.CustomTags.ApplResponseID) {}
        public ApplResponseID(string val)
            :base(Fields.CustomTags.ApplResponseID, val) {}

    }


    /// <summary>
    /// ApplResponseError Field
    /// </summary>/
    public sealed class ApplResponseError : QuickFix.Fields.IntField
    {
        public ApplResponseError()
            :base(Fields.CustomTags.ApplResponseError) {}
        public ApplResponseError(int val)
            :base(Fields.CustomTags.ApplResponseError, val) {}


        // Field Enumerations
        public const int APPLICATION_DOES_NOT_EXIST = 0;
        public const int MESSAGES_REQUESTED_ARE_NOT_AVAILABLE = 1;
        public const int USER_NOT_AUTHORIZED_FOR_APPLICATION = 2;
    }


    /// <summary>
    /// RefApplID Field
    /// </summary>/
    public sealed class RefApplID : QuickFix.Fields.StringField
    {
        public RefApplID()
            :base(Fields.CustomTags.RefApplID) {}
        public RefApplID(string val)
            :base(Fields.CustomTags.RefApplID, val) {}

    }


    /// <summary>
    /// ApplReportID Field
    /// </summary>/
    public sealed class ApplReportID : QuickFix.Fields.StringField
    {
        public ApplReportID()
            :base(Fields.CustomTags.ApplReportID) {}
        public ApplReportID(string val)
            :base(Fields.CustomTags.ApplReportID, val) {}

    }


    /// <summary>
    /// RefApplLastSeqNum Field
    /// </summary>/
    public sealed class RefApplLastSeqNum : QuickFix.Fields.IntField
    {
        public RefApplLastSeqNum()
            :base(Fields.CustomTags.RefApplLastSeqNum) {}
        public RefApplLastSeqNum(int val)
            :base(Fields.CustomTags.RefApplLastSeqNum, val) {}

    }


    /// <summary>
    /// EncodedSymbolLen Field
    /// </summary>/
    public sealed class EncodedSymbolLen : QuickFix.Fields.IntField
    {
        public EncodedSymbolLen()
            :base(Fields.CustomTags.EncodedSymbolLen) {}
        public EncodedSymbolLen(int val)
            :base(Fields.CustomTags.EncodedSymbolLen, val) {}

    }


    /// <summary>
    /// EncodedSymbol Field
    /// </summary>/
    public sealed class EncodedSymbol : QuickFix.Fields.StringField
    {
        public EncodedSymbol()
            :base(Fields.CustomTags.EncodedSymbol) {}
        public EncodedSymbol(string val)
            :base(Fields.CustomTags.EncodedSymbol, val) {}

    }


    /// <summary>
    /// TotNoFills Field
    /// </summary>/
    public sealed class TotNoFills : QuickFix.Fields.IntField
    {
        public TotNoFills()
            :base(Fields.CustomTags.TotNoFills) {}
        public TotNoFills(int val)
            :base(Fields.CustomTags.TotNoFills, val) {}

    }


    /// <summary>
    /// LegAllocSettlCurrency Field
    /// </summary>/
    public sealed class LegAllocSettlCurrency : QuickFix.Fields.StringField
    {
        public LegAllocSettlCurrency()
            :base(Fields.CustomTags.LegAllocSettlCurrency) {}
        public LegAllocSettlCurrency(string val)
            :base(Fields.CustomTags.LegAllocSettlCurrency, val) {}

    }


    /// <summary>
    /// TradSesEvent Field
    /// </summary>/
    public sealed class TradSesEvent : QuickFix.Fields.IntField
    {
        public TradSesEvent()
            :base(Fields.CustomTags.TradSesEvent) {}
        public TradSesEvent(int val)
            :base(Fields.CustomTags.TradSesEvent, val) {}


        // Field Enumerations
        public const int TRADING_RESUMES = 0;
        public const int CHANGE_OF_TRADING_SESSION = 1;
        public const int CHANGE_OF_TRADING_SUBSESSION = 2;
        public const int CHANGE_OF_TRADING_STATUS = 3;
    }


    /// <summary>
    /// NoNotAffectedOrders Field
    /// </summary>/
    public sealed class NoNotAffectedOrders : QuickFix.Fields.IntField
    {
        public NoNotAffectedOrders()
            :base(Fields.CustomTags.NoNotAffectedOrders) {}
        public NoNotAffectedOrders(int val)
            :base(Fields.CustomTags.NoNotAffectedOrders, val) {}

    }


    /// <summary>
    /// NotAffectedOrderID Field
    /// </summary>/
    public sealed class NotAffectedOrderID : QuickFix.Fields.StringField
    {
        public NotAffectedOrderID()
            :base(Fields.CustomTags.NotAffectedOrderID) {}
        public NotAffectedOrderID(string val)
            :base(Fields.CustomTags.NotAffectedOrderID, val) {}

    }


    /// <summary>
    /// NotAffOrigClOrdID Field
    /// </summary>/
    public sealed class NotAffOrigClOrdID : QuickFix.Fields.StringField
    {
        public NotAffOrigClOrdID()
            :base(Fields.CustomTags.NotAffOrigClOrdID) {}
        public NotAffOrigClOrdID(string val)
            :base(Fields.CustomTags.NotAffOrigClOrdID, val) {}

    }


    /// <summary>
    /// MassActionRejectReason Field
    /// </summary>/
    public sealed class MassActionRejectReason : QuickFix.Fields.IntField
    {
        public MassActionRejectReason()
            :base(Fields.CustomTags.MassActionRejectReason) {}
        public MassActionRejectReason(int val)
            :base(Fields.CustomTags.MassActionRejectReason, val) {}


        // Field Enumerations
        public const int MASS_ACTION_NOT_SUPPORTED = 0;
        public const int INVALID_OR_UNKNOWN_SECURITY = 1;
        public const int INVALID_OR_UNKNOWN_UNDERLYING_SECURITY = 2;
        public const int INVALID_OR_UNKNOWN_PRODUCT = 3;
        public const int INVALID_OR_UNKNOWN_CFICODE = 4;
        public const int INVALID_OR_UNKNOWN_SECURITYTYPE = 5;
        public const int INVALID_OR_UNKNOWN_TRADING_SESSION = 6;
        public const int INVALID_OR_UNKNOWN_MARKET = 7;
        public const int INVALID_OR_UNKNOWN_MARKET_SEGMENT = 8;
        public const int INVALID_OR_UNKNOWN_SECURITY_GROUP = 9;
        public const int OTHER = 99;
        public const int INVALID_OR_UNKNOWN_SECURITY_ISSUER = 10;
        public const int INVALID_OR_UNKNOWN_ISSUER_OF_UNDERLYING_SECURITY = 11;
    }


    /// <summary>
    /// MultilegModel Field
    /// </summary>/
    public sealed class MultilegModel : QuickFix.Fields.IntField
    {
        public MultilegModel()
            :base(Fields.CustomTags.MultilegModel) {}
        public MultilegModel(int val)
            :base(Fields.CustomTags.MultilegModel, val) {}


        // Field Enumerations
        public const int PREDEFINED_MULTILEG_SECURITY = 0;
        public const int USER_DEFINED_MULTLEG_SECURITY = 1;
        public const int USER_DEFINED_NON_SECURITIZED_MULTILEG = 2;
    }


    /// <summary>
    /// MultilegPriceMethod Field
    /// </summary>/
    public sealed class MultilegPriceMethod : QuickFix.Fields.IntField
    {
        public MultilegPriceMethod()
            :base(Fields.CustomTags.MultilegPriceMethod) {}
        public MultilegPriceMethod(int val)
            :base(Fields.CustomTags.MultilegPriceMethod, val) {}


        // Field Enumerations
        public const int NET_PRICE = 0;
        public const int REVERSED_NET_PRICE = 1;
        public const int YIELD_DIFFERENCE = 2;
        public const int INDIVIDUAL = 3;
        public const int CONTRACT_WEIGHTED_AVERAGE_PRICE = 4;
        public const int MULTIPLIED_PRICE = 5;
    }


    /// <summary>
    /// LegVolatility Field
    /// </summary>/
    public sealed class LegVolatility : QuickFix.Fields.DecimalField
    {
        public LegVolatility()
            :base(Fields.CustomTags.LegVolatility) {}
        public LegVolatility(Decimal val)
            :base(Fields.CustomTags.LegVolatility, val) {}

    }


    /// <summary>
    /// DividendYield Field
    /// </summary>/
    public sealed class DividendYield : QuickFix.Fields.DecimalField
    {
        public DividendYield()
            :base(Fields.CustomTags.DividendYield) {}
        public DividendYield(Decimal val)
            :base(Fields.CustomTags.DividendYield, val) {}

    }


    /// <summary>
    /// LegDividendYield Field
    /// </summary>/
    public sealed class LegDividendYield : QuickFix.Fields.DecimalField
    {
        public LegDividendYield()
            :base(Fields.CustomTags.LegDividendYield) {}
        public LegDividendYield(Decimal val)
            :base(Fields.CustomTags.LegDividendYield, val) {}

    }


    /// <summary>
    /// CurrencyRatio Field
    /// </summary>/
    public sealed class CurrencyRatio : QuickFix.Fields.DecimalField
    {
        public CurrencyRatio()
            :base(Fields.CustomTags.CurrencyRatio) {}
        public CurrencyRatio(Decimal val)
            :base(Fields.CustomTags.CurrencyRatio, val) {}

    }


    /// <summary>
    /// LegCurrencyRatio Field
    /// </summary>/
    public sealed class LegCurrencyRatio : QuickFix.Fields.DecimalField
    {
        public LegCurrencyRatio()
            :base(Fields.CustomTags.LegCurrencyRatio) {}
        public LegCurrencyRatio(Decimal val)
            :base(Fields.CustomTags.LegCurrencyRatio, val) {}

    }


    /// <summary>
    /// LegExecInst Field
    /// </summary>/
    public sealed class LegExecInst : QuickFix.Fields.StringField
    {
        public LegExecInst()
            :base(Fields.CustomTags.LegExecInst) {}
        public LegExecInst(string val)
            :base(Fields.CustomTags.LegExecInst, val) {}

    }


    /// <summary>
    /// ListRejectReason Field
    /// </summary>/
    public sealed class ListRejectReason : QuickFix.Fields.IntField
    {
        public ListRejectReason()
            :base(Fields.CustomTags.ListRejectReason) {}
        public ListRejectReason(int val)
            :base(Fields.CustomTags.ListRejectReason, val) {}


        // Field Enumerations
        public const int BROKER = 0;
        public const int EXCHANGE_CLOSED = 2;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_ORDER = 5;
        public const int DUPLICATE_ORDER = 6;
        public const int UNSUPPORTED_ORDER_CHARACTERISTIC = 11;
        public const int OTHER = 99;
    }


    /// <summary>
    /// NoTrdRepIndicators Field
    /// </summary>/
    public sealed class NoTrdRepIndicators : QuickFix.Fields.IntField
    {
        public NoTrdRepIndicators()
            :base(Fields.CustomTags.NoTrdRepIndicators) {}
        public NoTrdRepIndicators(int val)
            :base(Fields.CustomTags.NoTrdRepIndicators, val) {}

    }


    /// <summary>
    /// TrdRepPartyRole Field
    /// </summary>/
    public sealed class TrdRepPartyRole : QuickFix.Fields.IntField
    {
        public TrdRepPartyRole()
            :base(Fields.CustomTags.TrdRepPartyRole) {}
        public TrdRepPartyRole(int val)
            :base(Fields.CustomTags.TrdRepPartyRole, val) {}

    }


    /// <summary>
    /// TrdRepIndicator Field
    /// </summary>/
    public sealed class TrdRepIndicator : QuickFix.Fields.BooleanField
    {
        public TrdRepIndicator()
            :base(Fields.CustomTags.TrdRepIndicator) {}
        public TrdRepIndicator(Boolean val)
            :base(Fields.CustomTags.TrdRepIndicator, val) {}

    }


    /// <summary>
    /// TradePublishIndicator Field
    /// </summary>/
    public sealed class TradePublishIndicator : QuickFix.Fields.IntField
    {
        public TradePublishIndicator()
            :base(Fields.CustomTags.TradePublishIndicator) {}
        public TradePublishIndicator(int val)
            :base(Fields.CustomTags.TradePublishIndicator, val) {}


        // Field Enumerations
        public const int DO_NOT_PUBLISH_TRADE = 0;
        public const int PUBLISH_TRADE = 1;
        public const int DEFERRED_PUBLICATION = 2;
    }


    /// <summary>
    /// UnderlyingLegOptAttribute Field
    /// </summary>/
    public sealed class UnderlyingLegOptAttribute : QuickFix.Fields.CharField
    {
        public UnderlyingLegOptAttribute()
            :base(Fields.CustomTags.UnderlyingLegOptAttribute) {}
        public UnderlyingLegOptAttribute(char val)
            :base(Fields.CustomTags.UnderlyingLegOptAttribute, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityDesc Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityDesc : QuickFix.Fields.StringField
    {
        public UnderlyingLegSecurityDesc()
            :base(Fields.CustomTags.UnderlyingLegSecurityDesc) {}
        public UnderlyingLegSecurityDesc(string val)
            :base(Fields.CustomTags.UnderlyingLegSecurityDesc, val) {}

    }


    /// <summary>
    /// MarketReqID Field
    /// </summary>/
    public sealed class MarketReqID : QuickFix.Fields.StringField
    {
        public MarketReqID()
            :base(Fields.CustomTags.MarketReqID) {}
        public MarketReqID(string val)
            :base(Fields.CustomTags.MarketReqID, val) {}

    }


    /// <summary>
    /// MarketReportID Field
    /// </summary>/
    public sealed class MarketReportID : QuickFix.Fields.StringField
    {
        public MarketReportID()
            :base(Fields.CustomTags.MarketReportID) {}
        public MarketReportID(string val)
            :base(Fields.CustomTags.MarketReportID, val) {}

    }


    /// <summary>
    /// MarketUpdateAction Field
    /// </summary>/
    public sealed class MarketUpdateAction : QuickFix.Fields.CharField
    {
        public MarketUpdateAction()
            :base(Fields.CustomTags.MarketUpdateAction) {}
        public MarketUpdateAction(char val)
            :base(Fields.CustomTags.MarketUpdateAction, val) {}


        // Field Enumerations
        public const char ADD = 'A';
        public const char DELETE = 'D';
        public const char MODIFY = 'M';
    }


    /// <summary>
    /// MarketSegmentDesc Field
    /// </summary>/
    public sealed class MarketSegmentDesc : QuickFix.Fields.StringField
    {
        public MarketSegmentDesc()
            :base(Fields.CustomTags.MarketSegmentDesc) {}
        public MarketSegmentDesc(string val)
            :base(Fields.CustomTags.MarketSegmentDesc, val) {}

    }


    /// <summary>
    /// EncodedMktSegmDescLen Field
    /// </summary>/
    public sealed class EncodedMktSegmDescLen : QuickFix.Fields.IntField
    {
        public EncodedMktSegmDescLen()
            :base(Fields.CustomTags.EncodedMktSegmDescLen) {}
        public EncodedMktSegmDescLen(int val)
            :base(Fields.CustomTags.EncodedMktSegmDescLen, val) {}

    }


    /// <summary>
    /// EncodedMktSegmDesc Field
    /// </summary>/
    public sealed class EncodedMktSegmDesc : QuickFix.Fields.StringField
    {
        public EncodedMktSegmDesc()
            :base(Fields.CustomTags.EncodedMktSegmDesc) {}
        public EncodedMktSegmDesc(string val)
            :base(Fields.CustomTags.EncodedMktSegmDesc, val) {}

    }


    /// <summary>
    /// ApplNewSeqNum Field
    /// </summary>/
    public sealed class ApplNewSeqNum : QuickFix.Fields.IntField
    {
        public ApplNewSeqNum()
            :base(Fields.CustomTags.ApplNewSeqNum) {}
        public ApplNewSeqNum(int val)
            :base(Fields.CustomTags.ApplNewSeqNum, val) {}

    }


    /// <summary>
    /// EncryptedNewPasswordLen Field
    /// </summary>/
    public sealed class EncryptedNewPasswordLen : QuickFix.Fields.IntField
    {
        public EncryptedNewPasswordLen()
            :base(Fields.CustomTags.EncryptedNewPasswordLen) {}
        public EncryptedNewPasswordLen(int val)
            :base(Fields.CustomTags.EncryptedNewPasswordLen, val) {}

    }


    /// <summary>
    /// EncryptedNewPassword Field
    /// </summary>/
    public sealed class EncryptedNewPassword : QuickFix.Fields.StringField
    {
        public EncryptedNewPassword()
            :base(Fields.CustomTags.EncryptedNewPassword) {}
        public EncryptedNewPassword(string val)
            :base(Fields.CustomTags.EncryptedNewPassword, val) {}

    }


    /// <summary>
    /// UnderlyingLegMaturityTime Field
    /// </summary>/
    public sealed class UnderlyingLegMaturityTime : QuickFix.Fields.StringField
    {
        public UnderlyingLegMaturityTime()
            :base(Fields.CustomTags.UnderlyingLegMaturityTime) {}
        public UnderlyingLegMaturityTime(string val)
            :base(Fields.CustomTags.UnderlyingLegMaturityTime, val) {}

    }


    /// <summary>
    /// RefApplExtID Field
    /// </summary>/
    public sealed class RefApplExtID : QuickFix.Fields.IntField
    {
        public RefApplExtID()
            :base(Fields.CustomTags.RefApplExtID) {}
        public RefApplExtID(int val)
            :base(Fields.CustomTags.RefApplExtID, val) {}

    }


    /// <summary>
    /// DefaultApplExtID Field
    /// </summary>/
    public sealed class DefaultApplExtID : QuickFix.Fields.IntField
    {
        public DefaultApplExtID()
            :base(Fields.CustomTags.DefaultApplExtID) {}
        public DefaultApplExtID(int val)
            :base(Fields.CustomTags.DefaultApplExtID, val) {}

    }


    /// <summary>
    /// DefaultCstmApplVerID Field
    /// </summary>/
    public sealed class DefaultCstmApplVerID : QuickFix.Fields.StringField
    {
        public DefaultCstmApplVerID()
            :base(Fields.CustomTags.DefaultCstmApplVerID) {}
        public DefaultCstmApplVerID(string val)
            :base(Fields.CustomTags.DefaultCstmApplVerID, val) {}

    }


    /// <summary>
    /// SessionStatus Field
    /// </summary>/
    public sealed class SessionStatus : QuickFix.Fields.IntField
    {
        public SessionStatus()
            :base(Fields.CustomTags.SessionStatus) {}
        public SessionStatus(int val)
            :base(Fields.CustomTags.SessionStatus, val) {}


        // Field Enumerations
        public const int SESSION_ACTIVE = 0;
        public const int SESSION_PASSWORD_CHANGED = 1;
        public const int SESSION_PASSWORD_DUE_TO_EXPIRE = 2;
        public const int NEW_SESSION_PASSWORD_DOES_NOT_COMPLY_WITH_POLICY = 3;
        public const int SESSION_LOGOUT_COMPLETE = 4;
        public const int INVALID_USERNAME_OR_PASSWORD = 5;
        public const int ACCOUNT_LOCKED = 6;
        public const int LOGONS_ARE_NOT_ALLOWED_AT_THIS_TIME = 7;
        public const int PASSWORD_EXPIRED = 8;
    }


    /// <summary>
    /// DefaultVerIndicator Field
    /// </summary>/
    public sealed class DefaultVerIndicator : QuickFix.Fields.BooleanField
    {
        public DefaultVerIndicator()
            :base(Fields.CustomTags.DefaultVerIndicator) {}
        public DefaultVerIndicator(Boolean val)
            :base(Fields.CustomTags.DefaultVerIndicator, val) {}

    }


    /// <summary>
    /// Nested4PartySubIDType Field
    /// </summary>/
    public sealed class Nested4PartySubIDType : QuickFix.Fields.IntField
    {
        public Nested4PartySubIDType()
            :base(Fields.CustomTags.Nested4PartySubIDType) {}
        public Nested4PartySubIDType(int val)
            :base(Fields.CustomTags.Nested4PartySubIDType, val) {}

    }


    /// <summary>
    /// Nested4PartySubID Field
    /// </summary>/
    public sealed class Nested4PartySubID : QuickFix.Fields.StringField
    {
        public Nested4PartySubID()
            :base(Fields.CustomTags.Nested4PartySubID) {}
        public Nested4PartySubID(string val)
            :base(Fields.CustomTags.Nested4PartySubID, val) {}

    }


    /// <summary>
    /// NoNested4PartySubIDs Field
    /// </summary>/
    public sealed class NoNested4PartySubIDs : QuickFix.Fields.IntField
    {
        public NoNested4PartySubIDs()
            :base(Fields.CustomTags.NoNested4PartySubIDs) {}
        public NoNested4PartySubIDs(int val)
            :base(Fields.CustomTags.NoNested4PartySubIDs, val) {}

    }


    /// <summary>
    /// NoNested4PartyIDs Field
    /// </summary>/
    public sealed class NoNested4PartyIDs : QuickFix.Fields.IntField
    {
        public NoNested4PartyIDs()
            :base(Fields.CustomTags.NoNested4PartyIDs) {}
        public NoNested4PartyIDs(int val)
            :base(Fields.CustomTags.NoNested4PartyIDs, val) {}

    }


    /// <summary>
    /// Nested4PartyID Field
    /// </summary>/
    public sealed class Nested4PartyID : QuickFix.Fields.StringField
    {
        public Nested4PartyID()
            :base(Fields.CustomTags.Nested4PartyID) {}
        public Nested4PartyID(string val)
            :base(Fields.CustomTags.Nested4PartyID, val) {}

    }


    /// <summary>
    /// Nested4PartyIDSource Field
    /// </summary>/
    public sealed class Nested4PartyIDSource : QuickFix.Fields.CharField
    {
        public Nested4PartyIDSource()
            :base(Fields.CustomTags.Nested4PartyIDSource) {}
        public Nested4PartyIDSource(char val)
            :base(Fields.CustomTags.Nested4PartyIDSource, val) {}

    }


    /// <summary>
    /// Nested4PartyRole Field
    /// </summary>/
    public sealed class Nested4PartyRole : QuickFix.Fields.IntField
    {
        public Nested4PartyRole()
            :base(Fields.CustomTags.Nested4PartyRole) {}
        public Nested4PartyRole(int val)
            :base(Fields.CustomTags.Nested4PartyRole, val) {}

    }


    /// <summary>
    /// UnderlyingExerciseStyle Field
    /// </summary>/
    public sealed class UnderlyingExerciseStyle : QuickFix.Fields.IntField
    {
        public UnderlyingExerciseStyle()
            :base(Fields.CustomTags.UnderlyingExerciseStyle) {}
        public UnderlyingExerciseStyle(int val)
            :base(Fields.CustomTags.UnderlyingExerciseStyle, val) {}

    }


    /// <summary>
    /// LegExerciseStyle Field
    /// </summary>/
    public sealed class LegExerciseStyle : QuickFix.Fields.IntField
    {
        public LegExerciseStyle()
            :base(Fields.CustomTags.LegExerciseStyle) {}
        public LegExerciseStyle(int val)
            :base(Fields.CustomTags.LegExerciseStyle, val) {}

    }


    /// <summary>
    /// LegPriceUnitOfMeasure Field
    /// </summary>/
    public sealed class LegPriceUnitOfMeasure : QuickFix.Fields.StringField
    {
        public LegPriceUnitOfMeasure()
            :base(Fields.CustomTags.LegPriceUnitOfMeasure) {}
        public LegPriceUnitOfMeasure(string val)
            :base(Fields.CustomTags.LegPriceUnitOfMeasure, val) {}

    }


    /// <summary>
    /// LegPriceUnitOfMeasureQty Field
    /// </summary>/
    public sealed class LegPriceUnitOfMeasureQty : QuickFix.Fields.DecimalField
    {
        public LegPriceUnitOfMeasureQty()
            :base(Fields.CustomTags.LegPriceUnitOfMeasureQty) {}
        public LegPriceUnitOfMeasureQty(Decimal val)
            :base(Fields.CustomTags.LegPriceUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// UnderlyingUnitOfMeasureQty Field
    /// </summary>/
    public sealed class UnderlyingUnitOfMeasureQty : QuickFix.Fields.DecimalField
    {
        public UnderlyingUnitOfMeasureQty()
            :base(Fields.CustomTags.UnderlyingUnitOfMeasureQty) {}
        public UnderlyingUnitOfMeasureQty(Decimal val)
            :base(Fields.CustomTags.UnderlyingUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// UnderlyingPriceUnitOfMeasure Field
    /// </summary>/
    public sealed class UnderlyingPriceUnitOfMeasure : QuickFix.Fields.StringField
    {
        public UnderlyingPriceUnitOfMeasure()
            :base(Fields.CustomTags.UnderlyingPriceUnitOfMeasure) {}
        public UnderlyingPriceUnitOfMeasure(string val)
            :base(Fields.CustomTags.UnderlyingPriceUnitOfMeasure, val) {}

    }


    /// <summary>
    /// UnderlyingPriceUnitOfMeasureQty Field
    /// </summary>/
    public sealed class UnderlyingPriceUnitOfMeasureQty : QuickFix.Fields.DecimalField
    {
        public UnderlyingPriceUnitOfMeasureQty()
            :base(Fields.CustomTags.UnderlyingPriceUnitOfMeasureQty) {}
        public UnderlyingPriceUnitOfMeasureQty(Decimal val)
            :base(Fields.CustomTags.UnderlyingPriceUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// ApplReportType Field
    /// </summary>/
    public sealed class ApplReportType : QuickFix.Fields.IntField
    {
        public ApplReportType()
            :base(Fields.CustomTags.ApplReportType) {}
        public ApplReportType(int val)
            :base(Fields.CustomTags.ApplReportType, val) {}


        // Field Enumerations
        public const int RESET_APPLSEQNUM_TO_NEW_VALUE_SPECIFIED_IN_APPLNEWSEQNUM = 0;
        public const int REPORTS_THAT_THE_LAST_MESSAGE_HAS_BEEN_SENT_FOR_THE_APPLIDS_REFER_TO_REFAPPLLASTSEQNUM = 1;
        public const int HEARTBEAT_MESSAGE_INDICATING_THAT_APPLICATION_IDENTIFIED_BY_REFAPPLID = 2;
        public const int APPLICATION_MESSAGE_RE_SEND_COMPLETED = 3;
    }


    /// <summary>
    /// HaltReasonInt Field
    /// </summary>/
    public sealed class HaltReasonInt : QuickFix.Fields.IntField
    {
        public HaltReasonInt()
            :base(Fields.CustomTags.HaltReasonInt) {}
        public HaltReasonInt(int val)
            :base(Fields.CustomTags.HaltReasonInt, val) {}


        // Field Enumerations
        public const int NEWS_DISSEMINATION = 0;
        public const int ORDER_INFLUX = 1;
        public const int ORDER_IMBALANCE = 2;
        public const int ADDITIONAL_INFORMATION = 3;
        public const int NEWS_PENDING = 4;
        public const int EQUIPMENT_CHANGEOVER = 5;
    }


    /// <summary>
    /// SideLastQty Field
    /// </summary>/
    public sealed class SideLastQty : QuickFix.Fields.IntField
    {
        public SideLastQty()
            :base(Fields.CustomTags.SideLastQty) {}
        public SideLastQty(int val)
            :base(Fields.CustomTags.SideLastQty, val) {}

    }


    /// <summary>
    /// UnderlyingInstrumentPartyID Field
    /// </summary>/
    public sealed class UnderlyingInstrumentPartyID : QuickFix.Fields.StringField
    {
        public UnderlyingInstrumentPartyID()
            :base(Fields.CustomTags.UnderlyingInstrumentPartyID) {}
        public UnderlyingInstrumentPartyID(string val)
            :base(Fields.CustomTags.UnderlyingInstrumentPartyID, val) {}

    }


    /// <summary>
    /// UnderlyingInstrumentPartyIDSource Field
    /// </summary>/
    public sealed class UnderlyingInstrumentPartyIDSource : QuickFix.Fields.CharField
    {
        public UnderlyingInstrumentPartyIDSource()
            :base(Fields.CustomTags.UnderlyingInstrumentPartyIDSource) {}
        public UnderlyingInstrumentPartyIDSource(char val)
            :base(Fields.CustomTags.UnderlyingInstrumentPartyIDSource, val) {}

    }


    /// <summary>
    /// UnderlyingInstrumentPartyRole Field
    /// </summary>/
    public sealed class UnderlyingInstrumentPartyRole : QuickFix.Fields.IntField
    {
        public UnderlyingInstrumentPartyRole()
            :base(Fields.CustomTags.UnderlyingInstrumentPartyRole) {}
        public UnderlyingInstrumentPartyRole(int val)
            :base(Fields.CustomTags.UnderlyingInstrumentPartyRole, val) {}

    }


    /// <summary>
    /// UnderlyingInstrumentPartySubID Field
    /// </summary>/
    public sealed class UnderlyingInstrumentPartySubID : QuickFix.Fields.StringField
    {
        public UnderlyingInstrumentPartySubID()
            :base(Fields.CustomTags.UnderlyingInstrumentPartySubID) {}
        public UnderlyingInstrumentPartySubID(string val)
            :base(Fields.CustomTags.UnderlyingInstrumentPartySubID, val) {}

    }


    /// <summary>
    /// UnderlyingInstrumentPartySubIDType Field
    /// </summary>/
    public sealed class UnderlyingInstrumentPartySubIDType : QuickFix.Fields.IntField
    {
        public UnderlyingInstrumentPartySubIDType()
            :base(Fields.CustomTags.UnderlyingInstrumentPartySubIDType) {}
        public UnderlyingInstrumentPartySubIDType(int val)
            :base(Fields.CustomTags.UnderlyingInstrumentPartySubIDType, val) {}

    }


    /// <summary>
    /// OptPayoutAmount Field
    /// </summary>/
    public sealed class OptPayoutAmount : QuickFix.Fields.DecimalField
    {
        public OptPayoutAmount()
            :base(Fields.CustomTags.OptPayoutAmount) {}
        public OptPayoutAmount(Decimal val)
            :base(Fields.CustomTags.OptPayoutAmount, val) {}

    }


    /// <summary>
    /// ValuationMethod Field
    /// </summary>/
    public sealed class ValuationMethod : QuickFix.Fields.StringField
    {
        public ValuationMethod()
            :base(Fields.CustomTags.ValuationMethod) {}
        public ValuationMethod(string val)
            :base(Fields.CustomTags.ValuationMethod, val) {}


        // Field Enumerations
        public const string PREMIUM_STYLE = "EQTY";
        public const string FUTURES_STYLE_MARK_TO_MARKET = "FUT";
        public const string FUTURES_STYLE_WITH_AN_ATTACHED_CASH_ADJUSTMENT = "FUTDA";
        public const string CDS_STYLE_COLLATERALIZATION_OF_MARKET_TO_MARKET_AND_COUPON = "CDS";
        public const string CDS_IN_DELIVERY = "CDSD";
    }


    /// <summary>
    /// DerivativeValuationMethod Field
    /// </summary>/
    public sealed class DerivativeValuationMethod : QuickFix.Fields.StringField
    {
        public DerivativeValuationMethod()
            :base(Fields.CustomTags.DerivativeValuationMethod) {}
        public DerivativeValuationMethod(string val)
            :base(Fields.CustomTags.DerivativeValuationMethod, val) {}

    }


    /// <summary>
    /// SideExecID Field
    /// </summary>/
    public sealed class SideExecID : QuickFix.Fields.StringField
    {
        public SideExecID()
            :base(Fields.CustomTags.SideExecID) {}
        public SideExecID(string val)
            :base(Fields.CustomTags.SideExecID, val) {}

    }


    /// <summary>
    /// OrderDelay Field
    /// </summary>/
    public sealed class OrderDelay : QuickFix.Fields.IntField
    {
        public OrderDelay()
            :base(Fields.CustomTags.OrderDelay) {}
        public OrderDelay(int val)
            :base(Fields.CustomTags.OrderDelay, val) {}

    }


    /// <summary>
    /// OrderDelayUnit Field
    /// </summary>/
    public sealed class OrderDelayUnit : QuickFix.Fields.IntField
    {
        public OrderDelayUnit()
            :base(Fields.CustomTags.OrderDelayUnit) {}
        public OrderDelayUnit(int val)
            :base(Fields.CustomTags.OrderDelayUnit, val) {}


        // Field Enumerations
        public const int SECONDS = 0;
        public const int TENTHS_OF_A_SECOND = 1;
        public const int HUNDREDTHS_OF_A_SECOND = 2;
        public const int MILLISECONDS = 3;
        public const int MICROSECONDS = 4;
        public const int NANOSECONDS = 5;
        public const int MINUTES = 10;
        public const int HOURS = 11;
        public const int DAYS = 12;
        public const int WEEKS = 13;
        public const int MONTHS = 14;
        public const int YEARS = 15;
    }


    /// <summary>
    /// VenueType Field
    /// </summary>/
    public sealed class VenueType : QuickFix.Fields.CharField
    {
        public VenueType()
            :base(Fields.CustomTags.VenueType) {}
        public VenueType(char val)
            :base(Fields.CustomTags.VenueType, val) {}


        // Field Enumerations
        public const char ELECTRONIC = 'E';
        public const char PIT = 'P';
        public const char EX_PIT = 'X';
    }


    /// <summary>
    /// RefOrdIDReason Field
    /// </summary>/
    public sealed class RefOrdIDReason : QuickFix.Fields.IntField
    {
        public RefOrdIDReason()
            :base(Fields.CustomTags.RefOrdIDReason) {}
        public RefOrdIDReason(int val)
            :base(Fields.CustomTags.RefOrdIDReason, val) {}


        // Field Enumerations
        public const int GTC_FROM_PREVIOUS_DAY = 0;
        public const int PARTIAL_FILL_REMAINING = 1;
        public const int ORDER_CHANGED = 2;
    }


    /// <summary>
    /// OrigCustOrderCapacity Field
    /// </summary>/
    public sealed class OrigCustOrderCapacity : QuickFix.Fields.IntField
    {
        public OrigCustOrderCapacity()
            :base(Fields.CustomTags.OrigCustOrderCapacity) {}
        public OrigCustOrderCapacity(int val)
            :base(Fields.CustomTags.OrigCustOrderCapacity, val) {}


        // Field Enumerations
        public const int MEMBER_TRADING_FOR_THEIR_OWN_ACCOUNT = 1;
        public const int CLEARING_FIRM_TRADING_FOR_ITS_PROPRIETARY_ACCOUNT = 2;
        public const int MEMBER_TRADING_FOR_ANOTHER_MEMBER = 3;
        public const int ALL_OTHER = 4;
    }


    /// <summary>
    /// RefApplReqID Field
    /// </summary>/
    public sealed class RefApplReqID : QuickFix.Fields.StringField
    {
        public RefApplReqID()
            :base(Fields.CustomTags.RefApplReqID) {}
        public RefApplReqID(string val)
            :base(Fields.CustomTags.RefApplReqID, val) {}

    }


    /// <summary>
    /// ModelType Field
    /// </summary>/
    public sealed class ModelType : QuickFix.Fields.IntField
    {
        public ModelType()
            :base(Fields.CustomTags.ModelType) {}
        public ModelType(int val)
            :base(Fields.CustomTags.ModelType, val) {}


        // Field Enumerations
        public const int UTILITY_PROVIDED_STANDARD_MODEL = 0;
        public const int PROPRIETARY = 1;
    }


    /// <summary>
    /// ContractMultiplierUnit Field
    /// </summary>/
    public sealed class ContractMultiplierUnit : QuickFix.Fields.IntField
    {
        public ContractMultiplierUnit()
            :base(Fields.CustomTags.ContractMultiplierUnit) {}
        public ContractMultiplierUnit(int val)
            :base(Fields.CustomTags.ContractMultiplierUnit, val) {}


        // Field Enumerations
        public const int SHARES = 0;
        public const int HOURS = 1;
        public const int DAYS = 2;
    }


    /// <summary>
    /// LegContractMultiplierUnit Field
    /// </summary>/
    public sealed class LegContractMultiplierUnit : QuickFix.Fields.IntField
    {
        public LegContractMultiplierUnit()
            :base(Fields.CustomTags.LegContractMultiplierUnit) {}
        public LegContractMultiplierUnit(int val)
            :base(Fields.CustomTags.LegContractMultiplierUnit, val) {}

    }


    /// <summary>
    /// UnderlyingContractMultiplierUnit Field
    /// </summary>/
    public sealed class UnderlyingContractMultiplierUnit : QuickFix.Fields.IntField
    {
        public UnderlyingContractMultiplierUnit()
            :base(Fields.CustomTags.UnderlyingContractMultiplierUnit) {}
        public UnderlyingContractMultiplierUnit(int val)
            :base(Fields.CustomTags.UnderlyingContractMultiplierUnit, val) {}

    }


    /// <summary>
    /// DerivativeContractMultiplierUnit Field
    /// </summary>/
    public sealed class DerivativeContractMultiplierUnit : QuickFix.Fields.IntField
    {
        public DerivativeContractMultiplierUnit()
            :base(Fields.CustomTags.DerivativeContractMultiplierUnit) {}
        public DerivativeContractMultiplierUnit(int val)
            :base(Fields.CustomTags.DerivativeContractMultiplierUnit, val) {}

    }


    /// <summary>
    /// FlowScheduleType Field
    /// </summary>/
    public sealed class FlowScheduleType : QuickFix.Fields.IntField
    {
        public FlowScheduleType()
            :base(Fields.CustomTags.FlowScheduleType) {}
        public FlowScheduleType(int val)
            :base(Fields.CustomTags.FlowScheduleType, val) {}


        // Field Enumerations
        public const int NERC_EASTERN_OFF_PEAK = 0;
        public const int NERC_WESTERN_OFF_PEAK = 1;
        public const int NERC_CALENDAR_ALL_DAYS_IN_MONTH = 2;
        public const int NERC_EASTERN_PEAK = 3;
        public const int NERC_WESTERN_PEAK = 4;
    }


    /// <summary>
    /// LegFlowScheduleType Field
    /// </summary>/
    public sealed class LegFlowScheduleType : QuickFix.Fields.IntField
    {
        public LegFlowScheduleType()
            :base(Fields.CustomTags.LegFlowScheduleType) {}
        public LegFlowScheduleType(int val)
            :base(Fields.CustomTags.LegFlowScheduleType, val) {}

    }


    /// <summary>
    /// UnderlyingFlowScheduleType Field
    /// </summary>/
    public sealed class UnderlyingFlowScheduleType : QuickFix.Fields.IntField
    {
        public UnderlyingFlowScheduleType()
            :base(Fields.CustomTags.UnderlyingFlowScheduleType) {}
        public UnderlyingFlowScheduleType(int val)
            :base(Fields.CustomTags.UnderlyingFlowScheduleType, val) {}

    }


    /// <summary>
    /// DerivativeFlowScheduleType Field
    /// </summary>/
    public sealed class DerivativeFlowScheduleType : QuickFix.Fields.IntField
    {
        public DerivativeFlowScheduleType()
            :base(Fields.CustomTags.DerivativeFlowScheduleType) {}
        public DerivativeFlowScheduleType(int val)
            :base(Fields.CustomTags.DerivativeFlowScheduleType, val) {}

    }


    /// <summary>
    /// FillLiquidityInd Field
    /// </summary>/
    public sealed class FillLiquidityInd : QuickFix.Fields.IntField
    {
        public FillLiquidityInd()
            :base(Fields.CustomTags.FillLiquidityInd) {}
        public FillLiquidityInd(int val)
            :base(Fields.CustomTags.FillLiquidityInd, val) {}

    }


    /// <summary>
    /// SideLiquidityInd Field
    /// </summary>/
    public sealed class SideLiquidityInd : QuickFix.Fields.IntField
    {
        public SideLiquidityInd()
            :base(Fields.CustomTags.SideLiquidityInd) {}
        public SideLiquidityInd(int val)
            :base(Fields.CustomTags.SideLiquidityInd, val) {}

    }


    /// <summary>
    /// NoRateSources Field
    /// </summary>/
    public sealed class NoRateSources : QuickFix.Fields.IntField
    {
        public NoRateSources()
            :base(Fields.CustomTags.NoRateSources) {}
        public NoRateSources(int val)
            :base(Fields.CustomTags.NoRateSources, val) {}

    }


    /// <summary>
    /// RateSource Field
    /// </summary>/
    public sealed class RateSource : QuickFix.Fields.IntField
    {
        public RateSource()
            :base(Fields.CustomTags.RateSource) {}
        public RateSource(int val)
            :base(Fields.CustomTags.RateSource, val) {}


        // Field Enumerations
        public const int BLOOMBERG = 0;
        public const int REUTERS = 1;
        public const int TELERATE = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// RateSourceType Field
    /// </summary>/
    public sealed class RateSourceType : QuickFix.Fields.IntField
    {
        public RateSourceType()
            :base(Fields.CustomTags.RateSourceType) {}
        public RateSourceType(int val)
            :base(Fields.CustomTags.RateSourceType, val) {}


        // Field Enumerations
        public const int PRIMARY = 0;
        public const int SECONDARY = 1;
    }


    /// <summary>
    /// ReferencePage Field
    /// </summary>/
    public sealed class ReferencePage : QuickFix.Fields.StringField
    {
        public ReferencePage()
            :base(Fields.CustomTags.ReferencePage) {}
        public ReferencePage(string val)
            :base(Fields.CustomTags.ReferencePage, val) {}

    }


    /// <summary>
    /// RestructuringType Field
    /// </summary>/
    public sealed class RestructuringType : QuickFix.Fields.StringField
    {
        public RestructuringType()
            :base(Fields.CustomTags.RestructuringType) {}
        public RestructuringType(string val)
            :base(Fields.CustomTags.RestructuringType, val) {}


        // Field Enumerations
        public const string FULL_RESTRUCTURING = "FR";
        public const string MODIFIED_RESTRUCTURING = "MR";
        public const string MODIFIED_MOD_RESTRUCTURING = "MM";
        public const string NO_RESTRUCTURING_SPECIFIED = "XR";
    }


    /// <summary>
    /// Seniority Field
    /// </summary>/
    public sealed class Seniority : QuickFix.Fields.StringField
    {
        public Seniority()
            :base(Fields.CustomTags.Seniority) {}
        public Seniority(string val)
            :base(Fields.CustomTags.Seniority, val) {}


        // Field Enumerations
        public const string SENIOR_SECURED = "SD";
        public const string SENIOR = "SR";
        public const string SUBORDINATED = "SB";
    }


    /// <summary>
    /// NotionalPercentageOutstanding Field
    /// </summary>/
    public sealed class NotionalPercentageOutstanding : QuickFix.Fields.DecimalField
    {
        public NotionalPercentageOutstanding()
            :base(Fields.CustomTags.NotionalPercentageOutstanding) {}
        public NotionalPercentageOutstanding(Decimal val)
            :base(Fields.CustomTags.NotionalPercentageOutstanding, val) {}

    }


    /// <summary>
    /// OriginalNotionalPercentageOutstanding Field
    /// </summary>/
    public sealed class OriginalNotionalPercentageOutstanding : QuickFix.Fields.DecimalField
    {
        public OriginalNotionalPercentageOutstanding()
            :base(Fields.CustomTags.OriginalNotionalPercentageOutstanding) {}
        public OriginalNotionalPercentageOutstanding(Decimal val)
            :base(Fields.CustomTags.OriginalNotionalPercentageOutstanding, val) {}

    }


    /// <summary>
    /// UnderlyingRestructuringType Field
    /// </summary>/
    public sealed class UnderlyingRestructuringType : QuickFix.Fields.StringField
    {
        public UnderlyingRestructuringType()
            :base(Fields.CustomTags.UnderlyingRestructuringType) {}
        public UnderlyingRestructuringType(string val)
            :base(Fields.CustomTags.UnderlyingRestructuringType, val) {}

    }


    /// <summary>
    /// UnderlyingSeniority Field
    /// </summary>/
    public sealed class UnderlyingSeniority : QuickFix.Fields.StringField
    {
        public UnderlyingSeniority()
            :base(Fields.CustomTags.UnderlyingSeniority) {}
        public UnderlyingSeniority(string val)
            :base(Fields.CustomTags.UnderlyingSeniority, val) {}

    }


    /// <summary>
    /// UnderlyingNotionalPercentageOutstanding Field
    /// </summary>/
    public sealed class UnderlyingNotionalPercentageOutstanding : QuickFix.Fields.DecimalField
    {
        public UnderlyingNotionalPercentageOutstanding()
            :base(Fields.CustomTags.UnderlyingNotionalPercentageOutstanding) {}
        public UnderlyingNotionalPercentageOutstanding(Decimal val)
            :base(Fields.CustomTags.UnderlyingNotionalPercentageOutstanding, val) {}

    }


    /// <summary>
    /// UnderlyingOriginalNotionalPercentageOutstanding Field
    /// </summary>/
    public sealed class UnderlyingOriginalNotionalPercentageOutstanding : QuickFix.Fields.DecimalField
    {
        public UnderlyingOriginalNotionalPercentageOutstanding()
            :base(Fields.CustomTags.UnderlyingOriginalNotionalPercentageOutstanding) {}
        public UnderlyingOriginalNotionalPercentageOutstanding(Decimal val)
            :base(Fields.CustomTags.UnderlyingOriginalNotionalPercentageOutstanding, val) {}

    }


    /// <summary>
    /// AttachmentPoint Field
    /// </summary>/
    public sealed class AttachmentPoint : QuickFix.Fields.DecimalField
    {
        public AttachmentPoint()
            :base(Fields.CustomTags.AttachmentPoint) {}
        public AttachmentPoint(Decimal val)
            :base(Fields.CustomTags.AttachmentPoint, val) {}

    }


    /// <summary>
    /// DetachmentPoint Field
    /// </summary>/
    public sealed class DetachmentPoint : QuickFix.Fields.DecimalField
    {
        public DetachmentPoint()
            :base(Fields.CustomTags.DetachmentPoint) {}
        public DetachmentPoint(Decimal val)
            :base(Fields.CustomTags.DetachmentPoint, val) {}

    }


    /// <summary>
    /// UnderlyingAttachmentPoint Field
    /// </summary>/
    public sealed class UnderlyingAttachmentPoint : QuickFix.Fields.DecimalField
    {
        public UnderlyingAttachmentPoint()
            :base(Fields.CustomTags.UnderlyingAttachmentPoint) {}
        public UnderlyingAttachmentPoint(Decimal val)
            :base(Fields.CustomTags.UnderlyingAttachmentPoint, val) {}

    }


    /// <summary>
    /// UnderlyingDetachmentPoint Field
    /// </summary>/
    public sealed class UnderlyingDetachmentPoint : QuickFix.Fields.DecimalField
    {
        public UnderlyingDetachmentPoint()
            :base(Fields.CustomTags.UnderlyingDetachmentPoint) {}
        public UnderlyingDetachmentPoint(Decimal val)
            :base(Fields.CustomTags.UnderlyingDetachmentPoint, val) {}

    }


    /// <summary>
    /// NoTargetPartyIDs Field
    /// </summary>/
    public sealed class NoTargetPartyIDs : QuickFix.Fields.IntField
    {
        public NoTargetPartyIDs()
            :base(Fields.CustomTags.NoTargetPartyIDs) {}
        public NoTargetPartyIDs(int val)
            :base(Fields.CustomTags.NoTargetPartyIDs, val) {}

    }


    /// <summary>
    /// TargetPartyID Field
    /// </summary>/
    public sealed class TargetPartyID : QuickFix.Fields.StringField
    {
        public TargetPartyID()
            :base(Fields.CustomTags.TargetPartyID) {}
        public TargetPartyID(string val)
            :base(Fields.CustomTags.TargetPartyID, val) {}

    }


    /// <summary>
    /// TargetPartyIDSource Field
    /// </summary>/
    public sealed class TargetPartyIDSource : QuickFix.Fields.CharField
    {
        public TargetPartyIDSource()
            :base(Fields.CustomTags.TargetPartyIDSource) {}
        public TargetPartyIDSource(char val)
            :base(Fields.CustomTags.TargetPartyIDSource, val) {}

    }


    /// <summary>
    /// TargetPartyRole Field
    /// </summary>/
    public sealed class TargetPartyRole : QuickFix.Fields.IntField
    {
        public TargetPartyRole()
            :base(Fields.CustomTags.TargetPartyRole) {}
        public TargetPartyRole(int val)
            :base(Fields.CustomTags.TargetPartyRole, val) {}

    }


    /// <summary>
    /// SecurityListID Field
    /// </summary>/
    public sealed class SecurityListID : QuickFix.Fields.StringField
    {
        public SecurityListID()
            :base(Fields.CustomTags.SecurityListID) {}
        public SecurityListID(string val)
            :base(Fields.CustomTags.SecurityListID, val) {}

    }


    /// <summary>
    /// SecurityListRefID Field
    /// </summary>/
    public sealed class SecurityListRefID : QuickFix.Fields.StringField
    {
        public SecurityListRefID()
            :base(Fields.CustomTags.SecurityListRefID) {}
        public SecurityListRefID(string val)
            :base(Fields.CustomTags.SecurityListRefID, val) {}

    }


    /// <summary>
    /// SecurityListDesc Field
    /// </summary>/
    public sealed class SecurityListDesc : QuickFix.Fields.StringField
    {
        public SecurityListDesc()
            :base(Fields.CustomTags.SecurityListDesc) {}
        public SecurityListDesc(string val)
            :base(Fields.CustomTags.SecurityListDesc, val) {}

    }


    /// <summary>
    /// EncodedSecurityListDescLen Field
    /// </summary>/
    public sealed class EncodedSecurityListDescLen : QuickFix.Fields.IntField
    {
        public EncodedSecurityListDescLen()
            :base(Fields.CustomTags.EncodedSecurityListDescLen) {}
        public EncodedSecurityListDescLen(int val)
            :base(Fields.CustomTags.EncodedSecurityListDescLen, val) {}

    }


    /// <summary>
    /// EncodedSecurityListDesc Field
    /// </summary>/
    public sealed class EncodedSecurityListDesc : QuickFix.Fields.StringField
    {
        public EncodedSecurityListDesc()
            :base(Fields.CustomTags.EncodedSecurityListDesc) {}
        public EncodedSecurityListDesc(string val)
            :base(Fields.CustomTags.EncodedSecurityListDesc, val) {}

    }


    /// <summary>
    /// SecurityListType Field
    /// </summary>/
    public sealed class SecurityListType : QuickFix.Fields.IntField
    {
        public SecurityListType()
            :base(Fields.CustomTags.SecurityListType) {}
        public SecurityListType(int val)
            :base(Fields.CustomTags.SecurityListType, val) {}


        // Field Enumerations
        public const int INDUSTRY_CLASSIFICATION = 1;
        public const int TRADING_LIST = 2;
        public const int MARKET = 3;
        public const int NEWSPAPER_LIST = 4;
    }


    /// <summary>
    /// SecurityListTypeSource Field
    /// </summary>/
    public sealed class SecurityListTypeSource : QuickFix.Fields.IntField
    {
        public SecurityListTypeSource()
            :base(Fields.CustomTags.SecurityListTypeSource) {}
        public SecurityListTypeSource(int val)
            :base(Fields.CustomTags.SecurityListTypeSource, val) {}


        // Field Enumerations
        public const int ICB = 1;
        public const int NAICS = 2;
        public const int GICS = 3;
    }


    /// <summary>
    /// NewsID Field
    /// </summary>/
    public sealed class NewsID : QuickFix.Fields.StringField
    {
        public NewsID()
            :base(Fields.CustomTags.NewsID) {}
        public NewsID(string val)
            :base(Fields.CustomTags.NewsID, val) {}

    }


    /// <summary>
    /// NewsCategory Field
    /// </summary>/
    public sealed class NewsCategory : QuickFix.Fields.IntField
    {
        public NewsCategory()
            :base(Fields.CustomTags.NewsCategory) {}
        public NewsCategory(int val)
            :base(Fields.CustomTags.NewsCategory, val) {}


        // Field Enumerations
        public const int COMPANY_NEWS = 0;
        public const int MARKETPLACE_NEWS = 1;
        public const int FINANCIAL_MARKET_NEWS = 2;
        public const int TECHNICAL_NEWS = 3;
        public const int OTHER_NEWS = 99;
    }


    /// <summary>
    /// LanguageCode Field
    /// </summary>/
    public sealed class LanguageCode : QuickFix.Fields.StringField
    {
        public LanguageCode()
            :base(Fields.CustomTags.LanguageCode) {}
        public LanguageCode(string val)
            :base(Fields.CustomTags.LanguageCode, val) {}

    }


    /// <summary>
    /// NoNewsRefIDs Field
    /// </summary>/
    public sealed class NoNewsRefIDs : QuickFix.Fields.IntField
    {
        public NoNewsRefIDs()
            :base(Fields.CustomTags.NoNewsRefIDs) {}
        public NoNewsRefIDs(int val)
            :base(Fields.CustomTags.NoNewsRefIDs, val) {}

    }


    /// <summary>
    /// NewsRefID Field
    /// </summary>/
    public sealed class NewsRefID : QuickFix.Fields.StringField
    {
        public NewsRefID()
            :base(Fields.CustomTags.NewsRefID) {}
        public NewsRefID(string val)
            :base(Fields.CustomTags.NewsRefID, val) {}

    }


    /// <summary>
    /// NewsRefType Field
    /// </summary>/
    public sealed class NewsRefType : QuickFix.Fields.IntField
    {
        public NewsRefType()
            :base(Fields.CustomTags.NewsRefType) {}
        public NewsRefType(int val)
            :base(Fields.CustomTags.NewsRefType, val) {}


        // Field Enumerations
        public const int REPLACEMENT = 0;
        public const int OTHER_LANGUAGE = 1;
        public const int COMPLIMENTARY = 2;
    }


    /// <summary>
    /// StrikePriceDeterminationMethod Field
    /// </summary>/
    public sealed class StrikePriceDeterminationMethod : QuickFix.Fields.IntField
    {
        public StrikePriceDeterminationMethod()
            :base(Fields.CustomTags.StrikePriceDeterminationMethod) {}
        public StrikePriceDeterminationMethod(int val)
            :base(Fields.CustomTags.StrikePriceDeterminationMethod, val) {}


        // Field Enumerations
        public const int FIXED_STRIKE = 1;
        public const int STRIKE_SET_AT_EXPIRATION_TO_UNDERLYING_OR_OTHER_VALUE = 2;
        public const int STRIKE_SET_TO_AVERAGE_OF_UNDERLYING_SETTLEMENT_PRICE_ACROSS_THE_LIFE_OF_THE_OPTION = 3;
        public const int STRIKE_SET_TO_OPTIMAL_VALUE = 4;
    }


    /// <summary>
    /// StrikePriceBoundaryMethod Field
    /// </summary>/
    public sealed class StrikePriceBoundaryMethod : QuickFix.Fields.IntField
    {
        public StrikePriceBoundaryMethod()
            :base(Fields.CustomTags.StrikePriceBoundaryMethod) {}
        public StrikePriceBoundaryMethod(int val)
            :base(Fields.CustomTags.StrikePriceBoundaryMethod, val) {}


        // Field Enumerations
        public const int LESS_THAN_UNDERLYING_PRICE_IS_IN_THE_MONEY = 1;
        public const int LESS_THAN_OR_EQUAL_TO_THE_UNDERLYING_PRICE_IS_IN_THE_MONEY = 2;
        public const int EQUAL_TO_THE_UNDERLYING_PRICE_IS_IN_THE_MONEY = 3;
        public const int GREATER_THAN_OR_EQUAL_TO_UNDERLYING_PRICE_IS_IN_THE_MONEY = 4;
        public const int GREATER_THAN_UNDERLYING_IS_IN_THE_MONEY = 5;
    }


    /// <summary>
    /// StrikePriceBoundaryPrecision Field
    /// </summary>/
    public sealed class StrikePriceBoundaryPrecision : QuickFix.Fields.DecimalField
    {
        public StrikePriceBoundaryPrecision()
            :base(Fields.CustomTags.StrikePriceBoundaryPrecision) {}
        public StrikePriceBoundaryPrecision(Decimal val)
            :base(Fields.CustomTags.StrikePriceBoundaryPrecision, val) {}

    }


    /// <summary>
    /// UnderlyingPriceDeterminationMethod Field
    /// </summary>/
    public sealed class UnderlyingPriceDeterminationMethod : QuickFix.Fields.IntField
    {
        public UnderlyingPriceDeterminationMethod()
            :base(Fields.CustomTags.UnderlyingPriceDeterminationMethod) {}
        public UnderlyingPriceDeterminationMethod(int val)
            :base(Fields.CustomTags.UnderlyingPriceDeterminationMethod, val) {}


        // Field Enumerations
        public const int REGULAR = 1;
        public const int SPECIAL_REFERENCE = 2;
        public const int OPTIMAL_VALUE = 3;
        public const int AVERAGE_VALUE = 4;
    }


    /// <summary>
    /// OptPayoutType Field
    /// </summary>/
    public sealed class OptPayoutType : QuickFix.Fields.IntField
    {
        public OptPayoutType()
            :base(Fields.CustomTags.OptPayoutType) {}
        public OptPayoutType(int val)
            :base(Fields.CustomTags.OptPayoutType, val) {}


        // Field Enumerations
        public const int VANILLA = 1;
        public const int CAPPED = 2;
        public const int BINARY = 3;
    }


    /// <summary>
    /// NoComplexEvents Field
    /// </summary>/
    public sealed class NoComplexEvents : QuickFix.Fields.IntField
    {
        public NoComplexEvents()
            :base(Fields.CustomTags.NoComplexEvents) {}
        public NoComplexEvents(int val)
            :base(Fields.CustomTags.NoComplexEvents, val) {}

    }


    /// <summary>
    /// ComplexEventType Field
    /// </summary>/
    public sealed class ComplexEventType : QuickFix.Fields.IntField
    {
        public ComplexEventType()
            :base(Fields.CustomTags.ComplexEventType) {}
        public ComplexEventType(int val)
            :base(Fields.CustomTags.ComplexEventType, val) {}


        // Field Enumerations
        public const int CAPPED = 1;
        public const int TRIGGER = 2;
        public const int KNOCK_IN_UP = 3;
        public const int KOCK_IN_DOWN = 4;
        public const int KNOCK_OUT_UP = 5;
        public const int KNOCK_OUT_DOWN = 6;
        public const int UNDERLYING = 7;
        public const int RESET_BARRIER = 8;
        public const int ROLLING_BARRIER = 9;
    }


    /// <summary>
    /// ComplexOptPayoutAmount Field
    /// </summary>/
    public sealed class ComplexOptPayoutAmount : QuickFix.Fields.DecimalField
    {
        public ComplexOptPayoutAmount()
            :base(Fields.CustomTags.ComplexOptPayoutAmount) {}
        public ComplexOptPayoutAmount(Decimal val)
            :base(Fields.CustomTags.ComplexOptPayoutAmount, val) {}

    }


    /// <summary>
    /// ComplexEventPrice Field
    /// </summary>/
    public sealed class ComplexEventPrice : QuickFix.Fields.DecimalField
    {
        public ComplexEventPrice()
            :base(Fields.CustomTags.ComplexEventPrice) {}
        public ComplexEventPrice(Decimal val)
            :base(Fields.CustomTags.ComplexEventPrice, val) {}

    }


    /// <summary>
    /// ComplexEventPriceBoundaryMethod Field
    /// </summary>/
    public sealed class ComplexEventPriceBoundaryMethod : QuickFix.Fields.IntField
    {
        public ComplexEventPriceBoundaryMethod()
            :base(Fields.CustomTags.ComplexEventPriceBoundaryMethod) {}
        public ComplexEventPriceBoundaryMethod(int val)
            :base(Fields.CustomTags.ComplexEventPriceBoundaryMethod, val) {}


        // Field Enumerations
        public const int LESS_THAN_COMPLEXEVENTPRICE = 1;
        public const int LESS_THAN_OR_EQUAL_TO_COMPLEXEVENTPRICE = 2;
        public const int EQUAL_TO_COMPLEXEVENTPRICE = 3;
        public const int GREATER_THAN_OR_EQUAL_TO_COMPLEXEVENTPRICE = 4;
        public const int GREATER_THAN_COMPLEXEVENTPRICE = 5;
    }


    /// <summary>
    /// ComplexEventPriceBoundaryPrecision Field
    /// </summary>/
    public sealed class ComplexEventPriceBoundaryPrecision : QuickFix.Fields.DecimalField
    {
        public ComplexEventPriceBoundaryPrecision()
            :base(Fields.CustomTags.ComplexEventPriceBoundaryPrecision) {}
        public ComplexEventPriceBoundaryPrecision(Decimal val)
            :base(Fields.CustomTags.ComplexEventPriceBoundaryPrecision, val) {}

    }


    /// <summary>
    /// ComplexEventPriceTimeType Field
    /// </summary>/
    public sealed class ComplexEventPriceTimeType : QuickFix.Fields.IntField
    {
        public ComplexEventPriceTimeType()
            :base(Fields.CustomTags.ComplexEventPriceTimeType) {}
        public ComplexEventPriceTimeType(int val)
            :base(Fields.CustomTags.ComplexEventPriceTimeType, val) {}


        // Field Enumerations
        public const int EXPIRATION = 1;
        public const int IMMEDIATE = 2;
        public const int SPECIFIED_DATE_TIME = 3;
    }


    /// <summary>
    /// ComplexEventCondition Field
    /// </summary>/
    public sealed class ComplexEventCondition : QuickFix.Fields.IntField
    {
        public ComplexEventCondition()
            :base(Fields.CustomTags.ComplexEventCondition) {}
        public ComplexEventCondition(int val)
            :base(Fields.CustomTags.ComplexEventCondition, val) {}


        // Field Enumerations
        public const int AND = 1;
        public const int OR = 2;
    }


    /// <summary>
    /// NoComplexEventDates Field
    /// </summary>/
    public sealed class NoComplexEventDates : QuickFix.Fields.IntField
    {
        public NoComplexEventDates()
            :base(Fields.CustomTags.NoComplexEventDates) {}
        public NoComplexEventDates(int val)
            :base(Fields.CustomTags.NoComplexEventDates, val) {}

    }


    /// <summary>
    /// ComplexEventStartDate Field
    /// </summary>/
    public sealed class ComplexEventStartDate : QuickFix.Fields.DateTimeField
    {
        public ComplexEventStartDate()
            :base(Fields.CustomTags.ComplexEventStartDate) {}
        public ComplexEventStartDate(DateTime val)
            :base(Fields.CustomTags.ComplexEventStartDate, val) {}
        public ComplexEventStartDate(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.ComplexEventStartDate, val, showMilliseconds) {}
		public ComplexEventStartDate(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.ComplexEventStartDate, val, precision) {}

    }


    /// <summary>
    /// ComplexEventEndDate Field
    /// </summary>/
    public sealed class ComplexEventEndDate : QuickFix.Fields.DateTimeField
    {
        public ComplexEventEndDate()
            :base(Fields.CustomTags.ComplexEventEndDate) {}
        public ComplexEventEndDate(DateTime val)
            :base(Fields.CustomTags.ComplexEventEndDate, val) {}
        public ComplexEventEndDate(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.ComplexEventEndDate, val, showMilliseconds) {}
		public ComplexEventEndDate(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.ComplexEventEndDate, val, precision) {}

    }


    /// <summary>
    /// NoComplexEventTimes Field
    /// </summary>/
    public sealed class NoComplexEventTimes : QuickFix.Fields.IntField
    {
        public NoComplexEventTimes()
            :base(Fields.CustomTags.NoComplexEventTimes) {}
        public NoComplexEventTimes(int val)
            :base(Fields.CustomTags.NoComplexEventTimes, val) {}

    }


    /// <summary>
    /// ComplexEventStartTime Field
    /// </summary>/
    public sealed class ComplexEventStartTime : QuickFix.Fields.TimeOnlyField
    {
        public ComplexEventStartTime()
            :base(Fields.CustomTags.ComplexEventStartTime) {}
        public ComplexEventStartTime(DateTime val)
            :base(Fields.CustomTags.ComplexEventStartTime, val) {}
        public ComplexEventStartTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.ComplexEventStartTime, val, showMilliseconds) {}
		public ComplexEventStartTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.ComplexEventStartTime, val, precision) {}

    }


    /// <summary>
    /// ComplexEventEndTime Field
    /// </summary>/
    public sealed class ComplexEventEndTime : QuickFix.Fields.TimeOnlyField
    {
        public ComplexEventEndTime()
            :base(Fields.CustomTags.ComplexEventEndTime) {}
        public ComplexEventEndTime(DateTime val)
            :base(Fields.CustomTags.ComplexEventEndTime, val) {}
        public ComplexEventEndTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.ComplexEventEndTime, val, showMilliseconds) {}
		public ComplexEventEndTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.ComplexEventEndTime, val, precision) {}

    }


    /// <summary>
    /// StreamAsgnReqID Field
    /// </summary>/
    public sealed class StreamAsgnReqID : QuickFix.Fields.StringField
    {
        public StreamAsgnReqID()
            :base(Fields.CustomTags.StreamAsgnReqID) {}
        public StreamAsgnReqID(string val)
            :base(Fields.CustomTags.StreamAsgnReqID, val) {}

    }


    /// <summary>
    /// StreamAsgnReqType Field
    /// </summary>/
    public sealed class StreamAsgnReqType : QuickFix.Fields.IntField
    {
        public StreamAsgnReqType()
            :base(Fields.CustomTags.StreamAsgnReqType) {}
        public StreamAsgnReqType(int val)
            :base(Fields.CustomTags.StreamAsgnReqType, val) {}


        // Field Enumerations
        public const int STREAM_ASSIGNMENT_FOR_NEW_CUSTOMER = 1;
        public const int STREAM_ASSIGNMENT_FOR_EXISTING_CUSTOMER = 2;
    }


    /// <summary>
    /// NoAsgnReqs Field
    /// </summary>/
    public sealed class NoAsgnReqs : QuickFix.Fields.IntField
    {
        public NoAsgnReqs()
            :base(Fields.CustomTags.NoAsgnReqs) {}
        public NoAsgnReqs(int val)
            :base(Fields.CustomTags.NoAsgnReqs, val) {}

    }


    /// <summary>
    /// MDStreamID Field
    /// </summary>/
    public sealed class MDStreamID : QuickFix.Fields.StringField
    {
        public MDStreamID()
            :base(Fields.CustomTags.MDStreamID) {}
        public MDStreamID(string val)
            :base(Fields.CustomTags.MDStreamID, val) {}

    }


    /// <summary>
    /// StreamAsgnRptID Field
    /// </summary>/
    public sealed class StreamAsgnRptID : QuickFix.Fields.StringField
    {
        public StreamAsgnRptID()
            :base(Fields.CustomTags.StreamAsgnRptID) {}
        public StreamAsgnRptID(string val)
            :base(Fields.CustomTags.StreamAsgnRptID, val) {}

    }


    /// <summary>
    /// StreamAsgnRejReason Field
    /// </summary>/
    public sealed class StreamAsgnRejReason : QuickFix.Fields.IntField
    {
        public StreamAsgnRejReason()
            :base(Fields.CustomTags.StreamAsgnRejReason) {}
        public StreamAsgnRejReason(int val)
            :base(Fields.CustomTags.StreamAsgnRejReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_CLIENT = 0;
        public const int EXCEEDS_MAXIMUM_SIZE = 1;
        public const int UNKNOWN_OR_INVALID_CURRENCY_PAIR = 2;
        public const int NO_AVAILABLE_STREAM = 3;
        public const int OTHER = 99;
    }


    /// <summary>
    /// StreamAsgnAckType Field
    /// </summary>/
    public sealed class StreamAsgnAckType : QuickFix.Fields.IntField
    {
        public StreamAsgnAckType()
            :base(Fields.CustomTags.StreamAsgnAckType) {}
        public StreamAsgnAckType(int val)
            :base(Fields.CustomTags.StreamAsgnAckType, val) {}


        // Field Enumerations
        public const int ASSIGNMENT_ACCEPTED = 0;
        public const int ASSIGNMENT_REJECTED = 1;
    }


    /// <summary>
    /// RelSymTransactTime Field
    /// </summary>/
    public sealed class RelSymTransactTime : QuickFix.Fields.DateTimeField
    {
        public RelSymTransactTime()
            :base(Fields.CustomTags.RelSymTransactTime) {}
        public RelSymTransactTime(DateTime val)
            :base(Fields.CustomTags.RelSymTransactTime, val) {}
        public RelSymTransactTime(DateTime val, bool showMilliseconds)
            :base(Fields.CustomTags.RelSymTransactTime, val, showMilliseconds) {}
		public RelSymTransactTime(DateTime val, QuickFix.Fields.Converters.TimeStampPrecision precision)
            :base(Fields.CustomTags.RelSymTransactTime, val, precision) {}

    }


    /// <summary>
    /// PartyDetailsListRequestID Field
    /// </summary>/
    public sealed class PartyDetailsListRequestID : QuickFix.Fields.StringField
    {
        public PartyDetailsListRequestID()
            :base(Fields.CustomTags.PartyDetailsListRequestID) {}
        public PartyDetailsListRequestID(string val)
            :base(Fields.CustomTags.PartyDetailsListRequestID, val) {}

    }


    /// <summary>
    /// NoPartyListResponseTypes Field
    /// </summary>/
    public sealed class NoPartyListResponseTypes : QuickFix.Fields.IntField
    {
        public NoPartyListResponseTypes()
            :base(Fields.CustomTags.NoPartyListResponseTypes) {}
        public NoPartyListResponseTypes(int val)
            :base(Fields.CustomTags.NoPartyListResponseTypes, val) {}

    }


    /// <summary>
    /// PartyListResponseType Field
    /// </summary>/
    public sealed class PartyListResponseType : QuickFix.Fields.IntField
    {
        public PartyListResponseType()
            :base(Fields.CustomTags.PartyListResponseType) {}
        public PartyListResponseType(int val)
            :base(Fields.CustomTags.PartyListResponseType, val) {}


        // Field Enumerations
        public const int RETURN_ALL_AVAILABLE_INFORMATION_ON_PARTIES_AND_RELATED_PARTIES = 0;
        public const int RETURN_ONLY_PARTY_INFORMATION = 1;
        public const int INCLUDE_INFORMATION_ON_RELATED_PARTIES = 2;
        public const int INCLUDE_RISK_LIMIT_INFORMATION = 3;
    }


    /// <summary>
    /// NoRequestedPartyRoles Field
    /// </summary>/
    public sealed class NoRequestedPartyRoles : QuickFix.Fields.IntField
    {
        public NoRequestedPartyRoles()
            :base(Fields.CustomTags.NoRequestedPartyRoles) {}
        public NoRequestedPartyRoles(int val)
            :base(Fields.CustomTags.NoRequestedPartyRoles, val) {}

    }


    /// <summary>
    /// RequestedPartyRole Field
    /// </summary>/
    public sealed class RequestedPartyRole : QuickFix.Fields.IntField
    {
        public RequestedPartyRole()
            :base(Fields.CustomTags.RequestedPartyRole) {}
        public RequestedPartyRole(int val)
            :base(Fields.CustomTags.RequestedPartyRole, val) {}

    }


    /// <summary>
    /// PartyDetailsListReportID Field
    /// </summary>/
    public sealed class PartyDetailsListReportID : QuickFix.Fields.StringField
    {
        public PartyDetailsListReportID()
            :base(Fields.CustomTags.PartyDetailsListReportID) {}
        public PartyDetailsListReportID(string val)
            :base(Fields.CustomTags.PartyDetailsListReportID, val) {}

    }


    /// <summary>
    /// PartyDetailsRequestResult Field
    /// </summary>/
    public sealed class PartyDetailsRequestResult : QuickFix.Fields.IntField
    {
        public PartyDetailsRequestResult()
            :base(Fields.CustomTags.PartyDetailsRequestResult) {}
        public PartyDetailsRequestResult(int val)
            :base(Fields.CustomTags.PartyDetailsRequestResult, val) {}


        // Field Enumerations
        public const int VALID_REQUEST = 0;
        public const int INVALID_OR_UNSUPPORTED_REQUEST = 1;
        public const int NO_PARTIES_OR_PARTY_DETAILS_FOUND_THAT_MATCH_SELECTION_CRITERIA = 2;
        public const int UNSUPPORTED_PARTYLISTRESPONSETYPE = 3;
        public const int NOT_AUTHORIZED_TO_RETRIEVE_PARTIES_OR_PARTY_DETAILS_DATA = 4;
        public const int PARTIES_OR_PARTY_DETAILS_DATA_TEMPORARILY_UNAVAILABLE = 5;
        public const int REQUEST_FOR_PARTIES_DATA_NOT_SUPPORTED = 6;
        public const int OTHER = 99;
    }


    /// <summary>
    /// TotNoPartyList Field
    /// </summary>/
    public sealed class TotNoPartyList : QuickFix.Fields.IntField
    {
        public TotNoPartyList()
            :base(Fields.CustomTags.TotNoPartyList) {}
        public TotNoPartyList(int val)
            :base(Fields.CustomTags.TotNoPartyList, val) {}

    }


    /// <summary>
    /// NoPartyList Field
    /// </summary>/
    public sealed class NoPartyList : QuickFix.Fields.IntField
    {
        public NoPartyList()
            :base(Fields.CustomTags.NoPartyList) {}
        public NoPartyList(int val)
            :base(Fields.CustomTags.NoPartyList, val) {}

    }


    /// <summary>
    /// NoPartyRelationships Field
    /// </summary>/
    public sealed class NoPartyRelationships : QuickFix.Fields.IntField
    {
        public NoPartyRelationships()
            :base(Fields.CustomTags.NoPartyRelationships) {}
        public NoPartyRelationships(int val)
            :base(Fields.CustomTags.NoPartyRelationships, val) {}

    }


    /// <summary>
    /// PartyRelationship Field
    /// </summary>/
    public sealed class PartyRelationship : QuickFix.Fields.IntField
    {
        public PartyRelationship()
            :base(Fields.CustomTags.PartyRelationship) {}
        public PartyRelationship(int val)
            :base(Fields.CustomTags.PartyRelationship, val) {}


        // Field Enumerations
        public const int IS_ALSO = 0;
        public const int CLEARS_FOR = 1;
        public const int CLEARS_THROUGH = 2;
        public const int TRADES_FOR = 3;
        public const int TRADES_THROUGH = 4;
        public const int SPONSORS = 5;
        public const int SPONSORED_THROUGH = 6;
        public const int PROVIDES_GUARANTEE_FOR = 7;
        public const int IS_GUARANTEED_BY = 8;
        public const int MEMBER_OF = 9;
        public const int HAS_MEMBERS = 10;
        public const int PROVIDES_MARKETPLACE_FOR = 11;
        public const int PARTICIPANT_OF_MARKETPLACE = 12;
        public const int CARRIES_POSITIONS_FOR = 13;
        public const int POSTS_TRADES_TO = 14;
        public const int ENTERS_TRADES_FOR = 15;
        public const int ENTERS_TRADES_THROUGH = 16;
        public const int PROVIDES_QUOTES_TO = 17;
        public const int REQUESTS_QUOTES_FROM = 18;
        public const int INVESTS_FOR = 19;
        public const int INVESTS_THROUGH = 20;
        public const int BROKERS_TRADES_FOR = 21;
        public const int BROKERS_TRADES_THROUGH = 22;
        public const int PROVIDES_TRADING_SERVICES_FOR = 23;
        public const int USES_TRADING_SERVICES_OF = 24;
        public const int APPROVES_OF = 25;
        public const int APPROVED_BY = 26;
        public const int PARENT_FIRM_FOR = 27;
        public const int SUBSIDIARY_OF = 28;
        public const int REGULATORY_OWNER_OF = 29;
        public const int OWNED_BY_30 = 30;
        public const int CONTROLS = 31;
        public const int IS_CONTROLLED_BY = 32;
        public const int LEGAL = 33;
        public const int OWNED_BY_34 = 34;
        public const int BENEFICIAL_OWNER_OF = 35;
        public const int OWNED_BY_36 = 36;
    }


    /// <summary>
    /// NoPartyAltIDs Field
    /// </summary>/
    public sealed class NoPartyAltIDs : QuickFix.Fields.IntField
    {
        public NoPartyAltIDs()
            :base(Fields.CustomTags.NoPartyAltIDs) {}
        public NoPartyAltIDs(int val)
            :base(Fields.CustomTags.NoPartyAltIDs, val) {}

    }


    /// <summary>
    /// PartyAltID Field
    /// </summary>/
    public sealed class PartyAltID : QuickFix.Fields.StringField
    {
        public PartyAltID()
            :base(Fields.CustomTags.PartyAltID) {}
        public PartyAltID(string val)
            :base(Fields.CustomTags.PartyAltID, val) {}

    }


    /// <summary>
    /// PartyAltIDSource Field
    /// </summary>/
    public sealed class PartyAltIDSource : QuickFix.Fields.CharField
    {
        public PartyAltIDSource()
            :base(Fields.CustomTags.PartyAltIDSource) {}
        public PartyAltIDSource(char val)
            :base(Fields.CustomTags.PartyAltIDSource, val) {}

    }


    /// <summary>
    /// NoPartyAltSubIDs Field
    /// </summary>/
    public sealed class NoPartyAltSubIDs : QuickFix.Fields.IntField
    {
        public NoPartyAltSubIDs()
            :base(Fields.CustomTags.NoPartyAltSubIDs) {}
        public NoPartyAltSubIDs(int val)
            :base(Fields.CustomTags.NoPartyAltSubIDs, val) {}

    }


    /// <summary>
    /// PartyAltSubID Field
    /// </summary>/
    public sealed class PartyAltSubID : QuickFix.Fields.StringField
    {
        public PartyAltSubID()
            :base(Fields.CustomTags.PartyAltSubID) {}
        public PartyAltSubID(string val)
            :base(Fields.CustomTags.PartyAltSubID, val) {}

    }


    /// <summary>
    /// PartyAltSubIDType Field
    /// </summary>/
    public sealed class PartyAltSubIDType : QuickFix.Fields.IntField
    {
        public PartyAltSubIDType()
            :base(Fields.CustomTags.PartyAltSubIDType) {}
        public PartyAltSubIDType(int val)
            :base(Fields.CustomTags.PartyAltSubIDType, val) {}

    }


    /// <summary>
    /// NoContextPartyIDs Field
    /// </summary>/
    public sealed class NoContextPartyIDs : QuickFix.Fields.IntField
    {
        public NoContextPartyIDs()
            :base(Fields.CustomTags.NoContextPartyIDs) {}
        public NoContextPartyIDs(int val)
            :base(Fields.CustomTags.NoContextPartyIDs, val) {}

    }


    /// <summary>
    /// ContextPartyID Field
    /// </summary>/
    public sealed class ContextPartyID : QuickFix.Fields.StringField
    {
        public ContextPartyID()
            :base(Fields.CustomTags.ContextPartyID) {}
        public ContextPartyID(string val)
            :base(Fields.CustomTags.ContextPartyID, val) {}

    }


    /// <summary>
    /// ContextPartyIDSource Field
    /// </summary>/
    public sealed class ContextPartyIDSource : QuickFix.Fields.CharField
    {
        public ContextPartyIDSource()
            :base(Fields.CustomTags.ContextPartyIDSource) {}
        public ContextPartyIDSource(char val)
            :base(Fields.CustomTags.ContextPartyIDSource, val) {}

    }


    /// <summary>
    /// ContextPartyRole Field
    /// </summary>/
    public sealed class ContextPartyRole : QuickFix.Fields.IntField
    {
        public ContextPartyRole()
            :base(Fields.CustomTags.ContextPartyRole) {}
        public ContextPartyRole(int val)
            :base(Fields.CustomTags.ContextPartyRole, val) {}

    }


    /// <summary>
    /// NoContextPartySubIDs Field
    /// </summary>/
    public sealed class NoContextPartySubIDs : QuickFix.Fields.IntField
    {
        public NoContextPartySubIDs()
            :base(Fields.CustomTags.NoContextPartySubIDs) {}
        public NoContextPartySubIDs(int val)
            :base(Fields.CustomTags.NoContextPartySubIDs, val) {}

    }


    /// <summary>
    /// ContextPartySubID Field
    /// </summary>/
    public sealed class ContextPartySubID : QuickFix.Fields.StringField
    {
        public ContextPartySubID()
            :base(Fields.CustomTags.ContextPartySubID) {}
        public ContextPartySubID(string val)
            :base(Fields.CustomTags.ContextPartySubID, val) {}

    }


    /// <summary>
    /// ContextPartySubIDType Field
    /// </summary>/
    public sealed class ContextPartySubIDType : QuickFix.Fields.IntField
    {
        public ContextPartySubIDType()
            :base(Fields.CustomTags.ContextPartySubIDType) {}
        public ContextPartySubIDType(int val)
            :base(Fields.CustomTags.ContextPartySubIDType, val) {}

    }


    /// <summary>
    /// NoRiskLimits Field
    /// </summary>/
    public sealed class NoRiskLimits : QuickFix.Fields.IntField
    {
        public NoRiskLimits()
            :base(Fields.CustomTags.NoRiskLimits) {}
        public NoRiskLimits(int val)
            :base(Fields.CustomTags.NoRiskLimits, val) {}

    }


    /// <summary>
    /// RiskLimitType Field
    /// </summary>/
    public sealed class RiskLimitType : QuickFix.Fields.IntField
    {
        public RiskLimitType()
            :base(Fields.CustomTags.RiskLimitType) {}
        public RiskLimitType(int val)
            :base(Fields.CustomTags.RiskLimitType, val) {}


        // Field Enumerations
        public const int GROSS_LIMIT = 1;
        public const int NET_LIMIT = 2;
        public const int EXPOSURE = 3;
        public const int LONG_LIMIT = 4;
        public const int SHORT_LIMIT = 5;
    }


    /// <summary>
    /// RiskLimitAmount Field
    /// </summary>/
    public sealed class RiskLimitAmount : QuickFix.Fields.DecimalField
    {
        public RiskLimitAmount()
            :base(Fields.CustomTags.RiskLimitAmount) {}
        public RiskLimitAmount(Decimal val)
            :base(Fields.CustomTags.RiskLimitAmount, val) {}

    }


    /// <summary>
    /// RiskLimitCurrency Field
    /// </summary>/
    public sealed class RiskLimitCurrency : QuickFix.Fields.StringField
    {
        public RiskLimitCurrency()
            :base(Fields.CustomTags.RiskLimitCurrency) {}
        public RiskLimitCurrency(string val)
            :base(Fields.CustomTags.RiskLimitCurrency, val) {}

    }


    /// <summary>
    /// RiskLimitPlatform Field
    /// </summary>/
    public sealed class RiskLimitPlatform : QuickFix.Fields.StringField
    {
        public RiskLimitPlatform()
            :base(Fields.CustomTags.RiskLimitPlatform) {}
        public RiskLimitPlatform(string val)
            :base(Fields.CustomTags.RiskLimitPlatform, val) {}

    }


    /// <summary>
    /// NoRiskInstruments Field
    /// </summary>/
    public sealed class NoRiskInstruments : QuickFix.Fields.IntField
    {
        public NoRiskInstruments()
            :base(Fields.CustomTags.NoRiskInstruments) {}
        public NoRiskInstruments(int val)
            :base(Fields.CustomTags.NoRiskInstruments, val) {}

    }


    /// <summary>
    /// RiskInstrumentOperator Field
    /// </summary>/
    public sealed class RiskInstrumentOperator : QuickFix.Fields.IntField
    {
        public RiskInstrumentOperator()
            :base(Fields.CustomTags.RiskInstrumentOperator) {}
        public RiskInstrumentOperator(int val)
            :base(Fields.CustomTags.RiskInstrumentOperator, val) {}


        // Field Enumerations
        public const int INCLUDE = 1;
        public const int EXCLUDE = 2;
    }


    /// <summary>
    /// RiskSymbol Field
    /// </summary>/
    public sealed class RiskSymbol : QuickFix.Fields.StringField
    {
        public RiskSymbol()
            :base(Fields.CustomTags.RiskSymbol) {}
        public RiskSymbol(string val)
            :base(Fields.CustomTags.RiskSymbol, val) {}

    }


    /// <summary>
    /// RiskSymbolSfx Field
    /// </summary>/
    public sealed class RiskSymbolSfx : QuickFix.Fields.StringField
    {
        public RiskSymbolSfx()
            :base(Fields.CustomTags.RiskSymbolSfx) {}
        public RiskSymbolSfx(string val)
            :base(Fields.CustomTags.RiskSymbolSfx, val) {}

    }


    /// <summary>
    /// RiskSecurityID Field
    /// </summary>/
    public sealed class RiskSecurityID : QuickFix.Fields.StringField
    {
        public RiskSecurityID()
            :base(Fields.CustomTags.RiskSecurityID) {}
        public RiskSecurityID(string val)
            :base(Fields.CustomTags.RiskSecurityID, val) {}

    }


    /// <summary>
    /// RiskSecurityIDSource Field
    /// </summary>/
    public sealed class RiskSecurityIDSource : QuickFix.Fields.StringField
    {
        public RiskSecurityIDSource()
            :base(Fields.CustomTags.RiskSecurityIDSource) {}
        public RiskSecurityIDSource(string val)
            :base(Fields.CustomTags.RiskSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoRiskSecurityAltID Field
    /// </summary>/
    public sealed class NoRiskSecurityAltID : QuickFix.Fields.IntField
    {
        public NoRiskSecurityAltID()
            :base(Fields.CustomTags.NoRiskSecurityAltID) {}
        public NoRiskSecurityAltID(int val)
            :base(Fields.CustomTags.NoRiskSecurityAltID, val) {}

    }


    /// <summary>
    /// RiskSecurityAltID Field
    /// </summary>/
    public sealed class RiskSecurityAltID : QuickFix.Fields.StringField
    {
        public RiskSecurityAltID()
            :base(Fields.CustomTags.RiskSecurityAltID) {}
        public RiskSecurityAltID(string val)
            :base(Fields.CustomTags.RiskSecurityAltID, val) {}

    }


    /// <summary>
    /// RiskSecurityAltIDSource Field
    /// </summary>/
    public sealed class RiskSecurityAltIDSource : QuickFix.Fields.StringField
    {
        public RiskSecurityAltIDSource()
            :base(Fields.CustomTags.RiskSecurityAltIDSource) {}
        public RiskSecurityAltIDSource(string val)
            :base(Fields.CustomTags.RiskSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// RiskProduct Field
    /// </summary>/
    public sealed class RiskProduct : QuickFix.Fields.IntField
    {
        public RiskProduct()
            :base(Fields.CustomTags.RiskProduct) {}
        public RiskProduct(int val)
            :base(Fields.CustomTags.RiskProduct, val) {}

    }


    /// <summary>
    /// RiskProductComplex Field
    /// </summary>/
    public sealed class RiskProductComplex : QuickFix.Fields.StringField
    {
        public RiskProductComplex()
            :base(Fields.CustomTags.RiskProductComplex) {}
        public RiskProductComplex(string val)
            :base(Fields.CustomTags.RiskProductComplex, val) {}

    }


    /// <summary>
    /// RiskSecurityGroup Field
    /// </summary>/
    public sealed class RiskSecurityGroup : QuickFix.Fields.StringField
    {
        public RiskSecurityGroup()
            :base(Fields.CustomTags.RiskSecurityGroup) {}
        public RiskSecurityGroup(string val)
            :base(Fields.CustomTags.RiskSecurityGroup, val) {}

    }


    /// <summary>
    /// RiskCFICode Field
    /// </summary>/
    public sealed class RiskCFICode : QuickFix.Fields.StringField
    {
        public RiskCFICode()
            :base(Fields.CustomTags.RiskCFICode) {}
        public RiskCFICode(string val)
            :base(Fields.CustomTags.RiskCFICode, val) {}

    }


    /// <summary>
    /// RiskSecurityType Field
    /// </summary>/
    public sealed class RiskSecurityType : QuickFix.Fields.StringField
    {
        public RiskSecurityType()
            :base(Fields.CustomTags.RiskSecurityType) {}
        public RiskSecurityType(string val)
            :base(Fields.CustomTags.RiskSecurityType, val) {}

    }


    /// <summary>
    /// RiskSecuritySubType Field
    /// </summary>/
    public sealed class RiskSecuritySubType : QuickFix.Fields.StringField
    {
        public RiskSecuritySubType()
            :base(Fields.CustomTags.RiskSecuritySubType) {}
        public RiskSecuritySubType(string val)
            :base(Fields.CustomTags.RiskSecuritySubType, val) {}

    }


    /// <summary>
    /// RiskMaturityMonthYear Field
    /// </summary>/
    public sealed class RiskMaturityMonthYear : QuickFix.Fields.StringField
    {
        public RiskMaturityMonthYear()
            :base(Fields.CustomTags.RiskMaturityMonthYear) {}
        public RiskMaturityMonthYear(string val)
            :base(Fields.CustomTags.RiskMaturityMonthYear, val) {}

    }


    /// <summary>
    /// RiskMaturityTime Field
    /// </summary>/
    public sealed class RiskMaturityTime : QuickFix.Fields.StringField
    {
        public RiskMaturityTime()
            :base(Fields.CustomTags.RiskMaturityTime) {}
        public RiskMaturityTime(string val)
            :base(Fields.CustomTags.RiskMaturityTime, val) {}

    }


    /// <summary>
    /// RiskRestructuringType Field
    /// </summary>/
    public sealed class RiskRestructuringType : QuickFix.Fields.StringField
    {
        public RiskRestructuringType()
            :base(Fields.CustomTags.RiskRestructuringType) {}
        public RiskRestructuringType(string val)
            :base(Fields.CustomTags.RiskRestructuringType, val) {}

    }


    /// <summary>
    /// RiskSeniority Field
    /// </summary>/
    public sealed class RiskSeniority : QuickFix.Fields.StringField
    {
        public RiskSeniority()
            :base(Fields.CustomTags.RiskSeniority) {}
        public RiskSeniority(string val)
            :base(Fields.CustomTags.RiskSeniority, val) {}

    }


    /// <summary>
    /// RiskPutOrCall Field
    /// </summary>/
    public sealed class RiskPutOrCall : QuickFix.Fields.IntField
    {
        public RiskPutOrCall()
            :base(Fields.CustomTags.RiskPutOrCall) {}
        public RiskPutOrCall(int val)
            :base(Fields.CustomTags.RiskPutOrCall, val) {}

    }


    /// <summary>
    /// RiskFlexibleIndicator Field
    /// </summary>/
    public sealed class RiskFlexibleIndicator : QuickFix.Fields.BooleanField
    {
        public RiskFlexibleIndicator()
            :base(Fields.CustomTags.RiskFlexibleIndicator) {}
        public RiskFlexibleIndicator(Boolean val)
            :base(Fields.CustomTags.RiskFlexibleIndicator, val) {}

    }


    /// <summary>
    /// RiskCouponRate Field
    /// </summary>/
    public sealed class RiskCouponRate : QuickFix.Fields.DecimalField
    {
        public RiskCouponRate()
            :base(Fields.CustomTags.RiskCouponRate) {}
        public RiskCouponRate(Decimal val)
            :base(Fields.CustomTags.RiskCouponRate, val) {}

    }


    /// <summary>
    /// RiskSecurityDesc Field
    /// </summary>/
    public sealed class RiskSecurityDesc : QuickFix.Fields.StringField
    {
        public RiskSecurityDesc()
            :base(Fields.CustomTags.RiskSecurityDesc) {}
        public RiskSecurityDesc(string val)
            :base(Fields.CustomTags.RiskSecurityDesc, val) {}

    }


    /// <summary>
    /// RiskInstrumentSettlType Field
    /// </summary>/
    public sealed class RiskInstrumentSettlType : QuickFix.Fields.StringField
    {
        public RiskInstrumentSettlType()
            :base(Fields.CustomTags.RiskInstrumentSettlType) {}
        public RiskInstrumentSettlType(string val)
            :base(Fields.CustomTags.RiskInstrumentSettlType, val) {}

    }


    /// <summary>
    /// RiskInstrumentMultiplier Field
    /// </summary>/
    public sealed class RiskInstrumentMultiplier : QuickFix.Fields.DecimalField
    {
        public RiskInstrumentMultiplier()
            :base(Fields.CustomTags.RiskInstrumentMultiplier) {}
        public RiskInstrumentMultiplier(Decimal val)
            :base(Fields.CustomTags.RiskInstrumentMultiplier, val) {}

    }


    /// <summary>
    /// NoRiskWarningLevels Field
    /// </summary>/
    public sealed class NoRiskWarningLevels : QuickFix.Fields.IntField
    {
        public NoRiskWarningLevels()
            :base(Fields.CustomTags.NoRiskWarningLevels) {}
        public NoRiskWarningLevels(int val)
            :base(Fields.CustomTags.NoRiskWarningLevels, val) {}

    }


    /// <summary>
    /// RiskWarningLevelPercent Field
    /// </summary>/
    public sealed class RiskWarningLevelPercent : QuickFix.Fields.DecimalField
    {
        public RiskWarningLevelPercent()
            :base(Fields.CustomTags.RiskWarningLevelPercent) {}
        public RiskWarningLevelPercent(Decimal val)
            :base(Fields.CustomTags.RiskWarningLevelPercent, val) {}

    }


    /// <summary>
    /// RiskWarningLevelName Field
    /// </summary>/
    public sealed class RiskWarningLevelName : QuickFix.Fields.StringField
    {
        public RiskWarningLevelName()
            :base(Fields.CustomTags.RiskWarningLevelName) {}
        public RiskWarningLevelName(string val)
            :base(Fields.CustomTags.RiskWarningLevelName, val) {}

    }


    /// <summary>
    /// NoRelatedPartyIDs Field
    /// </summary>/
    public sealed class NoRelatedPartyIDs : QuickFix.Fields.IntField
    {
        public NoRelatedPartyIDs()
            :base(Fields.CustomTags.NoRelatedPartyIDs) {}
        public NoRelatedPartyIDs(int val)
            :base(Fields.CustomTags.NoRelatedPartyIDs, val) {}

    }


    /// <summary>
    /// RelatedPartyID Field
    /// </summary>/
    public sealed class RelatedPartyID : QuickFix.Fields.StringField
    {
        public RelatedPartyID()
            :base(Fields.CustomTags.RelatedPartyID) {}
        public RelatedPartyID(string val)
            :base(Fields.CustomTags.RelatedPartyID, val) {}

    }


    /// <summary>
    /// RelatedPartyIDSource Field
    /// </summary>/
    public sealed class RelatedPartyIDSource : QuickFix.Fields.CharField
    {
        public RelatedPartyIDSource()
            :base(Fields.CustomTags.RelatedPartyIDSource) {}
        public RelatedPartyIDSource(char val)
            :base(Fields.CustomTags.RelatedPartyIDSource, val) {}

    }


    /// <summary>
    /// RelatedPartyRole Field
    /// </summary>/
    public sealed class RelatedPartyRole : QuickFix.Fields.IntField
    {
        public RelatedPartyRole()
            :base(Fields.CustomTags.RelatedPartyRole) {}
        public RelatedPartyRole(int val)
            :base(Fields.CustomTags.RelatedPartyRole, val) {}

    }


    /// <summary>
    /// NoRelatedPartySubIDs Field
    /// </summary>/
    public sealed class NoRelatedPartySubIDs : QuickFix.Fields.IntField
    {
        public NoRelatedPartySubIDs()
            :base(Fields.CustomTags.NoRelatedPartySubIDs) {}
        public NoRelatedPartySubIDs(int val)
            :base(Fields.CustomTags.NoRelatedPartySubIDs, val) {}

    }


    /// <summary>
    /// RelatedPartySubID Field
    /// </summary>/
    public sealed class RelatedPartySubID : QuickFix.Fields.StringField
    {
        public RelatedPartySubID()
            :base(Fields.CustomTags.RelatedPartySubID) {}
        public RelatedPartySubID(string val)
            :base(Fields.CustomTags.RelatedPartySubID, val) {}

    }


    /// <summary>
    /// RelatedPartySubIDType Field
    /// </summary>/
    public sealed class RelatedPartySubIDType : QuickFix.Fields.IntField
    {
        public RelatedPartySubIDType()
            :base(Fields.CustomTags.RelatedPartySubIDType) {}
        public RelatedPartySubIDType(int val)
            :base(Fields.CustomTags.RelatedPartySubIDType, val) {}

    }


    /// <summary>
    /// NoRelatedPartyAltIDs Field
    /// </summary>/
    public sealed class NoRelatedPartyAltIDs : QuickFix.Fields.IntField
    {
        public NoRelatedPartyAltIDs()
            :base(Fields.CustomTags.NoRelatedPartyAltIDs) {}
        public NoRelatedPartyAltIDs(int val)
            :base(Fields.CustomTags.NoRelatedPartyAltIDs, val) {}

    }


    /// <summary>
    /// RelatedPartyAltID Field
    /// </summary>/
    public sealed class RelatedPartyAltID : QuickFix.Fields.StringField
    {
        public RelatedPartyAltID()
            :base(Fields.CustomTags.RelatedPartyAltID) {}
        public RelatedPartyAltID(string val)
            :base(Fields.CustomTags.RelatedPartyAltID, val) {}

    }


    /// <summary>
    /// RelatedPartyAltIDSource Field
    /// </summary>/
    public sealed class RelatedPartyAltIDSource : QuickFix.Fields.CharField
    {
        public RelatedPartyAltIDSource()
            :base(Fields.CustomTags.RelatedPartyAltIDSource) {}
        public RelatedPartyAltIDSource(char val)
            :base(Fields.CustomTags.RelatedPartyAltIDSource, val) {}

    }


    /// <summary>
    /// NoRelatedPartyAltSubIDs Field
    /// </summary>/
    public sealed class NoRelatedPartyAltSubIDs : QuickFix.Fields.IntField
    {
        public NoRelatedPartyAltSubIDs()
            :base(Fields.CustomTags.NoRelatedPartyAltSubIDs) {}
        public NoRelatedPartyAltSubIDs(int val)
            :base(Fields.CustomTags.NoRelatedPartyAltSubIDs, val) {}

    }


    /// <summary>
    /// RelatedPartyAltSubID Field
    /// </summary>/
    public sealed class RelatedPartyAltSubID : QuickFix.Fields.StringField
    {
        public RelatedPartyAltSubID()
            :base(Fields.CustomTags.RelatedPartyAltSubID) {}
        public RelatedPartyAltSubID(string val)
            :base(Fields.CustomTags.RelatedPartyAltSubID, val) {}

    }


    /// <summary>
    /// RelatedPartyAltSubIDType Field
    /// </summary>/
    public sealed class RelatedPartyAltSubIDType : QuickFix.Fields.IntField
    {
        public RelatedPartyAltSubIDType()
            :base(Fields.CustomTags.RelatedPartyAltSubIDType) {}
        public RelatedPartyAltSubIDType(int val)
            :base(Fields.CustomTags.RelatedPartyAltSubIDType, val) {}

    }


    /// <summary>
    /// NoRelatedContextPartyIDs Field
    /// </summary>/
    public sealed class NoRelatedContextPartyIDs : QuickFix.Fields.IntField
    {
        public NoRelatedContextPartyIDs()
            :base(Fields.CustomTags.NoRelatedContextPartyIDs) {}
        public NoRelatedContextPartyIDs(int val)
            :base(Fields.CustomTags.NoRelatedContextPartyIDs, val) {}

    }


    /// <summary>
    /// RelatedContextPartyID Field
    /// </summary>/
    public sealed class RelatedContextPartyID : QuickFix.Fields.StringField
    {
        public RelatedContextPartyID()
            :base(Fields.CustomTags.RelatedContextPartyID) {}
        public RelatedContextPartyID(string val)
            :base(Fields.CustomTags.RelatedContextPartyID, val) {}

    }


    /// <summary>
    /// RelatedContextPartyIDSource Field
    /// </summary>/
    public sealed class RelatedContextPartyIDSource : QuickFix.Fields.CharField
    {
        public RelatedContextPartyIDSource()
            :base(Fields.CustomTags.RelatedContextPartyIDSource) {}
        public RelatedContextPartyIDSource(char val)
            :base(Fields.CustomTags.RelatedContextPartyIDSource, val) {}

    }


    /// <summary>
    /// RelatedContextPartyRole Field
    /// </summary>/
    public sealed class RelatedContextPartyRole : QuickFix.Fields.IntField
    {
        public RelatedContextPartyRole()
            :base(Fields.CustomTags.RelatedContextPartyRole) {}
        public RelatedContextPartyRole(int val)
            :base(Fields.CustomTags.RelatedContextPartyRole, val) {}

    }


    /// <summary>
    /// NoRelatedContextPartySubIDs Field
    /// </summary>/
    public sealed class NoRelatedContextPartySubIDs : QuickFix.Fields.IntField
    {
        public NoRelatedContextPartySubIDs()
            :base(Fields.CustomTags.NoRelatedContextPartySubIDs) {}
        public NoRelatedContextPartySubIDs(int val)
            :base(Fields.CustomTags.NoRelatedContextPartySubIDs, val) {}

    }


    /// <summary>
    /// RelatedContextPartySubID Field
    /// </summary>/
    public sealed class RelatedContextPartySubID : QuickFix.Fields.StringField
    {
        public RelatedContextPartySubID()
            :base(Fields.CustomTags.RelatedContextPartySubID) {}
        public RelatedContextPartySubID(string val)
            :base(Fields.CustomTags.RelatedContextPartySubID, val) {}

    }


    /// <summary>
    /// RelatedContextPartySubIDType Field
    /// </summary>/
    public sealed class RelatedContextPartySubIDType : QuickFix.Fields.IntField
    {
        public RelatedContextPartySubIDType()
            :base(Fields.CustomTags.RelatedContextPartySubIDType) {}
        public RelatedContextPartySubIDType(int val)
            :base(Fields.CustomTags.RelatedContextPartySubIDType, val) {}

    }


    /// <summary>
    /// NoRelationshipRiskLimits Field
    /// </summary>/
    public sealed class NoRelationshipRiskLimits : QuickFix.Fields.IntField
    {
        public NoRelationshipRiskLimits()
            :base(Fields.CustomTags.NoRelationshipRiskLimits) {}
        public NoRelationshipRiskLimits(int val)
            :base(Fields.CustomTags.NoRelationshipRiskLimits, val) {}

    }


    /// <summary>
    /// RelationshipRiskLimitType Field
    /// </summary>/
    public sealed class RelationshipRiskLimitType : QuickFix.Fields.IntField
    {
        public RelationshipRiskLimitType()
            :base(Fields.CustomTags.RelationshipRiskLimitType) {}
        public RelationshipRiskLimitType(int val)
            :base(Fields.CustomTags.RelationshipRiskLimitType, val) {}

    }


    /// <summary>
    /// RelationshipRiskLimitAmount Field
    /// </summary>/
    public sealed class RelationshipRiskLimitAmount : QuickFix.Fields.DecimalField
    {
        public RelationshipRiskLimitAmount()
            :base(Fields.CustomTags.RelationshipRiskLimitAmount) {}
        public RelationshipRiskLimitAmount(Decimal val)
            :base(Fields.CustomTags.RelationshipRiskLimitAmount, val) {}

    }


    /// <summary>
    /// RelationshipRiskLimitCurrency Field
    /// </summary>/
    public sealed class RelationshipRiskLimitCurrency : QuickFix.Fields.StringField
    {
        public RelationshipRiskLimitCurrency()
            :base(Fields.CustomTags.RelationshipRiskLimitCurrency) {}
        public RelationshipRiskLimitCurrency(string val)
            :base(Fields.CustomTags.RelationshipRiskLimitCurrency, val) {}

    }


    /// <summary>
    /// RelationshipRiskLimitPlatform Field
    /// </summary>/
    public sealed class RelationshipRiskLimitPlatform : QuickFix.Fields.StringField
    {
        public RelationshipRiskLimitPlatform()
            :base(Fields.CustomTags.RelationshipRiskLimitPlatform) {}
        public RelationshipRiskLimitPlatform(string val)
            :base(Fields.CustomTags.RelationshipRiskLimitPlatform, val) {}

    }


    /// <summary>
    /// NoRelationshipRiskInstruments Field
    /// </summary>/
    public sealed class NoRelationshipRiskInstruments : QuickFix.Fields.IntField
    {
        public NoRelationshipRiskInstruments()
            :base(Fields.CustomTags.NoRelationshipRiskInstruments) {}
        public NoRelationshipRiskInstruments(int val)
            :base(Fields.CustomTags.NoRelationshipRiskInstruments, val) {}

    }


    /// <summary>
    /// RelationshipRiskInstrumentOperator Field
    /// </summary>/
    public sealed class RelationshipRiskInstrumentOperator : QuickFix.Fields.IntField
    {
        public RelationshipRiskInstrumentOperator()
            :base(Fields.CustomTags.RelationshipRiskInstrumentOperator) {}
        public RelationshipRiskInstrumentOperator(int val)
            :base(Fields.CustomTags.RelationshipRiskInstrumentOperator, val) {}

    }


    /// <summary>
    /// RelationshipRiskSymbol Field
    /// </summary>/
    public sealed class RelationshipRiskSymbol : QuickFix.Fields.StringField
    {
        public RelationshipRiskSymbol()
            :base(Fields.CustomTags.RelationshipRiskSymbol) {}
        public RelationshipRiskSymbol(string val)
            :base(Fields.CustomTags.RelationshipRiskSymbol, val) {}

    }


    /// <summary>
    /// RelationshipRiskSymbolSfx Field
    /// </summary>/
    public sealed class RelationshipRiskSymbolSfx : QuickFix.Fields.StringField
    {
        public RelationshipRiskSymbolSfx()
            :base(Fields.CustomTags.RelationshipRiskSymbolSfx) {}
        public RelationshipRiskSymbolSfx(string val)
            :base(Fields.CustomTags.RelationshipRiskSymbolSfx, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityID Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityID : QuickFix.Fields.StringField
    {
        public RelationshipRiskSecurityID()
            :base(Fields.CustomTags.RelationshipRiskSecurityID) {}
        public RelationshipRiskSecurityID(string val)
            :base(Fields.CustomTags.RelationshipRiskSecurityID, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityIDSource Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityIDSource : QuickFix.Fields.StringField
    {
        public RelationshipRiskSecurityIDSource()
            :base(Fields.CustomTags.RelationshipRiskSecurityIDSource) {}
        public RelationshipRiskSecurityIDSource(string val)
            :base(Fields.CustomTags.RelationshipRiskSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoRelationshipRiskSecurityAltID Field
    /// </summary>/
    public sealed class NoRelationshipRiskSecurityAltID : QuickFix.Fields.IntField
    {
        public NoRelationshipRiskSecurityAltID()
            :base(Fields.CustomTags.NoRelationshipRiskSecurityAltID) {}
        public NoRelationshipRiskSecurityAltID(int val)
            :base(Fields.CustomTags.NoRelationshipRiskSecurityAltID, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityAltID Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityAltID : QuickFix.Fields.StringField
    {
        public RelationshipRiskSecurityAltID()
            :base(Fields.CustomTags.RelationshipRiskSecurityAltID) {}
        public RelationshipRiskSecurityAltID(string val)
            :base(Fields.CustomTags.RelationshipRiskSecurityAltID, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityAltIDSource Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityAltIDSource : QuickFix.Fields.StringField
    {
        public RelationshipRiskSecurityAltIDSource()
            :base(Fields.CustomTags.RelationshipRiskSecurityAltIDSource) {}
        public RelationshipRiskSecurityAltIDSource(string val)
            :base(Fields.CustomTags.RelationshipRiskSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// RelationshipRiskProduct Field
    /// </summary>/
    public sealed class RelationshipRiskProduct : QuickFix.Fields.IntField
    {
        public RelationshipRiskProduct()
            :base(Fields.CustomTags.RelationshipRiskProduct) {}
        public RelationshipRiskProduct(int val)
            :base(Fields.CustomTags.RelationshipRiskProduct, val) {}

    }


    /// <summary>
    /// RelationshipRiskProductComplex Field
    /// </summary>/
    public sealed class RelationshipRiskProductComplex : QuickFix.Fields.StringField
    {
        public RelationshipRiskProductComplex()
            :base(Fields.CustomTags.RelationshipRiskProductComplex) {}
        public RelationshipRiskProductComplex(string val)
            :base(Fields.CustomTags.RelationshipRiskProductComplex, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityGroup Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityGroup : QuickFix.Fields.StringField
    {
        public RelationshipRiskSecurityGroup()
            :base(Fields.CustomTags.RelationshipRiskSecurityGroup) {}
        public RelationshipRiskSecurityGroup(string val)
            :base(Fields.CustomTags.RelationshipRiskSecurityGroup, val) {}

    }


    /// <summary>
    /// RelationshipRiskCFICode Field
    /// </summary>/
    public sealed class RelationshipRiskCFICode : QuickFix.Fields.StringField
    {
        public RelationshipRiskCFICode()
            :base(Fields.CustomTags.RelationshipRiskCFICode) {}
        public RelationshipRiskCFICode(string val)
            :base(Fields.CustomTags.RelationshipRiskCFICode, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityType Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityType : QuickFix.Fields.StringField
    {
        public RelationshipRiskSecurityType()
            :base(Fields.CustomTags.RelationshipRiskSecurityType) {}
        public RelationshipRiskSecurityType(string val)
            :base(Fields.CustomTags.RelationshipRiskSecurityType, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecuritySubType Field
    /// </summary>/
    public sealed class RelationshipRiskSecuritySubType : QuickFix.Fields.StringField
    {
        public RelationshipRiskSecuritySubType()
            :base(Fields.CustomTags.RelationshipRiskSecuritySubType) {}
        public RelationshipRiskSecuritySubType(string val)
            :base(Fields.CustomTags.RelationshipRiskSecuritySubType, val) {}

    }


    /// <summary>
    /// RelationshipRiskMaturityMonthYear Field
    /// </summary>/
    public sealed class RelationshipRiskMaturityMonthYear : QuickFix.Fields.StringField
    {
        public RelationshipRiskMaturityMonthYear()
            :base(Fields.CustomTags.RelationshipRiskMaturityMonthYear) {}
        public RelationshipRiskMaturityMonthYear(string val)
            :base(Fields.CustomTags.RelationshipRiskMaturityMonthYear, val) {}

    }


    /// <summary>
    /// RelationshipRiskMaturityTime Field
    /// </summary>/
    public sealed class RelationshipRiskMaturityTime : QuickFix.Fields.StringField
    {
        public RelationshipRiskMaturityTime()
            :base(Fields.CustomTags.RelationshipRiskMaturityTime) {}
        public RelationshipRiskMaturityTime(string val)
            :base(Fields.CustomTags.RelationshipRiskMaturityTime, val) {}

    }


    /// <summary>
    /// RelationshipRiskRestructuringType Field
    /// </summary>/
    public sealed class RelationshipRiskRestructuringType : QuickFix.Fields.StringField
    {
        public RelationshipRiskRestructuringType()
            :base(Fields.CustomTags.RelationshipRiskRestructuringType) {}
        public RelationshipRiskRestructuringType(string val)
            :base(Fields.CustomTags.RelationshipRiskRestructuringType, val) {}

    }


    /// <summary>
    /// RelationshipRiskSeniority Field
    /// </summary>/
    public sealed class RelationshipRiskSeniority : QuickFix.Fields.StringField
    {
        public RelationshipRiskSeniority()
            :base(Fields.CustomTags.RelationshipRiskSeniority) {}
        public RelationshipRiskSeniority(string val)
            :base(Fields.CustomTags.RelationshipRiskSeniority, val) {}

    }


    /// <summary>
    /// RelationshipRiskPutOrCall Field
    /// </summary>/
    public sealed class RelationshipRiskPutOrCall : QuickFix.Fields.IntField
    {
        public RelationshipRiskPutOrCall()
            :base(Fields.CustomTags.RelationshipRiskPutOrCall) {}
        public RelationshipRiskPutOrCall(int val)
            :base(Fields.CustomTags.RelationshipRiskPutOrCall, val) {}

    }


    /// <summary>
    /// RelationshipRiskFlexibleIndicator Field
    /// </summary>/
    public sealed class RelationshipRiskFlexibleIndicator : QuickFix.Fields.BooleanField
    {
        public RelationshipRiskFlexibleIndicator()
            :base(Fields.CustomTags.RelationshipRiskFlexibleIndicator) {}
        public RelationshipRiskFlexibleIndicator(Boolean val)
            :base(Fields.CustomTags.RelationshipRiskFlexibleIndicator, val) {}

    }


    /// <summary>
    /// RelationshipRiskCouponRate Field
    /// </summary>/
    public sealed class RelationshipRiskCouponRate : QuickFix.Fields.DecimalField
    {
        public RelationshipRiskCouponRate()
            :base(Fields.CustomTags.RelationshipRiskCouponRate) {}
        public RelationshipRiskCouponRate(Decimal val)
            :base(Fields.CustomTags.RelationshipRiskCouponRate, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityExchange Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityExchange : QuickFix.Fields.StringField
    {
        public RelationshipRiskSecurityExchange()
            :base(Fields.CustomTags.RelationshipRiskSecurityExchange) {}
        public RelationshipRiskSecurityExchange(string val)
            :base(Fields.CustomTags.RelationshipRiskSecurityExchange, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityDesc Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityDesc : QuickFix.Fields.StringField
    {
        public RelationshipRiskSecurityDesc()
            :base(Fields.CustomTags.RelationshipRiskSecurityDesc) {}
        public RelationshipRiskSecurityDesc(string val)
            :base(Fields.CustomTags.RelationshipRiskSecurityDesc, val) {}

    }


    /// <summary>
    /// RelationshipRiskInstrumentSettlType Field
    /// </summary>/
    public sealed class RelationshipRiskInstrumentSettlType : QuickFix.Fields.StringField
    {
        public RelationshipRiskInstrumentSettlType()
            :base(Fields.CustomTags.RelationshipRiskInstrumentSettlType) {}
        public RelationshipRiskInstrumentSettlType(string val)
            :base(Fields.CustomTags.RelationshipRiskInstrumentSettlType, val) {}

    }


    /// <summary>
    /// RelationshipRiskInstrumentMultiplier Field
    /// </summary>/
    public sealed class RelationshipRiskInstrumentMultiplier : QuickFix.Fields.DecimalField
    {
        public RelationshipRiskInstrumentMultiplier()
            :base(Fields.CustomTags.RelationshipRiskInstrumentMultiplier) {}
        public RelationshipRiskInstrumentMultiplier(Decimal val)
            :base(Fields.CustomTags.RelationshipRiskInstrumentMultiplier, val) {}

    }


    /// <summary>
    /// NoRelationshipRiskWarningLevels Field
    /// </summary>/
    public sealed class NoRelationshipRiskWarningLevels : QuickFix.Fields.IntField
    {
        public NoRelationshipRiskWarningLevels()
            :base(Fields.CustomTags.NoRelationshipRiskWarningLevels) {}
        public NoRelationshipRiskWarningLevels(int val)
            :base(Fields.CustomTags.NoRelationshipRiskWarningLevels, val) {}

    }


    /// <summary>
    /// RelationshipRiskWarningLevelPercent Field
    /// </summary>/
    public sealed class RelationshipRiskWarningLevelPercent : QuickFix.Fields.DecimalField
    {
        public RelationshipRiskWarningLevelPercent()
            :base(Fields.CustomTags.RelationshipRiskWarningLevelPercent) {}
        public RelationshipRiskWarningLevelPercent(Decimal val)
            :base(Fields.CustomTags.RelationshipRiskWarningLevelPercent, val) {}

    }


    /// <summary>
    /// RelationshipRiskWarningLevelName Field
    /// </summary>/
    public sealed class RelationshipRiskWarningLevelName : QuickFix.Fields.StringField
    {
        public RelationshipRiskWarningLevelName()
            :base(Fields.CustomTags.RelationshipRiskWarningLevelName) {}
        public RelationshipRiskWarningLevelName(string val)
            :base(Fields.CustomTags.RelationshipRiskWarningLevelName, val) {}

    }


    /// <summary>
    /// RiskSecurityExchange Field
    /// </summary>/
    public sealed class RiskSecurityExchange : QuickFix.Fields.StringField
    {
        public RiskSecurityExchange()
            :base(Fields.CustomTags.RiskSecurityExchange) {}
        public RiskSecurityExchange(string val)
            :base(Fields.CustomTags.RiskSecurityExchange, val) {}

    }


    /// <summary>
    /// StreamAsgnType Field
    /// </summary>/
    public sealed class StreamAsgnType : QuickFix.Fields.IntField
    {
        public StreamAsgnType()
            :base(Fields.CustomTags.StreamAsgnType) {}
        public StreamAsgnType(int val)
            :base(Fields.CustomTags.StreamAsgnType, val) {}


        // Field Enumerations
        public const int ASSIGNMENT = 1;
        public const int REJECTED = 2;
        public const int TERMINATE_UNASSIGN = 3;
    }


    /// <summary>
    /// RelationshipRiskEncodedSecurityDescLen Field
    /// </summary>/
    public sealed class RelationshipRiskEncodedSecurityDescLen : QuickFix.Fields.IntField
    {
        public RelationshipRiskEncodedSecurityDescLen()
            :base(Fields.CustomTags.RelationshipRiskEncodedSecurityDescLen) {}
        public RelationshipRiskEncodedSecurityDescLen(int val)
            :base(Fields.CustomTags.RelationshipRiskEncodedSecurityDescLen, val) {}

    }


    /// <summary>
    /// RelationshipRiskEncodedSecurityDesc Field
    /// </summary>/
    public sealed class RelationshipRiskEncodedSecurityDesc : QuickFix.Fields.StringField
    {
        public RelationshipRiskEncodedSecurityDesc()
            :base(Fields.CustomTags.RelationshipRiskEncodedSecurityDesc) {}
        public RelationshipRiskEncodedSecurityDesc(string val)
            :base(Fields.CustomTags.RelationshipRiskEncodedSecurityDesc, val) {}

    }


    /// <summary>
    /// RiskEncodedSecurityDescLen Field
    /// </summary>/
    public sealed class RiskEncodedSecurityDescLen : QuickFix.Fields.IntField
    {
        public RiskEncodedSecurityDescLen()
            :base(Fields.CustomTags.RiskEncodedSecurityDescLen) {}
        public RiskEncodedSecurityDescLen(int val)
            :base(Fields.CustomTags.RiskEncodedSecurityDescLen, val) {}

    }


    /// <summary>
    /// RiskEncodedSecurityDesc Field
    /// </summary>/
    public sealed class RiskEncodedSecurityDesc : QuickFix.Fields.StringField
    {
        public RiskEncodedSecurityDesc()
            :base(Fields.CustomTags.RiskEncodedSecurityDesc) {}
        public RiskEncodedSecurityDesc(string val)
            :base(Fields.CustomTags.RiskEncodedSecurityDesc, val) {}

    }


}
