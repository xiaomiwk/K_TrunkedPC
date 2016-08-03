namespace UI.开发人员视图
{
    partial class F工具
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
            this.out导航 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.out导航)).BeginInit();
            this.SuspendLayout();
            // 
            // out导航
            // 
            this.out导航.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out导航.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out导航.Appearance.HeaderPanel.Options.UseFont = true;
            this.out导航.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.out导航.Location = new System.Drawing.Point(3, 3);
            this.out导航.Name = "out导航";
            this.out导航.BeginUnboundLoad();
            this.out导航.AppendNode(new object[] {
            "VXWORKX"}, -1);
            this.out导航.AppendNode(new object[] {
            "a"}, 0);
            this.out导航.AppendNode(new object[] {
            "b"}, 0);
            this.out导航.AppendNode(new object[] {
            "WINDOWS"}, -1);
            this.out导航.AppendNode(new object[] {
            "定制抓包"}, 3);
            this.out导航.AppendNode(new object[] {
            "通用抓包"}, 3);
            this.out导航.AppendNode(new object[] {
            "日志查看"}, 3);
            this.out导航.AppendNode(new object[] {
            "日志打包"}, 3);
            this.out导航.AppendNode(new object[] {
            "Windebug"}, 3);
            this.out导航.AppendNode(new object[] {
            "LINUX"}, -1);
            this.out导航.AppendNode(new object[] {
            "(手机)"}, -1);
            this.out导航.EndUnboundLoad();
            this.out导航.OptionsBehavior.Editable = false;
            this.out导航.OptionsView.ShowColumns = false;
            this.out导航.OptionsView.ShowIndicator = false;
            this.out导航.Size = new System.Drawing.Size(766, 439);
            this.out导航.TabIndex = 72;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "文档";
            this.treeListColumn2.FieldName = "treeListColumn1";
            this.treeListColumn2.MinWidth = 70;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // F工具
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.out导航);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "F工具";
            this.Size = new System.Drawing.Size(772, 445);
            ((System.ComponentModel.ISupportInitialize)(this.out导航)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTreeList.TreeList out导航;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
    }
}
