using System;
using System.Windows.Forms;
using UI.基础.辅助;
using Utility.WindowsForm;

namespace UI.调度.地图.轨迹回放
{
    public partial class F地图_轨迹回放_第一步 : DevExpress.XtraEditors.XtraUserControl
    {
        public F地图_轨迹回放_第一步()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置属性
            H设置样式.设置基本样式(this.out列表);
            H设置样式.设置基本样式(this.out列表容器.EmbeddedNavigator);
            //H设置样式.设置操作列基本样式(this.out操作列1);
            this.刷新();

            //订阅事件
            this.do下一步.Click += do下一步_Click;
        }

        void do下一步_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F地图_轨迹回放_第二步();
            this.out辅助容器.创建全覆盖控件(__弹出窗口, q =>
            {
            });
        }

        public void 刷新()
        {

        }

    }
}
