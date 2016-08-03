namespace UI.调度.短信
{
    partial class F短信_短信模板
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
            this.out辅助容器 = new DevExpress.XtraEditors.PanelControl();
            this.do查询提示 = new DevExpress.XtraEditors.SimpleButton();
            this.out列表容器 = new DevExpress.XtraGrid.GridControl();
            this.out列表 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.out关键字列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out内容列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out复制次数列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out内置短信列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.do增加模板 = new DevExpress.XtraEditors.SimpleButton();
            this.do重置次数 = new DevExpress.XtraEditors.SimpleButton();
            this.in查询条件 = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.out辅助容器)).BeginInit();
            this.out辅助容器.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in查询条件.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // out辅助容器
            // 
            this.out辅助容器.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.out辅助容器.Controls.Add(this.do查询提示);
            this.out辅助容器.Controls.Add(this.out列表容器);
            this.out辅助容器.Controls.Add(this.do增加模板);
            this.out辅助容器.Controls.Add(this.do重置次数);
            this.out辅助容器.Controls.Add(this.in查询条件);
            this.out辅助容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out辅助容器.Location = new System.Drawing.Point(10, 3);
            this.out辅助容器.Name = "out辅助容器";
            this.out辅助容器.Size = new System.Drawing.Size(522, 382);
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
            this.out列表容器.Size = new System.Drawing.Size(522, 339);
            this.out列表容器.TabIndex = 25;
            this.out列表容器.UseEmbeddedNavigator = true;
            this.out列表容器.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.out列表});
            // 
            // out列表
            // 
            this.out列表.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.out关键字列,
            this.out内容列,
            this.out复制次数列,
            this.out内置短信列,
            this.out操作列1,
            this.out操作列2,
            this.out操作列3});
            this.out列表.GridControl = this.out列表容器;
            this.out列表.Name = "out列表";
            // 
            // out关键字列
            // 
            this.out关键字列.Caption = "关键字";
            this.out关键字列.FieldName = "关键字描述";
            this.out关键字列.Name = "out关键字列";
            this.out关键字列.OptionsColumn.AllowEdit = false;
            this.out关键字列.Visible = true;
            this.out关键字列.VisibleIndex = 0;
            this.out关键字列.Width = 143;
            // 
            // out内容列
            // 
            this.out内容列.Caption = "内容";
            this.out内容列.FieldName = "内容";
            this.out内容列.Name = "out内容列";
            this.out内容列.OptionsColumn.AllowEdit = false;
            this.out内容列.Visible = true;
            this.out内容列.VisibleIndex = 1;
            this.out内容列.Width = 219;
            // 
            // out复制次数列
            // 
            this.out复制次数列.FieldName = "复制次数";
            this.out复制次数列.Name = "out复制次数列";
            this.out复制次数列.OptionsColumn.AllowEdit = false;
            this.out复制次数列.Visible = true;
            this.out复制次数列.VisibleIndex = 2;
            // 
            // out内置短信列
            // 
            this.out内置短信列.Caption = "内置短信";
            this.out内置短信列.FieldName = "内置短信";
            this.out内置短信列.Name = "out内置短信列";
            this.out内置短信列.OptionsColumn.AllowEdit = false;
            this.out内置短信列.Visible = true;
            this.out内置短信列.VisibleIndex = 3;
            this.out内置短信列.Width = 78;
            // 
            // out操作列1
            // 
            this.out操作列1.Caption = "复制";
            this.out操作列1.Name = "out操作列1";
            this.out操作列1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.out操作列1.OptionsColumn.ReadOnly = true;
            this.out操作列1.Visible = true;
            this.out操作列1.VisibleIndex = 4;
            this.out操作列1.Width = 52;
            // 
            // out操作列2
            // 
            this.out操作列2.Caption = "编辑";
            this.out操作列2.Name = "out操作列2";
            this.out操作列2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.out操作列2.OptionsColumn.ReadOnly = true;
            this.out操作列2.Visible = true;
            this.out操作列2.VisibleIndex = 5;
            this.out操作列2.Width = 51;
            // 
            // out操作列3
            // 
            this.out操作列3.Caption = "删除";
            this.out操作列3.Name = "out操作列3";
            this.out操作列3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.out操作列3.OptionsColumn.ReadOnly = true;
            this.out操作列3.Visible = true;
            this.out操作列3.VisibleIndex = 6;
            this.out操作列3.Width = 48;
            // 
            // do增加模板
            // 
            this.do增加模板.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.do增加模板.Location = new System.Drawing.Point(313, 10);
            this.do增加模板.Name = "do增加模板";
            this.do增加模板.Size = new System.Drawing.Size(100, 26);
            this.do增加模板.TabIndex = 28;
            this.do增加模板.Text = "增加模板";
            // 
            // do重置次数
            // 
            this.do重置次数.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.do重置次数.Location = new System.Drawing.Point(419, 10);
            this.do重置次数.Name = "do重置次数";
            this.do重置次数.Size = new System.Drawing.Size(100, 26);
            this.do重置次数.TabIndex = 27;
            this.do重置次数.Text = "重置次数";
            // 
            // in查询条件
            // 
            this.in查询条件.Location = new System.Drawing.Point(0, 13);
            this.in查询条件.Name = "in查询条件";
            this.in查询条件.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "查询", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::UI.Properties.Resources.搜索, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.in查询条件.Size = new System.Drawing.Size(250, 24);
            this.in查询条件.TabIndex = 26;
            // 
            // F短信_短信模板
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.out辅助容器);
            this.Name = "F短信_短信模板";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Size = new System.Drawing.Size(542, 388);
            ((System.ComponentModel.ISupportInitialize)(this.out辅助容器)).EndInit();
            this.out辅助容器.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in查询条件.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl out辅助容器;
        private DevExpress.XtraGrid.GridControl out列表容器;
        private DevExpress.XtraGrid.Views.Grid.GridView out列表;
        private DevExpress.XtraGrid.Columns.GridColumn out关键字列;
        private DevExpress.XtraGrid.Columns.GridColumn out内容列;
        private DevExpress.XtraGrid.Columns.GridColumn out复制次数列;
        private DevExpress.XtraGrid.Columns.GridColumn out内置短信列;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列1;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列2;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列3;
        private DevExpress.XtraEditors.SimpleButton do增加模板;
        private DevExpress.XtraEditors.SimpleButton do重置次数;
        private DevExpress.XtraEditors.ButtonEdit in查询条件;
        private DevExpress.XtraEditors.SimpleButton do查询提示;

    }
}
