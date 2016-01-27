Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class OverseaFutureProduct

    Private Sub OverseaFutureProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim m_nCode As Integer

        Dim fOnOverseaFuture As New FOnGetBSTR(AddressOf OnOverseaFuture)
        m_nCode = Functions.RegisterOnOverseaFuturesCallBack(fOnOverseaFuture)
        m_nCode = Functions.GetOverseaFutures()

    End Sub

    Public Sub OnOverseaFuture(ByVal strMsg As String)
        Dim rows As DataGridViewRowCollection = GridProducts.Rows

        Dim strRowData As String() = strMsg.Split(";"c)
        rows.Add(strRowData)
    End Sub
End Class