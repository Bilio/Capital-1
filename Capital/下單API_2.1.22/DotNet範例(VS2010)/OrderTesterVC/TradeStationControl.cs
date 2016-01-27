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
    public partial class TradeStationControl : UserControl
    {
        #region Define Variable
        //----------------------------------------------------------------------
        // Define Variable
        //----------------------------------------------------------------------
        private delegate void InvokeSendMessage(string state);
        FOnTSFilledOrder    fOnTSFilledOrder;
        FOnTSActiveOrder    fOnTSActiveOrder;
        FOnTSCanceledOrder  fOnTSCanceledOrder;

        Logger   Log;

        #endregion

        #region Initialize
        //----------------------------------------------------------------------
        // Initialize
        //----------------------------------------------------------------------
        public TradeStationControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Component Event
        //----------------------------------------------------------------------
        // Component Event
        //----------------------------------------------------------------------\
        private void TradeStationControl_Load(object sender, EventArgs e)
        {
            Log = new Logger();

            fOnTSActiveOrder = new FOnTSActiveOrder(OnTSActiveOrder);
            GC.KeepAlive(fOnTSActiveOrder);
            Log.Write("NEW fOnTSActiveOrder and KeepAlive");

            fOnTSCanceledOrder = new FOnTSCanceledOrder(OnTSCanceledOrder);
            GC.KeepAlive(fOnTSCanceledOrder);

            fOnTSFilledOrder = new FOnTSFilledOrder(OnTSFilledOrder);
            GC.KeepAlive(fOnTSFilledOrder);
        }

        #endregion

        private void btnInitializeTS_Click(object sender, EventArgs e)
        {
            try
            {
                int nCode;

                nCode = Functions.SKOrderLib_InitializeTS("");

                if (nCode == 0 || nCode == 2002)
                {
                    lblInitialize.Text = "TS初始成功  ";

                    nCode = Functions.RegisterOnTSActiveOrderCallBack(fOnTSActiveOrder);
                    Log.Write("RegisterOnTSActiveOrderCallBack" + nCode.ToString());

                    if (nCode != 0)
                    {
                        lblInitialize.Text += " RegisterOnTSActiveOrderCallBack 失敗 Code: " + nCode.ToString();
                    }

                    nCode = Functions.RegisterOnTSCanceledOrderCallBack(fOnTSCanceledOrder);
                    if (nCode != 0)
                    {
                        lblInitialize.Text += " RegisterOnTSCanceledOrderCallBack 失敗 Code: " + nCode.ToString();
                    }

                    nCode = Functions.RegisterOnTSFilledOrderCallBack(fOnTSFilledOrder);
                    if (nCode != 0)
                    {
                        lblInitialize.Text += " RegisterOnTSFilledOrderCallBack 失敗 Code: " + nCode.ToString();
                    } 
                }
                else
                {
                    lblInitialize.Text = "TS初始失敗 Code ：" + nCode.ToString();
                    Log.Write(lblInitialize.Text);
                }
            }
            catch(Exception ex )
            {
                Log.Write(ex.Message.ToString()); 
            }
        }

        #region Custom Method
        //----------------------------------------------------------------------
        // Custom Method
        //----------------------------------------------------------------------

        public void OnTSFilledOrder(string bstrSymbol, string bstrDescription, string bstrOrderType, string bstrOrder, int lFillPrice, int lSlippage, double dTimePlace, double dTimeFilled, string bstrStrategy, string bstrSignal, string bstrWorkspace, string bstrInterval, string bstrPositionNumber, string bstrOrderNumber)
        {
            try
            {
                string strOrderMsg = "callback";

                strOrderMsg = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
                                            bstrSymbol.Trim(),
                                            bstrDescription.Trim(),
                                            bstrOrderType.Trim(),
                                            bstrOrder.Trim(),
                                            lFillPrice.ToString().Trim(),
                                            lSlippage.ToString().Trim(),
                                            dTimePlace.ToString().Trim(),
                                            dTimeFilled.ToString().Trim(),
                                            bstrStrategy.Trim(),
                                            bstrSignal.Trim(),
                                            bstrWorkspace.Trim(),
                                            bstrInterval.Trim(),
                                            bstrPositionNumber.Trim(),
                                            bstrOrderNumber.Trim()
                                            );

                Log.Write("  FilledOrder：" + strOrderMsg);

                WriteInfo( DateTime.Now.ToString("hh:mm:ss")+"  FilledOrder："+strOrderMsg);

            }
            catch(Exception ex )
            {
                Log.Write(ex.Message.ToString()); 
            }

        }

        public void OnTSActiveOrder(string bstrSymbol, string bstrDescription, string bstrOrderType, string bstrOrder, int lLastPrice, double dTimePlaced, string bstrStrategy, string bstrSignal, string bstrWorkspace, string bstrInterval, string bstrPositionNumber, string bstrOrderNumber)
        {
            try
            {
                string strOrderMsg = "callback";

                strOrderMsg = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                                             bstrSymbol.Trim(),
                                             bstrDescription.Trim(),
                                             bstrOrderType.Trim(),
                                             bstrOrder.Trim(),
                                             lLastPrice.ToString().Trim(),
                                             dTimePlaced.ToString().Trim(),
                                             bstrStrategy.Trim(),
                                             bstrSignal.Trim(),
                                             bstrWorkspace.Trim(),
                                             bstrInterval.Trim(),
                                             bstrPositionNumber.Trim(),
                                             bstrOrderNumber.Trim()
                                            );

                Log.Write("  ActiveOrder：" + strOrderMsg);
                WriteInfo(DateTime.Now.ToString("hh:mm:ss") + "  ActiveOrder：" + strOrderMsg);


            }
            catch (Exception ex)
            {
                Log.Write(ex.Message.ToString()); 
            }
        }

        public void OnTSCanceledOrder(string bstrSymbol, string bstrDescription, string bstrOrderType, string bstrOrder, double dTimePlaced, double dTimeCanceled, string bstrStrategy, string bstrSignal, string bstrWorkspace, string bstrInterval, string bstrPositionNumber, string bstrOrderNumber, string bstrCanceledNumber)
        {
            try
            {
                string strOrderMsg = "callback";

                strOrderMsg = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}",
                                            bstrSymbol.Trim(),
                                            bstrDescription.Trim(),
                                            bstrOrderType.Trim(),
                                            bstrOrder.Trim(),
                                            dTimePlaced.ToString().Trim(),
                                            dTimeCanceled.ToString().Trim(),
                                            bstrStrategy.Trim(),
                                            bstrSignal.Trim(),
                                            bstrWorkspace.Trim(),
                                            bstrInterval.Trim(),
                                            bstrPositionNumber.Trim(),
                                            bstrOrderNumber.Trim(),
                                            bstrCanceledNumber.Trim()
                                            );

                Log.Write("  CanceledOrder：" + strOrderMsg);

                WriteInfo(DateTime.Now.ToString("hh:mm:ss") + "  CanceledOrder：" + strOrderMsg);
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message.ToString()); 
            }
        }

        public void WriteInfo(string strMsg)
        {
            try
            {
                if (listTSInfo.InvokeRequired == true)
                {
                    BeginInvoke(new InvokeSendMessage(this.WriteInfo), new object[] { strMsg });
                }
                else
                {
                    listTSInfo.Items.Add(strMsg.Trim());

                    listTSInfo.SelectedIndex = listTSInfo.Items.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion

    }
}
