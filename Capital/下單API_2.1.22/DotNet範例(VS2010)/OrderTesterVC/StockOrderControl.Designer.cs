namespace OrderTester
{
    partial class StockOrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendStockOrderAsync = new System.Windows.Forms.Button();
            this.btnSendStockOrder = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.boxFlag = new System.Windows.Forms.ComboBox();
            this.boxPeriod = new System.Windows.Forms.ComboBox();
            this.boxBidAsk = new System.Windows.Forms.ComboBox();
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelOrderBySeqNo = new System.Windows.Forms.Button();
            this.txtCancelSeqNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCancelStockNo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQueryReport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDecreaseQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDecreaseQty = new System.Windows.Forms.Button();
            this.txtDecreaseSeqNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品代碼";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendStockOrderAsync);
            this.groupBox1.Controls.Add(this.btnSendStockOrder);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.boxFlag);
            this.groupBox1.Controls.Add(this.boxPeriod);
            this.groupBox1.Controls.Add(this.boxBidAsk);
            this.groupBox1.Controls.Add(this.txtStockNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "證券委託";
            // 
            // btnSendStockOrderAsync
            // 
            this.btnSendStockOrderAsync.Location = new System.Drawing.Point(582, 47);
            this.btnSendStockOrderAsync.Name = "btnSendStockOrderAsync";
            this.btnSendStockOrderAsync.Size = new System.Drawing.Size(190, 23);
            this.btnSendStockOrderAsync.TabIndex = 13;
            this.btnSendStockOrderAsync.Text = "SendStockOrderAsync";
            this.btnSendStockOrderAsync.UseVisualStyleBackColor = true;
            this.btnSendStockOrderAsync.Click += new System.EventHandler(this.btnSendStockOrderAsync_Click);
            // 
            // btnSendStockOrder
            // 
            this.btnSendStockOrder.Location = new System.Drawing.Point(582, 21);
            this.btnSendStockOrder.Name = "btnSendStockOrder";
            this.btnSendStockOrder.Size = new System.Drawing.Size(190, 23);
            this.btnSendStockOrder.TabIndex = 12;
            this.btnSendStockOrder.Text = "SendStockOrder";
            this.btnSendStockOrder.UseVisualStyleBackColor = true;
            this.btnSendStockOrder.Click += new System.EventHandler(this.btnSendStockOrder_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(502, 45);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(49, 25);
            this.txtQty.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(399, 45);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(74, 25);
            this.txtPrice.TabIndex = 10;
            // 
            // boxFlag
            // 
            this.boxFlag.FormattingEnabled = true;
            this.boxFlag.Items.AddRange(new object[] {
            "現股",
            "融資",
            "融券",
            "無券"});
            this.boxFlag.Location = new System.Drawing.Point(308, 47);
            this.boxFlag.Name = "boxFlag";
            this.boxFlag.Size = new System.Drawing.Size(64, 23);
            this.boxFlag.TabIndex = 9;
            // 
            // boxPeriod
            // 
            this.boxPeriod.FormattingEnabled = true;
            this.boxPeriod.Items.AddRange(new object[] {
            "整股",
            "盤後",
            "零股"});
            this.boxPeriod.Location = new System.Drawing.Point(205, 47);
            this.boxPeriod.Name = "boxPeriod";
            this.boxPeriod.Size = new System.Drawing.Size(64, 23);
            this.boxPeriod.TabIndex = 8;
            // 
            // boxBidAsk
            // 
            this.boxBidAsk.FormattingEnabled = true;
            this.boxBidAsk.Items.AddRange(new object[] {
            "買",
            "賣"});
            this.boxBidAsk.Location = new System.Drawing.Point(118, 47);
            this.boxBidAsk.Name = "boxBidAsk";
            this.boxBidAsk.Size = new System.Drawing.Size(49, 23);
            this.boxBidAsk.TabIndex = 7;
            // 
            // txtStockNo
            // 
            this.txtStockNo.Location = new System.Drawing.Point(19, 45);
            this.txtStockNo.MaxLength = 8;
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(64, 25);
            this.txtStockNo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "委託量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "委託價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "當沖與否";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "委託條件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "買賣別";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelOrderBySeqNo);
            this.groupBox2.Controls.Add(this.txtCancelSeqNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnCancelOrder);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCancelStockNo);
            this.groupBox2.Location = new System.Drawing.Point(3, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "取消委託";
            // 
            // btnCancelOrderBySeqNo
            // 
            this.btnCancelOrderBySeqNo.Location = new System.Drawing.Point(245, 48);
            this.btnCancelOrderBySeqNo.Name = "btnCancelOrderBySeqNo";
            this.btnCancelOrderBySeqNo.Size = new System.Drawing.Size(178, 23);
            this.btnCancelOrderBySeqNo.TabIndex = 5;
            this.btnCancelOrderBySeqNo.Text = "Cancel Order By SeqNo";
            this.btnCancelOrderBySeqNo.UseVisualStyleBackColor = true;
            this.btnCancelOrderBySeqNo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCancelSeqNo
            // 
            this.txtCancelSeqNo.Location = new System.Drawing.Point(103, 51);
            this.txtCancelSeqNo.Name = "txtCancelSeqNo";
            this.txtCancelSeqNo.Size = new System.Drawing.Size(136, 25);
            this.txtCancelSeqNo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "委託序號";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(245, 19);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(178, 23);
            this.btnCancelOrder.TabIndex = 2;
            this.btnCancelOrder.Text = "Cancel Order By StockNo";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "商品代碼";
            // 
            // txtCancelStockNo
            // 
            this.txtCancelStockNo.Location = new System.Drawing.Point(103, 20);
            this.txtCancelStockNo.Name = "txtCancelStockNo";
            this.txtCancelStockNo.Size = new System.Drawing.Size(136, 25);
            this.txtCancelStockNo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQueryReport);
            this.groupBox3.Location = new System.Drawing.Point(3, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 62);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查詢";
            // 
            // btnQueryReport
            // 
            this.btnQueryReport.Location = new System.Drawing.Point(19, 24);
            this.btnQueryReport.Name = "btnQueryReport";
            this.btnQueryReport.Size = new System.Drawing.Size(114, 23);
            this.btnQueryReport.TabIndex = 0;
            this.btnQueryReport.Text = " 查詢及時庫存";
            this.btnQueryReport.UseVisualStyleBackColor = true;
            this.btnQueryReport.Click += new System.EventHandler(this.btnQueryReport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDecreaseQty);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnDecreaseQty);
            this.groupBox4.Controls.Add(this.txtDecreaseSeqNo);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(3, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 62);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "委託減量";
            // 
            // txtDecreaseQty
            // 
            this.txtDecreaseQty.Location = new System.Drawing.Point(399, 24);
            this.txtDecreaseQty.Name = "txtDecreaseQty";
            this.txtDecreaseQty.Size = new System.Drawing.Size(72, 25);
            this.txtDecreaseQty.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = " 輸入欲減少的數量";
            // 
            // btnDecreaseQty
            // 
            this.btnDecreaseQty.Location = new System.Drawing.Point(582, 24);
            this.btnDecreaseQty.Name = "btnDecreaseQty";
            this.btnDecreaseQty.Size = new System.Drawing.Size(178, 23);
            this.btnDecreaseQty.TabIndex = 16;
            this.btnDecreaseQty.Text = "Decrease Order By SeqNo";
            this.btnDecreaseQty.UseVisualStyleBackColor = true;
            this.btnDecreaseQty.Click += new System.EventHandler(this.btnDecreaseQty_Click);
            // 
            // txtDecreaseSeqNo
            // 
            this.txtDecreaseSeqNo.Location = new System.Drawing.Point(103, 24);
            this.txtDecreaseSeqNo.Name = "txtDecreaseSeqNo";
            this.txtDecreaseSeqNo.Size = new System.Drawing.Size(136, 25);
            this.txtDecreaseSeqNo.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "委託序號";
            // 
            // StockOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockOrderControl";
            this.Size = new System.Drawing.Size(811, 325);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStockNo;
        private System.Windows.Forms.ComboBox boxBidAsk;
        private System.Windows.Forms.ComboBox boxPeriod;
        private System.Windows.Forms.ComboBox boxFlag;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSendStockOrder;
        private System.Windows.Forms.Button btnSendStockOrderAsync;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCancelStockNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelOrderBySeqNo;
        private System.Windows.Forms.TextBox txtCancelSeqNo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQueryReport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDecreaseQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDecreaseQty;
        private System.Windows.Forms.TextBox txtDecreaseSeqNo;
        private System.Windows.Forms.Label label11;

    }
}
