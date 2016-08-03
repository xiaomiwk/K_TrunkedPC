namespace UI
{
    partial class F主窗口
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F主窗口));
            this.out框架 = new System.Windows.Forms.TableLayoutPanel();
            this.out主体 = new DevExpress.XtraEditors.SplitContainerControl();
            this.out内容 = new DevExpress.XtraEditors.XtraUserControl();
            this.out文档管理器 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.outTab视图 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.out内容组 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.out更新日志 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.outBar管理器 = new DevExpress.XtraBars.BarManager(this.components);
            this.out工具栏 = new DevExpress.XtraBars.Bar();
            this.out菜单栏 = new DevExpress.XtraBars.Bar();
            this.out状态栏 = new DevExpress.XtraBars.Bar();
            this.out菜单栏容器 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.out框架.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out主体)).BeginInit();
            this.out主体.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out文档管理器)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTab视图)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out内容组)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out更新日志)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outBar管理器)).BeginInit();
            this.SuspendLayout();
            // 
            // out框架
            // 
            this.out框架.ColumnCount = 1;
            this.out框架.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.out框架.Controls.Add(this.out主体, 0, 0);
            this.out框架.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out框架.Location = new System.Drawing.Point(0, 49);
            this.out框架.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.out框架.Name = "out框架";
            this.out框架.RowCount = 1;
            this.out框架.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.out框架.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 644F));
            this.out框架.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 644F));
            this.out框架.Size = new System.Drawing.Size(1262, 628);
            this.out框架.TabIndex = 0;
            // 
            // out主体
            // 
            this.out主体.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.out主体.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out主体.Location = new System.Drawing.Point(0, 0);
            this.out主体.Margin = new System.Windows.Forms.Padding(0);
            this.out主体.Name = "out主体";
            this.out主体.Panel1.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.out主体.Panel1.Text = "导航";
            this.out主体.Panel2.Controls.Add(this.out内容);
            this.out主体.Panel2.Text = "内容";
            this.out主体.Size = new System.Drawing.Size(1262, 628);
            this.out主体.SplitterPosition = 171;
            this.out主体.TabIndex = 0;
            this.out主体.Text = "splitContainerControl1";
            // 
            // out内容
            // 
            this.out内容.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out内容.Location = new System.Drawing.Point(0, 0);
            this.out内容.Margin = new System.Windows.Forms.Padding(0);
            this.out内容.Name = "out内容";
            this.out内容.Size = new System.Drawing.Size(1086, 628);
            this.out内容.TabIndex = 0;
            // 
            // out文档管理器
            // 
            this.out文档管理器.ContainerControl = this.out内容;
            this.out文档管理器.View = this.outTab视图;
            this.out文档管理器.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.outTab视图});
            // 
            // outTab视图
            // 
            this.outTab视图.AppearancePage.Header.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTab视图.AppearancePage.Header.Options.UseFont = true;
            this.outTab视图.AppearancePage.HeaderActive.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTab视图.AppearancePage.HeaderActive.Options.UseFont = true;
            this.outTab视图.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTab视图.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.outTab视图.AppearancePage.HeaderSelected.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.outTab视图.AppearancePage.HeaderSelected.Options.UseFont = true;
            this.outTab视图.AppearancePage.PageClient.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTab视图.AppearancePage.PageClient.Options.UseFont = true;
            this.outTab视图.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.out内容组});
            this.outTab视图.DocumentProperties.AllowDock = false;
            this.outTab视图.DocumentProperties.MaxTabWidth = 150;
            this.outTab视图.DocumentProperties.TabWidth = 120;
            this.outTab视图.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.out更新日志});
            // 
            // out内容组
            // 
            this.out内容组.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.out更新日志});
            // 
            // out更新日志
            // 
            this.out更新日志.Caption = "更新日志";
            this.out更新日志.ControlName = "document1";
            this.out更新日志.Properties.AllowDock = DevExpress.Utils.DefaultBoolean.False;
            this.out更新日志.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.False;
            // 
            // outBar管理器
            // 
            this.outBar管理器.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.out工具栏,
            this.out菜单栏,
            this.out状态栏});
            this.outBar管理器.DockControls.Add(this.out菜单栏容器);
            this.outBar管理器.DockControls.Add(this.barDockControl2);
            this.outBar管理器.DockControls.Add(this.barDockControl3);
            this.outBar管理器.DockControls.Add(this.barDockControl4);
            this.outBar管理器.Form = this;
            this.outBar管理器.MainMenu = this.out菜单栏;
            this.outBar管理器.MaxItemId = 2;
            this.outBar管理器.StatusBar = this.out状态栏;
            // 
            // out工具栏
            // 
            this.out工具栏.BarName = "Tools";
            this.out工具栏.DockCol = 0;
            this.out工具栏.DockRow = 1;
            this.out工具栏.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.out工具栏.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.out工具栏.Text = "Tools";
            this.out工具栏.Visible = false;
            // 
            // out菜单栏
            // 
            this.out菜单栏.BarAppearance.Disabled.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out菜单栏.BarAppearance.Disabled.Options.UseFont = true;
            this.out菜单栏.BarAppearance.Hovered.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out菜单栏.BarAppearance.Hovered.Options.UseFont = true;
            this.out菜单栏.BarAppearance.Normal.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out菜单栏.BarAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.out菜单栏.BarAppearance.Normal.Options.UseFont = true;
            this.out菜单栏.BarAppearance.Normal.Options.UseForeColor = true;
            this.out菜单栏.BarAppearance.Pressed.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out菜单栏.BarAppearance.Pressed.Options.UseFont = true;
            this.out菜单栏.BarName = "Main menu";
            this.out菜单栏.DockCol = 0;
            this.out菜单栏.DockRow = 0;
            this.out菜单栏.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.out菜单栏.OptionsBar.AllowQuickCustomization = false;
            this.out菜单栏.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.out菜单栏.OptionsBar.DisableCustomization = true;
            this.out菜单栏.OptionsBar.DrawBorder = false;
            this.out菜单栏.OptionsBar.MultiLine = true;
            this.out菜单栏.OptionsBar.UseWholeRow = true;
            this.out菜单栏.Text = "Main menu";
            // 
            // out状态栏
            // 
            this.out状态栏.BarName = "Status bar";
            this.out状态栏.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.out状态栏.DockCol = 0;
            this.out状态栏.DockRow = 0;
            this.out状态栏.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.out状态栏.OptionsBar.AllowQuickCustomization = false;
            this.out状态栏.OptionsBar.DrawDragBorder = false;
            this.out状态栏.OptionsBar.UseWholeRow = true;
            this.out状态栏.Text = "Status bar";
            this.out状态栏.Visible = false;
            // 
            // out菜单栏容器
            // 
            this.out菜单栏容器.Appearance.ForeColor = System.Drawing.Color.White;
            this.out菜单栏容器.Appearance.Options.UseForeColor = true;
            this.out菜单栏容器.CausesValidation = false;
            this.out菜单栏容器.Dock = System.Windows.Forms.DockStyle.Top;
            this.out菜单栏容器.Location = new System.Drawing.Point(0, 0);
            this.out菜单栏容器.Size = new System.Drawing.Size(1262, 49);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 677);
            this.barDockControl2.Size = new System.Drawing.Size(1262, 23);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 49);
            this.barDockControl3.Size = new System.Drawing.Size(0, 628);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1262, 49);
            this.barDockControl4.Size = new System.Drawing.Size(0, 628);
            // 
            // F主窗口
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 700);
            this.Controls.Add(this.out框架);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.out菜单栏容器);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "F主窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "集群通信PC端";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.out框架.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.out主体)).EndInit();
            this.out主体.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.out文档管理器)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTab视图)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out内容组)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out更新日志)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outBar管理器)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel out框架;
        private DevExpress.XtraEditors.SplitContainerControl out主体;
        private DevExpress.XtraEditors.XtraUserControl out内容;
        private DevExpress.XtraBars.Docking2010.DocumentManager out文档管理器;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView outTab视图;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup out内容组;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document out更新日志;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl out菜单栏容器;
        private DevExpress.XtraBars.BarManager outBar管理器;
        private DevExpress.XtraBars.Bar out工具栏;
        private DevExpress.XtraBars.Bar out菜单栏;
        private DevExpress.XtraBars.Bar out状态栏;

    }
}

