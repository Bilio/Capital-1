Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class Main

#Region "Define Variable"
    '----------------------------------------------------------------------
    ' Define Variable
    '----------------------------------------------------------------------
    Private m_nCode As Integer
    Private m_strLoginID As String

    Private m_nBest5Count As Integer

    Private Delegate Sub InvokeSendMessage(ByVal state As String)

    Private Delegate Sub InvokeQuoteUpdate(ByVal Foreign As FOREIGN)
    Private Delegate Sub InvokeBest5(ByVal Best5 As BEST5)

    Private m_dtForeigns As DataTable
    Private m_dtBest5Ask As DataTable
    Private m_dtBest5Bid As DataTable

    Private fConnect As FOnConnect
    Private fQuoteUpdate As FOnGetStockIdx
    Private fOnNotifyBest5 As FOnGetStockIdx
    Private fNotifyTicks As FOnNotifyTicks
    Private fOverseaProducts As FOnOverseaProducts
    Private fNotifyServerTime As FOnNotifyServerTime
    Private fNotifyKLineData As FOnNotifyKLineData


#End Region

#Region "Initialize"

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fConnect = New FOnConnect(AddressOf OnConnect)
        GC.KeepAlive(fConnect)

        fQuoteUpdate = New FOnGetStockIdx(AddressOf OnQuoteUpdate)
        GC.KeepAlive(fQuoteUpdate)

        fNotifyTicks = New FOnNotifyTicks(AddressOf OnNotifyTicks)
        GC.KeepAlive(fNotifyTicks)

        fOnNotifyBest5 = New FOnGetStockIdx(AddressOf OnNotifyBest5)
        GC.KeepAlive(fOnNotifyBest5)

        fOverseaProducts = New FOnOverseaProducts(AddressOf OnOverseaProducts)
        GC.KeepAlive(fOverseaProducts)

        fNotifyServerTime = New FOnNotifyServerTime(AddressOf OnNotifyServerTime)
        GC.KeepAlive(fNotifyServerTime)

        fNotifyKLineData = New FOnNotifyKLineData(AddressOf OnNotifyKLineData)
        GC.KeepAlive(fNotifyKLineData)


        m_dtForeigns = CreateStocksDataTable()
        m_dtBest5Ask = CreateBest5AskTable()
        m_dtBest5Bid = CreateBest5AskTable()

        SetDoubleBuffered(gridStocks)

        m_nBest5Count = 0

        lblConnect.ForeColor = Color.Red

        boxKLineType.SelectedIndex = 0

    End Sub

    Private Sub Main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        btnDisconnect_Click(Nothing, Nothing)
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
        m_nCode = Functions.SKOSQuoteLib_Initialize(m_strLoginID, strPassword)

        If m_nCode = 0 Then
            MessageBox.Show("Initialize Success")
            lblMessage.Text = "元件初始化完成"
        ElseIf m_nCode = 2003 Then
            lblMessage.Text = "元件已初始過，無須重複執行"
        Else
            lblMessage.Text = "元件初始化失敗 code " & GetApiCodeDefine(m_nCode)
            Return
        End If

        m_nCode = Functions.SKOSQuoteLib_AttachConnectCallBack(fConnect)

        m_nCode = Functions.SKOSQuoteLib_AttachQuoteCallBack(fQuoteUpdate)

        m_nCode = Functions.SKOSQuoteLib_AttachTicksCallBack(fNotifyTicks)

        m_nCode = Functions.SKOSQuoteLib_AttachBest5CallBack(fOnNotifyBest5)

        m_nCode = Functions.SKOSQuoteLib_AttachServerTimeCallBack(fNotifyServerTime)

    End Sub


    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        m_nCode = Functions.SKOSQuoteLib_EnterMonitor(1)

        If m_nCode <> 0 Then
            lblMessage.Text = "連線失敗 code " & GetApiCodeDefine(m_nCode)
        End If

    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        m_nCode = Functions.SKOSQuoteLib_LeaveMonitor()

        If m_nCode <> 0 Then
            lblMessage.Text = "斷線失敗 code " & GetApiCodeDefine(m_nCode)
        End If

    End Sub

    Private Sub btnServerTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServerTime.Click
        m_nCode = Functions.SKOSQuoteLib_RequestServerTime()

        If m_nCode <> 0 Then
            lblMessage.Text = "查詢時間失敗 code " & GetApiCodeDefine(m_nCode)
        End If

    End Sub

    Private Sub btnQueryStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryStocks.Click
        Dim strStocks As String
        Dim nPage As Integer = 0

        m_dtForeigns.Clear()
        gridStocks.ClearSelection()

        gridStocks.DataSource = m_dtForeigns


        gridStocks.Columns("m_sStockidx").Visible = False
        gridStocks.Columns("m_sDecimal").Visible = False
        gridStocks.Columns("m_nDenominator").Visible = False
        gridStocks.Columns("m_cMarketNo").Visible = False
        gridStocks.Columns("m_caExchangeNo").HeaderText = "交易所代碼"
        gridStocks.Columns("m_caExchangeName").HeaderText = "交易所名稱"
        gridStocks.Columns("m_caStockNo").HeaderText = "商品代碼"
        gridStocks.Columns("m_caStockName").HeaderText = "商品名稱"

        gridStocks.Columns("m_nOpen").HeaderText = "開盤價"
        gridStocks.Columns("m_nHigh").HeaderText = "最高價"
        gridStocks.Columns("m_nLow").HeaderText = "最低價"
        gridStocks.Columns("m_nClose").HeaderText = "成交價"
        gridStocks.Columns("m_dSettlePrice").HeaderText = "結算價"
        gridStocks.Columns("m_nTickQty").HeaderText = "單量"
        gridStocks.Columns("m_nRef").HeaderText = "昨收價"

        gridStocks.Columns("m_nBid").HeaderText = "買價"
        gridStocks.Columns("m_nBc").HeaderText = "買量"
        gridStocks.Columns("m_nAsk").HeaderText = "賣價"
        gridStocks.Columns("m_nAc").HeaderText = "賣量"
        gridStocks.Columns("m_nTQty").HeaderText = "成交量"



        strStocks = txtStocks.Text.Trim()

        m_nCode = Functions.SKOSQuoteLib_RequestStocks(nPage, strStocks)

        If m_nCode <> 0 Then
            lblMessage.Text = "查詢商品失敗 code " & GetApiCodeDefine(m_nCode)
        End If

        gridStocks.Refresh()

    End Sub

    Private Sub gridStocks_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles gridStocks.CellPainting
        If e.RowIndex >= 0 Then
            e.Graphics.FillRectangle(Brushes.Black, e.CellBounds)

            If e.Value IsNot Nothing Then
                Dim strHeaderText As String = DirectCast(sender, DataGridView).Columns(e.ColumnIndex).HeaderText.ToString()

                Dim nDenominator As Integer

                Try
                    nDenominator = Integer.Parse(DirectCast(sender, DataGridView).Rows(e.RowIndex).Cells("m_nDenominator").Value.ToString())
                Catch Ex As Exception
                    Return
                End Try

                If strHeaderText = "名稱" Then
                    e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.SkyBlue, e.CellBounds.X, e.CellBounds.Y)
                ElseIf strHeaderText = "買價" OrElse strHeaderText = "賣價" OrElse strHeaderText = "成交價" OrElse strHeaderText = "開盤價" OrElse strHeaderText = "最高價" OrElse strHeaderText = "最低價" OrElse strHeaderText = "昨收價" Then
                    Dim dPrc As Double = Double.Parse(DirectCast(sender, DataGridView).Rows(e.RowIndex).Cells("m_nRef").Value.ToString())

                    Dim dValue As Double = Double.Parse(e.Value.ToString())

                    Dim strCellValue As String = ""


                    If nDenominator > 4 Then
                        Dim strValue As String = e.Value.ToString()

                        If strValue.IndexOf("."c) > -1 Then
                            Dim nValue1 As Integer = Integer.Parse(strValue.Substring(0, strValue.IndexOf("."c)))

                            Dim dValue2 As Double = Double.Parse(strValue.Substring(strValue.IndexOf("."c), (strValue.Length - strValue.IndexOf("."c))))

                            strCellValue = nValue1.ToString() & "'" & (dValue2 * nDenominator).ToString("#0.##")
                        End If
                    Else
                        strCellValue = e.Value.ToString()
                    End If

                    If dValue > dPrc Then

                        e.Graphics.DrawString(strCellValue, e.CellStyle.Font, Brushes.Red, e.CellBounds.X, e.CellBounds.Y)
                    ElseIf dValue < dPrc Then
                        e.Graphics.DrawString(strCellValue, e.CellStyle.Font, Brushes.Lime, e.CellBounds.X, e.CellBounds.Y)
                    Else
                        e.Graphics.DrawString(strCellValue, e.CellStyle.Font, Brushes.White, e.CellBounds.X, e.CellBounds.Y)
                    End If
                ElseIf strHeaderText = "單量" OrElse strHeaderText = "成交量" Then
                    e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.Yellow, e.CellBounds.X, e.CellBounds.Y)
                Else
                    e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.White, e.CellBounds.X, e.CellBounds.Y)
                End If
            End If
            e.Handled = True
        End If

    End Sub

    Private Sub btnTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTick.Click
        listTicks.Items.Clear()
        m_dtBest5Ask.Clear()
        m_dtBest5Bid.Clear()

        gridBest5Bid.DataSource = m_dtBest5Bid
        gridBest5Ask.DataSource = m_dtBest5Ask


        gridBest5Ask.Columns("m_nAskQty").HeaderText = "張數"
        gridBest5Ask.Columns("m_nAskQty").Width = 60
        gridBest5Ask.Columns("m_nAsk").HeaderText = "賣價"
        gridBest5Ask.Columns("m_nAsk").Width = 60

        gridBest5Bid.Columns("m_nAskQty").HeaderText = "張數"
        gridBest5Bid.Columns("m_nAskQty").Width = 60
        gridBest5Bid.Columns("m_nAsk").HeaderText = "買價"
        gridBest5Bid.Columns("m_nAsk").Width = 60

        Dim nPage As Integer = 0

        Dim strTicks As String = txtTick.Text.Trim()

        m_nCode = Functions.SKOSQuoteLib_RequestTicks(nPage, strTicks)

        If m_nCode <> 0 Then
            lblMessage.Text = "查詢Ticks失敗 code " & GetApiCodeDefine(m_nCode)
        End If

    End Sub

    Private Sub btnOverseaProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverseaProducts.Click
        listOverseaProducts.Items.Clear()

        m_nCode = Functions.SKOSQuoteLib_AttachOverseaProductsCallBack(fOverseaProducts)

        m_nCode = Functions.SKOSQuoteLib_RequestOverseaProducts()

    End Sub

    Private Sub btnKLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKLine.Click
        listKLine.Items.Clear()

        Dim strStock As String = ""
        Dim nType As Integer = 0

        strStock = txtKLine.Text.Trim()
        nType = boxKLineType.SelectedIndex

        m_nCode = Functions.SKOSQuoteLib_AttachKLineDataCallBack(fNotifyKLineData)

        m_nCode = Functions.SKOSQuoteLib_RequestKLine(strStock, CShort(nType))

    End Sub

#End Region

#Region "CallBack Function"
    '----------------------------------------------------------------------
    ' CallBack Function
    '----------------------------------------------------------------------
    'Connect CallBack Function
    Public Sub OnConnect(ByVal nKind As Integer, ByVal nErrorCode As Integer)
        If nKind = 100 Then
            WriteInfo("Connect Code: " & GetApiCodeDefine(nErrorCode))

            Timer1.Enabled = True

            lblConnect.ForeColor = Color.Green
        ElseIf nKind = 101 Then
            WriteInfo("Disconnect Code: " & GetApiCodeDefine(nErrorCode))

            Timer1.Enabled = False

            lblConnect.ForeColor = Color.Red
        End If
    End Sub
    Public Sub OnQuoteUpdate(ByVal nStockIdx As Short)
        Dim Foreign As FOREIGN
        Foreign = Nothing

        m_nCode = Functions.SKOSQuoteLib_GetStockByIndex(nStockIdx, Foreign)

        If m_nCode <> 0 Then
            lblMessage.Text = "商品報價查詢失敗 " & GetApiCodeDefine(m_nCode)
        Else

            'OnUpDateDataQuote(Foreign);
            Me.Invoke(New InvokeQuoteUpdate(AddressOf Me.OnUpDateDataQuote), New Object() {Foreign})
        End If
    End Sub

    Public Sub OnNotifyTicks(ByVal sStockIdx As Short, ByVal nPtr As Integer)
        Dim tTick As TICK

        m_nCode = Functions.SKQuoteLib_GetTick(sStockIdx, nPtr, tTick)

        If m_nCode = 0 Then
            'listTicks.Items.Add("時間：" & tTick.m_nTime.ToString() & "  成交價：" & tTick.m_nClose.ToString() & "  量：" & tTick.m_nQty.ToString())

            'listTicks.SelectedIndex = listTicks.Items.Count - 1
            Dim strMsge As String

            strMsge = "時間：" & tTick.m_nTime.ToString() & "  成交價：" & tTick.m_nClose.ToString() & "  量：" & tTick.m_nQty.ToString()

            Me.Invoke(New InvokeSendMessage(AddressOf Me.WriteTick), New Object() {strMsge})
        End If

    End Sub
    Public Sub WriteTick(ByVal strMsg As String)

        'If lblMessage.InvokeRequired = True Then
        '    Me.Invoke(New InvokeSendMessage(AddressOf Me.WriteInfo), New Object() {strMsg})
        'Else
        '    lblMessage.Text = strMsg
        'End If

        listTicks.Items.Add(strMsg)
        listTicks.SelectedIndex = listTicks.Items.Count - 1

    End Sub

    Public Sub OnNotifyBest5(ByVal sStockidx As Short)
        Dim best5 As BEST5

        Functions.SKOSQuoteLib_GetBest5(sStockidx, best5)


        Me.Invoke(New InvokeBest5(AddressOf Me.InsertBest5), New Object() {best5})

        'InsertBest5(best5)

        'm_nBest5Count += 1

    End Sub

    Public Sub OnOverseaProducts(ByVal strProducts As String)
        listOverseaProducts.Items.Add(strProducts.Trim())
    End Sub

    Public Sub OnNotifyServerTime(ByVal sHour As Short, ByVal sMinute As Short, ByVal sSecond As Short)
        lblServerTime.Text = sHour.ToString() & "：" & sMinute.ToString() & "：" & sSecond.ToString()
    End Sub

    Public Sub OnNotifyKLineData(ByVal strStockNo As String, ByVal strKLineData As String)
        listKLine.Items.Add(strKLineData.Trim())
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


    Public Sub WriteInfo(ByVal strMsg As String)
        If lblMessage.InvokeRequired = True Then
            Me.Invoke(New InvokeSendMessage(AddressOf Me.WriteInfo), New Object() {strMsg})
        Else
            lblMessage.Text = strMsg
        End If
    End Sub

    Public Shared Sub SetDoubleBuffered(ByVal c As System.Windows.Forms.Control)
        If System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Return
        End If

        Dim aProp As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)

        aProp.SetValue(c, True, Nothing)
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
        myDataColumn.DataType = Type.[GetType]("System.Int32")
        myDataColumn.ColumnName = "m_nDenominator"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.String")
        myDataColumn.ColumnName = "m_cMarketNo"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.String")
        myDataColumn.ColumnName = "m_caExchangeNo"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.String")
        myDataColumn.ColumnName = "m_caExchangeName"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.String")
        myDataColumn.ColumnName = "m_caStockNo"
        myDataTable.Columns.Add(myDataColumn)

        myDataColumn = New DataColumn()
        myDataColumn.DataType = Type.[GetType]("System.String")
        myDataColumn.ColumnName = "m_caStockName"
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
        myDataColumn.DataType = Type.[GetType]("System.Double")
        myDataColumn.ColumnName = "m_dSettlePrice"
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
        myDataColumn.DataType = Type.[GetType]("System.Int64")
        myDataColumn.ColumnName = "m_nTQty"
        myDataTable.Columns.Add(myDataColumn)

        myDataTable.PrimaryKey = New DataColumn() {myDataTable.Columns("m_sStockidx")}

        Return myDataTable
    End Function

    Private Sub OnUpDateDataQuote(ByVal Foreign As FOREIGN)
        Dim sStockIdx As Short = Foreign.m_sStockidx

        Dim drFind As DataRow = m_dtForeigns.Rows.Find(sStockIdx)
        If drFind Is Nothing Then
            Dim myDataRow As DataRow = m_dtForeigns.NewRow()

            myDataRow("m_sStockidx") = Foreign.m_sStockidx
            myDataRow("m_sDecimal") = Foreign.m_sDecimal
            myDataRow("m_nDenominator") = Foreign.m_nDenominator
            myDataRow("m_cMarketNo") = Foreign.m_cMarketNo.Trim()
            myDataRow("m_caExchangeNo") = Foreign.m_caExchangeNo.Trim()
            myDataRow("m_caExchangeName") = Foreign.m_caExchangeName.Trim()
            myDataRow("m_caStockNo") = Foreign.m_caStockNo.Trim()
            myDataRow("m_caStockName") = Foreign.m_caStockName.Trim()

            myDataRow("m_nOpen") = Foreign.m_nOpen / (Math.Pow(10, Foreign.m_sDecimal))
            myDataRow("m_nHigh") = Foreign.m_nHigh / (Math.Pow(10, Foreign.m_sDecimal))
            myDataRow("m_nLow") = Foreign.m_nLow / (Math.Pow(10, Foreign.m_sDecimal))
            myDataRow("m_nClose") = Foreign.m_nClose / (Math.Pow(10, Foreign.m_sDecimal))
            myDataRow("m_dSettlePrice") = Foreign.m_dSettlePrice / (Math.Pow(10, Foreign.m_sDecimal))

            myDataRow("m_nTickQty") = Foreign.m_nTickQty
            myDataRow("m_nRef") = Foreign.m_nRef / (Math.Pow(10, Foreign.m_sDecimal))
            myDataRow("m_nBid") = Foreign.m_nBid / (Math.Pow(10, Foreign.m_sDecimal))
            myDataRow("m_nBc") = Foreign.m_nBc
            myDataRow("m_nAsk") = Foreign.m_nAsk
            myDataRow("m_nAc") = Foreign.m_nAc / (Math.Pow(10, Foreign.m_sDecimal))
            myDataRow("m_nTQty") = Foreign.m_nTQty

            m_dtForeigns.Rows.Add(myDataRow)
        Else
            drFind("m_sStockidx") = Foreign.m_sStockidx
            drFind("m_sDecimal") = Foreign.m_sDecimal
            drFind("m_nDenominator") = Foreign.m_nDenominator
            drFind("m_cMarketNo") = Foreign.m_cMarketNo.Trim()
            drFind("m_caExchangeNo") = Foreign.m_caExchangeNo.Trim()
            drFind("m_caExchangeName") = Foreign.m_caExchangeName.Trim()
            drFind("m_caStockNo") = Foreign.m_caStockNo.Trim()
            drFind("m_caStockName") = Foreign.m_caStockName.Trim()

            drFind("m_nOpen") = Foreign.m_nOpen / (Math.Pow(10, Foreign.m_sDecimal))
            drFind("m_nHigh") = Foreign.m_nHigh / (Math.Pow(10, Foreign.m_sDecimal))
            drFind("m_nLow") = Foreign.m_nLow / (Math.Pow(10, Foreign.m_sDecimal))
            drFind("m_nClose") = Foreign.m_nClose / (Math.Pow(10, Foreign.m_sDecimal))
            drFind("m_dSettlePrice") = Foreign.m_dSettlePrice / (Math.Pow(10, Foreign.m_sDecimal))

            drFind("m_nTickQty") = Foreign.m_nTickQty
            drFind("m_nRef") = Foreign.m_nRef / (Math.Pow(10, Foreign.m_sDecimal))
            drFind("m_nBid") = Foreign.m_nBid / (Math.Pow(10, Foreign.m_sDecimal))
            drFind("m_nBc") = Foreign.m_nBc
            drFind("m_nAsk") = Foreign.m_nAsk / (Math.Pow(10, Foreign.m_sDecimal))
            drFind("m_nAc") = Foreign.m_nAc
            drFind("m_nTQty") = Foreign.m_nTQty
        End If
    End Sub


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

    Private Sub InsertBest5(ByVal Best5 As BEST5)
        If m_dtBest5Ask.Rows.Count = 0 AndAlso m_dtBest5Bid.Rows.Count = 0 Then
            Dim myDataRow As DataRow

            myDataRow = m_dtBest5Ask.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nAskQty1
            myDataRow("m_nAsk") = Best5.m_nAsk1
            m_dtBest5Ask.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Ask.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nAskQty2
            myDataRow("m_nAsk") = Best5.m_nAsk2
            m_dtBest5Ask.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Ask.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nAskQty3
            myDataRow("m_nAsk") = Best5.m_nAsk3
            m_dtBest5Ask.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Ask.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nAskQty4
            myDataRow("m_nAsk") = Best5.m_nAsk4
            m_dtBest5Ask.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Ask.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nAskQty5
            myDataRow("m_nAsk") = Best5.m_nAsk5
            m_dtBest5Ask.Rows.Add(myDataRow)



            myDataRow = m_dtBest5Bid.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nBidQty1
            myDataRow("m_nAsk") = Best5.m_nBid1
            m_dtBest5Bid.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Bid.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nBidQty2
            myDataRow("m_nAsk") = Best5.m_nBid2
            m_dtBest5Bid.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Bid.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nBidQty3
            myDataRow("m_nAsk") = Best5.m_nBid3
            m_dtBest5Bid.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Bid.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nBidQty4
            myDataRow("m_nAsk") = Best5.m_nBid4
            m_dtBest5Bid.Rows.Add(myDataRow)

            myDataRow = m_dtBest5Bid.NewRow()
            myDataRow("m_nAskQty") = Best5.m_nBidQty5
            myDataRow("m_nAsk") = Best5.m_nBid5

            m_dtBest5Bid.Rows.Add(myDataRow)
        Else
            m_dtBest5Ask.Rows(0)("m_nAskQty") = Best5.m_nAskQty1
            m_dtBest5Ask.Rows(0)("m_nAsk") = Best5.m_nAsk1

            m_dtBest5Ask.Rows(1)("m_nAskQty") = Best5.m_nAskQty2
            m_dtBest5Ask.Rows(1)("m_nAsk") = Best5.m_nAsk2

            m_dtBest5Ask.Rows(2)("m_nAskQty") = Best5.m_nAskQty3
            m_dtBest5Ask.Rows(2)("m_nAsk") = Best5.m_nAsk3

            m_dtBest5Ask.Rows(3)("m_nAskQty") = Best5.m_nAskQty4
            m_dtBest5Ask.Rows(3)("m_nAsk") = Best5.m_nAsk4

            m_dtBest5Ask.Rows(4)("m_nAskQty") = Best5.m_nAskQty5
            m_dtBest5Ask.Rows(4)("m_nAsk") = Best5.m_nAsk5


            m_dtBest5Bid.Rows(0)("m_nAskQty") = Best5.m_nBidQty1
            m_dtBest5Bid.Rows(0)("m_nAsk") = Best5.m_nBid1

            m_dtBest5Bid.Rows(1)("m_nAskQty") = Best5.m_nBidQty2
            m_dtBest5Bid.Rows(1)("m_nAsk") = Best5.m_nBid2

            m_dtBest5Bid.Rows(2)("m_nAskQty") = Best5.m_nBidQty3
            m_dtBest5Bid.Rows(2)("m_nAsk") = Best5.m_nBid3

            m_dtBest5Bid.Rows(3)("m_nAskQty") = Best5.m_nBidQty4
            m_dtBest5Bid.Rows(3)("m_nAsk") = Best5.m_nBid4

            m_dtBest5Bid.Rows(4)("m_nAskQty") = Best5.m_nBidQty5
            m_dtBest5Bid.Rows(4)("m_nAsk") = Best5.m_nBid5
        End If
    End Sub
#End Region

    
End Class
