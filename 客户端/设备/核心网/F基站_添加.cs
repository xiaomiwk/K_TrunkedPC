using DevExpress.XtraEditors;

namespace UI.设备.核心设备
{
    public partial class F基站_添加 : XtraForm
    {
        public F基站_添加()
        {
            InitializeComponent();
            this.do新增.Click += do新增_Click;
        }

        void do新增_Click(object sender, System.EventArgs e)
        {
            new F基站_添加_信道(){ StartPosition = System.Windows.Forms.FormStartPosition.CenterParent }.ShowDialog();
        }
    }
}
