Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Imports System.Runtime.InteropServices

'----------------------------------------------------------------------
' SKOrderLib
'----------------------------------------------------------------------

'GetUserAccount、GetRealBalanceReport    Call Back Function Used
<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnGetBSTR(<MarshalAs(UnmanagedType.BStr)> ByVal strAccount As String)

'OnOrderAsyncReport Call Back Function
<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnOrderAsyncReport(ByVal nThreadID As Integer, ByVal nCode As Integer, <MarshalAs(UnmanagedType.BStr)> ByVal strAccount As String)

'OnTSFilledOrder Call Back Function
<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnTSFilledOrder(<MarshalAs(UnmanagedType.BStr)> ByVal bstrSymbol As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrDescription As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrOrderType As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrOrder As String, ByVal lFillPrice As Integer, ByVal lSlippage As Integer, _
 ByVal dTimePlace As Double, ByVal dTimeFilled As Double, <MarshalAs(UnmanagedType.BStr)> ByVal bstrStrategy As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrSignal As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrWorkspace As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrInterval As String, _
 <MarshalAs(UnmanagedType.BStr)> ByVal bstrPositionNumber As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrOrderNumber As String)

'OnTSActiveOrder Call Back Function
<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnTSActiveOrder(<MarshalAs(UnmanagedType.BStr)> ByVal bstrSymbol As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrDescription As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrOrderType As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrOrder As String, ByVal lLastPrice As Integer, ByVal dTimePlaced As Double, _
 <MarshalAs(UnmanagedType.BStr)> ByVal bstrStrategy As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrSignal As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrWorkspace As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrInterval As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrPositionNumber As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrOrderNumber As String)

'OnTSCanceledOrder Call Back Function
<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnTSCanceledOrder(<MarshalAs(UnmanagedType.BStr)> ByVal bstrSymbol As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrDescription As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrOrderType As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrOrder As String, ByVal dTimePlaced As Double, ByVal dTimeCanceled As Double, _
 <MarshalAs(UnmanagedType.BStr)> ByVal bstrStrategy As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrSignal As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrWorkspace As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrInterval As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrPositionNumber As String, <MarshalAs(UnmanagedType.BStr)> ByVal bstrOrderNumber As String, _
 <MarshalAs(UnmanagedType.BStr)> ByVal bstrCanceledNumber As String)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnGetExecutionReoprt(<MarshalAs(UnmanagedType.BStr)> ByVal strAccount As String)


'OverSea Product Struct
Public Structure SOfComProduct
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=10)> _
    Public strExchange As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=10)> _
    Public strProductNo As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=10)> _
    Public strYearMonth As String

    Public sSpecialTradeType As Integer

    Public dMinJump As Double

    Public nDenominator As Integer

    Public sDayTrade As Integer
End Structure

'----------------------------------------------------------------------
' SKReplyLib
'----------------------------------------------------------------------

' Define Connect Disconnect Call Back Function
<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnConnect(<MarshalAs(UnmanagedType.BStr)> ByVal strAccount As String, ByVal nErrorCode As Integer)

'Define OnData Call Back
<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnData(ByVal strData As IntPtr)
'public delegate void FOnData([MarshalAs(UnmanagedType.BStr)]string strData);

'Define OnComplete Call Back
<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnComplete(ByVal nComplete As Integer)

'Reply Data Struct
<StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
Public Structure DataItem
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=13)> _
    Public strKeyNo As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=2)> _
    Public strMarketType As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=1)> _
    Public strType As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=1)> _
    Public strOrderErr As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=7)> _
    Public strBroker As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=7)> _
    Public strCustNo As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=3)> _
    Public strBuySell As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=7)> _
    Public strExchangeID As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> _
    Public strComId As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=13)> _
    Public strStrikePrice As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=5)> _
    Public strOrderNo As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=13)> _
    Public strPrice As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=5)> _
    Public strNumerator As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=4)> _
    Public strDenominator As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=13)> _
    Public strPrice1 As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=5)> _
    Public strNumerator1 As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=4)> _
    Public strDenominator1 As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=13)> _
    Public strPrice2 As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=5)> _
    Public strNumerator2 As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=4)> _
    Public strDenominator2 As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=8)> _
    Public strQty As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=4)> _
    Public strBeforeQty As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=4)> _
    Public strAfterQty As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=8)> _
    Public strDate As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=6)> _
    Public strTime As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=8)> _
    Public strOkSeq As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=7)> _
    Public strSubID As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=4)> _
    Public strSaleNo As String

    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=1)> _
    Public strAgent As String
End Structure

Enum ApiMessage
    SK_SUCCESS = 0
    SK_ERROR_INITIALIZE_FAIL = 1000
    SK_ERROR_ACCOUNT_NOT_EXIST = 1001
    SK_ERROR_ACCOUNT_MARKET_NOT_MATCH = 1002
    SK_ERROR_PERIOD_OUT_OF_RANGE = 1003
    SK_ERROR_FLAG_OUT_OF_RANGE = 1004
    SK_ERROR_BUYSELL_OUT_OF_RANGE = 1005
    SK_ERROR_ORDER_SERVER_INVALID = 1006
    SK_ERROR_PERMISSION_DENIED = 1007
    SK_ERROR_TRADE_TYPR_OUT_OF_RANGE = 1008
    SK_ERROR_DAY_TRADE_OUT_OF_RANGE = 1009
    SK_ERROR_ORDER_SIGN_INVALID = 1010
    SK_ERROR_NEW_CLOSE_OUT_OF_RANGE = 1011
    SK_ERROR_PRODUCT_INVALID = 1012
    SK_ERROR_QTY_INVALID = 1013
    SK_ERROR_DAYTRADE_DENIED = 1014
    SK_ERROR_SPCIAL_TRADE_TYPE_INVALID = 1015
    SK_ERROR_PRICE_INVALID = 1016
    SK_ERROR_INDEX_OUT_OF_RANGE = 1017
    SK_ERROR_QUERY_IN_PROCESSING = 1018
    SK_ERROR_LOGIN_INVALID = 1019
    SK_ERROR_REGISTER_CALLBACK = 1020
    SK_ERROR_FUNCTION_PERMISSION_DENIED = 1021
    SK_ERROR_MARKET_OUT_OF_RANGE = 1022
    SK_ERROR_PERMISSION_TIMEOUT = 1023
    SK_ERROR_FOREIGNSTOCK_PRICE_OUT_OF_RANGE = 1024
    SK_ERROR_FOREIGNSTOCK_UNDEFINE_COINTYPE = 1025
    SK_ERROR_FOREIGNSTOCK_SAME_COINSTYPE = 1026
    SK_ERROR_FOREIGNSTOCK_SALE_SHOULD_ORIGINAL_COIN = 1027
    SK_ERROR_FOREIGNSTOCK_TRADE_UNIT_INVALID = 1028
    SK_ERROR_FOREIGNSTOCK_STOCKNO_INVALID = 1029
    SK_ERROR_FOREIGNSTOCK_ACCOUNTTYPE_INVALID = 1030
    SK_ERROR_FOREIGNSTOCK_INITIALIZE_FAIL = 1031
    SK_ERROR_TS_INITIALIZE_FAIL = 1032
    SK_ERROR_OVERSEA_TRADE_PRODUCT_FAIL = 1033
    SK_ERROR_OVERSEA_TRADE_DATA_NOT_COMPLETE = 1034
    SK_ERROR_CERT_VERIFY_CN_INVALID = 1035
    SK_ERROR_CERT_VERIFY_SERVER_REJECT = 1036
    SK_ERROR_CERT_NOT_VERIFIED = 1037
    SK_ERROR_SERVER_NOT_CONNECTED = 1038
    SK_WARNING_OF_COM_DATA_MISSING = 2001
    SK_WARNING_TS_READY = 2002
    SK_WARNING_LOGIN_ALREADY = 2003
    SK_WARNING_LOGIN_SPECIAL_ALREADY = 2004
    SK_FAIL = 3001
End Enum

Public Class Functions

    '[DllImport("SKOrderLib.dll")]
    'public static extern int SKOrderLib_Initialize(char[] pcUserName, char[] pcPassword);

#Region "SKOrderLib"
    '----------------------------------------------------------------------
    ' SKOrderLib
    '----------------------------------------------------------------------

    <DllImport("SKOrderLib.dll", EntryPoint:="SKOrderLib_Initialize", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOrderLib_Initialize(ByVal pcUserName As String, ByVal pcPassword As String) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SKOrderLib_InitializeTS", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOrderLib_InitializeTS(ByVal lpszTSCOMName As String) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SKOrderLib_ReadCertByID", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOrderLib_ReadCertByID(ByVal lpszUserID As String) As Integer
    End Function

    <DllImport("SKOrderLib.dll")> _
    Public Shared Function GetUserAccount() As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendStockOrder", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SendStockOrder(ByVal lpszAccount As String, ByVal lpszStockNo As String, ByVal usPeriod As Integer, ByVal usFlag As Integer, ByVal usBuySell As Integer, ByVal lpszPrice As String, _
   ByVal nQty As Integer, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendStockOrderAsync", CharSet:=CharSet.Ansi)> _
    Public Shared Function SendStockOrderAsync(ByVal lpszAccount As String, ByVal lpszStockNo As String, ByVal usPeriod As Integer, ByVal usFlag As Integer, ByVal usBuySell As Integer, ByVal lpszPrice As String, _
   ByVal nQty As Integer) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="CancelOrderByStockNo", CharSet:=CharSet.Ansi)> _
    Public Shared Function CancelOrderByStockNo(ByVal lpszAccount As String, ByVal lpszStockNo As String) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="CancelOrderBySeqNo", CharSet:=CharSet.Ansi)> _
    Public Shared Function CancelOrderBySeqNo(ByVal lpszAccount As String, ByVal lpszStockNo As String) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="GetRealBalanceReport", CharSet:=CharSet.Ansi)> _
    Public Shared Function GetRealBalanceReport(ByVal lpszAccount As String) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendFutureOrder", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SendFutureOrder(ByVal lpszAccount As String, ByVal lpszFutureNo As String, ByVal usTradeType As Integer, ByVal usDayTrade As Integer, ByVal usBuySell As Integer, ByVal lpszPrice As String, _
   ByVal nQty As Integer, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendFutureOrderAsync", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SendFutureOrderAsync(ByVal lpszAccount As String, ByVal lpszFutureNo As String, ByVal usTradeType As Integer, ByVal usDayTrade As Integer, ByVal usBuySell As Integer, ByVal lpszPrice As String, _
   ByVal nQty As Integer) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="GetOpenInterest", CharSet:=CharSet.Ansi)> _
    Public Shared Function GetOpenInterest(ByVal lpszAccount As String) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendOptionOrder", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SendOptionOrder(ByVal lpszAccount As String, ByVal lpszFutureNo As String, ByVal usTradeType As Integer, ByVal usNewClose As Integer, ByVal usBuySell As Integer, ByVal lpszPrice As String, _
   ByVal nQty As Integer, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendOptionOrderAsync", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SendOptionOrderAsync(ByVal lpszAccount As String, ByVal lpszFutureNo As String, ByVal usTradeType As Integer, ByVal usNewClose As Integer, ByVal usBuySell As Integer, ByVal lpszPrice As String, _
   ByVal nQty As Integer) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendForeignStockOrder", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SendForeignStockOrder(ByVal lpszAccount As String, ByVal lpszStockNo As String, ByVal lpszExchangeNo As String, ByVal usBuySell As Integer, ByVal lpszPrice As String, ByVal nQty As Integer, _
   ByVal lpszCurrency1 As String, ByVal lpszCurrency2 As String, ByVal lpszCurrency3 As String, ByVal iAccountType As Integer, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendForeignStockOrderAsync", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SendForeignStockOrderAsync(ByVal lpszAccount As String, ByVal lpszStockNo As String, ByVal lpszExchangeNo As String, ByVal usBuySell As Integer, ByVal lpszPrice As String, ByVal nQty As Integer, _
   ByVal lpszCurrency1 As String, ByVal lpszCurrency2 As String, ByVal lpszCurrency3 As String, ByVal iAccountType As Integer) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="CancelForeignStockOrderByBookNo", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function CancelForeignStockOrderByBookNo(ByVal lpszAccount As String, ByVal lpszBookNo As String, ByVal lpszExchangeNo As String, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="CancelForeignStockOrderBySeqNo", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function CancelForeignStockOrderBySeqNo(ByVal lpszAccount As String, ByVal lpszSeqNo As String, ByVal lpszExchangeNo As String, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendOverseaFutureOrder", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SendOverseaFutureOrder(ByVal lpszAccount As String, ByVal lpszTradeName As String, ByVal lpszStockNo As String, ByVal lpszYearMonth As String, ByVal usBuySell As Integer, ByVal usNewClose As Integer, _
   ByVal usDayTrade As Integer, ByVal usTradeType As Integer, ByVal usSpecialTradeType As Integer, ByVal nQty As Integer, ByVal lpszOrder As String, ByVal lpszOrderNumerator As String, _
   ByVal lpszTrigger As String, ByVal lpszTriggerNumerator As String, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendOverseaFutureOrderAsync", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SendOverseaFutureOrderAsync(ByVal lpszAccount As String, ByVal lpszTradeName As String, ByVal lpszStockNo As String, ByVal lpszYearMonth As String, ByVal usBuySell As Integer, ByVal usNewClose As Integer, _
   ByVal usDayTrade As Integer, ByVal usTradeType As Integer, ByVal usSpecialTradeType As Integer, ByVal nQty As Integer, ByVal lpszOrder As String, ByVal lpszOrderNumerator As String, _
   ByVal lpszTrigger As String, ByVal lpszTriggerNumerator As String) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="GetOverseaCount", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function GetOverseaCount() As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="GetOverseaProducts", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function GetOverseaProducts(ByVal nIndext As Integer, ByRef product As SOfComProduct) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="GetOverseaFutures", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function GetOverseaFutures() As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="ReloadOverseaProducts", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function ReloadOverseaProducts() As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="OverseaCancelOrderBySeqNo", CharSet:=CharSet.Ansi)> _
    Public Shared Function OverseaCancelOrderBySeqNo(ByVal lpszAccount As String, ByVal lpszSeqNo As String) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="OverseaDecreaseOrderBySeqNo", CharSet:=CharSet.Ansi)> _
    Public Shared Function OverseaDecreaseOrderBySeqNo(ByVal lpszAccount As String, ByVal lpszSeqNo As String, ByVal nDecreaseQty As Integer) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="DecreaseOrderBySeqNo", CharSet:=CharSet.Ansi)> _
    Public Shared Function DecreaseOrderBySeqNo(ByVal lpszAccount As String, ByVal lpszSeqNo As String, ByVal nDecreaseQty As Integer) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendFutureStopLoss", CharSet:=CharSet.Ansi)> _
    Public Shared Function SendFutureStopLoss(ByVal lpszAccount As String, ByVal lpszFutureNo As String, ByVal usTradeType As Integer, ByVal usDayTrade As Integer, ByVal usBuySell As Integer, ByVal lpszPrice As String, _
   ByVal nQty As Integer, ByVal lpszTriggerPrice As String, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="CancelFutureStopLoss", CharSet:=CharSet.Ansi)> _
    Public Shared Function CancelFutureStopLoss(ByVal lpszAccount As String, ByVal lpszBookNo As String, ByVal lpszSymbol As String, ByVal lpszBuySell As String, ByVal lpszPrice As String, ByVal lpszQty As String, _
   ByVal lpszTriggerPrice As String, ByVal lpszTradeType As String, ByVal lpszDayTrade As String, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="GetStopLossReport", CharSet:=CharSet.Ansi)> _
    Public Shared Function GetStopLossReport(ByVal lpszAccount As String, ByVal nReportStatus As Integer, ByVal lpszType As String) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendMovingStopLoss", CharSet:=CharSet.Ansi)> _
    Public Shared Function SendMovingStopLoss(ByVal lpszAccount As String, ByVal lpszFutureNo As String, ByVal usTradeType As Integer, ByVal usDayTrade As Integer, ByVal usBuySell As Integer, ByVal lpszPrice As String, _
   ByVal nQty As Integer, ByVal lpszMovingPoint As String, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="CancelMovingStopLoss", CharSet:=CharSet.Ansi)> _
    Public Shared Function CancelMovingStopLoss(ByVal lpszAccount As String, ByVal lpszBookNo As String, ByVal lpszSymbol As String, ByVal lpszBuySell As String, ByVal lpszPrice As String, ByVal lpszQty As String, _
   ByVal lpszMovingPoint As String, ByVal lpszTradeType As String, ByVal lpszDayTrade As String, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="SendOptionStopLoss", CharSet:=CharSet.Ansi)> _
    Public Shared Function SendOptionStopLoss(ByVal lpszAccount As String, ByVal lpszFutureNo As String, ByVal usTradeType As Integer, ByVal usNewClose As Integer, ByVal usBuySell As Integer, ByVal lpszPrice As String, _
   ByVal nQty As Integer, ByVal lpszMovingPoint As String, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="CancelOptionStopLoss", CharSet:=CharSet.Ansi)> _
    Public Shared Function CancelOptionStopLoss(ByVal lpszAccount As String, ByVal lpszBookNo As String, ByVal lpszSymbol As String, ByVal lpszBuySell As String, ByVal lpszPrice As String, ByVal lpszQty As String, _
   ByVal lpszMovingPoint As String, ByVal lpszTradeType As String, ByVal lpszDayTrade As String, <MarshalAs(UnmanagedType.LPStr)> ByVal buf As StringBuilder, ByRef pnMessageBufferSize As Int32) As Integer
    End Function

    <DllImport("SKOrderLib.dll", EntryPoint:="GetExecutionReport", CharSet:=CharSet.Ansi)> _
    Public Shared Function GetExecutionReport(ByVal lpszAccount As String, ByVal lpszStockNo As String, ByVal nMarket As Integer, ByVal nBuySell As Integer, ByVal nDataNum As Integer, ByVal nType As Integer) As Integer
    End Function






    <DllImport("SKOrderLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnAccountCallBack(ByVal Account As FOnGetBSTR) As Integer
    End Function

    <DllImport("SKOrderLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnOrderAsyncReportCallBack(ByVal OrderAsync As FOnOrderAsyncReport) As Integer
    End Function

    <DllImport("SKOrderLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnRealBalanceReportCallBack(ByVal RealBalanceReport As FOnGetBSTR) As Integer
    End Function

    <DllImport("SKOrderLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnOpenInterestCallBack(ByVal OnOpenInterest As FOnGetBSTR) As Integer
    End Function

    <DllImport("SKOrderLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnOverseaFuturesCallBack(ByVal OnOpenInterest As FOnGetBSTR) As Integer
    End Function

    <DllImport("SKOrderLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnTSFilledOrderCallBack(ByVal OnTSFilledOrder As FOnTSFilledOrder) As Integer
    End Function

    <DllImport("SKOrderLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnTSActiveOrderCallBack(ByVal OnTSActiveOrder As FOnTSActiveOrder) As Integer
    End Function

    <DllImport("SKOrderLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnTSCanceledOrderCallBack(ByVal OnTSCanceledOrder As FOnTSCanceledOrder) As Integer
    End Function

    <DllImport("SKOrderLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnStopLossReportCallBack(ByVal OnTSCanceledOrder As FOnGetBSTR) As Integer
    End Function

    <DllImport("SKOrderLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnExecutionReportCallBack(ByVal ExecutionReport As FOnGetExecutionReoprt) As Integer
    End Function

#End Region

#Region "SKReplyLib"
    '----------------------------------------------------------------------
    ' SKReplyLib
    '----------------------------------------------------------------------

    <DllImport("SKReplyLib.dll", EntryPoint:="SKReplyLib_Initialize", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKReplyLib_Initialize(ByVal pcUserName As String, ByVal pcPassword As String) As Integer
    End Function

    <DllImport("SKReplyLib.dll", EntryPoint:="SKReplyLib_ConnectByID", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKReplyLib_ConnectByID(ByVal pcUserID As String) As Integer
    End Function

    <DllImport("SKReplyLib.dll", EntryPoint:="SKReplyLib_IsConnectedByID", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKReplyLib_IsConnectedByID(ByVal pcUserID As String) As Integer
    End Function

    <DllImport("SKReplyLib.dll", EntryPoint:="SKReplyLib_CloseByID", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKReplyLib_CloseByID(ByVal pcUserID As String) As Integer
    End Function


    <DllImport("SKReplyLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnConnectCallBack(ByVal Connect As FOnConnect) As Integer
    End Function

    <DllImport("SKReplyLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnDisconnectCallBack(ByVal Connect As FOnConnect) As Integer
    End Function

    <DllImport("SKReplyLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnDataCallBack(ByVal Data As FOnData) As Integer
    End Function


    <DllImport("SKReplyLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function RegisterOnCompleteCallBack(ByVal Complete As FOnComplete) As Integer
    End Function


#End Region

End Class
