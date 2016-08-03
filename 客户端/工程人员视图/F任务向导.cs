using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UI.工程人员视图
{
    public partial class F任务向导 : UserControl
    {
        public F任务向导()
        {
            InitializeComponent();
            this.do开局_基站.Click += do开局_基站_Click;
        }

        void do开局_基站_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("打开文档,并打开相应工具的文件夹");
        }
    }
}
