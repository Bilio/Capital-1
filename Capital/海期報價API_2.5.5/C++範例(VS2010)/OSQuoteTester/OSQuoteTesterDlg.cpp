
// OSQuoteTesterDlg.cpp : 實作檔
//

#include "stdafx.h"
#include "OSQuoteTester.h"
#include "OSQuoteTesterDlg.h"
#include "afxdialogex.h"
#include "Function.h"



#include   <math.h> 


#ifdef _DEBUG
#define new DEBUG_NEW
#endif


UINT_PTR m_nTimer;

// COSQuoteTesterDlg 對話方塊

COSQuoteTesterDlg::COSQuoteTesterDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(COSQuoteTesterDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void COSQuoteTesterDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(COSQuoteTesterDlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_LogIn, &COSQuoteTesterDlg::OnBnClickedLogin)
	ON_MESSAGE(WM_UPDATE,&COSQuoteTesterDlg::OnQuoteUpdate)
	ON_MESSAGE(WM_TICKS,&COSQuoteTesterDlg::OnTicks)
	ON_MESSAGE(WM_BEST5,&COSQuoteTesterDlg::OnBest5)
	ON_MESSAGE(WM_DATA,&COSQuoteTesterDlg::OnData)
	ON_BN_CLICKED(IDC_BUTTON1, &COSQuoteTesterDlg::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_ClearData, &COSQuoteTesterDlg::OnBnClickedCleardata)
	ON_BN_CLICKED(IDC_TICKS_BUTTON, &COSQuoteTesterDlg::OnBnClickedTicksButton)
	ON_BN_CLICKED(IDC_BUTTON4, &COSQuoteTesterDlg::OnBnClickedButton4)
	ON_BN_CLICKED(IDC_BUTTON5, &COSQuoteTesterDlg::OnBnClickedButton5)
	ON_BN_CLICKED(IDC_BUTTON2, &COSQuoteTesterDlg::OnBnClickedButton2)
	ON_WM_TIMER()
	ON_BN_CLICKED(IDC_BUTTON3, &COSQuoteTesterDlg::OnBnClickedButton3)
END_MESSAGE_MAP()


// COSQuoteTesterDlg 訊息處理常式

BOOL COSQuoteTesterDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// 設定此對話方塊的圖示。當應用程式的主視窗不是對話方塊時，
	// 框架會自動從事此作業
	SetIcon(m_hIcon, TRUE);			// 設定大圖示
	SetIcon(m_hIcon, FALSE);		// 設定小圖示

	// TODO: 在此加入額外的初始設定

	CComboBox   *pComboBox   =   (CComboBox *)GetDlgItem(IDC_KLINETYPE); 

	pComboBox->AddString(_T("分鐘線"));
	pComboBox->AddString(_T("日線"));
	pComboBox->AddString(_T("週線"));
	pComboBox->AddString(_T("月線"));

	pComboBox->SetCurSel(0);

	m_sTickDecimal	= -1;
	m_nDenominator	= -1;

	return TRUE;  // 傳回 TRUE，除非您對控制項設定焦點
}

// 如果將最小化按鈕加入您的對話方塊，您需要下列的程式碼，
// 以便繪製圖示。對於使用文件/檢視模式的 MFC 應用程式，
// 框架會自動完成此作業。

void COSQuoteTesterDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // 繪製的裝置內容

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// 將圖示置中於用戶端矩形
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// 描繪圖示
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// 當使用者拖曳最小化視窗時，
// 系統呼叫這個功能取得游標顯示。
HCURSOR COSQuoteTesterDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

/*
CALL BACK FUNCTION
*/

void _stdcall OnConnect( int nKind, int nErrorCode)
{
	if( nKind == SK_SUBJECT_CONNECTION_CONNECTED)
	{
		AfxMessageBox(_T("CONNECTED"));
		
		m_nTimer = SetTimer(FindWindow(NULL,_T("OSQuoteTester")),1, 60000, 0);
	}
	else if( nKind == SK_SUBJECT_CONNECTION_DISCONNECT)
	{
		AfxMessageBox(_T("DISCONNECT"));
		KillTimer(FindWindow(NULL,_T("OSQuoteTester")),m_nTimer);
	}
}


void _stdcall OnNotifyQuote( short sStockidx)
{
	PostMessage(FindWindow(NULL,_T("OSQuoteTester")),WM_UPDATE,0,sStockidx);
} 

void _stdcall OnNotifyTicks(short sStockidx, int nPtr)
{
	PostMessage(FindWindow(NULL,_T("OSQuoteTester")),WM_TICKS,sStockidx,nPtr);
}

void _stdcall FOnNotifyBest5( short sStockidx)
{
	PostMessage(FindWindow(NULL,_T("OSQuoteTester")),WM_BEST5,0,sStockidx);
}

void _stdcall OnNotifyKLineData(BSTR bstrStockNo, BSTR bstrData)
{
	SendMessage(FindWindow(NULL,_T("OSQuoteTester")),WM_DATA,(int)bstrStockNo,(int)bstrData);
}

void _stdcall OnOverseaProducts( BSTR bstrData)
{
	SendMessage(FindWindow(NULL,_T("OSQuoteTester")),WM_DATA,0,(int)bstrData);
}

void _stdcall OnNotifyHistoryTicksGet( short sStockidx,int nPtr, int nTime, int nClose, int nQty)
{
	PostMessage(FindWindow(NULL,_T("OSQuoteTester")),WM_TICKS,sStockidx,nPtr);
}

void _stdcall OnNotifyKData(int nID, int nTime, int nOpen, int nHigh, int nLow, int nClose, int nRefPrice, int nQty  )
{
	CString strData;
	strData.Format(_T("ID:%d  Time:%d  Open:%d  High:%d  Low:%d  Close:%d  Ref:%d  Qty:%d ")
					,nID, nTime, nOpen, nHigh, nLow, nClose, nRefPrice, nQty);
	
	SendMessage(FindWindow(NULL,_T("OSQuoteTester")),WM_DATA,0,(int)strData.AllocSysString());
}


/*
POSTMESSAGE
*/
LRESULT COSQuoteTesterDlg::OnQuoteUpdate(WPARAM wParam,LPARAM lParam)
{
	if(m_nQueryType == 0)
	{
		int nCode;
		TForeign* Foreign = new TForeign();

		nCode = SKOSQuoteLib_GetStockByIndex(lParam,Foreign);

		CString strStockName(Foreign->m_caStockName);

		CString strMsg;
		strMsg.Format(_T("%s,買價：%s,買量：%d,賣價：%s,賣量：%d,成交價：%s,成交量：%d"),
			strStockName,
			ParsePrice(Foreign->m_nBid,Foreign->m_sDecimal,Foreign->m_nDenominator),
			Foreign->m_nBc,
			ParsePrice(Foreign->m_nAsk,Foreign->m_sDecimal,Foreign->m_nDenominator),
			Foreign->m_nAc,
			ParsePrice(Foreign->m_nClose,Foreign->m_sDecimal,Foreign->m_nDenominator),
			Foreign->m_nTQty);

		CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 


		if( pListBox->GetCount() > 2000 )
		{
			pListBox->ResetContent();
		}

		pListBox->InsertString(0,strMsg);

		delete Foreign;
		Foreign = NULL;
	}

	return 0;
}

LRESULT COSQuoteTesterDlg::OnTicks(WPARAM wParam,LPARAM lParam)
{
	if(m_nQueryType == 1)
	{
		int nCode;
		TTick* pTick = new TTick();

		if( m_sTickDecimal == -1 && m_nDenominator == -1 )
		{
			TForeign* pForeign = new TForeign();

			nCode = SKOSQuoteLib_GetStockByIndex(wParam,pForeign);

			m_sTickDecimal = pForeign->m_sDecimal;

			m_nDenominator = pForeign->m_nDenominator;

			delete pForeign;
			pForeign = NULL;
		}

		nCode = SKOSQuoteLib_GetTick(wParam,lParam,pTick);

		CString strMsg;
		strMsg.Format(_T("TICK：時間 %d、價 %s、量 %d"),
			pTick->m_nTime,
			ParsePrice(pTick->m_nClose,m_sTickDecimal,m_nDenominator),
			pTick->m_nQty);

		CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 

		if( pListBox->GetCount() > 2000 )
		{
			pListBox->ResetContent();
		}

		pListBox->InsertString(0,strMsg);
		

		delete pTick;
		pTick = NULL;
	}

	return 0;
}
LRESULT COSQuoteTesterDlg::OnBest5(WPARAM wParam,LPARAM lParam)
{
	if(m_nQueryType == 1)
	{
		int nCode;
		TBest5* pBest5 = new TBest5();

		if( m_sTickDecimal == -1 && m_nDenominator == -1 )
		{
			TForeign* pForeign = new TForeign();

			nCode = SKOSQuoteLib_GetStockByIndex(wParam,pForeign);

			m_sTickDecimal = pForeign->m_sDecimal;

			m_nDenominator = pForeign->m_nDenominator;

			delete pForeign;
			pForeign = NULL;
		}
		
		nCode = SKOSQuoteLib_GetBest5(lParam,pBest5);

		
		CString strMsg1;
		strMsg1.Format(_T("BEST5：買1~5(價,量) %s,%d、%s,%d、%s,%d、%s,%d、%s,%d  "),
			ParsePrice(pBest5->m_nBid1,m_sTickDecimal,m_nDenominator),pBest5->m_nBidQty1,
			ParsePrice(pBest5->m_nBid2,m_sTickDecimal,m_nDenominator),pBest5->m_nBidQty2,
			ParsePrice(pBest5->m_nBid3,m_sTickDecimal,m_nDenominator),pBest5->m_nBidQty3,
			ParsePrice(pBest5->m_nBid4,m_sTickDecimal,m_nDenominator),pBest5->m_nBidQty4,
			ParsePrice(pBest5->m_nBid5,m_sTickDecimal,m_nDenominator),pBest5->m_nBidQty5);

		CString strMsg2;
		strMsg2.Format(_T("BEST5：賣1~5(價,量) %s,%d、%s,%d、%s,%d、%s,%d、%s,%d  "),
			ParsePrice(pBest5->m_nAsk1,m_sTickDecimal,m_nDenominator),pBest5->m_nAskQty1,
			ParsePrice(pBest5->m_nAsk2,m_sTickDecimal,m_nDenominator),pBest5->m_nAskQty2,
			ParsePrice(pBest5->m_nAsk3,m_sTickDecimal,m_nDenominator),pBest5->m_nAskQty3,
			ParsePrice(pBest5->m_nAsk4,m_sTickDecimal,m_nDenominator),pBest5->m_nAskQty4,
			ParsePrice(pBest5->m_nAsk5,m_sTickDecimal,m_nDenominator),pBest5->m_nAskQty5);
		
		CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 

		if( pListBox->GetCount() > 2000 )
		{
			pListBox->ResetContent();
		}

		pListBox->InsertString(0,strMsg1);
		pListBox->InsertString(0,strMsg2);

		

		delete pBest5;
		pBest5 = NULL;
	}
	return 0;
}

LRESULT COSQuoteTesterDlg::OnData(WPARAM wParam,LPARAM lParam)
{
	BSTR bstrKDATA = (BSTR)lParam;
	CString strData = CString(bstrKDATA);

	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->InsertString(0,strData);

	SysFreeString(bstrKDATA);

	return 0;
}
/*
	
*/
void COSQuoteTesterDlg::OnBnClickedLogin()
{
	// TODO: Add your control notification handler code here
	int  nCode = 0;

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_ID); 
	CString strText;
	pEdit->GetWindowTextW(strText);

    pEdit = (CEdit*) GetDlgItem(IDC_PASSWORD); 
	CString strPassword;
	pEdit->GetWindowTextW(strPassword);
	  
	CStringA strTempA(strText);
	const CHAR* caText = (LPCSTR)strTempA;
	
	CStringA strTempB(strPassword);
	const CHAR* caPass = (LPCSTR)strTempB;

	nCode = SKOSQuoteLib_Initialize(caText,caPass);

	nCode = SKOSQuoteLib_AttachConnectCallBack((UINT_PTR)OnConnect);
	nCode = SKOSQuoteLib_AttachQuoteCallBack((UINT_PTR)OnNotifyQuote);
	nCode = SKOSQuoteLib_AttachTicksCallBack((UINT_PTR)OnNotifyTicks);
	nCode = SKOSQuoteLib_AttachBest5CallBack((UINT_PTR)FOnNotifyBest5);
	nCode = SKOSQuoteLib_AttachKLineDataCallBack((UINT_PTR)OnNotifyKLineData);
	nCode = SKOSQuoteLib_AttachOverseaProductsCallBack((UINT_PTR)OnOverseaProducts);
	nCode = SKOSQuoteLib_AttachHistoryTicksGetCallBack((UINT_PTR)OnNotifyHistoryTicksGet);
	nCode = SKOSQuoteLib_AttachKDataCallBack((UINT_PTR)OnNotifyKData);

	nCode = SKOSQuoteLib_EnterMonitor(0);

}


void COSQuoteTesterDlg::OnBnClickedButton1()
{
	// TODO: Add your control notification handler code here
	int  nCode = 0;

	m_nQueryType = 0;

	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->ResetContent();

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_STOCKS); 
	CString strText;
	pEdit->GetWindowTextW(strText);

	CStringA strTempA(strText);
	char*   caText   =   strTempA.GetBuffer(strTempA.GetLength()); 

	short psPage= 0;

	nCode = SKOSQuoteLib_RequestStocks(&psPage,caText);
}

void COSQuoteTesterDlg::OnBnClickedCleardata()
{
	// TODO: Add your control notification handler code here

	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->ResetContent();
}

void COSQuoteTesterDlg::OnBnClickedTicksButton()
{
	// TODO: Add your control notification handler code here

	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->ResetContent();

	int  nCode		= 0;
	m_nQueryType	= 1;
	m_sTickDecimal	= -1;
	m_nDenominator	= -1;

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_TICKS); 
	CString strText;
	pEdit->GetWindowTextW(strText);
	 
	CStringA strTempA(strText);
	char*   caText   =   strTempA.GetBuffer(strTempA.GetLength()); 

	short psPage= 0;

	nCode = SKOSQuoteLib_RequestTicks(&psPage,caText);

}

void COSQuoteTesterDlg::OnBnClickedButton4()
{
	// TODO: Add your control notification handler code here
	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->ResetContent();

	int  nCode = 0;
	m_nQueryType = -1;


	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_KDATA); 
	CString strText;
	pEdit->GetWindowTextW(strText);
	 
	CStringA strTempA(strText);
	char*   caText   =   strTempA.GetBuffer(strTempA.GetLength()); 


	short sKType;
	CComboBox   *pComboBox   =   (CComboBox *)GetDlgItem(IDC_KLINETYPE); 

	sKType = pComboBox->GetCurSel();

	nCode = SKOSQuoteLib_RequestKLine(caText,sKType);

}


void COSQuoteTesterDlg::OnBnClickedButton5()
{
	// TODO: Add your control notification handler code here
	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->ResetContent();
	
	int  nCode = 0;
	m_nQueryType = -1;

	nCode = SKOSQuoteLib_RequestOverseaProducts();
}


CString COSQuoteTesterDlg::ParsePrice(int nPrice,short sDecimal ,int nDenominator )
{
	CString strPrice;

	double dPrice = (double)nPrice / pow(10.0,sDecimal);
	
	strPrice.Format(_T("%f"),dPrice );
	strPrice.TrimRight('0');

	if(strPrice.Find('.') == strPrice.GetLength()-1 )
		strPrice.TrimRight('.');

	if( nDenominator > 4 )
	{
		if( strPrice.Find('.') != -1 )
		{
			int nPrice = (int)dPrice;

			double dDot			= dPrice - nPrice;
			double dNumerator	= dDot * nDenominator;

			CString strNumerator;
			strNumerator.Format(_T("%f"),dNumerator);
			strNumerator.TrimRight('0');

			if(strNumerator.Find('.') == strNumerator.GetLength()-1 )
				strNumerator.TrimRight('.');

			strPrice.Format(_T("%d'%s"),nPrice,strNumerator);
		}
	}

	return strPrice;

}

void COSQuoteTesterDlg::OnBnClickedButton2()
{
	// TODO: Add your control notification handler code here

	int nCode = SKOSQuoteLib_LeaveMonitor();
}


void COSQuoteTesterDlg::OnTimer(UINT_PTR nIDEvent)
{
	// TODO: Add your message handler code here and/or call default

	CDialogEx::OnTimer(nIDEvent);

	SKOSQuoteLib_RequestServerTime();
}


void COSQuoteTesterDlg::OnBnClickedButton3()
{
	// TODO: Add your control notification handler code here
	
	int  nCode = 0;

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_KDATA); 
	CString strText;
	pEdit->GetWindowTextW(strText);
	 
	CStringA strTempA(strText);
	char*   caText   =   strTempA.GetBuffer(strTempA.GetLength()); 

	short psPage = -1;
	nCode = SKOSQuoteLib_RequestKData(&psPage, caText);

	CString strPageNo;
	strPageNo.Format(_T("PageNo: %d "),psPage);

	MessageBox( strPageNo );
}
