<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForeignStockOrderControl
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
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.boxAccountType = New System.Windows.Forms.ComboBox()
        Me.boxCurrency1 = New System.Windows.Forms.ComboBox()
        Me.boxCurrency2 = New System.Windows.Forms.ComboBox()
        Me.boxCurrency3 = New System.Windows.Forms.ComboBox()
        Me.boxExchange = New System.Windows.Forms.ComboBox()
        Me.boxBidAsk = New System.Windows.Forms.ComboBox()
        Me.txtStockNo = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnSendForeignStockOrder = New System.Windows.Forms.Button()
        Me.btnSendForeignStockOrderAsync = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.boxCancelExchange = New System.Windows.Forms.ComboBox()
        Me.txtCancelBookNo = New System.Windows.Forms.TextBox()
        Me.txtCancelSeqNo = New System.Windows.Forms.TextBox()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btnCancelOrderBySeqNo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSendForeignStockOrderAsync)
        Me.GroupBox1.Controls.Add(Me.btnSendForeignStockOrder)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtStockNo)
        Me.GroupBox1.Controls.Add(Me.boxBidAsk)
        Me.GroupBox1.Controls.Add(Me.boxExchange)
        Me.GroupBox1.Controls.Add(Me.boxCurrency3)
        Me.GroupBox1.Controls.Add(Me.boxCurrency2)
        Me.GroupBox1.Controls.Add(Me.boxCurrency1)
        Me.GroupBox1.Controls.Add(Me.boxAccountType)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Controls.Add(Me.label9)
        Me.GroupBox1.Controls.Add(Me.label10)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(801, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "複委託"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(375, 52)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(52, 15)
        Me.label8.TabIndex = 25
        Me.label8.Text = "委託量"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(284, 52)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(52, 15)
        Me.label9.TabIndex = 24
        Me.label9.Text = "委託價"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(193, 52)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(52, 15)
        Me.label10.TabIndex = 23
        Me.label10.Text = "買賣別"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(100, 53)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(67, 15)
        Me.label7.TabIndex = 22
        Me.label7.Text = "商品代碼"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(19, 53)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 15)
        Me.label6.TabIndex = 21
        Me.label6.Text = "交易所"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(535, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(18, 15)
        Me.label5.TabIndex = 20
        Me.label5.Text = "3."
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(438, 21)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(18, 15)
        Me.label4.TabIndex = 19
        Me.label4.Text = "2."
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(339, 21)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(18, 15)
        Me.label3.TabIndex = 18
        Me.label3.Text = "1."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(221, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(112, 15)
        Me.label2.TabIndex = 17
        Me.label2.Text = "扣款幣別順序："
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 16
        Me.label1.Text = "專戶別："
        '
        'boxAccountType
        '
        Me.boxAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxAccountType.FormattingEnabled = True
        Me.boxAccountType.Items.AddRange(New Object() {"外幣專戶", "台幣專戶"})
        Me.boxAccountType.Location = New System.Drawing.Point(88, 18)
        Me.boxAccountType.Name = "boxAccountType"
        Me.boxAccountType.Size = New System.Drawing.Size(79, 23)
        Me.boxAccountType.TabIndex = 1
        '
        'boxCurrency1
        '
        Me.boxCurrency1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxCurrency1.FormattingEnabled = True
        Me.boxCurrency1.Items.AddRange(New Object() {"HKD", "NTD", "USD", "JPY", "SGD", "EUR", "AUD"})
        Me.boxCurrency1.Location = New System.Drawing.Point(363, 18)
        Me.boxCurrency1.Name = "boxCurrency1"
        Me.boxCurrency1.Size = New System.Drawing.Size(64, 23)
        Me.boxCurrency1.TabIndex = 26
        '
        'boxCurrency2
        '
        Me.boxCurrency2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxCurrency2.FormattingEnabled = True
        Me.boxCurrency2.Items.AddRange(New Object() {"HKD", "NTD", "USD", "JPY", "SGD", "EUR", "AUD"})
        Me.boxCurrency2.Location = New System.Drawing.Point(462, 18)
        Me.boxCurrency2.Name = "boxCurrency2"
        Me.boxCurrency2.Size = New System.Drawing.Size(67, 23)
        Me.boxCurrency2.TabIndex = 27
        '
        'boxCurrency3
        '
        Me.boxCurrency3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxCurrency3.FormattingEnabled = True
        Me.boxCurrency3.Items.AddRange(New Object() {"HKD", "NTD", "USD", "JPY", "SGD", "EUR", "AUD"})
        Me.boxCurrency3.Location = New System.Drawing.Point(559, 18)
        Me.boxCurrency3.Name = "boxCurrency3"
        Me.boxCurrency3.Size = New System.Drawing.Size(66, 23)
        Me.boxCurrency3.TabIndex = 28
        '
        'boxExchange
        '
        Me.boxExchange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxExchange.FormattingEnabled = True
        Me.boxExchange.Items.AddRange(New Object() {"美股", "港股"})
        Me.boxExchange.Location = New System.Drawing.Point(18, 75)
        Me.boxExchange.Name = "boxExchange"
        Me.boxExchange.Size = New System.Drawing.Size(64, 23)
        Me.boxExchange.TabIndex = 29
        '
        'boxBidAsk
        '
        Me.boxBidAsk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxBidAsk.FormattingEnabled = True
        Me.boxBidAsk.Items.AddRange(New Object() {"買", "賣"})
        Me.boxBidAsk.Location = New System.Drawing.Point(195, 75)
        Me.boxBidAsk.Name = "boxBidAsk"
        Me.boxBidAsk.Size = New System.Drawing.Size(49, 23)
        Me.boxBidAsk.TabIndex = 30
        '
        'txtStockNo
        '
        Me.txtStockNo.Location = New System.Drawing.Point(103, 73)
        Me.txtStockNo.Name = "txtStockNo"
        Me.txtStockNo.Size = New System.Drawing.Size(64, 25)
        Me.txtStockNo.TabIndex = 31
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(276, 75)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(70, 25)
        Me.txtPrice.TabIndex = 32
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(363, 75)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(65, 25)
        Me.txtQty.TabIndex = 33
        '
        'btnSendForeignStockOrder
        '
        Me.btnSendForeignStockOrder.Location = New System.Drawing.Point(559, 48)
        Me.btnSendForeignStockOrder.Name = "btnSendForeignStockOrder"
        Me.btnSendForeignStockOrder.Size = New System.Drawing.Size(227, 23)
        Me.btnSendForeignStockOrder.TabIndex = 34
        Me.btnSendForeignStockOrder.Text = "SendForeignStockOrder"
        Me.btnSendForeignStockOrder.UseVisualStyleBackColor = True
        '
        'btnSendForeignStockOrderAsync
        '
        Me.btnSendForeignStockOrderAsync.Location = New System.Drawing.Point(559, 75)
        Me.btnSendForeignStockOrderAsync.Name = "btnSendForeignStockOrderAsync"
        Me.btnSendForeignStockOrderAsync.Size = New System.Drawing.Size(227, 23)
        Me.btnSendForeignStockOrderAsync.TabIndex = 35
        Me.btnSendForeignStockOrderAsync.Text = "SendForeignStockOrderAsync"
        Me.btnSendForeignStockOrderAsync.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelOrderBySeqNo)
        Me.GroupBox2.Controls.Add(Me.btnCancelOrder)
        Me.GroupBox2.Controls.Add(Me.txtCancelSeqNo)
        Me.GroupBox2.Controls.Add(Me.txtCancelBookNo)
        Me.GroupBox2.Controls.Add(Me.boxCancelExchange)
        Me.GroupBox2.Controls.Add(Me.label13)
        Me.GroupBox2.Controls.Add(Me.label12)
        Me.GroupBox2.Controls.Add(Me.label11)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(801, 78)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "取消委託"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(110, 53)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(112, 15)
        Me.label13.TabIndex = 16
        Me.label13.Text = "委託序號刪單："
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(110, 21)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(112, 15)
        Me.label12.TabIndex = 15
        Me.label12.Text = "委託書號刪單："
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(10, 22)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(52, 15)
        Me.label11.TabIndex = 14
        Me.label11.Text = "交易所"
        '
        'boxCancelExchange
        '
        Me.boxCancelExchange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxCancelExchange.FormattingEnabled = True
        Me.boxCancelExchange.Items.AddRange(New Object() {"美股", "港股"})
        Me.boxCancelExchange.Location = New System.Drawing.Point(18, 40)
        Me.boxCancelExchange.Name = "boxCancelExchange"
        Me.boxCancelExchange.Size = New System.Drawing.Size(64, 23)
        Me.boxCancelExchange.TabIndex = 17
        '
        'txtCancelBookNo
        '
        Me.txtCancelBookNo.Location = New System.Drawing.Point(224, 12)
        Me.txtCancelBookNo.Name = "txtCancelBookNo"
        Me.txtCancelBookNo.Size = New System.Drawing.Size(144, 25)
        Me.txtCancelBookNo.TabIndex = 18
        '
        'txtCancelSeqNo
        '
        Me.txtCancelSeqNo.Location = New System.Drawing.Point(224, 43)
        Me.txtCancelSeqNo.Name = "txtCancelSeqNo"
        Me.txtCancelSeqNo.Size = New System.Drawing.Size(144, 25)
        Me.txtCancelSeqNo.TabIndex = 19
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(426, 17)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(199, 23)
        Me.btnCancelOrder.TabIndex = 20
        Me.btnCancelOrder.Text = "CancelOrder"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'btnCancelOrderBySeqNo
        '
        Me.btnCancelOrderBySeqNo.Location = New System.Drawing.Point(426, 49)
        Me.btnCancelOrderBySeqNo.Name = "btnCancelOrderBySeqNo"
        Me.btnCancelOrderBySeqNo.Size = New System.Drawing.Size(199, 23)
        Me.btnCancelOrderBySeqNo.TabIndex = 21
        Me.btnCancelOrderBySeqNo.Text = "CancelOrderBySeqNo"
        Me.btnCancelOrderBySeqNo.UseVisualStyleBackColor = True
        '
        'ForeignStockOrderControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ForeignStockOrderControl"
        Me.Size = New System.Drawing.Size(810, 215)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents boxAccountType As System.Windows.Forms.ComboBox
    Friend WithEvents boxCurrency3 As System.Windows.Forms.ComboBox
    Friend WithEvents boxCurrency2 As System.Windows.Forms.ComboBox
    Friend WithEvents boxCurrency1 As System.Windows.Forms.ComboBox
    Friend WithEvents boxExchange As System.Windows.Forms.ComboBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtStockNo As System.Windows.Forms.TextBox
    Friend WithEvents boxBidAsk As System.Windows.Forms.ComboBox
    Friend WithEvents btnSendForeignStockOrderAsync As System.Windows.Forms.Button
    Friend WithEvents btnSendForeignStockOrder As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents boxCancelExchange As System.Windows.Forms.ComboBox
    Friend WithEvents txtCancelSeqNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCancelBookNo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelOrderBySeqNo As System.Windows.Forms.Button
    Friend WithEvents btnCancelOrder As System.Windows.Forms.Button

End Class
