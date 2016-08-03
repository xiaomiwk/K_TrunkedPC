using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace UI.基础.辅助
{
    class H查询框
    {
        private readonly ButtonEdit _查询条件;

        private readonly GridView _列表;

        private readonly Action _查询;

        public H查询框(ButtonEdit __查询条件, GridView __列表, Action __查询 = null)
        {
            this._查询条件 = __查询条件;
            this._列表 = __列表;
            this._查询 = __查询;
            this._查询条件.Properties.Buttons[1].Visible = false;
            this._查询条件.Properties.Buttons[1].IsLeft = true;
            this._查询条件.AllowDrop = true;
            this._查询条件.ButtonClick += 号码查询_Click;
            this._查询条件.KeyDown += in查询条件_KeyDown;
            this._查询条件.DragEnter += H拖动操作.号码输入框_DragEnter;
            this._查询条件.DragDrop += H拖动操作.单号码输入框_DragDrop;
            this._查询条件.TextChanged += _查询条件_TextChanged;
        }

        void _查询条件_TextChanged(object sender, EventArgs e)
        {
            if (this._查询条件.Text == string.Empty)
            {
                开始查询();
                this._查询条件.Properties.Buttons[1].Visible = false;
            }
            else
            {
                this._查询条件.Properties.Buttons[1].Visible = true;
            }
        }

        public void 查询(string __条件)
        {
            this._查询条件.Text = __条件;
            开始查询();
        }

        void in查询条件_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                开始查询();
            }
        }

        void 号码查询_Click(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                开始查询();
            }
            else
            {
                _查询条件.Text = string.Empty;
            }
        }

        void 开始查询()
        {
            var __查询条件 = _查询条件.Text.Trim();
            if(_查询 != null)
            {
                _查询();
            }
            else
            {
                _列表.ApplyFindFilter(__查询条件);
            }

        }
    }
}
