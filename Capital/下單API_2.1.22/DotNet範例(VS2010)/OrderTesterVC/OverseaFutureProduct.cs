using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderTester
{
    public partial class OverseaFutureProduct : Form
    {

        public OverseaFutureProduct()
        {
            InitializeComponent();
        }

        private void OverseaFutureProduct_Load(object sender, EventArgs e)
        {
            //Get Oversea Product
            int m_nCode;

            FOnGetBSTR fOnOverseaFuture = new FOnGetBSTR(OnOverseaFuture);
            m_nCode = Functions.RegisterOnOverseaFuturesCallBack(fOnOverseaFuture);
            m_nCode = Functions.GetOverseaFutures();
        }

        public void OnOverseaFuture(string strMsg)
        {
            DataGridViewRowCollection rows = GridProducts.Rows;

            string[] strRowData = strMsg.Split(';');
            rows.Add(strRowData);
        }
    }
}
