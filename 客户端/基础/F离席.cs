using System;
using System.ComponentModel;
using System.Windows.Forms;
using UI.基础.辅助;

namespace UI.基础
{
    public partial class F离席 : DevExpress.XtraEditors.XtraForm
    {
        private static readonly string _类型名 = typeof(F离席).Name;

        private readonly Timer _定时器 = new Timer();

        private TimeSpan _经历时间;

        private bool _重登录成功;

        public F离席()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置属性
            _定时器.Interval = 1000;
            _定时器.Enabled = true;
            _定时器.Start();
            _重登录成功 = false;
            this.in账号.Text = "admin";
            this.in密码.Focus();
            this.in账号.Enabled = false;

            //订阅事件
            _定时器.Tick += _定时器_Tick;
            this.do关闭程序.Click += do关闭程序_Click;
            this.do重新登录.Click += do重新登录_Click;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (_重登录成功)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (H弹出消息.显示("确定要关闭吗?", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Abort;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        void do重新登录_Click(object sender, EventArgs e)
        {
            //using (H调试.跟踪(_类型名 + ": do重新登录_Click"))
            //{
            //    var __账号 = this.in账号.Text.Trim();
            //    var __密码 = this.in密码.Text.Trim();
            //    _I用户鉴权.重登录(__账号, __密码);
                _重登录成功 = true;
                this.Close();
                //App.主窗口.记录操作日志(E功能.主界面, string.Format("{0}登录", __账号));
            //}
        }

        void do关闭程序_Click(object sender, EventArgs e)
        {
            //using (H调试.跟踪(_类型名 + ": do关闭程序_Click", "关闭程序"))
            //{
                this.Close();
            //}
        }

        void _定时器_Tick(object sender, EventArgs e)
        {
            _经历时间 = _经历时间.Add(new TimeSpan(0, 0, 0, 0, _定时器.Interval));
            this.out离席时间.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)_经历时间.TotalHours, _经历时间.Minutes, _经历时间.Seconds);
        }

    }
}
