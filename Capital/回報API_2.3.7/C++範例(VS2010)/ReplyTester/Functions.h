#ifndef _FunctionH_
#define _FunctionH_

#define DLLImport _declspec(dllimport)


struct DataItem
{
   char caKeyNo[13];
   char caMarketType[2];                   // TS TA TL TF TO
   char cType;                             // N(new) C(cancel) U(update) D(deal) Q(quote)
   char cOrderErr;                         // Y N
   char caBroker[7];                       // TS,TA,TL is unit_no, TF,TO is broker
   char caCustNo[7];
   char caBuySell[3];                      // �Ҩ� B/S  0/2   0/1/2/3/4  ���v B/S  0/N/O 0/R/I/F
   char caExchangeID[7];                   // �����
   char caComId[20];                       // �e13�X�ӫ~�N�� �@�Ӫť� �᤻�X�ӫ~�~��
   char caStrikePrice[13];                 // �i���� �C����
   char caOrderNo[5];
   char caPrice[13];                       // �Ҩ���p��, ���f�T��p��,  �K���Ƥ���p��
                                           // �e�U�G9999999999999�������A��l���e�U��  ����G�����
   char caNumerator[5];                    // ���l�A3���ơA2��p��
   char caDenominator[4];                  // ���� 4����
   char caPrice1[13];                      // �K���Ƥ���p�� �e�U�GĲ�o��  ����G0000000000000
   char caNumerator1[5];                   // ���l �T���ƤG��p��
   char caDenominator1[4];                 // ���� �|����
   char caPrice2[13];                      // �K���Ƥ���p�� �e�U�G0000000000000  ����G0000000000000
   char caNumerator2[5];                   // ���l �T���ƤG��p��
   char caDenominator2[4];                 // ���� �|����

   char caQty[8];                          // �Ѽ�
   char caBeforeQty[4];
   char caAfterQty[4];
   char caDate[8];
   char caTime[6];
   char caOkSeq[8];                        // ����Ǹ�
   char caSubID[7];
   char caSaleNo[4];
   char cAgent;
};

typedef struct DataItem TData;

DLLImport int __stdcall SKReplyLib_Initialize( const char* lpszUserName, const char* lpszPassword);
DLLImport int __stdcall SKReplyLib_ConnectByID( const char* lpszUserId);
DLLImport int __stdcall SKReplyLib_CloseByID( const char* lpszUserID);
DLLImport int __stdcall SKReplyLib_IsConnectedByID( const char* lpszUserID);


DLLImport int __stdcall RegisterOnConnectCallBack( UINT_PTR  lCallBackFunction);
DLLImport int __stdcall RegisterOnDisconnectCallBack( UINT_PTR  lCallBackFunction);
DLLImport int __stdcall RegisterOnDataCallBack( UINT_PTR lCallBackFunction);
DLLImport int __stdcall RegisterOnCompleteCallBack( UINT_PTR lCallBackFunction);


#endif

