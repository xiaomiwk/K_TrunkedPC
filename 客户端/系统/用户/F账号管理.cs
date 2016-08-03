using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.系统
{
    [ToolboxItem(false)]
    public partial class F账号管理 : UserControl
    {
        public F账号管理()
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
