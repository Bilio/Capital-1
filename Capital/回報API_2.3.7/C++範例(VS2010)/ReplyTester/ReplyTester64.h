
// ReplyTester64.h : PROJECT_NAME 應用程式的主要標頭檔
//

#pragma once

#define WM_DATA WM_USER+1

#ifndef __AFXWIN_H__
	#error "對 PCH 包含此檔案前先包含 'stdafx.h'"
#endif

#include "resource.h"		// 主要符號


// CReplyTester64App:
// 請參閱實作此類別的 ReplyTester64.cpp
//

class CReplyTester64App : public CWinApp
{
public:
	CReplyTester64App();

// 覆寫
public:
	virtual BOOL InitInstance();

// 程式碼實作

	DECLARE_MESSAGE_MAP()
};

extern CReplyTester64App theApp;