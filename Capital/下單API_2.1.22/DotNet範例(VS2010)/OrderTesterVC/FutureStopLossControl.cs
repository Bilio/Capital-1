using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderTester
{
    public partial class FutureStopLossControl : UserControl
    {
        #region Define Variable
        //----------------------------------------------------------------------
        // Define Variable
        //----------------------------------------------------------------------
        private int m_nCode;
        public string m_strMessage;

        public delegate void MyMessageHandler(string strType, int nCode, string strMessage);
        public event MyMessageHandler GetMessage;

        private string m_UserAccount = "";
        public string UserAccount
        {
            get { return m_UserAccount; }
            set { m_UserAccount = value; }
        }

        #endregion

        #region Initialize
        //----------------------------------------------------------------------
        // Initialize
        //----------------------------------------------------------------------
        public FutureStopLossControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Component Event
        //----------------------------------------------------------------------
        // Component Event
        //----------------------------------------------------------------------

        private void btnSendFutureOrder_Click(object sender, EventArgs e)
        {
            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇期貨帳號");
                return;
            }

            string strFutureNo;
            int nBidAsk;
            int nPeriod;
            int nFlag;
            string strPrice;
            int nQty;
            string strTriggerPrice;



            if (txtStockNo.Text.Trim() == "")
            {
                MessageBox.Show("請輸入商品代碼");
                return;
            }
            strFutureNo = txtStockNo.Text.Trim();

            if (boxBidAsk.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇買賣別");
                return;
            }
            nBidAsk = boxBidAsk.SelectedIndex;

            if (boxPeriod.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇委託條件");
                return;
            }
            nPeriod = boxPeriod.SelectedIndex;

            if (boxFlag.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇當沖與否");
                return;
            }
            nFlag = boxFlag.SelectedIndex;

            double dPrice = 0.0;
            if (double.TryParse(txtPrice.Text.Trim(), out dPrice) == false)
            {
                MessageBox.Show("委託價請輸入數字");
                return;
            }
            strPrice = txtPrice.Text.Trim();

            if (int.TryParse(txtQty.Text.Trim(), out nQty) == false)
            {
                MessageBox.Show("委託量請輸入數字");
                return;
            }

            if (txtTriggerPrice.Text.Trim() == "")
            {
                MessageBox.Show("請輸入商品代碼");
                return;
            }
            strTriggerPrice = txtTriggerPrice.Text.Trim();



            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.SendFutureStopLoss(m_UserAccount, strFutureNo, nPeriod, nFlag, nBidAsk, strPrice, nQty,strTriggerPrice, strMessage, out nSiz);

            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("FutureStopLoss", m_nCode, m_strMessage);
            }

            strMessage = null;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇期貨帳號");
                return;
            }

            string strBookNo;

            if(txtBookNo.Text.Trim() == "")
            {
                MessageBox.Show("請輸入委託書號");
                return;
            }
            strBookNo = txtBookNo.Text.Trim();


            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.CancelFutureStopLoss(m_UserAccount, strBookNo, "0", "0", "0", "0", "0", "0", "0", strMessage, out nSiz);

            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("CancelFutureStopLoss", m_nCode, m_strMessage);
            }

            strMessage = null;
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇期貨帳號");
                return;
            }

            int nStatus = 0;

            if (boxReportStatus.SelectedIndex >= 0)
            {
                nStatus = boxReportStatus.SelectedIndex;
            }

            string strType = boxKind.Text;


            FOnGetBSTR fOnStopLossReport = new FOnGetBSTR(OnStopLossReport);
            m_nCode = Functions.RegisterOnStopLossReportCallBack(fOnStopLossReport);
            m_nCode = Functions.GetStopLossReport(m_UserAccount, nStatus, strType);

            if (m_nCode != 0)
            {
                GetMessage("GetStopLossReport", m_nCode, "");
            }
        }

        #endregion

        #region Custom Method
        //----------------------------------------------------------------------
        // Custom Method
        //----------------------------------------------------------------------
        public void OnStopLossReport(string StopLossReport)
        {
            if (GetMessage != null)
            {
                GetMessage("OnStopLossReport", 0, StopLossReport);
            }
        }
        #endregion

    }
}
