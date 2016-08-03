using System;

namespace UI.调度.短信
{
    public partial class F短信_发送短信_弹出窗口 : DevExpress.XtraEditors.XtraForm
    {
        public F短信_发送短信_弹出窗口()
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
            this.Close();
        }

    }
}