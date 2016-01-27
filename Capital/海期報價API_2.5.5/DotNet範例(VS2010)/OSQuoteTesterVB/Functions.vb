Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Runtime.InteropServices

'Namespace OSQuoteTesterVB

' Define Call Back Function
<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnConnect(ByVal nKind As Integer, ByVal nErrorCode As Integer)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnOverseaProducts(<MarshalAs(UnmanagedType.BStr)> ByVal strProducts As String)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnGetStockIdx(ByVal nCode As Short)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnNotifyTicks(ByVal sStockidx As Short, ByVal nPtr As Integer)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnNotifyServerTime(ByVal sHour As Short, ByVal sMinute As Short, ByVal sSecond As Short)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnNotifyKLineData(<MarshalAs(UnmanagedType.BStr)> ByVal strStockNo As String, <MarshalAs(UnmanagedType.BStr)> ByVal strKData As String)

Public Structure FOREIGN
    Public m_sStockidx As Short
    ' 系統自行定義的股票代碼
    Public m_sDecimal As Short
    ' 報價小數位數
    Public m_nDenominator As Integer
    ' 分母
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=1)> _
    Public m_cMarketNo As String
    ' 市場代號0x05海外商品
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> _
    Public m_caExchangeNo As String
    ' 交易所代號
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> _
    Public m_caExchangeName As String
    ' 交易所名稱
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> _
    Public m_caStockNo As String
    ' 股票代號
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> _
    Public m_caStockName As String
    ' 股票名稱
    Public m_nOpen As Integer
    ' 開盤價
    Public m_nHigh As Integer
    ' 最高價
    Public m_nLow As Integer
    ' 最低價
    Public m_nClose As Integer
    ' 成交價
    Public m_dSettlePrice As Integer
    '結算價
    Public m_nTickQty As Integer
    ' 單量
    Public m_nRef As Integer
    ' 昨收、參考價
    Public m_nBid As Integer
    ' 買價
    Public m_nBc As Integer
    ' 買量
    Public m_nAsk As Integer
    ' 賣價
    Public m_nAc As Integer
    ' 賣量
    Public m_nTQty As Integer
    ' 總量
End Structure

Public Structure TICK
    Public m_nPtr As Integer
    'Index

    Public m_nTime As Integer
    ' 時間
    Public m_nClose As Integer
    '成交價
    Public m_nQty As Integer
    '成交量
End Structure
Public Structure BEST5
    Public m_nBid1 As Integer
    Public m_nBidQty1 As Integer
    Public m_nBid2 As Integer
    Public m_nBidQty2 As Integer
    Public m_nBid3 As Integer
    Public m_nBidQty3 As Integer
    Public m_nBid4 As Integer
    Public m_nBidQty4 As Integer
    Public m_nBid5 As Integer
    Public m_nBidQty5 As Integer
    Public m_nAsk1 As Integer
    Public m_nAskQty1 As Integer
    Public m_nAsk2 As Integer
    Public m_nAskQty2 As Integer
    Public m_nAsk3 As Integer
    Public m_nAskQty3 As Integer
    Public m_nAsk4 As Integer
    Public m_nAskQty4 As Integer
    Public m_nAsk5 As Integer
    Public m_nAskQty5 As Integer
End Structure

Enum ApiMessage
    SK_SUCCESS = 0
    SK_FAIL = -1
    SK_ERROR_SERVER_NOT_CONNECTED = -3
    SK_ERROR_INITIALIZE_FAIL = -4
    SK_ERROR_ACCOUNT_NOT_EXIST = 1
    SK_ERROR_ACCOUNT_MARKET_NOT_MATCH = 2
    SK_ERROR_PERIOD_OUT_OF_RANGE = 3
    SK_ERROR_FLAG_OUT_OF_RANGE = 4
    SK_ERROR_BUYSELL_OUT_OF_RANGE = 5
    SK_ERROR_ORDER_SERVER_INVALID = 6
    SK_ERROR_PERMISSION_DENIED = 7
    SK_KLINE_DATA_TYPE_NOT_FOUND = 8
    SK_ERROR_PERMISSION_TIMEOUT = 9

    SK_SUBJECT_CONNECTION_CONNECTED = 100
    SK_SUBJECT_CONNECTION_DISCONNECT = 101
    SK_SUBJECT_QUOTE_PAGE_EXCEED = 200
    SK_SUBJECT_QUOTE_PAGE_INCORRECT = 201
    SK_SUBJECT_TICK_PAGE_EXCEED = 210
    SK_SUBJECT_TICK_PAGE_INCORRECT = 211
    SK_SUBJECT_TICK_STOCK_NOT_FOUND = 212
    SK_SUBJECT_BEST5_DATA_NOT_FOUND = 213
    SK_SUBJECT_QUOTEREQUEST_NOT_FOUND = 214
    SK_SUBJECT_SERVER_TIME_NOT_FOUND = 215

    SK_WARNING_LOGIN_ALREADY = 2003
End Enum

Class Functions
    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_Initialize", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_Initialize(ByVal pcUserName As String, ByVal pcPassword As String) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_EnterMonitor", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_EnterMonitor(ByVal nConnectType As Short) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_LeaveMonitor", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_LeaveMonitor() As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_RequestStocks", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_RequestStocks(ByRef psPageNo As Integer, ByVal pStockNos As String) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_RequestTicks", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_RequestTicks(ByRef psPageNo As Integer, ByVal pStockNos As String) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_GetStockByIndex", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_GetStockByIndex(ByVal sIndex As Short, ByRef TForeign As FOREIGN) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_GetTick", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_GetTick(ByVal sIndex As Short, ByVal nPtr As Integer, ByRef TTick As TICK) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_GetBest5", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_GetBest5(ByVal sIndex As Short, ByRef TBest5 As BEST5) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_RequestOverseaProducts", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_RequestOverseaProducts() As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_RequestServerTime", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_RequestServerTime() As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_RequestKLine", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_RequestKLine(ByVal pStockNos As String, ByVal KLineType As Short) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", EntryPoint:="SKOSQuoteLib_EnterMonitor_WithOutLogIn", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKOSQuoteLib_EnterMonitor_WithOutLogIn(ByVal nConnectType As Short, ByVal pcUserName As String) As Integer
    End Function




    <DllImport("SKOSQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKOSQuoteLib_AttachConnectCallBack(ByVal Connect As FOnConnect) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKOSQuoteLib_AttachQuoteCallBack(ByVal StockIdx As FOnGetStockIdx) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKOSQuoteLib_AttachTicksCallBack(ByVal StockIdx As FOnNotifyTicks) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKOSQuoteLib_AttachBest5CallBack(ByVal StockIdx As FOnGetStockIdx) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKOSQuoteLib_AttachOverseaProductsCallBack(ByVal OverseaProducts As FOnOverseaProducts) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKOSQuoteLib_AttachServerTimeCallBack(ByVal ServerTime As FOnNotifyServerTime) As Integer
    End Function

    <DllImport("SKOSQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKOSQuoteLib_AttachKLineDataCallBack(ByVal KLineData As FOnNotifyKLineData) As Integer
    End Function


End Class
'End Namespace
