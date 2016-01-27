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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblServerTime = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblConnect = New System.Windows.Forms.Label()
        Me.btnEnterMonitor = New System.Windows.Forms.Button()
        Me.btnLeaveMonitor = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtStocks = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnQueryStocks = New System.Windows.Forms.Button()
        Me.gridStocks = New System.Windows.Forms.DataGridView()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtTick = New System.Windows.Forms.TextBox()
        Me.btnTick = New System.Windows.Forms.Button()
        Me.GridTick = New System.Windows.Forms.DataGridView()
        Me.GridBest5Ask = New System.Windows.Forms.DataGridView()
        Me.GridBest5Bid = New System.Windows.Forms.DataGridView()
        Me.timerServerTime = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridTick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBest5Ask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBest5Bid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(14, 54)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(75, 15)
        Me.lblPassword.TabIndex = 17
        Me.lblPassword.Text = "Password："
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(14, 22)
        Me.lblAccount.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(69, 15)
        Me.lblAccount.TabIndex = 16
        Me.lblAccount.Text = "Account："
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(91, 19)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(156, 25)
        Me.txtAccount.TabIndex = 18
        '
        'txtPassWord
        '
        Me.txtPassWord.Location = New System.Drawing.Point(91, 50)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWord.Size = New System.Drawing.Size(156, 25)
        Me.txtPassWord.TabIndex = 19
        '
        'btnInitialize
        '
        Me.btnInitialize.Font = New System.Drawing.Font("PMingLiU", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnInitialize.Location = New System.Drawing.Point(279, 22)
        Me.btnInitialize.Name = "btnInitialize"
        Me.btnInitialize.Size = New System.Drawing.Size(94, 53)
        Me.btnInitialize.TabIndex = 20
        Me.btnInitialize.Text = "Initialize"
        Me.btnInitialize.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblServerTime)
        Me.GroupBox1.Location = New System.Drawing.Point(431, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 53)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server Time"
        '
        'lblServerTime
        '
        Me.lblServerTime.AutoSize = True
        Me.lblServerTime.Location = New System.Drawing.Point(32, 24)
        Me.lblServerTime.Name = "lblServerTime"
        Me.lblServerTime.Size = New System.Drawing.Size(45, 15)
        Me.lblServerTime.TabIndex = 0
        Me.lblServerTime.Text = "--:--:--"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.lblConnect)
        Me.groupBox2.Location = New System.Drawing.Point(577, 19)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(71, 56)
        Me.groupBox2.TabIndex = 22
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "訊號"
        '
        'lblConnect
        '
        Me.lblConnect.AutoSize = True
        Me.lblConnect.Font = New System.Drawing.Font("PMingLiU", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblConnect.Location = New System.Drawing.Point(19, 22)
        Me.lblConnect.Name = "lblConnect"
        Me.lblConnect.Size = New System.Drawing.Size(32, 22)
        Me.lblConnect.TabIndex = 0
        Me.lblConnect.Text = "●"
        '
        'btnEnterMonitor
        '
        Me.btnEnterMonitor.Location = New System.Drawing.Point(17, 95)
        Me.btnEnterMonitor.Name = "btnEnterMonitor"
        Me.btnEnterMonitor.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterMonitor.TabIndex = 23
        Me.btnEnterMonitor.Text = "Connect"
        Me.btnEnterMonitor.UseVisualStyleBackColor = True
        '
        'btnLeaveMonitor
        '
        Me.btnLeaveMonitor.Location = New System.Drawing.Point(115, 95)
        Me.btnLeaveMonitor.Name = "btnLeaveMonitor"
        Me.btnLeaveMonitor.Size = New System.Drawing.Size(85, 23)
        Me.btnLeaveMonitor.TabIndex = 24
        Me.btnLeaveMonitor.Text = "DisConnect"
        Me.btnLeaveMonitor.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(206, 95)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 40)
        Me.button1.TabIndex = 25
        Me.button1.Text = "Time"
        Me.button1.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.lblMessage)
        Me.groupBox3.Location = New System.Drawing.Point(287, 81)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(416, 61)
        Me.groupBox3.TabIndex = 26
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "訊息"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(14, 27)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(55, 15)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Message"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 175)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(693, 330)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gridStocks)
        Me.TabPage1.Controls.Add(Me.btnQueryStocks)
        Me.TabPage1.Controls.Add(Me.label2)
        Me.TabPage1.Controls.Add(Me.txtStocks)
        Me.TabPage1.Controls.Add(Me.label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(685, 301)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "報價"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridBest5Bid)
        Me.TabPage2.Controls.Add(Me.GridBest5Ask)
        Me.TabPage2.Controls.Add(Me.GridTick)
        Me.TabPage2.Controls.Add(Me.btnTick)
        Me.TabPage2.Controls.Add(Me.txtTick)
        Me.TabPage2.Controls.Add(Me.label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(685, 301)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(9, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 1
        Me.label1.Text = "商品代碼"
        '
        'txtStocks
        '
        Me.txtStocks.Location = New System.Drawing.Point(82, 15)
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.Size = New System.Drawing.Size(183, 25)
        Me.txtStocks.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(271, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(148, 15)
        Me.label2.TabIndex = 3
        Me.label2.Text = "( 多筆以逗號{,}區隔 )"
        '
        'btnQueryStocks
        '
        Me.btnQueryStocks.Location = New System.Drawing.Point(425, 17)
        Me.btnQueryStocks.Name = "btnQueryStocks"
        Me.btnQueryStocks.Size = New System.Drawing.Size(75, 23)
        Me.btnQueryStocks.TabIndex = 4
        Me.btnQueryStocks.Text = "查詢"
        Me.btnQueryStocks.UseVisualStyleBackColor = True
        '
        'gridStocks
        '
        Me.gridStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridStocks.Location = New System.Drawing.Point(6, 46)
        Me.gridStocks.Name = "gridStocks"
        Me.gridStocks.RowHeadersVisible = False
        Me.gridStocks.RowTemplate.Height = 24
        Me.gridStocks.Size = New System.Drawing.Size(673, 249)
        Me.gridStocks.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(9, 17)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 15)
        Me.label3.TabIndex = 2
        Me.label3.Text = "商品代碼"
        '
        'txtTick
        '
        Me.txtTick.Location = New System.Drawing.Point(84, 14)
        Me.txtTick.Name = "txtTick"
        Me.txtTick.Size = New System.Drawing.Size(100, 25)
        Me.txtTick.TabIndex = 3
        '
        'btnTick
        '
        Me.btnTick.Location = New System.Drawing.Point(203, 16)
        Me.btnTick.Name = "btnTick"
        Me.btnTick.Size = New System.Drawing.Size(75, 23)
        Me.btnTick.TabIndex = 4
        Me.btnTick.Text = "查詢"
        Me.btnTick.UseVisualStyleBackColor = True
        '
        'GridTick
        '
        Me.GridTick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTick.Location = New System.Drawing.Point(45, 55)
        Me.GridTick.Name = "GridTick"
        Me.GridTick.RowHeadersVisible = False
        Me.GridTick.RowTemplate.Height = 24
        Me.GridTick.Size = New System.Drawing.Size(295, 240)
        Me.GridTick.TabIndex = 5
        '
        'GridBest5Ask
        '
        Me.GridBest5Ask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBest5Ask.Location = New System.Drawing.Point(365, 55)
        Me.GridBest5Ask.Name = "GridBest5Ask"
        Me.GridBest5Ask.RowHeadersVisible = False
        Me.GridBest5Ask.RowTemplate.Height = 24
        Me.GridBest5Ask.Size = New System.Drawing.Size(147, 240)
        Me.GridBest5Ask.TabIndex = 6
        '
        'GridBest5Bid
        '
        Me.GridBest5Bid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBest5Bid.Location = New System.Drawing.Point(518, 55)
        Me.GridBest5Bid.Name = "GridBest5Bid"
        Me.GridBest5Bid.RowHeadersVisible = False
        Me.GridBest5Bid.RowTemplate.Height = 24
        Me.GridBest5Bid.Size = New System.Drawing.Size(145, 240)
        Me.GridBest5Bid.TabIndex = 7
        '
        'timerServerTime
        '
        Me.timerServerTime.Interval = 1000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 517)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.btnLeaveMonitor)
        Me.Controls.Add(Me.btnEnterMonitor)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnInitialize)
        Me.Controls.Add(Me.txtPassWord)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblAccount)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.Text = "QuoteTesterVB"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.gridStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridTick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBest5Ask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBest5Bid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblPassword As System.Windows.Forms.Label
    Private WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents btnInitialize As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblServerTime As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblConnect As System.Windows.Forms.Label
    Friend WithEvents btnEnterMonitor As System.Windows.Forms.Button
    Friend WithEvents btnLeaveMonitor As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents txtStocks As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents btnQueryStocks As System.Windows.Forms.Button
    Friend WithEvents gridStocks As System.Windows.Forms.DataGridView
    Private WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents txtTick As System.Windows.Forms.TextBox
    Friend WithEvents GridBest5Bid As System.Windows.Forms.DataGridView
    Friend WithEvents GridBest5Ask As System.Windows.Forms.DataGridView
    Friend WithEvents GridTick As System.Windows.Forms.DataGridView
    Friend WithEvents btnTick As System.Windows.Forms.Button
    Friend WithEvents timerServerTime As System.Windows.Forms.Timer

End Class
