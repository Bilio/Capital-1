
// QuoteTesterDlg.cpp : 實作檔
//

#include "stdafx.h"
#include "QuoteTester.h"
#include "QuoteTesterDlg.h"
#include "afxdialogex.h"
#include "Functions.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CQuoteTesterDlg 對話方塊

int m_nType = 0;

int m_nMarketTot = 0;
int m_nMarketBuySale = 0;
int m_nMarketHightLow = 0;


CQuoteTesterDlg::CQuoteTesterDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CQuoteTesterDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

CQuoteTesterDlg::~CQuoteTesterDlg()
{
	SKQuoteLib_LeaveMonitor();
}

void CQuoteTesterDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CQuoteTesterDlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_MESSAGE(WM_DATA,&CQuoteTesterDlg::OnData)
	ON_BN_CLICKED(IDC_BUTTON1, &CQuoteTesterDlg::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_BUTTON2, &CQuoteTesterDlg::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BUTTON3, &CQuoteTesterDlg::OnBnClickedButton3)
	ON_BN_CLICKED(IDC_BUTTON4, &CQuoteTesterDlg::OnBnClickedButton4)
	ON_BN_CLICKED(IDC_BUTTON5, &CQuoteTesterDlg::OnBnClickedButton5)
	ON_BN_CLICKED(IDC_BUTTON6, &CQuoteTesterDlg::OnBnClickedButton6)
	ON_BN_CLICKED(IDC_BUTTON8, &CQuoteTesterDlg::OnBnClickedButton8)
	ON_BN_CLICKED(IDC_BUTTON10, &CQuoteTesterDlg::OnBnClickedButton10)
	ON_BN_CLICKED(IDC_BUTTON7, &CQuoteTesterDlg::OnBnClickedButton7)
	ON_BN_CLICKED(IDC_BUTTON11, &CQuoteTesterDlg::OnBnClickedButton11)
	ON_BN_CLICKED(IDC_BUTTON12, &CQuoteTesterDlg::OnBnClickedButton12)
END_MESSAGE_MAP()


// CQuoteTesterDlg 訊息處理常式

BOOL CQuoteTesterDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// 設定此對話方塊的圖示。當應用程式的主視窗不是對話方塊時，
	// 框架會自動從事此作業
	SetIcon(m_hIcon, TRUE);			// 設定大圖示
	SetIcon(m_hIcon, FALSE);		// 設定小圖示

	// TODO: 在此加入額外的初始設定

	CComboBox   *pComboBox   =   (CComboBox *)GetDlgItem(IDC_COMBO_KLine); 

	pComboBox->AddString(_T("1分鐘線"));
	pComboBox->AddString(_T("5分鐘線"));
	pComboBox->AddString(_T("30分鐘線"));
	pComboBox->AddString(_T("日線228天"));
	pComboBox->AddString(_T("完整日線"));
	pComboBox->AddString(_T("週線"));
	pComboBox->AddString(_T("月線"));

	pComboBox->SetCurSel(0);


	return TRUE;  // 傳回 TRUE，除非您對控制項設定焦點
}

// 如果將最小化按鈕加入您的對話方塊，您需要下列的程式碼，
// 以便繪製圖示。對於使用文件/檢視模式的 MFC 應用程式，
// 框架會自動完成此作業。

void CQuoteTesterDlg::OnPaint()
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
HCURSOR CQuoteTesterDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

/*******************************************************
CALLBACK
*********************************************************/
void _stdcall OnConnect( int nKind, int nErrorCode)
{
	//if( nKind == SK_SUBJECT_CONNECTION_CONNECTED)
		//AfxMessageBox(_T("CONNECTED"));
	if( nKind == SK_SUBJECT_CONNECTION_DISCONNECT)
		AfxMessageBox(_T("DISCONNECT"));

	CString strMsg;
	strMsg.Format(_T("Connect  nKind：%d nErrorCode：%d"),nKind,nErrorCode);

	BSTR bstrMsg = strMsg.AllocSysString();

	SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,98,(int)bstrMsg);

	SysFreeString(bstrMsg);
}

//
void _stdcall OnNotifyQuote( short sMarketNo, short sStockidx)
{
	if( m_nType == 1 )
	{
		TStock* tStock = new TStock();

		SKQuoteLib_GetStockByIndex(sMarketNo,sStockidx,tStock);

		CString strStockNo(tStock->m_caStockNo);
		CString strStockName(tStock->m_caName);

		CString strMsg;
		strMsg.Format(_T("%s %s 買價:%d 買量:%d 賣價:%d 買量:%d 成交價:%d 成交量:%d"),
			strStockNo,
			strStockName,
			tStock->m_nBid,
			tStock->m_nBc,
			tStock->m_nAsk,
			tStock->m_nAc,
			tStock->m_nClose,
			tStock->m_nTQty);

		BSTR bstrMsg = strMsg.AllocSysString();

		SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,m_nType,(int)bstrMsg);

		delete tStock;
		tStock = NULL;

		SysFreeString(bstrMsg);
	}
}

void _stdcall OnNotifyTicks( short sMarketNo, short sStockidx, int nPtr)
{
	if( m_nType == 2 )
	{
/*
		TTick* tTick = new TTick();

		SKQuoteLib_GetTick(sMarketNo,sStockidx,nPtr,tTick);

		CString strMsg;

		strMsg.Format(_T("TICK %d 買價:%d 賣價:%d 成交價:%d 量:%d "),
			tTick->m_nTime,
			tTick->m_nBid,
			tTick->m_nAsk,
			tTick->m_nClose,
			tTick->m_nQty);

		BSTR bstrMsg = strMsg.AllocSysString();

		SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,m_nType,(int)bstrMsg);

		//delete tTick;
		//tTick = NULL;
		
		SysFreeString(bstrMsg);
*/
	}
}

void _stdcall OnNotifyTicksGet( short sMarketNo, short sStockidx, int nPtr, int nTime,int nBid, int nAsk, int nClose, int nQty)
{
	if( m_nType == 2 )
	{
		CString strMsg;

		strMsg.Format(_T("TICK 編號:%d 時間:%d 買價:%d 賣價:%d 成交價:%d 量:%d "),
			nPtr,
			nTime,
			nBid,
			nAsk,
			nClose,
			nQty);

		BSTR bstrMsg = strMsg.AllocSysString();

		SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,m_nType,(int)bstrMsg);

		SysFreeString(bstrMsg);
	}
}


void _stdcall OnNotifyBest5( short sMarketNo, short sStockidx)
{
	if( m_nType == 2 )
	{
		TBest5* tBest5 = new TBest5();

		SKQuoteLib_GetBest5(sMarketNo,sStockidx,tBest5);

		
		CString strMsg;
		strMsg.Format(_T("Best5 %d %d %d %d"),
			tBest5->m_nBid1,
			tBest5->m_nBidQty1,
			tBest5->m_nAsk1,
			tBest5->m_nAskQty1);

		BSTR bstrMsg = strMsg.AllocSysString();

		SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,m_nType,(int)bstrMsg);

		delete tBest5;
		tBest5 = NULL;
		
		SysFreeString(bstrMsg);

	}
}

void _stdcall OnNotifyKLineData( char * caStockNo, char * caData )
{
	if( m_nType == 3 )
	{
		CString strStockNo(caStockNo);
		CString strData(caData);

		CString strMsg;
		strMsg.Format(_T("%s %s"),strStockNo,strData);

		
		BSTR bstrMsg = strMsg.AllocSysString();

		SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,m_nType,(int)bstrMsg);
		
		SysFreeString(bstrMsg);
	}
}

void _stdcall OnNotifyMarketTot( char cMarketNo , short sPrt, long lTime, long lTotv, long lTots, long lTotc )
{
	if( m_nType == 4 )
	{
		m_nMarketTot = sPrt;
		
		int nMarketNo =cMarketNo;

		CString strMsg;
		strMsg.Format(_T("%d 時間:%d 成交(億):%d 筆數:%d 張數:%d"),
				nMarketNo,lTime,lTotv,lTots,lTotc);

		BSTR bstrMsg = strMsg.AllocSysString();

		SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,m_nType,(int)bstrMsg);
		
		SysFreeString(bstrMsg);
	}
}

void _stdcall OnNotifyMarketBuySell( char cMarketNo , short sPrt, long lTime,long lBc, long lSc, long lBs, long lSs )
{
	if( m_nType == 4 )
	{
		m_nMarketBuySale = sPrt;
		
		int nMarketNo =cMarketNo;

		CString strMsg;
		strMsg.Format(_T("%d 時間:%d 買進筆數:%d 賣出筆數:%d 買進張數:%d 賣出張數:%d"),
			nMarketNo,lTime,lBc, lSc, lBs, lSs);

		BSTR bstrMsg = strMsg.AllocSysString();

		SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,m_nType,(int)bstrMsg);
		
		SysFreeString(bstrMsg);
	}
}

void _stdcall OnNotifyMarketHighLow( char cMarketNo , short sPrt, long lTime, short sUp, short sDown, short sHigh, short sLow, short sNoChange )
{
	if( m_nType == 4 )
	{
		m_nMarketHightLow = sPrt;
		int nMarketNo =cMarketNo;

		CString strMsg;
		strMsg.Format(_T("%d 時間:%d 上漲家:%d 下跌家:%d 漲停家:%d 跌停家:%d  平盤家:%d"),
			 nMarketNo,lTime,sUp,  sDown,  sHigh,  sLow,  sNoChange );

		BSTR bstrMsg = strMsg.AllocSysString();

		SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,m_nType,(int)bstrMsg);
		
		SysFreeString(bstrMsg);
	}
}

void _stdcall OnNotifyStrikePrices( BSTR BProduct, BSTR BName, BSTR BCall, BSTR BPut, int nStrikePrice, int nYearMonth )
{
	if( m_nType == 5 )
	{
		CString strProduct(BProduct);
		CString strName(BName);
		CString strCall(BCall);
		CString strPut(BPut);

		CString strMsg;

		strMsg.Format(_T("%s %s  Call: %s  Put: %s  履約價:%d 年月:%d"),
			   strProduct,strName,strCall,strPut,nStrikePrice,nYearMonth);

		BSTR bstrMsg = strMsg.AllocSysString();

		SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,m_nType,(int)bstrMsg);
		
		SysFreeString(bstrMsg);

	}
}

void _stdcall OnNotifyServerTime( short sHour, short sMinute, short sSecond, int nTotal)
{
	CString strMsg;
	strMsg.Format(_T("時間 %d:%d:%d"),sHour,sMinute,sSecond);

	BSTR bstrMsg = strMsg.AllocSysString();

	SendMessage(FindWindow(NULL,_T("QuoteTester")),WM_DATA,99,(int)bstrMsg);
		
	SysFreeString(bstrMsg);
}

void _stdcall OnNotifyProductsReady()
{
	AfxMessageBox(_T("商品載入完成!"));

}

//////////////////////////////////////////////////////////////////////////////////////////////////////
void CQuoteTesterDlg::OnBnClickedButton1()
{
	// TODO: Add your control notification handler code here
	int  nCode = 0;

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_EDIT_ID); 
	CString strText;
	pEdit->GetWindowTextW(strText);

    pEdit = (CEdit*) GetDlgItem(IDC_EDIT_Pass); 
	CString strPassword;
	pEdit->GetWindowTextW(strPassword);

	CStringA strTempA(strText);
	const CHAR* caText = (LPCSTR)strTempA;
	
	CStringA strTempB(strPassword);
	const CHAR* caPass = (LPCSTR)strTempB;

	nCode = SKQuoteLib_Initialize(caText,caPass);

	if( nCode == 0 )
	{
		//註冊CALLBACK
		nCode = SKQuoteLib_AttachConnectionCallBack( (UINT_PTR) OnConnect);
		nCode = SKQuoteLib_AttachQuoteCallBack( (UINT_PTR) OnNotifyQuote);
		nCode = SKQuoteLib_AttachBest5CallBack( (UINT_PTR) OnNotifyBest5);
		//nCode = SKQuoteLib_AttachTicksCallBack( (UINT_PTR) OnNotifyTicks);
		nCode = SKQuoteLib_AttachTicksGetCallBack( (UINT_PTR) OnNotifyTicksGet);
		nCode = SKQuoteLib_AttachKLineDataCallBack( (UINT_PTR)OnNotifyKLineData );
		nCode = SKQuoteLib_AttachMarketTotCallBack( (UINT_PTR)OnNotifyMarketTot );
		nCode = SKQuoteLib_AttachMarketBuySellCallBack( (UINT_PTR)OnNotifyMarketBuySell );
		nCode = SKQuoteLib_AttachMarketHighLowCallBack( (UINT_PTR)OnNotifyMarketHighLow );
		nCode = SKQuoteLib_AttachStrikePricesCallBack( (UINT_PTR)OnNotifyStrikePrices );
		nCode = SKQuoteLib_AttchServerTimeCallBack( (UINT_PTR)OnNotifyServerTime );
		nCode = SKQuoteLib_AttachHistoryTicksGetCallBack( (UINT_PTR) OnNotifyTicksGet);
		nCode = SKQuoteLib_AttachProductsReadyCallBack( (UINT_PTR) OnNotifyProductsReady);

		AfxMessageBox(_T("初始成功"));
	}
}


void CQuoteTesterDlg::OnBnClickedButton2()
{
	// TODO: Add your control notification handler code here
	m_nType = 1;

	int nCOde = SKQuoteLib_EnterMonitor();

	CString strMsg;
	strMsg.Format(_T("SKQuoteLib_EnterMonitor  Code %d"),nCOde);

	BSTR bstrMsg = strMsg.AllocSysString();

	SendMessage(WM_DATA,98,(int)bstrMsg);
		
	SysFreeString(bstrMsg);
}

void CQuoteTesterDlg::OnBnClickedButton3()
{
	// TODO: Add your control notification handler code here
	SKQuoteLib_LeaveMonitor();
}


LRESULT CQuoteTesterDlg::OnData(WPARAM wParam,LPARAM lParam)
{
	if( wParam == 99 )
	{
		BSTR bstrData = (BSTR)lParam;

		CString strReport( bstrData);

		GetDlgItem(IDC_STATIC_TIME)->SetWindowTextW(strReport); 

		SysFreeString(bstrData);
	
		return 0;
	}
	else if( wParam == 98 )
	{
		BSTR bstrData = (BSTR)lParam;

		CString strReport( bstrData);
	
		CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 

		pListBox->InsertString(0,strReport);

		SysFreeString(bstrData);
	}
	else if( m_nType == wParam )
	{
		BSTR bstrData = (BSTR)lParam;

		CString strReport( bstrData);
	
		CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 

		pListBox->InsertString(0,strReport);

		SysFreeString(bstrData);
	
		return 0;
	}
}



void CQuoteTesterDlg::OnBnClickedButton4()
{
	// TODO: Add your control notification handler code here
	int		nCode = 0;
	short	sPageNo = 1;

	m_nType = 1;

	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->ResetContent();

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_EDIT_Stock); 
	CString strText;
	pEdit->GetWindowTextW(strText);

	CStringA strTempA(strText);
	char*   caText   =   strTempA.GetBuffer(strTempA.GetLength()); 

	nCode = SKQuoteLib_RequestStocks(&sPageNo,caText);

}


void CQuoteTesterDlg::OnBnClickedButton5()
{
	// TODO: Add your control notification handler code here

	int		nCode = 0;
	short	sPageNo = 1;

	m_nType = 2;

	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->ResetContent();

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_EDIT_Ticks); 
	CString strText;
	pEdit->GetWindowTextW(strText);
	
	CStringA strTempA(strText);
	char*   caText   =   strTempA.GetBuffer(strTempA.GetLength()); 
	
	SKQuoteLib_RequestTicks(&sPageNo,caText);
}


void CQuoteTesterDlg::OnBnClickedButton6()
{
	// TODO: Add your control notification handler code here

	CComboBox   *pComboBox   =   (CComboBox *)GetDlgItem(IDC_COMBO_KLine); 

	int nType = pComboBox->GetCurSel();

	m_nType = 3;

	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->ResetContent();

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_EDIT_KLine); 
	CString strText;
	pEdit->GetWindowTextW(strText);
	
	CStringA strTempA(strText);
	char*   caText   =   strTempA.GetBuffer(strTempA.GetLength()); 

	SKQuoteLib_GetKLine(caText,nType);
}

void CQuoteTesterDlg::OnBnClickedButton8()
{
	// TODO: Add your control notification handler code here
	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->ResetContent();

	CComboBox   *pComboBox   =   (CComboBox *)GetDlgItem(IDC_COMBO_KLine); 
	int nType = pComboBox->GetCurSel();

	m_nType = 4;
}


void CQuoteTesterDlg::OnBnClickedButton10()
{
	// TODO: Add your control notification handler code here

	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 
	pListBox->ResetContent();
	
	CComboBox   *pComboBox   =   (CComboBox *)GetDlgItem(IDC_COMBO_KLine); 
	int nType = pComboBox->GetCurSel();

	m_nType = 5;

	SKQuoteLib_GetStrikePrices();
}

void CQuoteTesterDlg::OnBnClickedButton7()
{
	// TODO: Add your control notification handler code here

	SKQuoteLib_RequestServerTime();
}

void CQuoteTesterDlg::OnBnClickedButton11()
{
	// TODO: Add your control notification handler code here

	char cVersion[1024]  = {0};
	int nSize = sizeof(cVersion);

	SKQuoteLib_GetVersion( cVersion, &nSize);

	AfxMessageBox((CString)cVersion);
}

void CQuoteTesterDlg::OnBnClickedButton12()
{
	// TODO: Add your control notification handler code here

	if( m_nType == 1 )
	{
		TStock* tStock = new TStock();
		BSTR bstrMsg;

		for(int i = 0; i<5; i++)
		{
			int nStockidx = 0;
			while(true)
			{
				int nCode = SKQuoteLib_GetStockByIndex(i,nStockidx,tStock);

				if(nCode != 0)
					break;

				CString strStockNo(tStock->m_caStockNo);
				CString strStockName(tStock->m_caName);

				CString strMsg;
				strMsg.Format(_T("Stockidx:%d  StockNo:%s  StockName:%s"),
					tStock->m_sStockidx,
					strStockNo,
					strStockName);

				bstrMsg = strMsg.AllocSysString();

				SendMessage(WM_DATA,m_nType,(int)bstrMsg);

				nStockidx++;
			}
		}

		SysFreeString(bstrMsg);

		delete tStock;
		tStock = NULL;
	}
}
