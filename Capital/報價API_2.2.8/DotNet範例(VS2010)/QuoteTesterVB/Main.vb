Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

'Imports System.Windows.Forms.DataVisualization.Charting

Public Class Main
#Region "Define Variable"
    '----------------------------------------------------------------------
    ' Define Variable
    '----------------------------------------------------------------------
    Private m_nCode As Integer
    Private m_strLoginID As String
    Private m_bConnect As Boolean = False
    Private m_bTick As Boolean = False

    Private m_dtStocks As DataTable
    Private m_dtTick As DataTable
    Private m_dtBest5Ask As DataTable
    Private m_dtBest5Bid As DataTable


    Private Delegate Sub InvokeSendMessage(ByVal state As String)


    Private fOnNotifyConnection As FOnNotifyConnection
    Private fOnNotifyQuote As FOnNotifyQuote
    Private fOnNotifyTicks As FOnNotifyTicks
    Private fOnNotifyBest5 As FOnNotifyBest5
    Private fOnNotifyServerTime As FOnNotifyServerTime

#End Region

#Region "CallBack Function"
    '----------------------------------------------------------------------
    ' CallBack Function
    '----------------------------------------------------------------------

    Public Sub OnNotifyConnection(ByVal nKind As Integer, ByVal nCode As Integer)
        If nCode = 0 Then
            If nKind = 100 Then
                lblConnect.ForeColor = Color.Green
                m_bConnect = True
            ElseIf nKind = 101 Then
                lblConnect.ForeColor = Color.Red
                m_bConnect = False
            End If
        End If
    End Sub

    Public Sub OnNotifyQuote(ByVal sMarketNo As Short, ByVal sStockidx As Short)
        Dim pSTOCK As STOCK
        pSTOCK = Nothing

        Functions.SKQuoteLib_GetStockByIndex(sMarketNo, sStockidx, pSTOCK)

        OnUpDateDataRow(pSTOCK)
    End Sub

    Public Sub OnNotifyTicks(ByVal sMarketNo As Short, ByVal sStockidx As Short, ByVal nPtr As Integer)
        Dim tick As TICK

        If m_bTick = False Then
            m_bTick = True

            'For i As Integer = 0 To nPtr
            'Functions.SKQuoteLib_GetTick(sMarketNo, sStockidx, i, tick)

            'InsertTick(tick)
            'Next
        Else
            Functions.SKQuoteLib_GetTick(sMarketNo, sStockidx, nPtr, tick)

            InsertTick(tick)
        End If
    End Sub

    Public Sub OnNotifyBest5(ByVal sMarketNo As Short, ByVal sStockidx As Short)
        Dim best5 As BEST5

        Functions.SKQuoteLib_GetBest5(sMarketNo, sStockidx, best5)

        InsertBest5(best5)
    End Sub

    Public Sub OnNotifyServerTime(ByVal sHour As Short, ByVal sMinute As Short, ByVal sSecond As Short, ByVal nTotal As Integer)
        Dim strTime As String = String.Format("{0}:{1}:{2}", sHour.ToString(), sMinute.ToString(), sSecond.ToString())

        OnPrintServerTime(strTime)
    End Sub
#End Region

#Region "Custom Method"
    '----------------------------------------------------------------------
    ' Custom Method
    '----------------------------------------------------------------------
    Public Function GetApiCodeDefine(ByVal nCode As Integer) As String
        Dim strNCode As String = [Enum].GetName(GetType(ApiMessage), nCode)

        If strNCode = "" OrElse strNCode Is Nothing Then
            Return nCode.ToString()
        Else
            Return strNCode
        End If
    End Function

    Public Sub OnPrintServerTime(ByVal strMsg As String)
        If lblServerTime.InvokeRequired = True Then
            Me.Invoke(New InvokeSendMessage(AddressOf Me.OnPrintServerTime), New Object() {strMsg})
        Else
            lblServerTime.Text = strMsg
        End If
    End Sub

    Private Function CreateStocksDataTable() As DataTable
        Dim myDataTable As New DataTable()

        Dim myDataColumn As DataColumn

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int16")
        myDataColumn.ColumnName = "m_sStockidx"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int16")
        myDataColumn.ColumnName = "m_sDecimal"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int16")
        myDataColumn.ColumnName = "m_sTypeNo"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.String")
        myDataColumn.ColumnName = "m_cMarketNo"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.String")
        myDataColumn.ColumnName = "m_caStockNo"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.String")
        myDataColumn.ColumnName = "m_caName"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nOpen"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nHigh"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nLow"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nClose"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nTickQty"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nRef"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nBid"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nBc"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nAsk"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nAc"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nTBc"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nTAc"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nFutureOI"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nTQty"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nYQty"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nUp"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nDown"
        myDataTable.Columns.Add(myDataColumn)


        myDataTable.PrimaryKey = New DataColumn() {myDataTable.Columns("m_caStockNo")}


        Return myDataTable
    End Function

    Private Function CreateTickDataTable() As DataTable
        Dim myDataTable As New DataTable()

        Dim myDataColumn As DataColumn

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nPtr"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int64")
        myDataColumn.ColumnName = "m_nTime"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nBid"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nAsk"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nClose"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nQty"
        myDataTable.Columns.Add(myDataColumn)

        Return myDataTable
    End Function

    Private Function CreateBest5AskTable() As DataTable
        Dim myDataTable As New DataTable()

        Dim myDataColumn As DataColumn

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nAskQty"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_nAsk"
        myDataTable.Columns.Add(myDataColumn)

        Return myDataTable

    End Function

    Private Sub OnUpDateDataRow(ByVal pStock As STOCK)
        Dim strStockNo As String = pStock.m_caStockNo

        Dim drFind As DataRow = m_dtStocks.Rows.Find(strStockNo)
        If drFind Is Nothing Then
            Try
                Dim myDataRow As DataRow = m_dtStocks.NewRow()

                myDataRow("m_sStockidx") = pStock.m_sStockidx
                myDataRow("m_sDecimal") = pStock.m_sDecimal
                myDataRow("m_sTypeNo") = pStock.m_sTypeNo
                myDataRow("m_cMarketNo") = pStock.m_cMarketNo
                myDataRow("m_caStockNo") = pStock.m_caStockNo
                myDataRow("m_caName") = pStock.m_caName
                myDataRow("m_nOpen") = pStock.m_nOpen / (Math.Pow(10, pStock.m_sDecimal))
                myDataRow("m_nHigh") = pStock.m_nHigh / (Math.Pow(10, pStock.m_sDecimal))
                myDataRow("m_nLow") = pStock.m_nLow / (Math.Pow(10, pStock.m_sDecimal))
                myDataRow("m_nClose") = pStock.m_nClose / (Math.Pow(10, pStock.m_sDecimal))
                myDataRow("m_nTickQty") = pStock.m_nTickQty
                myDataRow("m_nRef") = pStock.m_nRef / (Math.Pow(10, pStock.m_sDecimal))
                myDataRow("m_nBid") = pStock.m_nBid / (Math.Pow(10, pStock.m_sDecimal))
                myDataRow("m_nBc") = pStock.m_nBc
                myDataRow("m_nAsk") = pStock.m_nAsk / (Math.Pow(10, pStock.m_sDecimal))
                myDataRow("m_nAc") = pStock.m_nAc
                myDataRow("m_nTBc") = pStock.m_nTBc
                myDataRow("m_nTAc") = pStock.m_nTAc
                myDataRow("m_nFutureOI") = pStock.m_nFutureOI
                myDataRow("m_nTQty") = pStock.m_nTQty
                myDataRow("m_nYQty") = pStock.m_nYQty
                myDataRow("m_nUp") = pStock.m_nUp / (Math.Pow(10, pStock.m_sDecimal))
                myDataRow("m_nDown") = pStock.m_nDown / (Math.Pow(10, pStock.m_sDecimal))


                m_dtStocks.Rows.Add(myDataRow)
            Catch ex As Exception
                Dim msg As String = ex.Message
            End Try
        Else
            drFind("m_sStockidx") = pStock.m_sStockidx
            drFind("m_sDecimal") = pStock.m_sDecimal
            drFind("m_sTypeNo") = pStock.m_sTypeNo
            drFind("m_cMarketNo") = pStock.m_cMarketNo
            drFind("m_caStockNo") = pStock.m_caStockNo
            drFind("m_caName") = pStock.m_caName
            drFind("m_nOpen") = pStock.m_nOpen / (Math.Pow(10, pStock.m_sDecimal))
            drFind("m_nHigh") = pStock.m_nHigh / (Math.Pow(10, pStock.m_sDecimal))
            drFind("m_nLow") = pStock.m_nLow / (Math.Pow(10, pStock.m_sDecimal))
            drFind("m_nClose") = pStock.m_nClose / (Math.Pow(10, pStock.m_sDecimal))
            drFind("m_nTickQty") = pStock.m_nTickQty
            drFind("m_nRef") = pStock.m_nRef / (Math.Pow(10, pStock.m_sDecimal))
            drFind("m_nBid") = pStock.m_nBid / (Math.Pow(10, pStock.m_sDecimal))
            drFind("m_nBc") = pStock.m_nBc
            drFind("m_nAsk") = pStock.m_nAsk / (Math.Pow(10, pStock.m_sDecimal))
            drFind("m_nAc") = pStock.m_nAc
            drFind("m_nTBc") = pStock.m_nTBc
            drFind("m_nTAc") = pStock.m_nTAc
            drFind("m_nFutureOI") = pStock.m_nFutureOI
            drFind("m_nTQty") = pStock.m_nTQty
            drFind("m_nYQty") = pStock.m_nYQty
            drFind("m_nUp") = pStock.m_nUp / (Math.Pow(10, pStock.m_sDecimal))
            drFind("m_nDown") = pStock.m_nDown / (Math.Pow(10, pStock.m_sDecimal))
        End If
    End Sub

    Public Shared Sub SetDoubleBuffered(ByVal c As System.Windows.Forms.Control)
        If System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Return
        End If

        Dim aProp As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)

        aProp.SetValue(c, True, Nothing)
    End Sub

    Public Sub InsertTick(ByVal pTick As TICK)
        Dim myDataRow As DataRow = m_dtTick.NewRow()

        myDataRow("m_nPtr") = pTick.m_nPtr
        myDataRow("m_nTime") = pTick.m_nTime

        If pTick.m_nBid = -999999 Then
            myDataRow("m_nBid") = 0
        Else
            myDataRow("m_nBid") = pTick.m_nBid / 100.0
        End If

        If pTick.m_nAsk = -999999 Then
            myDataRow("m_nAsk") = 0
        Else
            myDataRow("m_nAsk") = pTick.m_nAsk / 100.0
        End If

        If pTick.m_nAsk = -999999 Then
            myDataRow("m_nClose") = 0
        Else
            myDataRow("m_nClose") = pTick.m_nClose / 100.0
        End If

        myDataRow("m_nQty") = pTick.m_nQty

        m_dtTick.Rows.Add(myDataRow)

    End Sub

    Private Sub InsertBest5(ByVal Best5 As BEST5)
        If m_dtBest5Ask.Rows.Count = 0 AndAlso m_dtBest5Bid.Rows.Count = 0 Then
            Dim myDataRow As DataRow

            myDataRow = m_dtBest5Ask.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nAskQty1
            myDataRow("m_nAsk") = Best5.m_nAsk1 / 100.0
            m_dtBest5Ask.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Ask.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nAskQty2
            myDataRow("m_nAsk") = Best5.m_nAsk2 / 100.0
            m_dtBest5Ask.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Ask.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nAskQty3
            myDataRow("m_nAsk") = Best5.m_nAsk3 / 100.0
            m_dtBest5Ask.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Ask.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nAskQty4
            myDataRow("m_nAsk") = Best5.m_nAsk4 / 100.0
            m_dtBest5Ask.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Ask.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nAskQty5
            myDataRow("m_nAsk") = Best5.m_nAsk5 / 100.0
            m_dtBest5Ask.Rows.Add(myDataRow)



            myDataRow = m_dtBest5Bid.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nBidQty1
            myDataRow("m_nAsk") = Best5.m_nBid1 / 100.0
            m_dtBest5Bid.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Bid.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nBidQty2
            myDataRow("m_nAsk") = Best5.m_nBid2 / 100.0
            m_dtBest5Bid.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Bid.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nBidQty3
            myDataRow("m_nAsk") = Best5.m_nBid3 / 100.0
            m_dtBest5Bid.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Bid.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nBidQty4
            myDataRow("m_nAsk") = Best5.m_nBid4 / 100.0
            m_dtBest5Bid.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Bid.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nBidQty5
            myDataRow("m_nAsk") = Best5.m_nBid5 / 100.0

            m_dtBest5Bid.Rows.Add(myDataRow)
        Else
            m_dtBest5Ask.Rows(0)("m_nAskQty") = Best5.m_nAskQty1
            m_dtBest5Ask.Rows(0)("m_nAsk") = Best5.m_nAsk1 / 100.0

            m_dtBest5Ask.Rows(1)("m_nAskQty") = Best5.m_nAskQty2
            m_dtBest5Ask.Rows(1)("m_nAsk") = Best5.m_nAsk2 / 100.0

            m_dtBest5Ask.Rows(2)("m_nAskQty") = Best5.m_nAskQty3
            m_dtBest5Ask.Rows(2)("m_nAsk") = Best5.m_nAsk3 / 100.0

            m_dtBest5Ask.Rows(3)("m_nAskQty") = Best5.m_nAskQty4
            m_dtBest5Ask.Rows(3)("m_nAsk") = Best5.m_nAsk4 / 100.0

            m_dtBest5Ask.Rows(4)("m_nAskQty") = Best5.m_nAskQty5
            m_dtBest5Ask.Rows(4)("m_nAsk") = Best5.m_nAsk5 / 100.0


            m_dtBest5Bid.Rows(0)("m_nAskQty") = Best5.m_nBidQty1
            m_dtBest5Bid.Rows(0)("m_nAsk") = Best5.m_nBid1 / 100.0

            m_dtBest5Bid.Rows(1)("m_nAskQty") = Best5.m_nBidQty2
            m_dtBest5Bid.Rows(1)("m_nAsk") = Best5.m_nBid2 / 100.0

            m_dtBest5Bid.Rows(2)("m_nAskQty") = Best5.m_nBidQty3
            m_dtBest5Bid.Rows(2)("m_nAsk") = Best5.m_nBid3 / 100.0

            m_dtBest5Bid.Rows(3)("m_nAskQty") = Best5.m_nBidQty4
            m_dtBest5Bid.Rows(3)("m_nAsk") = Best5.m_nBid4 / 100.0

            m_dtBest5Bid.Rows(4)("m_nAskQty") = Best5.m_nBidQty5
            m_dtBest5Bid.Rows(4)("m_nAsk") = Best5.m_nBid5 / 100.0
        End If
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim fServerTime As FORMAT05
        m_nCode = Functions.SKQuoteLib_GetServerTime(fServerTime)

        If m_nCode = 0 Then
            Dim strTime As String = String.Format("{0}:{1}:{2}", fServerTime.m_sHour.ToString(), fServerTime.m_sMinute.ToString(), fServerTime.m_sSecond.ToString())

            MessageBox.Show(strTime)
        End If

        timerServerTime.Enabled = True

    End Sub

    Private Sub timerServerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerServerTime.Tick
        If m_bConnect = True Then
            m_nCode = Functions.SKQuoteLib_RequestServerTime()
        End If

    End Sub

#End Region

#Region "Component Event"
    '----------------------------------------------------------------------
    ' Component Event
    '----------------------------------------------------------------------

    Private Sub btnInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInitialize.Click
        Dim strPassword As String

        m_strLoginID = txtAccount.Text.Trim()
        strPassword = txtPassWord.Text.Trim()

        'Initialize SKOrderLib
        m_nCode = Functions.SKQuoteLib_Initialize(m_strLoginID, strPassword)

        If m_nCode = 0 Then
            MessageBox.Show("Initialize Success")
            lblMessage.Text = "元件初始化完成"
        ElseIf m_nCode = 2003 Then
            lblMessage.Text = "元件已初始過，無須重複執行"
            Return
        Else
            lblMessage.Text = "元件初始化失敗 code " & GetApiCodeDefine(m_nCode)
            Return
        End If

        m_nCode = Functions.SKQuoteLib_AttachConnectionCallBack(fOnNotifyConnection)

        m_nCode = Functions.SKQuoteLib_AttachQuoteCallBack(fOnNotifyQuote)

        m_nCode = Functions.SKQuoteLib_AttachTicksCallBack(fOnNotifyTicks)

        m_nCode = Functions.SKQuoteLib_AttachBest5CallBack(fOnNotifyBest5)

        m_nCode = Functions.SKQuoteLib_AttchServerTimeCallBack(fOnNotifyServerTime)

    End Sub

    Private Sub btnEnterMonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterMonitor.Click
        m_nCode = Functions.SKQuoteLib_EnterMonitor()

        If m_nCode = 0 Then
            lblMessage.Text = "SKQuoteLib_EnterMonitor 呼叫成功"
            m_bConnect = True
        Else
            lblMessage.Text = "呼叫失敗 [CODE] " & GetApiCodeDefine(m_nCode)
        End If

    End Sub

    Private Sub btnLeaveMonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeaveMonitor.Click
        m_nCode = Functions.SKQuoteLib_LeaveMonitor()

        If m_nCode = 0 Then
            lblConnect.ForeColor = Color.Red
            lblMessage.Text = "SKQuoteLib_LeaveMonitor 呼叫成功"
            m_bConnect = False
        Else
            lblMessage.Text = "呼叫失敗 [CODE] " & GetApiCodeDefine(m_nCode)
        End If

    End Sub

    Private Sub btnQueryStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryStocks.Click
        Dim strStocks As String
        Dim nPage As Integer = 1

        m_dtStocks.Clear()
        gridStocks.ClearSelection()

        gridStocks.DataSource = m_dtStocks

        gridStocks.Columns("m_sStockidx").Visible = False
        gridStocks.Columns("m_sDecimal").Visible = False
        gridStocks.Columns("m_sTypeNo").Visible = False
        gridStocks.Columns("m_cMarketNo").Visible = False
        gridStocks.Columns("m_caStockNo").HeaderText = "代碼"
        gridStocks.Columns("m_caName").HeaderText = "名稱"
        gridStocks.Columns("m_nOpen").HeaderText = "開盤價"
        gridStocks.Columns("m_nHigh").Visible = False
        gridStocks.Columns("m_nLow").Visible = False
        gridStocks.Columns("m_nClose").HeaderText = "成交價"
        gridStocks.Columns("m_nTickQty").HeaderText = "單量"
        gridStocks.Columns("m_nRef").HeaderText = "昨收價"
        gridStocks.Columns("m_nBid").HeaderText = "買進"
        gridStocks.Columns("m_nBc").Visible = False
        gridStocks.Columns("m_nAsk").HeaderText = "賣出"
        gridStocks.Columns("m_nAc").Visible = False
        gridStocks.Columns("m_nTBc").Visible = False
        gridStocks.Columns("m_nTAc").Visible = False
        gridStocks.Columns("m_nFutureOI").Visible = False
        gridStocks.Columns("m_nTQty").Visible = False
        gridStocks.Columns("m_nYQty").Visible = False
        gridStocks.Columns("m_nUp").Visible = False
        gridStocks.Columns("m_nDown").Visible = False

        strStocks = txtStocks.Text.Trim()

        m_nCode = Functions.SKQuoteLib_RequestStocks(nPage, strStocks)

        If m_nCode = 0 Then
            lblMessage.Text = "SKQuoteLib_RequestStocks 呼叫成功"
        Else
            lblMessage.Text = "呼叫失敗 [CODE] " & GetApiCodeDefine(m_nCode)
        End If

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fOnNotifyConnection = New FOnNotifyConnection(AddressOf OnNotifyConnection)
        GC.KeepAlive(fOnNotifyConnection)

        fOnNotifyQuote = New FOnNotifyQuote(AddressOf OnNotifyQuote)
        GC.KeepAlive(fOnNotifyQuote)

        fOnNotifyTicks = New FOnNotifyTicks(AddressOf OnNotifyTicks)
        GC.KeepAlive(fOnNotifyTicks)

        fOnNotifyBest5 = New FOnNotifyBest5(AddressOf OnNotifyBest5)
        GC.KeepAlive(fOnNotifyBest5)

        fOnNotifyServerTime = New FOnNotifyServerTime(AddressOf OnNotifyServerTime)
        GC.KeepAlive(fOnNotifyServerTime)

        m_dtStocks = CreateStocksDataTable()
        m_dtTick = CreateTickDataTable()
        m_dtBest5Ask = CreateBest5AskTable()
        m_dtBest5Bid = CreateBest5AskTable()

        SetDoubleBuffered(gridStocks)

    End Sub

    Private Sub gridStocks_CellPainting_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles gridStocks.CellPainting
        If e.RowIndex >= 0 Then
            e.Graphics.FillRectangle(Brushes.Black, e.CellBounds)

            If e.Value IsNot Nothing Then

                Dim strHeaderText As String
                Try
                    strHeaderText = DirectCast(sender, DataGridView).Columns(e.ColumnIndex).HeaderText.ToString()

                    If strHeaderText = "名稱" Then
                        e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.SkyBlue, e.CellBounds.X, e.CellBounds.Y)
                    ElseIf strHeaderText = "買進" OrElse strHeaderText = "賣出" OrElse strHeaderText = "成交價" Then
                        Dim dPrc As Double = Double.Parse(DirectCast(sender, DataGridView).Rows(e.RowIndex).Cells("m_nRef").Value.ToString())

                        Dim dValue As Double = Double.Parse(e.Value.ToString())

                        If dValue > dPrc Then
                            e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.Red, e.CellBounds.X, e.CellBounds.Y)
                        ElseIf dValue < dPrc Then
                            e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.Lime, e.CellBounds.X, e.CellBounds.Y)
                        Else
                            e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.White, e.CellBounds.X, e.CellBounds.Y)
                        End If
                    ElseIf strHeaderText = "單量" Then
                        e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.Yellow, e.CellBounds.X, e.CellBounds.Y)
                    Else
                        e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.White, e.CellBounds.X, e.CellBounds.Y)
                    End If

                Catch Ex As Exception
                    Return
                End Try
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub btnTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick.Click
        m_dtTick.Clear()
        m_dtBest5Ask.Clear()
        m_dtBest5Bid.Clear()

        m_bTick = False

        GridTick.DataSource = m_dtTick
        GridBest5Ask.DataSource = m_dtBest5Ask
        GridBest5Bid.DataSource = m_dtBest5Bid


        GridTick.Columns("m_nPtr").Visible = False
        GridTick.Columns("m_nTime").HeaderText = "時間"
        GridTick.Columns("m_nTime").Width = 80
        GridTick.Columns("m_nBid").HeaderText = "買價"
        GridTick.Columns("m_nBid").Width = 80
        GridTick.Columns("m_nAsk").HeaderText = "賣價"
        GridTick.Columns("m_nAsk").Width = 80
        GridTick.Columns("m_nClose").HeaderText = "成交價"
        GridTick.Columns("m_nClose").Width = 80
        GridTick.Columns("m_nQty").HeaderText = "量"
        GridTick.Columns("m_nQty").Width = 40


        GridBest5Ask.Columns("m_nAskQty").HeaderText = "張數"
        GridBest5Ask.Columns("m_nAskQty").Width = 60
        GridBest5Ask.Columns("m_nAsk").HeaderText = "賣價"
        GridBest5Ask.Columns("m_nAsk").Width = 60

        GridBest5Bid.Columns("m_nAskQty").HeaderText = "張數"
        GridBest5Bid.Columns("m_nAskQty").Width = 60
        GridBest5Bid.Columns("m_nAsk").HeaderText = "買價"
        GridBest5Bid.Columns("m_nAsk").Width = 60

        Dim nPageNo As Integer = 3
        m_nCode = Functions.SKQuoteLib_RequestTicks(nPageNo, txtTick.Text.Trim())

    End Sub

    Private Sub Main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        btnLeaveMonitor_Click(Nothing, Nothing)
    End Sub
#End Region



End Class
