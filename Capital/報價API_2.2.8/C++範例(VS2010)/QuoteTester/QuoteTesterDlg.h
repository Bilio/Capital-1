
// QuoteTesterDlg.h : 標頭檔
//

#pragma once

#define WM_DATA WM_USER+1

// CQuoteTesterDlg 對話方塊
class CQuoteTesterDlg : public CDialogEx
{
// 建構
public:
	CQuoteTesterDlg(CWnd* pParent = NULL);	// 標準建構函式
	~CQuoteTesterDlg();

// 對話方塊資料
	enum { IDD = IDD_QUOTETESTER_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 支援


// 程式碼實作
protected:
	HICON m_hIcon;

	// 產生的訊息對應函式
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedButton1();
	afx_msg void OnBnClickedButton2();
	
	afx_msg LRESULT OnData(WPARAM wParam,LPARAM lParam);

	afx_msg void OnBnClickedButton3();
	afx_msg void OnBnClickedButton4();
	afx_msg void OnBnClickedButton5();
	afx_msg void OnBnClickedButton6();
	afx_msg void OnBnClickedButton8();
	afx_msg void OnBnClickedButton9();
	afx_msg void OnBnClickedButton10();
	afx_msg void OnBnClickedButton7();
	afx_msg void OnBnClickedButton11();
	afx_msg void OnBnClickedButton12();
};
