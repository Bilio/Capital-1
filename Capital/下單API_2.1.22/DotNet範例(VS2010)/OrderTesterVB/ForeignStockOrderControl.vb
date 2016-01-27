Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class ForeignStockOrderControl
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

    Private Sub btnSendForeignStockOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendForeignStockOrder.Click
        If m_UserAccount = "" Then
            MessageBox.Show("請選擇複委託帳號")
            Return
        End If

        Dim strExchangeNo As String = ""
        Dim strStockNo As String
        Dim nBidAsk As Integer
        Dim strPrice As String
        Dim nQty As Integer
        Dim strCurrency1 As String
        Dim strCurrency2 As String
        Dim strCurrency3 As String
        Dim nAccountType As Integer


        If boxAccountType.SelectedIndex < 0 Then
            MessageBox.Show("請選擇帳戶別")
            Return
        End If
        nAccountType = boxAccountType.SelectedIndex + 1

        If boxCurrency1.SelectedIndex < 0 Then
            MessageBox.Show("請至少選擇扣款幣別 1")
            Return
        End If
        strCurrency1 = boxCurrency1.Text
        strCurrency2 = boxCurrency2.Text
        strCurrency3 = boxCurrency3.Text

        If boxExchange.SelectedIndex < 0 Then
            MessageBox.Show("請選擇交易所")
            Return
        End If

        If boxExchange.SelectedIndex = 0 Then
            strExchangeNo = "US"
        ElseIf boxExchange.SelectedIndex = 1 Then
            strExchangeNo = "HK"
        End If

        If txtStockNo.Text.Trim() = "" Then
            MessageBox.Show("請輸入商品代碼")
            Return
        End If
        strStockNo = txtStockNo.Text.Trim()

        If boxBidAsk.SelectedIndex < 0 Then
            MessageBox.Show("請選擇買賣別")
            Return
        End If
        nBidAsk = boxBidAsk.SelectedIndex

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

        m_nCode = Functions.SendForeignStockOrder(m_UserAccount, strStockNo, strExchangeNo, nBidAsk, strPrice, nQty, _
         strCurrency1, strCurrency2, strCurrency3, nAccountType, strMessage, nSiz)

        m_strMessage = strMessage.ToString()

        RaiseEvent GetMessage("ForeignStockOrder", m_nCode, m_strMessage)

        strMessage = Nothing

    End Sub

    Private Sub btnSendForeignStockOrderAsync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendForeignStockOrderAsync.Click
        If m_UserAccount = "" Then
            MessageBox.Show("請選擇複委託帳號")
            Return
        End If

        Dim strExchangeNo As String = ""
        Dim strStockNo As String
        Dim nBidAsk As Integer
        Dim strPrice As String
        Dim nQty As Integer
        Dim strCurrency1 As String
        Dim strCurrency2 As String
        Dim strCurrency3 As String
        Dim nAccountType As Integer


        If boxAccountType.SelectedIndex < 0 Then
            MessageBox.Show("請選擇帳戶別")
            Return
        End If
        nAccountType = boxAccountType.SelectedIndex + 1

        If boxCurrency1.SelectedIndex < 0 Then
            MessageBox.Show("請至少選擇扣款幣別 1")
            Return
        End If
        strCurrency1 = boxCurrency1.Text
        strCurrency2 = boxCurrency2.Text
        strCurrency3 = boxCurrency3.Text

        If boxExchange.SelectedIndex < 0 Then
            MessageBox.Show("請選擇交易所")
            Return
        End If

        If boxExchange.SelectedIndex = 0 Then
            strExchangeNo = "US"
        ElseIf boxExchange.SelectedIndex = 1 Then
            strExchangeNo = "HK"
        End If

        If txtStockNo.Text.Trim() = "" Then
            MessageBox.Show("請輸入商品代碼")
            Return
        End If
        strStockNo = txtStockNo.Text.Trim()

        If boxBidAsk.SelectedIndex < 0 Then
            MessageBox.Show("請選擇買賣別")
            Return
        End If
        nBidAsk = boxBidAsk.SelectedIndex

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

        m_nCode = Functions.SendForeignStockOrderAsync(m_UserAccount, strStockNo, strExchangeNo, nBidAsk, strPrice, nQty, _
         strCurrency1, strCurrency2, strCurrency3, nAccountType)

        RaiseEvent GetMessage("ForeignStockOrderAsync", m_nCode, "非同步委託")

    End Sub

    Private Sub btnCancelOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelOrder.Click
        Dim strExchangeNo As String = ""
        Dim strBookNo As String = ""

        If m_UserAccount = "" Then
            MessageBox.Show("請選擇複委託帳號")
            Return
        End If

        If boxExchange.SelectedIndex < 0 Then
            MessageBox.Show("請選擇交易所")
            Return
        End If

        If boxExchange.SelectedIndex = 0 Then
            strExchangeNo = "US"
        ElseIf boxExchange.SelectedIndex = 1 Then
            strExchangeNo = "HK"
        End If

        If txtCancelBookNo.Text.Trim() = "" Then
            MessageBox.Show("請輸入欲刪除的委託書號")
            Return
        End If
        strBookNo = txtCancelBookNo.Text.Trim()


        Dim strMessage As New StringBuilder()
        strMessage.Length = 1024
        Dim nSiz As Int32 = 1024

        m_nCode = Functions.CancelForeignStockOrderByBookNo(m_UserAccount, strBookNo, strExchangeNo, strMessage, nSiz)

        m_strMessage = strMessage.ToString()

        RaiseEvent GetMessage("CancelForeignStockOrder By BookNo", m_nCode, m_strMessage)

        strMessage = Nothing

    End Sub

    Private Sub btnCancelOrderBySeqNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelOrderBySeqNo.Click
        Dim strExchangeNo As String = ""
        Dim strSeqNo As String = ""

        If m_UserAccount = "" Then
            MessageBox.Show("請選擇複委託帳號")
            Return
        End If

        If boxExchange.SelectedIndex < 0 Then
            MessageBox.Show("請選擇交易所")
            Return
        End If

        If boxExchange.SelectedIndex = 0 Then
            strExchangeNo = "US"
        ElseIf boxExchange.SelectedIndex = 1 Then
            strExchangeNo = "HK"
        End If

        If txtCancelSeqNo.Text.Trim() = "" Then
            MessageBox.Show("請輸入欲刪除的委託序號")
            Return
        End If
        strSeqNo = txtCancelSeqNo.Text.Trim()


        Dim strMessage As New StringBuilder()
        strMessage.Length = 1024
        Dim nSiz As Int32 = 1024

        m_nCode = Functions.CancelForeignStockOrderBySeqNo(m_UserAccount, strSeqNo, strExchangeNo, strMessage, nSiz)

        m_strMessage = strMessage.ToString()

        RaiseEvent GetMessage("CancelForeignStockOrder By SqlNo", m_nCode, m_strMessage)
        strMessage = Nothing

    End Sub
End Class
