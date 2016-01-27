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
    public partial class OptionOrderControl : UserControl
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
        public OptionOrderControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Component Event
        //----------------------------------------------------------------------
        // Component Event
        //----------------------------------------------------------------------

        private void btnSendOptionOrder_Click(object sender, EventArgs e)
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

            m_nCode = Functions.SendOptionOrder(m_UserAccount, strFutureNo, nPeriod, nFlag, nBidAsk, strPrice, nQty, strMessage, out nSiz);

            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("OptionOrder", m_nCode, m_strMessage);
            }

            strMessage = null;
        }

        private void btnSendOptionOrderAsync_Click(object sender, EventArgs e)
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

            m_nCode = Functions.SendOptionOrderAsync(m_UserAccount, strFutureNo, nPeriod, nFlag, nBidAsk, strPrice, nQty);

            if (GetMessage != null)
            {
                GetMessage("OptionOrderAsync", m_nCode, "");
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
                    

                    m_nCode = Functions.CancelOrderByStockNo(m_UserAccount, strStcokNo, strMessage,out nSiz);

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

        private void btnCancelOrderBySeqNo_Click(object sender, EventArgs e)
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

        #endregion

        #region Custom Method
        //----------------------------------------------------------------------
        // Custom Method
        //----------------------------------------------------------------------

        #endregion
    }
}
