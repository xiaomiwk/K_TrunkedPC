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
    public partial class F语音 : UserControl
    {
        public F语音()
        {
            InitializeComponent();
            if (!Program.概念版)
            {
                this.xtraTabControl1.TabPages.RemoveAt(this.xtraTabControl1.TabPages.Count - 1);
            }
        }
    }
}
