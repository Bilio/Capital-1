Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class OverseaFutureOrderControl

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


    Private Sub btnSendOverseaFutureOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendOverseaFutureOrder.Click
        If m_UserAccount = "" Then
            MessageBox.Show("請選擇海期帳號")
            Return
        End If

        Dim strTradeName As String
        Dim strStockNo As String
        Dim strYearMonth As String
        Dim nBuySell As Integer
        Dim nNewClose As Integer
        Dim nDayTrade As Integer
        Dim nTradeType As Integer
        Dim nSpecialTradeType As Integer
        Dim strPrice As String
        Dim nQty As Integer

        If txtTradeNo.Text.Trim() = "" Then
            MessageBox.Show("請輸入交易所代號")
            Return
        End If
        strTradeName = txtTradeNo.Text.Trim()

        If txtStockNo.Text.Trim() = "" Then
            MessageBox.Show("請輸入商品代碼")
            Return
        End If
        strStockNo = txtStockNo.Text.Trim()

        If txtYearMonth.Text.Trim() = "" Then
            MessageBox.Show("請輸入年月")
            Return
        End If
        strYearMonth = txtYearMonth.Text.Trim()

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

        If boxBidAsk.SelectedIndex < 0 Then
            MessageBox.Show("請選擇買賣別")
            Return
        End If
        nBuySell = boxBidAsk.SelectedIndex

        If boxNewClose.SelectedIndex < 0 Then
            MessageBox.Show("請選擇倉別")
            Return
        End If
        nNewClose = boxNewClose.SelectedIndex

        If boxFlag.SelectedIndex < 0 Then
            MessageBox.Show("請選擇當沖與否")
            Return
        End If
        nDayTrade = boxFlag.SelectedIndex

        If boxPeriod.SelectedIndex < 0 Then
            MessageBox.Show("請選擇委託條件")
            Return
        End If
        nTradeType = boxPeriod.SelectedIndex

        If boxSpecialTradeType.SelectedIndex < 0 Then
            MessageBox.Show("請選擇特殊委託條件")
            Return
        End If
        nSpecialTradeType = boxSpecialTradeType.SelectedIndex

        'Log.Write(m_UserAccount + "," + strTradeName + "," + strStockNo + "," + strYearMonth + "," + nBuySell.ToString() + "," + nNewClose.ToString() + "," + nDayTrade.ToString() + "," + nTradeType.ToString() + "," + nSpecialTradeType.ToString() + "," + nQty.ToString() + "," + strPrice + "," + "0" + "," + "0" + "," + "0" + "... ");

        Dim strMessage As New StringBuilder()
        strMessage.Length = 1024
        Dim nSiz As Int32 = 1024

        m_nCode = Functions.SendOverseaFutureOrder(m_UserAccount, strTradeName, strStockNo, strYearMonth, nBuySell, nNewClose, _
         nDayTrade, nTradeType, nSpecialTradeType, nQty, strPrice, "0", _
         "0", "0", strMessage, nSiz)

        m_strMessage = strMessage.ToString()

        RaiseEvent GetMessage("SendOverseaFutureOrder", m_nCode, m_strMessage)
        strMessage = Nothing

    End Sub

    Private Sub btnSendOverseaFutureOrderAsync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendOverseaFutureOrderAsync.Click
        If m_UserAccount = "" Then
            MessageBox.Show("請選擇海期帳號")
            Return
        End If

        Dim strTradeName As String
        Dim strStockNo As String
        Dim strYearMonth As String
        Dim nBuySell As Integer
        Dim nNewClose As Integer
        Dim nDayTrade As Integer
        Dim nTradeType As Integer
        Dim nSpecialTradeType As Integer
        Dim strPrice As String
        Dim nQty As Integer

        If txtTradeNo.Text.Trim() = "" Then
            MessageBox.Show("請輸入交易所代號")
            Return
        End If
        strTradeName = txtTradeNo.Text.Trim()

        If txtStockNo.Text.Trim() = "" Then
            MessageBox.Show("請輸入商品代碼")
            Return
        End If
        strStockNo = txtStockNo.Text.Trim()

        If txtYearMonth.Text.Trim() = "" Then
            MessageBox.Show("請輸入年月")
            Return
        End If
        strYearMonth = txtYearMonth.Text.Trim()

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

        If boxBidAsk.SelectedIndex < 0 Then
            MessageBox.Show("請選擇買賣別")
            Return
        End If
        nBuySell = boxBidAsk.SelectedIndex

        If boxNewClose.SelectedIndex < 0 Then
            MessageBox.Show("請選擇倉別")
            Return
        End If
        nNewClose = boxNewClose.SelectedIndex

        If boxFlag.SelectedIndex < 0 Then
            MessageBox.Show("請選擇當沖與否")
            Return
        End If
        nDayTrade = boxFlag.SelectedIndex

        If boxPeriod.SelectedIndex < 0 Then
            MessageBox.Show("請選擇委託條件")
            Return
        End If
        nTradeType = boxPeriod.SelectedIndex

        If boxSpecialTradeType.SelectedIndex < 0 Then
            MessageBox.Show("請選擇特殊委託條件")
            Return
        End If
        nSpecialTradeType = boxSpecialTradeType.SelectedIndex


        m_nCode = Functions.SendOverseaFutureOrderAsync(m_UserAccount, strTradeName, strStockNo, strYearMonth, nBuySell, nNewClose, _
         nDayTrade, nTradeType, nSpecialTradeType, nQty, strPrice, "0", _
         "0", "0")

        RaiseEvent GetMessage("OverseaFutureOrderAsync", m_nCode, m_strMessage)

    End Sub

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        m_nCode = Functions.ReloadOverseaProducts()

        RaiseEvent GetMessage("ReloadOverseaProducts", m_nCode, "")

    End Sub

    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        m_nCode = Functions.GetOverseaCount()

        If m_nCode >= 0 Then
            txtCount.Text = m_nCode.ToString()

            lblIndext.Text = "商品序號( 0~" & (m_nCode - 1).ToString() & " )"
        Else
            RaiseEvent GetMessage("GetOverseaCount", m_nCode, "")
        End If

    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        If txtIndext.Text = "" Then
            MessageBox.Show("請輸入欲查詢商品序號")
            Return
        End If

        Dim nIndext As Integer = -1

        If Integer.TryParse(txtIndext.Text.Trim(), nIndext) = False Then
            MessageBox.Show("商品序號請輸入數字")
            Return
        End If

        Dim myProduct As New SOfComProduct
        Dim strMsg As String

        m_nCode = Functions.GetOverseaProducts(nIndext, myProduct)

        strMsg = String.Format("交易所代號:{0}  商品代號:{1}  商品年月:{2}  特殊條件:{3}  跳動點:{4}  分母:{5}  是否可當沖{6}", myProduct.strExchange, myProduct.strProductNo, myProduct.strYearMonth, myProduct.sSpecialTradeType, myProduct.dMinJump, _
         myProduct.nDenominator, myProduct.sDayTrade)

        myProduct = Nothing

        RaiseEvent GetMessage("GetOverseaProducts", m_nCode, strMsg)

    End Sub

    Private Sub btnQueryAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryAll.Click
        Dim myProduct As New OverseaFutureProduct()

        myProduct.Show()

    End Sub

    Private Sub btnCancelOrderBySeqNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelOrderBySeqNo.Click
        Dim strSeqNo As String = txtCancelSeqNo.Text.Trim()

        m_nCode = Functions.OverseaCancelOrderBySeqNo(m_UserAccount, strSeqNo)

        RaiseEvent GetMessage("OverseaCancelOrderBySeqNo", m_nCode, "")

    End Sub

    Private Sub btnDecreaseQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecreaseQty.Click
        Dim nQty As Integer

        If Integer.TryParse(txtDecreaseQty.Text.Trim(), nQty) Then
            Dim strSeqNo As String = txtCancelSeqNo.Text.Trim()

            m_nCode = Functions.DecreaseOrderBySeqNo(m_UserAccount, strSeqNo, nQty)

            RaiseEvent GetMessage("DecreaseOrderBySeqNo", m_nCode, "")
        Else
            MessageBox.Show("欲改數量請輸入數字")
        End If

    End Sub
End Class
