using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.设备.互联接口
{
    [ToolboxItem(false)]
    public partial class F外部基站_列表 : UserControl
    {
        public F外部基站_列表()
        {
            InitializeComponent();
            this.do添加基站.Click += do添加基站_Click;
        }

        void do添加基站_Click(object sender, EventArgs e)
        {
            new F外部基站_添加() {StartPosition = FormStartPosition.CenterParent}.ShowDialog();
        }
    }
}
