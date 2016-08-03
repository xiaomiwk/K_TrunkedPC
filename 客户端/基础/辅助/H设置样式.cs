using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;

namespace UI.基础.辅助
{
    static class H设置样式
    {
        public static void 设置基本样式(TreeList __列表)
        {
            __列表.Appearance.HorzLine.BackColor = Color.FromArgb(224, 224, 224);
            __列表.Appearance.HorzLine.Options.UseBackColor = true;
            __列表.Appearance.VertLine.BackColor = Color.FromArgb(224, 224, 224);
            __列表.Appearance.VertLine.Options.UseBackColor = true;
            __列表.OptionsMenu.EnableColumnMenu = false;
            //__列表.OptionsSelection.EnableAppearanceFocusedCell = true;
            //__列表.OptionsSelection.EnableAppearanceFocusedRow = true;
            __列表.OptionsSelection.EnableAppearanceFocusedCell = false;
            __列表.OptionsSelection.EnableAppearanceFocusedRow = false;
            __列表.OptionsSelection.UseIndicatorForSelection = true;
            __列表.OptionsSelection.InvertSelection = true;
            __列表.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.CellFocus;
            __列表.RowHeight = 23;
        }

        public static void 设置基本样式(GridView __列表)
        {
            __列表.Appearance.HorzLine.BackColor = Color.FromArgb(224, 224, 224);
            __列表.Appearance.HorzLine.Options.UseBackColor = true;
            __列表.Appearance.VertLine.BackColor = Color.FromArgb(224, 224, 224);
            __列表.Appearance.VertLine.Options.UseBackColor = true;
            __列表.OptionsMenu.EnableColumnMenu = false;
            //__列表.OptionsSelection.EnableAppearanceFocusedCell = true;
            //__列表.OptionsSelection.EnableAppearanceFocusedRow = true;
            //__列表.OptionsSelection.InvertSelection = true;
            //__列表.OptionsSelection.EnableAppearanceHideSelection = true;
            __列表.OptionsSelection.EnableAppearanceFocusedCell = false;
            __列表.OptionsSelection.EnableAppearanceFocusedRow = false;
            __列表.OptionsSelection.InvertSelection = false;
            __列表.OptionsSelection.EnableAppearanceHideSelection = true;
            __列表.RowHeight = 25;

            __列表.OptionsCustomization.AllowColumnMoving = false;
            __列表.OptionsCustomization.AllowFilter = false;
            __列表.OptionsCustomization.AllowGroup = false;
            __列表.OptionsCustomization.AllowSort = false;
            __列表.OptionsMenu.EnableColumnMenu = false;
            __列表.OptionsView.ShowGroupPanel = false;
            __列表.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            __列表.OptionsView.ShowDetailButtons = false;
            __列表.OptionsFind.AllowFindPanel = false;
        }

        /// <summary>
        /// 非可编辑按钮
        /// </summary>
        /// <param name="__操作列集合"></param>
        public static void 设置操作列基本样式(params GridColumn[] __操作列集合)
        {
            foreach (var __操作列 in __操作列集合)
            {
                __操作列.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                __操作列.OptionsColumn.ReadOnly = true;
            }
        }

        /// <summary>
        /// 非可编辑按钮
        /// </summary>
        /// <param name="__操作列集合"></param>
        public static void 设置操作列基本样式(params TreeListColumn[] __操作列集合)
        {
            foreach (var __操作列 in __操作列集合)
            {
                __操作列.OptionsColumn.AllowSort = false;
                __操作列.OptionsColumn.ReadOnly = true;
                //__操作列.OptionsColumn.AllowEdit = false;
            }
        }

        public static void 设置基本样式(ControlNavigator __导航)
        {
            __导航.Buttons.Append.Visible = false;
            __导航.Buttons.CancelEdit.Visible = false;
            __导航.Buttons.Edit.Visible = false;
            __导航.Buttons.EndEdit.Visible = false;
            __导航.Buttons.Remove.Visible = false;
            __导航.TextStringFormat = "第 {0} 条, 共 {1} 条";
        }

    }
}
