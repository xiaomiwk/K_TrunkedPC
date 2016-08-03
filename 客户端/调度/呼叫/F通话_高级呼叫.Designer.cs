namespace UI.调度.通话
{
    partial class F高级呼叫
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
            this.out容器 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.out呼叫操作 = new System.Windows.Forms.Panel();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.do呼叫 = new DevExpress.XtraEditors.SimpleButton();
            this.out默认号码 = new System.Windows.Forms.Panel();
            this.do手动输入号码 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.out容器.SuspendLayout();
            this.out呼叫操作.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.out默认号码.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.do手动输入号码.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // out容器
            // 
            this.out容器.Controls.Add(this.out呼叫操作);
            this.out容器.Controls.Add(this.out默认号码);
            this.out容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out容器.Location = new System.Drawing.Point(0, 0);
            this.out容器.Name = "out容器";
            this.out容器.Size = new System.Drawing.Size(230, 121);
            this.out容器.TabIndex = 0;
            // 
            // out呼叫操作
            // 
            this.out呼叫操作.Controls.Add(this.checkEdit3);
            this.out呼叫操作.Controls.Add(this.checkEdit2);
            this.out呼叫操作.Controls.Add(this.checkEdit1);
            this.out呼叫操作.Controls.Add(this.do呼叫);
            this.out呼叫操作.Dock = System.Windows.Forms.DockStyle.Top;
            this.out呼叫操作.Location = new System.Drawing.Point(0, 42);
            this.out呼叫操作.Name = "out呼叫操作";
            this.out呼叫操作.Size = new System.Drawing.Size(230, 78);
            this.out呼叫操作.TabIndex = 39;
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(140, 6);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "限定基站";
            this.checkEdit3.Size = new System.Drawing.Size(80, 19);
            this.checkEdit3.TabIndex = 37;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(80, 6);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "紧急";
            this.checkEdit2.Size = new System.Drawing.Size(54, 19);
            this.checkEdit2.TabIndex = 36;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(20, 6);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "广播";
            this.checkEdit1.Size = new System.Drawing.Size(54, 19);
            this.checkEdit1.TabIndex = 35;
            // 
            // do呼叫
            // 
            this.do呼叫.Location = new System.Drawing.Point(19, 40);
            this.do呼叫.Name = "do呼叫";
            this.do呼叫.Size = new System.Drawing.Size(191, 30);
            this.do呼叫.TabIndex = 34;
            this.do呼叫.Text = "呼叫";
            // 
            // out默认号码
            // 
            this.out默认号码.Controls.Add(this.do手动输入号码);
            this.out默认号码.Controls.Add(this.labelControl2);
            this.out默认号码.Dock = System.Windows.Forms.DockStyle.Top;
            this.out默认号码.Location = new System.Drawing.Point(0, 0);
            this.out默认号码.Name = "out默认号码";
            this.out默认号码.Size = new System.Drawing.Size(230, 42);
            this.out默认号码.TabIndex = 38;
            // 
            // do手动输入号码
            // 
            this.do手动输入号码.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.do手动输入号码.Cursor = System.Windows.Forms.Cursors.Hand;
            this.do手动输入号码.EditValue = global::UI.Properties.Resources.键盘;
            this.do手动输入号码.Location = new System.Drawing.Point(204, 2);
            this.do手动输入号码.Name = "do手动输入号码";
            this.do手动输入号码.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.do手动输入号码.Properties.Appearance.Options.UseBackColor = true;
            this.do手动输入号码.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.do手动输入号码.Properties.ShowMenu = false;
            this.do手动输入号码.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.do手动输入号码.Size = new System.Drawing.Size(25, 25);
            this.do手动输入号码.TabIndex = 36;
            this.do手动输入号码.ToolTip = "点击手动输入号码";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(8, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 16);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "XXX区交警一中队";
            // 
            // F高级呼叫
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(230, 121);
            this.Controls.Add(this.out容器);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F高级呼叫";
            this.Text = "高级呼叫";
            this.out容器.ResumeLayout(false);
            this.out呼叫操作.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.out默认号码.ResumeLayout(false);
            this.out默认号码.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.do手动输入号码.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl out容器;
        private System.Windows.Forms.Panel out默认号码;
        private DevExpress.XtraEditors.PictureEdit do手动输入号码;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel out呼叫操作;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton do呼叫;



    }
}