using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UI.基础
{
    public partial class F提示 : UserControl
    {
        public F提示()
        {
            InitializeComponent();
        }

        public string 内容
        {
            get { return this.out提示内容.Text; }
            set { this.out提示内容.Text = value; }
        }

        public Image 图标
        {
            get { return this.out提示图片.Image; }
            set { this.out提示图片.Image = value; }
        }

        public LabelControl 内容控件
        {
            get { return this.out提示内容; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.辅助容器.Appearance.BackColor = Color.FromArgb(255, 255, 225);
            this.辅助容器.Appearance.Options.UseBackColor = true;
            this.out提示图片.BackColor = Color.FromArgb(255, 255, 225);
        }
    }
}
