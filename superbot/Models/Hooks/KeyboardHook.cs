using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static superbot.Models.Hooks.HookFunctions;

namespace superbot.Models.Hooks
{
    class KeyboardHook
    {
        private static event KeyEventHandler _KeyDown;
        private static event KeyEventHandler _KeyUp;
        private static event KeyEventHandler _KeyPress;

        public static event KeyEventHandler KeyDown
        {
            add
            {
                _KeyDown += value;
                EnsureSubscribedToGlobalKeyboardEvents();
            }
            remove
            {
                _KeyDown -= value;
                TryUnsubscribeFromGlobalKeyboardEvents();
            }
        }
        public static event KeyEventHandler KeyPress
        {
            add
            {
                _KeyPress += value;
                EnsureSubscribedToGlobalKeyboardEvents();
            }
            remove
            {
                _KeyPress -= value;
                TryUnsubscribeFromGlobalKeyboardEvents();
            }
        }
        public static event KeyEventHandler KeyUp
        {
            add
            {
                _KeyUp += value;
                EnsureSubscribedToGlobalKeyboardEvents();
            }
            remove
            {
                _KeyUp -= value;
                TryUnsubscribeFromGlobalKeyboardEvents();
            }
        }

        public static class Charakters
        {
            public const int WH_KEYBOARD_LL = 13;
            public const int WM_KEYDOWN = 0x100;
            public const int WM_KEYUP = 0x101;
            public const int WM_SYSKEYDOWN = 0x104;
            public const int WH_KEYBOARD = 2;
            public const int WM_SYSKEYUP = 0x105;

            public const byte VK_SHIFT = 0x10;
            public const byte VK_CAPITAL = 0x14;
            public const byte VK_NUMLOCK = 0x90;
        }

        private static int HandleKeyboardHookID;
        private static HookProc HookProcDelegate;
        private static Dictionary<int, bool> kliknieteKlawisze = new Dictionary<int, bool>();

        private static int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            bool handled = false;

            if (nCode >= 0)
            {
                KeyboardHookStruct MyKeyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
                Keys keyData = (Keys)MyKeyboardHookStruct.VirtualKeyCode;
                KeyEventArgs e = new KeyEventArgs(keyData);

                //raise KeyDown
                if (wParam == Charakters.WM_KEYDOWN || wParam == Charakters.WM_SYSKEYDOWN)
                {
                    _KeyPress?.Invoke(null, e); // tak czy siak keypress sie wykona

                    bool czyOdpalicEvent = false;
                    if (!kliknieteKlawisze.ContainsKey(e.KeyValue))
                    {
                        kliknieteKlawisze.Add(e.KeyValue, true);
                        czyOdpalicEvent = true;
                    }
                    else
                    {
                        if (kliknieteKlawisze[e.KeyValue] == false)
                        {
                            kliknieteKlawisze[e.KeyValue] = true;
                            czyOdpalicEvent = true;
                        }
                    }
                    if (czyOdpalicEvent)
                    {
                        if (_KeyDown != null)
                        {
                            _KeyDown.Invoke(null, e);
                            handled = e.Handled;
                        }
                    }
                }

                // raise KeyUp
                if (wParam == Charakters.WM_KEYUP || wParam == Charakters.WM_SYSKEYUP)
                {
                    bool czyOdpalicEvent = false;
                    if (!kliknieteKlawisze.ContainsKey(e.KeyValue))
                    {
                        kliknieteKlawisze.Add(e.KeyValue, false);
                        czyOdpalicEvent = true;
                    }
                    else
                    {
                        if (kliknieteKlawisze[e.KeyValue] == true)
                        {
                            kliknieteKlawisze[e.KeyValue] = false;
                            czyOdpalicEvent = true;
                        }
                    }
                    if (czyOdpalicEvent)
                    {
                        if (_KeyUp != null)
                        {
                            _KeyUp.Invoke(null, e);
                            handled = e.Handled;
                        }
                    }
                }
            }
            if (handled)
                return -1;

            return CallNextHookEx(HandleKeyboardHookID, nCode, wParam, lParam);
        }


        private static void EnsureSubscribedToGlobalKeyboardEvents()
        {
            if (HandleKeyboardHookID == 0)
            {
                HookProcDelegate = KeyboardHookProc;
                HandleKeyboardHookID = SetWindowsHookEx(Charakters.WH_KEYBOARD_LL, HookProcDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
                if (HandleKeyboardHookID == 0)
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Win32Exception(errorCode);
                }
            }
        }

        private static void TryUnsubscribeFromGlobalKeyboardEvents()
        {
            if (_KeyDown == null &&
                _KeyUp == null &&
                _KeyPress == null)
            {
                ForceUnsunscribeFromGlobalKeyboardEvents();
            }
        }

        private static void ForceUnsunscribeFromGlobalKeyboardEvents()
        {
            if (HandleKeyboardHookID != 0)
            {
                kliknieteKlawisze.Clear();
                int result = UnhookWindowsHookEx(HandleKeyboardHookID);
                HookProcDelegate = null;
                HandleKeyboardHookID = 0;

                if (result == 0)
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Win32Exception(errorCode);
                }
            }
        }
    }
}
