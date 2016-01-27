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
    public partial class StockOrderControl : UserControl
    {
        #region Define Variable
        //----------------------------------------------------------------------
        // Define Variable
        //----------------------------------------------------------------------
        private     int     m_nCode;
        public      string  m_strMessage;

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
        public StockOrderControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Component Event
        //----------------------------------------------------------------------
        // Component Event
        //----------------------------------------------------------------------

        private void btnSendStockOrder_Click(object sender, EventArgs e)
        {
            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇證券帳號");
                return;
            }

            string  strStockNo;
            int     nBidAsk;
            int     nPeriod;
            int     nFlag;
            string  strPrice;
            int     nQty;


            if (txtStockNo.Text.Trim() == "" )
            {
                MessageBox.Show("請輸入商品代碼");
                return;
            }
            strStockNo = txtStockNo.Text.Trim();

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
            if (double.TryParse( txtPrice.Text.Trim() , out dPrice) == false)
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
            strMessage.Length   = 1024;
            Int32 nSiz          = 1024; 

            m_nCode = Functions.SendStockOrder(m_UserAccount, strStockNo, nPeriod, nFlag, nBidAsk, strPrice, nQty, strMessage, out nSiz);
            
            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("StockOrder", m_nCode, m_strMessage);
            }

            strMessage = null;
        }

        private void btnSendStockOrderAsync_Click(object sender, EventArgs e)
        {
            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇證券帳號");
                return;
            }

            string strStockNo;
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
            strStockNo = txtStockNo.Text.Trim();

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

            m_nCode = Functions.SendStockOrderAsync(m_UserAccount, strStockNo, nPeriod, nFlag, nBidAsk, strPrice, nQty);

            if (GetMessage != null)
            {
                GetMessage("StockOrderAsync", m_nCode, "非同步委託");
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

        private void btnQueryReport_Click(object sender, EventArgs e)
        {
            //Get RealBalanceReport
            FOnGetBSTR fRealBalanceReport = new FOnGetBSTR(OnRealBalanceReportCallBack);
            m_nCode = Functions.RegisterOnRealBalanceReportCallBack(fRealBalanceReport);
            m_nCode = Functions.GetRealBalanceReport(m_UserAccount);
            GC.KeepAlive(fRealBalanceReport);

            if (m_nCode != 0)
            {
                GetMessage("GetRealBalanceReport", m_nCode, "");
            }
        }

        private void btnDecreaseQty_Click(object sender, EventArgs e)
        {
            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇證券帳號");
                return;
            }

            int nQty;

            if (int.TryParse(txtDecreaseQty.Text.Trim(), out nQty))
            {
                string strSeqNo =  txtDecreaseSeqNo.Text.Trim();

                StringBuilder strMessage = new StringBuilder();
                strMessage.Length = 1024;
                Int32 nSiz = 1024;

                m_nCode = Functions.DecreaseOrderBySeqNo(m_UserAccount, strSeqNo, nQty, strMessage, out nSiz);

                if (GetMessage != null)
                {
                    GetMessage("DecreaseOrderBySeqNo", m_nCode, strMessage.ToString());
                }

                strMessage = null;
            }
            else
            {
                MessageBox.Show("欲改數量請輸入數字");
            }
        }

        #endregion
         
        #region Custom Method
        //----------------------------------------------------------------------
        // Custom Method
        //----------------------------------------------------------------------

        public void OnRealBalanceReportCallBack( string strBalanceReport )
        {
            if (GetMessage != null)
            { 
                GetMessage("RealBalanceReport",0, strBalanceReport);
            }
        }
        #endregion

    }
}
