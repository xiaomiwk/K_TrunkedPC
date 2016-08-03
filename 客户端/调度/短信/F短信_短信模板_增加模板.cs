using System;
using System.ComponentModel;
using UI.基础;

namespace UI.调度.短信
{
    [ToolboxItem(false)]
    public partial class F短信_短信模板_增加模板 : F覆盖控件
    {
        private static readonly string _类型名 = typeof(F短信_短信模板_增加模板).Name;


        public bool 增加成功 { get; set; }

        public F短信_短信模板_增加模板()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置属性
            this.in内容.Properties.MaxLength = 100;
            this.in关键字.Properties.MaxLength = 30;

            //订阅事件
            this.do保存.Click += do保存_Click;
            this.do返回.ButtonClick += do返回_Click;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            this.in关键字.Focus();
        }

        void do返回_Click(object sender, EventArgs e)
        {
            this.隐藏();
        }

        void do保存_Click(object sender, EventArgs e)
        {
            this.隐藏();

        }
    }

}
