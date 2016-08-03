using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI.业务.状态;

namespace UI.业务.状态
{
    [ToolboxItem(false)]
    public partial class F信道监控 : UserControl
    {
        public F信道监控()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.treeList1.ExpandAll();
            this.out基站名称.DoubleClick += out基站名称_DoubleClick;
        }

        void out基站名称_DoubleClick(object sender, EventArgs e)
        {
            new F状态概览_基站(){ StartPosition = FormStartPosition.CenterParent }.ShowDialog();
        }

    }
}
