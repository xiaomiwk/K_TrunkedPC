namespace UI.调度.地图
{
    partial class F地图_区域操作
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.do移动地图 = new DevExpress.XtraBars.BarButtonItem();
            this.do选择矩形 = new DevExpress.XtraBars.BarButtonItem();
            this.do选择圆形 = new DevExpress.XtraBars.BarButtonItem();
            this.do删除上一个区域 = new DevExpress.XtraBars.BarButtonItem();
            this.do删除所有区域 = new DevExpress.XtraBars.BarButtonItem();
            this.do查询已显示号码 = new DevExpress.XtraBars.BarButtonItem();
            this.do查询所有号码 = new DevExpress.XtraBars.BarButtonItem();
            this.do呼叫已选号码 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.out号码列表容器 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.out列表容器 = new DevExpress.XtraGrid.GridControl();
            this.out列表 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.out选择列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.out名称列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out号码列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out职位列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out部门列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.out列表容器2 = new DevExpress.XtraGrid.GridControl();
            this.out列表2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.do折叠展开 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out号码列表容器)).BeginInit();
            this.out号码列表容器.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.do选择矩形,
            this.do选择圆形,
            this.do删除上一个区域,
            this.do删除所有区域,
            this.do呼叫已选号码,
            this.do查询所有号码,
            this.do查询已显示号码,
            this.do移动地图,
            this.do折叠展开});
            this.barManager1.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarItemHorzIndent = 8;
            this.bar1.BarItemVertIndent = 8;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.do选择矩形),
            new DevExpress.XtraBars.LinkPersistInfo(this.do选择圆形),
            new DevExpress.XtraBars.LinkPersistInfo(this.do移动地图, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.do删除上一个区域, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.do删除所有区域),
            new DevExpress.XtraBars.LinkPersistInfo(this.do查询已显示号码, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.do查询所有号码),
            new DevExpress.XtraBars.LinkPersistInfo(this.do呼叫已选号码, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.do折叠展开, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.Text = "Tools";
            // 
            // do移动地图
            // 
            this.do移动地图.Caption = "移动地图";
            this.do移动地图.Id = 9;
            this.do移动地图.Name = "do移动地图";
            // 
            // do选择矩形
            // 
            this.do选择矩形.Caption = "选择矩形";
            this.do选择矩形.Id = 0;
            this.do选择矩形.Name = "do选择矩形";
            // 
            // do选择圆形
            // 
            this.do选择圆形.Caption = "选择圆形";
            this.do选择圆形.Id = 1;
            this.do选择圆形.Name = "do选择圆形";
            // 
            // do删除上一个区域
            // 
            this.do删除上一个区域.Caption = "删除上一个区域";
            this.do删除上一个区域.Id = 2;
            this.do删除上一个区域.Name = "do删除上一个区域";
            // 
            // do删除所有区域
            // 
            this.do删除所有区域.Caption = "删除所有区域";
            this.do删除所有区域.Id = 3;
            this.do删除所有区域.Name = "do删除所有区域";
            // 
            // do查询已显示号码
            // 
            this.do查询已显示号码.Caption = "查询已显示号码";
            this.do查询已显示号码.Id = 8;
            this.do查询已显示号码.Name = "do查询已显示号码";
            // 
            // do查询所有号码
            // 
            this.do查询所有号码.Caption = "查询所有号码";
            this.do查询所有号码.Id = 6;
            this.do查询所有号码.Name = "do查询所有号码";
            // 
            // do呼叫已选号码
            // 
            this.do呼叫已选号码.Caption = "呼叫已选号码";
            this.do呼叫已选号码.Id = 5;
            this.do呼叫已选号码.Name = "do呼叫已选号码";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(769, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 40);
            this.barDockControlBottom.Size = new System.Drawing.Size(769, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(769, 41);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // out号码列表容器
            // 
            this.out号码列表容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out号码列表容器.Location = new System.Drawing.Point(0, 41);
            this.out号码列表容器.Name = "out号码列表容器";
            this.out号码列表容器.SelectedTabPage = this.xtraTabPage1;
            this.out号码列表容器.Size = new System.Drawing.Size(769, 0);
            this.out号码列表容器.TabIndex = 37;
            this.out号码列表容器.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.out列表容器);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(763, 0);
            this.xtraTabPage1.Text = "个号";
            // 
            // out列表容器
            // 
            this.out列表容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out列表容器.Location = new System.Drawing.Point(0, 0);
            this.out列表容器.MainView = this.out列表;
            this.out列表容器.Name = "out列表容器";
            this.out列表容器.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.out列表容器.Size = new System.Drawing.Size(763, 0);
            this.out列表容器.TabIndex = 33;
            this.out列表容器.UseEmbeddedNavigator = true;
            this.out列表容器.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.out列表});
            // 
            // out列表
            // 
            this.out列表.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.out选择列,
            this.out名称列,
            this.out号码列,
            this.out职位列,
            this.out部门列,
            this.out操作列1,
            this.out操作列2});
            this.out列表.GridControl = this.out列表容器;
            this.out列表.Name = "out列表";
            // 
            // out选择列
            // 
            this.out选择列.Caption = "选择";
            this.out选择列.ColumnEdit = this.repositoryItemCheckEdit1;
            this.out选择列.Name = "out选择列";
            this.out选择列.Visible = true;
            this.out选择列.VisibleIndex = 0;
            this.out选择列.Width = 55;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // out名称列
            // 
            this.out名称列.Caption = "名称";
            this.out名称列.FieldName = "名称";
            this.out名称列.Name = "out名称列";
            this.out名称列.OptionsColumn.AllowEdit = false;
            this.out名称列.Visible = true;
            this.out名称列.VisibleIndex = 1;
            this.out名称列.Width = 110;
            // 
            // out号码列
            // 
            this.out号码列.Caption = "号码";
            this.out号码列.FieldName = "号码";
            this.out号码列.Name = "out号码列";
            this.out号码列.OptionsColumn.AllowEdit = false;
            this.out号码列.Visible = true;
            this.out号码列.VisibleIndex = 2;
            this.out号码列.Width = 111;
            // 
            // out职位列
            // 
            this.out职位列.Caption = "状态";
            this.out职位列.FieldName = "状态";
            this.out职位列.Name = "out职位列";
            this.out职位列.OptionsColumn.AllowEdit = false;
            this.out职位列.Visible = true;
            this.out职位列.VisibleIndex = 4;
            this.out职位列.Width = 108;
            // 
            // out部门列
            // 
            this.out部门列.Caption = "部门";
            this.out部门列.FieldName = "部门";
            this.out部门列.Name = "out部门列";
            this.out部门列.Visible = true;
            this.out部门列.VisibleIndex = 3;
            this.out部门列.Width = 185;
            // 
            // out操作列1
            // 
            this.out操作列1.Caption = "呼叫";
            this.out操作列1.Name = "out操作列1";
            this.out操作列1.Visible = true;
            this.out操作列1.VisibleIndex = 5;
            this.out操作列1.Width = 59;
            // 
            // out操作列2
            // 
            this.out操作列2.Caption = "发短信";
            this.out操作列2.Name = "out操作列2";
            this.out操作列2.Visible = true;
            this.out操作列2.VisibleIndex = 6;
            this.out操作列2.Width = 68;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.out列表容器2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(728, 0);
            this.xtraTabPage2.Text = "归属组";
            // 
            // out列表容器2
            // 
            this.out列表容器2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out列表容器2.Location = new System.Drawing.Point(0, 0);
            this.out列表容器2.MainView = this.out列表2;
            this.out列表容器2.Name = "out列表容器2";
            this.out列表容器2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.out列表容器2.Size = new System.Drawing.Size(728, 0);
            this.out列表容器2.TabIndex = 34;
            this.out列表容器2.UseEmbeddedNavigator = true;
            this.out列表容器2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.out列表2});
            // 
            // out列表2
            // 
            this.out列表2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.out操作列3,
            this.out操作列4});
            this.out列表2.GridControl = this.out列表容器2;
            this.out列表2.Name = "out列表2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "选择";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "名称";
            this.gridColumn2.FieldName = "名称";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 258;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "号码";
            this.gridColumn3.FieldName = "号码";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 172;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "部门";
            this.gridColumn5.FieldName = "部门";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 342;
            // 
            // out操作列3
            // 
            this.out操作列3.Caption = "呼叫";
            this.out操作列3.Name = "out操作列3";
            this.out操作列3.Visible = true;
            this.out操作列3.VisibleIndex = 4;
            this.out操作列3.Width = 128;
            // 
            // out操作列4
            // 
            this.out操作列4.Caption = "发短信";
            this.out操作列4.Name = "out操作列4";
            this.out操作列4.Visible = true;
            this.out操作列4.VisibleIndex = 5;
            this.out操作列4.Width = 114;
            // 
            // do折叠展开
            // 
            this.do折叠展开.Caption = "折叠";
            this.do折叠展开.Id = 10;
            this.do折叠展开.Name = "do折叠展开";
            // 
            // F地图_区域操作
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(769, 40);
            this.Controls.Add(this.out号码列表容器);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "F地图_区域操作";
            this.Text = "区域操作";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out号码列表容器)).EndInit();
            this.out号码列表容器.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem do选择矩形;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem do选择圆形;
        private DevExpress.XtraBars.BarButtonItem do删除上一个区域;
        private DevExpress.XtraBars.BarButtonItem do删除所有区域;
        private DevExpress.XtraBars.BarButtonItem do呼叫已选号码;
        private DevExpress.XtraBars.BarButtonItem do查询所有号码;
        private DevExpress.XtraBars.BarButtonItem do查询已显示号码;
        private DevExpress.XtraTab.XtraTabControl out号码列表容器;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl out列表容器;
        private DevExpress.XtraGrid.Views.Grid.GridView out列表;
        private DevExpress.XtraGrid.Columns.GridColumn out选择列;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn out名称列;
        private DevExpress.XtraGrid.Columns.GridColumn out号码列;
        private DevExpress.XtraGrid.Columns.GridColumn out职位列;
        private DevExpress.XtraGrid.Columns.GridColumn out部门列;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列1;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl out列表容器2;
        private DevExpress.XtraGrid.Views.Grid.GridView out列表2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列3;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列4;
        private DevExpress.XtraBars.BarButtonItem do移动地图;
        private DevExpress.XtraBars.BarButtonItem do折叠展开;
    }
}