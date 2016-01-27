namespace ReplyTesterVC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConnect = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnInitializeReply = new System.Windows.Forms.Button();
            this.listInformation = new System.Windows.Forms.ListBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.timerConnect = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblConnect);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(499, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 105);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ReplyServer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "訊號";
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblConnect.ForeColor = System.Drawing.Color.Black;
            this.lblConnect.Location = new System.Drawing.Point(69, 17);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(32, 22);
            this.lblConnect.TabIndex = 3;
            this.lblConnect.Text = "●";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisconnect.Location = new System.Drawing.Point(8, 75);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(116, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnect.Location = new System.Drawing.Point(7, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(116, 27);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnInitializeReply
            // 
            this.btnInitializeReply.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInitializeReply.Location = new System.Drawing.Point(223, 32);
            this.btnInitializeReply.Name = "btnInitializeReply";
            this.btnInitializeReply.Size = new System.Drawing.Size(116, 59);
            this.btnInitializeReply.TabIndex = 0;
            this.btnInitializeReply.Text = "Initialize";
            this.btnInitializeReply.UseVisualStyleBackColor = true;
            this.btnInitializeReply.Click += new System.EventHandler(this.btnInitializeReply_Click);
            // 
            // listInformation
            // 
            this.listInformation.FormattingEnabled = true;
            this.listInformation.HorizontalScrollbar = true;
            this.listInformation.ItemHeight = 12;
            this.listInformation.Location = new System.Drawing.Point(12, 137);
            this.listInformation.Name = "listInformation";
            this.listInformation.Size = new System.Drawing.Size(616, 160);
            this.listInformation.TabIndex = 23;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPassword.Location = new System.Drawing.Point(9, 77);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 15);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password：";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(84, 75);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(132, 22);
            this.txtPassWord.TabIndex = 27;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccount.Location = new System.Drawing.Point(9, 36);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(69, 15);
            this.lblAccount.TabIndex = 26;
            this.lblAccount.Text = "Account：";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(84, 33);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(132, 25);
            this.txtAccount.TabIndex = 25;
            // 
            // timerConnect
            // 
            this.timerConnect.Interval = 60000;
            this.timerConnect.Tick += new System.EventHandler(this.timerConnect_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 309);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listInformation);
            this.Controls.Add(this.btnInitializeReply);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplyTesterC#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnInitializeReply;
        private System.Windows.Forms.ListBox listInformation;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Timer timerConnect;
    }
}

