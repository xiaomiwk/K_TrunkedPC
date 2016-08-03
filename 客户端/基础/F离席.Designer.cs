namespace UI.基础
{
    partial class F离席
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F离席));
            this.in密码 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.in账号 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.do关闭程序 = new DevExpress.XtraEditors.SimpleButton();
            this.out离席时间 = new DevExpress.XtraEditors.LabelControl();
            this.do重新登录 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.in密码.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in账号.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // in密码
            // 
            this.in密码.EditValue = "";
            this.in密码.EnterMoveNextControl = true;
            this.in密码.Location = new System.Drawing.Point(92, 77);
            this.in密码.Name = "in密码";
            this.in密码.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.in密码.Properties.Appearance.Options.UseFont = true;
            this.in密码.Properties.MaxLength = 20;
            this.in密码.Properties.UseSystemPasswordChar = true;
            this.in密码.Size = new System.Drawing.Size(216, 30);
            this.in密码.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelControl2.Location = new System.Drawing.Point(34, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 23);
            this.labelControl2.TabIndex = 128;
            this.labelControl2.Text = "密   码:";
            // 
            // in账号
            // 
            this.in账号.EnterMoveNextControl = true;
            this.in账号.Location = new System.Drawing.Point(92, 47);
            this.in账号.Name = "in账号";
            this.in账号.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.in账号.Properties.Appearance.Options.UseFont = true;
            this.in账号.Properties.MaxLength = 20;
            this.in账号.Size = new System.Drawing.Size(216, 30);
            this.in账号.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelControl1.Location = new System.Drawing.Point(34, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 23);
            this.labelControl1.TabIndex = 126;
            this.labelControl1.Text = "账   号:";
            // 
            // do关闭程序
            // 
            this.do关闭程序.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.do关闭程序.Appearance.Options.UseFont = true;
            this.do关闭程序.Location = new System.Drawing.Point(199, 115);
            this.do关闭程序.Name = "do关闭程序";
            this.do关闭程序.Size = new System.Drawing.Size(100, 26);
            this.do关闭程序.TabIndex = 4;
            this.do关闭程序.Text = "关闭程序";
            // 
            // out离席时间
            // 
            this.out离席时间.Appearance.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.out离席时间.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.out离席时间.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.out离席时间.Location = new System.Drawing.Point(34, 7);
            this.out离席时间.Name = "out离席时间";
            this.out离席时间.Size = new System.Drawing.Size(274, 27);
            this.out离席时间.TabIndex = 132;
            this.out离席时间.Text = "00:00:00";
            // 
            // do重新登录
            // 
            this.do重新登录.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.do重新登录.Appearance.Options.UseFont = true;
            this.do重新登录.Location = new System.Drawing.Point(92, 115);
            this.do重新登录.Name = "do重新登录";
            this.do重新登录.Size = new System.Drawing.Size(100, 26);
            this.do重新登录.TabIndex = 3;
            this.do重新登录.Text = "重新登录";
            // 
            // F离席
            // 
            this.AcceptButton = this.do重新登录;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(335, 152);
            this.Controls.Add(this.out离席时间);
            this.Controls.Add(this.do关闭程序);
            this.Controls.Add(this.in密码);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.in账号);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.do重新登录);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F离席";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "离席中";
            ((System.ComponentModel.ISupportInitialize)(this.in密码.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in账号.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit in密码;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit in账号;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton do关闭程序;
        private DevExpress.XtraEditors.LabelControl out离席时间;
        private DevExpress.XtraEditors.SimpleButton do重新登录;

    }
}