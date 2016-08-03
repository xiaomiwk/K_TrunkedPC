namespace UI.调度.短信
{
    partial class F短信_合并发送短信_弹出窗口
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
            this.do选择模板 = new DevExpress.XtraEditors.SimpleButton();
            this.do发送 = new DevExpress.XtraEditors.SimpleButton();
            this.in短信内容 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.in短信内容.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // do选择模板
            // 
            this.do选择模板.Location = new System.Drawing.Point(122, 307);
            this.do选择模板.Name = "do选择模板";
            this.do选择模板.Size = new System.Drawing.Size(100, 26);
            this.do选择模板.TabIndex = 81;
            this.do选择模板.Text = "选择模板";
            // 
            // do发送
            // 
            this.do发送.Location = new System.Drawing.Point(228, 307);
            this.do发送.Name = "do发送";
            this.do发送.Size = new System.Drawing.Size(100, 26);
            this.do发送.TabIndex = 79;
            this.do发送.Text = "发送";
            // 
            // in短信内容
            // 
            this.in短信内容.Location = new System.Drawing.Point(54, 143);
            this.in短信内容.Name = "in短信内容";
            this.in短信内容.Size = new System.Drawing.Size(274, 154);
            this.in短信内容.TabIndex = 78;
            this.in短信内容.UseOptimizedRendering = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(12, 141);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 77;
            this.labelControl1.Text = "内容";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(12, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 74;
            this.labelControl2.Text = "号码";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(54, 16);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(274, 113);
            this.listBoxControl1.TabIndex = 83;
            // 
            // F短信_合并发送短信_弹出窗口
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(340, 343);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.do选择模板);
            this.Controls.Add(this.do发送);
            this.Controls.Add(this.in短信内容);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F短信_合并发送短信_弹出窗口";
            this.Text = "发送短信";
            ((System.ComponentModel.ISupportInitialize)(this.in短信内容.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton do选择模板;
        private DevExpress.XtraEditors.SimpleButton do发送;
        private DevExpress.XtraEditors.MemoEdit in短信内容;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
    }
}