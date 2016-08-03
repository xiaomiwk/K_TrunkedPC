using System;
using System.Collections.Generic;

namespace UI.调度.短信
{
    public partial class F短信_合并发送短信_弹出窗口 : DevExpress.XtraEditors.XtraForm
    {
        public F短信_合并发送短信_弹出窗口()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.do发送.Click += do发送_Click;
        }

        void do发送_Click(object sender, EventArgs e)
        {
            On开始执行(null);
            this.Close();
        }

        public event Action<List<string>> 开始执行;

        protected virtual void On开始执行(List<string> obj)
        {
            Action<List<string>> handler = 开始执行;
            if (handler != null) handler(obj);
        }

        public void 添加号码(string __号码)
        {
            this.listBoxControl1.Items.Add(__号码);
        }

        public void 删除号码(string __号码)
        {
            this.listBoxControl1.Items.Remove(__号码);
        }

    }
}