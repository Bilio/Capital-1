using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace ReplyTesterVC
{
    //----------------------------------------------------------------------
    // SKReplyLib
    //----------------------------------------------------------------------

    // Define Connect Disconnect Call Back Function
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FOnConnect([MarshalAs(UnmanagedType.BStr)]string strAccount, int nErrorCode);

    //Define OnData Call Back
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FOnData(IntPtr strData);
    //public delegate void FOnData([MarshalAs(UnmanagedType.BStr)]string strData);

    //Define OnComplete Call Back
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void FOnComplete(int nComplete);

    //Reply Data Struct
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DataItem
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string strKeyNo;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string strMarketType;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string strType;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string strOrderErr;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string strBroker;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string strCustNo;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string strBuySell;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string strExchangeID;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string strComId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string strStrikePrice;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string strOrderNo;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string strPrice;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string strNumerator;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string strDenominator;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string strPrice1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string strNumerator1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string strDenominator1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string strPrice2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string strNumerator2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string strDenominator2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string strQty;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string strBeforeQty;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string strAfterQty;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string strDate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public string strTime;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string strOkSeq;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string strSubID;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string strSaleNo;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string strAgent;
    }


    enum ApiMessage
    {
        SK_SUCCESS = 0,
        SK_ERROR_INITIALIZE_FAIL = 1000,
        SK_ERROR_ACCOUNT_NOT_EXIST = 1001,
        SK_ERROR_ACCOUNT_MARKET_NOT_MATCH = 1002,
        SK_ERROR_PERIOD_OUT_OF_RANGE = 1003,
        SK_ERROR_FLAG_OUT_OF_RANGE = 1004,
        SK_ERROR_BUYSELL_OUT_OF_RANGE = 1005,
        SK_ERROR_ORDER_SERVER_INVALID = 1006,
        SK_ERROR_PERMISSION_DENIED = 1007,
        SK_ERROR_TRADE_TYPR_OUT_OF_RANGE = 1008,
        SK_ERROR_DAY_TRADE_OUT_OF_RANGE = 1009,
        SK_ERROR_ORDER_SIGN_INVALID = 1010,
        SK_ERROR_NEW_CLOSE_OUT_OF_RANGE = 1011,
        SK_ERROR_PRODUCT_INVALID = 1012,
        SK_ERROR_QTY_INVALID = 1013,
        SK_ERROR_DAYTRADE_DENIED = 1014,
        SK_ERROR_SPCIAL_TRADE_TYPE_INVALID = 1015,
        SK_ERROR_PRICE_INVALID = 1016,
        SK_ERROR_INDEX_OUT_OF_RANGE = 1017,
        SK_ERROR_QUERY_IN_PROCESSING = 1018,
        SK_ERROR_LOGIN_INVALID = 1019,
        SK_ERROR_REGISTER_CALLBACK = 1020,
        SK_ERROR_FUNCTION_PERMISSION_DENIED = 1021,
        SK_ERROR_MARKET_OUT_OF_RANGE = 1022,
        SK_ERROR_PERMISSION_TIMEOUT = 1023,
        SK_ERROR_FOREIGNSTOCK_PRICE_OUT_OF_RANGE = 1024,
        SK_ERROR_FOREIGNSTOCK_UNDEFINE_COINTYPE = 1025,
        SK_ERROR_FOREIGNSTOCK_SAME_COINSTYPE = 1026,
        SK_ERROR_FOREIGNSTOCK_SALE_SHOULD_ORIGINAL_COIN = 1027,
        SK_ERROR_FOREIGNSTOCK_TRADE_UNIT_INVALID = 1028,
        SK_ERROR_FOREIGNSTOCK_STOCKNO_INVALID = 1029,
        SK_ERROR_FOREIGNSTOCK_ACCOUNTTYPE_INVALID = 1030,
        SK_ERROR_FOREIGNSTOCK_INITIALIZE_FAIL = 1031,
        SK_ERROR_TS_INITIALIZE_FAIL = 1032,
        SK_ERROR_OVERSEA_TRADE_PRODUCT_FAIL = 1033,
        SK_ERROR_OVERSEA_TRADE_DATA_NOT_COMPLETE = 1034,
        SK_ERROR_CERT_VERIFY_CN_INVALID = 1035,
        SK_ERROR_CERT_VERIFY_SERVER_REJECT = 1036,
        SK_ERROR_CERT_NOT_VERIFIED = 1037,
        SK_ERROR_SERVER_NOT_CONNECTED = 1038,
        SK_ERROR_ORDER_LOCK = 1039,
        SK_ERROR_DID_NOT_LOCK = 1040,
        SK_WARNING_OF_COM_DATA_MISSING = 2001,
        SK_WARNING_TS_READY = 2002,
        SK_WARNING_LOGIN_ALREADY = 2003,
        SK_WARNING_LOGIN_SPECIAL_ALREADY = 2004,
        SK_FAIL = 3001
    }
    class Functions
    {

        #region SKReplyLib
        //----------------------------------------------------------------------
        // SKReplyLib
        //----------------------------------------------------------------------

        [DllImport("SKReplyLib.dll", EntryPoint = "SKReplyLib_Initialize", CharSet = CharSet.Ansi)]
        public static extern int SKReplyLib_Initialize(string pcUserName, string pcPassword);

        [DllImport("SKReplyLib.dll", EntryPoint = "SKReplyLib_ConnectByID", CharSet = CharSet.Ansi)]
        public static extern int SKReplyLib_ConnectByID(string pcUserID);

        [DllImport("SKReplyLib.dll", EntryPoint = "SKReplyLib_IsConnectedByID", CharSet = CharSet.Ansi)]
        public static extern int SKReplyLib_IsConnectedByID(string pcUserID);

        [DllImport("SKReplyLib.dll", EntryPoint = "SKReplyLib_CloseByID", CharSet = CharSet.Ansi)]
        public static extern int SKReplyLib_CloseByID(string pcUserID);


        [DllImport("SKReplyLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterOnConnectCallBack(FOnConnect Connect);

        [DllImport("SKReplyLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterOnDisconnectCallBack(FOnConnect Connect);

        [DllImport("SKReplyLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterOnDataCallBack(FOnData Data);


        [DllImport("SKReplyLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int RegisterOnCompleteCallBack(FOnComplete Complete);


        #endregion
    }
}
