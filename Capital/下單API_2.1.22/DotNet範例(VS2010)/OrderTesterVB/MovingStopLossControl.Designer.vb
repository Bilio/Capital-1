<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovingStopLossControl
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
        Me.boxBidAsk = New System.Windows.Forms.ComboBox()
        Me.boxPeriod = New System.Windows.Forms.ComboBox()
        Me.boxFlag = New System.Windows.Forms.ComboBox()
        Me.txtMovingPoint = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtTriggerPrice = New System.Windows.Forms.TextBox()
        Me.btnSendMovingOrder = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtBookNo = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "移動停損單委託"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(567, 21)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(52, 15)
        Me.label7.TabIndex = 20
        Me.label7.Text = "觸發價"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(486, 21)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 15)
        Me.label6.TabIndex = 19
        Me.label6.Text = "委託量"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(392, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(67, 15)
        Me.label5.TabIndex = 18
        Me.label5.Text = "移動點數"
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
        Me.txtStockNo.Location = New System.Drawing.Point(9, 41)
        Me.txtStockNo.Name = "txtStockNo"
        Me.txtStockNo.Size = New System.Drawing.Size(64, 25)
        Me.txtStockNo.TabIndex = 21
        '
        'boxBidAsk
        '
        Me.boxBidAsk.FormattingEnabled = True
        Me.boxBidAsk.Location = New System.Drawing.Point(108, 41)
        Me.boxBidAsk.Name = "boxBidAsk"
        Me.boxBidAsk.Size = New System.Drawing.Size(49, 23)
        Me.boxBidAsk.TabIndex = 22
        '
        'boxPeriod
        '
        Me.boxPeriod.FormattingEnabled = True
        Me.boxPeriod.Location = New System.Drawing.Point(195, 43)
        Me.boxPeriod.Name = "boxPeriod"
        Me.boxPeriod.Size = New System.Drawing.Size(64, 23)
        Me.boxPeriod.TabIndex = 23
        '
        'boxFlag
        '
        Me.boxFlag.FormattingEnabled = True
        Me.boxFlag.Location = New System.Drawing.Point(296, 43)
        Me.boxFlag.Name = "boxFlag"
        Me.boxFlag.Size = New System.Drawing.Size(64, 23)
        Me.boxFlag.TabIndex = 24
        '
        'txtMovingPoint
        '
        Me.txtMovingPoint.Location = New System.Drawing.Point(395, 43)
        Me.txtMovingPoint.Name = "txtMovingPoint"
        Me.txtMovingPoint.Size = New System.Drawing.Size(64, 25)
        Me.txtMovingPoint.TabIndex = 25
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(489, 41)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(49, 25)
        Me.txtQty.TabIndex = 26
        '
        'txtTriggerPrice
        '
        Me.txtTriggerPrice.Location = New System.Drawing.Point(570, 41)
        Me.txtTriggerPrice.Name = "txtTriggerPrice"
        Me.txtTriggerPrice.Size = New System.Drawing.Size(49, 25)
        Me.txtTriggerPrice.TabIndex = 27
        '
        'btnSendMovingOrder
        '
        Me.btnSendMovingOrder.Location = New System.Drawing.Point(641, 24)
        Me.btnSendMovingOrder.Name = "btnSendMovingOrder"
        Me.btnSendMovingOrder.Size = New System.Drawing.Size(147, 40)
        Me.btnSendMovingOrder.TabIndex = 28
        Me.btnSendMovingOrder.Text = "SendMovingStopLossOrder"
        Me.btnSendMovingOrder.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.txtBookNo)
        Me.GroupBox2.Controls.Add(Me.label8)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 65)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "刪單"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(6, 27)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(67, 15)
        Me.label8.TabIndex = 1
        Me.label8.Text = "委託書號"
        '
        'txtBookNo
        '
        Me.txtBookNo.Location = New System.Drawing.Point(79, 24)
        Me.txtBookNo.Name = "txtBookNo"
        Me.txtBookNo.Size = New System.Drawing.Size(100, 25)
        Me.txtBookNo.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(195, 27)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(165, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CancelMovingStopLoss"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'MovingStopLossControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MovingStopLossControl"
        Me.Size = New System.Drawing.Size(810, 200)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents txtStockNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSendMovingOrder As System.Windows.Forms.Button
    Friend WithEvents txtTriggerPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtMovingPoint As System.Windows.Forms.TextBox
    Friend WithEvents boxFlag As System.Windows.Forms.ComboBox
    Friend WithEvents boxPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents boxBidAsk As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtBookNo As System.Windows.Forms.TextBox

End Class
