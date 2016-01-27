namespace QuoteTester
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblServerTime = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.gridStocks = new System.Windows.Forms.DataGridView();
            this.btnQueryStocks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStocks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridBest5Bid = new System.Windows.Forms.DataGridView();
            this.GridBest5Ask = new System.Windows.Forms.DataGridView();
            this.GridTick = new System.Windows.Forms.DataGridView();
            this.btnTick = new System.Windows.Forms.Button();
            this.txtTick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listStockInfo = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEnterMonitor = new System.Windows.Forms.Button();
            this.btnLeaveMonitor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblConnect = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.timerServerTime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblSendRequestServerTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGetServerTime = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblnBuyTotalCount = new System.Windows.Forms.Label();
            this.lblnSellTotalCount = new System.Windows.Forms.Label();
            this.lblSellTotalQty = new System.Windows.Forms.Label();
            this.lblnBuyTotalQty = new System.Windows.Forms.Label();
            this.lblnSellDealTotalCount = new System.Windows.Forms.Label();
            this.lblnBuyDealTotalCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFutureStockNo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStocks)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBest5Bid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBest5Ask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTick)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInitialize
            // 
            this.btnInitialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInitialize.Location = new System.Drawing.Point(292, 21);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(5);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(147, 60);
            this.btnInitialize.TabIndex = 3;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPassword.Location = new System.Drawing.Point(12, 60);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 15);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password：";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(91, 56);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(175, 25);
            this.txtPassWord.TabIndex = 2;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccount.Location = new System.Drawing.Point(12, 28);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(69, 15);
            this.lblAccount.TabIndex = 13;
            this.lblAccount.Text = "Account：";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(91, 21);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(5);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(175, 25);
            this.txtAccount.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblServerTime);
            this.groupBox1.Location = new System.Drawing.Point(514, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 62);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server時間";
            // 
            // lblServerTime
            // 
            this.lblServerTime.AutoSize = true;
            this.lblServerTime.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblServerTime.Location = new System.Drawing.Point(40, 27);
            this.lblServerTime.Name = "lblServerTime";
            this.lblServerTime.Size = new System.Drawing.Size(0, 19);
            this.lblServerTime.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(15, 215);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 407);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.gridStocks);
            this.tabPage1.Controls.Add(this.btnQueryStocks);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtStocks);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "報價";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridStocks
            // 
            this.gridStocks.AllowUserToAddRows = false;
            this.gridStocks.AllowUserToDeleteRows = false;
            this.gridStocks.AllowUserToResizeRows = false;
            this.gridStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStocks.Location = new System.Drawing.Point(7, 47);
            this.gridStocks.Name = "gridStocks";
            this.gridStocks.ReadOnly = true;
            this.gridStocks.RowHeadersVisible = false;
            this.gridStocks.RowTemplate.Height = 24;
            this.gridStocks.Size = new System.Drawing.Size(697, 301);
            this.gridStocks.TabIndex = 4;
            this.gridStocks.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridStocks_CellPainting);
            // 
            // btnQueryStocks
            // 
            this.btnQueryStocks.Location = new System.Drawing.Point(495, 18);
            this.btnQueryStocks.Name = "btnQueryStocks";
            this.btnQueryStocks.Size = new System.Drawing.Size(75, 23);
            this.btnQueryStocks.TabIndex = 3;
            this.btnQueryStocks.Text = "查詢";
            this.btnQueryStocks.UseVisualStyleBackColor = true;
            this.btnQueryStocks.Click += new System.EventHandler(this.btnQueryStocks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "( 多筆以逗號{,}區隔 )";
            // 
            // txtStocks
            // 
            this.txtStocks.Location = new System.Drawing.Point(79, 16);
            this.txtStocks.Name = "txtStocks";
            this.txtStocks.Size = new System.Drawing.Size(243, 25);
            this.txtStocks.TabIndex = 1;
            this.txtStocks.Text = "TX00,6005";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品代碼";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GridBest5Bid);
            this.tabPage2.Controls.Add(this.GridBest5Ask);
            this.tabPage2.Controls.Add(this.GridTick);
            this.tabPage2.Controls.Add(this.btnTick);
            this.tabPage2.Controls.Add(this.txtTick);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tick & Best5";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridBest5Bid
            // 
            this.GridBest5Bid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBest5Bid.Location = new System.Drawing.Point(495, 192);
            this.GridBest5Bid.MultiSelect = false;
            this.GridBest5Bid.Name = "GridBest5Bid";
            this.GridBest5Bid.RowHeadersVisible = false;
            this.GridBest5Bid.RowTemplate.Height = 24;
            this.GridBest5Bid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridBest5Bid.Size = new System.Drawing.Size(131, 159);
            this.GridBest5Bid.TabIndex = 6;
            // 
            // GridBest5Ask
            // 
            this.GridBest5Ask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBest5Ask.Location = new System.Drawing.Point(495, 21);
            this.GridBest5Ask.MultiSelect = false;
            this.GridBest5Ask.Name = "GridBest5Ask";
            this.GridBest5Ask.RowHeadersVisible = false;
            this.GridBest5Ask.RowTemplate.Height = 24;
            this.GridBest5Ask.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridBest5Ask.Size = new System.Drawing.Size(131, 159);
            this.GridBest5Ask.TabIndex = 5;
            // 
            // GridTick
            // 
            this.GridTick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTick.Location = new System.Drawing.Point(72, 49);
            this.GridTick.MultiSelect = false;
            this.GridTick.Name = "GridTick";
            this.GridTick.RowHeadersVisible = false;
            this.GridTick.RowTemplate.Height = 24;
            this.GridTick.Size = new System.Drawing.Size(390, 302);
            this.GridTick.TabIndex = 4;
            // 
            // btnTick
            // 
            this.btnTick.Location = new System.Drawing.Point(185, 17);
            this.btnTick.Name = "btnTick";
            this.btnTick.Size = new System.Drawing.Size(75, 23);
            this.btnTick.TabIndex = 3;
            this.btnTick.Text = "查詢";
            this.btnTick.UseVisualStyleBackColor = true;
            this.btnTick.Click += new System.EventHandler(this.btnTick_Click);
            // 
            // txtTick
            // 
            this.txtTick.Location = new System.Drawing.Point(79, 18);
            this.txtTick.Name = "txtTick";
            this.txtTick.Size = new System.Drawing.Size(100, 25);
            this.txtTick.TabIndex = 2;
            this.txtTick.Text = "1101";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "商品代碼";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(710, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "KLine";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listStockInfo);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(710, 378);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "取得商品";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listStockInfo
            // 
            this.listStockInfo.FormattingEnabled = true;
            this.listStockInfo.ItemHeight = 15;
            this.listStockInfo.Location = new System.Drawing.Point(79, 51);
            this.listStockInfo.Name = "listStockInfo";
            this.listStockInfo.Size = new System.Drawing.Size(565, 304);
            this.listStockInfo.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "查詢";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEnterMonitor
            // 
            this.btnEnterMonitor.Location = new System.Drawing.Point(15, 99);
            this.btnEnterMonitor.Name = "btnEnterMonitor";
            this.btnEnterMonitor.Size = new System.Drawing.Size(77, 26);
            this.btnEnterMonitor.TabIndex = 18;
            this.btnEnterMonitor.Text = "報價連線";
            this.btnEnterMonitor.UseVisualStyleBackColor = true;
            this.btnEnterMonitor.Click += new System.EventHandler(this.btnEnterMonitor_Click);
            // 
            // btnLeaveMonitor
            // 
            this.btnLeaveMonitor.Location = new System.Drawing.Point(98, 99);
            this.btnLeaveMonitor.Name = "btnLeaveMonitor";
            this.btnLeaveMonitor.Size = new System.Drawing.Size(83, 26);
            this.btnLeaveMonitor.TabIndex = 19;
            this.btnLeaveMonitor.Text = "中斷報價";
            this.btnLeaveMonitor.UseVisualStyleBackColor = true;
            this.btnLeaveMonitor.Click += new System.EventHandler(this.btnLeaveMonitor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblConnect);
            this.groupBox2.Location = new System.Drawing.Point(658, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(71, 62);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "訊號";
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblConnect.Location = new System.Drawing.Point(19, 24);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(32, 22);
            this.lblConnect.TabIndex = 0;
            this.lblConnect.Text = "●";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMessage);
            this.groupBox3.Location = new System.Drawing.Point(317, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 61);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "訊息";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 27);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(37, 15);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "訊息";
            // 
            // timerServerTime
            // 
            this.timerServerTime.Interval = 60000;
            this.timerServerTime.Tick += new System.EventHandler(this.timerServerTime_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 22;
            this.button1.Text = "GetServerTime";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "送出要求時間：";
            // 
            // lblSendRequestServerTime
            // 
            this.lblSendRequestServerTime.AutoSize = true;
            this.lblSendRequestServerTime.Location = new System.Drawing.Point(242, 187);
            this.lblSendRequestServerTime.Name = "lblSendRequestServerTime";
            this.lblSendRequestServerTime.Size = new System.Drawing.Size(0, 15);
            this.lblSendRequestServerTime.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "收到Server時間CALLBACK：";
            // 
            // lblGetServerTime
            // 
            this.lblGetServerTime.AutoSize = true;
            this.lblGetServerTime.Location = new System.Drawing.Point(547, 187);
            this.lblGetServerTime.Name = "lblGetServerTime";
            this.lblGetServerTime.Size = new System.Drawing.Size(0, 15);
            this.lblGetServerTime.TabIndex = 26;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.lblFutureStockNo);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.lblnSellDealTotalCount);
            this.tabPage5.Controls.Add(this.lblnBuyDealTotalCount);
            this.tabPage5.Controls.Add(this.lblSellTotalQty);
            this.tabPage5.Controls.Add(this.lblnBuyTotalQty);
            this.tabPage5.Controls.Add(this.lblnSellTotalCount);
            this.tabPage5.Controls.Add(this.lblnBuyTotalCount);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(710, 378);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "期貨資訊";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(234, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "總委託買進筆數";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "總委託賣出筆數";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "總委託賣出口數";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "總委託買進口數";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "總委託賣出筆數";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "總委託買進筆數";
            // 
            // lblnBuyTotalCount
            // 
            this.lblnBuyTotalCount.AutoSize = true;
            this.lblnBuyTotalCount.Location = new System.Drawing.Point(361, 95);
            this.lblnBuyTotalCount.Name = "lblnBuyTotalCount";
            this.lblnBuyTotalCount.Size = new System.Drawing.Size(22, 15);
            this.lblnBuyTotalCount.TabIndex = 6;
            this.lblnBuyTotalCount.Text = "---";
            // 
            // lblnSellTotalCount
            // 
            this.lblnSellTotalCount.AutoSize = true;
            this.lblnSellTotalCount.Location = new System.Drawing.Point(361, 132);
            this.lblnSellTotalCount.Name = "lblnSellTotalCount";
            this.lblnSellTotalCount.Size = new System.Drawing.Size(22, 15);
            this.lblnSellTotalCount.TabIndex = 7;
            this.lblnSellTotalCount.Text = "---";
            // 
            // lblSellTotalQty
            // 
            this.lblSellTotalQty.AutoSize = true;
            this.lblSellTotalQty.Location = new System.Drawing.Point(361, 202);
            this.lblSellTotalQty.Name = "lblSellTotalQty";
            this.lblSellTotalQty.Size = new System.Drawing.Size(22, 15);
            this.lblSellTotalQty.TabIndex = 9;
            this.lblSellTotalQty.Text = "---";
            // 
            // lblnBuyTotalQty
            // 
            this.lblnBuyTotalQty.AutoSize = true;
            this.lblnBuyTotalQty.Location = new System.Drawing.Point(361, 165);
            this.lblnBuyTotalQty.Name = "lblnBuyTotalQty";
            this.lblnBuyTotalQty.Size = new System.Drawing.Size(22, 15);
            this.lblnBuyTotalQty.TabIndex = 8;
            this.lblnBuyTotalQty.Text = "---";
            // 
            // lblnSellDealTotalCount
            // 
            this.lblnSellDealTotalCount.AutoSize = true;
            this.lblnSellDealTotalCount.Location = new System.Drawing.Point(361, 269);
            this.lblnSellDealTotalCount.Name = "lblnSellDealTotalCount";
            this.lblnSellDealTotalCount.Size = new System.Drawing.Size(22, 15);
            this.lblnSellDealTotalCount.TabIndex = 11;
            this.lblnSellDealTotalCount.Text = "---";
            // 
            // lblnBuyDealTotalCount
            // 
            this.lblnBuyDealTotalCount.AutoSize = true;
            this.lblnBuyDealTotalCount.Location = new System.Drawing.Point(361, 236);
            this.lblnBuyDealTotalCount.Name = "lblnBuyDealTotalCount";
            this.lblnBuyDealTotalCount.Size = new System.Drawing.Size(22, 15);
            this.lblnBuyDealTotalCount.TabIndex = 10;
            this.lblnBuyDealTotalCount.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(234, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "商品代碼";
            // 
            // lblFutureStockNo
            // 
            this.lblFutureStockNo.AutoSize = true;
            this.lblFutureStockNo.Location = new System.Drawing.Point(364, 57);
            this.lblFutureStockNo.Name = "lblFutureStockNo";
            this.lblFutureStockNo.Size = new System.Drawing.Size(22, 15);
            this.lblFutureStockNo.TabIndex = 13;
            this.lblFutureStockNo.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(325, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "(  於報價頁面訂閱期貨商品，即會顯示期貨資訊)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 634);
            this.Controls.Add(this.lblGetServerTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSendRequestServerTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLeaveMonitor);
            this.Controls.Add(this.btnEnterMonitor);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.txtAccount);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuoteTester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStocks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBest5Bid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBest5Ask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTick)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEnterMonitor;
        private System.Windows.Forms.Button btnLeaveMonitor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQueryStocks;
        private System.Windows.Forms.Label lblServerTime;
        private System.Windows.Forms.Timer timerServerTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridStocks;
        private System.Windows.Forms.Button btnTick;
        private System.Windows.Forms.TextBox txtTick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridTick;
        private System.Windows.Forms.DataGridView GridBest5Ask;
        private System.Windows.Forms.DataGridView GridBest5Bid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listStockInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSendRequestServerTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGetServerTime;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnSellDealTotalCount;
        private System.Windows.Forms.Label lblnBuyDealTotalCount;
        private System.Windows.Forms.Label lblSellTotalQty;
        private System.Windows.Forms.Label lblnBuyTotalQty;
        private System.Windows.Forms.Label lblnSellTotalCount;
        private System.Windows.Forms.Label lblnBuyTotalCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFutureStockNo;
        private System.Windows.Forms.Label label13;
    }
}

