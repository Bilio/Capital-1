<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TradeStationControl
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
        Me.btnInitializeTS = New System.Windows.Forms.Button()
        Me.listTSInfo = New System.Windows.Forms.ListBox()
        Me.lblInitialize = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblInitialize)
        Me.GroupBox1.Controls.Add(Me.btnInitializeTS)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "初始"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listTSInfo)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(807, 201)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TS"
        '
        'btnInitializeTS
        '
        Me.btnInitializeTS.Location = New System.Drawing.Point(6, 19)
        Me.btnInitializeTS.Name = "btnInitializeTS"
        Me.btnInitializeTS.Size = New System.Drawing.Size(109, 28)
        Me.btnInitializeTS.TabIndex = 0
        Me.btnInitializeTS.Text = "訊號接收"
        Me.btnInitializeTS.UseVisualStyleBackColor = True
        '
        'listTSInfo
        '
        Me.listTSInfo.FormattingEnabled = True
        Me.listTSInfo.ItemHeight = 15
        Me.listTSInfo.Location = New System.Drawing.Point(6, 24)
        Me.listTSInfo.Name = "listTSInfo"
        Me.listTSInfo.Size = New System.Drawing.Size(795, 169)
        Me.listTSInfo.TabIndex = 0
        '
        'lblInitialize
        '
        Me.lblInitialize.AutoSize = True
        Me.lblInitialize.Location = New System.Drawing.Point(142, 26)
        Me.lblInitialize.Name = "lblInitialize"
        Me.lblInitialize.Size = New System.Drawing.Size(55, 15)
        Me.lblInitialize.TabIndex = 1
        Me.lblInitialize.Text = "Message"
        '
        'TradeStationControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("PMingLiU", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "TradeStationControl"
        Me.Size = New System.Drawing.Size(810, 266)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnInitializeTS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents listTSInfo As System.Windows.Forms.ListBox
    Friend WithEvents lblInitialize As System.Windows.Forms.Label

End Class
