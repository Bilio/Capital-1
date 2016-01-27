namespace OrderTester
{
    partial class MovingStopLossControl
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
            this.txtTriggerPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSendMovingOrder = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtMovingPoint = new System.Windows.Forms.TextBox();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBookNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTriggerPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnSendMovingOrder);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtMovingPoint);
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
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "移動停損單委託";
            // 
            // txtTriggerPrice
            // 
            this.txtTriggerPrice.Location = new System.Drawing.Point(580, 45);
            this.txtTriggerPrice.Name = "txtTriggerPrice";
            this.txtTriggerPrice.Size = new System.Drawing.Size(49, 25);
            this.txtTriggerPrice.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "觸發價";
            // 
            // btnSendMovingOrder
            // 
            this.btnSendMovingOrder.Location = new System.Drawing.Point(652, 22);
            this.btnSendMovingOrder.Name = "btnSendMovingOrder";
            this.btnSendMovingOrder.Size = new System.Drawing.Size(142, 46);
            this.btnSendMovingOrder.TabIndex = 14;
            this.btnSendMovingOrder.Text = "SendMovingStopLossOrder";
            this.btnSendMovingOrder.UseVisualStyleBackColor = true;
            this.btnSendMovingOrder.Click += new System.EventHandler(this.btnSendMovingOrder_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(499, 45);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(49, 25);
            this.txtQty.TabIndex = 11;
            // 
            // txtMovingPoint
            // 
            this.txtMovingPoint.Location = new System.Drawing.Point(399, 45);
            this.txtMovingPoint.Name = "txtMovingPoint";
            this.txtMovingPoint.Size = new System.Drawing.Size(74, 25);
            this.txtMovingPoint.TabIndex = 10;
            // 
            // boxFlag
            // 
            this.boxFlag.FormattingEnabled = true;
            this.boxFlag.Items.AddRange(new object[] {
            "非當沖",
            "當沖"});
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
            this.txtStockNo.MaxLength = 8;
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(64, 25);
            this.txtStockNo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "委託量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "移動點數";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 21);
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
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.txtBookNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(3, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 65);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "刪單";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 28);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CancelMovingStopLoss";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBookNo
            // 
            this.txtBookNo.Location = new System.Drawing.Point(89, 28);
            this.txtBookNo.Name = "txtBookNo";
            this.txtBookNo.Size = new System.Drawing.Size(78, 25);
            this.txtBookNo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "委託書號";
            // 
            // MovingStopLossControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MovingStopLossControl";
            this.Size = new System.Drawing.Size(810, 209);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTriggerPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSendMovingOrder;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtMovingPoint;
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBookNo;
        private System.Windows.Forms.Label label8;
    }
}
