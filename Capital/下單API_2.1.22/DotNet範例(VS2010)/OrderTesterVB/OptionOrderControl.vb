Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class OptionOrderControl
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



    Private Sub btnSendOptionOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendOptionOrder.Click
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

        Dim strMessage As New StringBuilder()
        strMessage.Length = 1024
        Dim nSiz As Int32 = 1024

        m_nCode = Functions.SendOptionOrder(m_UserAccount, strFutureNo, nPeriod, nFlag, nBidAsk, strPrice, _
         nQty, strMessage, nSiz)

        m_strMessage = strMessage.ToString()

        RaiseEvent GetMessage("OptionOrder", m_nCode, m_strMessage)

        strMessage = Nothing

    End Sub

    Private Sub btnSendOptionOrderAsync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendOptionOrderAsync.Click
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

        m_nCode = Functions.SendOptionOrderAsync(m_UserAccount, strFutureNo, nPeriod, nFlag, nBidAsk, strPrice, _
         nQty)

        RaiseEvent GetMessage("OptionOrderAsync", m_nCode, "")

    End Sub

    Private Sub btnCancelOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelOrder.Click
        Dim strStcokNo As String = txtCancelStockNo.Text.Trim()

        If strStcokNo = "" Then
            Dim myResult As DialogResult = MessageBox.Show("未輸入商品代碼會取消所有預約單，是否取消?", "取消預約單", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If myResult = DialogResult.Yes Then
                m_nCode = Functions.CancelOrderByStockNo(m_UserAccount, strStcokNo)

                RaiseEvent GetMessage("CancelOrderByStockNo", m_nCode, "")
            End If
        Else
            m_nCode = Functions.CancelOrderByStockNo(m_UserAccount, strStcokNo)

            RaiseEvent GetMessage("CancelOrderByStockNo", m_nCode, "")
        End If

    End Sub

    Private Sub btnCancelOrderBySeqNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelOrderBySeqNo.Click
        Dim strSeqNo As String = txtCancelSeqNo.Text.Trim()

        m_nCode = Functions.CancelOrderBySeqNo(m_UserAccount, strSeqNo)

        RaiseEvent GetMessage("CancelOrderBySeqNo", m_nCode, "")

    End Sub
#End Region
End Class
