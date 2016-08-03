using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DTO.公共;

namespace UI.公共
{
    [ToolboxItem(false)]
    public partial class F资源 : DevExpress.XtraEditors.XtraUserControl
    {
        private TreeListHitInfo _HitInfo;

        public ContextMenuStrip 关注菜单
        {
            get { return this.out订阅列表.ContextMenuStrip; }
            set { this.out订阅列表.ContextMenuStrip = value; }
        }

        public ContextMenuStrip 部门菜单
        {
            get { return this.out部门列表.ContextMenuStrip; }
            set { this.out部门列表.ContextMenuStrip = value; }
        }

        public ContextMenuStrip 基站菜单
        {
            get { return this.out基站列表.ContextMenuStrip; }
            set { this.out基站列表.ContextMenuStrip = value; }
        }

        public ContextMenuStrip 环境菜单
        {
            get { return this.out环境列表.ContextMenuStrip; }
            set { this.out环境列表.ContextMenuStrip = value; }
        }

        public bool 关注可见
        {
            get { return this.out关注.PageVisible; }
            set { this.out关注.PageVisible = value; }
        }

        public bool 基站可见
        {
            get { return this.out基站.PageVisible; }
            set { this.out基站.PageVisible = value; }
        }

        public bool 环境可见
        {
            get { return this.out环境.PageVisible; }
            set { this.out环境.PageVisible = value; }
        }

        public bool 显示关注复选框
        {
            get { return this.out订阅列表.OptionsView.ShowCheckBoxes; }
            set { this.out订阅列表.OptionsView.ShowCheckBoxes = value; }
        }

        public bool 显示部门复选框
        {
            get { return this.out部门列表.OptionsView.ShowCheckBoxes; }
            set { this.out部门列表.OptionsView.ShowCheckBoxes = value; }
        }

        public bool 显示基站复选框
        {
            get { return this.out基站列表.OptionsView.ShowCheckBoxes; }
            set { this.out基站列表.OptionsView.ShowCheckBoxes = value; }
        }

        public F资源()
        {
            InitializeComponent();
            this.out环境.PageVisible = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
            {
                return;
            }
            初始化关注列表();
            初始化部门列表();
            初始化基站列表();
            初始化环境列表();

            var __所有列表 = new List<TreeList>
                {
                     this.out订阅列表,
                     this.out部门列表,
                     this.out基站列表,
                     this.out环境列表,
                };
            __所有列表.ForEach(q =>
                {
                    q.ExpandAll();
                    q.MouseDown += this.out列表_MouseDown;
                    q.MouseMove += this.out列表_MouseMove;
                    q.AfterCheckNode += out列表_AfterCheckNode;
                    q.BeforeCheckNode += out列表_BeforeCheckNode;
                });

            this.out订阅列表.MouseDoubleClick += out关注列表_MouseDoubleClick;
        }

        void out关注列表_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var __列表 = sender as TreeList;
            _HitInfo = __列表.CalcHitInfo(new Point(e.X, e.Y));
            if (_HitInfo.Node != null && _HitInfo.Node.Tag != null)
            {
                if (!__列表.OptionsView.ShowCheckBoxes || _HitInfo.Node.Checked)
                {
                    On双击业务对象(_HitInfo.Node.Tag);
                }
            }
        }

        private void 初始化环境列表()
        {
            this.out环境列表.BeginUnboundLoad();
            this.out环境列表.AppendNode(new object[] { "丽水市" }, -1);
            this.out环境列表.AppendNode(new object[] { "莲都区" }, 0);
            this.out环境列表.AppendNode(new object[] { "XXX路" }, 1);
            this.out环境列表.AppendNode(new object[] { "001号道路摄像头" }, 2);
            this.out环境列表.AppendNode(new object[] { "002号道路摄像头" }, 2);
            this.out环境列表.AppendNode(new object[] { "003号道路摄像头" }, 2);
            this.out环境列表.AppendNode(new object[] { "YYY路" }, 1);
            this.out环境列表.AppendNode(new object[] { "ZZZ路" }, 1);
            this.out环境列表.AppendNode(new object[] { "五都区" }, 0);
            this.out环境列表.AppendNode(new object[] { "六都区" }, 0);
            this.out环境列表.EndUnboundLoad();
        }

        private void 初始化基站列表()
        {
            this.out基站列表.BeginUnboundLoad();
            this.out基站列表.AppendNode(new object[] { "丽水市" }, -1);
            this.out基站列表.AppendNode(new object[] { "莲都区" }, 0);
            this.out基站列表.AppendNode(new object[] { "XXX街道基站" }, 1, new M基站 { Id = 1, 名称 = "XXX街道基站" });
            this.out基站列表.AppendNode(new object[] { "YYY街道基站" }, 1, new M基站 { Id = 2, 名称 = "YYY街道基站" });
            this.out基站列表.AppendNode(new object[] { "ZZZ街道基站" }, 1, new M基站 { Id = 3, 名称 = "ZZZ街道基站" });
            this.out基站列表.AppendNode(new object[] { "五都区" }, 0);
            this.out基站列表.AppendNode(new object[] { "六都区" }, 0);
            this.out基站列表.EndUnboundLoad();
        }

        private void 初始化部门列表()
        {
            this.out部门列表.BeginUnboundLoad();
            初始化列表(this.out部门列表, H模拟数据.根部门, null);
            this.out部门列表.EndUnboundLoad();
        }

        private void 初始化列表(TreeList __列表, M部门 __部门, TreeListNode __父节点)
        {
            var __部门节点 = __列表.AppendNode(new object[] { __部门.名称 }, __父节点, __部门);
            foreach (var __下属部门 in __部门.下属部门)
            {
                初始化列表(__列表, __下属部门, __部门节点);
            }
            if (__部门.组号列表.Count > 0)
            {
                var __组号列表节点 = __列表.AppendNode(new object[] { "组号" }, __部门节点);
                foreach (var __组号 in __部门.组号列表)
                {
                    __列表.AppendNode(new object[] { __组号.名称 }, __组号列表节点, __组号);
                }
            }
            if (__部门.个号列表.Count > 0)
            {
                var __个号列表节点 = __列表.AppendNode(new object[] { "个号" }, __部门节点);
                foreach (var __个号 in __部门.个号列表)
                {
                    __列表.AppendNode(new object[] { __个号.名称 }, __个号列表节点, __个号);
                }
            }
        }

        private void 初始化关注列表()
        {
            this.out订阅列表.BeginUnboundLoad();
            var __常用节点 = this.out订阅列表.AppendNode(new object[] { "预案" }, -1);
            var __常用组号节点 = this.out订阅列表.AppendNode(new object[] { "组号" }, __常用节点.Id);
            H模拟数据.关注组号列表.ForEach(q => this.out订阅列表.AppendNode(new object[] { q.名称 }, __常用组号节点.Id, q));
            var __常用个号节点 = this.out订阅列表.AppendNode(new object[] { "个号" }, __常用节点.Id);
            H模拟数据.关注个号列表.ForEach(q => this.out订阅列表.AppendNode(new object[] { q.名称 }, __常用个号节点.Id, q));

            var __临时节点 = this.out订阅列表.AppendNode(new object[] { "临时" }, -1);
            var __临时组号节点 = this.out订阅列表.AppendNode(new object[] { "组号" }, __临时节点.Id);
            this.out订阅列表.AppendNode(new object[] { "XXX区特警一中队" }, __临时组号节点.Id);
            this.out订阅列表.AppendNode(new object[] { "XXX区消防一中队" }, __临时组号节点.Id);
            this.out订阅列表.AppendNode(new object[] { "XXX区城管一中队" }, __临时组号节点.Id);
            var __临时个号节点 = this.out订阅列表.AppendNode(new object[] { "个号" }, __临时节点.Id);
            this.out订阅列表.AppendNode(new object[] { "XXX区特警一中队队员001" }, __临时个号节点.Id);
            this.out订阅列表.AppendNode(new object[] { "XXX区特警一中队队员001" }, __临时个号节点.Id);
            this.out订阅列表.AppendNode(new object[] { "XXX区特警一中队队员001" }, __临时个号节点.Id);
            this.out订阅列表.EndUnboundLoad();
        }

        void out列表_BeforeCheckNode(object sender, CheckNodeEventArgs e)
        {
        }

        void out列表_AfterCheckNode(object sender, NodeEventArgs e)
        {
            var __原始节点 = e.Node;
            if (__原始节点.Checked)
            {
                On增加选择(__原始节点.GetDisplayText(0));
                var __业务对象 = __原始节点.Tag;
                if (__业务对象 != null)
                {
                    On选择业务对象(__业务对象);
                }
                设置选中_子节点(__原始节点);
                设置选中_父节点(__原始节点);

            }
            else
            {
                On删除选择(__原始节点.GetDisplayText(0));
                var __业务对象 = __原始节点.Tag;
                if (__业务对象 != null)
                {
                    On取消选择业务对象(__业务对象);
                }
                设置未选中_子节点(__原始节点);
                设置未选中_父节点(__原始节点);
            }
        }

        private void 设置未选中_父节点(TreeListNode __原始节点)
        {
            if (__原始节点.ParentNode != null)
            {
                __原始节点.ParentNode.Checked = false;
                设置未选中_父节点(__原始节点.ParentNode);
            }
        }

        private void 设置未选中_子节点(TreeListNode __原始节点)
        {
            if (__原始节点.HasChildren)
            {
                foreach (TreeListNode __node in __原始节点.Nodes)
                {
                    if (__node.Checked)
                    {
                        On删除选择(__node.GetDisplayText(0));
                        var __子业务对象 = __node.Tag;
                        if (__子业务对象 != null)
                        {
                            On取消选择业务对象(__子业务对象);
                        }
                        __node.Checked = false;
                        设置未选中_子节点(__node);
                    }
                }
                //__原始节点.UncheckAll();
            }
        }

        private void 设置选中_父节点(TreeListNode __原始节点)
        {
            if (__原始节点.ParentNode != null)
            {
                var __全选 = __原始节点.ParentNode.Nodes.Cast<TreeListNode>().All(__node => __node.Checked);
                if (__全选)
                {
                    __原始节点.ParentNode.Checked = true;
                }
                设置选中_父节点(__原始节点.ParentNode);
            }
        }

        private void 设置选中_子节点(TreeListNode __原始节点)
        {
            if (__原始节点.HasChildren)
            {
                foreach (TreeListNode __node in __原始节点.Nodes)
                {
                    if (!__node.Checked)
                    {
                        On增加选择(__node.GetDisplayText(0));
                        var __子业务对象 = __node.Tag;
                        if (__子业务对象 != null)
                        {
                            On选择业务对象(__子业务对象);
                        }
                        __node.Checked = true;
                        设置选中_子节点(__node);
                    }
                }
                //__原始节点.CheckAll();
            }
        }

        public TreeList 当前列表
        {
            get
            {
                if (this.xtraTabControl1.SelectedTabPage == this.out关注)
                {
                    return this.out订阅列表;
                }
                if (this.xtraTabControl1.SelectedTabPage == this.out部门)
                {
                    return this.out部门列表;
                }
                return this.out基站列表;
            }
        }

        public TreeList 当前允许多选列表;

        public void 开启选择多个()
        {
            this.当前允许多选列表 = this.当前列表;
            this.当前允许多选列表.UncheckAll();
            this.当前允许多选列表.OptionsView.ShowCheckBoxes = true;
        }

        public void 关闭选择多个(bool __显示选择框 = false)
        {
            this.当前允许多选列表.UncheckAll();
            this.当前允许多选列表.OptionsView.ShowCheckBoxes = __显示选择框;
        }

        public List<TreeListNode> 查询当前选择()
        {
            return this.当前列表.GetAllCheckedNodes();
        }

        public void 设置选择(List<TreeListNode> __已选列表)
        {
            __已选列表.ForEach(q => q.Checked = true);
        }

        public void 添加关注组中成员()
        {
            var __组 = this.out订阅列表.Nodes[0].Nodes[0].Nodes[0];
            var __组号 = __组.Tag as M组号;
            if (__组号 != null)
            {
                __组号.成员.ForEach(q => this.out订阅列表.AppendNode(new object[] { q.名称 }, __组, q));
            }
            else
            {
                this.out订阅列表.AppendNode(new object[] { "XXX区交警一中队队长" }, __组.Id);
                this.out订阅列表.AppendNode(new object[] { "XXX区交警一中队队员001" }, __组.Id);
                this.out订阅列表.AppendNode(new object[] { "XXX区交警一中队队员002" }, __组.Id);
                this.out订阅列表.AppendNode(new object[] { "XXX区交警一中队队员003" }, __组.Id);
                this.out订阅列表.AppendNode(new object[] { "XXX区交警一中队队员004" }, __组.Id);
                this.out订阅列表.AppendNode(new object[] { "XXX区交警一中队队员005" }, __组.Id);
            }
        }

        public void 删除临时组号()
        {
            this.out订阅列表.Nodes[1].Nodes.RemoveAt(0);
        }

        public void 允许拖动()
        {
            //this.out订阅列表.OptionsBehavior.DragNodes = true;
            //this.out订阅列表.OptionsBehavior.CanCloneNodesOnDrop = true;
            //this.out环境列表.OptionsBehavior.DragNodes = true;
            //this.out环境列表.OptionsBehavior.CanCloneNodesOnDrop = true;
            //this.out部门列表.OptionsBehavior.DragNodes = true;
            //this.out部门列表.OptionsBehavior.CanCloneNodesOnDrop = true;
            this.out订阅列表.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single;
            this.out订阅列表.OptionsDragAndDrop.CanCloneNodesOnDrop = true;
            this.out环境列表.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single;
            this.out环境列表.OptionsDragAndDrop.CanCloneNodesOnDrop = true;
            this.out部门列表.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single;
            this.out部门列表.OptionsDragAndDrop.CanCloneNodesOnDrop = true;

        }

        public void 选中关注()
        {
            this.out订阅列表.Nodes[0].CheckAll();
        }

        public List<TreeListNode> 获取已选()
        {
            return this.out订阅列表.GetAllCheckedNodes();
        }

        public event Action<string> 增加选择;

        protected virtual void On增加选择(string obj)
        {
            Action<string> handler = 增加选择;
            if (handler != null) handler(obj);
        }

        public event Action<string> 删除选择;

        protected virtual void On删除选择(string obj)
        {
            Action<string> handler = 删除选择;
            if (handler != null) handler(obj);
        }

        public event Action<object> 选择业务对象;

        protected virtual void On选择业务对象(object obj)
        {
            Action<object> handler = 选择业务对象;
            if (handler != null) handler(obj);
        }

        public event Action<object> 取消选择业务对象;

        protected virtual void On取消选择业务对象(object obj)
        {
            Action<object> handler = 取消选择业务对象;
            if (handler != null) handler(obj);
        }

        public event Action<object> 双击业务对象;

        protected virtual void On双击业务对象(object obj)
        {
            Action<object> handler = 双击业务对象;
            if (handler != null) handler(obj);
        }

        private void out列表_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var __列表 = sender as TreeList;
            _HitInfo = __列表.CalcHitInfo(new Point(e.X, e.Y));
        }

        private void out列表_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var __列表 = sender as TreeList;

            if (_HitInfo == null) return;
            if (e.Button != MouseButtons.Left) return;
            var dragRect = new Rectangle(new Point(
                _HitInfo.MousePoint.X - SystemInformation.DragSize.Width / 2,
                _HitInfo.MousePoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);
            if (!dragRect.Contains(new Point(e.X, e.Y)))
            {
                if (!_HitInfo.Node.HasChildren)
                {
                    //var data = (__列表.GetRow(_HitInfo.RowHandle) as M通话记录).对方号码.值;
                    __列表.DoDragDrop("", DragDropEffects.Copy);
                }
            }
        }

        public object 获取鼠标位置业务对象()
        {
            if (_HitInfo != null)
            {
                if (_HitInfo.Node != null && _HitInfo.Node.Tag != null)
                {
                    return _HitInfo.Node.Tag;
                }
            }
            return null;
        }

        public void 设置鼠标位置节点选中状态(bool __选中)
        {
            if (_HitInfo != null)
            {
                if (_HitInfo.Node != null && _HitInfo.Node.Checked != __选中)
                {
                    _HitInfo.Node.Checked = __选中;
                }
            }
        }
    }
}
