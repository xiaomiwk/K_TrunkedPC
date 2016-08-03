namespace UI.开发人员视图
{
    partial class F开发人员视图
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F开发人员视图));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.f文档与工具1 = new UI.开发人员视图.F工具();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.out业务 = new UI.工程人员视图.F通用交互();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.out设备 = new UI.工程人员视图.F通用交互();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage6.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(921, 568);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage6,
            this.xtraTabPage3});
            this.xtraTabControl1.TabPageWidth = 120;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.f文档与工具1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.xtraTabPage2.Size = new System.Drawing.Size(915, 539);
            this.xtraTabPage2.Text = "工具";
            // 
            // f文档与工具1
            // 
            this.f文档与工具1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f文档与工具1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.f文档与工具1.Location = new System.Drawing.Point(10, 10);
            this.f文档与工具1.Name = "f文档与工具1";
            this.f文档与工具1.Size = new System.Drawing.Size(895, 519);
            this.f文档与工具1.TabIndex = 0;
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.out业务);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Padding = new System.Windows.Forms.Padding(10);
            this.xtraTabPage6.Size = new System.Drawing.Size(915, 539);
            this.xtraTabPage6.Text = "公用";
            // 
            // out业务
            // 
            this.out业务.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out业务.Location = new System.Drawing.Point(10, 10);
            this.out业务.Name = "out业务";
            this.out业务.Size = new System.Drawing.Size(895, 519);
            this.out业务.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.out设备);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Padding = new System.Windows.Forms.Padding(10);
            this.xtraTabPage3.Size = new System.Drawing.Size(915, 539);
            this.xtraTabPage3.Text = "设备";
            // 
            // out设备
            // 
            this.out设备.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out设备.Location = new System.Drawing.Point(10, 10);
            this.out设备.Name = "out设备";
            this.out设备.Size = new System.Drawing.Size(895, 519);
            this.out设备.TabIndex = 0;
            // 
            // F开发人员视图
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 568);
            this.Controls.Add(this.xtraTabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "F开发人员视图";
            this.Text = "开发人员视图";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage6.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private 工程人员视图.F通用交互 out业务;
        private 工程人员视图.F通用交互 out设备;
        private F工具 f文档与工具1;


    }
}