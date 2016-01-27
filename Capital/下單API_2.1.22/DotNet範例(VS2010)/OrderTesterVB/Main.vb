Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Security.Permissions

Public Class Main

#Region "Define Variable"
    '----------------------------------------------------------------------
    ' Define Variable
    '----------------------------------------------------------------------
    Private m_OrderAsync As New Dictionary(Of String, String)()
    Private Delegate Sub InvokeSendMessage(ByVal state As String)
    Private Delegate Sub ConnectReplyServer(ByVal state As String)

    Private fData As FOnData
    Private fOrderAsync As FOnOrderAsyncReport
    Private fConnect As FOnConnect
    Private fDisconnect As FOnConnect
    Private fComplete As FOnComplete
    Private fOnExecutionReport As FOnGetExecutionReoprt

    Private m_strLoginID As String = ""
    Private m_strData As String = ""
    Private m_nCode As Integer = 0
    Private m_bDisconnect As Boolean = False

#End Region

#Region "CallBack Function"
    '----------------------------------------------------------------------
    ' CallBack Function
    '----------------------------------------------------------------------

    'Account CallBack Function
    Public Sub OnAccount(ByVal bstrData As String)
        Dim strValues As String()
        Dim strAccount As String

        strValues = bstrData.Split(","c)
        strAccount = strValues(1) & strValues(3)

        If strValues(0) = "TS" Then
            boxStockAccount.Items.Add(strAccount)
            boxExecutionAccount.Items.Add("證券 " & strAccount)
        ElseIf strValues(0) = "TF" Then
            boxFutureAccount.Items.Add(strAccount)
            boxExecutionAccount.Items.Add("期貨 " & strAccount)
        ElseIf strValues(0) = "OF" Then
            boxOSFutureAccount.Items.Add(strAccount)
        ElseIf strValues(0) = "OS" Then
            boxOSStockAccount.Items.Add(strAccount)
        End If

        WriteInfo(bstrData)
    End Sub

    'Connect CallBack Function
    Public Sub OnConnect(ByVal strID As String, ByVal nErrorCode As Integer)
        Dim strInfo As String = "回報連線 " & strID & "        Code: " & GetApiCodeDefine(nErrorCode)

        WriteInfo(strInfo)

        lblConnect.ForeColor = Color.Green
    End Sub

    'Disconnect CallBack Function
    Public Sub OnDisconnect(ByVal strID As String, ByVal nErrorCode As Integer)
        Dim strInfo As String = "回報斷線 " & strID & "       Code: " & GetApiCodeDefine(nErrorCode) & " 五秒後重新連線 "

        Me.Invoke(New ConnectReplyServer(AddressOf Me.ReConnectReplyServer), New Object() {strInfo})

        lblConnect.ForeColor = Color.Red
    End Sub

    'OnData CallBack Function
    Public Sub OnData(ByVal bstrData As IntPtr)
        Dim bstrmyData As IntPtr = bstrData
        Dim myDataItem As DataItem = DirectCast(Marshal.PtrToStructure(bstrmyData, GetType(DataItem)), DataItem)

        m_strData = String.Format("委託序號：{0}   市場類別：{1}   委託種類：{2}    錯誤：{3}   .........營業員代碼：{4}   來源：{5}", myDataItem.strKeyNo, myDataItem.strMarketType, myDataItem.strType, myDataItem.strOrderErr, myDataItem.strSaleNo, _
         myDataItem.strAgent)
        WriteInfo(m_strData)
        'this.Invoke(new InvokeSendMessage(this.WriteInfo), new object[] { m_strData });

        Marshal.FreeBSTR(bstrmyData)
    End Sub

    'OnComplete CallBack Function
    Public Sub OnComplete(ByVal nCode As Integer)
        Dim strInfo As String = "Server連線確認      Code: " & GetApiCodeDefine(nCode)

        WriteInfo(strInfo)

    End Sub

    'OnOrderAsync CallBack Function
    Public Sub OnOrderAsyncReport(ByVal nThreadID As Integer, ByVal nCode As Integer, ByVal strMessage As String)
        Dim strValue As String
        strValue = ""
        If m_OrderAsync.TryGetValue(nThreadID.ToString(), strValue) Then
            Dim strInfo As String = String.Format("{0}    ﹝Cocd﹞:{1}    ﹝Message﹞:{2} ", strValue, GetApiCodeDefine(nCode), strMessage)

            WriteInfo(strInfo)
        Else
            Dim strInfo As String = "Thread ID  Not Found " & nThreadID

            WriteInfo(strInfo)
        End If
    End Sub

#End Region

#Region "Custom Method"
    '----------------------------------------------------------------------
    ' Custom Method
    '----------------------------------------------------------------------

    Public Sub WriteInfo(ByVal strMsg As String)
        If listInformation.InvokeRequired = True Then
            Me.Invoke(New InvokeSendMessage(AddressOf Me.WriteInfo), New Object() {strMsg})
        Else
            listInformation.Items.Add(strMsg)

            listInformation.SelectedIndex = listInformation.Items.Count - 1


            'listInformation.HorizontalScrollbar = true;

            ' Create a Graphics object to use when determining the size of the largest item in the ListBox.
            Dim g As Graphics = listInformation.CreateGraphics()

            ' Determine the size for HorizontalExtent using the MeasureString method using the last item in the list.
            Dim hzSize As Integer = CInt(g.MeasureString(listInformation.Items(listInformation.Items.Count - 1).ToString(), listInformation.Font).Width)
            ' Set the HorizontalExtent property.
            listInformation.HorizontalExtent = hzSize
        End If
    End Sub

    Public Sub ReConnectReplyServer(ByVal strMsg As String)
        If m_bDisconnect = False Then
            WriteInfo(strMsg)

            timerConnect.Enabled = True
        End If
    End Sub

    Public Function GetApiCodeDefine(ByVal nCode As Integer) As String
        Dim strNCode As String = [Enum].GetName(GetType(ApiMessage), nCode)

        If strNCode = "" OrElse strNCode Is Nothing Then
            Return nCode.ToString()
        Else
            Return strNCode
        End If
    End Function

#End Region

    Private Sub btnInitialize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInitialize.Click
        Dim strPassword As String

        boxStockAccount.Items.Clear()
        boxFutureAccount.Items.Clear()
        boxOSStockAccount.Items.Clear()
        boxOSFutureAccount.Items.Clear()

        m_strLoginID = txtAccount.Text.Trim()
        strPassword = txtPassWord.Text.Trim()

        'Initialize SKOrderLib
        m_nCode = Functions.SKOrderLib_Initialize(m_strLoginID, strPassword)

        If m_nCode = 0 Then
            MessageBox.Show("Initialize Success")
        ElseIf m_nCode = 2003 Then
            MessageBox.Show("元件已初始過，無須重複執行")
        Else
            MessageBox.Show("Initialize Fail：code " & GetApiCodeDefine(m_nCode))
            Return
        End If

        'Initialize  Cert
        m_nCode = Functions.SKOrderLib_ReadCertByID(m_strLoginID)
        If m_nCode = 0 Then
            MessageBox.Show("ReadCert Success")
        End If

        'Get Account
        Dim fAccount As New FOnGetBSTR(AddressOf OnAccount)
        m_nCode = Functions.RegisterOnAccountCallBack(fAccount)
        m_nCode = Functions.GetUserAccount()

        'OrderAsync CallBack
        m_nCode = Functions.RegisterOnOrderAsyncReportCallBack(fOrderAsync)

        m_nCode = Functions.RegisterOnExecutionReportCallBack(fOnExecutionReport)

    End Sub

    Private Sub btnInitializeReply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInitializeReply.Click
        Dim strPassword As String

        m_strLoginID = txtAccount.Text.Trim()
        strPassword = txtPassWord.Text.Trim()

        'Initialize SKOrderLib
        m_nCode = Functions.SKReplyLib_Initialize(m_strLoginID, strPassword)

        If m_nCode = 0 Then
            MessageBox.Show("SKReplyLib_Initialize Success")
        ElseIf m_nCode = 2003 Then
            MessageBox.Show("元件已初始過，無須重複執行")
        Else
            MessageBox.Show("SKReplyLib_Initialize  Fail：code " & GetApiCodeDefine(m_nCode))
            Return
        End If

        'OnConnect CallBack
        m_nCode = Functions.RegisterOnConnectCallBack(fConnect)

        'OnDisconnect CallBack
        m_nCode = Functions.RegisterOnDisconnectCallBack(fDisconnect)

        'OnData CallBack
        m_nCode = Functions.RegisterOnDataCallBack(fData)

        'OnComplete CallBack
        m_nCode = Functions.RegisterOnCompleteCallBack(fComplete)

    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        m_bDisconnect = False

        m_nCode = Functions.SKReplyLib_IsConnectedByID(m_strLoginID)

        If m_nCode = 0 Then
            Functions.SKReplyLib_ConnectByID(m_strLoginID)
        End If

    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        m_bDisconnect = True

        m_nCode = Functions.SKReplyLib_CloseByID(m_strLoginID)

        WriteInfo("關閉回報 Code:" & GetApiCodeDefine(m_nCode))

    End Sub

    Private Sub StockOrderControl_GetMessage(ByVal strType As System.String, ByVal nCode As System.Int32, ByVal strMessage As System.String) Handles StockOrderControl.GetMessage, OverseaFutureOrderControl.GetMessage, OptionStopLossControl.GetMessage, OptionOrderControl.GetMessage, MovingStopLossControl.GetMessage, FutureStopLossControl.GetMessage, FutureOrderControl.GetMessage, ForeignStockOrderControl.GetMessage
        Dim strMsg As String

        If strMessage = "" Then
            strMsg = String.Format("{0}    ﹝Code﹞:{1}", strType, GetApiCodeDefine(nCode))
        Else
            strMsg = String.Format("{0}    ﹝Code﹞:{1}    ﹝Message﹞:{2}", strType, GetApiCodeDefine(nCode), strMessage)
        End If

        WriteInfo(strMsg)

        If strType = "StockOrderAsync" OrElse strType = "FutureOrderAsync" OrElse strType = "OptionOrderAsync" OrElse strType = "ForeignStockOrderAsync" OrElse strType = "OverseaFutureOrderAsync" Then
            Dim strValue As String

            strValue = ""
            If Not m_OrderAsync.TryGetValue(nCode.ToString(), strValue) Then
                m_OrderAsync.Add(nCode.ToString(), strType)
            End If
        End If

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fData = New FOnData(AddressOf OnData)
        GC.KeepAlive(fData)

        fOrderAsync = New FOnOrderAsyncReport(AddressOf OnOrderAsyncReport)
        GC.KeepAlive(fOrderAsync)

        fConnect = New FOnConnect(AddressOf OnConnect)
        GC.KeepAlive(fConnect)

        fDisconnect = New FOnConnect(AddressOf OnDisconnect)
        GC.KeepAlive(fDisconnect)

        fComplete = New FOnComplete(AddressOf OnComplete)
        GC.KeepAlive(fComplete)

        fOnExecutionReport = New FOnGetExecutionReoprt(AddressOf OnExecutionReport)
        GC.KeepAlive(fOnExecutionReport)
        GC.SuppressFinalize(fOnExecutionReport)

        boxExecutionAccount.SelectedIndex = 0
        boxCount.SelectedIndex = 0
        boxMarket.SelectedIndex = 0
        boxBuySell.SelectedIndex = 0

    End Sub

    Private Sub boxStockAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxStockAccount.SelectedIndexChanged
        StockOrderControl.UserAccount = boxStockAccount.Text
    End Sub

    Private Sub boxFutureAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxFutureAccount.SelectedIndexChanged
        FutureOrderControl.UserAccount = boxFutureAccount.Text
        OptionOrderControl.UserAccount = boxFutureAccount.Text
        FutureStopLossControl.UserAccount = boxFutureAccount.Text
        MovingStopLossControl.UserAccount = boxFutureAccount.Text
        OptionStopLossControl.UserAccount = boxFutureAccount.Text
    End Sub

    Private Sub boxOSFutureAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxOSFutureAccount.SelectedIndexChanged
        OverseaFutureOrderControl.UserAccount = boxOSFutureAccount.Text
    End Sub

    Private Sub boxOSStockAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxOSStockAccount.SelectedIndexChanged
        ForeignStockOrderControl.UserAccount = boxOSStockAccount.Text
    End Sub

    Public Sub OnExecutionReport(ByVal strData As String)
        Me.Invoke(New InvokeSendMessage(AddressOf InsertData), New Object() {strData})
    End Sub

    Public Sub InsertData(ByVal strData As String)
        Dim split As String() = strData.Split(New [Char]() {","c})

        Dim myListItem As New ListViewItem(split)

        If tabExecutionReport.SelectedIndex = 0 Then
            listReport1.Items.Add(myListItem)
        ElseIf tabExecutionReport.SelectedIndex = 1 Then
            listReport2.Items.Add(myListItem)
        ElseIf tabExecutionReport.SelectedIndex = 2 Then
            listReport3.Items.Add(myListItem)
        ElseIf tabExecutionReport.SelectedIndex = 3 Then
            listReport4.Items.Add(myListItem)
        End If
    End Sub


    Private Sub btnQueryExecution_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryExecution.Click
        listReport1.Items.Clear()
        listReport2.Items.Clear()
        listReport3.Items.Clear()
        listReport4.Items.Clear()

        Dim strAccount As String = "0"
        If boxExecutionAccount.SelectedIndex <> 0 Then
            Dim Account As String() = boxExecutionAccount.Text.Trim().Split(New [Char]() {" "c})


            strAccount = Account(1)
        End If

        Dim strStockNo As String = txtStockNo.Text.Trim()

        If strStockNo = "" Then
            strStockNo = "0"
        End If

        Dim nMarket As Integer = boxMarket.SelectedIndex
        Dim nBuySell As Integer = boxBuySell.SelectedIndex
        Dim nDataNum As Integer = boxCount.SelectedIndex
        Dim nType As Integer = tabExecutionReport.SelectedIndex + 1

        m_nCode = Functions.GetExecutionReport(strAccount, strStockNo, nMarket, nBuySell, nDataNum, nType)

        If m_nCode = 0 Then
            lblExecutionMsg.Text = "查詢成功"
        Else
            lblExecutionMsg.Text = "查詢失敗 Code：" & m_nCode.ToString()
        End If

    End Sub
End Class
