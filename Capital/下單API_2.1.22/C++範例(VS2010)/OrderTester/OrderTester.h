
// OrderTester.h : main header file for the PROJECT_NAME application
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// COrderTesterApp:
// See OrderTester.cpp for the implementation of this class
//

class COrderTesterApp : public CWinApp
{
public:
	COrderTesterApp();
// Overrides
public:
	virtual BOOL InitInstance();

// Implementation

	DECLARE_MESSAGE_MAP()
};

extern COrderTesterApp theApp;