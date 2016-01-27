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
   char caBuySell[3];                      // 靡ㄩ B/S  0/2   0/1/2/3/4  戳舦 B/S  0/N/O 0/R/I/F
   char caExchangeID[7];                   // ユ┮
   char caComId[20];                       // 玡13絏坝珇腹 フ せ絏坝珇る
   char caStrikePrice[13];                 // 糹基 俱计
   char caOrderNo[5];
   char caPrice[13];                       // 靡ㄩㄢ计, 戳砯计,  俱计き计
                                           // 〆癠9999999999999カ基ㄤ緇〆癠基  ΘユΘユ基
   char caNumerator[5];                    // だ3俱计2计
   char caDenominator[4];                  // だダ 4俱计
   char caPrice1[13];                      // 俱计き计 〆癠牟祇基  Θユ0000000000000
   char caNumerator1[5];                   // だ 俱计计
   char caDenominator1[4];                 // だダ 俱计
   char caPrice2[13];                      // 俱计き计 〆癠0000000000000  Θユ0000000000000
   char caNumerator2[5];                   // だ 俱计计
   char caDenominator2[4];                 // だダ 俱计

   char caQty[8];                          // 计
   char caBeforeQty[4];
   char caAfterQty[4];
   char caDate[8];
   char caTime[6];
   char caOkSeq[8];                        // Θユ腹
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

