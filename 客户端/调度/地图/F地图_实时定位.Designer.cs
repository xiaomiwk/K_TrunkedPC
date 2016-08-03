using UI.公共;
using UI.基础.通知;

namespace UI.调度.地图
{
    partial class F地图_实时定位
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.out框架 = new DevExpress.XtraEditors.SplitContainerControl();
            this.out导航 = new DevExpress.XtraEditors.SplitContainerControl();
            this.in资源 = new UI.公共.F资源();
            this.f日志1 = new UI.基础.通知.F通知();
            this.out主体 = new System.Windows.Forms.TableLayoutPanel();
            this.out工具栏 = new DevExpress.XtraEditors.XtraUserControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.out地图容器 = new DevExpress.XtraEditors.PanelControl();
            this.out浏览器 = new System.Windows.Forms.WebBrowser();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.do地图操作_平移 = new DevExpress.XtraBars.BarButtonItem();
            this.do地图操作_区域 = new DevExpress.XtraBars.BarButtonItem();
            this.do地图操作_标注 = new DevExpress.XtraBars.BarButtonItem();
            this.do地图操作_测距 = new DevExpress.XtraBars.BarButtonItem();
            this.do地图操作_查询 = new DevExpress.XtraBars.BarEditItem();
            this.do地图操作_查询_编辑器 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.do地图操作_轨迹回放 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.out订阅菜单 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.do关注_呼叫 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_高级呼叫 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_合并呼叫 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_发送短信 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_合并发送短信 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.do关注_取消预案 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_删除临时关注 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_删除所有临时关注 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.do关注_查看成员 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_查看通话记录 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_查看详细信息 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.do关注_定位 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_锁定 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_取消锁定 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_设置显示样式 = new System.Windows.Forms.ToolStripMenuItem();
            this.do关注_配置定位参数 = new System.Windows.Forms.ToolStripMenuItem();
            this.out基站菜单 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.do基站_呼叫 = new System.Windows.Forms.ToolStripMenuItem();
            this.do基站_合并呼叫 = new System.Windows.Forms.ToolStripMenuItem();
            this.do基站_发送短信 = new System.Windows.Forms.ToolStripMenuItem();
            this.do基站_合并发送短信 = new System.Windows.Forms.ToolStripMenuItem();
            this.out部门菜单 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.do部门_呼叫 = new System.Windows.Forms.ToolStripMenuItem();
            this.do部门_高级呼叫 = new System.Windows.Forms.ToolStripMenuItem();
            this.do部门_合并呼叫 = new System.Windows.Forms.ToolStripMenuItem();
            this.do部门_发送短信 = new System.Windows.Forms.ToolStripMenuItem();
            this.do部门_合并发送短信 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.do部门_设为预案 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.do部门_查看成员 = new System.Windows.Forms.ToolStripMenuItem();
            this.do部门_查看通话记录 = new System.Windows.Forms.ToolStripMenuItem();
            this.do部门_查看详细信息 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.do部门_定位 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.out框架)).BeginInit();
            this.out框架.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out导航)).BeginInit();
            this.out导航.SuspendLayout();
            this.out主体.SuspendLayout();
            this.out工具栏.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out地图容器)).BeginInit();
            this.out地图容器.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.do地图操作_查询_编辑器)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            this.out订阅菜单.SuspendLayout();
            this.out基站菜单.SuspendLayout();
            this.out部门菜单.SuspendLayout();
            this.SuspendLayout();
            // 
            // out框架
            // 
            this.out框架.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.out框架.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out框架.Location = new System.Drawing.Point(6, 6);
            this.out框架.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.out框架.Name = "out框架";
            this.out框架.Panel1.Controls.Add(this.out导航);
            this.out框架.Panel1.Text = "Panel1";
            this.out框架.Panel2.Controls.Add(this.out主体);
            this.out框架.Panel2.Text = "Panel2";
            this.out框架.Size = new System.Drawing.Size(1044, 722);
            this.out框架.SplitterPosition = 225;
            this.out框架.TabIndex = 0;
            this.out框架.Text = "splitContainerControl1";
            // 
            // out导航
            // 
            this.out导航.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out导航.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.out导航.Horizontal = false;
            this.out导航.Location = new System.Drawing.Point(0, 0);
            this.out导航.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.out导航.Name = "out导航";
            this.out导航.Panel1.Controls.Add(this.in资源);
            this.out导航.Panel1.Text = "Panel1";
            this.out导航.Panel2.Controls.Add(this.f日志1);
            this.out导航.Panel2.Text = "Panel2";
            this.out导航.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            this.out导航.Size = new System.Drawing.Size(225, 722);
            this.out导航.SplitterPosition = 380;
            this.out导航.TabIndex = 1;
            this.out导航.Text = "splitContainerControl1";
            // 
            // in资源
            // 
            this.in资源.Dock = System.Windows.Forms.DockStyle.Fill;
            this.in资源.Location = new System.Drawing.Point(0, 0);
            this.in资源.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.in资源.Name = "in资源";
            this.in资源.Size = new System.Drawing.Size(225, 722);
            this.in资源.TabIndex = 0;
            this.in资源.关注可见 = true;
            this.in资源.关注菜单 = null;
            this.in资源.基站可见 = true;
            this.in资源.基站菜单 = null;
            this.in资源.显示关注复选框 = true;
            this.in资源.显示基站复选框 = true;
            this.in资源.显示部门复选框 = false;
            this.in资源.环境可见 = false;
            this.in资源.环境菜单 = null;
            this.in资源.部门菜单 = null;
            // 
            // f日志1
            // 
            this.f日志1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f日志1.Location = new System.Drawing.Point(0, 0);
            this.f日志1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.f日志1.Name = "f日志1";
            this.f日志1.Size = new System.Drawing.Size(0, 0);
            this.f日志1.TabIndex = 0;
            // 
            // out主体
            // 
            this.out主体.ColumnCount = 1;
            this.out主体.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.out主体.Controls.Add(this.out工具栏, 0, 0);
            this.out主体.Controls.Add(this.out地图容器, 0, 1);
            this.out主体.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out主体.Location = new System.Drawing.Point(0, 0);
            this.out主体.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.out主体.Name = "out主体";
            this.out主体.RowCount = 2;
            this.out主体.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.out主体.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.out主体.Size = new System.Drawing.Size(814, 722);
            this.out主体.TabIndex = 0;
            // 
            // out工具栏
            // 
            this.out工具栏.Controls.Add(this.barDockControlLeft);
            this.out工具栏.Controls.Add(this.barDockControlRight);
            this.out工具栏.Controls.Add(this.barDockControlBottom);
            this.out工具栏.Controls.Add(this.barDockControlTop);
            this.out工具栏.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out工具栏.Location = new System.Drawing.Point(3, 4);
            this.out工具栏.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.out工具栏.Name = "out工具栏";
            this.out工具栏.Size = new System.Drawing.Size(808, 32);
            this.out工具栏.TabIndex = 1;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(808, 34);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 32);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(808, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(137)))));
            this.barDockControlTop.Appearance.Options.UseBackColor = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(808, 34);
            // 
            // out地图容器
            // 
            this.out地图容器.Controls.Add(this.out浏览器);
            this.out地图容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out地图容器.Location = new System.Drawing.Point(3, 44);
            this.out地图容器.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.out地图容器.Name = "out地图容器";
            this.out地图容器.Size = new System.Drawing.Size(808, 674);
            this.out地图容器.TabIndex = 2;
            // 
            // out浏览器
            // 
            this.out浏览器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out浏览器.Location = new System.Drawing.Point(2, 2);
            this.out浏览器.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.out浏览器.MinimumSize = new System.Drawing.Size(23, 26);
            this.out浏览器.Name = "out浏览器";
            this.out浏览器.Size = new System.Drawing.Size(804, 670);
            this.out浏览器.TabIndex = 11;
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this.out工具栏;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.do地图操作_平移,
            this.do地图操作_标注,
            this.do地图操作_测距,
            this.do地图操作_轨迹回放,
            this.barButtonItem5,
            this.do地图操作_区域,
            this.barButtonItem7,
            this.barEditItem1,
            this.barLargeButtonItem1,
            this.barToolbarsListItem1,
            this.barEditItem2,
            this.do地图操作_查询});
            this.barManager1.MaxItemId = 14;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemPopupContainerEdit1,
            this.do地图操作_查询_编辑器});
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.bar1.BarAppearance.Normal.Options.UseForeColor = true;
            this.bar1.BarItemHorzIndent = 10;
            this.bar1.BarItemVertIndent = 5;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.do地图操作_平移),
            new DevExpress.XtraBars.LinkPersistInfo(this.do地图操作_区域, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.do地图操作_标注, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.do地图操作_测距, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.do地图操作_查询, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.Text = "Tools";
            // 
            // do地图操作_平移
            // 
            this.do地图操作_平移.Caption = "平移";
            this.do地图操作_平移.Id = 0;
            this.do地图操作_平移.Name = "do地图操作_平移";
            this.do地图操作_平移.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // do地图操作_区域
            // 
            this.do地图操作_区域.Caption = "区域";
            this.do地图操作_区域.Id = 6;
            this.do地图操作_区域.Name = "do地图操作_区域";
            // 
            // do地图操作_标注
            // 
            this.do地图操作_标注.Caption = "标注";
            this.do地图操作_标注.Id = 1;
            this.do地图操作_标注.Name = "do地图操作_标注";
            // 
            // do地图操作_测距
            // 
            this.do地图操作_测距.Caption = "测距";
            this.do地图操作_测距.Id = 2;
            this.do地图操作_测距.Name = "do地图操作_测距";
            // 
            // do地图操作_查询
            // 
            this.do地图操作_查询.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.do地图操作_查询.Edit = this.do地图操作_查询_编辑器;
            this.do地图操作_查询.Id = 12;
            this.do地图操作_查询.Name = "do地图操作_查询";
            this.do地图操作_查询.Width = 250;
            // 
            // do地图操作_查询_编辑器
            // 
            this.do地图操作_查询_编辑器.AutoHeight = false;
            this.do地图操作_查询_编辑器.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::UI.Properties.Resources.搜索, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.do地图操作_查询_编辑器.Name = "do地图操作_查询_编辑器";
            // 
            // do地图操作_轨迹回放
            // 
            this.do地图操作_轨迹回放.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.do地图操作_轨迹回放.Caption = "轨迹回放";
            this.do地图操作_轨迹回放.Glyph = global::UI.Properties.Resources.回放;
            this.do地图操作_轨迹回放.Id = 3;
            this.do地图操作_轨迹回放.Name = "do地图操作_轨迹回放";
            this.do地图操作_轨迹回放.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "搜索";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "选择圆形区域";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemImageComboBox1;
            this.barEditItem1.Id = 8;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "barLargeButtonItem1";
            this.barLargeButtonItem1.Id = 9;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 10;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemPopupContainerEdit1;
            this.barEditItem2.Id = 11;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // out订阅菜单
            // 
            this.out订阅菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.do关注_呼叫,
            this.do关注_高级呼叫,
            this.do关注_合并呼叫,
            this.do关注_发送短信,
            this.do关注_合并发送短信,
            this.toolStripSeparator1,
            this.do关注_取消预案,
            this.do关注_删除临时关注,
            this.do关注_删除所有临时关注,
            this.toolStripSeparator7,
            this.do关注_查看成员,
            this.do关注_查看通话记录,
            this.do关注_查看详细信息,
            this.toolStripSeparator3,
            this.do关注_定位,
            this.do关注_锁定,
            this.do关注_取消锁定,
            this.do关注_设置显示样式,
            this.do关注_配置定位参数});
            this.out订阅菜单.Name = "out关注菜单";
            this.out订阅菜单.Size = new System.Drawing.Size(171, 396);
            // 
            // do关注_呼叫
            // 
            this.do关注_呼叫.Name = "do关注_呼叫";
            this.do关注_呼叫.Size = new System.Drawing.Size(170, 22);
            this.do关注_呼叫.Text = "呼叫";
            // 
            // do关注_高级呼叫
            // 
            this.do关注_高级呼叫.Name = "do关注_高级呼叫";
            this.do关注_高级呼叫.Size = new System.Drawing.Size(170, 22);
            this.do关注_高级呼叫.Text = "高级呼叫";
            // 
            // do关注_合并呼叫
            // 
            this.do关注_合并呼叫.Name = "do关注_合并呼叫";
            this.do关注_合并呼叫.Size = new System.Drawing.Size(170, 22);
            this.do关注_合并呼叫.Text = "合并呼叫";
            // 
            // do关注_发送短信
            // 
            this.do关注_发送短信.Name = "do关注_发送短信";
            this.do关注_发送短信.Size = new System.Drawing.Size(170, 22);
            this.do关注_发送短信.Text = "发送短信";
            // 
            // do关注_合并发送短信
            // 
            this.do关注_合并发送短信.Name = "do关注_合并发送短信";
            this.do关注_合并发送短信.Size = new System.Drawing.Size(170, 22);
            this.do关注_合并发送短信.Text = "合并发送短信";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // do关注_取消预案
            // 
            this.do关注_取消预案.Name = "do关注_取消预案";
            this.do关注_取消预案.Size = new System.Drawing.Size(170, 22);
            this.do关注_取消预案.Text = "取消预案";
            // 
            // do关注_删除临时关注
            // 
            this.do关注_删除临时关注.Name = "do关注_删除临时关注";
            this.do关注_删除临时关注.Size = new System.Drawing.Size(170, 22);
            this.do关注_删除临时关注.Text = "删除临时关注";
            // 
            // do关注_删除所有临时关注
            // 
            this.do关注_删除所有临时关注.Name = "do关注_删除所有临时关注";
            this.do关注_删除所有临时关注.Size = new System.Drawing.Size(170, 22);
            this.do关注_删除所有临时关注.Text = "删除所有临时关注";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(167, 6);
            // 
            // do关注_查看成员
            // 
            this.do关注_查看成员.Name = "do关注_查看成员";
            this.do关注_查看成员.Size = new System.Drawing.Size(170, 22);
            this.do关注_查看成员.Text = "查看成员";
            this.do关注_查看成员.Visible = false;
            // 
            // do关注_查看通话记录
            // 
            this.do关注_查看通话记录.Name = "do关注_查看通话记录";
            this.do关注_查看通话记录.Size = new System.Drawing.Size(170, 22);
            this.do关注_查看通话记录.Text = "查看通话记录";
            this.do关注_查看通话记录.Visible = false;
            // 
            // do关注_查看详细信息
            // 
            this.do关注_查看详细信息.Name = "do关注_查看详细信息";
            this.do关注_查看详细信息.Size = new System.Drawing.Size(170, 22);
            this.do关注_查看详细信息.Text = "查看详细信息";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // do关注_定位
            // 
            this.do关注_定位.Name = "do关注_定位";
            this.do关注_定位.Size = new System.Drawing.Size(170, 22);
            this.do关注_定位.Text = "定位";
            // 
            // do关注_锁定
            // 
            this.do关注_锁定.Name = "do关注_锁定";
            this.do关注_锁定.Size = new System.Drawing.Size(170, 22);
            this.do关注_锁定.Text = "锁定";
            // 
            // do关注_取消锁定
            // 
            this.do关注_取消锁定.Name = "do关注_取消锁定";
            this.do关注_取消锁定.Size = new System.Drawing.Size(170, 22);
            this.do关注_取消锁定.Text = "取消锁定";
            // 
            // do关注_设置显示样式
            // 
            this.do关注_设置显示样式.Name = "do关注_设置显示样式";
            this.do关注_设置显示样式.Size = new System.Drawing.Size(170, 22);
            this.do关注_设置显示样式.Text = "设置显示样式";
            // 
            // do关注_配置定位参数
            // 
            this.do关注_配置定位参数.Name = "do关注_配置定位参数";
            this.do关注_配置定位参数.Size = new System.Drawing.Size(170, 22);
            this.do关注_配置定位参数.Text = "配置定位参数";
            // 
            // out基站菜单
            // 
            this.out基站菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.do基站_呼叫,
            this.do基站_合并呼叫,
            this.do基站_发送短信,
            this.do基站_合并发送短信});
            this.out基站菜单.Name = "out关注菜单";
            this.out基站菜单.Size = new System.Drawing.Size(147, 92);
            // 
            // do基站_呼叫
            // 
            this.do基站_呼叫.Name = "do基站_呼叫";
            this.do基站_呼叫.Size = new System.Drawing.Size(146, 22);
            this.do基站_呼叫.Text = "呼叫";
            // 
            // do基站_合并呼叫
            // 
            this.do基站_合并呼叫.Name = "do基站_合并呼叫";
            this.do基站_合并呼叫.Size = new System.Drawing.Size(146, 22);
            this.do基站_合并呼叫.Text = "合并呼叫";
            // 
            // do基站_发送短信
            // 
            this.do基站_发送短信.Name = "do基站_发送短信";
            this.do基站_发送短信.Size = new System.Drawing.Size(146, 22);
            this.do基站_发送短信.Text = "发送短信";
            // 
            // do基站_合并发送短信
            // 
            this.do基站_合并发送短信.Name = "do基站_合并发送短信";
            this.do基站_合并发送短信.Size = new System.Drawing.Size(146, 22);
            this.do基站_合并发送短信.Text = "合并发送短信";
            // 
            // out部门菜单
            // 
            this.out部门菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.do部门_呼叫,
            this.do部门_高级呼叫,
            this.do部门_合并呼叫,
            this.do部门_发送短信,
            this.do部门_合并发送短信,
            this.toolStripSeparator2,
            this.do部门_设为预案,
            this.toolStripSeparator4,
            this.do部门_查看成员,
            this.do部门_查看通话记录,
            this.do部门_查看详细信息,
            this.toolStripSeparator5,
            this.do部门_定位});
            this.out部门菜单.Name = "out关注菜单";
            this.out部门菜单.Size = new System.Drawing.Size(147, 242);
            // 
            // do部门_呼叫
            // 
            this.do部门_呼叫.Name = "do部门_呼叫";
            this.do部门_呼叫.Size = new System.Drawing.Size(146, 22);
            this.do部门_呼叫.Text = "呼叫";
            // 
            // do部门_高级呼叫
            // 
            this.do部门_高级呼叫.Name = "do部门_高级呼叫";
            this.do部门_高级呼叫.Size = new System.Drawing.Size(146, 22);
            this.do部门_高级呼叫.Text = "高级呼叫";
            // 
            // do部门_合并呼叫
            // 
            this.do部门_合并呼叫.Name = "do部门_合并呼叫";
            this.do部门_合并呼叫.Size = new System.Drawing.Size(146, 22);
            this.do部门_合并呼叫.Text = "合并呼叫";
            // 
            // do部门_发送短信
            // 
            this.do部门_发送短信.Name = "do部门_发送短信";
            this.do部门_发送短信.Size = new System.Drawing.Size(146, 22);
            this.do部门_发送短信.Text = "发送短信";
            // 
            // do部门_合并发送短信
            // 
            this.do部门_合并发送短信.Name = "do部门_合并发送短信";
            this.do部门_合并发送短信.Size = new System.Drawing.Size(146, 22);
            this.do部门_合并发送短信.Text = "合并发送短信";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // do部门_设为预案
            // 
            this.do部门_设为预案.Name = "do部门_设为预案";
            this.do部门_设为预案.Size = new System.Drawing.Size(146, 22);
            this.do部门_设为预案.Text = "设为预案";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // do部门_查看成员
            // 
            this.do部门_查看成员.Name = "do部门_查看成员";
            this.do部门_查看成员.Size = new System.Drawing.Size(146, 22);
            this.do部门_查看成员.Text = "查看成员";
            this.do部门_查看成员.Visible = false;
            // 
            // do部门_查看通话记录
            // 
            this.do部门_查看通话记录.Name = "do部门_查看通话记录";
            this.do部门_查看通话记录.Size = new System.Drawing.Size(146, 22);
            this.do部门_查看通话记录.Text = "查看通话记录";
            this.do部门_查看通话记录.Visible = false;
            // 
            // do部门_查看详细信息
            // 
            this.do部门_查看详细信息.Name = "do部门_查看详细信息";
            this.do部门_查看详细信息.Size = new System.Drawing.Size(146, 22);
            this.do部门_查看详细信息.Text = "查看详细信息";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(143, 6);
            // 
            // do部门_定位
            // 
            this.do部门_定位.Name = "do部门_定位";
            this.do部门_定位.Size = new System.Drawing.Size(146, 22);
            this.do部门_定位.Text = "定位";
            // 
            // F地图_实时定位
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.out框架);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "F地图_实时定位";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(1056, 734);
            ((System.ComponentModel.ISupportInitialize)(this.out框架)).EndInit();
            this.out框架.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.out导航)).EndInit();
            this.out导航.ResumeLayout(false);
            this.out主体.ResumeLayout(false);
            this.out工具栏.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.out地图容器)).EndInit();
            this.out地图容器.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.do地图操作_查询_编辑器)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            this.out订阅菜单.ResumeLayout(false);
            this.out基站菜单.ResumeLayout(false);
            this.out部门菜单.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl out框架;
        private DevExpress.XtraEditors.SplitContainerControl out导航;
        private System.Windows.Forms.TableLayoutPanel out主体;
        private F资源 in资源;
        private F通知 f日志1;
        private DevExpress.XtraEditors.XtraUserControl out工具栏;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem do地图操作_平移;
        private DevExpress.XtraBars.BarButtonItem do地图操作_标注;
        private DevExpress.XtraBars.BarButtonItem do地图操作_测距;
        private DevExpress.XtraBars.BarButtonItem do地图操作_轨迹回放;
        private DevExpress.XtraEditors.PanelControl out地图容器;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem do地图操作_区域;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private System.Windows.Forms.ContextMenuStrip out订阅菜单;
        private System.Windows.Forms.ToolStripMenuItem do关注_呼叫;
        private System.Windows.Forms.ToolStripMenuItem do关注_高级呼叫;
        private System.Windows.Forms.ToolStripMenuItem do关注_合并呼叫;
        private System.Windows.Forms.ToolStripMenuItem do关注_发送短信;
        private System.Windows.Forms.ToolStripMenuItem do关注_合并发送短信;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem do关注_取消预案;
        private System.Windows.Forms.ToolStripMenuItem do关注_查看成员;
        private System.Windows.Forms.ToolStripMenuItem do关注_查看通话记录;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem do关注_定位;
        private System.Windows.Forms.ContextMenuStrip out基站菜单;
        private System.Windows.Forms.ToolStripMenuItem do基站_呼叫;
        private System.Windows.Forms.ToolStripMenuItem do基站_合并呼叫;
        private System.Windows.Forms.ToolStripMenuItem do基站_发送短信;
        private System.Windows.Forms.ToolStripMenuItem do基站_合并发送短信;
        private System.Windows.Forms.ContextMenuStrip out部门菜单;
        private System.Windows.Forms.ToolStripMenuItem do部门_呼叫;
        private System.Windows.Forms.ToolStripMenuItem do部门_高级呼叫;
        private System.Windows.Forms.ToolStripMenuItem do部门_合并呼叫;
        private System.Windows.Forms.ToolStripMenuItem do部门_发送短信;
        private System.Windows.Forms.ToolStripMenuItem do部门_合并发送短信;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem do部门_设为预案;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem do部门_查看成员;
        private System.Windows.Forms.ToolStripMenuItem do部门_查看通话记录;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem do部门_定位;
        private System.Windows.Forms.ToolStripMenuItem do关注_删除临时关注;
        private System.Windows.Forms.ToolStripMenuItem do关注_删除所有临时关注;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem do关注_设置显示样式;
        private DevExpress.XtraBars.BarEditItem do地图操作_查询;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit do地图操作_查询_编辑器;
        private System.Windows.Forms.ToolStripMenuItem do关注_查看详细信息;
        private System.Windows.Forms.ToolStripMenuItem do部门_查看详细信息;
        private System.Windows.Forms.ToolStripMenuItem do关注_配置定位参数;
        private System.Windows.Forms.WebBrowser out浏览器;
        private System.Windows.Forms.ToolStripMenuItem do关注_锁定;
        private System.Windows.Forms.ToolStripMenuItem do关注_取消锁定;
    }
}
