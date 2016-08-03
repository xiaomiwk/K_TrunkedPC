using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using UI.公共;
using UI.基础.辅助;
using UI.调度.短信;
using UI.调度.通话;

namespace UI.调度.视频
{
    [ToolboxItem(false)]
    public partial class F视频 : DevExpress.XtraEditors.XtraUserControl
    {
        public F视频()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.in资源.部门菜单 = this.out部门菜单;
            this.in资源.关注菜单 = this.out关注菜单;
            this.in资源.基站菜单 = this.out基站菜单;
            this.in资源.环境菜单 = this.out环境菜单;
            this.in资源.添加关注组中成员();
            this.in资源.删除临时组号();
            //this.in资源.允许拖动();

            this.do关注_呼叫.Click += do呼叫_Click;
            this.do关注_合并呼叫.Click += do关注_合并呼叫_Click;
            this.do关注_高级呼叫.Click += do高级呼叫_Click;
            this.do关注_发送短信.Click += do发送短信_Click;
            this.do关注_合并发送短信.Click += do关注_合并发送短信_Click;
            this.do关注_查看成员.Click += do查看成员_Click;
            this.do关注_查看通话记录.Click += do查看通话记录_Click;
            this.do关注_查看详细信息.Click += do关注_查看详细信息_Click;
            this.do关注_设置布局_1.Click += do关注_设置布局_1_Click;
            this.do关注_设置布局_6.Click += do关注_设置布局_6_Click;
            this.do关注_设置布局_9.Click += do关注_设置布局_9_Click;
            this.do关注_配置视频参数.Click += do配置视频参数_Click;
            this.do关注_查看录像.Click += do查看录像_Click;

            this.do部门_呼叫.Click += do呼叫_Click;
            this.do部门_合并呼叫.Click += do部门_合并呼叫_Click;
            this.do部门_高级呼叫.Click += do高级呼叫_Click;
            this.do部门_发送短信.Click += do发送短信_Click;
            this.do部门_合并发送短信.Click += do部门_合并发送短信_Click;
            this.do部门_查看成员.Click += do查看成员_Click;
            this.do部门_查看通话记录.Click += do查看通话记录_Click;
            this.do部门_查看详细信息.Click += do部门_查看详细信息_Click;

            this.do主界面_设置布局_1.Click += do关注_设置布局_1_Click;
            this.do主界面_设置布局_6.Click += do关注_设置布局_6_Click;
            this.do主界面_设置布局_9.Click += do关注_设置布局_9_Click;
            this.do主界面_查看录像.Click += do查看录像_Click;
            this.do主界面_配置视频参数.Click += do配置视频参数_Click;
            this.do环境_查看录像.Click += do查看录像_Click;
            this.do环境_详细信息.Click += do环境_详细信息_Click;

            var __摄像头显示列表 = new List<PictureEdit>()
                {
                    this.pictureEdit1,
                    this.pictureEdit2,
                    this.pictureEdit3,
                    this.pictureEdit4,
                    this.pictureEdit5,
                    this.pictureEdit6,
                    this.pictureEdit7,
                    this.pictureEdit8,
                    this.pictureEdit9
                };
            __摄像头显示列表.ForEach(q =>
                {
                    q.DragEnter += H拖动操作.号码输入框_DragEnter;
                    q.DoubleClick += 摄像头_DoubleClick;
                    //q.MouseMove += 摄像头_MouseMove;
                    //q.MouseDown += 摄像头_MouseDown;
                });
        }

        private PictureEdit _摄像头;

        void 摄像头_MouseDown(object sender, MouseEventArgs e)
        {
            var __摄像头 = this.GetChildAtPoint(e.Location) as PictureEdit;
            if (__摄像头 == null)
            {
                return;
            }
            _摄像头 = __摄像头;
        }

        void 摄像头_MouseMove(object sender, MouseEventArgs e)
        {
            var __摄像头 = this.GetChildAtPoint(e.Location) as PictureEdit;
            if (__摄像头 == null || __摄像头 == _摄像头)
            {
                return;
            }

            _摄像头.DoDragDrop("", DragDropEffects.Copy);
        }

        void 摄像头_DoubleClick(object sender, EventArgs e)
        {
            弹出窗口(new F视频_控制摄像头());
        }

        #region 列表操作
        void do呼叫_Click(object sender, EventArgs e)
        {
            弹出窗口(new F通话_通话列表());
        }

        void do高级呼叫_Click(object sender, EventArgs e)
        {
            弹出窗口(new F高级呼叫());
        }

        void do关注_合并呼叫_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F通话_合并呼叫();
            弹出窗口(__弹出窗口);

            var __当前选择列表 = this.in资源.查询当前选择();
            this.in资源.开启选择多个();
            this.in资源.增加选择 += __弹出窗口.添加号码;
            this.in资源.删除选择 += __弹出窗口.删除号码;
            __弹出窗口.FormClosed += (sender1, e1) =>
            {
                this.in资源.关闭选择多个(true);
                this.in资源.设置选择(__当前选择列表);
            };
        }

        void do部门_合并呼叫_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F通话_合并呼叫();
            弹出窗口(__弹出窗口);

            this.in资源.开启选择多个();
            this.in资源.增加选择 += __弹出窗口.添加号码;
            this.in资源.删除选择 += __弹出窗口.删除号码;
            __弹出窗口.FormClosed += (sender1, e1) => this.in资源.关闭选择多个();
        }

        void do发送短信_Click(object sender, EventArgs e)
        {
            弹出窗口(new F短信_发送短信_弹出窗口());
        }

        void do关注_合并发送短信_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F短信_合并发送短信_弹出窗口();
            弹出窗口(__弹出窗口);

            var __当前选择列表 = this.in资源.查询当前选择();
            this.in资源.开启选择多个();
            this.in资源.增加选择 += __弹出窗口.添加号码;
            this.in资源.删除选择 += __弹出窗口.删除号码;
            __弹出窗口.FormClosed += (sender1, e1) =>
            {
                this.in资源.关闭选择多个(true);
                this.in资源.设置选择(__当前选择列表);
            };
        }

        void do部门_合并发送短信_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F短信_合并发送短信_弹出窗口();
            弹出窗口(__弹出窗口);

            this.in资源.开启选择多个();
            this.in资源.增加选择 += __弹出窗口.添加号码;
            this.in资源.删除选择 += __弹出窗口.删除号码;
            __弹出窗口.FormClosed += (sender1, e1) => this.in资源.关闭选择多个();
        }

        void do查看成员_Click(object sender, EventArgs e)
        {
            弹出窗口(new F组成员());
        }

        void do查看通话记录_Click(object sender, EventArgs e)
        {
            弹出窗口(new F通话_通话记录());
        }

        void do关注_查看详细信息_Click(object sender, EventArgs e)
        {
            弹出窗口(new F视频_详细信息());
        }

        void do部门_查看详细信息_Click(object sender, EventArgs e)
        {
            弹出窗口(new F视频_详细信息());
        }

        void do关注_设置布局_1_Click(object sender, EventArgs e)
        {
            初始化布局();
            this.tableLayoutPanel1.SetColumnSpan(this.pictureEdit1, 4);
            this.tableLayoutPanel1.SetRowSpan(this.pictureEdit1, 3);
            this.pictureEdit2.Visible = false;
            this.pictureEdit3.Visible = false;
            this.pictureEdit4.Visible = false;
            this.pictureEdit5.Visible = false;
            this.pictureEdit6.Visible = false;
            this.pictureEdit7.Visible = false;
            this.pictureEdit8.Visible = false;
            this.pictureEdit9.Visible = false;
            this.tableLayoutPanel1.Refresh();
        }

        void do关注_设置布局_6_Click(object sender, EventArgs e)
        {
            初始化布局();
            this.tableLayoutPanel1.SetColumnSpan(this.pictureEdit2, 2);
            this.tableLayoutPanel1.SetRowSpan(this.pictureEdit2, 2);
            this.pictureEdit7.Visible = false;
            this.pictureEdit8.Visible = false;
            this.pictureEdit9.Visible = false;
            this.tableLayoutPanel1.Refresh();

        }

        void do关注_设置布局_9_Click(object sender, EventArgs e)
        {
            初始化布局();
            this.tableLayoutPanel1.Refresh();
        }

        private void 初始化布局()
        {
            this.pictureEdit1.Visible = true;
            this.pictureEdit2.Visible = true;
            this.pictureEdit3.Visible = true;
            this.pictureEdit4.Visible = true;
            this.pictureEdit5.Visible = true;
            this.pictureEdit6.Visible = true;
            this.pictureEdit7.Visible = true;
            this.pictureEdit8.Visible = true;
            this.pictureEdit9.Visible = true;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureEdit1, 2);
            this.tableLayoutPanel1.SetRowSpan(this.pictureEdit1, 2);
            this.tableLayoutPanel1.SetColumnSpan(this.pictureEdit2, 1);
            this.tableLayoutPanel1.SetRowSpan(this.pictureEdit2, 1);
        }

        void do配置视频参数_Click(object sender, EventArgs e)
        {
            弹出窗口(new F视频_视频参数());
        }

        void do查看录像_Click(object sender, EventArgs e)
        {
            弹出窗口(new F视频_录像());
        }

        void do环境_详细信息_Click(object sender, EventArgs e)
        {
            弹出窗口(new F视频_详细信息());
        }

        #endregion



        private void 弹出窗口(XtraForm __窗口)
        {
            __窗口.TopMost = true;
            __窗口.StartPosition = FormStartPosition.Manual;
            var __窗口位置 = this.tableLayoutPanel1.PointToScreen(new Point((this.tableLayoutPanel1.Width - __窗口.Width) / 2, (this.tableLayoutPanel1.Height - __窗口.Height) / 2));
            __窗口.Location = __窗口位置;
            __窗口.Show();
        }

        private void 弹出窗口(XtraForm __窗口, Point __位置)
        {
            __窗口.TopMost = true;
            __窗口.StartPosition = FormStartPosition.Manual;
            var __窗口位置 = __位置;
            __窗口.Location = __窗口位置;
            __窗口.Show();
        }
    }
}
