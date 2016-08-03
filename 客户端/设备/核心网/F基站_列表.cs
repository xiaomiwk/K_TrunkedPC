using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UI.设备.核心设备
{
    [ToolboxItem(false)]
    public partial class F基站_列表 : UserControl
    {
        public F基站_列表()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.do添加基站.Click += (sender1, e1) => this.添加设备("基站");
        }

        void 添加设备(string __设备类型)
        {
            switch (__设备类型)
            {
                case "基站":
                    new F基站_添加().ShowDialog();
                    break;
                default:
                    new F添加通用设备() { Text = string.Format("添加{0}", __设备类型) }.ShowDialog();
                    break;
            }
        }
    }
}
