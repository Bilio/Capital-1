<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtPassWord = New System.Windows.Forms.TextBox()
        Me.btnInitialize = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblConnect = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblServerTime = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnServerTime = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gridStocks = New System.Windows.Forms.DataGridView()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnQueryStocks = New System.Windows.Forms.Button()
        Me.txtStocks = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gridBest5Bid = New System.Windows.Forms.DataGridView()
        Me.gridBest5Ask = New System.Windows.Forms.DataGridView()
        Me.listTicks = New System.Windows.Forms.ListBox()
        Me.btnTick = New System.Windows.Forms.Button()
        Me.txtTick = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.listOverseaProducts = New System.Windows.Forms.ListBox()
        Me.btnOverseaProducts = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.listKLine = New System.Windows.Forms.ListBox()
        Me.btnKLine = New System.Windows.Forms.Button()
        Me.boxKLineType = New System.Windows.Forms.ComboBox()
        Me.txtKLine = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.gridStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridBest5Bid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBest5Ask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(15, 56)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(75, 15)
        Me.lblPassword.TabIndex = 22
        Me.lblPassword.Text = "Password："
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(15, 21)
        Me.lblAccount.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(69, 15)
        Me.lblAccount.TabIndex = 21
        Me.lblAccount.Text = "Account："
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(93, 18)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(161, 25)
        Me.txtAccount.TabIndex = 23
        '
        'txtPassWord
        '
        Me.txtPassWord.Location = New System.Drawing.Point(93, 53)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWord.Size = New System.Drawing.Size(161, 25)
        Me.txtPassWord.TabIndex = 24
        '
        'btnInitialize
        '
        Me.btnInitialize.Font = New System.Drawing.Font("PMingLiU", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnInitialize.Location = New System.Drawing.Point(292, 18)
        Me.btnInitialize.Name = "btnInitialize"
        Me.btnInitialize.Size = New System.Drawing.Size(103, 60)
        Me.btnInitialize.TabIndex = 25
        Me.btnInitialize.Text = "Initialize"
        Me.btnInitialize.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.lblConnect)
        Me.groupBox2.Location = New System.Drawing.Point(438, 18)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(71, 62)
        Me.groupBox2.TabIndex = 26
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "訊號"
        '
        'lblConnect
        '
        Me.lblConnect.AutoSize = True
        Me.lblConnect.Font = New System.Drawing.Font("PMingLiU", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblConnect.Location = New System.Drawing.Point(17, 22)
        Me.lblConnect.Name = "lblConnect"
        Me.lblConnect.Size = New System.Drawing.Size(34, 24)
        Me.lblConnect.TabIndex = 0
        Me.lblConnect.Text = "●"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblServerTime)
        Me.groupBox1.Location = New System.Drawing.Point(566, 18)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(135, 62)
        Me.groupBox1.TabIndex = 29
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Server Time"
        '
        'lblServerTime
        '
        Me.lblServerTime.AutoSize = True
        Me.lblServerTime.Font = New System.Drawing.Font("PMingLiU", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblServerTime.Location = New System.Drawing.Point(27, 26)
        Me.lblServerTime.Name = "lblServerTime"
        Me.lblServerTime.Size = New System.Drawing.Size(55, 19)
        Me.lblServerTime.TabIndex = 0
        Me.lblServerTime.Text = "--:--:--"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.lblMessage)
        Me.groupBox3.Location = New System.Drawing.Point(292, 86)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(535, 51)
        Me.groupBox3.TabIndex = 30
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "訊息"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(15, 21)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(55, 15)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Message"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(18, 103)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 31
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(99, 103)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(89, 23)
        Me.btnDisconnect.TabIndex = 32
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnServerTime
        '
        Me.btnServerTime.Location = New System.Drawing.Point(211, 95)
        Me.btnServerTime.Name = "btnServerTime"
        Me.btnServerTime.Size = New System.Drawing.Size(55, 38)
        Me.btnServerTime.TabIndex = 33
        Me.btnServerTime.Text = "ServerTime"
        Me.btnServerTime.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 143)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(815, 313)
        Me.TabControl1.TabIndex = 34
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gridStocks)
        Me.TabPage1.Controls.Add(Me.label2)
        Me.TabPage1.Controls.Add(Me.btnQueryStocks)
        Me.TabPage1.Controls.Add(Me.txtStocks)
        Me.TabPage1.Controls.Add(Me.label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(807, 284)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "報價"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gridStocks
        '
        Me.gridStocks.AllowUserToDeleteRows = False
        Me.gridStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridStocks.Location = New System.Drawing.Point(6, 69)
        Me.gridStocks.MultiSelect = False
        Me.gridStocks.Name = "gridStocks"
        Me.gridStocks.ReadOnly = True
        Me.gridStocks.RowHeadersVisible = False
        Me.gridStocks.RowTemplate.Height = 24
        Me.gridStocks.Size = New System.Drawing.Size(795, 209)
        Me.gridStocks.TabIndex = 9
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(357, 45)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(365, 15)
        Me.label2.TabIndex = 8
        Me.label2.Text = "格式 [ 交易代碼,商品報價代碼 ] ( 多筆以 井號{#}區隔 )"
        '
        'btnQueryStocks
        '
        Me.btnQueryStocks.Location = New System.Drawing.Point(360, 6)
        Me.btnQueryStocks.Name = "btnQueryStocks"
        Me.btnQueryStocks.Size = New System.Drawing.Size(113, 36)
        Me.btnQueryStocks.TabIndex = 7
        Me.btnQueryStocks.Text = "查詢"
        Me.btnQueryStocks.UseVisualStyleBackColor = True
        '
        'txtStocks
        '
        Me.txtStocks.Location = New System.Drawing.Point(83, 26)
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.Size = New System.Drawing.Size(263, 25)
        Me.txtStocks.TabIndex = 6
        Me.txtStocks.Text = "CBT,ZB1203#CME,ES_1203"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(10, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 5
        Me.label1.Text = "商品代碼"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridBest5Bid)
        Me.TabPage2.Controls.Add(Me.gridBest5Ask)
        Me.TabPage2.Controls.Add(Me.listTicks)
        Me.TabPage2.Controls.Add(Me.btnTick)
        Me.TabPage2.Controls.Add(Me.txtTick)
        Me.TabPage2.Controls.Add(Me.label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(807, 284)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TICKS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gridBest5Bid
        '
        Me.gridBest5Bid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBest5Bid.Location = New System.Drawing.Point(637, 64)
        Me.gridBest5Bid.Name = "gridBest5Bid"
        Me.gridBest5Bid.RowHeadersVisible = False
        Me.gridBest5Bid.RowTemplate.Height = 24
        Me.gridBest5Bid.Size = New System.Drawing.Size(149, 214)
        Me.gridBest5Bid.TabIndex = 10
        '
        'gridBest5Ask
        '
        Me.gridBest5Ask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBest5Ask.Location = New System.Drawing.Point(443, 64)
        Me.gridBest5Ask.Name = "gridBest5Ask"
        Me.gridBest5Ask.RowHeadersVisible = False
        Me.gridBest5Ask.RowTemplate.Height = 24
        Me.gridBest5Ask.Size = New System.Drawing.Size(163, 214)
        Me.gridBest5Ask.TabIndex = 9
        '
        'listTicks
        '
        Me.listTicks.FormattingEnabled = True
        Me.listTicks.ItemHeight = 15
        Me.listTicks.Location = New System.Drawing.Point(54, 64)
        Me.listTicks.Name = "listTicks"
        Me.listTicks.Size = New System.Drawing.Size(325, 214)
        Me.listTicks.TabIndex = 8
        '
        'btnTick
        '
        Me.btnTick.Location = New System.Drawing.Point(400, 12)
        Me.btnTick.Name = "btnTick"
        Me.btnTick.Size = New System.Drawing.Size(93, 25)
        Me.btnTick.TabIndex = 7
        Me.btnTick.Text = "查詢"
        Me.btnTick.UseVisualStyleBackColor = True
        '
        'txtTick
        '
        Me.txtTick.Location = New System.Drawing.Point(256, 12)
        Me.txtTick.Name = "txtTick"
        Me.txtTick.Size = New System.Drawing.Size(100, 25)
        Me.txtTick.TabIndex = 6
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(183, 22)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 15)
        Me.label3.TabIndex = 5
        Me.label3.Text = "商品代碼"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.listOverseaProducts)
        Me.TabPage3.Controls.Add(Me.btnOverseaProducts)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(807, 284)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "商品"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'listOverseaProducts
        '
        Me.listOverseaProducts.FormattingEnabled = True
        Me.listOverseaProducts.ItemHeight = 15
        Me.listOverseaProducts.Location = New System.Drawing.Point(83, 82)
        Me.listOverseaProducts.Name = "listOverseaProducts"
        Me.listOverseaProducts.Size = New System.Drawing.Size(616, 199)
        Me.listOverseaProducts.TabIndex = 1
        '
        'btnOverseaProducts
        '
        Me.btnOverseaProducts.Location = New System.Drawing.Point(225, 6)
        Me.btnOverseaProducts.Name = "btnOverseaProducts"
        Me.btnOverseaProducts.Size = New System.Drawing.Size(304, 59)
        Me.btnOverseaProducts.TabIndex = 0
        Me.btnOverseaProducts.Text = "OverseaProducts"
        Me.btnOverseaProducts.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.listKLine)
        Me.TabPage4.Controls.Add(Me.btnKLine)
        Me.TabPage4.Controls.Add(Me.boxKLineType)
        Me.TabPage4.Controls.Add(Me.txtKLine)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(807, 284)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "KLine"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'listKLine
        '
        Me.listKLine.FormattingEnabled = True
        Me.listKLine.ItemHeight = 15
        Me.listKLine.Location = New System.Drawing.Point(77, 63)
        Me.listKLine.Name = "listKLine"
        Me.listKLine.Size = New System.Drawing.Size(667, 214)
        Me.listKLine.TabIndex = 10
        '
        'btnKLine
        '
        Me.btnKLine.Location = New System.Drawing.Point(482, 13)
        Me.btnKLine.Name = "btnKLine"
        Me.btnKLine.Size = New System.Drawing.Size(82, 30)
        Me.btnKLine.TabIndex = 9
        Me.btnKLine.Text = "查詢"
        Me.btnKLine.UseVisualStyleBackColor = True
        '
        'boxKLineType
        '
        Me.boxKLineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxKLineType.FormattingEnabled = True
        Me.boxKLineType.Items.AddRange(New Object() {"分鐘線", "日線", "週線", "月線"})
        Me.boxKLineType.Location = New System.Drawing.Point(349, 17)
        Me.boxKLineType.Name = "boxKLineType"
        Me.boxKLineType.Size = New System.Drawing.Size(112, 23)
        Me.boxKLineType.TabIndex = 8
        '
        'txtKLine
        '
        Me.txtKLine.Location = New System.Drawing.Point(233, 17)
        Me.txtKLine.Name = "txtKLine"
        Me.txtKLine.Size = New System.Drawing.Size(100, 25)
        Me.txtKLine.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "商品代碼"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 468)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnServerTime)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.btnInitialize)
        Me.Controls.Add(Me.txtPassWord)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblAccount)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.Text = "OSQUote"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.gridStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.gridBest5Bid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBest5Ask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblPassword As System.Windows.Forms.Label
    Private WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents btnInitialize As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblConnect As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblServerTime As System.Windows.Forms.Label
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnServerTime As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents btnQueryStocks As System.Windows.Forms.Button
    Friend WithEvents txtStocks As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents gridStocks As System.Windows.Forms.DataGridView
    Friend WithEvents btnTick As System.Windows.Forms.Button
    Friend WithEvents txtTick As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents listTicks As System.Windows.Forms.ListBox
    Friend WithEvents gridBest5Bid As System.Windows.Forms.DataGridView
    Friend WithEvents gridBest5Ask As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents listOverseaProducts As System.Windows.Forms.ListBox
    Friend WithEvents btnOverseaProducts As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnKLine As System.Windows.Forms.Button
    Friend WithEvents boxKLineType As System.Windows.Forms.ComboBox
    Friend WithEvents txtKLine As System.Windows.Forms.TextBox
    Friend WithEvents listKLine As System.Windows.Forms.ListBox

End Class
