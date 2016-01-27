<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FutureStopLossControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtStockNo = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtTriggerPrice = New System.Windows.Forms.TextBox()
        Me.boxBidAsk = New System.Windows.Forms.ComboBox()
        Me.boxPeriod = New System.Windows.Forms.ComboBox()
        Me.boxFlag = New System.Windows.Forms.ComboBox()
        Me.btnSendFutureOrder = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtBookNo = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.boxReportStatus = New System.Windows.Forms.GroupBox()
        Me.boxKind = New System.Windows.Forms.ComboBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.boxReport = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.boxReportStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSendFutureOrder)
        Me.GroupBox1.Controls.Add(Me.boxFlag)
        Me.GroupBox1.Controls.Add(Me.boxPeriod)
        Me.GroupBox1.Controls.Add(Me.boxBidAsk)
        Me.GroupBox1.Controls.Add(Me.txtTriggerPrice)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtStockNo)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "期貨停損單"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(569, 21)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(52, 15)
        Me.label7.TabIndex = 20
        Me.label7.Text = "觸發價"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(490, 21)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 15)
        Me.label6.TabIndex = 19
        Me.label6.Text = "委託量"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(391, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(67, 15)
        Me.label5.TabIndex = 18
        Me.label5.Text = "委託價格"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(293, 21)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(67, 15)
        Me.label4.TabIndex = 17
        Me.label4.Text = "當沖與否"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(192, 21)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 15)
        Me.label3.TabIndex = 16
        Me.label3.Text = "委託條件"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(105, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 15)
        Me.label2.TabIndex = 15
        Me.label2.Text = "買賣別"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 14
        Me.label1.Text = "商品代碼"
        '
        'txtStockNo
        '
        Me.txtStockNo.Location = New System.Drawing.Point(9, 39)
        Me.txtStockNo.Name = "txtStockNo"
        Me.txtStockNo.Size = New System.Drawing.Size(64, 25)
        Me.txtStockNo.TabIndex = 21
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(394, 39)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(64, 25)
        Me.txtPrice.TabIndex = 22
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(489, 39)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(57, 25)
        Me.txtQty.TabIndex = 23
        '
        'txtTriggerPrice
        '
        Me.txtTriggerPrice.Location = New System.Drawing.Point(570, 39)
        Me.txtTriggerPrice.Name = "txtTriggerPrice"
        Me.txtTriggerPrice.Size = New System.Drawing.Size(57, 25)
        Me.txtTriggerPrice.TabIndex = 24
        '
        'boxBidAsk
        '
        Me.boxBidAsk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxBidAsk.FormattingEnabled = True
        Me.boxBidAsk.Items.AddRange(New Object() {"買", "賣"})
        Me.boxBidAsk.Location = New System.Drawing.Point(108, 41)
        Me.boxBidAsk.Name = "boxBidAsk"
        Me.boxBidAsk.Size = New System.Drawing.Size(49, 23)
        Me.boxBidAsk.TabIndex = 25
        '
        'boxPeriod
        '
        Me.boxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxPeriod.FormattingEnabled = True
        Me.boxPeriod.Items.AddRange(New Object() {"ROD", "IOC", "FOK"})
        Me.boxPeriod.Location = New System.Drawing.Point(195, 41)
        Me.boxPeriod.Name = "boxPeriod"
        Me.boxPeriod.Size = New System.Drawing.Size(64, 23)
        Me.boxPeriod.TabIndex = 26
        '
        'boxFlag
        '
        Me.boxFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxFlag.FormattingEnabled = True
        Me.boxFlag.Items.AddRange(New Object() {"非當沖", "當沖"})
        Me.boxFlag.Location = New System.Drawing.Point(296, 41)
        Me.boxFlag.Name = "boxFlag"
        Me.boxFlag.Size = New System.Drawing.Size(64, 23)
        Me.boxFlag.TabIndex = 27
        '
        'btnSendFutureOrder
        '
        Me.btnSendFutureOrder.Location = New System.Drawing.Point(644, 21)
        Me.btnSendFutureOrder.Name = "btnSendFutureOrder"
        Me.btnSendFutureOrder.Size = New System.Drawing.Size(135, 43)
        Me.btnSendFutureOrder.TabIndex = 28
        Me.btnSendFutureOrder.Text = "SendFutureStopLossOrder"
        Me.btnSendFutureOrder.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.txtBookNo)
        Me.GroupBox2.Controls.Add(Me.label8)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 59)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "刪單"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(16, 25)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(67, 15)
        Me.label8.TabIndex = 1
        Me.label8.Text = "委託書號"
        '
        'txtBookNo
        '
        Me.txtBookNo.Location = New System.Drawing.Point(89, 22)
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.Size = New System.Drawing.Size(108, 25)
        Me.txtBookNo.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(220, 24)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(174, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CancelFutureStopLoss"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'boxReportStatus
        '
        Me.boxReportStatus.Controls.Add(Me.boxReport)
        Me.boxReportStatus.Controls.Add(Me.btnQuery)
        Me.boxReportStatus.Controls.Add(Me.boxKind)
        Me.boxReportStatus.Location = New System.Drawing.Point(3, 149)
        Me.boxReportStatus.Name = "boxReportStatus"
        Me.boxReportStatus.Size = New System.Drawing.Size(804, 60)
        Me.boxReportStatus.TabIndex = 2
        Me.boxReportStatus.TabStop = False
        Me.boxReportStatus.Text = "查詢"
        '
        'boxKind
        '
        Me.boxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxKind.FormattingEnabled = True
        Me.boxKind.Items.AddRange(New Object() {"STP", "MST", "OST"})
        Me.boxKind.Location = New System.Drawing.Point(108, 24)
        Me.boxKind.Name = "boxKind"
        Me.boxKind.Size = New System.Drawing.Size(89, 23)
        Me.boxKind.TabIndex = 1
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(220, 23)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(100, 23)
        Me.btnQuery.TabIndex = 2
        Me.btnQuery.Text = "查詢期貨停損"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'boxReport
        '
        Me.boxReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxReport.FormattingEnabled = True
        Me.boxReport.Items.AddRange(New Object() {"全部委託單", "有效委託單"})
        Me.boxReport.Location = New System.Drawing.Point(9, 23)
        Me.boxReport.Name = "boxReport"
        Me.boxReport.Size = New System.Drawing.Size(93, 23)
        Me.boxReport.TabIndex = 3
        '
        'FutureStopLossControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.boxReportStatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FutureStopLossControl"
        Me.Size = New System.Drawing.Size(810, 222)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.boxReportStatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents boxFlag As System.Windows.Forms.ComboBox
    Friend WithEvents boxPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents boxBidAsk As System.Windows.Forms.ComboBox
    Friend WithEvents txtTriggerPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtStockNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSendFutureOrder As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtBookNo As System.Windows.Forms.TextBox
    Friend WithEvents boxReportStatus As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents boxKind As System.Windows.Forms.ComboBox
    Friend WithEvents boxReport As System.Windows.Forms.ComboBox

End Class
