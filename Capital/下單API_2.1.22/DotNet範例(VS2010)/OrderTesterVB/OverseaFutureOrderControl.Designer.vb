<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverseaFutureOrderControl
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnSendOverseaFutureOrderAsync = New System.Windows.Forms.Button()
        Me.btnSendOverseaFutureOrder = New System.Windows.Forms.Button()
        Me.boxSpecialTradeType = New System.Windows.Forms.ComboBox()
        Me.boxPeriod = New System.Windows.Forms.ComboBox()
        Me.boxFlag = New System.Windows.Forms.ComboBox()
        Me.boxNewClose = New System.Windows.Forms.ComboBox()
        Me.boxBidAsk = New System.Windows.Forms.ComboBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtYearMonth = New System.Windows.Forms.TextBox()
        Me.txtStockNo = New System.Windows.Forms.TextBox()
        Me.txtTradeNo = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.txtIndext = New System.Windows.Forms.TextBox()
        Me.lblIndext = New System.Windows.Forms.Label()
        Me.btnQueryAll = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtCancelSeqNo = New System.Windows.Forms.TextBox()
        Me.btnCancelOrderBySeqNo = New System.Windows.Forms.Button()
        Me.txtDecreaseQty = New System.Windows.Forms.TextBox()
        Me.btnDecreaseQty = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnSendOverseaFutureOrderAsync)
        Me.GroupBox1.Controls.Add(Me.btnSendOverseaFutureOrder)
        Me.GroupBox1.Controls.Add(Me.boxSpecialTradeType)
        Me.GroupBox1.Controls.Add(Me.boxPeriod)
        Me.GroupBox1.Controls.Add(Me.boxFlag)
        Me.GroupBox1.Controls.Add(Me.boxNewClose)
        Me.GroupBox1.Controls.Add(Me.boxBidAsk)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtYearMonth)
        Me.GroupBox1.Controls.Add(Me.txtStockNo)
        Me.GroupBox1.Controls.Add(Me.txtTradeNo)
        Me.GroupBox1.Controls.Add(Me.label10)
        Me.GroupBox1.Controls.Add(Me.label9)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "海期委託"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReload)
        Me.GroupBox2.Location = New System.Drawing.Point(690, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(108, 100)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "重新載入可交易商品"
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(16, 36)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(75, 56)
        Me.btnReload.TabIndex = 0
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'btnSendOverseaFutureOrderAsync
        '
        Me.btnSendOverseaFutureOrderAsync.Location = New System.Drawing.Point(493, 70)
        Me.btnSendOverseaFutureOrderAsync.Name = "btnSendOverseaFutureOrderAsync"
        Me.btnSendOverseaFutureOrderAsync.Size = New System.Drawing.Size(191, 23)
        Me.btnSendOverseaFutureOrderAsync.TabIndex = 40
        Me.btnSendOverseaFutureOrderAsync.Text = "SendOverseaFutureOrderAsync"
        Me.btnSendOverseaFutureOrderAsync.UseVisualStyleBackColor = True
        '
        'btnSendOverseaFutureOrder
        '
        Me.btnSendOverseaFutureOrder.Location = New System.Drawing.Point(493, 38)
        Me.btnSendOverseaFutureOrder.Name = "btnSendOverseaFutureOrder"
        Me.btnSendOverseaFutureOrder.Size = New System.Drawing.Size(191, 23)
        Me.btnSendOverseaFutureOrder.TabIndex = 39
        Me.btnSendOverseaFutureOrder.Text = "SendOverseaFutureOrder"
        Me.btnSendOverseaFutureOrder.UseVisualStyleBackColor = True
        '
        'boxSpecialTradeType
        '
        Me.boxSpecialTradeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxSpecialTradeType.FormattingEnabled = True
        Me.boxSpecialTradeType.Items.AddRange(New Object() {"LMT ", "MKT", "STL", "STP"})
        Me.boxSpecialTradeType.Location = New System.Drawing.Point(411, 92)
        Me.boxSpecialTradeType.Name = "boxSpecialTradeType"
        Me.boxSpecialTradeType.Size = New System.Drawing.Size(59, 23)
        Me.boxSpecialTradeType.TabIndex = 38
        '
        'boxPeriod
        '
        Me.boxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxPeriod.FormattingEnabled = True
        Me.boxPeriod.Items.AddRange(New Object() {"ROD", "GTC", "MOO", "IOC", "FOK", "GTG", "GTD", "MOC"})
        Me.boxPeriod.Location = New System.Drawing.Point(315, 92)
        Me.boxPeriod.Name = "boxPeriod"
        Me.boxPeriod.Size = New System.Drawing.Size(64, 23)
        Me.boxPeriod.TabIndex = 37
        '
        'boxFlag
        '
        Me.boxFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxFlag.FormattingEnabled = True
        Me.boxFlag.Items.AddRange(New Object() {"非當沖", "當沖"})
        Me.boxFlag.Location = New System.Drawing.Point(217, 92)
        Me.boxFlag.Name = "boxFlag"
        Me.boxFlag.Size = New System.Drawing.Size(64, 23)
        Me.boxFlag.TabIndex = 36
        '
        'boxNewClose
        '
        Me.boxNewClose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxNewClose.FormattingEnabled = True
        Me.boxNewClose.Items.AddRange(New Object() {"新倉", "平倉", "自動"})
        Me.boxNewClose.Location = New System.Drawing.Point(123, 92)
        Me.boxNewClose.Name = "boxNewClose"
        Me.boxNewClose.Size = New System.Drawing.Size(61, 23)
        Me.boxNewClose.TabIndex = 35
        '
        'boxBidAsk
        '
        Me.boxBidAsk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxBidAsk.FormattingEnabled = True
        Me.boxBidAsk.Items.AddRange(New Object() {"買", "賣"})
        Me.boxBidAsk.Location = New System.Drawing.Point(39, 92)
        Me.boxBidAsk.Name = "boxBidAsk"
        Me.boxBidAsk.Size = New System.Drawing.Size(49, 23)
        Me.boxBidAsk.TabIndex = 34
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(411, 39)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(49, 25)
        Me.txtQty.TabIndex = 33
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(315, 39)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(53, 25)
        Me.txtPrice.TabIndex = 32
        '
        'txtYearMonth
        '
        Me.txtYearMonth.Location = New System.Drawing.Point(217, 39)
        Me.txtYearMonth.Name = "txtYearMonth"
        Me.txtYearMonth.Size = New System.Drawing.Size(64, 25)
        Me.txtYearMonth.TabIndex = 31
        '
        'txtStockNo
        '
        Me.txtStockNo.Location = New System.Drawing.Point(120, 39)
        Me.txtStockNo.Name = "txtStockNo"
        Me.txtStockNo.Size = New System.Drawing.Size(64, 25)
        Me.txtStockNo.TabIndex = 30
        '
        'txtTradeNo
        '
        Me.txtTradeNo.Location = New System.Drawing.Point(9, 39)
        Me.txtTradeNo.Name = "txtTradeNo"
        Me.txtTradeNo.Size = New System.Drawing.Size(79, 25)
        Me.txtTradeNo.TabIndex = 29
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(385, 74)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(97, 15)
        Me.label10.TabIndex = 28
        Me.label10.Text = "特殊委託條件"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(135, 74)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(37, 15)
        Me.label9.TabIndex = 27
        Me.label9.Text = "倉別"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(218, 74)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(67, 15)
        Me.label6.TabIndex = 26
        Me.label6.Text = "當沖與否"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(312, 74)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(67, 15)
        Me.label7.TabIndex = 25
        Me.label7.Text = "委託條件"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(36, 74)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(52, 15)
        Me.label8.TabIndex = 24
        Me.label8.Text = "買賣別"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(408, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(52, 15)
        Me.label5.TabIndex = 23
        Me.label5.Text = "委託量"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(316, 21)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(52, 15)
        Me.label4.TabIndex = 22
        Me.label4.Text = "委託價"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(214, 21)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 15)
        Me.label3.TabIndex = 21
        Me.label3.Text = "商品年月"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(117, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(67, 15)
        Me.label2.TabIndex = 20
        Me.label2.Text = "商品代號"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 15)
        Me.label1.TabIndex = 19
        Me.label1.Text = "交易所代號"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnQueryAll)
        Me.GroupBox3.Controls.Add(Me.lblIndext)
        Me.GroupBox3.Controls.Add(Me.txtIndext)
        Me.GroupBox3.Controls.Add(Me.txtCount)
        Me.GroupBox3.Controls.Add(Me.btnQuery)
        Me.GroupBox3.Controls.Add(Me.btnCount)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(804, 83)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "查詢"
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(13, 24)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(134, 23)
        Me.btnCount.TabIndex = 0
        Me.btnCount.Text = "可委託商品數量"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(13, 53)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(134, 23)
        Me.btnQuery.TabIndex = 1
        Me.btnQuery.Text = "GetOverseaProducts"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(153, 25)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(84, 25)
        Me.txtCount.TabIndex = 2
        '
        'txtIndext
        '
        Me.txtIndext.Location = New System.Drawing.Point(153, 51)
        Me.txtIndext.Name = "txtIndext"
        Me.txtIndext.Size = New System.Drawing.Size(48, 25)
        Me.txtIndext.TabIndex = 3
        '
        'lblIndext
        '
        Me.lblIndext.AutoSize = True
        Me.lblIndext.Location = New System.Drawing.Point(207, 57)
        Me.lblIndext.Name = "lblIndext"
        Me.lblIndext.Size = New System.Drawing.Size(172, 15)
        Me.lblIndext.TabIndex = 4
        Me.lblIndext.Text = "商品序號( 0~商品數量-1 )"
        '
        'btnQueryAll
        '
        Me.btnQueryAll.Location = New System.Drawing.Point(388, 12)
        Me.btnQueryAll.Name = "btnQueryAll"
        Me.btnQueryAll.Size = New System.Drawing.Size(153, 67)
        Me.btnQueryAll.TabIndex = 5
        Me.btnQueryAll.Text = "查詢所有可交易商品"
        Me.btnQueryAll.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnDecreaseQty)
        Me.GroupBox4.Controls.Add(Me.txtDecreaseQty)
        Me.GroupBox4.Controls.Add(Me.btnCancelOrderBySeqNo)
        Me.GroupBox4.Controls.Add(Me.txtCancelSeqNo)
        Me.GroupBox4.Controls.Add(Me.label13)
        Me.GroupBox4.Controls.Add(Me.label12)
        Me.GroupBox4.Controls.Add(Me.label11)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 222)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(804, 78)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "刪單 / 改量"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(227, 51)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(176, 15)
        Me.label13.TabIndex = 15
        Me.label13.Text = "改量： 輸入欲減少的數量"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(227, 17)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(52, 15)
        Me.label12.TabIndex = 14
        Me.label12.Text = "刪單："
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(6, 36)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(67, 15)
        Me.label11.TabIndex = 13
        Me.label11.Text = "委託序號"
        '
        'txtCancelSeqNo
        '
        Me.txtCancelSeqNo.Location = New System.Drawing.Point(79, 29)
        Me.txtCancelSeqNo.Name = "txtCancelSeqNo"
        Me.txtCancelSeqNo.Size = New System.Drawing.Size(142, 25)
        Me.txtCancelSeqNo.TabIndex = 16
        '
        'btnCancelOrderBySeqNo
        '
        Me.btnCancelOrderBySeqNo.Location = New System.Drawing.Point(285, 13)
        Me.btnCancelOrderBySeqNo.Name = "btnCancelOrderBySeqNo"
        Me.btnCancelOrderBySeqNo.Size = New System.Drawing.Size(175, 23)
        Me.btnCancelOrderBySeqNo.TabIndex = 17
        Me.btnCancelOrderBySeqNo.Text = "CancelOrder By SeqNo"
        Me.btnCancelOrderBySeqNo.UseVisualStyleBackColor = True
        '
        'txtDecreaseQty
        '
        Me.txtDecreaseQty.Location = New System.Drawing.Point(409, 47)
        Me.txtDecreaseQty.Name = "txtDecreaseQty"
        Me.txtDecreaseQty.Size = New System.Drawing.Size(51, 25)
        Me.txtDecreaseQty.TabIndex = 18
        '
        'btnDecreaseQty
        '
        Me.btnDecreaseQty.Location = New System.Drawing.Point(466, 47)
        Me.btnDecreaseQty.Name = "btnDecreaseQty"
        Me.btnDecreaseQty.Size = New System.Drawing.Size(154, 23)
        Me.btnDecreaseQty.TabIndex = 19
        Me.btnDecreaseQty.Text = "Decrease Qty"
        Me.btnDecreaseQty.UseVisualStyleBackColor = True
        '
        'OverseaFutureOrderControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OverseaFutureOrderControl"
        Me.Size = New System.Drawing.Size(810, 304)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents boxSpecialTradeType As System.Windows.Forms.ComboBox
    Friend WithEvents boxPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents boxFlag As System.Windows.Forms.ComboBox
    Friend WithEvents boxNewClose As System.Windows.Forms.ComboBox
    Friend WithEvents boxBidAsk As System.Windows.Forms.ComboBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtYearMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtStockNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTradeNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents btnSendOverseaFutureOrderAsync As System.Windows.Forms.Button
    Friend WithEvents btnSendOverseaFutureOrder As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents btnCount As System.Windows.Forms.Button
    Friend WithEvents txtIndext As System.Windows.Forms.TextBox
    Private WithEvents lblIndext As System.Windows.Forms.Label
    Friend WithEvents btnQueryAll As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents btnDecreaseQty As System.Windows.Forms.Button
    Friend WithEvents txtDecreaseQty As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelOrderBySeqNo As System.Windows.Forms.Button
    Friend WithEvents txtCancelSeqNo As System.Windows.Forms.TextBox

End Class
