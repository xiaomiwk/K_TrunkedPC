using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UI.����
{
    public partial class F��ʾ : UserControl
    {
        public F��ʾ()
        {
            InitializeComponent();
        }

        public string ����
        {
            get { return this.out��ʾ����.Text; }
            set { this.out��ʾ����.Text = value; }
        }

        public Image ͼ��
        {
            get { return this.out��ʾͼƬ.Image; }
            set { this.out��ʾͼƬ.Image = value; }
        }

        public LabelControl ���ݿؼ�
        {
            get { return this.out��ʾ����; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.��������.Appearance.BackColor = Color.FromArgb(255, 255, 225);
            this.��������.Appearance.Options.UseBackColor = true;
            this.out��ʾͼƬ.BackColor = Color.FromArgb(255, 255, 225);
        }
    }
}
