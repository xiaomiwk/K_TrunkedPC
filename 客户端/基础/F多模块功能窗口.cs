using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UI.基础
{
    //[ToolboxItem(false)]
    public partial class F多模块功能窗口 : XtraUserControl
    {
        private readonly List<XtraUserControl> _所有模块 = new List<XtraUserControl>();

        public F多模块功能窗口()
        {
            InitializeComponent();
            this.out子功能列表.Items.Clear();
            this.out子功能列表.SelectedIndexChanged += this.out子功能列表_SelectedIndexChanged;
        }

        public void 增加子功能(string __名称, XtraUserControl __控件)
        {
            this._所有模块.Add(__控件);
            this.out子功能列表.Items.Add(__名称);
            __控件.Dock = DockStyle.Fill;
            __控件.BackColor = Color.Transparent;
            this.out辅助容器.Controls.Add(__控件);
        }

        public void 激活子功能(string __名称)
        {
            this.out子功能列表.SelectedItem = __名称;
        }

        private void out子功能列表_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._所有模块[this.out子功能列表.SelectedIndex].BringToFront();
        }
    }
}
