<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FutureOrderControl
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
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnSendFutureOrder = New System.Windows.Forms.Button()
        Me.btnSendFutureOrderAsync = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtCancelStockNo = New System.Windows.Forms.TextBox()
        Me.txtCancelSeqNo = New System.Windows.Forms.TextBox()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btnCancelOrderBySeqNo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSendFutureOrderAsync)
        Me.GroupBox1.Controls.Add(Me.btnSendFutureOrder)
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
        Me.GroupBox1.Size = New System.Drawing.Size(804, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "期貨委託"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(503, 21)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 15)
        Me.label6.TabIndex = 11
        Me.label6.Text = "委託量"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(410, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(52, 15)
        Me.label5.TabIndex = 10
        Me.label5.Text = "委託價"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(302, 21)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(67, 15)
        Me.label4.TabIndex = 9
        Me.label4.Text = "當沖與否"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(201, 21)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 15)
        Me.label3.TabIndex = 8
        Me.label3.Text = "委託條件"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(114, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 15)
        Me.label2.TabIndex = 7
        Me.label2.Text = "買賣別"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 6
        Me.label1.Text = "商品代碼"
        '
        'txtStockNo
        '
        Me.txtStockNo.Location = New System.Drawing.Point(18, 39)
        Me.txtStockNo.Name = "txtStockNo"
        Me.txtStockNo.Size = New System.Drawing.Size(64, 25)
        Me.txtStockNo.TabIndex = 12
        '
        'boxBidAsk
        '
        Me.boxBidAsk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxBidAsk.FormattingEnabled = True
        Me.boxBidAsk.Items.AddRange(New Object() {"買", "賣"})
        Me.boxBidAsk.Location = New System.Drawing.Point(117, 41)
        Me.boxBidAsk.Name = "boxBidAsk"
        Me.boxBidAsk.Size = New System.Drawing.Size(49, 23)
        Me.boxBidAsk.TabIndex = 13
        '
        'boxPeriod
        '
        Me.boxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxPeriod.FormattingEnabled = True
        Me.boxPeriod.Items.AddRange(New Object() {"ROD", "IOC", "FOK"})
        Me.boxPeriod.Location = New System.Drawing.Point(204, 41)
        Me.boxPeriod.Name = "boxPeriod"
        Me.boxPeriod.Size = New System.Drawing.Size(64, 23)
        Me.boxPeriod.TabIndex = 14
        '
        'boxFlag
        '
        Me.boxFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxFlag.FormattingEnabled = True
        Me.boxFlag.Items.AddRange(New Object() {"非當沖", "當沖"})
        Me.boxFlag.Location = New System.Drawing.Point(295, 41)
        Me.boxFlag.Name = "boxFlag"
        Me.boxFlag.Size = New System.Drawing.Size(74, 23)
        Me.boxFlag.TabIndex = 15
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(404, 41)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(67, 25)
        Me.txtPrice.TabIndex = 16
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(501, 41)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(63, 25)
        Me.txtQty.TabIndex = 17
        '
        'btnSendFutureOrder
        '
        Me.btnSendFutureOrder.Location = New System.Drawing.Point(603, 21)
        Me.btnSendFutureOrder.Name = "btnSendFutureOrder"
        Me.btnSendFutureOrder.Size = New System.Drawing.Size(178, 23)
        Me.btnSendFutureOrder.TabIndex = 18
        Me.btnSendFutureOrder.Text = "SendFutureOrder"
        Me.btnSendFutureOrder.UseVisualStyleBackColor = True
        '
        'btnSendFutureOrderAsync
        '
        Me.btnSendFutureOrderAsync.Location = New System.Drawing.Point(603, 50)
        Me.btnSendFutureOrderAsync.Name = "btnSendFutureOrderAsync"
        Me.btnSendFutureOrderAsync.Size = New System.Drawing.Size(178, 23)
        Me.btnSendFutureOrderAsync.TabIndex = 19
        Me.btnSendFutureOrderAsync.Text = "SendFutureOrderAsync"
        Me.btnSendFutureOrderAsync.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelOrderBySeqNo)
        Me.GroupBox2.Controls.Add(Me.btnCancelOrder)
        Me.GroupBox2.Controls.Add(Me.txtCancelSeqNo)
        Me.GroupBox2.Controls.Add(Me.txtCancelStockNo)
        Me.GroupBox2.Controls.Add(Me.label8)
        Me.GroupBox2.Controls.Add(Me.label7)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 78)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "取消委託"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(15, 52)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(67, 15)
        Me.label8.TabIndex = 5
        Me.label8.Text = "委託序號"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(15, 21)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(67, 15)
        Me.label7.TabIndex = 4
        Me.label7.Text = "商品代碼"
        '
        'txtCancelStockNo
        '
        Me.txtCancelStockNo.Location = New System.Drawing.Point(88, 18)
        Me.txtCancelStockNo.Name = "txtCancelStockNo"
        Me.txtCancelStockNo.Size = New System.Drawing.Size(114, 25)
        Me.txtCancelStockNo.TabIndex = 6
        '
        'txtCancelSeqNo
        '
        Me.txtCancelSeqNo.Location = New System.Drawing.Point(88, 47)
        Me.txtCancelSeqNo.Name = "txtCancelSeqNo"
        Me.txtCancelSeqNo.Size = New System.Drawing.Size(114, 25)
        Me.txtCancelSeqNo.TabIndex = 7
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(227, 17)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(200, 23)
        Me.btnCancelOrder.TabIndex = 8
        Me.btnCancelOrder.Text = "Cancel Order By StockNo"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'btnCancelOrderBySeqNo
        '
        Me.btnCancelOrderBySeqNo.Location = New System.Drawing.Point(227, 48)
        Me.btnCancelOrderBySeqNo.Name = "btnCancelOrderBySeqNo"
        Me.btnCancelOrderBySeqNo.Size = New System.Drawing.Size(200, 23)
        Me.btnCancelOrderBySeqNo.TabIndex = 9
        Me.btnCancelOrderBySeqNo.Text = "CancelOrderBySeqNo"
        Me.btnCancelOrderBySeqNo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnQuery)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(802, 60)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "查詢"
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(16, 24)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(148, 23)
        Me.btnQuery.TabIndex = 0
        Me.btnQuery.Text = "查詢未平倉"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'FutureOrderControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FutureOrderControl"
        Me.Size = New System.Drawing.Size(810, 239)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
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
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents boxFlag As System.Windows.Forms.ComboBox
    Friend WithEvents boxPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents boxBidAsk As System.Windows.Forms.ComboBox
    Friend WithEvents btnSendFutureOrderAsync As System.Windows.Forms.Button
    Friend WithEvents btnSendFutureOrder As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents btnCancelOrderBySeqNo As System.Windows.Forms.Button
    Friend WithEvents btnCancelOrder As System.Windows.Forms.Button
    Friend WithEvents txtCancelSeqNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCancelStockNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button

End Class
