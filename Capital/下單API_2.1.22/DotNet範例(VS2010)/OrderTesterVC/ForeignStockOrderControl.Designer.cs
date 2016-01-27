namespace OrderTester
{
    partial class ForeignStockOrderControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxAccountType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxCurrency1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxCurrency2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxCurrency3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxExchange = new System.Windows.Forms.ComboBox();
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.boxBidAsk = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSendForeignStockOrderAsync = new System.Windows.Forms.Button();
            this.btnSendForeignStockOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.boxCancelExchange = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCancelOrderBySeqNo = new System.Windows.Forms.Button();
            this.txtCancelSeqNo = new System.Windows.Forms.TextBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.txtCancelBookNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendForeignStockOrderAsync);
            this.groupBox1.Controls.Add(this.btnSendForeignStockOrder);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.boxBidAsk);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtStockNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.boxExchange);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.boxCurrency3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boxCurrency2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boxCurrency1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boxAccountType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "複委託 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "專戶別：";
            // 
            // boxAccountType
            // 
            this.boxAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAccountType.FormattingEnabled = true;
            this.boxAccountType.Items.AddRange(new object[] {
            "外幣專戶",
            "台幣專戶"});
            this.boxAccountType.Location = new System.Drawing.Point(95, 18);
            this.boxAccountType.Name = "boxAccountType";
            this.boxAccountType.Size = new System.Drawing.Size(88, 23);
            this.boxAccountType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "扣款幣別順序：";
            // 
            // boxCurrency1
            // 
            this.boxCurrency1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCurrency1.FormattingEnabled = true;
            this.boxCurrency1.Items.AddRange(new object[] {
            "HKD",
            "NTD",
            "USD",
            "JPY",
            "SGD",
            "EUR",
            "AUD"});
            this.boxCurrency1.Location = new System.Drawing.Point(370, 18);
            this.boxCurrency1.Name = "boxCurrency1";
            this.boxCurrency1.Size = new System.Drawing.Size(60, 23);
            this.boxCurrency1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "1.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "2.";
            // 
            // boxCurrency2
            // 
            this.boxCurrency2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCurrency2.FormattingEnabled = true;
            this.boxCurrency2.Items.AddRange(new object[] {
            "HKD",
            "NTD",
            "USD",
            "JPY",
            "SGD",
            "EUR",
            "AUD"});
            this.boxCurrency2.Location = new System.Drawing.Point(469, 18);
            this.boxCurrency2.Name = "boxCurrency2";
            this.boxCurrency2.Size = new System.Drawing.Size(60, 23);
            this.boxCurrency2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "3.";
            // 
            // boxCurrency3
            // 
            this.boxCurrency3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCurrency3.FormattingEnabled = true;
            this.boxCurrency3.Items.AddRange(new object[] {
            "HKD",
            "NTD",
            "USD",
            "JPY",
            "SGD",
            "EUR",
            "AUD"});
            this.boxCurrency3.Location = new System.Drawing.Point(566, 18);
            this.boxCurrency3.Name = "boxCurrency3";
            this.boxCurrency3.Size = new System.Drawing.Size(60, 23);
            this.boxCurrency3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "交易所";
            // 
            // boxExchange
            // 
            this.boxExchange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxExchange.FormattingEnabled = true;
            this.boxExchange.Items.AddRange(new object[] {
            "美股",
            "港股"});
            this.boxExchange.Location = new System.Drawing.Point(16, 76);
            this.boxExchange.Name = "boxExchange";
            this.boxExchange.Size = new System.Drawing.Size(73, 23);
            this.boxExchange.TabIndex = 10;
            // 
            // txtStockNo
            // 
            this.txtStockNo.Location = new System.Drawing.Point(110, 76);
            this.txtStockNo.MaxLength = 8;
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(64, 25);
            this.txtStockNo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "商品代碼";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(385, 76);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(49, 25);
            this.txtQty.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(282, 76);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(74, 25);
            this.txtPrice.TabIndex = 17;
            // 
            // boxBidAsk
            // 
            this.boxBidAsk.FormattingEnabled = true;
            this.boxBidAsk.Items.AddRange(new object[] {
            "買",
            "賣"});
            this.boxBidAsk.Location = new System.Drawing.Point(203, 78);
            this.boxBidAsk.Name = "boxBidAsk";
            this.boxBidAsk.Size = new System.Drawing.Size(49, 23);
            this.boxBidAsk.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "委託量";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "委託價";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "買賣別";
            // 
            // btnSendForeignStockOrderAsync
            // 
            this.btnSendForeignStockOrderAsync.Location = new System.Drawing.Point(566, 78);
            this.btnSendForeignStockOrderAsync.Name = "btnSendForeignStockOrderAsync";
            this.btnSendForeignStockOrderAsync.Size = new System.Drawing.Size(190, 23);
            this.btnSendForeignStockOrderAsync.TabIndex = 20;
            this.btnSendForeignStockOrderAsync.Text = "SendForeignStockOrderAsync";
            this.btnSendForeignStockOrderAsync.UseVisualStyleBackColor = true;
            this.btnSendForeignStockOrderAsync.Click += new System.EventHandler(this.btnSendForeignStockOrderAsync_Click);
            // 
            // btnSendForeignStockOrder
            // 
            this.btnSendForeignStockOrder.Location = new System.Drawing.Point(566, 52);
            this.btnSendForeignStockOrder.Name = "btnSendForeignStockOrder";
            this.btnSendForeignStockOrder.Size = new System.Drawing.Size(190, 23);
            this.btnSendForeignStockOrder.TabIndex = 19;
            this.btnSendForeignStockOrder.Text = "SendForeignStockOrder";
            this.btnSendForeignStockOrder.UseVisualStyleBackColor = true;
            this.btnSendForeignStockOrder.Click += new System.EventHandler(this.btnSendForeignStockOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelOrderBySeqNo);
            this.groupBox2.Controls.Add(this.txtCancelSeqNo);
            this.groupBox2.Controls.Add(this.btnCancelOrder);
            this.groupBox2.Controls.Add(this.txtCancelBookNo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.boxCancelExchange);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(3, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "取消委託";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "交易所";
            // 
            // boxCancelExchange
            // 
            this.boxCancelExchange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCancelExchange.FormattingEnabled = true;
            this.boxCancelExchange.Items.AddRange(new object[] {
            "美股",
            "港股"});
            this.boxCancelExchange.Location = new System.Drawing.Point(12, 45);
            this.boxCancelExchange.Name = "boxCancelExchange";
            this.boxCancelExchange.Size = new System.Drawing.Size(73, 23);
            this.boxCancelExchange.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "委託書號刪單：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(122, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "委託序號刪單：";
            // 
            // btnCancelOrderBySeqNo
            // 
            this.btnCancelOrderBySeqNo.Location = new System.Drawing.Point(414, 54);
            this.btnCancelOrderBySeqNo.Name = "btnCancelOrderBySeqNo";
            this.btnCancelOrderBySeqNo.Size = new System.Drawing.Size(230, 23);
            this.btnCancelOrderBySeqNo.TabIndex = 17;
            this.btnCancelOrderBySeqNo.Text = "Cancel ForeignOrder By SeqNo";
            this.btnCancelOrderBySeqNo.UseVisualStyleBackColor = true;
            this.btnCancelOrderBySeqNo.Click += new System.EventHandler(this.btnCancelOrderBySeqNo_Click);
            // 
            // txtCancelSeqNo
            // 
            this.txtCancelSeqNo.Location = new System.Drawing.Point(242, 52);
            this.txtCancelSeqNo.Name = "txtCancelSeqNo";
            this.txtCancelSeqNo.Size = new System.Drawing.Size(136, 25);
            this.txtCancelSeqNo.TabIndex = 16;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(414, 18);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(230, 23);
            this.btnCancelOrder.TabIndex = 15;
            this.btnCancelOrder.Text = "Cancel ForeignOrder By BookNo";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // txtCancelBookNo
            // 
            this.txtCancelBookNo.Location = new System.Drawing.Point(242, 21);
            this.txtCancelBookNo.Name = "txtCancelBookNo";
            this.txtCancelBookNo.Size = new System.Drawing.Size(136, 25);
            this.txtCancelBookNo.TabIndex = 14;
            // 
            // ForeignStockOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForeignStockOrderControl";
            this.Size = new System.Drawing.Size(810, 271);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox boxAccountType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxCurrency3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxCurrency2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxCurrency1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox boxExchange;
        private System.Windows.Forms.TextBox txtStockNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox boxBidAsk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSendForeignStockOrderAsync;
        private System.Windows.Forms.Button btnSendForeignStockOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox boxCancelExchange;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancelOrderBySeqNo;
        private System.Windows.Forms.TextBox txtCancelSeqNo;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.TextBox txtCancelBookNo;
    }
}
