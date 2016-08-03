using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;

namespace UI.基础.辅助
{
    static class H拖动操作
    {
        public static void 单号码输入框_DragDrop(object sender, DragEventArgs e)
        {
            var __目标 = sender as TextEdit;
            var __字符串 = e.Data.GetData(typeof(string)) as string;
            if (__字符串 != null)
            {
                __目标.Text = __字符串;
                return;
            }
            var __Node = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;
            if (__Node != null)
            {
                __目标.Text = __Node.GetDisplayText(1);
                return;
            }
        }

        public static void 多号码输入框_DragDrop(object sender, DragEventArgs e)
        {
            var __目标 = sender as TextEdit;
            var __字符串 = e.Data.GetData(typeof(string)) as string;
            if (__字符串 != null)
            {
                __目标.Text = (__目标.Text.Trim() + Environment.NewLine + __字符串).Trim();
                return;
            }
            var __Node = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;
            if (__Node != null)
            {
                __目标.Text = (__目标.Text.Trim() + Environment.NewLine + __Node.GetDisplayText(1)).Trim();
                return;
            }
        }

        public static void 号码输入框_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

    }
}
