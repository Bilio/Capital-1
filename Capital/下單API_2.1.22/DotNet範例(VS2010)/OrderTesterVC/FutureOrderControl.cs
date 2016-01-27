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
    public partial class FutureOrderControl : UserControl
    { 
        #region Define Variable
        //----------------------------------------------------------------------
        // Define Variable
        //----------------------------------------------------------------------
        private int     m_nCode;
        public string   m_strMessage;

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
        public FutureOrderControl()
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

            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.SendFutureOrder(m_UserAccount, strFutureNo, nPeriod, nFlag, nBidAsk, strPrice, nQty, strMessage, out nSiz);

            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("FutureOrder", m_nCode, m_strMessage);
            }

            strMessage = null;
        }

        private void btnSendFutureOrderAsync_Click(object sender, EventArgs e)
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

            m_nCode = Functions.SendFutureOrderAsync(m_UserAccount, strFutureNo, nPeriod, nFlag, nBidAsk, strPrice, nQty);

            if (GetMessage != null)
            {
                GetMessage("FutureOrderAsync", m_nCode, "");
            }
        }

        

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            string strStcokNo = txtCancelStockNo.Text.Trim();

            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            if (strStcokNo == "")
            {
                DialogResult myResult = MessageBox.Show("未輸入商品代碼會取消所有預約單，是否取消?", "取消預約單", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (myResult == DialogResult.Yes)
                {
                    m_nCode = Functions.CancelOrderByStockNo(m_UserAccount, strStcokNo, strMessage, out nSiz);

                    if (GetMessage != null)
                    {
                        GetMessage("CancelOrderByStockNo", m_nCode, strMessage.ToString());
                    }
                }
            }
            else
            {
                m_nCode = Functions.CancelOrderByStockNo(m_UserAccount, strStcokNo, strMessage, out nSiz);

                if (GetMessage != null)
                {
                    GetMessage("CancelOrderByStockNo", m_nCode, strMessage.ToString());
                }
            }

            strMessage = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSeqNo = txtCancelSeqNo.Text.Trim();

            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.CancelOrderBySeqNo(m_UserAccount, strSeqNo, strMessage, out nSiz);

            if (GetMessage != null)
            {
                GetMessage("CancelOrderBySeqNo", m_nCode, strMessage.ToString());
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

            FOnGetBSTR fOpenInterest = new FOnGetBSTR(OnOpenInterestCallBack);
            m_nCode = Functions.RegisterOnOpenInterestCallBack(fOpenInterest);
            m_nCode = Functions.GetOpenInterest(m_UserAccount);
            GC.KeepAlive(fOpenInterest);

            if (m_nCode != 0)
            {
                GetMessage("GetOpenInterest", m_nCode, "");
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            m_nCode = Functions.UnlockOrder("TF");

            if (GetMessage != null)
            {
                GetMessage("UnlockOrder", m_nCode, "");
            }
        }

        private void btnCorrectPriceBySeq_Click(object sender, EventArgs e)
        {
            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.CorrectPriceBySeqNo(m_UserAccount, txtMSqlNo.Text.Trim(),txtMPrice.Text.Trim(),boxMPeriod.SelectedIndex, strMessage, out nSiz);

            if (GetMessage != null)
            {
                GetMessage("CorrectPriceBySeqNo", m_nCode, strMessage.ToString());
            }

            strMessage = null;
        }

        private void btnCorrectPriceByBookNo_Click(object sender, EventArgs e)
        {
            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.CorrectPriceByBookNo(m_UserAccount,"TF", txtMBookNo.Text.Trim(), txtMPrice.Text.Trim(), boxMPeriod.SelectedIndex, strMessage, out nSiz);

            if (GetMessage != null)
            {
                GetMessage("CorrectPriceByBookNo", m_nCode, strMessage.ToString());
            }

            strMessage = null;
        }

        #endregion

        #region Custom Method
        //----------------------------------------------------------------------
        // Custom Method
        //----------------------------------------------------------------------
        public void OnOpenInterestCallBack(string OpenInterest)
        {
            if (GetMessage != null)
            {
                GetMessage("OpenInterestReport", 0, OpenInterest);
            }
        }

        #endregion

        

    }
}
