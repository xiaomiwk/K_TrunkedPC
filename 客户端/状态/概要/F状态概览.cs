using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace UI.业务.状态
{
    [ToolboxItem(false)]
    public partial class F状态概览 : UserControl
    {
        public F状态概览()
        {
            InitializeComponent();
            this.out机房容器.DoubleClick += out机房容器_DoubleClick;
            this.out基站容器.DoubleClick += out基站_DoubleClick;

            this.out基站列表.Controls.Clear();
            for (int i = 1; i <= 150; i++)
            {
                var __基站 = new DevExpress.XtraEditors.LabelControl();
                __基站.Appearance.BackColor = System.Drawing.Color.Green;
                __基站.Appearance.Font = new System.Drawing.Font("微软雅黑", 8F);
                __基站.Appearance.ForeColor = System.Drawing.Color.White;
                __基站.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                __基站.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
                __基站.Location = new System.Drawing.Point(1, 1);
                __基站.Margin = new System.Windows.Forms.Padding(1);
                __基站.Name = "labelControl21";
                __基站.Size = new System.Drawing.Size(200, 18);
                __基站.TabIndex = 61;
                __基站.Text = "XXXXX区XXXXXXXXXXXXXXX站" + i.ToString();

                this.out基站列表.Controls.Add(__基站);
            }
        }

        void out基站_DoubleClick(object sender, EventArgs e)
        {
            new F状态概览_基站() { StartPosition = FormStartPosition.CenterParent }.ShowDialog();
        }

        void out机房容器_DoubleClick(object sender, EventArgs e)
        {
            new F状态概览_机房设备().ShowDialog();
        }
    }
}
