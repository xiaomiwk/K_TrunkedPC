namespace UI.调度.短信
{
    partial class F短信_短信箱
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.out辅助容器 = new DevExpress.XtraEditors.PanelControl();
            this.do查询提示 = new DevExpress.XtraEditors.SimpleButton();
            this.out列表容器 = new DevExpress.XtraGrid.GridControl();
            this.out列表 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.out位置列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out对方号码列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out内容列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out时间列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.out操作列2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.out操作列3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.do清空 = new DevExpress.XtraEditors.SimpleButton();
            this.in仅未读 = new DevExpress.XtraEditors.CheckEdit();
            this.in查询条件 = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.out辅助容器)).BeginInit();
            this.out辅助容器.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in仅未读.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in查询条件.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // out辅助容器
            // 
            this.out辅助容器.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.out辅助容器.Controls.Add(this.do查询提示);
            this.out辅助容器.Controls.Add(this.out列表容器);
            this.out辅助容器.Controls.Add(this.do清空);
            this.out辅助容器.Controls.Add(this.in仅未读);
            this.out辅助容器.Controls.Add(this.in查询条件);
            this.out辅助容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out辅助容器.Location = new System.Drawing.Point(10, 3);
            this.out辅助容器.Name = "out辅助容器";
            this.out辅助容器.Size = new System.Drawing.Size(638, 446);
            this.out辅助容器.TabIndex = 0;
            // 
            // do查询提示
            // 
            this.do查询提示.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.do查询提示.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.do查询提示.Appearance.Options.UseBackColor = true;
            this.do查询提示.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.do查询提示.Image = global::UI.Properties.Resources.提示;
            this.do查询提示.Location = new System.Drawing.Point(256, 11);
            this.do查询提示.Name = "do查询提示";
            this.do查询提示.Size = new System.Drawing.Size(28, 23);
            this.do查询提示.TabIndex = 62;
            this.do查询提示.ToolTip = "点击查看查询示例";
            // 
            // out列表容器
            // 
            this.out列表容器.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out列表容器.Location = new System.Drawing.Point(0, 43);
            this.out列表容器.MainView = this.out列表;
            this.out列表容器.Name = "out列表容器";
            this.out列表容器.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemButtonEdit1});
            this.out列表容器.Size = new System.Drawing.Size(638, 403);
            this.out列表容器.TabIndex = 60;
            this.out列表容器.UseEmbeddedNavigator = true;
            this.out列表容器.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.out列表});
            // 
            // out列表
            // 
            this.out列表.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.out位置列,
            this.out对方号码列,
            this.out内容列,
            this.out时间列,
            this.out操作列1,
            this.out操作列2,
            this.out操作列3,
            this.out操作列4});
            this.out列表.GridControl = this.out列表容器;
            this.out列表.Name = "out列表";
            // 
            // out位置列
            // 
            this.out位置列.AppearanceCell.Options.UseTextOptions = true;
            this.out位置列.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.out位置列.Caption = "位置";
            this.out位置列.FieldName = "位置";
            this.out位置列.Name = "out位置列";
            this.out位置列.OptionsColumn.AllowEdit = false;
            this.out位置列.Visible = true;
            this.out位置列.VisibleIndex = 0;
            this.out位置列.Width = 68;
            // 
            // out对方号码列
            // 
            this.out对方号码列.Caption = "对方号码";
            this.out对方号码列.FieldName = "对方号码";
            this.out对方号码列.Name = "out对方号码列";
            this.out对方号码列.OptionsColumn.AllowEdit = false;
            this.out对方号码列.Visible = true;
            this.out对方号码列.VisibleIndex = 1;
            this.out对方号码列.Width = 97;
            // 
            // out内容列
            // 
            this.out内容列.Caption = "内容";
            this.out内容列.FieldName = "内容";
            this.out内容列.Name = "out内容列";
            this.out内容列.OptionsColumn.AllowEdit = false;
            this.out内容列.Visible = true;
            this.out内容列.VisibleIndex = 2;
            this.out内容列.Width = 152;
            // 
            // out时间列
            // 
            this.out时间列.Caption = "时间";
            this.out时间列.DisplayFormat.FormatString = "MM-dd HH:mm";
            this.out时间列.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.out时间列.FieldName = "时间";
            this.out时间列.Name = "out时间列";
            this.out时间列.OptionsColumn.AllowEdit = false;
            this.out时间列.Visible = true;
            this.out时间列.VisibleIndex = 3;
            this.out时间列.Width = 92;
            // 
            // out操作列1
            // 
            this.out操作列1.Caption = "打开";
            this.out操作列1.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.out操作列1.Name = "out操作列1";
            this.out操作列1.Visible = true;
            this.out操作列1.VisibleIndex = 4;
            this.out操作列1.Width = 40;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "ssss";
            // 
            // out操作列2
            // 
            this.out操作列2.Caption = "删除";
            this.out操作列2.ColumnEdit = this.repositoryItemButtonEdit1;
            this.out操作列2.Name = "out操作列2";
            this.out操作列2.Visible = true;
            this.out操作列2.VisibleIndex = 5;
            this.out操作列2.Width = 40;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            serializableAppearanceObject1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline);
            serializableAppearanceObject1.Options.UseFont = true;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "3333", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // out操作列3
            // 
            this.out操作列3.Caption = "呼叫";
            this.out操作列3.Name = "out操作列3";
            this.out操作列3.Visible = true;
            this.out操作列3.VisibleIndex = 6;
            this.out操作列3.Width = 40;
            // 
            // out操作列4
            // 
            this.out操作列4.Caption = "已读";
            this.out操作列4.Name = "out操作列4";
            this.out操作列4.Visible = true;
            this.out操作列4.VisibleIndex = 7;
            this.out操作列4.Width = 40;
            // 
            // do清空
            // 
            this.do清空.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.do清空.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.do清空.Appearance.Options.UseFont = true;
            this.do清空.Location = new System.Drawing.Point(538, 10);
            this.do清空.Name = "do清空";
            this.do清空.Size = new System.Drawing.Size(100, 26);
            this.do清空.TabIndex = 28;
            this.do清空.Text = "清空";
            // 
            // in仅未读
            // 
            this.in仅未读.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.in仅未读.Location = new System.Drawing.Point(466, 13);
            this.in仅未读.Name = "in仅未读";
            this.in仅未读.Properties.Caption = "仅未读";
            this.in仅未读.Size = new System.Drawing.Size(66, 22);
            this.in仅未读.TabIndex = 27;
            // 
            // in查询条件
            // 
            this.in查询条件.Location = new System.Drawing.Point(0, 13);
            this.in查询条件.Name = "in查询条件";
            this.in查询条件.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "查询", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::UI.Properties.Resources.搜索, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.in查询条件.Size = new System.Drawing.Size(250, 24);
            this.in查询条件.TabIndex = 26;
            // 
            // F短信_短信箱
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.out辅助容器);
            this.Name = "F短信_短信箱";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Size = new System.Drawing.Size(658, 452);
            ((System.ComponentModel.ISupportInitialize)(this.out辅助容器)).EndInit();
            this.out辅助容器.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in仅未读.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in查询条件.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl out辅助容器;
        private DevExpress.XtraEditors.SimpleButton do清空;
        private DevExpress.XtraEditors.CheckEdit in仅未读;
        private DevExpress.XtraEditors.ButtonEdit in查询条件;
        private DevExpress.XtraGrid.GridControl out列表容器;
        private DevExpress.XtraGrid.Views.Grid.GridView out列表;
        private DevExpress.XtraGrid.Columns.GridColumn out位置列;
        private DevExpress.XtraGrid.Columns.GridColumn out对方号码列;
        private DevExpress.XtraGrid.Columns.GridColumn out内容列;
        private DevExpress.XtraGrid.Columns.GridColumn out时间列;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列1;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列2;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列3;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列4;
        private DevExpress.XtraEditors.SimpleButton do查询提示;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;


    }
}
