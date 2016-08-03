using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using UI.基础.辅助;

namespace UI.基础.通知
{
    public partial class F通知记录 : DevExpress.XtraEditors.XtraForm
    {
        private H查询框 _H查询框;

        public F通知记录()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置属性
            this.刷新();
            H设置样式.设置基本样式(this.out列表);
            H设置样式.设置基本样式(this.out列表容器.EmbeddedNavigator);
            this._H查询框 = new H查询框(this.in查询条件, this.out列表);
        }

        void 刷新()
        {
            //var __位置 = this.out列表.FocusedRowHandle;
            //this.out列表容器.DataSource = __绑定;
            //this.out列表.FocusedRowHandle = __位置;
        }
    }
}