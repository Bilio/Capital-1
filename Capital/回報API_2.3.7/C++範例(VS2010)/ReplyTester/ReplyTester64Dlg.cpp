
// ReplyTester64Dlg.cpp : 實作檔
//

#include "stdafx.h"
#include "ReplyTester64.h"
#include "ReplyTester64Dlg.h"
#include "afxdialogex.h"
#include "Functions.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CReplyTester64Dlg 對話方塊

CReplyTester64Dlg::CReplyTester64Dlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CReplyTester64Dlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CReplyTester64Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CReplyTester64Dlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_MESSAGE(WM_DATA,&CReplyTester64Dlg::OnReplyData)
	ON_BN_CLICKED(IDC_BUTTON1, &CReplyTester64Dlg::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_BUTTON2, &CReplyTester64Dlg::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BUTTON3, &CReplyTester64Dlg::OnBnClickedButton3)
END_MESSAGE_MAP()


// CReplyTester64Dlg 訊息處理常式

BOOL CReplyTester64Dlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// 設定此對話方塊的圖示。當應用程式的主視窗不是對話方塊時，
	// 框架會自動從事此作業
	SetIcon(m_hIcon, TRUE);			// 設定大圖示
	SetIcon(m_hIcon, FALSE);		// 設定小圖示

	// TODO: 在此加入額外的初始設定

	return TRUE;  // 傳回 TRUE，除非您對控制項設定焦點
}

// 如果將最小化按鈕加入您的對話方塊，您需要下列的程式碼，
// 以便繪製圖示。對於使用文件/檢視模式的 MFC 應用程式，
// 框架會自動完成此作業。

void CReplyTester64Dlg::OnPaint()
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
HCURSOR CReplyTester64Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


void __stdcall OnData( BSTR bstrData)
{
	PostMessage(FindWindow(NULL,_T("ReplyTester")),WM_DATA,0,(int)bstrData);
}

void __stdcall OnConnect( BSTR bstrData,int nErrorCode)
{
	CString strData(bstrData);
	CString strMessage;
	strMessage.Format(_T("OnConnect :%s code %d"),strData,nErrorCode);

	BSTR bstrMsg = strMessage.AllocSysString();
	
	SendMessage(FindWindow(NULL,_T("ReplyTester")),WM_DATA,1,(int)bstrMsg);

	SysFreeString(bstrMsg);
}

void __stdcall OnDisconnect( BSTR bstrData,int nErrorCode)
{
	CString strData(bstrData);
	CString strMessage;
	strMessage.Format(_T("OnDisconnect :%s code %d"),strData,nErrorCode);

	BSTR bstrMsg = strMessage.AllocSysString();
	
	SendMessage(FindWindow(NULL,_T("ReplyTester")),WM_DATA,1,(int)bstrMsg);

	SysFreeString(bstrMsg);
}

void __stdcall OnComplete(int nCode)
{
	CString strMessage;
	strMessage.Format(_T("OnComplete  code %d"),nCode);

	BSTR bstrMsg = strMessage.AllocSysString();
	
	SendMessage(FindWindow(NULL,_T("ReplyTester")),WM_DATA,1,(int)bstrMsg);

	SysFreeString(bstrMsg);
}


void CReplyTester64Dlg::OnBnClickedButton1()
{
	// TODO: Add your control notification handler code here
	int nCode;

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_EDIT_ID); 
	CString strText;
	pEdit->GetWindowTextW(strText);

	pEdit = (CEdit*) GetDlgItem(IDC_EDIT_PASS); 
	CString strPassword;
	pEdit->GetWindowTextW(strPassword);

	nCode = SKReplyLib_Initialize((CStringA)strText,(CStringA)strPassword);

	if(nCode == 0)
	{
		RegisterOnConnectCallBack((UINT_PTR)OnConnect);
		RegisterOnDisconnectCallBack((UINT_PTR)OnDisconnect);
		RegisterOnDataCallBack((UINT_PTR)OnData);
		RegisterOnCompleteCallBack((UINT_PTR)OnComplete);
		
		AfxMessageBox(_T("Initialize SUCESS"));
	}
}

LRESULT CReplyTester64Dlg::OnReplyData(WPARAM wParam,LPARAM lParam)
{
	BSTR bstrData = (BSTR)lParam;

	CListBox   *pListBox   =   (CListBox *)GetDlgItem(IDC_LIST); 

	if( wParam == 0 )
	{
		TData Data;
		ZeroMemory(&Data,sizeof(TData));

		CStringA straData(bstrData);
		memcpy( &Data, straData.GetBuffer( straData.GetLength()), sizeof(TData));

		CString strMsg;

		strMsg.Format(_T("序號：%s 市場別：%s 委託類型：%s 帳號：%s  子帳號：%s ...")
			,CString(Data.caKeyNo,13)
			,CString(Data.caMarketType,2)
			,CString(Data.cType,1)
			,CString(Data.caCustNo,7)
			,CString(Data.caSubID,7)
			);

		pListBox->InsertString(0,strMsg);
	}
	else
	{
		CString strMsg(bstrData);
		pListBox->InsertString(0,strMsg);
	}

	//SysFreeString(bstrData);

	return 0;
}

void CReplyTester64Dlg::OnBnClickedButton2()
{
	// TODO: Add your control notification handler code here

	int nCode;

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_EDIT_ID); 
	CString strText;
	pEdit->GetWindowTextW(strText);

	SKReplyLib_ConnectByID((CStringA)strText);
}


void CReplyTester64Dlg::OnBnClickedButton3()
{
	// TODO: Add your control notification handler code here
	int nCode;

	CEdit* pEdit; 
    pEdit = (CEdit*) GetDlgItem(IDC_EDIT_ID); 
	CString strText;
	pEdit->GetWindowTextW(strText);

	SKReplyLib_CloseByID((CStringA)strText);
}
