Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class TradeStationControl

#Region "Define Variable"
    '----------------------------------------------------------------------
    ' Define Variable
    '----------------------------------------------------------------------
    Private Delegate Sub InvokeSendMessage(ByVal state As String)
    Private fOnTSFilledOrder As FOnTSFilledOrder
    Private fOnTSActiveOrder As FOnTSActiveOrder
    Private fOnTSCanceledOrder As FOnTSCanceledOrder


#End Region

#Region "Custom Method"
    '----------------------------------------------------------------------
    ' Custom Method
    '----------------------------------------------------------------------

    Public Sub OnTSFilledOrder(ByVal bstrSymbol As String, ByVal bstrDescription As String, ByVal bstrOrderType As String, ByVal bstrOrder As String, ByVal lFillPrice As Integer, ByVal lSlippage As Integer, _
     ByVal dTimePlace As Double, ByVal dTimeFilled As Double, ByVal bstrStrategy As String, ByVal bstrSignal As String, ByVal bstrWorkspace As String, ByVal bstrInterval As String, _
     ByVal bstrPositionNumber As String, ByVal bstrOrderNumber As String)
        Try
            Dim strOrderMsg As String = "callback"

            strOrderMsg = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}", bstrSymbol.Trim(), bstrDescription.Trim(), bstrOrderType.Trim(), bstrOrder.Trim(), lFillPrice.ToString().Trim(), _
             lSlippage.ToString().Trim(), dTimePlace.ToString().Trim(), dTimeFilled.ToString().Trim(), bstrStrategy.Trim(), bstrSignal.Trim(), bstrWorkspace.Trim(), _
             bstrInterval.Trim(), bstrPositionNumber.Trim(), bstrOrderNumber.Trim())


            WriteInfo(DateTime.Now.ToString("hh:mm:ss") & "  FilledOrder：" & strOrderMsg)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub OnTSActiveOrder(ByVal bstrSymbol As String, ByVal bstrDescription As String, ByVal bstrOrderType As String, ByVal bstrOrder As String, ByVal lLastPrice As Integer, ByVal dTimePlaced As Double, _
     ByVal bstrStrategy As String, ByVal bstrSignal As String, ByVal bstrWorkspace As String, ByVal bstrInterval As String, ByVal bstrPositionNumber As String, ByVal bstrOrderNumber As String)
        Try
            Dim strOrderMsg As String = "callback"

            strOrderMsg = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", bstrSymbol.Trim(), bstrDescription.Trim(), bstrOrderType.Trim(), bstrOrder.Trim(), lLastPrice.ToString().Trim(), _
             dTimePlaced.ToString().Trim(), bstrStrategy.Trim(), bstrSignal.Trim(), bstrWorkspace.Trim(), bstrInterval.Trim(), bstrPositionNumber.Trim(), _
             bstrOrderNumber.Trim())



            WriteInfo(DateTime.Now.ToString("hh:mm:ss") & "  ActiveOrder：" & strOrderMsg)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub OnTSCanceledOrder(ByVal bstrSymbol As String, ByVal bstrDescription As String, ByVal bstrOrderType As String, ByVal bstrOrder As String, ByVal dTimePlaced As Double, ByVal dTimeCanceled As Double, _
     ByVal bstrStrategy As String, ByVal bstrSignal As String, ByVal bstrWorkspace As String, ByVal bstrInterval As String, ByVal bstrPositionNumber As String, ByVal bstrOrderNumber As String, _
     ByVal bstrCanceledNumber As String)
        Try
            Dim strOrderMsg As String = "callback"

            strOrderMsg = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}", bstrSymbol.Trim(), bstrDescription.Trim(), bstrOrderType.Trim(), bstrOrder.Trim(), dTimePlaced.ToString().Trim(), _
             dTimeCanceled.ToString().Trim(), bstrStrategy.Trim(), bstrSignal.Trim(), bstrWorkspace.Trim(), bstrInterval.Trim(), bstrPositionNumber.Trim(), _
             bstrOrderNumber.Trim(), bstrCanceledNumber.Trim())

            WriteInfo(DateTime.Now.ToString("hh:mm:ss") & "  CanceledOrder：" & strOrderMsg)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub WriteInfo(ByVal strMsg As String)
        Try
            If listTSInfo.InvokeRequired = True Then
                BeginInvoke(New InvokeSendMessage(AddressOf Me.WriteInfo), New Object() {strMsg})
            Else
                listTSInfo.Items.Add(strMsg.Trim())

                listTSInfo.SelectedIndex = listTSInfo.Items.Count - 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
#End Region

    Private Sub btnInitializeTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInitializeTS.Click
        Try
            Dim nCode As Integer

            nCode = Functions.SKOrderLib_InitializeTS("")

            If nCode = 0 OrElse nCode = 2002 Then
                lblInitialize.Text = "TS初始成功  "

                nCode = Functions.RegisterOnTSActiveOrderCallBack(fOnTSActiveOrder)

                If nCode <> 0 Then
                    lblInitialize.Text += " RegisterOnTSActiveOrderCallBack 失敗 Code: " & nCode.ToString()
                End If

                nCode = Functions.RegisterOnTSCanceledOrderCallBack(fOnTSCanceledOrder)
                If nCode <> 0 Then
                    lblInitialize.Text += " RegisterOnTSCanceledOrderCallBack 失敗 Code: " & nCode.ToString()
                End If

                nCode = Functions.RegisterOnTSFilledOrderCallBack(fOnTSFilledOrder)
                If nCode <> 0 Then
                    lblInitialize.Text += " RegisterOnTSFilledOrderCallBack 失敗 Code: " & nCode.ToString()
                End If
            Else
                lblInitialize.Text = "TS初始失敗 Code ：" & nCode.ToString()

            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
