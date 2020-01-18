﻿namespace Dissonance.Framework.GLFW3
{
	public static partial class GLFW
	{
		public static LFWINIT Init;
		public static LFWTERMINATE Terminate;
		public static LFWGETVERSION GetVersion;
		public static LFWGETVERSIONSTRING GetVersionString;
		public static LFWSETERRORCALLBACK SetErrorCallback;
		public static LFWGETMONITORS GetMonitors;
		public static LFWGETPRIMARYMONITOR GetPrimaryMonitor;
		public static LFWGETMONITORPOS GetMonitorPos;
		public static LFWGETMONITORPHYSICALSIZE GetMonitorPhysicalSize;
		public static LFWGETMONITORNAME GetMonitorName;
		public static LFWSETMONITORCALLBACK SetMonitorCallback;
		public static LFWGETVIDEOMODES GetVideoModes;
		public static LFWGETVIDEOMODE GetVideoMode;
		public static LFWSETGAMMA SetGamma;
		public static LFWGETGAMMARAMP GetGammaRamp;
		public static LFWSETGAMMARAMP SetGammaRamp;
		public static LFWDEFAULTWINDOWHINTS DefaultWindowHints;
		public static LFWWINDOWHINT WindowHint;
		public static LFWCREATEWINDOW CreateWindow;
		public static LFWDESTROYWINDOW DestroyWindow;
		public static LFWWINDOWSHOULDCLOSE WindowShouldClose;
		public static LFWSETWINDOWSHOULDCLOSE SetWindowShouldClose;
		public static LFWSETWINDOWTITLE SetWindowTitle;
		public static LFWSETWINDOWICON SetWindowIcon;
		public static LFWGETWINDOWPOS GetWindowPos;
		public static LFWSETWINDOWPOS SetWindowPos;
		public static LFWGETWINDOWSIZE GetWindowSize;
		public static LFWSETWINDOWSIZELIMITS SetWindowSizeLimits;
		public static LFWSETWINDOWASPECTRATIO SetWindowAspectRatio;
		public static LFWSETWINDOWSIZE SetWindowSize;
		public static LFWGETFRAMEBUFFERSIZE GetFramebufferSize;
		public static LFWGETWINDOWFRAMESIZE GetWindowFrameSize;
		public static LFWICONIFYWINDOW IconifyWindow;
		public static LFWRESTOREWINDOW RestoreWindow;
		public static LFWMAXIMIZEWINDOW MaximizeWindow;
		public static LFWSHOWWINDOW ShowWindow;
		public static LFWHIDEWINDOW HideWindow;
		public static LFWFOCUSWINDOW FocusWindow;
		public static LFWGETWINDOWMONITOR GetWindowMonitor;
		public static LFWSETWINDOWMONITOR SetWindowMonitor;
		public static LFWGETWINDOWATTRIB GetWindowAttrib;
		public static LFWSETWINDOWUSERPOINTER SetWindowUserPointer;
		public static LFWGETWINDOWUSERPOINTER GetWindowUserPointer;
		public static LFWSETWINDOWPOSCALLBACK SetWindowPosCallback;
		public static LFWSETWINDOWSIZECALLBACK SetWindowSizeCallback;
		public static LFWSETWINDOWCLOSECALLBACK SetWindowCloseCallback;
		public static LFWSETWINDOWREFRESHCALLBACK SetWindowRefreshCallback;
		public static LFWSETWINDOWFOCUSCALLBACK SetWindowFocusCallback;
		public static LFWSETWINDOWICONIFYCALLBACK SetWindowIconifyCallback;
		public static LFWSETFRAMEBUFFERSIZECALLBACK SetFramebufferSizeCallback;
		public static LFWPOLLEVENTS PollEvents;
		public static LFWWAITEVENTS WaitEvents;
		public static LFWWAITEVENTSTIMEOUT WaitEventsTimeout;
		public static LFWPOSTEMPTYEVENT PostEmptyEvent;
		public static LFWGETINPUTMODE GetInputMode;
		public static LFWSETINPUTMODE SetInputMode;
		public static LFWGETKEYNAME GetKeyName;
		public static LFWGETKEY GetKey;
		public static LFWGETMOUSEBUTTON GetMouseButton;
		public static LFWGETCURSORPOS GetCursorPos;
		public static LFWSETCURSORPOS SetCursorPos;
		public static LFWCREATECURSOR CreateCursor;
		public static LFWCREATESTANDARDCURSOR CreateStandardCursor;
		public static LFWDESTROYCURSOR DestroyCursor;
		public static LFWSETCURSOR SetCursor;
		public static LFWSETKEYCALLBACK SetKeyCallback;
		public static LFWSETCHARCALLBACK SetCharCallback;
		public static LFWSETCHARMODSCALLBACK SetCharModsCallback;
		public static LFWSETMOUSEBUTTONCALLBACK SetMouseButtonCallback;
		public static LFWSETCURSORPOSCALLBACK SetCursorPosCallback;
		public static LFWSETCURSORENTERCALLBACK SetCursorEnterCallback;
		public static LFWSETSCROLLCALLBACK SetScrollCallback;
		public static LFWSETDROPCALLBACK SetDropCallback;
		public static LFWJOYSTICKPRESENT JoystickPresent;
		public static LFWGETJOYSTICKAXES GetJoystickAxes;
		public static LFWGETJOYSTICKBUTTONS GetJoystickButtons;
		public static LFWGETJOYSTICKNAME GetJoystickName;
		public static LFWSETJOYSTICKCALLBACK SetJoystickCallback;
		public static LFWSETCLIPBOARDSTRING SetClipboardString;
		public static LFWGETCLIPBOARDSTRING GetClipboardString;
		public static LFWGETTIME GetTime;
		public static LFWSETTIME SetTime;
		public static LFWGETTIMERVALUE GetTimerValue;
		public static LFWGETTIMERFREQUENCY GetTimerFrequency;
		public static LFWMAKECONTEXTCURRENT MakeContextCurrent;
		public static LFWGETCURRENTCONTEXT GetCurrentContext;
		public static LFWSWAPBUFFERS SwapBuffers;
		public static LFWSWAPINTERVAL SwapInterval;
		public static LFWEXTENSIONSUPPORTED ExtensionSupported;
		public static LFWGETADDRESS GetProcAddress;
		public static LFWVULKANSUPPORTED VulkanSupported;
		public static LFWGETREQUIREDINSTANCEEXTENSIONS GetRequiredInstanceExtensions;
	}
}
