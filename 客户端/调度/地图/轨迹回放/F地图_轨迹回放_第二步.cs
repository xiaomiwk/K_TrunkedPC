using System;
using UI.基础;

namespace UI.调度.地图.轨迹回放
{
    public partial class F地图_轨迹回放_第二步 : F覆盖控件
    {
        public F地图_轨迹回放_第二步()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置属性
            this.comboBoxEdit1.SelectedIndex = 0;

            this.刷新();

            //订阅事件
            this.do关闭.Click += do关闭_Click;
        }

        void do关闭_Click(object sender, EventArgs e)
        {
            this.隐藏();
        }

        public void 刷新()
        {

        }

    }
}
