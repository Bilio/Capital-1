namespace OrderTester
{
    partial class OptionOrderControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendOptionOrderAsync = new System.Windows.Forms.Button();
            this.btnSendOptionOrder = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelOrderBySeqNo = new System.Windows.Forms.Button();
            this.txtCancelSeqNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCancelStockNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendOptionOrderAsync);
            this.groupBox1.Controls.Add(this.btnSendOptionOrder);
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
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇權委託";
            // 
            // btnSendOptionOrderAsync
            // 
            this.btnSendOptionOrderAsync.Location = new System.Drawing.Point(582, 47);
            this.btnSendOptionOrderAsync.Name = "btnSendOptionOrderAsync";
            this.btnSendOptionOrderAsync.Size = new System.Drawing.Size(190, 23);
            this.btnSendOptionOrderAsync.TabIndex = 13;
            this.btnSendOptionOrderAsync.Text = "SendOptionOrderAsync";
            this.btnSendOptionOrderAsync.UseVisualStyleBackColor = true;
            this.btnSendOptionOrderAsync.Click += new System.EventHandler(this.btnSendOptionOrderAsync_Click);
            // 
            // btnSendOptionOrder
            // 
            this.btnSendOptionOrder.Location = new System.Drawing.Point(582, 21);
            this.btnSendOptionOrder.Name = "btnSendOptionOrder";
            this.btnSendOptionOrder.Size = new System.Drawing.Size(190, 23);
            this.btnSendOptionOrder.TabIndex = 12;
            this.btnSendOptionOrder.Text = "SendOptionOrder";
            this.btnSendOptionOrder.UseVisualStyleBackColor = true;
            this.btnSendOptionOrder.Click += new System.EventHandler(this.btnSendOptionOrder_Click);
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
            "新倉",
            "平倉",
            "自動"});
            this.boxFlag.Location = new System.Drawing.Point(303, 45);
            this.boxFlag.Name = "boxFlag";
            this.boxFlag.Size = new System.Drawing.Size(68, 23);
            this.boxFlag.TabIndex = 9;
            // 
            // boxPeriod
            // 
            this.boxPeriod.FormattingEnabled = true;
            this.boxPeriod.Items.AddRange(new object[] {
            "ROD",
            "IOC",
            "FOK"});
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
            this.txtStockNo.MaxLength = 20;
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(93, 25);
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
            this.label4.Location = new System.Drawing.Point(315, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "倉別";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品代碼";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelOrderBySeqNo);
            this.groupBox2.Controls.Add(this.txtCancelSeqNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnCancelOrder);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCancelStockNo);
            this.groupBox2.Location = new System.Drawing.Point(3, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 88);
            this.groupBox2.TabIndex = 4;
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
            this.btnCancelOrderBySeqNo.Click += new System.EventHandler(this.btnCancelOrderBySeqNo_Click);
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
            // OptionOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OptionOrderControl";
            this.Size = new System.Drawing.Size(810, 259);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSendOptionOrderAsync;
        private System.Windows.Forms.Button btnSendOptionOrder;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox boxFlag;
        private System.Windows.Forms.ComboBox boxPeriod;
        private System.Windows.Forms.ComboBox boxBidAsk;
        private System.Windows.Forms.TextBox txtStockNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelOrderBySeqNo;
        private System.Windows.Forms.TextBox txtCancelSeqNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCancelStockNo;
    }
}
