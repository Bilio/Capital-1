using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Permissions; 


namespace OrderTester
{
    public partial class Main : Form
    {
        #region Define Variable
        //----------------------------------------------------------------------
        // Define Variable
        //----------------------------------------------------------------------
        Dictionary<string, string> m_OrderAsync = new Dictionary<string, string>();
        private delegate void InvokeSendMessage(string state);
        private delegate void ConnectReplyServer(string state);

        FOnData             fData;
        FOnOrderAsyncReport fOrderAsync;
        FOnConnect          fConnect;
        FOnConnect          fDisconnect;
        FOnComplete         fComplete;
        FOnGetExecutionReoprt fOnExecutionReport;
         

        string  m_strLoginID    = "";
        string  m_strData       = "";
        int     m_nCode         = 0;
        bool    m_bDisconnect   = false;

        #endregion

        #region Initialize
        //----------------------------------------------------------------------
        // Initialize
        //----------------------------------------------------------------------
        public Main()
        {
            InitializeComponent();

            boxExecutionAccount.SelectedIndex   = 0;
            boxCount.SelectedIndex              = 0;
            boxMarket.SelectedIndex             = 0;
            boxBuySell.SelectedIndex            = 0;
        }

        #endregion

        #region Component Event
        //----------------------------------------------------------------------
        // Component Event
        //----------------------------------------------------------------------

        private void Main_Load(object sender, EventArgs e)
        {
            fData = new FOnData(OnData);
            GC.KeepAlive(fData);

            fOrderAsync = new FOnOrderAsyncReport(OnOrderAsyncReport);
            GC.KeepAlive(fOrderAsync);

            fConnect = new FOnConnect(OnConnect);
            GC.KeepAlive(fConnect);

            fDisconnect = new FOnConnect(OnDisconnect);
            GC.KeepAlive(fDisconnect);

            fComplete = new FOnComplete(OnComplete);
            GC.KeepAlive(fComplete);

            fOnExecutionReport = new FOnGetExecutionReoprt(OnExecutionReport);
            GC.KeepAlive(fOnExecutionReport);
            GC.SuppressFinalize(fOnExecutionReport);

        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            string  strPassword;

            boxStockAccount.Items.Clear();
            boxFutureAccount.Items.Clear();
            boxOSStockAccount.Items.Clear();
            boxOSFutureAccount.Items.Clear();

            m_strLoginID = txtAccount.Text.Trim();
            strPassword  = txtPassWord.Text.Trim();
           
            //Initialize SKOrderLib
            m_nCode = Functions.SKOrderLib_Initialize(m_strLoginID, strPassword);

            if (m_nCode == 0)
                MessageBox.Show("Initialize Success");
            else if (m_nCode == 2003)
            {
                MessageBox.Show("元件已初始過，無須重複執行");
            }
            else
            {
                MessageBox.Show("Initialize Fail：code " + GetApiCodeDefine(m_nCode));
                return;
            }

            //Initialize  Cert
            m_nCode = Functions.SKOrderLib_ReadCertByID(m_strLoginID);
            if (m_nCode == 0)
                MessageBox.Show("ReadCert Success");

            //Get Account
            FOnGetBSTR fAccount = new FOnGetBSTR(OnAccount);
            m_nCode = Functions.RegisterOnAccountCallBack(fAccount);
            m_nCode = Functions.GetUserAccount();

            //OrderAsync CallBack
            m_nCode = Functions.RegisterOnOrderAsyncReportCallBack(fOrderAsync);

            m_nCode = Functions.RegisterOnExecutionReportCallBack(fOnExecutionReport); 

            
        }
         
        private void btnInitializeReply_Click(object sender, EventArgs e)
        {
            string strPassword;

            m_strLoginID = txtAccount.Text.Trim();
            strPassword = txtPassWord.Text.Trim();

            //Initialize SKOrderLib
            m_nCode = Functions.SKReplyLib_Initialize(m_strLoginID, strPassword);

            if (m_nCode == 0)
                MessageBox.Show("SKReplyLib_Initialize Success");
            else if (m_nCode == 2003)
            {
                MessageBox.Show("元件已初始過，無須重複執行");
            }
            else
            { 
                MessageBox.Show("SKReplyLib_Initialize  Fail：code " + GetApiCodeDefine(m_nCode));
                return;
            }
             
            //OnConnect CallBack
            m_nCode = Functions.RegisterOnConnectCallBack(fConnect);

            //OnDisconnect CallBack
            m_nCode = Functions.RegisterOnDisconnectCallBack(fDisconnect);
             
            //OnData CallBack
            m_nCode = Functions.RegisterOnDataCallBack(fData); 
             
            //OnComplete CallBack
            m_nCode = Functions.RegisterOnCompleteCallBack(fComplete);

        } 
        private void btnConnect_Click(object sender, EventArgs e)
        {
            m_bDisconnect = false;

            m_nCode = Functions.SKReplyLib_IsConnectedByID(m_strLoginID);
            
            if (m_nCode == 0)
            {
                Functions.SKReplyLib_ConnectByID(m_strLoginID);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            m_bDisconnect = true;

            m_nCode = Functions.SKReplyLib_CloseByID(m_strLoginID);

            WriteInfo("關閉回報 Code:" + GetApiCodeDefine(m_nCode));
        }

        private void boxStockAccount_SelectionChangeCommitted(object sender, EventArgs e)
        {
            stockOrderControl.UserAccount = boxStockAccount.Text;
        }
        private void boxFutureAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            futureOrderControl.UserAccount      = boxFutureAccount.Text;
            optionOrderControl.UserAccount      = boxFutureAccount.Text;
            futureStopLossControl.UserAccount   = boxFutureAccount.Text;
            movingStopLossControl.UserAccount   = boxFutureAccount.Text;
            optionStopLossControl.UserAccount   = boxFutureAccount.Text;
        }
        private void boxOSStockAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreignStockOrderControl.UserAccount = boxOSStockAccount.Text;
        }

        private void boxOSFutureAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            overseaFutureOrderControl.UserAccount =  boxOSFutureAccount.Text;
        }
 
        private void timerConnect_Tick(object sender, EventArgs e)
        {
            timerConnect.Enabled = false;
            btnConnect_Click(null, null);
        }

        private void stockOrderControl_GetMessage(string strType, int nCode, string strMessage)
        {
            string strMsg;

            if (strMessage == "")
            {
                strMsg = string.Format("{0}    ﹝Code﹞:{1}", strType, GetApiCodeDefine(nCode));
            }
            else
            {
                strMsg = string.Format("{0}    ﹝Code﹞:{1}    ﹝Message﹞:{2}", strType, GetApiCodeDefine(nCode), strMessage);
            } 

            WriteInfo(strMsg);

            if (strType == "StockOrderAsync" || strType == "FutureOrderAsync" || strType == "OptionOrderAsync" || strType == "ForeignStockOrderAsync" || strType == "OverseaFutureOrderAsync")
            {
                string strValue;

                if ( !m_OrderAsync.TryGetValue(nCode.ToString(), out strValue))
                { 
                    m_OrderAsync.Add(nCode.ToString(), strType);
                }
            }
        }

        private void btnTS_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            Functions.GetLastLogMessage(strMessage,out nSiz);

            string strLogMsg = strMessage.ToString();

            MessageBox.Show(strLogMsg);

            strMessage = null;
        }

        #endregion

        #region CallBack Function
        //----------------------------------------------------------------------
        // CallBack Function
        //----------------------------------------------------------------------

        //Account CallBack Function
        public void OnAccount(string bstrData)
        {
            string[] strValues;
            string strAccount;

            strValues = bstrData.Split(',');
            strAccount = strValues[1] + strValues[3];

            if (strValues[0] == "TS")
            {
                boxStockAccount.Items.Add(strAccount);

                boxExecutionAccount.Items.Add( "證券 " + strAccount);
            }
            else if (strValues[0] == "TF")
            {
                boxFutureAccount.Items.Add(strAccount);

                boxExecutionAccount.Items.Add("期貨 " + strAccount);
            }
            else if (strValues[0] == "OF")
            {
                boxOSFutureAccount.Items.Add(strAccount);
            }
            else if (strValues[0] == "OS")
            {
                boxOSStockAccount.Items.Add(strAccount);
            }

            WriteInfo(bstrData);
        }

        //Connect CallBack Function
        public void OnConnect(string strID, int nErrorCode)
        {
            string strInfo = "回報連線 " + strID + "        Code: " + GetApiCodeDefine(nErrorCode);

            WriteInfo(strInfo);

            lblConnect.ForeColor = Color.Green; 
        }

        //Disconnect CallBack Function
        public void OnDisconnect(string strID, int nErrorCode)
        {
            string strInfo = "回報斷線 " + strID + "       Code: " + GetApiCodeDefine(nErrorCode) + " 一分後重新連線 ";
             
            this.Invoke(new ConnectReplyServer(this.ReConnectReplyServer), new object[] { strInfo });

            lblConnect.ForeColor = Color.Red;
        }

        //OnData CallBack Function
        public void OnData(IntPtr bstrData)
        {
            IntPtr bstrmyData = bstrData;
            DataItem myDataItem = (DataItem)Marshal.PtrToStructure(bstrmyData, typeof(DataItem));

            m_strData = string.Format("委託序號：{0}   市場類別：{1}   委託種類：{2}    錯誤：{3}   .........營業員代碼：{4}   來源：{5}", myDataItem.strKeyNo, myDataItem.strMarketType, myDataItem.strType, myDataItem.strOrderErr, myDataItem.strSaleNo, myDataItem.strAgent);
            WriteInfo(m_strData);
            //this.Invoke(new InvokeSendMessage(this.WriteInfo), new object[] { m_strData });

            Marshal.FreeBSTR(bstrmyData);
        }
 
        //OnComplete CallBack Function
        public void OnComplete(int nCode)
        {
            string strInfo = "Server連線確認      Code: " + GetApiCodeDefine(nCode);

            WriteInfo(strInfo);

        }

        //OnOrderAsync CallBack Function
        public void OnOrderAsyncReport(int nThreadID, int nCode, string strMessage)
        {
            string strValue;

            if (m_OrderAsync.TryGetValue(nThreadID.ToString(), out strValue))
            {
                string strInfo = string.Format("{0}    ﹝Cocd﹞:{1}    ﹝Message﹞:{2} ", strValue, GetApiCodeDefine(nCode), strMessage);
                  
                WriteInfo(strInfo);
            }
            else
            {
                string strInfo = "Thread ID  Not Found " + nThreadID;  

                WriteInfo(strInfo);
            }
        }

        #endregion

        #region Custom Method
        //----------------------------------------------------------------------
        // Custom Method
        //----------------------------------------------------------------------

        public void WriteInfo(string strMsg)
        {
            if (listInformation.InvokeRequired == true)
            {
                this.Invoke(new InvokeSendMessage(this.WriteInfo), new object[] { strMsg });
            }
            else
            {
                listInformation.Items.Add(strMsg);

                listInformation.SelectedIndex = listInformation.Items.Count - 1;


                //listInformation.HorizontalScrollbar = true;

                // Create a Graphics object to use when determining the size of the largest item in the ListBox.
                Graphics g = listInformation.CreateGraphics();

                // Determine the size for HorizontalExtent using the MeasureString method using the last item in the list.
                int hzSize = (int)g.MeasureString(listInformation.Items[listInformation.Items.Count - 1].ToString(), listInformation.Font).Width;
                // Set the HorizontalExtent property.
                listInformation.HorizontalExtent = hzSize;
            }
        }

        public void ReConnectReplyServer(string strMsg)
        {
            if (m_bDisconnect == false)
            {
                WriteInfo(strMsg);

                timerConnect.Enabled = true;
            }
        }

        public string GetApiCodeDefine( int nCode )
        {
            string strNCode = Enum.GetName(typeof(ApiMessage), nCode);

            if (strNCode == "" || strNCode == null )
            {
                return nCode.ToString();
            }
            else
            {
                return strNCode;
            }
        }  

        #endregion 

        private void btnQueryExecution_Click(object sender, EventArgs e)
        {
            listReport1.Items.Clear();
            listReport2.Items.Clear();
            listReport3.Items.Clear();
            listReport4.Items.Clear();

            string strAccount = "0";
            if (boxExecutionAccount.SelectedIndex != 0)
            {
                string[] Account = boxExecutionAccount.Text.Trim().Split(new Char[] { ' ' }); ;
                strAccount = Account[1];
            }

            string strStockNo = txtStockNo.Text.Trim();

            if (strStockNo == "")
                strStockNo = "0";

            int nMarket     = boxMarket.SelectedIndex;
            int nBuySell    = boxBuySell.SelectedIndex;
            int nDataNum    = boxCount.SelectedIndex;
            int nType       = tabExecutionReport.SelectedIndex+1;

            m_nCode = Functions.GetExecutionReport(strAccount, strStockNo, nMarket, nBuySell, nDataNum, nType);

            if (m_nCode == 0)
                lblExecutionMsg.Text = "查詢成功";
            else
                lblExecutionMsg.Text = "查詢失敗 Code：" + m_nCode.ToString();

        }

        public void OnExecutionReport(string strData)
        {
            this.Invoke(new InvokeSendMessage(InsertData), new object[] { strData });
        }

        public void InsertData(string strData)
        {
            string[] split = strData.Split(new Char[] { ',' });

            ListViewItem myListItem = new ListViewItem(split);

            if (tabExecutionReport.SelectedIndex == 0)
                listReport1.Items.Add(myListItem);
            else if (tabExecutionReport.SelectedIndex == 1)
                listReport2.Items.Add(myListItem);
            else if (tabExecutionReport.SelectedIndex == 2)
                listReport3.Items.Add(myListItem);
            else if (tabExecutionReport.SelectedIndex == 3)
                listReport4.Items.Add(myListItem);
        }
    }
}