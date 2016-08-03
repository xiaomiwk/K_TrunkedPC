namespace UI.调度.通话
{
    partial class F通话_通话记录
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.do查询提示 = new DevExpress.XtraEditors.SimpleButton();
            this.out列表容器 = new DevExpress.XtraGrid.GridControl();
            this.out列表 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.out通话类型列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out通话时间列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out通话时长列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.in查询条件 = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in查询条件.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // do查询提示
            // 
            this.do查询提示.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.do查询提示.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.do查询提示.Appearance.Options.UseBackColor = true;
            this.do查询提示.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.do查询提示.Image = global::UI.Properties.Resources.提示;
            this.do查询提示.Location = new System.Drawing.Point(266, 3);
            this.do查询提示.Name = "do查询提示";
            this.do查询提示.Size = new System.Drawing.Size(28, 23);
            this.do查询提示.TabIndex = 64;
            this.do查询提示.ToolTip = "点击查看查询示例";
            // 
            // out列表容器
            // 
            this.out列表容器.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out列表容器.Location = new System.Drawing.Point(10, 32);
            this.out列表容器.MainView = this.out列表;
            this.out列表容器.Name = "out列表容器";
            this.out列表容器.Size = new System.Drawing.Size(541, 407);
            this.out列表容器.TabIndex = 63;
            this.out列表容器.UseEmbeddedNavigator = true;
            this.out列表容器.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.out列表});
            // 
            // out列表
            // 
            this.out列表.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.out通话类型列,
            this.out通话时间列,
            this.out通话时长列,
            this.out操作列4});
            this.out列表.GridControl = this.out列表容器;
            this.out列表.Name = "out列表";
            // 
            // out通话类型列
            // 
            this.out通话类型列.AppearanceCell.Options.UseTextOptions = true;
            this.out通话类型列.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.out通话类型列.Caption = "通话类型";
            this.out通话类型列.FieldName = "通话类型";
            this.out通话类型列.Name = "out通话类型列";
            this.out通话类型列.OptionsColumn.AllowEdit = false;
            this.out通话类型列.Visible = true;
            this.out通话类型列.VisibleIndex = 3;
            this.out通话类型列.Width = 358;
            // 
            // out通话时间列
            // 
            this.out通话时间列.Caption = "通话时间";
            this.out通话时间列.DisplayFormat.FormatString = "MM-dd HH:mm";
            this.out通话时间列.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.out通话时间列.FieldName = "通话时间";
            this.out通话时间列.Name = "out通话时间列";
            this.out通话时间列.OptionsColumn.AllowEdit = false;
            this.out通话时间列.Visible = true;
            this.out通话时间列.VisibleIndex = 0;
            this.out通话时间列.Width = 507;
            // 
            // out通话时长列
            // 
            this.out通话时长列.Caption = "通话时长(时:分:秒)";
            this.out通话时长列.FieldName = "通话时长";
            this.out通话时长列.Name = "out通话时长列";
            this.out通话时长列.OptionsColumn.AllowEdit = false;
            this.out通话时长列.Visible = true;
            this.out通话时长列.VisibleIndex = 1;
            this.out通话时长列.Width = 446;
            // 
            // out操作列4
            // 
            this.out操作列4.Caption = "回放";
            this.out操作列4.Name = "out操作列4";
            this.out操作列4.Visible = true;
            this.out操作列4.VisibleIndex = 2;
            this.out操作列4.Width = 321;
            // 
            // in查询条件
            // 
            this.in查询条件.Location = new System.Drawing.Point(10, 6);
            this.in查询条件.Name = "in查询条件";
            this.in查询条件.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "查询", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::UI.Properties.Resources.搜索, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.in查询条件.Size = new System.Drawing.Size(250, 20);
            this.in查询条件.TabIndex = 62;
            // 
            // F查看通话记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(561, 449);
            this.Controls.Add(this.do查询提示);
            this.Controls.Add(this.out列表容器);
            this.Controls.Add(this.in查询条件);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "F查看通话记录";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "通话记录";
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in查询条件.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton do查询提示;
        private DevExpress.XtraGrid.GridControl out列表容器;
        private DevExpress.XtraGrid.Views.Grid.GridView out列表;
        private DevExpress.XtraGrid.Columns.GridColumn out通话类型列;
        private DevExpress.XtraGrid.Columns.GridColumn out通话时间列;
        private DevExpress.XtraGrid.Columns.GridColumn out通话时长列;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列4;
        private DevExpress.XtraEditors.ButtonEdit in查询条件;
    }
}