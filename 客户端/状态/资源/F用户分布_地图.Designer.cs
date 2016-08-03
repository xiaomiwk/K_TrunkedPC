using 显示地图;

namespace UI.业务.状态
{
    partial class F用户分布_地图
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
            this.f地图1 = new 显示地图.F地图();
            this.SuspendLayout();
            // 
            // f地图1
            // 
            this.f地图1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f地图1.Location = new System.Drawing.Point(0, 0);
            this.f地图1.Name = "f地图1";
            this.f地图1.Size = new System.Drawing.Size(884, 580);
            this.f地图1.TabIndex = 2;
            this.f地图1.启用默认缩放控件 = true;
            this.f地图1.当前层级 = 8;
            this.f地图1.按钮文字颜色 = System.Drawing.Color.White;
            this.f地图1.按钮背景颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(136)))));
            this.f地图1.显示图片调试信息 = false;
            this.f地图1.缩放控件位置 = new System.Drawing.Point(3, 5);
            // 
            // F用户分布_地图
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 580);
            this.Controls.Add(this.f地图1);
            this.Name = "F用户分布_地图";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "地图概览";
            this.ResumeLayout(false);

        }

        #endregion

        private F地图 f地图1;
    }
}