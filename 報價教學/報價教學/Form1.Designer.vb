<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnWriteQuote = New System.Windows.Forms.Button()
        Me.cbxOTC = New System.Windows.Forms.CheckBox()
        Me.cbxTWSE = New System.Windows.Forms.CheckBox()
        Me.btnAllTicks = New System.Windows.Forms.Button()
        Me.btnShowQuote = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnShowTicks = New System.Windows.Forms.Button()
        Me.btnTicks = New System.Windows.Forms.Button()
        Me.tbxTickStock = New System.Windows.Forms.TextBox()
        Me.tbxTicks = New System.Windows.Forms.TextBox()
        Me.tbxQuote = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTEST = New System.Windows.Forms.Button()
        Me.tbxR = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(193, 14)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(37, 12)
        Me.lblTime.TabIndex = 38
        Me.lblTime.Text = "Label2"
        '
        'btnWriteQuote
        '
        Me.btnWriteQuote.Enabled = False
        Me.btnWriteQuote.Location = New System.Drawing.Point(7, 120)
        Me.btnWriteQuote.Name = "btnWriteQuote"
        Me.btnWriteQuote.Size = New System.Drawing.Size(63, 23)
        Me.btnWriteQuote.TabIndex = 35
        Me.btnWriteQuote.Text = "輸出報價"
        Me.btnWriteQuote.UseVisualStyleBackColor = True
        '
        'cbxOTC
        '
        Me.cbxOTC.AutoSize = True
        Me.cbxOTC.Enabled = False
        Me.cbxOTC.Location = New System.Drawing.Point(246, 52)
        Me.cbxOTC.Name = "cbxOTC"
        Me.cbxOTC.Size = New System.Drawing.Size(48, 16)
        Me.cbxOTC.TabIndex = 34
        Me.cbxOTC.Text = "上櫃"
        Me.cbxOTC.UseVisualStyleBackColor = True
        '
        'cbxTWSE
        '
        Me.cbxTWSE.AutoSize = True
        Me.cbxTWSE.Checked = True
        Me.cbxTWSE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxTWSE.Enabled = False
        Me.cbxTWSE.Location = New System.Drawing.Point(246, 30)
        Me.cbxTWSE.Name = "cbxTWSE"
        Me.cbxTWSE.Size = New System.Drawing.Size(48, 16)
        Me.cbxTWSE.TabIndex = 33
        Me.cbxTWSE.Text = "上市"
        Me.cbxTWSE.UseVisualStyleBackColor = True
        '
        'btnAllTicks
        '
        Me.btnAllTicks.Enabled = False
        Me.btnAllTicks.Location = New System.Drawing.Point(7, 178)
        Me.btnAllTicks.Name = "btnAllTicks"
        Me.btnAllTicks.Size = New System.Drawing.Size(63, 23)
        Me.btnAllTicks.TabIndex = 32
        Me.btnAllTicks.Text = "全部回補"
        Me.btnAllTicks.UseVisualStyleBackColor = True
        '
        'btnShowQuote
        '
        Me.btnShowQuote.Location = New System.Drawing.Point(157, 150)
        Me.btnShowQuote.Name = "btnShowQuote"
        Me.btnShowQuote.Size = New System.Drawing.Size(75, 23)
        Me.btnShowQuote.TabIndex = 30
        Me.btnShowQuote.Text = "顯示報價"
        Me.btnShowQuote.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(244, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "增加選股"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnShowTicks
        '
        Me.btnShowTicks.Location = New System.Drawing.Point(238, 150)
        Me.btnShowTicks.Name = "btnShowTicks"
        Me.btnShowTicks.Size = New System.Drawing.Size(75, 23)
        Me.btnShowTicks.TabIndex = 29
        Me.btnShowTicks.Text = "顯示Ticks"
        Me.btnShowTicks.UseVisualStyleBackColor = True
        '
        'btnTicks
        '
        Me.btnTicks.Enabled = False
        Me.btnTicks.Location = New System.Drawing.Point(7, 150)
        Me.btnTicks.Name = "btnTicks"
        Me.btnTicks.Size = New System.Drawing.Size(63, 23)
        Me.btnTicks.TabIndex = 28
        Me.btnTicks.Text = "回補Ticks"
        Me.btnTicks.UseVisualStyleBackColor = True
        '
        'tbxTickStock
        '
        Me.tbxTickStock.Location = New System.Drawing.Point(76, 152)
        Me.tbxTickStock.Name = "tbxTickStock"
        Me.tbxTickStock.Size = New System.Drawing.Size(51, 22)
        Me.tbxTickStock.TabIndex = 27
        '
        'tbxTicks
        '
        Me.tbxTicks.Location = New System.Drawing.Point(100, 179)
        Me.tbxTicks.Name = "tbxTicks"
        Me.tbxTicks.Size = New System.Drawing.Size(213, 22)
        Me.tbxTicks.TabIndex = 26
        Me.tbxTicks.Text = "C:\Capital\Ticks.txt"
        '
        'tbxQuote
        '
        Me.tbxQuote.Location = New System.Drawing.Point(100, 121)
        Me.tbxQuote.Name = "tbxQuote"
        Me.tbxQuote.Size = New System.Drawing.Size(213, 22)
        Me.tbxQuote.TabIndex = 25
        Me.tbxQuote.Text = "C:\Capital\QuoteText.txt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "到"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "到"
        '
        'btnTEST
        '
        Me.btnTEST.Location = New System.Drawing.Point(246, 94)
        Me.btnTEST.Name = "btnTEST"
        Me.btnTEST.Size = New System.Drawing.Size(67, 23)
        Me.btnTEST.TabIndex = 21
        Me.btnTEST.Text = "TEST"
        Me.btnTEST.UseVisualStyleBackColor = True
        '
        'tbxR
        '
        Me.tbxR.Location = New System.Drawing.Point(10, 11)
        Me.tbxR.Multiline = True
        Me.tbxR.Name = "tbxR"
        Me.tbxR.Size = New System.Drawing.Size(223, 103)
        Me.tbxR.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 214)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnWriteQuote)
        Me.Controls.Add(Me.cbxOTC)
        Me.Controls.Add(Me.cbxTWSE)
        Me.Controls.Add(Me.btnAllTicks)
        Me.Controls.Add(Me.btnShowQuote)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnShowTicks)
        Me.Controls.Add(Me.btnTicks)
        Me.Controls.Add(Me.tbxTickStock)
        Me.Controls.Add(Me.tbxTicks)
        Me.Controls.Add(Me.tbxQuote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTEST)
        Me.Controls.Add(Me.tbxR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTime As Label
    Friend WithEvents btnWriteQuote As Button
    Friend WithEvents cbxOTC As CheckBox
    Friend WithEvents cbxTWSE As CheckBox
    Friend WithEvents btnAllTicks As Button
    Friend WithEvents btnShowQuote As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnShowTicks As Button
    Friend WithEvents btnTicks As Button
    Friend WithEvents tbxTickStock As TextBox
    Friend WithEvents tbxTicks As TextBox
    Friend WithEvents tbxQuote As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTEST As Button
    Friend WithEvents tbxR As TextBox
End Class
