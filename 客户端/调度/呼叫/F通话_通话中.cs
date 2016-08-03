using System;

namespace UI.调度.通话
{
    public partial class F通话_通话中 : DevExpress.XtraEditors.XtraUserControl
    {
        public F通话_通话中()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.do麦克风.Tag = "可用";
            this.do扬声器.Tag = "可用";
            this.do麦克风.Click += do麦克风_Click;
            this.do扬声器.Click += do扬声器_Click;
            this.do记录.Click += do记录_Click;
        }

        void do记录_Click(object sender, EventArgs e)
        {
            if (this.do记录.Text == "展开")
            {
                this.ParentForm.Height = 700;
                this.do记录.Text = "收缩";
            }
            else
            {
                this.ParentForm.Height = 400;
                this.do记录.Text = "展开";
            }
        }

        void do扬声器_Click(object sender, EventArgs e)
        {
            if ((string) this.do扬声器.Tag == "可用")
            {
                this.do扬声器.Image = UI.Properties.Resources.播放器禁用;
                this.do扬声器.Tag = "禁用";
            }
            else
            {
                this.do扬声器.Image = UI.Properties.Resources.播放器;
                this.do扬声器.Tag = "可用";
            }
        }

        void do麦克风_Click(object sender, EventArgs e)
        {
            if ((string) this.do麦克风.Tag == "可用")
            {
                this.do麦克风.Image = UI.Properties.Resources.麦克风禁用;
                this.do麦克风.Tag = "禁用";
            }
            else
            {
                this.do麦克风.Image = UI.Properties.Resources.麦克风;
                this.do麦克风.Tag = "可用";
            }
        }
    }
}
