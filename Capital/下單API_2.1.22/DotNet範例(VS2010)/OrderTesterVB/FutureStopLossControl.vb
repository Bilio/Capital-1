Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class FutureStopLossControl
#Region "Define Variable"
    '----------------------------------------------------------------------
    ' Define Variable
    '----------------------------------------------------------------------
    Private m_nCode As Integer
    Public m_strMessage As String

    Public Delegate Sub MyMessageHandler(ByVal strType As String, ByVal nCode As Integer, ByVal strMessage As String)
    Public Event GetMessage As MyMessageHandler

    Private m_UserAccount As String = ""
    Public Property UserAccount() As String
        Get
            Return m_UserAccount
        End Get
        Set(ByVal value As String)
            m_UserAccount = value
        End Set
    End Property

#End Region

#Region "Custom Method"
    '----------------------------------------------------------------------
    ' Custom Method
    '----------------------------------------------------------------------
    Public Sub OnStopLossReport(ByVal StopLossReport As String)
        RaiseEvent GetMessage("OnStopLossReport", 0, StopLossReport)
    End Sub
#End Region

#Region "Component Event"
    '----------------------------------------------------------------------
    ' Component Event
    '----------------------------------------------------------------------


    Private Sub btnSendFutureOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendFutureOrder.Click
        If m_UserAccount = "" Then
            MessageBox.Show("請選擇期貨帳號")
            Return
        End If

        Dim strFutureNo As String
        Dim nBidAsk As Integer
        Dim nPeriod As Integer
        Dim nFlag As Integer
        Dim strPrice As String
        Dim nQty As Integer
        Dim strTriggerPrice As String



        If txtStockNo.Text.Trim() = "" Then
            MessageBox.Show("請輸入商品代碼")
            Return
        End If
        strFutureNo = txtStockNo.Text.Trim()

        If boxBidAsk.SelectedIndex < 0 Then
            MessageBox.Show("請選擇買賣別")
            Return
        End If
        nBidAsk = boxBidAsk.SelectedIndex

        If boxPeriod.SelectedIndex < 0 Then
            MessageBox.Show("請選擇委託條件")
            Return
        End If
        nPeriod = boxPeriod.SelectedIndex

        If boxFlag.SelectedIndex < 0 Then
            MessageBox.Show("請選擇當沖與否")
            Return
        End If
        nFlag = boxFlag.SelectedIndex

        Dim dPrice As Double = 0.0
        If Double.TryParse(txtPrice.Text.Trim(), dPrice) = False Then
            MessageBox.Show("委託價請輸入數字")
            Return
        End If
        strPrice = txtPrice.Text.Trim()

        If Integer.TryParse(txtQty.Text.Trim(), nQty) = False Then
            MessageBox.Show("委託量請輸入數字")
            Return
        End If

        If txtTriggerPrice.Text.Trim() = "" Then
            MessageBox.Show("請輸入商品代碼")
            Return
        End If
        strTriggerPrice = txtTriggerPrice.Text.Trim()



        Dim strMessage As New StringBuilder()
        strMessage.Length = 1024
        Dim nSiz As Int32 = 1024

        m_nCode = Functions.SendFutureStopLoss(m_UserAccount, strFutureNo, nPeriod, nFlag, nBidAsk, strPrice, _
         nQty, strTriggerPrice, strMessage, nSiz)

        m_strMessage = strMessage.ToString()

        RaiseEvent GetMessage("FutureStopLoss", m_nCode, m_strMessage)

        strMessage = Nothing

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If m_UserAccount = "" Then
            MessageBox.Show("請選擇期貨帳號")
            Return
        End If

        Dim strBookNo As String

        If txtBookNo.Text.Trim() = "" Then
            MessageBox.Show("請輸入委託書號")
            Return
        End If
        strBookNo = txtBookNo.Text.Trim()


        Dim strMessage As New StringBuilder()
        strMessage.Length = 1024
        Dim nSiz As Int32 = 1024

        m_nCode = Functions.CancelFutureStopLoss(m_UserAccount, strBookNo, "0", "0", "0", "0", _
         "0", "0", "0", strMessage, nSiz)

        m_strMessage = strMessage.ToString()

        RaiseEvent GetMessage("CancelFutureStopLoss", m_nCode, m_strMessage)

        strMessage = Nothing

    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        If m_UserAccount = "" Then
            MessageBox.Show("請選擇期貨帳號")
            Return
        End If

        Dim nStatus As Integer = 0

        If boxReport.SelectedIndex >= 0 Then
            nStatus = boxReport.SelectedIndex
        End If

        Dim strType As String = boxKind.Text


        Dim fOnStopLossReport As New FOnGetBSTR(AddressOf OnStopLossReport)
        m_nCode = Functions.RegisterOnStopLossReportCallBack(fOnStopLossReport)
        m_nCode = Functions.GetStopLossReport(m_UserAccount, nStatus, strType)

        If m_nCode <> 0 Then
            RaiseEvent GetMessage("GetStopLossReport", m_nCode, "")
        End If

    End Sub
#End Region
End Class
