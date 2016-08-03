using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.业务.状态
{
    [ToolboxItem(false)]
    public partial class F用户状态 : UserControl
    {
        public F用户状态()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.gridView1.DoubleClick += gridView1_DoubleClick;
        }

        void gridView1_DoubleClick(object sender, EventArgs e)
        {
            new F用户状态_详细信息(){ StartPosition = FormStartPosition.CenterParent }.ShowDialog();
        }

    }
}
