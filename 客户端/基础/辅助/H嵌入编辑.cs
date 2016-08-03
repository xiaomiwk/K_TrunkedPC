using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace UI.基础.辅助
{
    public static class H嵌入编辑
    {
        public static RepositoryItemButtonEdit 生成操作(Dictionary<string, string> __命令描述, ButtonPressedEventHandler __命令动作)
        {
            var __do操作 = new RepositoryItemButtonEdit
            {
                AutoHeight = false,
                ButtonsStyle = BorderStyles.HotFlat,
                TextEditStyle = TextEditStyles.HideTextEditor
            };
            __do操作.Buttons.Clear();
            foreach (var kv in __命令描述)
            {
                var __do操作按钮 = new EditorButton(ButtonPredefines.Glyph) { Caption = kv.Key, ToolTip = kv.Value };
                __do操作.Buttons.Add(__do操作按钮);
            }
            __do操作.ButtonClick += __命令动作;
            //__do操作.Disposed += (object sender, EventArgs e) => __do操作.ButtonClick -=__do操作_ButtonClick;
            return __do操作;
        }

        public static RepositoryItemButtonEdit 生成按钮(string __命令, string __命令描述, ButtonPressedEventHandler __命令动作, Image __图标 = null)
        {
            var __do操作 = new RepositoryItemButtonEdit
            {
                AutoHeight = false,
                ButtonsStyle = BorderStyles.UltraFlat,
                TextEditStyle = TextEditStyles.HideTextEditor,
            };
            __do操作.Buttons.Clear();
            var __do操作按钮 = new EditorButton(ButtonPredefines.Glyph) { Caption = __命令, ToolTip = __命令描述, Image = __图标 };
            if(__do操作按钮.Image != null && string.IsNullOrEmpty(__do操作按钮.ToolTip))
            {
                __do操作按钮.ToolTip = __命令;
            }
            __do操作按钮.Appearance.BackColor = Color.Transparent;
            __do操作.Buttons.Add(__do操作按钮);
            __do操作.ButtonClick += __命令动作;
            //__do操作.Disposed += (object sender, EventArgs e) => __do操作.ButtonClick -=__do操作_ButtonClick;
            return __do操作;
        }

        public static RepositoryItemCheckEdit 生成选框(string __命令, EventHandler __命令动作, CheckStyles __样式)
        {
            var __do操作 = new RepositoryItemCheckEdit
            {
                CheckStyle = __样式,
                NullStyle = StyleIndeterminate.Unchecked,
            };
            if (__样式 == CheckStyles.Radio)
            {
                __do操作.RadioGroupIndex = 0;
            }
            else
            {
                __do操作.RadioGroupIndex = -1;
            }
            __do操作.CheckedChanged += __命令动作;
            return __do操作;
        }


    }
}
