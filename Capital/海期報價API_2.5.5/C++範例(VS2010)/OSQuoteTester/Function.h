#ifndef _FunctionH_
#define _FunctionH_

#define DLLImport _declspec(dllimport)

#define SK_SUCCESS								0
#define SK_FAIL									-1
#define SK_ERROR_STRING_LENGTH_NOT_ENOUGH		-2
#define SK_ERROR_SERVER_NOT_CONNECTED			-3
#define SK_ERROR_INITIALIZE_FAIL				-4
#define SK_ERROR_ACCOUNT_NOT_EXIST				1
#define SK_ERROR_ACCOUNT_MARKET_NOT_MATCH		2
#define SK_ERROR_PERIOD_OUT_OF_RANGE			3
#define SK_ERROR_FLAG_OUT_OF_RANGE				4
#define SK_ERROR_BUYSELL_OUT_OF_RANGE			5
#define SK_ERROR_ORDER_SERVER_INVALID			6
#define SK_ERROR_PERMISSION_DENIED				7
#define SK_KLINE_DATA_TYPE_NOT_FOUND			8
#define SK_ERROR_PERMISSION_TIMEOUT			    9

#define SK_SUBJECT_CONNECTION_CONNECTED			100
#define SK_SUBJECT_CONNECTION_DISCONNECT		101
#define SK_SUBJECT_QUOTE_PAGE_EXCEED			200
#define SK_SUBJECT_QUOTE_PAGE_INCORRECT			201
#define SK_SUBJECT_TICK_PAGE_EXCEED				210
#define SK_SUBJECT_TICK_PAGE_INCORRECT			211
#define SK_SUBJECT_TICK_STOCK_NOT_FOUND			212
#define SK_SUBJECT_BEST5_DATA_NOT_FOUND			213
#define SK_SUBJECT_QUOTEREQUEST_NOT_FOUND		214
#define SK_SUBJECT_SERVER_TIME_NOT_FOUND		215

#define SK_WARNING_LOGIN_ALREADY				2003




struct FOREIGN
{
	short	m_sStockidx;			// �t�Φۦ�w�q���Ѳ��N�X
	short	m_sDecimal;				// �����p�Ʀ��
	int 	m_nDenominator;			// ����

	char	m_cMarketNo;			//�����N�X
	char	m_caExchangeNo[20];		//����ҥN��
	char	m_caExchangeName[20];	//����ҦW��
	char	m_caStockNo[20];		//�Ѳ��N��
	char	m_caStockName[20];		//�Ѳ��W��

	int		m_nOpen;				//�}�L��
	int		m_nHigh;				//�̰���
	int		m_nLow;					//�̧C��
	int		m_nClose;				//�����
	int		m_nSettlePrice;         //�����
	int		m_nTickQty;				//��q
	int		m_nRef;					//�Q���B�Ѧһ�

	int		m_nBid;					// �R��
	int		m_nBc;					// �R�q
	int		m_nAsk;					// ���
	int		m_nAc;					// ��q

	int		m_nTQty;				//����q

};
typedef FOREIGN TForeign;


struct TICK
{
	int		m_nPtr;			//Index
	int		m_nTime;		//�ɶ�
	int		m_nClose;		//�����
	int		m_nQty;			//����q
};

typedef TICK TTick;

typedef struct BEST5
{
	int m_nBid1;
	int m_nBidQty1;
	int m_nBid2;
	int m_nBidQty2;
	int m_nBid3;
	int m_nBidQty3;
	int m_nBid4;
	int m_nBidQty4;
	int m_nBid5;
	int m_nBidQty5;

	int m_nAsk1;
	int m_nAskQty1;
	int m_nAsk2;
	int m_nAskQty2;
	int m_nAsk3;
	int m_nAskQty3;
	int m_nAsk4;
	int m_nAskQty4;
	int m_nAsk5;
	int m_nAskQty5;

} TBest5;

DLLImport int __stdcall SKOSQuoteLib_Initialize(const char* lpszUserName,const char* lpszPassword);
DLLImport int __stdcall SKOSQuoteLib_EnterMonitor(short nConnectType);
DLLImport int __stdcall SKOSQuoteLib_RequestStocks(short* psPageNo, char* pStockNos);
DLLImport int __stdcall SKOSQuoteLib_GetStockByIndex (short sStockidx, TForeign* pStock);
DLLImport int __stdcall SKOSQuoteLib_RequestTicks (short* psPageNo,char* pStockNo);
DLLImport int __stdcall SKOSQuoteLib_RequestKData (short* psPageNo,char* pStockNo);
DLLImport int __stdcall SKOSQuoteLib_GetTick( short sStockidx, int nPtr,TTick* pTick);
DLLImport int __stdcall SKOSQuoteLib_GetBest5( short sStockidx, TBest5* pBest5);
DLLImport int __stdcall SKOSQuoteLib_RequestKLine ( char* pStock, short KLineType);
DLLImport int __stdcall SKOSQuoteLib_RequestOverseaProducts();
DLLImport int __stdcall SKOSQuoteLib_LeaveMonitor();
DLLImport int __stdcall SKOSQuoteLib_RequestServerTime();

 
DLLImport int __stdcall SKOSQuoteLib_AttachConnectCallBack( UINT_PTR lCallBackFunction);
DLLImport int __stdcall SKOSQuoteLib_AttachQuoteCallBack( UINT_PTR lCallBack);
DLLImport int __stdcall SKOSQuoteLib_AttachTicksCallBack (UINT_PTR lCallBack);
DLLImport int __stdcall SKOSQuoteLib_AttachBest5CallBack (UINT_PTR lCallBack);
DLLImport int __stdcall SKOSQuoteLib_AttachKLineDataCallBack (UINT_PTR lCallBack);
DLLImport int __stdcall SKOSQuoteLib_AttachOverseaProductsCallBack(UINT_PTR lCallBack);
DLLImport int __stdcall SKOSQuoteLib_AttachHistoryTicksGetCallBack(UINT_PTR lCallBack);
DLLImport int __stdcall SKOSQuoteLib_AttachKDataCallBack(UINT_PTR lCallBack);


#endif