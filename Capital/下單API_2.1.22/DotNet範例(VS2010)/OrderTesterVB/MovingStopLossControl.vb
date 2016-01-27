Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class MovingStopLossControl
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

#Region "Component Event"
    '----------------------------------------------------------------------
    ' Component Event
    '----------------------------------------------------------------------
#End Region

    Private Sub btnSendMovingOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMovingOrder.Click
        If m_UserAccount = "" Then
            MessageBox.Show("請選擇期貨帳號")
            Return
        End If

        Dim strFutureNo As String
        Dim nBidAsk As Integer
        Dim nPeriod As Integer
        Dim nFlag As Integer
        Dim strMovingPoint As String
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

        If txtMovingPoint.Text.Trim() = "" Then
            MessageBox.Show("請輸入移動點數")
            Return
        End If
        strMovingPoint = txtMovingPoint.Text.Trim()

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

        m_nCode = Functions.SendMovingStopLoss(m_UserAccount, strFutureNo, nPeriod, nFlag, nBidAsk, strTriggerPrice, _
         nQty, strMovingPoint, strMessage, nSiz)

        m_strMessage = strMessage.ToString()

        RaiseEvent GetMessage("MovingStopLoss", m_nCode, m_strMessage)

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

        m_nCode = Functions.CancelMovingStopLoss(m_UserAccount, strBookNo, "0", "0", "0", "0", _
         "0", "0", "0", strMessage, nSiz)

        m_strMessage = strMessage.ToString()

        RaiseEvent GetMessage("CancelMovingStopLoss", m_nCode, m_strMessage)

    End Sub
End Class
