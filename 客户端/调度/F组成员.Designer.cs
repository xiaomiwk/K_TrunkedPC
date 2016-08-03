namespace UI.公共
{
    partial class F组成员
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
            this.out列表容器 = new DevExpress.XtraGrid.GridControl();
            this.out列表 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.out名称列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out号码列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out职位列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.in视图 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in视图.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // out列表容器
            // 
            this.out列表容器.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out列表容器.Location = new System.Drawing.Point(10, 32);
            this.out列表容器.MainView = this.out列表;
            this.out列表容器.Name = "out列表容器";
            this.out列表容器.Size = new System.Drawing.Size(664, 407);
            this.out列表容器.TabIndex = 31;
            this.out列表容器.UseEmbeddedNavigator = true;
            this.out列表容器.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.out列表});
            // 
            // out列表
            // 
            this.out列表.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.out名称列,
            this.out号码列,
            this.out职位列,
            this.out操作列1,
            this.out操作列2,
            this.out操作列3});
            this.out列表.GridControl = this.out列表容器;
            this.out列表.Name = "out列表";
            // 
            // out名称列
            // 
            this.out名称列.Caption = "名称";
            this.out名称列.FieldName = "名称";
            this.out名称列.Name = "out名称列";
            this.out名称列.OptionsColumn.AllowEdit = false;
            this.out名称列.Visible = true;
            this.out名称列.VisibleIndex = 0;
            this.out名称列.Width = 167;
            // 
            // out号码列
            // 
            this.out号码列.Caption = "号码";
            this.out号码列.FieldName = "号码";
            this.out号码列.Name = "out号码列";
            this.out号码列.OptionsColumn.AllowEdit = false;
            this.out号码列.Visible = true;
            this.out号码列.VisibleIndex = 1;
            this.out号码列.Width = 79;
            // 
            // out职位列
            // 
            this.out职位列.Caption = "状态";
            this.out职位列.FieldName = "状态";
            this.out职位列.Name = "out职位列";
            this.out职位列.OptionsColumn.AllowEdit = false;
            this.out职位列.Visible = true;
            this.out职位列.VisibleIndex = 2;
            this.out职位列.Width = 253;
            // 
            // out操作列1
            // 
            this.out操作列1.Caption = "呼叫";
            this.out操作列1.Name = "out操作列1";
            this.out操作列1.Visible = true;
            this.out操作列1.VisibleIndex = 3;
            this.out操作列1.Width = 65;
            // 
            // out操作列2
            // 
            this.out操作列2.Caption = "发短信";
            this.out操作列2.Name = "out操作列2";
            this.out操作列2.Visible = true;
            this.out操作列2.VisibleIndex = 4;
            this.out操作列2.Width = 59;
            // 
            // out操作列3
            // 
            this.out操作列3.Caption = "常用";
            this.out操作列3.Name = "out操作列3";
            this.out操作列3.Visible = true;
            this.out操作列3.VisibleIndex = 5;
            this.out操作列3.Width = 73;
            // 
            // in视图
            // 
            this.in视图.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.in视图.Location = new System.Drawing.Point(11, 6);
            this.in视图.Name = "in视图";
            this.in视图.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.in视图.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.in视图.Properties.Items.AddRange(new object[] {
            "列表",
            "详细列表",
            "平铺",
            "详细平铺"});
            this.in视图.Properties.ReadOnly = true;
            this.in视图.Size = new System.Drawing.Size(143, 20);
            this.in视图.TabIndex = 32;
            // 
            // F查看成员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 449);
            this.Controls.Add(this.in视图);
            this.Controls.Add(this.out列表容器);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "F查看成员";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "成员";
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in视图.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl out列表容器;
        private DevExpress.XtraGrid.Views.Grid.GridView out列表;
        private DevExpress.XtraGrid.Columns.GridColumn out名称列;
        private DevExpress.XtraGrid.Columns.GridColumn out职位列;
        private DevExpress.XtraGrid.Columns.GridColumn out号码列;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列1;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列2;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列3;
        private DevExpress.XtraEditors.ComboBoxEdit in视图;
    }
}