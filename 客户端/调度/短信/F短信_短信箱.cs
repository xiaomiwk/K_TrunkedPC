using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using UI.基础.辅助;
using Utility.WindowsForm;

namespace UI.调度.短信
{
    [ToolboxItem(false)]
    public partial class F短信_短信箱 : XtraUserControl
    {
        private static readonly string _类型名 = typeof(F短信_短信箱).Name;

        private Dictionary<string, RepositoryItem> _操作缓存 = new Dictionary<string, RepositoryItem>();

        private H查询框 _H查询框;

        public F短信_短信箱()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置属性
            H设置样式.设置基本样式(this.out列表);
            H设置样式.设置基本样式(this.out列表容器.EmbeddedNavigator);
            //H设置样式.设置操作列基本样式(this.out操作列1, this.out操作列2, this.out操作列3, this.out操作列4);
            H设置样式.设置操作列基本样式(this.out操作列3, this.out操作列4);
            this._H查询框 = new H查询框(this.in查询条件, this.out列表);
            this.刷新();
            
            //订阅事件
            this.out列表.DoubleClick += out列表_DoubleClick;
        }

        void out列表_DoubleClick(object sender, EventArgs e)
        {
            var __弹出窗口 = new F短信_短信箱_打开短信();
            this.out辅助容器.创建局部覆盖控件(__弹出窗口, q => 刷新());
        }

        void 刷新()
        {
            //var __位置 = this.out列表.FocusedRowHandle;
            //this.out列表容器.DataSource = __绑定;
            ////this.out列表.BestFitColumns();
            //this.out列表.FocusedRowHandle = __位置;
            //this.out列表容器.DataSource = new List<M绑定对象> { new M绑定对象
            //    {
            //           位置 = "位置", 对方号码 = "对方号码", 内容 = "内容", 时间 = DateTime.Now
            //    }};
        }

        private class M绑定对象
        {
            public string 位置 { get; set; }

            public DateTime 时间 { get;set; }

            public string 对方号码 { get; set; }

            public string 内容 { get; set; }
        }

    }
}
