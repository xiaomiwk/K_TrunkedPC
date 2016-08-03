using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using UI.基础.外观设置;
using UI.基础.辅助;
using Utility.存储;

namespace UI
{
    static class Program
    {
        public static F主窗口 主窗口;

        public static bool 概念版 = true;

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]                                            
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();                                    
            SkinManager.EnableFormSkins();
            H外观设置.单一实例.皮肤名称 = H程序配置.获取字符串("界面样式");

            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");     
            //UserLookAndFeel.Default.SetSkinStyle("Metropolis");
            //UserLookAndFeel.Default.SetSkinStyle("Office 2013 White");
            //UserLookAndFeel.Default.SetSkinStyle("Office 2013 Light Gray");

            DevExpress.Utils.AppearanceObject.DefaultFont = new System.Drawing.Font("微软雅黑", 9F);
            主窗口 = new F主窗口();
            Application.Run(主窗口);
        }
    }
}
