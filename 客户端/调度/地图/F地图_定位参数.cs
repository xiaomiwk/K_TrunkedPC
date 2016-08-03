using System;

namespace UI.调度.地图
{
    public partial class F地图_定位参数 : DevExpress.XtraEditors.XtraForm
    {
        public F地图_定位参数()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.comboBoxEdit2.SelectedIndex = 0;
        }
    }
}