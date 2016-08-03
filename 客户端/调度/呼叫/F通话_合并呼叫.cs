using System;
using System.Collections.Generic;

namespace UI.调度.通话
{
    public partial class F通话_合并呼叫 : DevExpress.XtraEditors.XtraForm
    {
        public event Action<List<string>> 开始执行;

        protected virtual void On开始呼叫(List<string> obj)
        {
            Action<List<string>> handler = 开始执行;
            if (handler != null) handler(obj);
        }

        public F通话_合并呼叫()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.do呼叫.Click += do呼叫_Click;
        }

        void do呼叫_Click(object sender, EventArgs e)
        {
            On开始呼叫(null);
            this.Close();
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