﻿using System;
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
    public partial class F通知方式 : UserControl
    {
        public F通知方式()
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
