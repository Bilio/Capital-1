<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionOrderControl
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
        Me.btnSendOptionOrderAsync = New System.Windows.Forms.Button()
        Me.boxFlag = New System.Windows.Forms.ComboBox()
        Me.boxPeriod = New System.Windows.Forms.ComboBox()
        Me.boxBidAsk = New System.Windows.Forms.ComboBox()
        Me.btnSendOptionOrder = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSendOptionOrderAsync)
        Me.GroupBox1.Controls.Add(Me.boxFlag)
        Me.GroupBox1.Controls.Add(Me.boxPeriod)
        Me.GroupBox1.Controls.Add(Me.boxBidAsk)
        Me.GroupBox1.Controls.Add(Me.btnSendOptionOrder)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtStockNo)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "選擇權"
        '
        'btnSendOptionOrderAsync
        '
        Me.btnSendOptionOrderAsync.Location = New System.Drawing.Point(577, 43)
        Me.btnSendOptionOrderAsync.Name = "btnSendOptionOrderAsync"
        Me.btnSendOptionOrderAsync.Size = New System.Drawing.Size(186, 23)
        Me.btnSendOptionOrderAsync.TabIndex = 19
        Me.btnSendOptionOrderAsync.Text = "SendOptionOrderAsync"
        Me.btnSendOptionOrderAsync.UseVisualStyleBackColor = True
        '
        'boxFlag
        '
        Me.boxFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxFlag.FormattingEnabled = True
        Me.boxFlag.Items.AddRange(New Object() {"新倉", "平倉", "自動"})
        Me.boxFlag.Location = New System.Drawing.Point(291, 41)
        Me.boxFlag.Name = "boxFlag"
        Me.boxFlag.Size = New System.Drawing.Size(62, 23)
        Me.boxFlag.TabIndex = 18
        '
        'boxPeriod
        '
        Me.boxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxPeriod.FormattingEnabled = True
        Me.boxPeriod.Items.AddRange(New Object() {"ROD", "IOC", "FOK"})
        Me.boxPeriod.Location = New System.Drawing.Point(195, 41)
        Me.boxPeriod.Name = "boxPeriod"
        Me.boxPeriod.Size = New System.Drawing.Size(64, 23)
        Me.boxPeriod.TabIndex = 17
        '
        'boxBidAsk
        '
        Me.boxBidAsk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxBidAsk.FormattingEnabled = True
        Me.boxBidAsk.Items.AddRange(New Object() {"買", "賣"})
        Me.boxBidAsk.Location = New System.Drawing.Point(119, 41)
        Me.boxBidAsk.Name = "boxBidAsk"
        Me.boxBidAsk.Size = New System.Drawing.Size(49, 23)
        Me.boxBidAsk.TabIndex = 16
        '
        'btnSendOptionOrder
        '
        Me.btnSendOptionOrder.Location = New System.Drawing.Point(577, 16)
        Me.btnSendOptionOrder.Name = "btnSendOptionOrder"
        Me.btnSendOptionOrder.Size = New System.Drawing.Size(186, 24)
        Me.btnSendOptionOrder.TabIndex = 15
        Me.btnSendOptionOrder.Text = "SendOptionOrder"
        Me.btnSendOptionOrder.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(488, 39)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(60, 25)
        Me.txtQty.TabIndex = 14
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(391, 41)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(67, 25)
        Me.txtPrice.TabIndex = 13
        '
        'txtStockNo
        '
        Me.txtStockNo.Location = New System.Drawing.Point(6, 39)
        Me.txtStockNo.Name = "txtStockNo"
        Me.txtStockNo.Size = New System.Drawing.Size(96, 25)
        Me.txtStockNo.TabIndex = 12
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(489, 21)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 15)
        Me.label6.TabIndex = 11
        Me.label6.Text = "委託量"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(398, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(52, 15)
        Me.label5.TabIndex = 10
        Me.label5.Text = "委託價"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(305, 21)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 15)
        Me.label4.TabIndex = 9
        Me.label4.Text = "倉別"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(192, 21)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 15)
        Me.label3.TabIndex = 8
        Me.label3.Text = "委託條件"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(116, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 15)
        Me.label2.TabIndex = 7
        Me.label2.Text = "買賣別"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 21)
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
        Me.GroupBox2.Location = New System.Drawing.Point(3, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 82)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "取消委託"
        '
        'btnCancelOrderBySeqNo
        '
        Me.btnCancelOrderBySeqNo.Location = New System.Drawing.Point(238, 49)
        Me.btnCancelOrderBySeqNo.Name = "btnCancelOrderBySeqNo"
        Me.btnCancelOrderBySeqNo.Size = New System.Drawing.Size(173, 23)
        Me.btnCancelOrderBySeqNo.TabIndex = 9
        Me.btnCancelOrderBySeqNo.Text = "Cancel Order By SeqNo"
        Me.btnCancelOrderBySeqNo.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(238, 18)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(173, 23)
        Me.btnCancelOrder.TabIndex = 8
        Me.btnCancelOrder.Text = "Cancel Order By StockNo"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'txtCancelSeqNo
        '
        Me.txtCancelSeqNo.Location = New System.Drawing.Point(87, 49)
        Me.txtCancelSeqNo.Name = "txtCancelSeqNo"
        Me.txtCancelSeqNo.Size = New System.Drawing.Size(135, 25)
        Me.txtCancelSeqNo.TabIndex = 7
        '
        'txtCancelStockNo
        '
        Me.txtCancelStockNo.Location = New System.Drawing.Point(87, 18)
        Me.txtCancelStockNo.Name = "txtCancelStockNo"
        Me.txtCancelStockNo.Size = New System.Drawing.Size(135, 25)
        Me.txtCancelStockNo.TabIndex = 6
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(14, 52)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(67, 15)
        Me.label8.TabIndex = 5
        Me.label8.Text = "委託序號"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(14, 21)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(67, 15)
        Me.label7.TabIndex = 4
        Me.label7.Text = "商品代碼"
        '
        'OptionOrderControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OptionOrderControl"
        Me.Size = New System.Drawing.Size(810, 188)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents btnSendOptionOrder As System.Windows.Forms.Button
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents boxFlag As System.Windows.Forms.ComboBox
    Friend WithEvents boxPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents boxBidAsk As System.Windows.Forms.ComboBox
    Friend WithEvents btnSendOptionOrderAsync As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents txtCancelSeqNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCancelStockNo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelOrderBySeqNo As System.Windows.Forms.Button
    Friend WithEvents btnCancelOrder As System.Windows.Forms.Button

End Class
