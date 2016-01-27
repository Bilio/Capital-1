namespace OrderTester
{
    partial class TradeStationControl
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
            this.btnInitializeTS = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listTSInfo = new System.Windows.Forms.ListBox();
            this.lblInitialize = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInitialize);
            this.groupBox1.Controls.Add(this.btnInitializeTS);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始化";
            // 
            // btnInitializeTS
            // 
            this.btnInitializeTS.Location = new System.Drawing.Point(17, 24);
            this.btnInitializeTS.Name = "btnInitializeTS";
            this.btnInitializeTS.Size = new System.Drawing.Size(87, 23);
            this.btnInitializeTS.TabIndex = 0;
            this.btnInitializeTS.Text = "訊號接收";
            this.btnInitializeTS.UseVisualStyleBackColor = true;
            this.btnInitializeTS.Click += new System.EventHandler(this.btnInitializeTS_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listTSInfo);
            this.groupBox2.Location = new System.Drawing.Point(3, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TS訊號";
            // 
            // listTSInfo
            // 
            this.listTSInfo.FormattingEnabled = true;
            this.listTSInfo.HorizontalScrollbar = true;
            this.listTSInfo.ItemHeight = 15;
            this.listTSInfo.Location = new System.Drawing.Point(6, 24);
            this.listTSInfo.Name = "listTSInfo";
            this.listTSInfo.Size = new System.Drawing.Size(792, 184);
            this.listTSInfo.TabIndex = 21;
            // 
            // lblInitialize
            // 
            this.lblInitialize.AutoSize = true;
            this.lblInitialize.Location = new System.Drawing.Point(161, 28);
            this.lblInitialize.Name = "lblInitialize";
            this.lblInitialize.Size = new System.Drawing.Size(0, 15);
            this.lblInitialize.TabIndex = 1;
            // 
            // TradeStationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TradeStationControl";
            this.Size = new System.Drawing.Size(810, 290);
            this.Load += new System.EventHandler(this.TradeStationControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInitializeTS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listTSInfo;
        private System.Windows.Forms.Label lblInitialize;
    }
}
