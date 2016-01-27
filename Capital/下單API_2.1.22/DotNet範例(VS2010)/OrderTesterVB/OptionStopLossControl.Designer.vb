<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionStopLossControl
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
        Me.btnSendMovingOrder = New System.Windows.Forms.Button()
        Me.txtTriggerPrice = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtMovingPoint = New System.Windows.Forms.TextBox()
        Me.boxFlag = New System.Windows.Forms.ComboBox()
        Me.boxPeriod = New System.Windows.Forms.ComboBox()
        Me.boxBidAsk = New System.Windows.Forms.ComboBox()
        Me.txtStockNo = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtBookNo = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSendMovingOrder)
        Me.GroupBox1.Controls.Add(Me.txtTriggerPrice)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtMovingPoint)
        Me.GroupBox1.Controls.Add(Me.boxFlag)
        Me.GroupBox1.Controls.Add(Me.boxPeriod)
        Me.GroupBox1.Controls.Add(Me.boxBidAsk)
        Me.GroupBox1.Controls.Add(Me.txtStockNo)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "選擇權停損單"
        '
        'btnSendMovingOrder
        '
        Me.btnSendMovingOrder.Location = New System.Drawing.Point(652, 24)
        Me.btnSendMovingOrder.Name = "btnSendMovingOrder"
        Me.btnSendMovingOrder.Size = New System.Drawing.Size(146, 40)
        Me.btnSendMovingOrder.TabIndex = 30
        Me.btnSendMovingOrder.Text = "SendMovingStopLossOrder"
        Me.btnSendMovingOrder.UseVisualStyleBackColor = True
        '
        'txtTriggerPrice
        '
        Me.txtTriggerPrice.Location = New System.Drawing.Point(570, 41)
        Me.txtTriggerPrice.Name = "txtTriggerPrice"
        Me.txtTriggerPrice.Size = New System.Drawing.Size(63, 25)
        Me.txtTriggerPrice.TabIndex = 29
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(489, 41)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(57, 25)
        Me.txtQty.TabIndex = 28
        '
        'txtMovingPoint
        '
        Me.txtMovingPoint.Location = New System.Drawing.Point(395, 41)
        Me.txtMovingPoint.Name = "txtMovingPoint"
        Me.txtMovingPoint.Size = New System.Drawing.Size(64, 25)
        Me.txtMovingPoint.TabIndex = 27
        '
        'boxFlag
        '
        Me.boxFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxFlag.FormattingEnabled = True
        Me.boxFlag.Items.AddRange(New Object() {"新倉", "平倉", "自動"})
        Me.boxFlag.Location = New System.Drawing.Point(289, 41)
        Me.boxFlag.Name = "boxFlag"
        Me.boxFlag.Size = New System.Drawing.Size(65, 23)
        Me.boxFlag.TabIndex = 26
        '
        'boxPeriod
        '
        Me.boxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxPeriod.FormattingEnabled = True
        Me.boxPeriod.Items.AddRange(New Object() {"ROD", "IOC", "FOK"})
        Me.boxPeriod.Location = New System.Drawing.Point(195, 41)
        Me.boxPeriod.Name = "boxPeriod"
        Me.boxPeriod.Size = New System.Drawing.Size(64, 23)
        Me.boxPeriod.TabIndex = 25
        '
        'boxBidAsk
        '
        Me.boxBidAsk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxBidAsk.FormattingEnabled = True
        Me.boxBidAsk.Items.AddRange(New Object() {"買", "賣"})
        Me.boxBidAsk.Location = New System.Drawing.Point(117, 41)
        Me.boxBidAsk.Name = "boxBidAsk"
        Me.boxBidAsk.Size = New System.Drawing.Size(49, 23)
        Me.boxBidAsk.TabIndex = 24
        '
        'txtStockNo
        '
        Me.txtStockNo.Location = New System.Drawing.Point(9, 39)
        Me.txtStockNo.Name = "txtStockNo"
        Me.txtStockNo.Size = New System.Drawing.Size(85, 25)
        Me.txtStockNo.TabIndex = 23
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(304, 21)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 15)
        Me.label4.TabIndex = 22
        Me.label4.Text = "倉別"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(572, 21)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(52, 15)
        Me.label7.TabIndex = 21
        Me.label7.Text = "觸發價"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(490, 21)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 15)
        Me.label6.TabIndex = 20
        Me.label6.Text = "委託量"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(392, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(67, 15)
        Me.label5.TabIndex = 19
        Me.label5.Text = "移動點數"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(192, 21)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 15)
        Me.label3.TabIndex = 18
        Me.label3.Text = "委託條件"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(114, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 15)
        Me.label2.TabIndex = 17
        Me.label2.Text = "買賣別"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 16
        Me.label1.Text = "商品代碼"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.txtBookNo)
        Me.GroupBox2.Controls.Add(Me.label8)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 66)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "刪單"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(238, 24)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(163, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CancelOptionStopLoss"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtBookNo
        '
        Me.txtBookNo.Location = New System.Drawing.Point(79, 24)
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.Size = New System.Drawing.Size(138, 25)
        Me.txtBookNo.TabIndex = 2
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(6, 30)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(67, 15)
        Me.label8.TabIndex = 1
        Me.label8.Text = "委託序號"
        '
        'OptionStopLossControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OptionStopLossControl"
        Me.Size = New System.Drawing.Size(810, 188)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents btnSendMovingOrder As System.Windows.Forms.Button
    Friend WithEvents txtTriggerPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtMovingPoint As System.Windows.Forms.TextBox
    Friend WithEvents boxFlag As System.Windows.Forms.ComboBox
    Friend WithEvents boxPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents boxBidAsk As System.Windows.Forms.ComboBox
    Friend WithEvents txtStockNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtBookNo As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label

End Class
