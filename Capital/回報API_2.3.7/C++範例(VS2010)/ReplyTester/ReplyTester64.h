
// ReplyTester64.h : PROJECT_NAME ���ε{�����D�n���Y��
//

#pragma once

#define WM_DATA WM_USER+1

#ifndef __AFXWIN_H__
	#error "�� PCH �]�t���ɮ׫e���]�t 'stdafx.h'"
#endif

#include "resource.h"		// �D�n�Ÿ�


// CReplyTester64App:
// �аѾ\��@�����O�� ReplyTester64.cpp
//

class CReplyTester64App : public CWinApp
{
public:
	CReplyTester64App();

// �мg
public:
	virtual BOOL InitInstance();

// �{���X��@

	DECLARE_MESSAGE_MAP()
};

extern CReplyTester64App theApp;