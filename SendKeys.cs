using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace KeySender
{
    public class SendHandler
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        const uint WM_KEYDOWN = 0x100;
        const uint WM_KEYUP = 0x101;
        const uint Key_Down = 0x0001;
        const uint Key_Up = 0x0002;
        private volatile bool shouldStop;
        private IntPtr hWnd;
        private Keys key;

        public SendHandler(IntPtr hWindow, Keys keyToSend)
        {
            hWnd = hWindow;
            key = keyToSend;
        }

        public void runKeysender()
        {
            SendKey(hWnd, key);
        }

        public void SendKey(IntPtr hWnd, Keys key) 
        {
            while (!shouldStop) 
            {
                Thread.Sleep(50);
                PostMessage(hWnd, WM_KEYDOWN, (IntPtr)(key), (IntPtr)(0));
                PostMessage(hWnd, WM_KEYUP, (IntPtr)(key), (IntPtr)(0));
                Thread.Sleep(50);
            }
        }

        public void SendModifiedKey(IntPtr hWnd, Keys key, byte ModKey)
        {
            while (!shouldStop)
            {
                keybd_event(ModKey, 0, Key_Down, 0);
                Thread.Sleep(50);
                PostMessage(hWnd, WM_KEYDOWN, (IntPtr)(key), (IntPtr)(0));
                PostMessage(hWnd, WM_KEYUP, (IntPtr)(key), (IntPtr)(0));
                Thread.Sleep(50);
                keybd_event(ModKey, 0, Key_Up, 0);
            }
        }

        public void StopSending()
        {
            shouldStop = true;
        }
        ~SendHandler()
        {
            GC.Collect();
        }
    }
}