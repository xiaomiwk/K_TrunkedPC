using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using UI.基础.辅助;
using Utility.WindowsForm;

namespace UI.调度.短信
{
    [ToolboxItem(false)]
    public partial class F短信_短信模板 : XtraUserControl
    {
        private static readonly string _类型名 = typeof(F短信_短信模板).Name;

        private H查询框 _H查询框;

        public F短信_短信模板()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置属性
            H设置样式.设置基本样式(this.out列表);
            H设置样式.设置基本样式(this.out列表容器.EmbeddedNavigator);
            H设置样式.设置操作列基本样式(this.out操作列1, this.out操作列2, this.out操作列3);
            this._H查询框 = new H查询框(this.in查询条件, this.out列表);
            this.刷新();

            //订阅事件
            this.do增加模板.Click += do增加模板_Click;
            this.out列表.DoubleClick += out列表_DoubleClick;
        }

        void do增加模板_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F短信_短信模板_增加模板();
            this.out辅助容器.创建局部覆盖控件(__弹出窗口, q =>
            {
                if (q.增加成功)
                {
                    刷新();
                }
            });
        }

        void out列表_DoubleClick(object sender, EventArgs e)
        {
            var __弹出窗口 = new F短信_短信模板_编辑模板();
            this.out辅助容器.创建局部覆盖控件(__弹出窗口, q => 刷新());
        }

        void 刷新()
        {
            //var __模糊查询 = this.in查询条件.Text.Trim();
            //var __绑定 = _I短信模板.查询(__模糊查询);
            //var __位置 = this.out列表.FocusedRowHandle;
            //this.out列表容器.DataSource = __绑定;
            ////this.out列表.BestFitColumns();
            //this.out列表.FocusedRowHandle = __位置;
        }

    }
}
