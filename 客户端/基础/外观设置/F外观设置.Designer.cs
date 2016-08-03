namespace UI.基础.外观设置
{
    partial class F外观设置
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F外观设置));
            this.in皮肤列表 = new DevExpress.XtraEditors.ImageListBoxControl();
            this.out图片列表 = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.out列表容器 = new DevExpress.XtraGrid.GridControl();
            this.out列表 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.out图片名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out图片 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.f提示1 = new UI.基础.F提示();
            ((System.ComponentModel.ISupportInitialize)(this.in皮肤列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out图片列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // in皮肤列表
            // 
            this.in皮肤列表.ImageList = this.out图片列表;
            this.in皮肤列表.ItemHeight = 25;
            this.in皮肤列表.Location = new System.Drawing.Point(46, 52);
            this.in皮肤列表.Name = "in皮肤列表";
            this.in皮肤列表.Size = new System.Drawing.Size(367, 129);
            this.in皮肤列表.TabIndex = 8;
            // 
            // out图片列表
            // 
            this.out图片列表.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("out图片列表.ImageStream")));
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(42, 204);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(371, 23);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = " 背景图片";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(42, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(371, 23);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = " 皮肤";
            // 
            // out列表容器
            // 
            this.out列表容器.Location = new System.Drawing.Point(46, 234);
            this.out列表容器.MainView = this.out列表;
            this.out列表容器.Name = "out列表容器";
            this.out列表容器.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.out列表容器.Size = new System.Drawing.Size(367, 197);
            this.out列表容器.TabIndex = 35;
            this.out列表容器.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.out列表});
            // 
            // out列表
            // 
            this.out列表.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.out图片名称,
            this.out图片});
            this.out列表.GridControl = this.out列表容器;
            this.out列表.Name = "out列表";
            this.out列表.OptionsBehavior.Editable = false;
            this.out列表.OptionsCustomization.AllowFilter = false;
            this.out列表.OptionsCustomization.AllowGroup = false;
            this.out列表.OptionsCustomization.AllowSort = false;
            this.out列表.OptionsFind.AllowFindPanel = false;
            this.out列表.OptionsMenu.EnableColumnMenu = false;
            this.out列表.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.out列表.OptionsView.ShowGroupPanel = false;
            this.out列表.RowHeight = 80;
            // 
            // out图片名称
            // 
            this.out图片名称.FieldName = "图片名称";
            this.out图片名称.Name = "out图片名称";
            this.out图片名称.Visible = true;
            this.out图片名称.VisibleIndex = 0;
            // 
            // out图片
            // 
            this.out图片.ColumnEdit = this.repositoryItemPictureEdit1;
            this.out图片.FieldName = "图片";
            this.out图片.Name = "out图片";
            this.out图片.OptionsColumn.AllowEdit = false;
            this.out图片.Visible = true;
            this.out图片.VisibleIndex = 1;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.CustomHeight = 100;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ShowMenu = false;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // f提示1
            // 
            this.f提示1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f提示1.Location = new System.Drawing.Point(42, 437);
            this.f提示1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.f提示1.Name = "f提示1";
            this.f提示1.Size = new System.Drawing.Size(371, 30);
            this.f提示1.TabIndex = 54;
            this.f提示1.内容 = "皮肤和背景图片需要色彩搭配，以达到最佳显示效果";
            this.f提示1.图标 = global::UI.Properties.Resources.提示;
            // 
            // F设置_外观
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.f提示1);
            this.Controls.Add(this.out列表容器);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.in皮肤列表);
            this.Name = "F设置_外观";
            this.Size = new System.Drawing.Size(474, 498);
            ((System.ComponentModel.ISupportInitialize)(this.in皮肤列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out图片列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ImageListBoxControl in皮肤列表;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.ImageCollection out图片列表;
        private DevExpress.XtraGrid.GridControl out列表容器;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView out列表;
        private DevExpress.XtraGrid.Columns.GridColumn out图片名称;
        private DevExpress.XtraGrid.Columns.GridColumn out图片;
        private F提示 f提示1;
    }
}
