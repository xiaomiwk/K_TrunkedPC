namespace UI.调度.地图
{
    partial class F地图_测距
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
            this.label1 = new System.Windows.Forms.Label();
            this.out第一步 = new System.Windows.Forms.Label();
            this.out第二步 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.out距离 = new System.Windows.Forms.Label();
            this.do重置 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "第一步： 选择起点";
            // 
            // out第一步
            // 
            this.out第一步.AutoSize = true;
            this.out第一步.BackColor = System.Drawing.Color.Green;
            this.out第一步.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.out第一步.ForeColor = System.Drawing.Color.White;
            this.out第一步.Location = new System.Drawing.Point(148, 9);
            this.out第一步.Name = "out第一步";
            this.out第一步.Size = new System.Drawing.Size(26, 17);
            this.out第一步.TabIndex = 1;
            this.out第一步.Text = "OK";
            // 
            // out第二步
            // 
            this.out第二步.AutoSize = true;
            this.out第二步.BackColor = System.Drawing.Color.Green;
            this.out第二步.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.out第二步.ForeColor = System.Drawing.Color.White;
            this.out第二步.Location = new System.Drawing.Point(148, 46);
            this.out第二步.Name = "out第二步";
            this.out第二步.Size = new System.Drawing.Size(26, 17);
            this.out第二步.TabIndex = 3;
            this.out第二步.Text = "OK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "第二步： 选择终点";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label6.Location = new System.Drawing.Point(26, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "结果： ";
            // 
            // out距离
            // 
            this.out距离.AutoSize = true;
            this.out距离.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.out距离.Location = new System.Drawing.Point(72, 84);
            this.out距离.Name = "out距离";
            this.out距离.Size = new System.Drawing.Size(54, 17);
            this.out距离.TabIndex = 5;
            this.out距离.Text = "1000米";
            // 
            // do重置
            // 
            this.do重置.Location = new System.Drawing.Point(99, 116);
            this.do重置.Name = "do重置";
            this.do重置.Size = new System.Drawing.Size(75, 23);
            this.do重置.TabIndex = 6;
            this.do重置.Text = "重置";
            // 
            // F地图_测距
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(194, 151);
            this.Controls.Add(this.do重置);
            this.Controls.Add(this.out距离);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.out第二步);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.out第一步);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F地图_测距";
            this.Text = "测距";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label out第一步;
        private System.Windows.Forms.Label out第二步;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label out距离;
        private DevExpress.XtraEditors.SimpleButton do重置;
    }
}