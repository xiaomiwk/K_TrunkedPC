namespace UI.����
{
    partial class F��ʾ
    {
        /// <summary> 
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region �����������ɵĴ���

        /// <summary> 
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.�������� = new DevExpress.XtraEditors.PanelControl();
            this.out��ʾ���� = new DevExpress.XtraEditors.LabelControl();
            this.out��ʾͼƬ = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.��������)).BeginInit();
            this.��������.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out��ʾͼƬ.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ��������
            // 
            this.��������.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.��������.Controls.Add(this.out��ʾ����);
            this.��������.Controls.Add(this.out��ʾͼƬ);
            this.��������.Dock = System.Windows.Forms.DockStyle.Fill;
            this.��������.Location = new System.Drawing.Point(0, 0);
            this.��������.Margin = new System.Windows.Forms.Padding(0);
            this.��������.Name = "��������";
            this.��������.Size = new System.Drawing.Size(554, 45);
            this.��������.TabIndex = 57;
            // 
            // out��ʾ����
            // 
            this.out��ʾ����.AllowHtmlString = true;
            this.out��ʾ����.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out��ʾ����.Appearance.Font = new System.Drawing.Font("΢���ź�", 9F);
            this.out��ʾ����.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.out��ʾ����.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.out��ʾ����.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.out��ʾ����.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.out��ʾ����.Location = new System.Drawing.Point(36, 6);
            this.out��ʾ����.Name = "out��ʾ����";
            this.out��ʾ����.Size = new System.Drawing.Size(505, 34);
            this.out��ʾ����.TabIndex = 1;
            // 
            // out��ʾͼƬ
            // 
            this.out��ʾͼƬ.EditValue = global::UI.Properties.Resources.��ʾ;
            this.out��ʾͼƬ.Location = new System.Drawing.Point(7, 5);
            this.out��ʾͼƬ.Name = "out��ʾͼƬ";
            this.out��ʾͼƬ.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.out��ʾͼƬ.Size = new System.Drawing.Size(20, 20);
            this.out��ʾͼƬ.TabIndex = 0;
            // 
            // F��ʾ
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.��������);
            this.Font = new System.Drawing.Font("΢���ź�", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "F��ʾ";
            this.Size = new System.Drawing.Size(554, 45);
            ((System.ComponentModel.ISupportInitialize)(this.��������)).EndInit();
            this.��������.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.out��ʾͼƬ.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl ��������;
        public DevExpress.XtraEditors.LabelControl out��ʾ����;
        public DevExpress.XtraEditors.PictureEdit out��ʾͼƬ;
    }
}
