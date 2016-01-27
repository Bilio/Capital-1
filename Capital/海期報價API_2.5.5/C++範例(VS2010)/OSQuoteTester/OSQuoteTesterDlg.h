
// OSQuoteTesterDlg.h : 標頭檔
//

#pragma once


#define WM_UPDATE WM_USER+1
#define WM_TICKS WM_USER+2
#define WM_BEST5 WM_USER+3
#define WM_DATA WM_USER+4

// COSQuoteTesterDlg 對話方塊
class COSQuoteTesterDlg : public CDialogEx
{
	
private:
	int		m_nQueryType;
	short	m_sTickDecimal;
	int		m_nDenominator;

// 建構
public:
	COSQuoteTesterDlg(CWnd* pParent = NULL);	// 標準建構函式

	CString ParsePrice(int nPrice,short sDecimal ,int nDenominator );

// 對話方塊資料
	enum { IDD = IDD_OSQUOTETESTER_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 支援


// 程式碼實作
protected:
	HICON m_hIcon;

	// 產生的訊息對應函式
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg LRESULT OnQuoteUpdate(WPARAM wParam,LPARAM lParam);
	afx_msg LRESULT OnTicks(WPARAM wParam,LPARAM lParam);
	afx_msg LRESULT OnBest5(WPARAM wParam,LPARAM lParam);
	afx_msg LRESULT OnData(WPARAM wParam,LPARAM lParam);
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedLogin();
	afx_msg void OnBnClickedButton1();
	afx_msg void OnBnClickedCleardata();
	afx_msg void OnBnClickedTicksButton();
	afx_msg void OnBnClickedButton4();
	afx_msg void OnBnClickedButton5();
	afx_msg void OnBnClickedButton2();
	afx_msg void OnTimer(UINT_PTR nIDEvent);
	afx_msg void OnBnClickedButton3();
};
