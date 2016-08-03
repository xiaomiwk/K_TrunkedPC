using UI.基础;

namespace UI.调度.短信
{
    partial class F短信_短信模板_增加模板
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.f提示1 = new UI.基础.F提示();
            this.in内容 = new DevExpress.XtraEditors.MemoEdit();
            this.do保存 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.do返回 = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.in关键字 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.out标题 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.in内容.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.do返回.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in关键字.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // f提示1
            // 
            this.f提示1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f提示1.Location = new System.Drawing.Point(80, 310);
            this.f提示1.Name = "f提示1";
            this.f提示1.Size = new System.Drawing.Size(303, 39);
            this.f提示1.TabIndex = 15;
            this.f提示1.内容 = "关键字使用空格\" \"分隔";
            this.f提示1.图标 = global::UI.Properties.Resources.提示;
            // 
            // in内容
            // 
            this.in内容.Location = new System.Drawing.Point(91, 139);
            this.in内容.Name = "in内容";
            this.in内容.Size = new System.Drawing.Size(277, 116);
            this.in内容.TabIndex = 12;
            this.in内容.UseOptimizedRendering = true;
            // 
            // do保存
            // 
            this.do保存.Location = new System.Drawing.Point(268, 265);
            this.do保存.Name = "do保存";
            this.do保存.Size = new System.Drawing.Size(100, 26);
            this.do保存.TabIndex = 13;
            this.do保存.Text = "确定";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.do返回);
            this.panelControl1.Controls.Add(this.f提示1);
            this.panelControl1.Controls.Add(this.do保存);
            this.panelControl1.Controls.Add(this.in内容);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.in关键字);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.out标题);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(459, 363);
            this.panelControl1.TabIndex = 1;
            // 
            // do返回
            // 
            this.do返回.Location = new System.Drawing.Point(434, 5);
            this.do返回.Name = "do返回";
            this.do返回.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.do返回.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close, ">", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.do返回.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.do返回.Size = new System.Drawing.Size(20, 16);
            this.do返回.TabIndex = 43;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(91, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "内容";
            // 
            // in关键字
            // 
            this.in关键字.Location = new System.Drawing.Point(91, 82);
            this.in关键字.Name = "in关键字";
            this.in关键字.Size = new System.Drawing.Size(277, 24);
            this.in关键字.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(91, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 18);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "关键字";
            // 
            // out标题
            // 
            this.out标题.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.out标题.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(160)))), ((int)(((byte)(225)))));
            this.out标题.Location = new System.Drawing.Point(20, 19);
            this.out标题.Name = "out标题";
            this.out标题.Size = new System.Drawing.Size(80, 27);
            this.out标题.TabIndex = 8;
            this.out标题.Text = "新增模板";
            // 
            // F短信_短信模板_增加模板
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelControl1);
            this.Name = "F短信_短信模板_增加模板";
            this.Size = new System.Drawing.Size(459, 363);
            ((System.ComponentModel.ISupportInitialize)(this.in内容.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.do返回.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in关键字.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private F提示 f提示1;
        private DevExpress.XtraEditors.MemoEdit in内容;
        private DevExpress.XtraEditors.SimpleButton do保存;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit in关键字;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl out标题;
        private DevExpress.XtraEditors.ButtonEdit do返回;
    }
}
