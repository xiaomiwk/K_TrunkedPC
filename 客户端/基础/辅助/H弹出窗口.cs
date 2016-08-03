using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UI.基础
{
    class H弹出窗口
    {
        public static void 显示(XtraForm __窗口, Control __父窗口)
        {
            __窗口.TopMost = true;
            __窗口.StartPosition = FormStartPosition.Manual;
            var __窗口位置 = __父窗口.PointToScreen(new Point((__父窗口.Width - __窗口.Width) / 2, (__父窗口.Height - __窗口.Height) / 2));
            __窗口.Location = __窗口位置;
            __窗口.Show();
        }

        public static void 弹出窗口(XtraForm __窗口, Point __位置)
        {
            __窗口.TopMost = true;
            __窗口.StartPosition = FormStartPosition.Manual;
            var __窗口位置 = __位置;
            __窗口.Location = __窗口位置;
            __窗口.Show();
        }

    }
}
