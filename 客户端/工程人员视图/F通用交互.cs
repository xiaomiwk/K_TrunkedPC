using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.工程人员视图
{
    public partial class F通用交互 : UserControl
    {
        public F通用交互()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.out导航.ExpandAll();
            this.out导航.MouseDoubleClick += treeList2_MouseDoubleClick;

            this.do显示设备输出.Click += do显示设备输出_Click;
        }

        void do显示设备输出_Click(object sender, EventArgs e)
        {
            new F设备输出().Show();
        }

        void treeList2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = (this.xtraTabControl1.SelectedTabPageIndex == 0 ? 1 : 0);
        }
    }
}
