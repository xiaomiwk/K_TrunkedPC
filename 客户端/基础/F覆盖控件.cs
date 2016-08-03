using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Utility.WindowsForm;

namespace UI.基础
{
    [ToolboxItem(false)]
    public class F覆盖控件 : XtraUserControl, I覆盖控件
    {
        public void 隐藏()
        {
            触发已隐藏();
            已隐藏 = null;
        }

        public event Action 已隐藏;

        protected void 触发已隐藏()
        {
            Action handler = 已隐藏;
            if (handler != null) handler();
        }
    }
}
