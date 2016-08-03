using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UI.工程人员视图
{
    public partial class F工程人员视图 : XtraForm
    {
        public F工程人员视图()
        {
            InitializeComponent();
            //this.out数据.out导航.ClearNodes();
            //this.out数据.out导航.AppendNode(new object[] { "话单" }, -1);
            //this.out数据.out导航.AppendNode(new object[] { "录音" }, -1);
            //this.out数据.out导航.AppendNode(new object[] { "GIS" }, -1);
            //this.out数据.out导航.AppendNode(new object[] { "勤务" }, -1);

            this.out业务.out导航.ClearNodes();
            this.out业务.out导航.AppendNode(new object[] { "号码方案" }, -1);
            this.out业务.out导航.AppendNode(new object[] { "呼叫" }, -1);
            this.out业务.out导航.AppendNode(new object[] { "定时器" }, 1);
            this.out业务.out导航.AppendNode(new object[] { "GIS" }, -1);
            this.out业务.out导航.AppendNode(new object[] { "短信" }, -1);

        }
    }
}
