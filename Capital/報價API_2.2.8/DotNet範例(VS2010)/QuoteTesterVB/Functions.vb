Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Runtime.InteropServices


<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnNotifyConnection(ByVal nKind As Integer, ByVal nCode As Integer)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnNotifyQuote(ByVal sMarketNo As Short, ByVal sStockidx As Short)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnNotifyTicks(ByVal sMarketNo As Short, ByVal sStockidx As Short, ByVal nPtr As Integer)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnNotifyBest5(ByVal sMarketNo As Short, ByVal sStockidx As Short)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnNotifyKLineData(<MarshalAs(UnmanagedType.BStr)> ByVal caStockNo As String, <MarshalAs(UnmanagedType.BStr)> ByVal caData As String)

<UnmanagedFunctionPointer(CallingConvention.StdCall)> _
Public Delegate Sub FOnNotifyServerTime(ByVal sHour As Short, ByVal sMinute As Short, ByVal sSecond As Short, ByVal nTotal As Integer)


Public Structure FORMAT05
    Public m_sHour As Short
    ' 時
    Public m_sMinute As Short
    ' 分
    Public m_sSecond As Short
    ' 秒
    Public m_lTotal As Long
    ' 總秒數
End Structure

Public Structure TICK
    Public m_nPtr As Integer
    ' KEY
    Public m_nTime As Integer
    '時間
    Public m_nBid As Integer
    ' 買價
    Public m_nAsk As Integer
    ' 賣價
    Public m_nClose As Integer
    '成交價
    Public m_nQty As Integer
    ' 成交量
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
    Public m_nExtendBid As Integer
    Public m_nExtendBidQty As Integer
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
    Public m_nExtendAsk As Integer
    Public m_nExtendAskQty As Integer
End Structure

Public Structure STOCK
    Public m_sStockidx As Short
    ' 系統自行定義的股票代碼
    Public m_sDecimal As Short
    ' 報價小數位數
    Public m_sTypeNo As Short
    ' 類股分類
    ' 市場代號0x00上市;0x01上櫃;0x02期貨;0x03選擇權; 0x04興櫃
    Public m_cMarketNo As Char

    ' 市場代號0x00上市;0x01上櫃;0x02期貨;0x03選擇權; 0x04興櫃
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> _
    Public m_caStockNo As String
    ' 股票代號
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> _
    Public m_caName As String
    ' 股票名稱
    Public m_nOpen As Integer
    ' 開盤價
    Public m_nHigh As Integer
    ' 最高價
    Public m_nLow As Integer
    ' 最低價
    Public m_nClose As Integer
    ' 成交價
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
    Public m_nTBc As Integer
    ' 買盤量
    Public m_nTAc As Integer
    ' 賣盤量
    Public m_nFutureOI As Integer
    ' 期貨未平倉 OI
    Public m_nTQty As Integer
    ' 總量
    Public m_nYQty As Integer
    ' 昨量
    Public m_nUp As Integer
    ' 漲停價
    Public m_nDown As Integer
    ' 跌停價
End Structure


Enum ApiMessage
    SK_SUCCESS = 0
    SK_FAIL = -1
    SK_ERROR_SERVER_NOT_CONNECTED = -2
    SK_ERROR_INITIALIZE_FAIL = -4
    SK_ERROR_ACCOUNT_NOT_EXIST = 1
    SK_ERROR_ACCOUNT_MARKET_NOT_MATCH = 2
    SK_ERROR_PERIOD_OUT_OF_RANGE = 3
    SK_ERROR_FLAG_OUT_OF_RANGE = 4
    SK_ERROR_BUYSELL_OUT_OF_RANGE = 5
    SK_ERROR_ORDER_SERVER_INVALID = 6
    SK_ERROR_PERMISSION_DENIED = 7
    SK_ERROR_TRADE_TYPR_OUT_OF_RANGE = 8
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

End Enum

Class Functions
    <DllImport("SKQuoteLib.dll", EntryPoint:="SKQuoteLib_Initialize", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_Initialize(ByVal pcUserName As String, ByVal pcPassword As String) As Integer
    End Function

    <DllImport("SKQuoteLib.dll", EntryPoint:="SKQuoteLib_EnterMonitor", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_EnterMonitor() As Integer
    End Function

    <DllImport("SKQuoteLib.dll", EntryPoint:="SKQuoteLib_LeaveMonitor", CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_LeaveMonitor() As Integer
    End Function

    <DllImport("SKQuoteLib.dll", EntryPoint:="SKQuoteLib_RequestServerTime", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_RequestServerTime() As Integer
    End Function

    <DllImport("SKQuoteLib.dll", EntryPoint:="SKQuoteLib_GetServerTime", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_GetServerTime(ByRef Time As FORMAT05) As Integer
    End Function

    <DllImport("SKQuoteLib.dll", EntryPoint:="SKQuoteLib_RequestStocks", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_RequestStocks(ByRef psPageNo As Integer, ByVal pStockNos As String) As Integer
    End Function

    <DllImport("SKQuoteLib.dll", EntryPoint:="SKQuoteLib_GetStockByIndex", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_GetStockByIndex(ByVal sMarketNo As Short, ByVal sIndex As Short, ByRef TStock As STOCK) As Integer
    End Function

    <DllImport("SKQuoteLib.dll", EntryPoint:="SKQuoteLib_RequestTicks", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_RequestTicks(ByRef psPageNo As Integer, ByVal pStockNos As String) As Integer
    End Function

    <DllImport("SKQuoteLib.dll", EntryPoint:="SKQuoteLib_GetTick", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_GetTick(ByVal sMarketNo As Integer, ByVal sStockidx As Integer, ByVal nPtr As Integer, ByRef Tick As TICK) As Integer
    End Function

    <DllImport("SKQuoteLib.dll", EntryPoint:="SKQuoteLib_GetBest5", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Shared Function SKQuoteLib_GetBest5(ByVal sMarketNo As Integer, ByVal sStockidx As Integer, ByRef Best5 As BEST5) As Integer
    End Function




    <DllImport("SKQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKQuoteLib_AttachConnectionCallBack(ByVal Connection As FOnNotifyConnection) As Integer
    End Function

    <DllImport("SKQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKQuoteLib_AttachQuoteCallBack(ByVal Quote As FOnNotifyQuote) As Integer
    End Function

    <DllImport("SKQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKQuoteLib_AttachTicksCallBack(ByVal Ticks As FOnNotifyTicks) As Integer
    End Function

    <DllImport("SKQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKQuoteLib_AttachBest5CallBack(ByVal Quote As FOnNotifyBest5) As Integer
    End Function

    <DllImport("SKQuoteLib.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SKQuoteLib_AttchServerTimeCallBack(ByVal Quote As FOnNotifyServerTime) As Integer
    End Function


End Class