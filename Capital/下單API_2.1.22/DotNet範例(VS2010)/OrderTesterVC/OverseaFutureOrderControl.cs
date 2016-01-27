using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OrderTester
{
    public partial class OverseaFutureOrderControl : UserControl
    {
        #region Define Variable
        //----------------------------------------------------------------------
        // Define Variable
        //----------------------------------------------------------------------
        private int m_nCode;
        public string m_strMessage;
        Logger Log;
        FOnOverseaFutureOpenInterest fOnOverseaFutureOpenInterest;

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
        public OverseaFutureOrderControl()
        {
            InitializeComponent();

            Log = new Logger();
        }

        #endregion

        #region Component Event
        //----------------------------------------------------------------------
        // Component Event
        //----------------------------------------------------------------------
        private void btnSendOverseaFutureOrder_Click(object sender, EventArgs e)
        {
            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇海期帳號");
                return;
            }

            string  strTradeName;
            string  strStockNo;
            string  strYearMonth;
            int     nBuySell;
            int     nNewClose;
            int     nDayTrade;
            int     nTradeType;
            int     nSpecialTradeType;
            string  strPrice;
            int     nQty;

            if( txtTradeNo.Text.Trim() == "")
            {
                MessageBox.Show("請輸入交易所代號");
                return;
            }
            strTradeName = txtTradeNo.Text.Trim();

            if (txtStockNo.Text.Trim() == "")
            {
                MessageBox.Show("請輸入商品代碼");
                return;
            }
            strStockNo = txtStockNo.Text.Trim();

            if (txtYearMonth.Text.Trim() == "")
            {
                MessageBox.Show("請輸入年月");
                return;
            }
            strYearMonth = txtYearMonth.Text.Trim();

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

            if (boxBidAsk.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇買賣別");
                return;
            }
            nBuySell = boxBidAsk.SelectedIndex;

            if (boxNewClose.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇倉別");
                return;
            }
            nNewClose = boxNewClose.SelectedIndex;

            if (boxFlag.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇當沖與否");
                return;
            }
            nDayTrade = boxFlag.SelectedIndex;

            if (boxPeriod.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇委託條件");
                return;
            }
            nTradeType = boxPeriod.SelectedIndex;

            if (boxSpecialTradeType.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇特殊委託條件");
                return;
            }
            nSpecialTradeType = boxSpecialTradeType.SelectedIndex;

            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.SendOverseaFutureOrder(m_UserAccount, strTradeName, strStockNo, strYearMonth, nBuySell, nNewClose, nDayTrade, nTradeType, nSpecialTradeType, nQty, strPrice, "0", "0", "0", strMessage, out nSiz);


            //m_nCode = Functions.SendOverseaFutureOrder("F0200008930396", "CME", "ES", "201206", 0, 0, 0, 0, 1, 1, "0", "0", "0", "0", strMessage, out nSiz);

            //m_nCode = Functions.SendOverseaFutureOrder("F0200008930396", "CBT", "US", "201206", 0, 0, 0, 0, 0, 1, "142", "10", "0", "0", strMessage, out nSiz);
             
            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("SendOverseaFutureOrder", m_nCode, m_strMessage);
            }
            strMessage = null; 
        }

        private void btnSendOverseaFutureOrderAsync_Click(object sender, EventArgs e)
        {
            if (m_UserAccount == "")
            {
                MessageBox.Show("請選擇海期帳號");
                return;
            }

            string strTradeName;
            string strStockNo;
            string strYearMonth;
            int nBuySell;
            int nNewClose;
            int nDayTrade;
            int nTradeType;
            int nSpecialTradeType;
            string strPrice;
            int nQty;

            if (txtTradeNo.Text.Trim() == "")
            {
                MessageBox.Show("請輸入交易所代號");
                return;
            }
            strTradeName = txtTradeNo.Text.Trim();

            if (txtStockNo.Text.Trim() == "")
            {
                MessageBox.Show("請輸入商品代碼");
                return;
            }
            strStockNo = txtStockNo.Text.Trim();

            if (txtYearMonth.Text.Trim() == "")
            {
                MessageBox.Show("請輸入年月");
                return;
            }
            strYearMonth = txtYearMonth.Text.Trim();

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

            if (boxBidAsk.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇買賣別");
                return;
            }
            nBuySell = boxBidAsk.SelectedIndex;

            if (boxNewClose.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇倉別");
                return;
            }
            nNewClose = boxNewClose.SelectedIndex;

            if (boxFlag.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇當沖與否");
                return;
            }
            nDayTrade = boxFlag.SelectedIndex;

            if (boxPeriod.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇委託條件");
                return;
            }
            nTradeType = boxPeriod.SelectedIndex;

            if (boxSpecialTradeType.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇特殊委託條件");
                return;
            }
            nSpecialTradeType = boxSpecialTradeType.SelectedIndex;

             
            m_nCode = Functions.SendOverseaFutureOrderAsync(m_UserAccount, strTradeName, strStockNo, strYearMonth, nBuySell, nNewClose, nDayTrade, nTradeType, nSpecialTradeType, nQty, strPrice, "0", "0", "0");
             
            if (GetMessage != null)
            {
                if (m_nCode < 0)
                    GetMessage("SendOverseaFutureOrderAsync", m_nCode, m_strMessage);
                else
                    GetMessage("SendOverseaFutureOrderAsync", m_nCode, "");
            } 

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            m_nCode = Functions.GetOverseaCount();

            if (m_nCode >= 0)
            {
                txtCount.Text = m_nCode.ToString();

                lblIndext.Text = "商品序號( 0~" + (m_nCode-1).ToString() + " )";
            }
            else
            {
                if (GetMessage != null)
                {
                    GetMessage("GetOverseaCount", m_nCode, "");
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtIndext.Text == "")
            {
                MessageBox.Show("請輸入欲查詢商品序號");
                return;
            }

            int nIndext = -1;

            if (int.TryParse(txtIndext.Text.Trim(), out nIndext) == false )
            {
                MessageBox.Show("商品序號請輸入數字");
                return;
            }

            SOfComProduct   myProduct;
            string          strMsg;

            m_nCode = Functions.GetOverseaProducts(nIndext, out myProduct);

            strMsg = string.Format("交易所代號:{0}  商品代號:{1}  商品年月:{2}  特殊條件:{3}  跳動點:{4}  分母:{5}  是否可當沖{6}",
                                    myProduct.strExchange, myProduct.strProductNo, myProduct.strYearMonth, myProduct.sSpecialTradeType, myProduct.dMinJump, myProduct.nDenominator, myProduct.sDayTrade);
            
            if (GetMessage != null)
            {
                GetMessage("GetOverseaProducts", m_nCode, strMsg);
            }
        }

        private void btnQueryAll_Click(object sender, EventArgs e)
        {
            OverseaFutureProduct myProduct = new OverseaFutureProduct();

            myProduct.Show();

            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            m_nCode = Functions.ReloadOverseaProducts();

            if (GetMessage != null)
            {
                GetMessage("ReloadOverseaProducts", m_nCode, "");
            }
        }

        private void btnCancelOrderBySeqNo_Click(object sender, EventArgs e)
        {
            string strSeqNo = txtCancelSeqNo.Text.Trim();

            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.OverseaCancelOrderBySeqNo(m_UserAccount, strSeqNo, strMessage, out nSiz);

            if (GetMessage != null)
            {
                GetMessage("OverseaCancelOrderBySeqNo", m_nCode, strMessage.ToString() );
            }

            strMessage = null;
        }

        private void btnDecreaseQty_Click(object sender, EventArgs e)
        {
            int nQty;

            if (int.TryParse(txtDecreaseQty.Text.Trim(), out nQty))
            {
                string strSeqNo = txtCancelSeqNo.Text.Trim();

                StringBuilder strMessage = new StringBuilder();
                strMessage.Length = 1024;
                Int32 nSiz = 1024;

                m_nCode = Functions.OverseaDecreaseOrderBySeqNo(m_UserAccount, strSeqNo, nQty, strMessage, out nSiz);

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

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            m_nCode = Functions.UnlockOrder("OF");

            if (GetMessage != null)
            {
                GetMessage("UnlockOrder", m_nCode, "");
            }
        }

        private void btnOpenInterest_Click(object sender, EventArgs e)
        {
            fOnOverseaFutureOpenInterest = new FOnOverseaFutureOpenInterest(OnOverseaFutureOpenInterest);
            m_nCode = Functions.RegisterOnOverseaFutureOpenInterestCallBack(fOnOverseaFutureOpenInterest);
            m_nCode = Functions.GetOverseaFutureOpenInterest(m_UserAccount);
        }

        #endregion

        

        #region Custom Method
        //----------------------------------------------------------------------
        // Custom Method
        //----------------------------------------------------------------------

        void OnOverseaFutureOpenInterest(string strData)
        {
            if (GetMessage != null)
            {
                GetMessage("GetOverseaProducts", 0, strData);
            }   
        }
        
        #endregion

        
    }
}