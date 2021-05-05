using System;
using System.Runtime.InteropServices;

namespace AppWebView
{
    public class ControlBoxMenu
    {
        public const Int32 WM_SYSCOMMAND = 0x112;
        public const Int32 MF_BYPOSITION = 0x400;

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern bool InsertMenu(IntPtr hMenu, Int32 wPosition, Int32 wFlags, Int32 wIDNewItem, string lpNewItem);

        public static void InsertMenu(IntPtr hWnd, int menuId, string label)
        {
            IntPtr MenuHandle = GetSystemMenu(hWnd, false);
            InsertMenu(MenuHandle, 5, MF_BYPOSITION, menuId, label);
        }
    }
}
