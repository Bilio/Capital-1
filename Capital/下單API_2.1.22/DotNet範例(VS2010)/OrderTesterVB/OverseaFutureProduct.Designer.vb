<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverseaFutureProduct
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
        Me.GridProducts = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridProducts
        '
        Me.GridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.GridProducts.Location = New System.Drawing.Point(12, 12)
        Me.GridProducts.Name = "GridProducts"
        Me.GridProducts.RowHeadersVisible = False
        Me.GridProducts.RowTemplate.Height = 24
        Me.GridProducts.Size = New System.Drawing.Size(726, 307)
        Me.GridProducts.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "交易所代碼"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 72
        '
        'Column2
        '
        Me.Column2.HeaderText = "交易所名稱"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 72
        '
        'Column3
        '
        Me.Column3.HeaderText = "商品代碼"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 61
        '
        'Column4
        '
        Me.Column4.HeaderText = "商品名稱"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 61
        '
        'Column5
        '
        Me.Column5.HeaderText = "年月"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 51
        '
        'Column6
        '
        Me.Column6.HeaderText = "跳動點"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 61
        '
        'Column7
        '
        Me.Column7.HeaderText = "分母"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 51
        '
        'Column8
        '
        Me.Column8.HeaderText = "可接受交易種類"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 83
        '
        'OverseaFutureProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 331)
        Me.Controls.Add(Me.GridProducts)
        Me.Name = "OverseaFutureProduct"
        Me.Text = "OverseaFutureProduct"
        CType(Me.GridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridProducts As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
