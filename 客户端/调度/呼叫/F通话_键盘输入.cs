using System;
using DevExpress.XtraEditors;

namespace UI.调度.通话
{
    public partial class F通话_键盘输入 : DevExpress.XtraEditors.XtraUserControl
    {
        public F通话_键盘输入()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.do0.Click += 拨号盘_Click;
            this.do1.Click += 拨号盘_Click;
            this.do2.Click += 拨号盘_Click;
            this.do3.Click += 拨号盘_Click;
            this.do4.Click += 拨号盘_Click;
            this.do5.Click += 拨号盘_Click;
            this.do6.Click += 拨号盘_Click;
            this.do7.Click += 拨号盘_Click;
            this.do8.Click += 拨号盘_Click;
            this.do9.Click += 拨号盘_Click;
            this.do星号.Click += 拨号盘_Click;
            this.do井号.Click += 拨号盘_Click;
            this.do后退.Click += 后退_Click;
            this.doR.Click += 重拨_Click;
            this.in号码.Properties.ButtonClick += delegate { this.in号码.Text = string.Empty; };

        }

        void 拨号盘_Click(object sender, EventArgs e)
        {
            var __btn = sender as SimpleButton;
            this.in号码.Text += __btn.Text;
        }

        void 后退_Click(object sender, EventArgs e)
        {
            if (this.in号码.Text.Length > 0)
            {
                this.in号码.Text = this.in号码.Text.Substring(0, this.in号码.Text.Length - 1);
            }
        }

        void 重拨_Click(object sender, EventArgs e)
        {
        }

    }
}
