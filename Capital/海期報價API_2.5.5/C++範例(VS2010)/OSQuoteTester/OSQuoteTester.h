
// OSQuoteTester.h : PROJECT_NAME ���ε{�����D�n���Y��
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�� PCH �]�t���ɮ׫e���]�t 'stdafx.h'"
#endif

#include "resource.h"		// �D�n�Ÿ�


// COSQuoteTesterApp:
// �аѾ\��@�����O�� OSQuoteTester.cpp
//

class COSQuoteTesterApp : public CWinApp
{
public:
	COSQuoteTesterApp();

// �мg
public:
	virtual BOOL InitInstance();

// �{���X��@

	DECLARE_MESSAGE_MAP()
};

extern COSQuoteTesterApp theApp;