using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.业务
{
    [ToolboxItem(false)]
    public partial class F设备监控 : UserControl
    {
        public F设备监控()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.treeList1.ExpandAll();
        }
    }
}
