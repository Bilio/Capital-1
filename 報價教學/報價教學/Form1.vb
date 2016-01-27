Imports System.Runtime.InteropServices
Public Class Form1
#Region "宣告函式"
    Private Declare Function SKQuoteLib_Initialize Lib "C:\Capital\SKQuoteLib.dll" (ByVal ID As String, ByVal Password As String) As Integer
    Private Declare Function SKQuoteLib_EnterMonitor Lib "C:\Capital\SKQuoteLib.dll" () As Integer
    Private Declare Function SKQuoteLib_LeaveMonitor Lib "C:\Capital\SKQuoteLib.dll" () As Integer
    Friend Declare Function SKQuoteLib_RequestStocks Lib "C:\Capital\SKQuoteLib.dll" (ByRef PageNo As Short, ByVal StockNos As String) As Integer
    Private Declare Function SKQuoteLib_RequestTicks Lib "C:\Capital\SKQuoteLib.dll" (ByRef PageNo As Short, ByVal StockNos As String) As Integer
    Private Declare Function SKQuoteLib_GetStockByIndex Lib "C:\Capital\SKQuoteLib.dll" (ByVal MarketNo As Short, ByVal Index As Short, ByRef tStock As TStock) As Integer
    Private Declare Function SKQuoteLib_GetTick Lib "C:\Capital\SKQuoteLib.dll" (ByVal MarketNo As Short, ByVal Index As Short, ByVal Ptr As Integer, ByRef tTick As TTick) As Integer

    Private Delegate Sub delegateOnQuote(ByVal MarketNo As Short, ByVal Index As Short)
    Private Declare Function SKQuoteLib_AttachQuoteCallBack Lib "C:\Capital\SKQuoteLib.dll" (ByVal Func As delegateOnQuote) As Integer
    Private OnQuoteCB As New delegateOnQuote(AddressOf OnQuote)

    Private Delegate Sub delegateOnConnection(ByVal Kind%, ByVal Code%)
    Private Declare Function SKQuoteLib_AttachConnectionCallBack Lib "C:\Capital\SKQuoteLib.dll" (ByVal Func As delegateOnConnection) As Integer
    Private ConnectionCB As New delegateOnConnection(AddressOf OnConnection)

    Private Delegate Sub delegateOnTicks(ByVal MarketNo As Short, ByVal Stockidx As Short, ByVal Ptr%, ByVal tTime%, ByVal Bid%, ByVal Ask%, ByVal Close%, ByVal Qty%)
    Private Declare Function SKQuoteLib_AttachTicksGetCallBack Lib "C:\Capital\SKQuoteLib.dll" (ByVal Func As delegateOnTicks) As Integer
    Private OnTicksCB As New delegateOnTicks(AddressOf OnTicks)
#End Region

#Region "宣告變數"
    Dim dtQuote, dtTicks As New DataTable
    Dim strID$ = "R220088490", strPW$ = "hmc94065"
    Dim arrTWSE, arrOTC, arrStockNo As New ArrayList
    Dim datLastTrading As Date
    Dim boolConnected As Boolean = False
    Dim datGetTicks As Date = #14:00:00#
    <StructLayout(LayoutKind.Sequential)>
    Structure TStock
        Friend Stockidx As Short       ' 系統自行定義的股票代碼
        Friend iDecimal As Short       ' 報價小數位數
        Friend TypeNo As Short         ' 類股分類
        Friend MarketNo As Byte        ' 市場代號 0x00 :上市; 0x01 :上櫃; 0x02 :期貨; 0x03 :選擇權 ; 0x04 :興櫃
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)>
        Friend StockNo As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)>
        Friend StockName As String
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

    <StructLayout(LayoutKind.Sequential)>
    Structure TTick
        Friend Ptr%
        Friend tTime%
        Friend Bid%
        Friend Ask%
        Friend Close%
        Friend Qty%
    End Structure
#End Region

#Region "設定表格與初始參數"
    '設定報價表
    Private Sub QuoteTable()
        If dtQuote.Columns.Count = 0 Then
            dtQuote.Columns.Add("StockNo")
            dtQuote.Columns.Add("Name")
            dtQuote.Columns.Add("Open", GetType(Single))
            dtQuote.Columns.Add("High", GetType(Single))
            dtQuote.Columns.Add("Low", GetType(Single))
            dtQuote.Columns.Add("Close", GetType(Single))
            dtQuote.Columns.Add("Volume", GetType(Integer))
            dtQuote.Constraints.Add("", dtQuote.Columns("StockNo"), True)
        End If
        dtQuote.Rows.Clear()
    End Sub

    '設定成交明細表
    Private Sub TickTable()
        If dtTicks.Columns.Count = 0 Then
            dtTicks.Columns.Add("Time", GetType(Date))
            dtTicks.Columns.Add("Bid", GetType(Single))
            dtTicks.Columns.Add("Ask", GetType(Single))
            dtTicks.Columns.Add("Close", GetType(Single))
            dtTicks.Columns.Add("Qty", GetType(Integer))
            dtTicks.Constraints.Add("", dtTicks.Columns("Time"), True)
        End If
        dtTicks.Rows.Clear()
    End Sub

    '填上市櫃股票代碼
    Private Sub FillinStockNo()
        '讀上市股票代碼
        arrTWSE.Clear()
        Using rea As New System.IO.StreamReader("C:\Capital\TWSE.txt")
            Do Until rea.EndOfStream
                arrTWSE.Add(rea.ReadLine)
            Loop
        End Using
        '讀上櫃股票代碼
        arrOTC.Clear()
        Using rea As New System.IO.StreamReader("C:\Capital\OTC.txt")
            Do Until rea.EndOfStream
                arrOTC.Add(rea.ReadLine)
            Loop
        End Using
    End Sub

    '設定輸出檔名，先找最後一個交易日
    Private Sub OutputFilesSetting()
        FindLastTradingDay()
        tbxQuote.Text = "C:\Capital\Quote\" & Format(datLastTrading, "yyyyMMdd") & If(cbxTWSE.Checked, "_市", "") & If(cbxOTC.Checked, "_櫃", "") & ".txt"
        tbxTicks.Text = "C:\Capital\Ticks\" & Format(datLastTrading, "yyyyMMdd")
        If Not My.Computer.FileSystem.DirectoryExists("C:\Capital\Quote") Then
            My.Computer.FileSystem.CreateDirectory("C:\Capital\Quote")
        End If
        If Not My.Computer.FileSystem.DirectoryExists(tbxTicks.Text) Then
            My.Computer.FileSystem.CreateDirectory(tbxTicks.Text)
        End If
    End Sub

    '尋找最近一個交易日
    Private Sub FindLastTradingDay()
        Dim arrHoliday As New ArrayList
        datLastTrading = Today
        Using rea As New System.IO.StreamReader("C:\Capital\Holidays.txt")
            Do Until rea.EndOfStream
                arrHoliday.Add(CDate(rea.ReadLine))
            Loop
        End Using
        Do While arrHoliday.Contains(datLastTrading)
            datLastTrading = datLastTrading.AddDays(-1)
        Loop
    End Sub
#End Region

#Region "呼叫報價並接收回傳"
    '連結報價
    Private Sub ConnectingQuote()
        Dim rt% = 0
        rt = SKQuoteLib_Initialize(strID, strPW)
        rt += SKQuoteLib_AttachConnectionCallBack(ConnectionCB)
        rt += SKQuoteLib_AttachQuoteCallBack(OnQuoteCB)
        rt += SKQuoteLib_AttachTicksGetCallBack(OnTicksCB)
        rt += SKQuoteLib_EnterMonitor

        If rt <> 0 Then
            MsgBox("登入錯誤")
            Close()
        End If
    End Sub

    '報價連結回傳，在此進行呼叫個股報價
    Private Sub OnConnection(ByVal intKind%, ByVal intCode%)
        If intKind = 100 AndAlso intCode = 0 Then
            boolConnected = True
            Dim rt% = 0
            For i% = 1 To 49
                rt = SKQuoteLib_RequestStocks(i, "2330")
            Next
            Wait(500)

            AddStockNos()

            btnWriteQuote.Enabled = True
            btnTicks.Enabled = True
            btnAllTicks.Enabled = True
            cbxTWSE.Enabled = True
            cbxOTC.Enabled = True
            Me.Text = "下載報價"
            tbxR.Text = Format(Now, "HH:mm:ss") & " 報價連結成功" & vbCrLf & tbxR.Text
        Else
            boolConnected = False
            Me.Text = "下載報價---未連線"
            btnWriteQuote.Enabled = False
            btnTicks.Enabled = False
            btnAllTicks.Enabled = False
            cbxTWSE.Enabled = False
            cbxOTC.Enabled = False
        End If
    End Sub

    '按照arrStockNo呼叫報價
    Private Sub CallRequestStocks()
        dtQuote.Rows.Clear()
        Dim intRequestCount% = Int((arrStockNo.Count - 1) / 100)
        Dim strRequest(intRequestCount) As String
        For i% = 0 To intRequestCount
            strRequest(i) = arrStockNo(i * 100)
            For j% = i * 100 + 1 To If(i < intRequestCount, 99, (arrStockNo.Count - 1) Mod 100) + i * 100
                strRequest(i) &= "," & arrStockNo(j)
            Next
        Next

        Dim rt% = 0
        For i% = 1 To strRequest.Count  '頁碼，從1開始，在strRequest要-1
            rt += SKQuoteLib_RequestStocks(i, strRequest(i - 1))
            If rt = 0 Then
                Wait(300)
            Else
                tbxR.Text = TimeOfDay & " > Fail to RequestStocks" & vbCrLf & tbxR.Text
                Exit For
            End If
        Next
    End Sub

    '報價伺服器回傳資訊，更新報價表
    Private Sub OnQuote(ByVal shtMarketNo As Short, ByVal shtIndex As Short)
        Dim tsTemp As New TStock
        Dim rt% = SKQuoteLib_GetStockByIndex(shtMarketNo, shtIndex, tsTemp)
        Dim intDivider% = 10 ^ tsTemp.iDecimal
        Dim strName$ = Trim(tsTemp.StockNo)
        Dim drQ As DataRow = dtQuote.Rows.Find(strName)

        If drQ Is Nothing Then
            drQ = dtQuote.Rows.Add(strName)
        End If

        drQ.Item("Name") = Trim(tsTemp.StockName)
        drQ.Item("Open") = tsTemp.Open / intDivider
        drQ.Item("High") = tsTemp.High / intDivider
        drQ.Item("Low") = tsTemp.Low / intDivider
        drQ.Item("Close") = tsTemp.Close / intDivider
        drQ.Item("Volume") = tsTemp.TQty
    End Sub
#End Region

#Region "接收與處理成交明細資料"
    '接收成交明細資料，若於盤中開始，將呼叫GetPrevious
    Private Sub OnTicks(ByVal MarketNo As Short, ByVal Stockidx As Short, ByVal Ptr%, ByVal tTime%, ByVal Bid%, ByVal Ask%, ByVal Close%, ByVal Qty%)
        If dtTicks.Rows.Count = 0 Then
            GetPrevious(MarketNo, Stockidx, Ptr)
        Else
            Dim tTick As New TTick With {.Ask = Ask, .Bid = Bid, .Close = Close, .Ptr = Ptr, .Qty = Qty, .tTime = tTime}
            addTicks(tTick)
        End If
    End Sub

    '增加成交明細資料
    Private Sub addTicks(ByVal tTick As TTick)
        Dim datT As Date = Today.AddHours(Int(tTick.tTime / 10000)).AddMinutes(Int(tTick.tTime / 100) Mod 100).AddSeconds(tTick.tTime Mod 100)
        Dim dr As DataRow = dtTicks.Rows.Find(datT)
        If dr Is Nothing Then
            dr = dtTicks.Rows.Add(datT, tTick.Bid / 100, tTick.Ask / 100, tTick.Close / 100, tTick.Qty)
        Else
            dr.Item("Bid") = tTick.Bid / 100
            dr.Item("Ask") = tTick.Ask / 100
            dr.Item("Close") = tTick.Close / 100
            dr.Item("Qty") += tTick.Qty
        End If
    End Sub

    '從開盤開始回補逐筆成交資料
    Private Sub GetPrevious(ByVal MarketNo As Short, ByVal stockidx As Short, ByVal ptr As Integer)
        Dim tTick As New TTick
        Dim pb As New ProgressBar
        pb.Maximum = ptr
        Me.Controls.Add(pb)
        pb.BringToFront()

        For i% = 0 To ptr
            If SKQuoteLib_GetTick(MarketNo, stockidx, i, tTick) = 0 Then
                Dim dateT As Date = Today.AddHours(Int(tTick.tTime / 10000)).AddMinutes(Int(tTick.tTime / 100) Mod 100).AddSeconds(tTick.tTime Mod 100)
                addTicks(tTick)
            End If
            pb.Value = i
            My.Application.DoEvents()
        Next

        SortTicks() '重新排序 drTicks
        Me.Controls.Remove(pb)

        WriteTicks()    '寫出成交明細資料
    End Sub

    '因為有可能呼叫歷史成交明細時，又收到新的明細資料，造成紊亂，所以要重新排序
    Private Sub SortTicks()
        Using dt As DataTable = dtTicks.Copy
            dtTicks.Rows.Clear()
            Dim intNoData = 0
            For i% = 0 To dt.Rows.Count - 1
                Dim dr As DataRow
                Do
                    dr = dt.Rows.Find(Today.AddHours(8).AddSeconds(i + intNoData + 2700))
                    If dr Is Nothing Then
                        intNoData += 1
                    End If
                Loop While dr Is Nothing
                Dim drTicks As DataRow = dtTicks.NewRow
                For j% = 0 To dtTicks.Columns.Count - 1
                    drTicks.Item(j) = dr.Item(j)
                Next
                dtTicks.Rows.Add(drTicks)
            Next
        End Using
    End Sub
#End Region

#Region "輸出資料和常用函式"
    '寫出報價檔案
    Private Sub WriteQuote()
        Dim wri As New System.IO.StreamWriter(tbxQuote.Text, False)
        For Each drQ As DataRow In dtQuote.Rows
            If Not IsDBNull(drQ.Item(4)) Then
                Dim strW$ = drQ.Item(0)
                For i% = 1 To 4
                    strW &= "," & Format(drQ.Item(i), "0.##")
                Next
                strW &= "," & drQ.Item(5)

                wri.WriteLine(strW)
            End If
        Next
        wri.Close()
    End Sub

    '寫出成交明細
    Private Sub WriteTicks()
        Using wri As New System.IO.StreamWriter(tbxTicks.Text, False)
            For Each drT As DataRow In dtTicks.Rows
                Dim strW$ = Format(drT.Item(0), "HH:mm:ss")
                For i% = 1 To 4
                    strW &= "," & Format(drT.Item(i), "0.##")
                Next

                wri.WriteLine(strW)
            Next
        End Using
    End Sub

    '等待intMS毫秒
    Private Sub Wait(ByVal intMS%)
        Dim datStart As Date = Now
        Do Until Now.Subtract(datStart).TotalMilliseconds > intMS
            My.Application.DoEvents()
        Loop
        My.Computer.Audio.Stop()
    End Sub

    '顯示表格
    Private Sub ShowTable(ByVal dt As DataTable)
        Dim fom As New Form
        Dim dgv As New DataGridView
        dgv.DataSource = dt
        dgv.Dock = DockStyle.Fill
        dgv.EditMode = DataGridViewEditMode.EditProgrammatically
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False

        fom.Controls.Add(dgv)
        fom.Show()
        For i% = 0 To dt.Columns.Count - 1
            If dt.Columns(i).DataType Is GetType(Date) Then
                dgv.Columns(i).DefaultCellStyle.Format = "HH:mm:ss"
            End If
        Next
        dgv.AutoResizeColumns()
        fom.Width = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 76
    End Sub
#End Region

    '載入表單，一切開始的地方
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        QuoteTable() '設定報價表格
        TickTable() '設定成交明細表格

        FillinStockNo() '填上市櫃股票代碼

        OutputFilesSetting() '設定輸出檔名，先找最後一個交易日

        ConnectingQuote() '連結報價
    End Sub

    '更動上市與上櫃勾選
    Private Sub AddStockNos() Handles cbxTWSE.CheckedChanged, cbxOTC.CheckedChanged
        arrStockNo.Clear()
        If cbxTWSE.Checked Then
            arrStockNo.AddRange(arrTWSE)
        End If
        If cbxOTC.Checked Then
            arrStockNo.AddRange(arrOTC)
        End If

        tbxQuote.Text = "C:\Capital\Quote\" & Format(datLastTrading, "yyyyMMdd") & If(cbxTWSE.Checked, "_市", "") & If(cbxOTC.Checked, "_櫃", "") & ".txt"

        '更動完呼叫報價
        CallRequestStocks()
    End Sub

    '顯示報價按鈕
    Private Sub btnShowQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowQuote.Click
        ShowTable(dtQuote)
    End Sub

    '顯示明細按鈕
    Private Sub btnShowTicks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowTicks.Click
        ShowTable(dtTicks)
    End Sub

    '更改呼叫明細股名
    Private Sub tbxTickStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxTickStock.TextChanged
        tbxTicks.Text = "C:\Capital\Ticks\" & Format(datLastTrading, "yyyyMMdd") & If(tbxTickStock.Text = "", "", "\" & tbxTickStock.Text & ".txt")
    End Sub

    '寫入報價按鈕
    Private Sub btnWriteQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteQuote.Click
        WriteQuote()
    End Sub

    '回補並寫入全部明細
    Private Sub btnAllTicks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllTicks.Click
        Dim datS As Date = Now
        For i% = 0 To 2
            Dim strNameTXT() As String = My.Computer.FileSystem.GetFiles("C:\Capital\Ticks\" & Format(datLastTrading, "yyyyMMdd")).ToArray
            For Each strStock In arrStockNo
                tbxTickStock.Text = strStock
                If Not strNameTXT.Contains(tbxTicks.Text) Then
                    btnTicks.PerformClick()
                End If
            Next
        Next
        tbxR.Text &= vbCrLf & Int(Now.Subtract(datS).TotalSeconds) & " 秒全部回補完成"
    End Sub

    '計時器操作
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static datLast As Date = TimeOfDay
        lblTime.Text = Format(Now, "HH:mm:ss")

        If Not boolConnected AndAlso Second(Now) Mod 5 = 0 AndAlso strID <> "" AndAlso strPW <> "" Then
            Form1_Load(sender, e)
        End If
        If TimeOfDay >= #8:35:00 AM# AndAlso datLast < #8:35:00 AM# Then
            'Form1_Load(sender, e)
            Dim rt% = SKQuoteLib_LeaveMonitor
        End If
        If TimeOfDay >= datGetTicks AndAlso datLast < datGetTicks Then
            btnAllTicks.PerformClick()
        End If
    End Sub

    '回補明細按鈕
    Private Sub btnTicks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTicks.Click
        dtTicks.Rows.Clear()
        For i% = 0 To 2
            Dim rt%
            rt += SKQuoteLib_RequestTicks(1, tbxTickStock.Text)
            If rt = 0 Then
                Wait(50)
                If dtTicks.Rows.Count > 0 Then Exit For
            End If
        Next
    End Sub

    '測試鍵
    Private Sub btnTEST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTEST.Click

    End Sub
End Class