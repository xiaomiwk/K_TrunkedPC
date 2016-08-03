using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using UI.业务.状态;

namespace UI.业务
{
    [ToolboxItem(false)]
    public partial class F用户分布 : UserControl
    {
        public F用户分布()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.do地图概览.Click += do地图概览_Click;
        }

        void do地图概览_Click(object sender, EventArgs e)
        {
            new F用户分布_地图() { StartPosition = FormStartPosition.CenterParent }.ShowDialog();
        }

    }
}
