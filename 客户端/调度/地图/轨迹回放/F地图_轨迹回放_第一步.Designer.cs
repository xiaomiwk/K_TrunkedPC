using UI.公共;

namespace UI.调度.地图.轨迹回放
{
    partial class F地图_轨迹回放_第一步
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
            this.out辅助容器 = new DevExpress.XtraEditors.PanelControl();
            this.out列表容器 = new DevExpress.XtraGrid.GridControl();
            this.out列表 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.out名称列 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out操作列1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.do下一步 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.in资源 = new UI.公共.F资源();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.out辅助容器)).BeginInit();
            this.out辅助容器.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // out辅助容器
            // 
            this.out辅助容器.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.out辅助容器.Controls.Add(this.out列表容器);
            this.out辅助容器.Controls.Add(this.do下一步);
            this.out辅助容器.Controls.Add(this.labelControl1);
            this.out辅助容器.Controls.Add(this.in资源);
            this.out辅助容器.Controls.Add(this.labelControl6);
            this.out辅助容器.Controls.Add(this.dateEdit2);
            this.out辅助容器.Controls.Add(this.labelControl3);
            this.out辅助容器.Controls.Add(this.dateEdit1);
            this.out辅助容器.Controls.Add(this.labelControl4);
            this.out辅助容器.Controls.Add(this.labelControl5);
            this.out辅助容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out辅助容器.Location = new System.Drawing.Point(0, 0);
            this.out辅助容器.Name = "out辅助容器";
            this.out辅助容器.Size = new System.Drawing.Size(779, 566);
            this.out辅助容器.TabIndex = 0;
            // 
            // out列表容器
            // 
            this.out列表容器.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.out列表容器.Location = new System.Drawing.Point(414, 59);
            this.out列表容器.MainView = this.out列表;
            this.out列表容器.Name = "out列表容器";
            this.out列表容器.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorEdit1});
            this.out列表容器.Size = new System.Drawing.Size(340, 381);
            this.out列表容器.TabIndex = 42;
            this.out列表容器.UseEmbeddedNavigator = true;
            this.out列表容器.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.out列表});
            // 
            // out列表
            // 
            this.out列表.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.out名称列,
            this.out操作列1});
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
            this.out名称列.Width = 1279;
            // 
            // out操作列1
            // 
            this.out操作列1.Caption = "选择颜色";
            this.out操作列1.ColumnEdit = this.repositoryItemColorEdit1;
            this.out操作列1.Name = "out操作列1";
            this.out操作列1.Visible = true;
            this.out操作列1.VisibleIndex = 1;
            this.out操作列1.Width = 353;
            // 
            // repositoryItemColorEdit1
            // 
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            // 
            // do下一步
            // 
            this.do下一步.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.do下一步.Location = new System.Drawing.Point(654, 512);
            this.do下一步.Name = "do下一步";
            this.do下一步.Size = new System.Drawing.Size(100, 26);
            this.do下一步.TabIndex = 41;
            this.do下一步.Text = "下一步";
            this.do下一步.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.labelControl1.Location = new System.Drawing.Point(24, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 21);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "1. 选择号码";
            // 
            // in资源
            // 
            this.in资源.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.in资源.Location = new System.Drawing.Point(70, 59);
            this.in资源.Name = "in资源";
            this.in资源.Size = new System.Drawing.Size(275, 381);
            this.in资源.TabIndex = 39;
            this.in资源.关注可见 = true;
            this.in资源.关注菜单 = null;
            this.in资源.基站可见 = false;
            this.in资源.基站菜单 = null;
            this.in资源.显示关注复选框 = true;
            this.in资源.显示基站复选框 = true;
            this.in资源.显示部门复选框 = true;
            this.in资源.环境可见 = false;
            this.in资源.环境菜单 = null;
            this.in资源.部门菜单 = null;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelControl6.Location = new System.Drawing.Point(367, 234);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 27);
            this.labelControl6.TabIndex = 48;
            this.labelControl6.Text = "=>";
            // 
            // dateEdit2
            // 
            this.dateEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(453, 513);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(195, 24);
            this.dateEdit2.TabIndex = 47;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelControl3.Location = new System.Drawing.Point(370, 513);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 20);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "结束时间";
            // 
            // dateEdit1
            // 
            this.dateEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(153, 513);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(195, 24);
            this.dateEdit1.TabIndex = 45;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelControl4.Location = new System.Drawing.Point(70, 513);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 20);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "开始时间";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.labelControl5.Location = new System.Drawing.Point(24, 476);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 21);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "2. 选择时间";
            // 
            // F地图_轨迹回放_第一步
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.out辅助容器);
            this.Name = "F地图_轨迹回放_第一步";
            this.Size = new System.Drawing.Size(779, 566);
            ((System.ComponentModel.ISupportInitialize)(this.out辅助容器)).EndInit();
            this.out辅助容器.ResumeLayout(false);
            this.out辅助容器.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out列表容器)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.out列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl out辅助容器;
        private DevExpress.XtraGrid.GridControl out列表容器;
        private DevExpress.XtraGrid.Views.Grid.GridView out列表;
        private DevExpress.XtraGrid.Columns.GridColumn out名称列;
        private DevExpress.XtraGrid.Columns.GridColumn out操作列1;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1;
        private DevExpress.XtraEditors.SimpleButton do下一步;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private F资源 in资源;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;


    }
}
