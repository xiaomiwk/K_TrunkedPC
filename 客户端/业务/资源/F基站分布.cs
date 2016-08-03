using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.业务.资源配置
{
    [ToolboxItem(false)]
    public partial class F基站分布 : UserControl
    {
        public F基站分布()
        {
            InitializeComponent();
            this.treeList1.ExpandAll();
            this.do邻近基站.Click += do邻近基站_Click;
        }

        void do邻近基站_Click(object sender, EventArgs e)
        {
            new F基站分布_邻近基站(){ StartPosition = FormStartPosition.CenterParent }.ShowDialog();
        }
    }
}
