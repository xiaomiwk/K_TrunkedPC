using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using UI.基础.辅助;

namespace UI.公共
{
    public partial class F号码详细信息 : DevExpress.XtraEditors.XtraForm
    {
        public F号码详细信息()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置属性
            H设置样式.设置基本样式(this.out列表);
            H设置样式.设置基本样式(this.out列表容器.EmbeddedNavigator);
            H设置样式.设置基本样式(this.out列表2);
            H设置样式.设置基本样式(this.out列表容器2.EmbeddedNavigator);
            H设置样式.设置基本样式(this.out列表3);
            H设置样式.设置基本样式(this.out列表容器3.EmbeddedNavigator);
            //H设置样式.设置操作列基本样式(this.out操作列1, this.out操作列2, this.out操作列3);
            this.in视图.SelectedIndex = 0;

            this.刷新();

            //订阅事件
        }

        public void 刷新()
        {

        }

    }
}