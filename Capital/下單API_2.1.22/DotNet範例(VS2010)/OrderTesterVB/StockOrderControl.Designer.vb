<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockOrderControl
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
        Me.btnSendStockOrderAsync = New System.Windows.Forms.Button()
        Me.btnSendStockOrder = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.boxFlag = New System.Windows.Forms.ComboBox()
        Me.boxPeriod = New System.Windows.Forms.ComboBox()
        Me.boxBidAsk = New System.Windows.Forms.ComboBox()
        Me.txtStockNo = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelOrderBySeqNo = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.txtCancelSeqNo = New System.Windows.Forms.TextBox()
        Me.txtCancelStockNo = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDecreaseQty = New System.Windows.Forms.Button()
        Me.txtDecreaseQty = New System.Windows.Forms.TextBox()
        Me.txtDecreaseSeqNo = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnQueryReport = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSendStockOrderAsync)
        Me.GroupBox1.Controls.Add(Me.btnSendStockOrder)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.boxFlag)
        Me.GroupBox1.Controls.Add(Me.boxPeriod)
        Me.GroupBox1.Controls.Add(Me.boxBidAsk)
        Me.GroupBox1.Controls.Add(Me.txtStockNo)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(814, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "證券委託"
        '
        'btnSendStockOrderAsync
        '
        Me.btnSendStockOrderAsync.Location = New System.Drawing.Point(596, 46)
        Me.btnSendStockOrderAsync.Name = "btnSendStockOrderAsync"
        Me.btnSendStockOrderAsync.Size = New System.Drawing.Size(185, 23)
        Me.btnSendStockOrderAsync.TabIndex = 19
        Me.btnSendStockOrderAsync.Text = "SendStockOrderAsync"
        Me.btnSendStockOrderAsync.UseVisualStyleBackColor = True
        '
        'btnSendStockOrder
        '
        Me.btnSendStockOrder.Location = New System.Drawing.Point(596, 17)
        Me.btnSendStockOrder.Name = "btnSendStockOrder"
        Me.btnSendStockOrder.Size = New System.Drawing.Size(185, 23)
        Me.btnSendStockOrder.TabIndex = 18
        Me.btnSendStockOrder.Text = "SendStockOrder"
        Me.btnSendStockOrder.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(512, 41)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(49, 25)
        Me.txtQty.TabIndex = 17
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(421, 41)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(49, 25)
        Me.txtPrice.TabIndex = 16
        '
        'boxFlag
        '
        Me.boxFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxFlag.FormattingEnabled = True
        Me.boxFlag.Items.AddRange(New Object() {"現股", "融資", "融券", "無券"})
        Me.boxFlag.Location = New System.Drawing.Point(318, 41)
        Me.boxFlag.Name = "boxFlag"
        Me.boxFlag.Size = New System.Drawing.Size(64, 23)
        Me.boxFlag.TabIndex = 15
        '
        'boxPeriod
        '
        Me.boxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxPeriod.FormattingEnabled = True
        Me.boxPeriod.Items.AddRange(New Object() {"整股", "盤後", "零股"})
        Me.boxPeriod.Location = New System.Drawing.Point(215, 41)
        Me.boxPeriod.Name = "boxPeriod"
        Me.boxPeriod.Size = New System.Drawing.Size(64, 23)
        Me.boxPeriod.TabIndex = 14
        '
        'boxBidAsk
        '
        Me.boxBidAsk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxBidAsk.FormattingEnabled = True
        Me.boxBidAsk.Items.AddRange(New Object() {"買", "賣"})
        Me.boxBidAsk.Location = New System.Drawing.Point(128, 41)
        Me.boxBidAsk.Name = "boxBidAsk"
        Me.boxBidAsk.Size = New System.Drawing.Size(49, 23)
        Me.boxBidAsk.TabIndex = 13
        '
        'txtStockNo
        '
        Me.txtStockNo.Location = New System.Drawing.Point(29, 39)
        Me.txtStockNo.Name = "txtStockNo"
        Me.txtStockNo.Size = New System.Drawing.Size(64, 25)
        Me.txtStockNo.TabIndex = 12
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(509, 21)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 15)
        Me.label6.TabIndex = 11
        Me.label6.Text = "委託量"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(418, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(52, 15)
        Me.label5.TabIndex = 10
        Me.label5.Text = "委託價"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(315, 21)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(67, 15)
        Me.label4.TabIndex = 9
        Me.label4.Text = "當沖與否"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(212, 21)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 15)
        Me.label3.TabIndex = 8
        Me.label3.Text = "委託條件"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(127, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 15)
        Me.label2.TabIndex = 7
        Me.label2.Text = "買賣別"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(26, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 6
        Me.label1.Text = "商品代碼"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelOrderBySeqNo)
        Me.GroupBox2.Controls.Add(Me.btnCancelOrder)
        Me.GroupBox2.Controls.Add(Me.txtCancelSeqNo)
        Me.GroupBox2.Controls.Add(Me.txtCancelStockNo)
        Me.GroupBox2.Controls.Add(Me.label8)
        Me.GroupBox2.Controls.Add(Me.label7)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(814, 82)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "取消委託"
        '
        'btnCancelOrderBySeqNo
        '
        Me.btnCancelOrderBySeqNo.Location = New System.Drawing.Point(307, 52)
        Me.btnCancelOrderBySeqNo.Name = "btnCancelOrderBySeqNo"
        Me.btnCancelOrderBySeqNo.Size = New System.Drawing.Size(172, 24)
        Me.btnCancelOrderBySeqNo.TabIndex = 9
        Me.btnCancelOrderBySeqNo.Text = "CancelOrderBySeqNo"
        Me.btnCancelOrderBySeqNo.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(307, 21)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(172, 23)
        Me.btnCancelOrder.TabIndex = 8
        Me.btnCancelOrder.Text = "CancelOrderByStockNo"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'txtCancelSeqNo
        '
        Me.txtCancelSeqNo.Location = New System.Drawing.Point(99, 51)
        Me.txtCancelSeqNo.Name = "txtCancelSeqNo"
        Me.txtCancelSeqNo.Size = New System.Drawing.Size(180, 25)
        Me.txtCancelSeqNo.TabIndex = 7
        '
        'txtCancelStockNo
        '
        Me.txtCancelStockNo.Location = New System.Drawing.Point(99, 21)
        Me.txtCancelStockNo.Name = "txtCancelStockNo"
        Me.txtCancelStockNo.Size = New System.Drawing.Size(180, 25)
        Me.txtCancelStockNo.TabIndex = 6
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(26, 55)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(67, 15)
        Me.label8.TabIndex = 5
        Me.label8.Text = "委託序號"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(26, 24)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(67, 15)
        Me.label7.TabIndex = 4
        Me.label7.Text = "商品代碼"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDecreaseQty)
        Me.GroupBox3.Controls.Add(Me.txtDecreaseQty)
        Me.GroupBox3.Controls.Add(Me.txtDecreaseSeqNo)
        Me.GroupBox3.Controls.Add(Me.label13)
        Me.GroupBox3.Controls.Add(Me.label11)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(814, 55)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "委託減量"
        '
        'btnDecreaseQty
        '
        Me.btnDecreaseQty.Location = New System.Drawing.Point(596, 17)
        Me.btnDecreaseQty.Name = "btnDecreaseQty"
        Me.btnDecreaseQty.Size = New System.Drawing.Size(185, 25)
        Me.btnDecreaseQty.TabIndex = 22
        Me.btnDecreaseQty.Text = "DecreaseQty"
        Me.btnDecreaseQty.UseVisualStyleBackColor = True
        '
        'txtDecreaseQty
        '
        Me.txtDecreaseQty.Location = New System.Drawing.Point(441, 19)
        Me.txtDecreaseQty.Name = "txtDecreaseQty"
        Me.txtDecreaseQty.Size = New System.Drawing.Size(87, 25)
        Me.txtDecreaseQty.TabIndex = 21
        '
        'txtDecreaseSeqNo
        '
        Me.txtDecreaseSeqNo.Location = New System.Drawing.Point(99, 23)
        Me.txtDecreaseSeqNo.Name = "txtDecreaseSeqNo"
        Me.txtDecreaseSeqNo.Size = New System.Drawing.Size(167, 25)
        Me.txtDecreaseSeqNo.TabIndex = 20
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(304, 27)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(131, 15)
        Me.label13.TabIndex = 19
        Me.label13.Text = " 輸入欲減少的數量"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(26, 27)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(67, 15)
        Me.label11.TabIndex = 18
        Me.label11.Text = "委託序號"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnQueryReport)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 227)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(814, 54)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "查詢"
        '
        'btnQueryReport
        '
        Me.btnQueryReport.Location = New System.Drawing.Point(29, 21)
        Me.btnQueryReport.Name = "btnQueryReport"
        Me.btnQueryReport.Size = New System.Drawing.Size(187, 23)
        Me.btnQueryReport.TabIndex = 0
        Me.btnQueryReport.Text = " 查詢及時庫存"
        Me.btnQueryReport.UseVisualStyleBackColor = True
        '
        'StockOrderControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StockOrderControl"
        Me.Size = New System.Drawing.Size(820, 292)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents txtStockNo As System.Windows.Forms.TextBox
    Friend WithEvents boxBidAsk As System.Windows.Forms.ComboBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents boxFlag As System.Windows.Forms.ComboBox
    Friend WithEvents boxPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents btnSendStockOrderAsync As System.Windows.Forms.Button
    Friend WithEvents btnSendStockOrder As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents txtCancelStockNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCancelSeqNo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelOrderBySeqNo As System.Windows.Forms.Button
    Friend WithEvents btnCancelOrder As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDecreaseSeqNo As System.Windows.Forms.TextBox
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents btnDecreaseQty As System.Windows.Forms.Button
    Friend WithEvents txtDecreaseQty As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQueryReport As System.Windows.Forms.Button

End Class
