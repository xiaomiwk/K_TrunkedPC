using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UI.设备.核心设备
{
    [ToolboxItem(false)]
    public partial class F应用_列表 : UserControl
    {
        public F应用_列表()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.in应用服务.SelectedIndex = 0;
            this.do添加应用服务.Click += (sender1, e1) => this.添加设备(this.in应用服务.SelectedItem.ToString());
        }

        void 添加设备(string __设备类型)
        {
            switch (__设备类型)
            {
                case "媒体服务器":
                    new F应用_添加媒体服务器().ShowDialog();
                    break;
                default:
                    new F添加通用设备() { Text = string.Format("添加{0}", __设备类型) }.ShowDialog();
                    break;
            }
        }
    }
}
