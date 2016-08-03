using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using UI;
using UI.公共;
using UI.基础.通知;
using UI.调度.短信;

namespace UI.调度.通话
{
    [ToolboxItem(false)]
    public partial class F通话 : DevExpress.XtraEditors.XtraUserControl
    {
        public F通话()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.out容器.ItemClick += out容器_ItemClick;
            //this.out容器.ItemDoubleClick += out容器_ItemDoubleClick;
            this.out容器.DoubleClick += out容器_DoubleClick;
            this.do关注_呼叫.Click += do呼叫_Click;
            this.do关注_合并呼叫.Click += do关注_合并呼叫_Click;
            this.do关注_高级呼叫.Click += do高级呼叫_Click;
            this.do关注_发送短信.Click += do发送短信_Click;
            this.do关注_合并发送短信.Click += do关注_合并发送短信_Click;
            this.do关注_查看成员.Click += do查看成员_Click;
            this.do关注_查看通话记录.Click += do查看通话记录_Click;
            this.do关注_查看详细信息.Click += do关注_查看详细信息_Click;
            this.do关注_定位.Click += do定位_Click;

            this.do部门_呼叫.Click += do呼叫_Click;
            this.do部门_合并呼叫.Click += do部门_合并呼叫_Click;
            this.do部门_高级呼叫.Click += do高级呼叫_Click;
            this.do部门_发送短信.Click += do发送短信_Click;
            this.do部门_合并发送短信.Click += do部门_合并发送短信_Click;
            this.do部门_查看成员.Click += do查看成员_Click;
            this.do部门_查看通话记录.Click += do查看通话记录_Click;
            this.do部门_查看详细信息.Click += do部门_查看详细信息_Click;
            this.do部门_定位.Click += do定位_Click;
        }

        void out容器_DoubleClick(object sender, EventArgs e)
        {
            弹出窗口(new F弹出通知(), this.out容器.PointToScreen(new Point(0, 0)));
        }

        void out容器_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            弹出窗口(new F弹出通知(), this.out容器.PointToScreen(new Point(0, 0)));
        }

        void out容器_ItemClick(object sender, TileItemEventArgs e)
        {
            //var __通话列表窗口 = new F通话列表();
            //弹出窗口(new F通话列表(), this.tileControl1.PointToScreen(new Point(0, this.tileControl1.Height - __通话列表窗口.Height)));
            弹出窗口(new F通话_通话列表());
        }

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

            this.out容器.ItemCheckMode = TileItemCheckMode.Multiple;
            this.out容器.ContextMenuStrip = null;
            TileItemClickEventHandler __多选 = (sender1, e1) =>
            {
                if (e1.Item.Checked)
                {
                    __弹出窗口.添加号码(e1.Item.Text);
                }
                else
                {
                    __弹出窗口.删除号码(e1.Item.Text);
                }
            };
            __弹出窗口.FormClosed += (sender1, e1) =>
            {
                this.out容器.ItemCheckMode = TileItemCheckMode.None;
                this.out容器.ContextMenuStrip = this.out关注菜单;
                this.out容器.ItemCheckedChanged -= __多选;
            };
            this.out容器.ItemCheckedChanged += __多选;
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
            this.out容器.ItemCheckMode = TileItemCheckMode.Multiple;
            this.out容器.ContextMenuStrip = null;
            TileItemClickEventHandler __多选 = (sender1, e1) =>
            {
                if (e1.Item.Checked)
                {
                    __弹出窗口.添加号码(e1.Item.Text);
                }
                else
                {
                    __弹出窗口.删除号码(e1.Item.Text);
                }
            };
            __弹出窗口.FormClosed += (sender1, e1) =>
            {
                this.out容器.ItemCheckMode = TileItemCheckMode.None;
                this.out容器.ContextMenuStrip = this.out关注菜单;
                this.out容器.ItemCheckedChanged -= __多选;
            };
            this.out容器.ItemCheckedChanged += __多选;
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
            弹出窗口(new F号码详细信息());
        }

        void do部门_查看详细信息_Click(object sender, EventArgs e)
        {
            弹出窗口(new F号码详细信息());
        }

        void do定位_Click(object sender, EventArgs e)
        {
            Program.主窗口.打开内容("实时定位");
        }

        private void 弹出窗口(XtraForm __窗口)
        {
            __窗口.TopMost = true;
            __窗口.StartPosition = FormStartPosition.Manual;
            var __窗口位置 = this.out容器.PointToScreen(new Point((this.out容器.Width - __窗口.Width) / 2, (this.out容器.Height - __窗口.Height) / 2));
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
