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
    public partial class OptionStopLossControl : UserControl
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
        public OptionStopLossControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Component Event
        //----------------------------------------------------------------------
        // Component Event
        //----------------------------------------------------------------------
        private void btnSendMovingOrder_Click(object sender, EventArgs e)
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
            string strMovingPoint;
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

            if (txtMovingPoint.Text.Trim() == "")
            {
                MessageBox.Show("請輸入移動點數");
                return;
            }
            strMovingPoint = txtMovingPoint.Text.Trim();

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

            m_nCode = Functions.SendOptionStopLoss(m_UserAccount, strFutureNo, nPeriod, nFlag, nBidAsk, strTriggerPrice, nQty, strMovingPoint, strMessage, out nSiz);

            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("OptionStopLoss", m_nCode, m_strMessage);
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

            if (txtBookNo.Text.Trim() == "")
            {
                MessageBox.Show("請輸入委託序號");
                return;
            }
            strBookNo = txtBookNo.Text.Trim();


            StringBuilder strMessage = new StringBuilder();
            strMessage.Length = 1024;
            Int32 nSiz = 1024;

            m_nCode = Functions.CancelOptionStopLoss(m_UserAccount, strBookNo, "0", "0", "0", "0", "0", "0", "0", strMessage, out nSiz);

            m_strMessage = strMessage.ToString();

            if (GetMessage != null)
            {
                GetMessage("CancelOptionStopLoss", m_nCode, m_strMessage);
            }
        }

        #endregion

        #region Custom Method
        //----------------------------------------------------------------------
        // Custom Method
        //----------------------------------------------------------------------


        #endregion
    }
}
