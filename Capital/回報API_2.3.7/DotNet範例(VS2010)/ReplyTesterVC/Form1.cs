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

namespace ReplyTesterVC
{
    public partial class Form1 : Form
    {
        #region Define Variable
        //----------------------------------------------------------------------
        // Define Variable
        //----------------------------------------------------------------------
        Dictionary<string, string> m_OrderAsync = new Dictionary<string, string>();
        private delegate void InvokeSendMessage(string state);
        private delegate void ConnectReplyServer(string state);

        FOnData     fData;
        FOnConnect  fConnect;
        FOnConnect  fDisconnect;
        FOnComplete fComplete;


        string m_strLoginID = "";
        string m_strData = "";
        int m_nCode = 0;
        bool m_bDisconnect = false;

        #endregion

        public Form1()
        {
            fData = new FOnData(OnData);
            GC.KeepAlive(fData);


            fConnect = new FOnConnect(OnConnect);
            GC.KeepAlive(fConnect);

            fDisconnect = new FOnConnect(OnDisconnect);
            GC.KeepAlive(fDisconnect);

            fComplete = new FOnComplete(OnComplete);
            GC.KeepAlive(fComplete);

            InitializeComponent();
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
                MessageBox.Show("SKReplyLib_Initialize  Fail：code " + m_nCode.ToString());
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

        public void ReConnectReplyServer(string strMsg)
        {
            if (m_bDisconnect == false)
            {
                WriteInfo(strMsg);

                timerConnect.Enabled = true;
            }
        }

        public string GetApiCodeDefine(int nCode)
        {
            string strNCode = Enum.GetName(typeof(ApiMessage), nCode);

            if (strNCode == "" || strNCode == null)
            {
                return nCode.ToString();
            }
            else
            {
                return strNCode;
            }
        }

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

        private void timerConnect_Tick(object sender, EventArgs e)
        {
            timerConnect.Enabled = false;
            btnConnect_Click(null, null);
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
    }
}
