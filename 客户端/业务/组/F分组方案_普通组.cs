using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI.设备.终端设备;

namespace UI.设备
{
    [ToolboxItem(false)]
    public partial class F分组方案_普通组 : UserControl
    {
        public F分组方案_普通组()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //this.do批量添加.Click += do批量添加_Click;
        }

        void do批量添加_Click(object sender, EventArgs e)
        {
        }
    }
}
