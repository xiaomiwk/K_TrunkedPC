namespace UI.基础
{
    partial class F提示
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
            this.辅助容器 = new DevExpress.XtraEditors.PanelControl();
            this.out提示内容 = new DevExpress.XtraEditors.LabelControl();
            this.out提示图片 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.辅助容器)).BeginInit();
            this.辅助容器.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out提示图片.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // 辅助容器
            // 
            this.辅助容器.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.辅助容器.Controls.Add(this.out提示内容);
            this.辅助容器.Controls.Add(this.out提示图片);
            this.辅助容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.辅助容器.Location = new System.Drawing.Point(0, 0);
            this.辅助容器.Margin = new System.Windows.Forms.Padding(0);
            this.辅助容器.Name = "辅助容器";
            this.辅助容器.Size = new System.Drawing.Size(554, 45);
            this.辅助容器.TabIndex = 57;
            // 
            // out提示内容
            // 
            this.out提示内容.AllowHtmlString = true;
            this.out提示内容.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out提示内容.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.out提示内容.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.out提示内容.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.out提示内容.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.out提示内容.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.out提示内容.Location = new System.Drawing.Point(36, 6);
            this.out提示内容.Name = "out提示内容";
            this.out提示内容.Size = new System.Drawing.Size(505, 34);
            this.out提示内容.TabIndex = 1;
            // 
            // out提示图片
            // 
            this.out提示图片.EditValue = global::UI.Properties.Resources.提示;
            this.out提示图片.Location = new System.Drawing.Point(7, 5);
            this.out提示图片.Name = "out提示图片";
            this.out提示图片.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.out提示图片.Size = new System.Drawing.Size(20, 20);
            this.out提示图片.TabIndex = 0;
            // 
            // F提示
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.辅助容器);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "F提示";
            this.Size = new System.Drawing.Size(554, 45);
            ((System.ComponentModel.ISupportInitialize)(this.辅助容器)).EndInit();
            this.辅助容器.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.out提示图片.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl 辅助容器;
        public DevExpress.XtraEditors.LabelControl out提示内容;
        public DevExpress.XtraEditors.PictureEdit out提示图片;
    }
}
