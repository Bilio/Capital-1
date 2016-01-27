<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnTEST = New System.Windows.Forms.Button()
        Me.lstR = New System.Windows.Forms.ListBox()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.dgvReply = New System.Windows.Forms.DataGridView()
        Me.cbxStopOrder = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbxM = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tbxTime = New System.Windows.Forms.TextBox()
        Me.cbxStopCancel = New System.Windows.Forms.CheckBox()
        Me.timSum = New System.Windows.Forms.Timer(Me.components)
        Me.timInv = New System.Windows.Forms.Timer(Me.components)
        Me.btnTarget = New System.Windows.Forms.Button()
        Me.btnWarrant = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReply, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTEST
        '
        Me.btnTEST.Location = New System.Drawing.Point(595, 92)
        Me.btnTEST.Name = "btnTEST"
        Me.btnTEST.Size = New System.Drawing.Size(75, 23)
        Me.btnTEST.TabIndex = 1
        Me.btnTEST.Text = "TEST"
        Me.btnTEST.UseVisualStyleBackColor = True
        '
        'lstR
        '
        Me.lstR.FormattingEnabled = True
        Me.lstR.HorizontalScrollbar = True
        Me.lstR.ItemHeight = 12
        Me.lstR.Location = New System.Drawing.Point(12, 12)
        Me.lstR.Name = "lstR"
        Me.lstR.Size = New System.Drawing.Size(332, 100)
        Me.lstR.TabIndex = 2
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventory.Location = New System.Drawing.Point(12, 262)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowHeadersWidth = 21
        Me.dgvInventory.RowTemplate.Height = 18
        Me.dgvInventory.Size = New System.Drawing.Size(658, 152)
        Me.dgvInventory.TabIndex = 27
        '
        'dgvReply
        '
        Me.dgvReply.AllowUserToAddRows = False
        Me.dgvReply.AllowUserToDeleteRows = False
        Me.dgvReply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReply.Location = New System.Drawing.Point(12, 118)
        Me.dgvReply.Name = "dgvReply"
        Me.dgvReply.ReadOnly = True
        Me.dgvReply.RowHeadersWidth = 21
        Me.dgvReply.RowTemplate.Height = 18
        Me.dgvReply.Size = New System.Drawing.Size(658, 138)
        Me.dgvReply.TabIndex = 28
        '
        'cbxStopOrder
        '
        Me.cbxStopOrder.AutoSize = True
        Me.cbxStopOrder.Checked = True
        Me.cbxStopOrder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxStopOrder.Location = New System.Drawing.Point(350, 96)
        Me.cbxStopOrder.Name = "cbxStopOrder"
        Me.cbxStopOrder.Size = New System.Drawing.Size(72, 16)
        Me.cbxStopOrder.TabIndex = 44
        Me.cbxStopOrder.Text = "停止下單"
        Me.cbxStopOrder.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(654, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 12)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "萬"
        '
        'tbxM
        '
        Me.tbxM.Location = New System.Drawing.Point(622, 57)
        Me.tbxM.Name = "tbxM"
        Me.tbxM.Size = New System.Drawing.Size(35, 22)
        Me.tbxM.TabIndex = 54
        Me.tbxM.Text = "100"
        Me.tbxM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(628, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 12)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "資金"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'tbxTime
        '
        Me.tbxTime.Location = New System.Drawing.Point(606, 15)
        Me.tbxTime.Name = "tbxTime"
        Me.tbxTime.Size = New System.Drawing.Size(64, 22)
        Me.tbxTime.TabIndex = 55
        Me.tbxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxStopCancel
        '
        Me.cbxStopCancel.AutoSize = True
        Me.cbxStopCancel.Location = New System.Drawing.Point(428, 96)
        Me.cbxStopCancel.Name = "cbxStopCancel"
        Me.cbxStopCancel.Size = New System.Drawing.Size(48, 16)
        Me.cbxStopCancel.TabIndex = 58
        Me.cbxStopCancel.Text = "停刪"
        Me.cbxStopCancel.UseVisualStyleBackColor = True
        '
        'timSum
        '
        Me.timSum.Interval = 1000
        '
        'timInv
        '
        Me.timInv.Interval = 5000
        '
        'btnTarget
        '
        Me.btnTarget.Location = New System.Drawing.Point(350, 41)
        Me.btnTarget.Name = "btnTarget"
        Me.btnTarget.Size = New System.Drawing.Size(49, 23)
        Me.btnTarget.TabIndex = 61
        Me.btnTarget.Text = "標的表"
        Me.btnTarget.UseVisualStyleBackColor = True
        '
        'btnWarrant
        '
        Me.btnWarrant.Location = New System.Drawing.Point(350, 15)
        Me.btnWarrant.Name = "btnWarrant"
        Me.btnWarrant.Size = New System.Drawing.Size(49, 23)
        Me.btnWarrant.TabIndex = 60
        Me.btnWarrant.Text = "權證表"
        Me.btnWarrant.UseVisualStyleBackColor = True
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(350, 67)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(49, 23)
        Me.btnSummary.TabIndex = 59
        Me.btnSummary.Text = "彙總表"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 429)
        Me.Controls.Add(Me.btnTarget)
        Me.Controls.Add(Me.btnWarrant)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.cbxStopCancel)
        Me.Controls.Add(Me.tbxTime)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbxM)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbxStopOrder)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.dgvReply)
        Me.Controls.Add(Me.btnTEST)
        Me.Controls.Add(Me.lstR)
        Me.Name = "Form1"
        Me.Text = "權證套利"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReply, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTEST As Button
    Friend WithEvents lstR As ListBox
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents dgvReply As DataGridView
    Friend WithEvents cbxStopOrder As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbxM As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tbxTime As TextBox
    Friend WithEvents cbxStopCancel As CheckBox
    Friend WithEvents timSum As Timer
    Friend WithEvents timInv As Timer
    Friend WithEvents btnTarget As Button
    Friend WithEvents btnWarrant As Button
    Friend WithEvents btnSummary As Button
End Class
