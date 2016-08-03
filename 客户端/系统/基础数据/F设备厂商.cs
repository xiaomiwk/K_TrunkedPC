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
    public partial class F设备厂商 : UserControl
    {
        public F设备厂商()
        {
            InitializeComponent();
            this.treeList1.ExpandAll();
        }
    }
}
