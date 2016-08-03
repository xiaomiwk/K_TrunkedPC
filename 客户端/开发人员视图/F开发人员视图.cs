using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UI.开发人员视图
{
    public partial class F开发人员视图 : XtraForm
    {
        public F开发人员视图()
        {
            InitializeComponent();

            this.out业务.out导航.ClearNodes();
            this.out业务.out导航.AppendNode(new object[] { "号码方案" }, -1);
            this.out业务.out导航.AppendNode(new object[] { "呼叫" }, -1);
            //this.out业务.out导航.AppendNode(new object[] { "定时器" }, 1);
            this.out业务.out导航.AppendNode(new object[] { "GIS" }, -1);
            this.out业务.out导航.AppendNode(new object[] { "短信" }, -1);

        }
    }
}
