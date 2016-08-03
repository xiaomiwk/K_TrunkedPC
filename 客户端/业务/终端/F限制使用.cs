using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UI.设备.终端设备
{
    [ToolboxItem(false)]
    public partial class F限制使用 : UserControl
    {
        public F限制使用()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.do批量添加.Click += do批量添加_Click;
        }

        void do批量添加_Click(object sender, EventArgs e)
        {
            new F移动台_批量添加().ShowDialog();
        }
    }
}
