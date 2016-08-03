using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraNavBar;
using UI.Properties;
using UI.基础;
using UI.基础.辅助;
using UI.基础.通知;

namespace UI
{
    public partial class F主窗口 : XtraForm
    {
        private readonly List<M一级菜单> _一级菜单列表;

        private readonly Dictionary<M一级菜单, NavBarControl> _二级菜单容器 = new Dictionary<M一级菜单, NavBarControl>();

        private readonly List<M三级菜单> _三级菜单列表 = new List<M三级菜单>();

        private readonly Dictionary<M三级菜单, Document> _已打开内容 = new Dictionary<M三级菜单, Document>();

        public F主窗口()
        {
            InitializeComponent();

            _一级菜单列表 = H系统菜单.一级功能列表;
            _一级菜单列表.ForEach(m => m.子菜单.ForEach(n => _三级菜单列表.AddRange(n.子菜单)));

            //初始化一级菜单
            var __列表1 = new List<BarItem>();
            var __列表2 = new List<LinkPersistInfo>();
            var __Logo = new BarStaticItem
            {
                Border = BorderStyles.NoBorder,
                Glyph = Resources.logo,
                PaintStyle = BarItemPaintStyle.CaptionInMenu,
                TextAlignment = StringAlignment.Near,
            };
            __Logo.ItemClick += (m, n) => this.打开内容("状态概览");

            __列表1.Add(__Logo);
            __列表2.Add(new LinkPersistInfo(__Logo));
            var __一级菜单按钮列表 = new List<BarButtonItem>();
            _一级菜单列表.ForEach(q =>
            {
                var __一级菜单按钮 = new BarButtonItem { Caption = " " + q.名称 + "  ", Glyph = q.图片 };
                if (q.名称.StartsWith("系统"))
                {
                    __一级菜单按钮.Alignment = BarItemLinkAlignment.Right;
                }
                __一级菜单按钮.ItemClick += (m, n) => 加载导航(q);
                __一级菜单按钮列表.Add(__一级菜单按钮);
                __列表1.Add(__一级菜单按钮);
                __列表2.Add(new LinkPersistInfo(BarLinkUserDefines.PaintStyle, __一级菜单按钮, BarItemPaintStyle.CaptionGlyph));

                var __二级菜单导航 = 创建导航(_一级菜单列表.Find(k => k.名称 == q.名称).子菜单);
                _二级菜单容器[q] = __二级菜单导航;
                out主体.Panel1.Controls.Add(__二级菜单导航);
            });
            __一级菜单按钮列表.ForEach(q =>
            {
                q.ItemClick += (m, n) =>
                {
                    __一级菜单按钮列表.ForEach(k => k.ItemAppearance.Normal.ForeColor = Color.White);
                    q.ItemAppearance.Normal.ForeColor = Color.Yellow;
                };
            });

            //var __通知菜单按钮 = new BarButtonItem
            //{
            //    Alignment = BarItemLinkAlignment.Right,
            //    Caption = "概览",
            //    PaintStyle = BarItemPaintStyle.CaptionGlyph,
            //    Glyph = Properties.Resources.短信
            //};
            ////__通知菜单按钮.ItemClick += (m, n) => H弹出窗口.显示(new F通知记录(), this);
            //__通知菜单按钮.ItemClick += (m, n) => this.打开内容("状态概览");
            //__列表1.Add(__通知菜单按钮);
            //__列表2.Add(new LinkPersistInfo(__通知菜单按钮));


            outBar管理器.Items.AddRange(__列表1.ToArray());
            out菜单栏.LinksPersistInfo.AddRange(__列表2.ToArray());
            out菜单栏容器.Appearance.BackColor = Color.FromArgb(22, 62, 98);
            out菜单栏.BarItemVertIndent = 15;
            out菜单栏.BarItemHorzIndent = 10;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            outTab视图.QueryControl += outTab视图_QueryControl;
            outTab视图.DocumentClosing += outTab视图_DocumentClosing;
            //outTab视图.DocumentActivated += outTab视图_DocumentActivated;
            //outTab视图.DocumentAdded += outTab视图_DocumentAdded;

            //设置默认一级菜单
            var __默认一级菜单 = "运营状态";
            BarItem __bar = null;
            foreach (BarItem __item in outBar管理器.Items)
            {
                if (__item.Caption.Contains(__默认一级菜单))
                {
                    __bar = __item;
                    __item.PerformClick();
                    break;
                }
            }
            if (__bar == null)
            {
                outBar管理器.Items[1].PerformClick();
            }

            //设置默认三级菜单
            var __默认三级菜单 = "状态概览";
            打开内容(__默认三级菜单);

        }

        private NavBarControl 创建导航(List<M二级菜单> __菜单列表)
        {
            var __二级菜单 = new NavBarControl
            {
                ActiveGroup = null,
                Dock = DockStyle.Fill,
                Location = new Point(3, 5),
                Margin = new Padding(3, 5, 3, 5)
            };
            __二级菜单.Appearance.GroupHeader.Font = new Font("微软雅黑", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            __二级菜单.Appearance.GroupHeader.Options.UseFont = true;
            __二级菜单.Appearance.GroupHeaderActive.Font = new Font("微软雅黑", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            __二级菜单.Appearance.GroupHeaderActive.Options.UseFont = true;
            __二级菜单.Appearance.Item.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            __二级菜单.Appearance.Item.Options.UseFont = true;
            __二级菜单.Appearance.ItemActive.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            __二级菜单.Appearance.ItemActive.Options.UseFont = true;
            __二级菜单.Appearance.ItemHotTracked.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            __二级菜单.Appearance.ItemHotTracked.Options.UseFont = true;
            __二级菜单.Appearance.ItemPressed.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            __二级菜单.Appearance.ItemPressed.Options.UseFont = true;

            __菜单列表.ForEach(q =>
            {
                var __组 = new NavBarGroup
                {
                    Caption = string.IsNullOrEmpty(q.描述) ? q.名称 : q.描述,
                    Name = q.名称,
                    Expanded = true, 
                };
                __二级菜单.Groups.Add(__组);
                q.子菜单.ForEach(k =>
                {
                    var __菜单控件 = new NavBarItem
                    {
                        Caption = k.名称,
                        Name = k.名称
                    };
                    __菜单控件.LinkClicked += (sender, e) => 打开内容(k);
                    __组.ItemLinks.Add(new NavBarItemLink(__菜单控件));
                    __二级菜单.Items.Add(__菜单控件);
                });
            });
            return __二级菜单;
        }

        private void 加载导航(M一级菜单 __一级菜单)
        {
            for (int i = 0; i < out主体.Panel1.Controls.Count; i++)
            {
                out主体.Panel1.Controls[i].Visible = _二级菜单容器[__一级菜单] == out主体.Panel1.Controls[i];
            }
        }

        public void 打开内容(string __三级菜单名称, string __二级菜单名称 = null, string __一级菜单名称 = null)
        {
            var __三级菜单 = 查找三级菜单(__三级菜单名称, __二级菜单名称, __一级菜单名称);
            if (__三级菜单 != null)
            {
                打开内容(__三级菜单);
            }
        }

        public void 打开内容(M三级菜单 __三级菜单)
        {
            if (_已打开内容.ContainsKey(__三级菜单))
            {
                激活功能(__三级菜单);
                return;
            }

            if (__三级菜单.创建窗口 == null)
            {
                if (__三级菜单.执行方法 != null)
                {
                    __三级菜单.执行方法();
                }
                else
                {
                    H弹出消息.显示("该功能未实现", string.IsNullOrEmpty(__三级菜单.描述) ? __三级菜单.名称 : __三级菜单.描述);
                }
                return;
            }

            var __内容 = new Document(components)
                {
                    Caption = string.Format("  {0}  ", string.IsNullOrEmpty(__三级菜单.描述) ? __三级菜单.名称 : __三级菜单.描述),
                    Tag = __三级菜单,
                };
            __内容.Properties.AllowClose = __三级菜单.允许关闭 ? DefaultBoolean.True : DefaultBoolean.False;
            __内容.Properties.AllowDock = __三级菜单.允许停靠 ? DefaultBoolean.True : DefaultBoolean.False;
            //__内容.Properties.ShowPinButton = __功能.允许关闭 ? DefaultBoolean.True : DefaultBoolean.False;
            
            _已打开内容[__三级菜单] = __内容;
            outTab视图.Documents.Add(__内容);
            out内容组.Items.Add(__内容);

            outTab视图.Controller.Activate(__内容);
        }

        public void 激活功能(string __三级菜单名称, string __二级菜单名称 = null, string __一级菜单名称 = null)
        {
            var __三级菜单 = 查找三级菜单(__三级菜单名称, __二级菜单名称, __一级菜单名称);
            if (__三级菜单 != null)
            {
                激活功能(__三级菜单);
            }
        }

        public void 激活功能(M三级菜单 __三级菜单)
        {
            outTab视图.ActivateDocument(__三级菜单.实例);
        }

        void outTab视图_QueryControl(object sender, QueryControlEventArgs e)
        {
            var __功能 = e.Document.Tag as M三级菜单;
            if (__功能 != null && __功能.创建窗口 != null)
            {
                var __控件 = __功能.创建窗口();
                e.Control = __控件;
                __功能.实例 = __控件;
                return;
            }
            if (e.Document == out更新日志)
            {
                e.Control = new F更新日志();
                return;
            }
            e.Control = new Label() { Text = e.Document.Caption };
        }

        void outTab视图_DocumentClosing(object sender, DocumentCancelEventArgs e)
        {
            var __功能 = e.Document.Tag as M三级菜单;
            if (__功能 != null)
            {
                _已打开内容.Remove(__功能);
            }
        }

        private M三级菜单 查找三级菜单(string __三级菜单名称, string __二级菜单名称, string __一级菜单名称)
        {
            if (string.IsNullOrEmpty(__一级菜单名称))
            {
                var __三级菜单 = _三级菜单列表.Find(q => q.名称 == __三级菜单名称);
                if (__三级菜单 != null)
                {
                    return __三级菜单;
                }
            }
            else
            {
                var __一级菜单 = _一级菜单列表.Find(q => q.名称 == __一级菜单名称);
                if (__一级菜单 == null)
                {
                    return null;
                }
                var __二级菜单 = __一级菜单.子菜单.Find(q => q.名称 == __二级菜单名称);
                if (__二级菜单 == null)
                {
                    return null;
                }
                var __三级菜单 = __二级菜单.子菜单.Find(q => q.名称 == __三级菜单名称);
                if (__三级菜单 != null)
                {
                    return __三级菜单;
                }
            }
            return null;
        }

    }
}
