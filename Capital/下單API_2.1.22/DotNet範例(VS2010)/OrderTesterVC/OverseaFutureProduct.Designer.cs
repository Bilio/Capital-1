namespace OrderTester
{
    partial class OverseaFutureProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridProducts = new System.Windows.Forms.DataGridView();
            this.交易所代碼 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.交易所名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品代碼 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年月 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.跳動點 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分母 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.可接受交易種類 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // GridProducts
            // 
            this.GridProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.交易所代碼,
            this.交易所名稱,
            this.商品代碼,
            this.商品名稱,
            this.年月,
            this.跳動點,
            this.分母,
            this.可接受交易種類});
            this.GridProducts.Location = new System.Drawing.Point(12, 12);
            this.GridProducts.Name = "GridProducts";
            this.GridProducts.RowTemplate.Height = 24;
            this.GridProducts.Size = new System.Drawing.Size(780, 238);
            this.GridProducts.TabIndex = 0;
            // 
            // 交易所代碼
            // 
            this.交易所代碼.FillWeight = 82.44849F;
            this.交易所代碼.HeaderText = "交易所代碼";
            this.交易所代碼.Name = "交易所代碼";
            this.交易所代碼.ReadOnly = true;
            // 
            // 交易所名稱
            // 
            this.交易所名稱.FillWeight = 103.0606F;
            this.交易所名稱.HeaderText = "交易所名稱";
            this.交易所名稱.Name = "交易所名稱";
            // 
            // 商品代碼
            // 
            this.商品代碼.FillWeight = 103.0606F;
            this.商品代碼.HeaderText = "商品代碼";
            this.商品代碼.Name = "商品代碼";
            // 
            // 商品名稱
            // 
            this.商品名稱.FillWeight = 103.0606F;
            this.商品名稱.HeaderText = "商品名稱";
            this.商品名稱.Name = "商品名稱";
            // 
            // 年月
            // 
            this.年月.FillWeight = 103.0606F;
            this.年月.HeaderText = "年月";
            this.年月.Name = "年月";
            // 
            // 跳動點
            // 
            this.跳動點.FillWeight = 103.0606F;
            this.跳動點.HeaderText = "跳動點";
            this.跳動點.Name = "跳動點";
            // 
            // 分母
            // 
            this.分母.FillWeight = 79.18782F;
            this.分母.HeaderText = "分母";
            this.分母.Name = "分母";
            // 
            // 可接受交易種類
            // 
            this.可接受交易種類.FillWeight = 103.0606F;
            this.可接受交易種類.HeaderText = "可接受交易種類";
            this.可接受交易種類.Name = "可接受交易種類";
            // 
            // OverseaFutureProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 285);
            this.Controls.Add(this.GridProducts);
            this.Name = "OverseaFutureProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverseaFutureProduct";
            this.Load += new System.EventHandler(this.OverseaFutureProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn 交易所代碼;
        private System.Windows.Forms.DataGridViewTextBoxColumn 交易所名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品代碼;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年月;
        private System.Windows.Forms.DataGridViewTextBoxColumn 跳動點;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分母;
        private System.Windows.Forms.DataGridViewTextBoxColumn 可接受交易種類;
    }
}