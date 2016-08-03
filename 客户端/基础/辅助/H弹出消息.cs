using System.Windows.Forms;

namespace UI.基础.辅助
{
    static class H弹出消息
    {
        public static DialogResult 显示(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            text = text ?? string.Empty;
            return DevExpress.XtraEditors.XtraMessageBox.Show(text, caption, buttons);
        }

        public static DialogResult 显示(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            text = text ?? string.Empty;
            return DevExpress.XtraEditors.XtraMessageBox.Show(text, caption, buttons, icon);
        }

        public static DialogResult 显示(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton 默认按钮)
        {
            text = text ?? string.Empty;
            return DevExpress.XtraEditors.XtraMessageBox.Show(text, caption, buttons, icon, 默认按钮);
        }

        //public static void 显示超长信息(string caption, string text) 
        //{
        //    new F显示超长信息(caption, text).ShowDialog();
        //}
    }
}
