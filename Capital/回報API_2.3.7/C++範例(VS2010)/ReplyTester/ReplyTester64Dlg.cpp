
// ReplyTester64Dlg.cpp : ��@��
//

#include "stdafx.h"
#include "ReplyTester64.h"
#include "ReplyTester64Dlg.h"
#include "afxdialogex.h"
#include "Functions.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CReplyTester64Dlg ��ܤ��

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


// CReplyTester64Dlg �T���B�z�`��

BOOL CReplyTester64Dlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// �]�w����ܤ�����ϥܡC�����ε{�����D�������O��ܤ���ɡA
	// �ج[�|�۰ʱq�Ʀ��@�~
	SetIcon(m_hIcon, TRUE);			// �]�w�j�ϥ�
	SetIcon(m_hIcon, FALSE);		// �]�w�p�ϥ�

	// TODO: �b���[�J�B�~����l�]�w

	return TRUE;  // �Ǧ^ TRUE�A���D�z�ﱱ��]�w�J�I
}

// �p�G�N�̤p�ƫ��s�[�J�z����ܤ���A�z�ݭn�U�C���{���X�A
// �H�Kø�s�ϥܡC���ϥΤ��/�˵��Ҧ��� MFC ���ε{���A
// �ج[�|�۰ʧ������@�~�C

void CReplyTester64Dlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // ø�s���˸m���e

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// �N�ϥܸm����Τ�ݯx��
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// �yø�ϥ�
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// ��ϥΪ̩즲�̤p�Ƶ����ɡA
// �t�ΩI�s�o�ӥ\����o�����ܡC
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

		strMsg.Format(_T("�Ǹ��G%s �����O�G%s �e�U�����G%s �b���G%s  �l�b���G%s ...")
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
