using System;
using System.ComponentModel;
using System.Windows.Forms;
using Utility.WindowsForm;

namespace UI.调度.地图.轨迹回放
{
    [ToolboxItem(false)]
    public partial class F地图_轨迹回放 : DevExpress.XtraEditors.XtraUserControl
    {
        public F地图_轨迹回放()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.do下一步.Click += do下一步_Click;
        }

        void do下一步_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F地图_轨迹回放_第二步();
            this.创建全覆盖控件(__弹出窗口, q =>
            {
            });
        }
    }
}
