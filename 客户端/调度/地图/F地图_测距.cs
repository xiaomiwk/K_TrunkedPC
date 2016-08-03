using System;
using System.ComponentModel;
using DTO.调度.地图;

namespace UI.调度.地图
{
    public partial class F地图_测距 : DevExpress.XtraEditors.XtraForm
    {
        private F地图_实时定位 _地图;

        public F地图_测距(F地图_实时定位 __地图)
        {
            InitializeComponent();
            _地图 = __地图;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _地图.地图请求 += _地图_地图请求;
            this.do重置.Click += do重置_Click;
            this.do重置.PerformClick();
        }

        void do重置_Click(object sender, EventArgs e)
        {
            _地图.设置地图操作模式(E地图操作方式.移动地图);
            _地图.设置地图操作模式(E地图操作方式.测距);
            _地图.文档.InvokeScript("删除测距线");
            this.out第一步.Visible = false;
            this.out第二步.Visible = false;
            this.out距离.Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _地图.文档.InvokeScript("删除测距线");
            _地图.设置地图操作模式(E地图操作方式.移动地图);
        }

        void _地图_地图请求(string __事件名称, string __事件参数)
        {
            if (__事件名称 != "测距")
            {
                return;
            }
            if (__事件参数 == "第一步")
            {
                this.out第一步.Visible = true;
            }
            else
            {
                var __距离 = double.Parse(__事件参数);
                this.out第二步.Visible = true;
                this.out距离.Visible = true;
                this.out距离.Text = string.Format("{0} 米", Math.Round(__距离));
            }
        }
    }
}