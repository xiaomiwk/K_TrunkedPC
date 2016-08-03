using System;
using System.ComponentModel;
using UI.基础;

namespace UI.调度.短信
{
    [ToolboxItem(false)]
    public partial class F短信_短信箱_打开短信 : F覆盖控件
    {
        private static readonly string _类型名 = typeof(F短信_短信箱_打开短信).Name;

        public F短信_短信箱_打开短信()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //设置属性
            this.out回复内容.Visible = false;

            //绑定相关短信

            //订阅事件
            this.do返回.ButtonClick += do返回_Click;
            this.do回复.Click += do回复_Click;
            this.do呼叫.Click += do呼叫_Click;
            this.do关闭回复.ButtonClick += do关闭回复_Click;
        }

        void do关闭回复_Click(object sender, EventArgs e)
        {
            this.out回复内容.Visible = false;
            this.out列表容器.Height += 160;
            this.do回复.Text = "回复";
        }

        void do呼叫_Click(object sender, EventArgs e)
        {
            //获取输入;
            this.隐藏();
        }

        void do回复_Click(object sender, EventArgs e)
        {
            if (this.do回复.Text == "回复")
            {
                this.out列表容器.Height -= 160;
                this.out回复内容.Visible = true;
                this.do回复.Text = "发送";
                this.out回复内容.Focus();
            }
            else
            {
                //获取输入;
                var __回复内容 = this.in回复内容.Text.Trim();
                this.隐藏();
            }
        }

        void do返回_Click(object sender, EventArgs e)
        {
            this.隐藏();
        }
    }
}
