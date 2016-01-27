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
    public partial class ForeignStockOrderControl : UserControl
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
        public ForeignStockOrderControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Component Event
        //----------------------------------------------------------------------
        // Component Event
        //----------------------------------------------------------------------
        private void btnSendForeignStockOrder_Click(object sender, EventArgs e)
        {
            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇複委託帳號");
                return;
            }
            
            string      strExchangeNo = "";
            string      strStockNo;
            int         nBidAsk;
            string      strPrice;
            int         nQty;
            string      strCurrency1;
            string      strCurrency2;
            string      strCurrency3;
            int         nAccountType;


            if (boxAccountType.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇帳戶別");
                return;
            }
            nAccountType = boxAccountType.SelectedIndex + 1;

            if (boxCurrency1.SelectedIndex < 0)
            {
                MessageBox.Show("請至少選擇扣款幣別 1");
                return;
            }
            strCurrency1 = boxCurrency1.Text;
            strCurrency2 = boxCurrency2.Text;
            strCurrency3 = boxCurrency3.Text;

            if (boxExchange.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇交易所");
                return;
            }

            if (boxExchange.SelectedIndex == 0)
            {
                strExchangeNo = "US";
            }
            else if (boxExchange.SelectedIndex == 1)
            {
                strExchangeNo = "HK";
            }

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

            m_nCode = Functions.SendForeignStockOrder(m_UserAccount, strStockNo, strExchangeNo, nBidAsk, strPrice, nQty, strCurrency1, strCurrency2, strCurrency3, nAccountType, strMessage, out nSiz);

            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("ForeignStockOrder", m_nCode, m_strMessage);
            }

            strMessage = null;

        }

        private void btnSendForeignStockOrderAsync_Click(object sender, EventArgs e)
        {
            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇複委託帳號");
                return;
            }

            string strExchangeNo = "";
            string strStockNo;
            int nBidAsk;
            string strPrice;
            int nQty;
            string strCurrency1;
            string strCurrency2;
            string strCurrency3;
            int nAccountType;


            if (boxAccountType.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇帳戶別");
                return;
            }
            nAccountType = boxAccountType.SelectedIndex + 1;

            if (boxCurrency1.SelectedIndex < 0)
            {
                MessageBox.Show("請至少選擇扣款幣別 1");
                return;
            }
            strCurrency1 = boxCurrency1.Text;
            strCurrency2 = boxCurrency2.Text;
            strCurrency3 = boxCurrency3.Text;

            if (boxExchange.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇交易所");
                return;
            }

            if (boxExchange.SelectedIndex == 0)
            {
                strExchangeNo = "US";
            }
            else if (boxExchange.SelectedIndex == 1)
            {
                strExchangeNo = "HK";
            }

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

            m_nCode = Functions.SendForeignStockOrderAsync(m_UserAccount, strStockNo, strExchangeNo, nBidAsk, strPrice, nQty, strCurrency1, strCurrency2, strCurrency3, nAccountType, strMessage, out nSiz);

            if (GetMessage != null)
            {
                GetMessage("ForeignStockOrderAsync", m_nCode, "非同步委託");
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            string strExchangeNo    = "";
            string strBookNo        = "";

            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇複委託帳號");
                return;
            }
             
            if (boxExchange.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇交易所");
                return;
            }

            if (boxExchange.SelectedIndex == 0)
            {
                strExchangeNo = "US";
            }
            else if (boxExchange.SelectedIndex == 1)
            {
                strExchangeNo = "HK";
            }

            if (txtCancelBookNo.Text.Trim() == "")
            {
                MessageBox.Show("請輸入欲刪除的委託書號");
                return;
            }
            strBookNo = txtCancelBookNo.Text.Trim();


            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.CancelForeignStockOrderByBookNo(m_UserAccount,strBookNo,strExchangeNo, strMessage, out nSiz);

            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("CancelForeignStockOrder By BookNo", m_nCode, m_strMessage);
            }

            strMessage = null;

        }

        private void btnCancelOrderBySeqNo_Click(object sender, EventArgs e)
        {
            string strExchangeNo = "";
            string strSeqNo     = "";

            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇複委託帳號");
                return;
            }

            if (boxExchange.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇交易所");
                return;
            }

            if (boxExchange.SelectedIndex == 0)
            {
                strExchangeNo = "US";
            }
            else if (boxExchange.SelectedIndex == 1)
            {
                strExchangeNo = "HK";
            }

            if (txtCancelSeqNo.Text.Trim() == "")
            {
                MessageBox.Show("請輸入欲刪除的委託序號");
                return;
            }
            strSeqNo = txtCancelSeqNo.Text.Trim();


            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.CancelForeignStockOrderBySeqNo(m_UserAccount, strSeqNo, strExchangeNo, strMessage, out nSiz);

            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("CancelForeignStockOrder By SqlNo", m_nCode, m_strMessage);
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
