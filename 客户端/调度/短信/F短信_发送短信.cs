using System;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace UI.调度.短信
{
    [ToolboxItem(false)]
    public partial class F短信_发送短信 : XtraUserControl
    {
        private static readonly string _类型名 = typeof(F短信_发送短信).Name;


        public F短信_发送短信()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置属性
            this.in短信内容.Properties.MaxLength = 300;
            this.in号码.Properties.MaxLength = 200;

            //订阅事件
            this.do选择成员.Click += do选择成员_Click;
            this.in号码.AllowDrop = true;
        }

        void do选择成员_Click(object sender, EventArgs e)
        {
        }

    }
}
