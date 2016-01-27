Imports System.Runtime.InteropServices

Public Class Form1
#Region "宣告函式"
    Private Declare Function SKQuoteLib_Initialize Lib "C:\Capital\SKQuoteLib.dll" (ByVal ID As String, ByVal Password As String) As Integer
    Private Declare Function SKQuoteLib_EnterMonitor Lib "C:\Capital\SKQuoteLib.dll" () As Integer
    Private Declare Function SKQuoteLib_LeaveMonitor Lib "C:\Capital\SKQuoteLib.dll" () As Integer
    Friend Declare Function SKQuoteLib_RequestStocks Lib "C:\Capital\SKQuoteLib.dll" (ByRef PageNo As Short, ByVal StockNos As String) As Integer
    Private Declare Function SKQuoteLib_GetStockByIndex Lib "C:\Capital\SKQuoteLib.dll" (ByVal MarketNo As Short, ByVal Index As Short, ByRef tStock As TStock) As Integer
    Friend Declare Function SKQuoteLib_GetStockByNo Lib "C:\Capital\SKQuoteLib.dll" (ByVal strStockNo$, ByRef tStock As TStock) As Integer

    Private Delegate Sub delegateOnQuote(ByVal MarketNo As Short, ByVal Index As Short)
    Private Declare Function SKQuoteLib_AttachQuoteCallBack Lib "C:\Capital\SKQuoteLib.dll" (ByVal Func As delegateOnQuote) As Integer
    Private OnQuoteCB As New delegateOnQuote(AddressOf OnQuote)

    Private Delegate Sub delegateConnection(ByVal Kind%, ByVal Code%)
    Private Declare Function SKQuoteLib_AttachConnectionCallBack Lib "C:\Capital\SKQuoteLib.dll" (ByVal Func As delegateConnection) As Integer
    Private ConnectionCB As New delegateConnection(AddressOf OnConnection)

    Private Declare Function SKOrderLib_Initialize Lib "C:\Capital\SKOrderLib.dll" (ByVal strID As String, ByVal strPass As String) As Integer
    Private Declare Function SKOrderLib_ReadCertByID Lib "C:\Capital\SKOrderLib.dll" (ByVal strID As String) As Integer
    Private Declare Function GetRealBalanceReport Lib "C:\Capital\SKOrderLib.dll" (ByVal strAccount As String) As Integer
    Private Declare Function SendStockOrder Lib "C:\Capital\SKOrderLib.dll" (ByVal strAccount$, ByVal strStockNo$, ByVal nPeriod As UShort,
                                ByVal nFlag As UShort, ByVal nBuySell As UShort, ByVal strPrice$, ByVal nQty%, ByVal strMsg$, ByRef nSize%) As Integer
    Private Declare Function SendStockOrderAsync Lib "C:\Capital\SKOrderLib.dll" (ByVal strAccount$, ByVal strStockNo$, ByVal nPeriod As UShort,
                                ByVal nFlag As UShort, ByVal nBuySell As UShort, ByVal strPrice$, ByVal nQty%) As Integer
    Private Declare Function CancelOrderBySeqNo Lib "C:\Capital\SKOrderLib.dll" (ByVal strAccount As String, ByVal strSeqNo As String, ByVal strMsg$, ByRef nSize%) As Integer
    Private Declare Function DecreaseOrderBySeqNo Lib "C:\Capital\SKOrderLib.dll" (ByVal strAccount$, ByVal strSeqNo$, ByVal intDQty%) As Integer

    Private Declare Function SKReplyLib_Initialize Lib "C:\Capital\SKReplyLib.dll" (ByVal strID As String, ByVal strPass As String) As Integer
    Private Declare Function SKReplyLib_ConnectByID Lib "C:\Capital\SKReplyLib.dll" (ByVal strID As String) As Integer
    Private Declare Function SKReplyLib_IsConnectedByID Lib "C:\Capital\SKReplyLib.dll" (ByVal strID As String) As Integer
    Private Declare Function SKReplyLib_CloseByID Lib "C:\Capital\SKReplyLib.dll" (ByVal strID As String) As Integer

    Private Delegate Sub delegateOnConnectReply(<MarshalAs(UnmanagedType.BStr)> ByVal bstrID As String, ByVal nErrorCode As Integer)
    Private Declare Function RegisterOnConnectCallBack Lib "C:\Capital\SKReplyLib.dll" (ByVal Func As delegateOnConnectReply) As Integer
    Private OnConnectReplyCB As New delegateOnConnectReply(AddressOf OnConnectReply)

    Private Declare Function RegisterOnDataCallBack Lib "C:\Capital\SKReplyLib.dll" (ByVal Func As delegateOnData) As Integer
    Private Delegate Sub delegateOnData(<MarshalAs(UnmanagedType.BStr)> ByVal bstrData$)
    Private OnDataCB As New delegateOnData(AddressOf OnData)

    Private Delegate Sub delegateOnRealBalanceReport(<MarshalAs(UnmanagedType.BStr)> ByVal bstrData As String)
    Private Declare Function RegisterOnRealBalanceReportCallBack Lib "C:\Capital\SKOrderLib.dll" (ByVal Func As delegateOnRealBalanceReport) As Integer
    Private RealBalanceReportCB As New delegateOnRealBalanceReport(AddressOf OnRealBalanceReport)
#End Region

#Region "宣告變數"
    Const strID$ = "R122455031", strPW$ = "asdfghjk", strAcc$ = "91827026236"
    Const constCostRatio! = 0   '預設交易成本倍數
    Const r! = 0.002, q! = 0    '計算選擇權理論價格與槓桿用之參數，r為殖利率，q為股利率

    Private dsTemp As New DataSet
    Private dtWarrant, dtTarget, dtReply, dtInven, dtSummary As System.Data.DataTable
    Dim dicOrderTime As New Dictionary(Of String, Date) '有下單時記錄時間，不要在短期內重複下單
    Dim lstReplyInventory As New ArrayList '回報表和庫存表的股名記錄，收到報價時用此加快查詢速度
    Dim boolConnected As Boolean = False    '連線時為True, 若未連線則每隔5秒試著重連
    Dim drInventory(-1) As DataRow  '暫記庫存回報，為處理多執行緒
    Dim boolTimSum As Boolean '開關彙總定時器，放在OnRealBalance裡使用，因為OnRealBalance不是主執行緒，不能操控Timer

#Region "資料結構"
    <StructLayout(LayoutKind.Sequential)>
    Structure TStock
        Friend Stockidx As Short       ' 系統自行定義的股票代碼
        Friend iDecimal As Short       ' 報價小數位數
        Friend TypeNo As Short         ' 類股分類
        Friend MarketNo As Byte        ' 市場代號 0x00 :上市; 0x01 :上櫃; 0x02 :期貨; 0x03 :選擇權 ; 0x04 :興櫃
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)>
        Friend StockNo As String ' 股票代號
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)>
        Friend StockName As String ' 股票名稱
        Friend Open As Integer    ' 開盤價
        Friend High As Integer    ' 最高價
        Friend Low As Integer     ' 最低價
        Friend Close As Integer   ' 成交價
        Friend TickQty As Integer ' 單量
        Friend Ref As Integer     ' 昨收、參考價
        Friend Bid As Integer     ' 買價
        Friend Bc As Integer      ' 買量
        Friend Ask As Integer     ' 賣價
        Friend Ac As Integer      ' 賣量
        Friend TBc As Integer     ' 買盤量
        Friend TAc As Integer     ' 賣盤量
        Friend FutureOI As Integer ' 期貨未平倉 OI
        Friend TQty As Integer     ' 總量
        Friend YQty As Integer     ' 昨量
        Friend Up As Integer       ' 漲停
        Friend Down As Integer     ' 跌停
    End Structure
    Structure ReplyItem
        Dim strReplyType$
        Dim strOrderType
        Dim strSeqNo$
        Dim strOrderNo$
        Dim strBuySell$
        Dim strCode$
        Dim sngPrice!
        Dim intVolume%
        Dim strError$
        Dim datChange As Date
        Dim strMsg$
        Dim strOKSeq$
        Dim strCustomID$
    End Structure

#End Region
#End Region

#Region "設定表格與工具"
    Private Sub SetTables()
        dtWarrant = dsTemp.Tables.Add("Warrant")
        WarrantTable()

        dtTarget = dsTemp.Tables.Add("Target")
        TargetTable()
        If Not dsTemp.Relations.Contains("Target2Warrant") Then
            dsTemp.Relations.Add("Target2Warrant", dtTarget.Columns("商品代碼"), dtWarrant.Columns("標的代碼"))
            dtWarrant.Columns("標的價").Expression = "IIf(權證種類='CALL',Parent(Target2Warrant).買價,Parent(Target2Warrant).賣價)"
        End If

        dtReply = dsTemp.Tables.Add("Reply")
        ReplyTable()

        dtInven = dsTemp.Tables.Add("Inventory")
        InventoryTable()

        dtSummary = dsTemp.Tables.Add("Summary")
        SummaryTable()
    End Sub
    '設定彙總資料表
    Private Sub SummaryTable()
        dtSummary.Rows.Clear()
        If dtSummary.Columns.Count = 0 Then
            dtSummary.Columns.Add("標的代碼", GetType(String))
            dtSummary.Columns.Add("標的名稱", GetType(String))
            dtSummary.Columns.Add("權證當值", GetType(Single))
            dtSummary.Columns.Add("標的當值", GetType(Single))
            dtSummary.Columns("權證當值").DefaultValue = 0
            dtSummary.Columns("標的當值").DefaultValue = 0
            dtSummary.Columns.Add("總當值", GetType(Single), "權證當值+標的當值")
            dtSummary.Constraints.Add("", dtSummary.Columns("標的代碼"), True)
        End If
    End Sub
    '設定庫存資料表
    Private Sub InventoryTable()
        dtInven.Rows.Clear()
        If dtInven.Columns.Count = 0 Then
            dtInven.Columns.Add("商品代碼", GetType(String))
            dtInven.Columns.Add("商品名稱", GetType(String))
            dtInven.Columns.Add("庫存種類", GetType(String))
            dtInven.Columns.Add("昨日庫存", GetType(Integer))
            dtInven.Columns.Add("委買賣", GetType(Integer))
            dtInven.Columns.Add("今成交", GetType(Integer))
            dtInven.Columns.Add("可用餘額", GetType(Integer))
            dtInven.Columns.Add("股價", GetType(Single))
            dtInven.Columns.Add("標的代碼")
            dtInven.Columns.Add("標的名稱")
            dtInven.Columns.Add("槓桿", GetType(Single))
            dtInven.Columns.Add("當值", GetType(Single), "股價*(昨日庫存+委買賣)*槓桿/10")
            dtInven.Constraints.Add("", New DataColumn() {dtInven.Columns("商品代碼"), dtInven.Columns("庫存種類")}, True)
            dgvInventory.DataSource = dtInven
            dgvInventory.Columns("庫存種類").Visible = False
            For Each dgvC As DataGridViewColumn In dgvInventory.Columns
                dgvC.Width = Len(dgvC.Name) * 12 + 12
            Next
        End If
    End Sub
    '設定回報資料表
    Private Sub ReplyTable()
        dtReply.Rows.Clear()
        If dtReply.Columns.Count = 0 Then
            dtReply.Columns.Add("委託時間", GetType(Date))
            dtReply.Columns.Add("買賣", GetType(String))
            dtReply.Columns.Add("單別", GetType(String))
            dtReply.Columns.Add("商品代碼", GetType(String))
            dtReply.Columns.Add("商品名稱", GetType(String))
            dtReply.Columns.Add("委託價", GetType(Single))
            dtReply.Columns.Add("委託量", GetType(Integer))
            dtReply.Columns.Add("取消量", GetType(Integer))
            dtReply.Columns.Add("成交量", GetType(Integer))
            dtReply.Columns.Add("均成價", GetType(Single))
            dtReply.Columns.Add("網路單號", GetType(String))
            dtReply.Columns.Add("書號", GetType(String))
            dtReply.Columns.Add("成交序號", GetType(String))
            dtReply.Columns.Add("股價", GetType(Single))
            dtReply.Columns("取消量").DefaultValue = 0
            dtReply.Columns("成交量").DefaultValue = 0
            dtReply.Columns("均成價").DefaultValue = 0
            dtReply.Columns("成交序號").DefaultValue = ""
            dtReply.Constraints.Add("", dtReply.Columns("書號"), True)
            dgvReply.DataSource = dtReply
            For Each dgvC As DataGridViewColumn In dgvReply.Columns
                dgvC.Width = Len(dgvC.Name) * 12 + 16
            Next
            dgvReply.Columns("委託時間").DefaultCellStyle.Format = "HH:mm:ss"
            dgvReply.Columns("網路單號").Visible = False
            dgvReply.Columns("成交序號").Visible = False
        End If
    End Sub

    '設定標的資料表
    Private Sub TargetTable()
        dtTarget.Rows.Clear()
        If dtTarget.Columns.Count = 0 Then
            dtTarget.Columns.Add("商品代碼", GetType(String))
            dtTarget.Columns.Add("商品名稱", GetType(String))
            dtTarget.Columns.Add("買價", GetType(Single))
            dtTarget.Columns.Add("買量", GetType(Integer))
            dtTarget.Columns.Add("賣價", GetType(Single))
            dtTarget.Columns.Add("賣量", GetType(Integer))
            dtTarget.Columns.Add("成交價", GetType(Single))
            dtTarget.Columns.Add("漲跌幅", GetType(Single))
            dtTarget.Columns.Add("成交量", GetType(Integer))
            dtTarget.Columns.Add("單量", GetType(Integer))
            dtTarget.Columns.Add("最高", GetType(Single))
            dtTarget.Columns.Add("最低", GetType(Single))
            dtTarget.Columns.Add("平盤價", GetType(Single))
            dtTarget.Columns("漲跌幅").Expression = "成交價/平盤價-1"
            dtTarget.Columns.Add("漲停", GetType(Single))
            dtTarget.Columns.Add("跌停", GetType(Single))
            dtTarget.Columns.Add("停止", GetType(Boolean))    '勾選則不下單此標的物之權證
            dtTarget.Constraints.Add("", dtTarget.Columns("商品代碼"), True)
            For Each dc As DataColumn In dtTarget.Columns
                If dc.DataType Is GetType(Single) OrElse dc.DataType Is GetType(Integer) Then
                    dc.DefaultValue = 0
                ElseIf dc.DataType Is GetType(Boolean) Then
                    dc.DefaultValue = False
                End If
            Next

            For Each que In (From qu In dtWarrant.AsEnumerable Select qu!標的名稱, qu!標的代碼 Distinct)
                Dim drN As DataRow = dtTarget.NewRow
                drN.Item("商品代碼") = que.標的代碼
                drN.Item("商品名稱") = que.標的名稱
                dtTarget.Rows.Add(drN)
            Next
            lstR.Items.Insert(0, dtTarget.Rows.Count & "項標的")
        End If
    End Sub

    '設定與載入權證資料表
    Private Sub WarrantTable()
        dtWarrant.Rows.Clear()
        If dtWarrant.Columns.Count = 0 Then
            dtWarrant.Columns.Add("商品代碼", GetType(String))
            dtWarrant.Columns.Add("商品名稱", GetType(String))
            dtWarrant.Columns.Add("標的代碼", GetType(String))
            dtWarrant.Columns.Add("標的名稱", GetType(String))
            dtWarrant.Columns.Add("權證種類", GetType(String))
            dtWarrant.Columns.Add("履約價", GetType(Single))
            dtWarrant.Columns.Add("比例", GetType(Single))
            dtWarrant.Columns.Add("剩餘天數", GetType(Integer))
            dtWarrant.Columns.Add("賣價", GetType(Single))
            dtWarrant.Columns.Add("賣量", GetType(Integer))
            dtWarrant.Columns.Add("買價", GetType(Single))
            dtWarrant.Columns.Add("漲停", GetType(Single))
            dtWarrant.Columns.Add("標的價", GetType(Single))
            dtWarrant.Columns.Add("內含價值", GetType(Single), "(標的價-履約價)*比例*IIf(權證種類='CALL',1,-1)")
            dtWarrant.Columns.Add("可套利值", GetType(Single), "iif(賣價=0 or 標的價=0,-100,內含價值-賣價)")
            dtWarrant.Columns.Add("預設成本", GetType(Single), "標的價*比例*0.01")
            dtWarrant.Constraints.Add("", dtWarrant.Columns("商品代碼"), True)

            ReadWarrantData()
        End If
    End Sub

    '讀取權證資料
    Private Sub ReadWarrantData()
        Dim strExclude() As String = {"加權指數", "金融保險", "電子類指"}
        Dim strCapWarr$ = My.Computer.FileSystem.CurrentDirectory & "\CapWarr.csv"
        My.Computer.Network.DownloadFile("http://iwarrant.capital.com.tw/warrants/wScreenerPull_DLoad.aspx?histv=60&days2=45&iom2=2", strCapWarr, "", "", False, 10000, True)
        Using rea As New System.IO.StreamReader(strCapWarr, System.Text.Encoding.Default)
            Do Until rea.EndOfStream
                Dim strI() As String = Split(rea.ReadLine(), ",")
                If Mid(strI(0), 1, 1) = "=" Then
                    Dim drNew As DataRow = dtWarrant.NewRow
                    drNew.Item("商品代碼") = Split(strI(0), """")(1)
                    drNew.Item("商品名稱") = strI(1)
                    drNew.Item("標的名稱") = strI(11)
                    drNew.Item("權證種類") = If(Microsoft.VisualBasic.Right(drNew.Item("商品代碼"), 1) = "P", "PUT", "CALL")
                    drNew.Item("履約價") = CSng(strI(13))
                    drNew.Item("比例") = CSng(strI(14))
                    drNew.Item("剩餘天數") = CInt(strI(15))
                    If Not dtWarrant.Rows.Contains(drNew.Item("商品代碼")) AndAlso Not strExclude.Contains(drNew.Item("標的名稱")) Then
                        dtWarrant.Rows.Add(drNew)
                    End If
                End If
            Loop
        End Using
        lstR.Items.Insert(0, dtWarrant.Rows.Count & "項權證")
        FillinCode()
    End Sub

    '填入標的代碼(因為群益權證搜尋沒有附上)
    Private Sub FillinCode()
        Dim dicCodeName As New Dictionary(Of String, String)
        Dim dicToWrite As New Dictionary(Of String, String)
        Using txtR As New System.IO.StreamReader(My.Computer.FileSystem.CurrentDirectory & "\Target0.txt")
            Do Until txtR.EndOfStream
                Dim strI() As String = Split(txtR.ReadLine, ",")
                Dim strToWrite$ = ""
                For i% = 1 To strI.Count - 1
                    dicCodeName.Add(strI(i), strI(0))
                    strToWrite &= "," & strI(i)
                Next
                dicToWrite.Add(strI(0), Mid(strToWrite, 2))
            Loop
        End Using

        For Each dr As DataRow In dtWarrant.Rows
            If dicCodeName.ContainsKey(dr.Item("標的名稱")) Then
                dr.Item("標的代碼") = dicCodeName(dr.Item("標的名稱"))
            Else
                Dim strCode$ = InputBox("請問「" & dr.Item("標的名稱") & "」的代碼是？")
                dicCodeName.Add(dr.Item("標的名稱"), strCode)
                dr.Item("標的代碼") = strCode
                If dicToWrite.ContainsKey(strCode) Then
                    dicToWrite(strCode) &= "," & dr.Item("標的名稱")
                Else
                    dicToWrite.Add(strCode, dr.Item("標的名稱"))
                End If
            End If
        Next

        Dim txtW As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(My.Computer.FileSystem.CurrentDirectory & "\Target0.txt", False)
        For Each strK$ In dicToWrite.Keys
            txtW.WriteLine(strK & "," & dicToWrite(strK))
        Next
        txtW.Close()
    End Sub
#End Region

#Region "呼叫報價"
    '初始化報價函式
    Private Sub QuoteInitiate()
        Dim rt% = SKQuoteLib_Initialize(strID, strPW)
        rt += SKQuoteLib_AttachConnectionCallBack(ConnectionCB)
        rt += SKQuoteLib_AttachQuoteCallBack(OnQuoteCB)
        rt += SKQuoteLib_EnterMonitor
        If rt <> 0 AndAlso rt <> 2003 Then
            lstR.Items.Insert(0, Format(Now, "HH:mm:ss") & (" 報價連結失敗"))
        Else
            lstR.Items.Insert(0, Format(Now, "HH:mm:ss") & (" 報價連結成功"))
        End If
    End Sub

    '回傳報價連結函式
    Private Sub OnConnection(ByVal intKind%, ByVal intCode%)
        If intKind = 100 AndAlso intCode = 0 Then
            boolConnected = True
            RequestQuote()
        Else
            boolConnected = False
            lstR.Items.Insert(0, Format(Now, "HH:mm:ss ") & "報價連結失敗")
            cbxStopOrder.Checked = True
        End If
    End Sub

    '呼叫個股(權證與標的)報價
    Private Sub RequestQuote()
        For i% = 1 To 49
            SKQuoteLib_RequestStocks(i, "2330")
            delay(50)
        Next

        For i% = 0 To Int((dtTarget.Rows.Count + dtWarrant.Rows.Count - 1) / 100)
            Dim x$ = ""
            For j% = 0 To Math.Min(99, dtTarget.Rows.Count + dtWarrant.Rows.Count - 1 - i * 100)
                If i * 100 + j < dtTarget.Rows.Count Then
                    x &= "," & dtTarget.Rows(i * 100 + j).Item("商品代碼")
                Else
                    x &= "," & dtWarrant.Rows(i * 100 + j - dtTarget.Rows.Count).Item("商品代碼")
                End If
            Next
            x = Mid(x, 2)

            Dim rt% = SKQuoteLib_RequestStocks(i + 1, x)
            If rt = 0 Then
                delay(100)
            Else
                lstR.Items.Insert(0, "Request Error. rt = " & rt & ", PageNo = " & i + 1)
            End If
        Next

        lstR.Items.Insert(0, Format(Now, "HH:mm:ss") & " RequestQuote Done")
    End Sub

    '回傳報價處理函式
    Private Sub OnQuote(ByVal shtMarketNo As Short, ByVal shtIndex As Short)
        Dim tsTemp As TStock = Nothing
        SKQuoteLib_GetStockByIndex(shtMarketNo, shtIndex, tsTemp)
        Dim strCode As String = Trim(tsTemp.StockNo)

        If dtTarget.Rows.Contains(strCode) Then
            QuoteTarget(tsTemp)
        Else
            If dtWarrant.Rows.Contains(strCode) Then
                QuoteWarrant(tsTemp)
            End If
        End If

        If lstReplyInventory.Contains(strCode) Then
            QuoteReplyInventory(tsTemp)
        End If
    End Sub

    '標的報價處理
    Private Sub QuoteTarget(ByVal tsTemp As TStock)
        Dim strCode As String = Trim(tsTemp.StockNo)
        Dim drT As DataRow = dtTarget.Rows.Find(strCode)
        If Not drT Is Nothing Then
            Dim intDivider% = 10 ^ tsTemp.iDecimal
            drT.Item("買價") = tsTemp.Bid / intDivider
            drT.Item("買量") = tsTemp.Bc
            drT.Item("賣價") = tsTemp.Ask / intDivider
            drT.Item("賣量") = tsTemp.Ac
            drT.Item("成交價") = tsTemp.Close / intDivider
            drT.Item("成交量") = tsTemp.TQty
            drT.Item("單量") = tsTemp.TickQty
            drT.Item("最高") = tsTemp.High / intDivider
            drT.Item("最低") = tsTemp.Low / intDivider
            drT.Item("平盤價") = tsTemp.Ref / intDivider
            drT.Item("漲停") = tsTemp.Up / intDivider
            drT.Item("跌停") = tsTemp.Down / intDivider
            For Each drW As DataRow In drT.GetChildRows("Target2Warrant")
                If Not IsDBNull(drW.Item("可套利值")) AndAlso drW.Item("可套利值") > 0 AndAlso drT.Item("成交量") > 0 Then
                    If Not (drT.Item("成交價") = drT.Item("跌停") AndAlso drW.Item("權證種類") = "CALL" OrElse
                        drT.Item("成交價") = drT.Item("漲停") AndAlso drW.Item("權證種類") = "PUT") Then
                        Arbitragible(drW)
                    End If
                End If
            Next
        End If
    End Sub

    '權證報價處理
    Private Sub QuoteWarrant(ByVal tsTemp As TStock)
        Dim strcode As String = Trim(tsTemp.StockNo)
        Dim drW As DataRow = dtWarrant.Rows.Find(strcode)
        If Not drW Is Nothing Then
            Dim intDivider% = 10 ^ tsTemp.iDecimal
            drW.Item("賣價") = tsTemp.Ask / intDivider
            drW.Item("賣量") = tsTemp.Ac
            drW.Item("買價") = tsTemp.Bid / intDivider
            drW.Item("漲停") = tsTemp.Up / intDivider
            If Not IsDBNull(drW.Item("可套利值")) AndAlso drW.Item("可套利值") > 0 Then
                Dim drT As DataRow = drW.GetParentRow("Target2Warrant")
                If drT.Item("成交量") > 0 AndAlso Not (drT.Item("成交價") = drT.Item("跌停") AndAlso drW.Item("權證種類") = "CALL" OrElse
                drT.Item("成交價") = drT.Item("漲停") AndAlso drW.Item("權證種類") = "PUT") Then Arbitragible(drW)
            End If
        End If
    End Sub

    '把報價資訊應用到"回報表"和"庫存表"
    Private Sub QuoteReplyInventory(ByVal tsTemp As TStock)
        Dim strCode As String = Trim(tsTemp.StockNo)
        Dim intDivider% = 10 ^ tsTemp.iDecimal

        For Each drR As DataRow In dtReply.Rows
            If drR.Item("商品代碼") = strCode Then
                drR.Item("股價") = If(drR.Item("買賣") = "B", tsTemp.Ask, tsTemp.Bid) / intDivider
            End If
        Next

        For Each drI As DataRow In dtInven.Rows
            If drI.Item("商品代碼") = strCode Then
                drI.Item("股價") = If(drI.Item("庫存種類") = "融券", tsTemp.Ask, tsTemp.Bid) / intDivider
                Dim drW As DataRow = dtWarrant.Rows.Find(strCode)
                If Not drW Is Nothing Then
                    Dim sngTargetPrice! = dtTarget.Rows.Find(drW.Item("標的代碼")).Item("成交價")
                    drI.Item("股價") = If(drI.Item("股價") > 0, drI.Item("股價"), ExpectedP(drW.Item("履約價"), sngTargetPrice, drW.Item("隱含波動率"),
                                                                      drW.Item("剩餘天數") / 365, drW.Item("權證種類") = "CALL") * drW.Item("比例"))
                    drI.Item("槓桿") = hDelta(drW.Item("履約價"), sngTargetPrice, drW.Item("隱含波動率"), drW.Item("剩餘天數") / 365,
                                               drW.Item("權證種類") = "CALL") * drW.Item("比例") * sngTargetPrice / drI.Item("股價")
                End If
            End If
        Next
    End Sub
#End Region

#Region "建立庫存整理資料"
    '呼叫庫存回報
    Private Sub GetInventory()
        If Not timSum.Enabled Then
            Dim rt% = GetRealBalanceReport(strAcc)
            If rt = 0 Then
                timInv.Stop()
                timSum.Start()
                ReDim drInventory(-1)
            Else
                lstR.Items.Insert(0, "呼叫庫存回報失敗：" & rt)
            End If
        End If
    End Sub

    '收取庫存回報並準備加以整理
    Private Sub OnRealBalanceReport(<MarshalAs(UnmanagedType.BStr)> ByVal bstrData As String)
        Dim strData$ = CStr(bstrData)
        If Len(strData) > 10 AndAlso Mid(strData, 2, 1) <> "#" Then
            Dim strDataSplit() As String = Split(strData, ",")
            ReDim Preserve drInventory(drInventory.Count)
            drInventory(drInventory.Count - 1) = dtInven.NewRow
            With drInventory(drInventory.Count - 1)
                .Item("商品代碼") = Mid(Trim(strDataSplit(0)), 2, 6)
                .Item("庫存種類") = If(Trim(strDataSplit(1)) = "T", "現股", If(Trim(strDataSplit(1)) = "C", "融資", "融券"))
                .Item("昨日庫存") = CInt(strDataSplit(6)) / 1000
                .Item("委買賣") = CInt(strDataSplit(7)) / 1000 - CInt(strDataSplit(8)) / 1000
                .Item("今成交") = CInt(strDataSplit(9)) / 1000 - CInt(strDataSplit(10)) / 1000
                .Item("可用餘額") = CInt(strDataSplit(11)) / 1000
                .Item("股價") = 0
                Dim drW As DataRow = dtWarrant.Rows.Find(.Item("商品代碼"))
                If drW Is Nothing Then
                    Dim drT As DataRow = dtTarget.Rows.Find(.Item("商品代碼"))
                    If Not drT Is Nothing Then .Item("商品名稱") = drT.Item("商品名稱")
                    .Item("標的代碼") = .Item("商品代碼")
                    .Item("標的名稱") = .Item("商品名稱")
                    .Item("槓桿") = If(.Item("庫存種類") = "融券", -1, 1)
                Else
                    .Item("商品名稱") = drW.Item("商品名稱")
                    .Item("標的代碼") = drW.Item("標的代碼")
                    .Item("標的名稱") = drW.Item("標的名稱")
                    If Not IsDBNull(drW.Item("買價")) AndAlso Not IsDBNull(drW.Item("賣價")) Then
                        .Item("槓桿") = If(drW.Item("權證種類") = "CALL", 1, -1) * drW.Item("比例") * drW.Item("標的價") /
                        Math.Max(drW.Item("買價"), Math.Max(drW.Item("賣價"), 0.01))
                    End If
                End If
            End With
        ElseIf Mid(bstrData, 2, 1) = "#" Then
            boolTimSum = True
        End If
    End Sub

    '整理庫存和回報資料
    Private Sub ReplyInvenSummary()
        dtInven.Rows.Clear()
        For Each dr As DataRow In drInventory
            If Not dtInven.Rows.Contains(New Object() {dr.Item("商品代碼"), dr.Item("庫存種類")}) Then dtInven.Rows.Add(dr)
        Next

        NewRequestQuote() '如果有未報價的個股，要重呼報價

        Dim tsTemp As New TStock
        For Each strStockNo$ In lstReplyInventory
            SKQuoteLib_GetStockByNo(strStockNo, tsTemp)
            QuoteReplyInventory(tsTemp)
        Next
        delay(1000) '等待回補報價

        Sum() '重建彙總表格dtSummary
        SetInvenColor() '把即將到期的權證變色提醒
    End Sub

    '重查"回報表"與"庫存表"，如果有新增個股，應先呼叫報價
    Private Sub NewRequestQuote()
        Dim boolNeedNewRequest As Boolean = False
        For Each drR As DataRow In dtReply.Rows
            If Not lstReplyInventory.Contains(drR.Item("商品代碼")) Then
                lstReplyInventory.Add(drR.Item("商品代碼"))
                boolNeedNewRequest = True
            End If
        Next
        For Each drI As DataRow In dtInven.Rows
            If Not lstReplyInventory.Contains(drI.Item("商品代碼")) Then
                lstReplyInventory.Add(drI.Item("商品代碼"))
                boolNeedNewRequest = True
            End If
        Next

        If boolNeedNewRequest Then
            Dim shtStartPageNo As Short = Int((dtTarget.Rows.Count + dtWarrant.Rows.Count - 1) / 100) + 2
            For i% = 0 To Int((lstReplyInventory.Count - 1) / 100)
                Dim x$ = ""
                For j% = 0 To Math.Min(99, lstReplyInventory.Count - 1 - i * 100)
                    x &= "," & lstReplyInventory(i * 100 + j)
                Next
                x = Mid(x, 2)
                SKQuoteLib_RequestStocks(shtStartPageNo + i, x)
                delay(100)
            Next
        End If
    End Sub

    '重建彙總表格dtSummary
    Private Sub Sum()
        dtSummary.Rows.Clear()
        For Each que In (From qu In dtInven.AsEnumerable Select qu!標的名稱, qu!標的代碼 Distinct)
            Dim drS As DataRow = dtSummary.NewRow
            drS.Item("標的代碼") = que.標的代碼
            drS.Item("標的名稱") = que.標的名稱
            drS.Item("權證當值") = ChangeNull(dtInven.Compute("Sum(當值)", "標的代碼<>商品代碼 and 標的代碼='" & drS.Item("標的代碼") & "'"), 0)
            drS.Item("標的當值") = ChangeNull(dtInven.Compute("Sum(當值)", "標的代碼=商品代碼 and 標的代碼='" & drS.Item("標的代碼") & "'"), 0)
            dtSummary.Rows.Add(drS)
        Next
    End Sub

    '把即將到期的權證變色提醒
    Private Sub SetInvenColor()
        For Each dgvR As DataGridViewRow In dgvInventory.Rows
            Dim drW As DataRow = dtWarrant.Rows.Find(dgvR.Cells("商品代碼").Value)
            If Not drW Is Nothing Then
                If drW.Item("剩餘天數") <= 5 Then
                    dgvR.DefaultCellStyle.BackColor = Color.LightPink
                End If
            End If
        Next
    End Sub
#End Region

#Region "套利下單， 判斷與執行"
    '初始化下單函式
    Private Sub OrderInitiate()
        Dim rt% = SKOrderLib_Initialize(strID, strPW)
        rt += SKOrderLib_ReadCertByID(strID)
        If rt = 0 OrElse rt = 2003 Then
            RegisterOnRealBalanceReportCallBack(RealBalanceReportCB)
        Else
            lstR.Items.Insert(0, "下單初始化失敗")
        End If
    End Sub
    '判斷可否套利
    Private Sub Arbitragible(ByVal drW As DataRow)
        If Not dtTarget.Rows.Find(drW.Item("標的代碼")).Item("停止") Then
            If Not dicOrderTime.ContainsKey(drW.Item("商品代碼")) OrElse TimeOfDay.Subtract(dicOrderTime(drW.Item("商品代碼"))).TotalSeconds > 10 Then
                If drW.Item("可套利值") > drW.Item("預設成本") * constCostRatio AndAlso TimeOfDay < #1:25:00 PM# Then
                    Dim intVol% = Math.Min(CInt(CDbl(tbxM.Text)) * 10 / drW.Item("賣價"), drW.Item("賣量"))
                    If intVol > 0 Then
                        Dim intMultiplier% = If(drW.Item("內含價值") < 5, 100, If(drW.Item("內含價值") < 10, 20, 10))
                        Dim sngPrice! = drW.Item("賣價") 'Math.Min(drW.Item("漲停"), Int(drTmpRec.Item("內含價值") * intMultiplier) / intMultiplier)
                        Order(drW.Item("商品代碼"), 0, 0, Format(sngPrice, "0.##"), intVol)
                        dicOrderTime.Add(drW.Item("商品代碼"), TimeOfDay)
                        Dim sngAdded! = intVol * drW.Item("比例") * drW.Item("標的價")
                    End If

                    tbxM.Text = Format(CDbl(tbxM.Text) - drW.Item("賣價") * intVol / 10, "0.#")
                End If
            End If
        End If
    End Sub

    '處理下單動作
    Private Sub Order(ByVal strCode$, ByVal usFlag As UShort, ByVal usBuySell As UShort, ByVal strPrice$, ByVal intQty%)
        Dim rt%
        If cbxStopOrder.Checked Then
            rt = -100
            lstR.Items.Insert(0, Format(Now, "HH:mm:ss ") & If(usBuySell = 0, "Buy ", "Sell ") & strCode & " 價位: " & strPrice & ", " & intQty & "張")
        Else
            rt = SendStockOrderAsync(strAcc, strCode, 0, usFlag, usBuySell, strPrice, intQty)
        End If
        If rt <> 0 Then
            lstR.Items.Insert(0, Format(Now, "HH: mm:ss ") & If(usBuySell = 0, "Buy ", "Sell ") & strCode & " 價位: " & strPrice & ", " & intQty & "張, 錯誤" & rt)
        End If
    End Sub

#End Region

#Region "收取回報和追蹤執行動作"
    '初始化回報函式
    Private Sub ReplyInitiate()
        Dim rt% = SKReplyLib_Initialize(strID, strPW)
        delay(100)
        rt = RegisterOnConnectCallBack(OnConnectReplyCB)
        delay(100)
        rt = RegisterOnDataCallBack(OnDataCB)
        delay(500)
        rt = SKReplyLib_ConnectByID(strID)
    End Sub

    '收取回報連結函式
    Private Sub OnConnectReply(<MarshalAs(UnmanagedType.BStr)> ByVal bstrID As String, ByVal nErrorCode As Integer)
        If nErrorCode = 0 Then
            timInv.Start()
        Else
            lstR.Items.Insert(0, Format(Now, "HH:mm:ss ") & "回報連結錯誤")
            cbxStopOrder.Checked = True
        End If
    End Sub

    '收取回報資料
    Private Sub OnData(<MarshalAs(UnmanagedType.BStr)> ByVal bstrData$)
        If Mid(bstrData, 14, 2) = "TS" AndAlso Mid(bstrData, 25, 7) = Microsoft.VisualBasic.Right(strAcc, 7) Then
            Dim riNew As ReplyItem = RI(bstrData)
            Select Case riNew.strReplyType
                Case "N"
                    AddReplyRow(riNew)
                Case "C", "D", "U"
                    Dim drR As DataRow = dtReply.Rows.Find(riNew.strOrderNo)
                    If Not drR Is Nothing Then
                        AlterReplyRow(drR, riNew)
                    End If
                Case Else
                    lstR.Items.Insert(0, Format(Now, "HH:mm:ss") & " 奇怪的回報種類：" & riNew.strReplyType)
            End Select
        End If

        timInv.Stop() : timInv.Start()
    End Sub

    '把回報字串轉換為ReplyItem
    Private Function RI(<MarshalAs(UnmanagedType.BStr)> ByVal bstrData$) As ReplyItem
        Dim riNew As New ReplyItem
        riNew.datChange = CDate(Mid(bstrData, 170, 2) & ":" & Mid(bstrData, 172, 2) & ":" & Mid(bstrData, 174, 2))
        riNew.intVolume = CInt(Mid(bstrData, 146, 8))
        riNew.sngPrice = CInt(Mid(bstrData, 80, 13)) / 100
        riNew.strBuySell = Mid(bstrData, 32, 1)
        riNew.strCode = Trim(Mid(bstrData, 42, 20))
        riNew.strError = Mid(bstrData, 17, 1)
        riNew.strOrderNo = Mid(bstrData, 75, 5)
        riNew.strOrderType = Mid(bstrData, 33, 2)
        riNew.strReplyType = Mid(bstrData, 16, 1)
        riNew.strSeqNo = Mid(bstrData, 1, 13)
        riNew.strOKSeq = Mid(bstrData, 176, 8)
        riNew.strCustomID = Mid(bstrData, 25, 7)
        Return riNew
    End Function

    '新增回報資料行
    Private Sub AddReplyRow(ByVal ri As ReplyItem)
        Static intWrong% = 1
        Dim drR As DataRow = dtReply.NewRow
        drR.Item("委託時間") = ri.datChange
        drR.Item("買賣") = ri.strBuySell
        drR.Item("單別") = If(ri.strOrderType = "00", "現股", If(ri.strOrderType = "03", "融資", If(ri.strOrderType = "04", "融券", "不明")))
        drR.Item("商品代碼") = ri.strCode
        Dim drT As DataRow = dtTarget.Rows.Find(ri.strCode)
        If drT IsNot Nothing Then
            drR.Item("商品名稱") = drT.Item("商品名稱")
        Else
            Dim drW As DataRow = dtWarrant.Rows.Find(ri.strCode)
            If Not drW Is Nothing Then
                drR.Item("商品名稱") = drW.Item("商品名稱")
            End If
        End If
        drR.Item("委託價") = ri.sngPrice
        drR.Item("委託量") = ri.intVolume
        drR.Item("取消量") = 0
        drR.Item("成交量") = 0
        drR.Item("網路單號") = ri.strSeqNo
        If ri.strError = "N" Then
            drR.Item("書號") = ri.strOrderNo
        Else
            Do While dtReply.Rows.Contains("錯單_" & intWrong)
                intWrong += 1
            Loop
            drR.Item("書號") = "錯單_" & intWrong
        End If
        If Not dtReply.Rows.Contains(ri.strOrderNo) Then dtReply.Rows.Add(drR)
    End Sub

    '更新回報資料行
    Private Sub AlterReplyRow(ByRef drR As DataRow, ByVal ri As ReplyItem)
        Select Case ri.strReplyType
            Case "C", "U"
                If ri.strError = "N" Then drR.Item("取消量") += ri.intVolume
            Case "D"
                If Not Split(drR.Item("成交序號"), ",").Contains(ri.strOKSeq) Then
                    drR.Item("均成價") = Math.Round((drR.Item("成交量") * drR.Item("均成價") + ri.sngPrice * ri.intVolume) /
                            (drR.Item("成交量") + ri.intVolume), 4)
                    drR.Item("成交量") += ri.intVolume
                    drR.Item("成交序號") = If(drR.Item("成交序號") = "", ri.strOKSeq, drR.Item("成交序號") & "," & ri.strOKSeq)
                End If
        End Select
    End Sub
#End Region

#Region "計算選擇權參數"
    '累加常態分配函數
    Private Function CND(ByVal z As Double) As Double
        Dim t As Double = 1 / (1 + 0.2316419 * Math.Abs(z))
        Dim t1 As Double = 1 - 1 / Math.Sqrt(2 * Math.PI) * Math.Exp(-z * z / 2) *
            t * (0.31938153 + t * (-0.356563782 + t * (1.781477937 + t * (-1.821255978 + t * 1.330274429))))
        If z < 0 Then
            Return 1 - t1
        Else
            Return t1
        End If
    End Function

    '常態分配密度函數
    Friend Function CNDD(ByVal z As Double) As Double
        Return Math.Exp(-z * z / 2) / 2.506628274631
    End Function

    '牛頓法求隱含波動率
    Function ImpliedV(ByVal x#, ByVal s#, ByVal p#, ByVal t#, ByVal IsCall As Boolean) As Double
        Dim defaultV# = 0.0001
        If s * p <> 0 Then
            Dim TempV# = 0, RefV# = 0.2, SlopeY# = 0, V0# = 0, RoundFlag% = 0, DiffV# = 10
            Do
                If RoundFlag > 1 Then DiffV = Math.Abs(TempV - RefV)
                TempV = RefV
                V0 = ExpectedP(x, s, RefV, t, IsCall)
                SlopeY = (ExpectedP(x, s, RefV + 0.00001, t, IsCall) - V0) / 0.00001
                If SlopeY <> 0 Then RefV = RefV - (V0 - p) / SlopeY
                RoundFlag += 1
            Loop Until RoundFlag > 10 OrElse Math.Abs(RefV - TempV) < 0.00001 OrElse Math.Abs(RefV - TempV) > DiffV

            If RoundFlag > 10 Or Math.Abs(ExpectedP(x, s, RefV, t, IsCall) / p) - 1 > 0.01 Then
                Return defaultV
            Else
                Return RefV
            End If
        Else
            Return defaultV
        End If
    End Function

    '求理論價格
    Function ExpectedP(ByVal x#, ByVal s#, ByVal iv#, ByVal t#, ByVal IsCall As Boolean) As Double
        Dim d1# = (Math.Log(s / x) + (r - q + iv * iv / 2) * t) / iv / Math.Sqrt(t)
        Dim d2# = d1 - iv * Math.Sqrt(t)
        If IsCall Then
            Return Math.Exp(-q * t) * s * CND(d1) - Math.Exp(-r * t) * x * CND(d2)
        Else
            Return Math.Exp(-r * t) * x * CND(-d2) - Math.Exp(-q * t) * s * CND(-d1)
        End If
    End Function

    '求理論槓桿
    Private Function hDelta(ByVal x#, ByVal s#, ByVal iv#, ByVal t#, ByVal IsCall As Boolean) As Single
        Dim d1# = (Math.Log(s / x) + (r + iv * iv / 2) * t) / iv / Math.Sqrt(t)
        Return If(IsCall, Math.Exp(-q * t) * CND(d1), Math.Exp(-q * t) * (CND(d1) - 1))
    End Function

#End Region

#Region "常用函式"
    '延遲(單位微秒)
    Private Sub delay(ByVal intDelay%)
        Dim start As Date = Now
        Do While Now.Subtract(start).TotalMilliseconds < intDelay
            My.Application.DoEvents()
        Loop
    End Sub

    '替代空資料
    Friend Function ChangeNull(ByVal a, ByVal b)
        Return If(IsDBNull(a), b, a)
    End Function

    '顯示表格
    Private Sub ShowTable(ByVal dt As System.Data.DataTable)
        Dim fom As New Form
        Dim dgv As New DataGridView
        dgv.Dock = DockStyle.Fill
        dgv.DataSource = dt
        dgv.RowTemplate.Resizable = DataGridViewTriState.False
        dgv.RowTemplate.Height = 18

        fom.Controls.Add(dgv)
        fom.Show()
        fom.Text = dt.TableName
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        For Each dgvC As DataGridViewColumn In dgv.Columns
            dgvC.Width = Len(dgvC.Name) * 12 + 12
        Next
        fom.Width = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 76
        dgv.AllowUserToAddRows = False
        dgv.EditMode = DataGridViewEditMode.EditProgrammatically
        AddHandler dgv.ColumnHeaderMouseClick, AddressOf dgv_ColumnHeaderMouseClick
        AddHandler dgv.Sorted, AddressOf dgv_Sorted
    End Sub

    '排序好不要再跳來跳去
    Private Sub dgv_Sorted(sender As Object, e As EventArgs)
        CType(sender, DataGridView).SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    '按鍵之後打開排序功能
    Private Sub dgv_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Static boolAscending = False
        Dim dgv As DataGridView = CType(sender, DataGridView)
        dgv.Sort(dgv.Columns(e.ColumnIndex), If(boolAscending, System.ComponentModel.ListSortDirection.Ascending, System.ComponentModel.ListSortDirection.Descending))
        boolAscending = Not boolAscending
    End Sub

#End Region

    '一切開始的地方
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetTables()
        OrderInitiate()
        ReplyInitiate()
        QuoteInitiate()
    End Sub

    '主要時間處理器
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '交易時間內處理
        If TimeOfDay < #1:29:00 PM# AndAlso TimeOfDay > #8:59:00# AndAlso Weekday(Now) <> 1 AndAlso Weekday(Now) <> 7 Then
            If Second(Now) Mod 20 = 0 Then
                If Not boolConnected Then
                    Form1_Load(sender, e)        '如果沒有成功連線，每20秒再重建一次
                ElseIf Not cbxStopCancel.Checked Then '每隔20秒刪掉未成交的單子
                    For Each drR As DataRow In dtReply.Rows
                        If drR.Item("委託量") > drR.Item("取消量") + drR.Item("成交量") Then
                            Dim strMsg$ = "", nSize% = 100
                            CancelOrderBySeqNo(strAcc, drR.Item("網路單號"), strMsg, nSize)
                        End If
                    Next
                End If
            End If
            '每分鐘彙總一下庫存，以防回報資料遺失
            If Second(Now) Mod 60 = 15 Then
                Sum()
            End If
        End If

        tbxTime.Text = Format(Now, "HH:mm:ss")
    End Sub

    '呼叫庫存定時器
    Private Sub timInv_Tick(sender As Object, e As EventArgs) Handles timInv.Tick
        GetInventory()
    End Sub

    '呼叫彙總定時器
    Private Sub timSum_Tick(sender As Object, e As EventArgs) Handles timSum.Tick
        If boolTimSum Then
            timSum.Stop()
            ReplyInvenSummary()
        End If
    End Sub

    '顯示權證表
    Private Sub btnWarrant_Click(sender As Object, e As EventArgs) Handles btnWarrant.Click
        ShowTable(dtWarrant)
    End Sub

    '顯示標的表
    Private Sub btnTarget_Click(sender As Object, e As EventArgs) Handles btnTarget.Click
        ShowTable(dtTarget)
    End Sub

    '顯示彙總表
    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        ShowTable(dtSummary)
    End Sub

    '測試鍵
    Private Sub btnTEST_Click(sender As Object, e As EventArgs) Handles btnTEST.Click
        ShowTable(dtWarrant)
    End Sub
End Class