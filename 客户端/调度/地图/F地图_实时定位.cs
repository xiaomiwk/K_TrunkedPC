using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO.公共;
using DTO.调度.地图;
using UI.公共;
using UI.基础.辅助;
using Utility.存储;
using UI.调度.短信;
using UI.调度.通话;

namespace UI.调度.地图
{
    public partial class F地图_实时定位 : XtraUserControl
    {
        private HtmlDocument _HtmlDocument;

        private const int _即将离线间隔 = 20; //秒

        private const int _离线间隔 = 20; //秒

        private readonly object _标记缓存锁 = new object();

        private readonly Dictionary<int, M号码状态> _号码状态缓存 = new Dictionary<int, M号码状态>();

        private class M号码状态
        {
            public M个号 号码 { get; set; }

            public M对讲机 标记 { get; set; }

            public DateTime 上次时间 { get; set; }

            public string 状态 { get; set; }
        }

        private readonly List<int> _当前关注 = new List<int>();

        private string _城市 = "南京";

        private const double _起始经度 = 118.720829;

        private const double _起始纬度 = 31.901709;

        //private string _城市 = "丽水";

        //private const double _起始经度 = 119.805682;

        //private const double _起始纬度 = 28.379928;

        private Dictionary<M组号, Tuple<double, double>> _组经纬度缓存 = new Dictionary<M组号, Tuple<double, double>>();

        public HtmlDocument 文档
        {
            get { return _HtmlDocument; }
        }

        public F地图_实时定位()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.do地图操作_查询.EditValue = "";

            this.in资源.部门菜单 = this.out部门菜单;
            this.in资源.关注菜单 = this.out订阅菜单;
            this.in资源.基站菜单 = this.out基站菜单;
            this.in资源.选中关注();
            this.in资源.选择业务对象 += in资源_选择业务对象;
            this.in资源.取消选择业务对象 += in资源_取消选择业务对象;
            this.in资源.双击业务对象 += in资源_双击业务对象;

            this.out浏览器.ScriptErrorsSuppressed = true;
            this.out浏览器.Navigate(Path.Combine(H路径.程序目录, "调度/地图/实时.html"));
            this.out浏览器.DocumentCompleted += out浏览器_DocumentCompleted;

            this.do关注_呼叫.Click += do呼叫_Click;
            this.do关注_合并呼叫.Click += do关注_合并呼叫_Click;
            this.do关注_高级呼叫.Click += do高级呼叫_Click;
            this.do关注_发送短信.Click += do发送短信_Click;
            this.do关注_合并发送短信.Click += do关注_合并发送短信_Click;
            this.do关注_查看成员.Click += do查看成员_Click;
            this.do关注_查看通话记录.Click += do查看通话记录_Click;
            this.do关注_查看详细信息.Click += do关注_查看详细信息_Click;
            this.do关注_定位.Click += do定位_Click;
            this.do关注_锁定.Click += do关注_锁定_Click;
            this.do关注_取消锁定.Click += do关注_取消锁定_Click;
            this.do关注_配置定位参数.Click += do关注_配置定位参数_Click;
            this.do关注_设置显示样式.Click += do关注_设置显示样式_Click;

            this.do部门_呼叫.Click += do呼叫_Click;
            this.do部门_合并呼叫.Click += do部门_合并呼叫_Click;
            this.do部门_高级呼叫.Click += do高级呼叫_Click;
            this.do部门_发送短信.Click += do发送短信_Click;
            this.do部门_合并发送短信.Click += do部门_合并发送短信_Click;
            this.do部门_查看成员.Click += do查看成员_Click;
            this.do部门_查看通话记录.Click += do查看通话记录_Click;
            this.do部门_查看详细信息.Click += do部门_查看详细信息_Click;
            this.do部门_定位.Click += do定位_Click;

            this.do地图操作_标注.ItemClick += do地图操作_标注_ItemClick;
            this.do地图操作_测距.ItemClick += do地图操作_测距_ItemClick;
            this.do地图操作_查询_编辑器.ButtonClick += do地图操作_查询_编辑器_ButtonClick;
            this.do地图操作_查询_编辑器.KeyDown += do地图操作_查询_编辑器_KeyDown;
            this.do地图操作_轨迹回放.ItemClick += do地图操作_轨迹回放_ItemClick;
            this.do地图操作_平移.ItemClick += do地图操作_平移_ItemClick;
            this.do地图操作_区域.ItemClick += do地图操作_区域_ItemClick;
        }

        #region 资源响应
        void in资源_双击业务对象(object obj)
        {
            var __组号 = obj as M组号;
            if (__组号 != null)
            {
                设置地图中心标记(__组号.成员);
                if (_当前关注.Count > 0)
                {
                    _当前关注.ForEach(q => 设置标注样式(q, "取消关注"));
                    _当前关注.Clear();
                }
                _当前关注.AddRange(__组号.成员.Select(q => q.Id));
                _当前关注.ForEach(q => 设置标注样式(q, "关注"));
                return;
            }
            var __个号1 = obj as M个号;
            if (__个号1 != null && _号码状态缓存.ContainsKey(__个号1.Id))
            {
                设置地图中心标记(new List<M个号> { __个号1 });
                if (_当前关注.Count > 0)
                {
                    _当前关注.ForEach(q => 设置标注样式(q, "取消关注"));
                    _当前关注.Clear();
                }
                _当前关注.Add(__个号1.Id);
                _当前关注.ForEach(q => 设置标注样式(q, "关注"));
            }
        }

        void in资源_取消选择业务对象(object obj)
        {
            var __组号 = obj as M组号;
            if (__组号 != null)
            {
                foreach (var __个号 in __组号.成员)
                {
                    if (_号码状态缓存.ContainsKey(__个号.Id))
                    {
                        _号码状态缓存.Remove(__个号.Id);
                        删除标记(__个号.Id);
                    }
                }
                return;
            }

            var __个号1 = obj as M个号;
            if (__个号1 != null && _号码状态缓存.ContainsKey(__个号1.Id))
            {
                _号码状态缓存.Remove(__个号1.Id);
                删除标记(__个号1.Id);
            }

            var __基站 = obj as M基站;
            if (__基站 != null)
            {
                删除基站(__基站.Id);
            }
        }

        void in资源_选择业务对象(object obj)
        {
            初始绑定业务对象(obj);
            var __基站 = obj as DTO.公共.M基站;
            if (__基站 != null)
            {
                if (__基站.Id == 1)
                {
                    添加基站(new M基站区域 { Id = __基站.Id, 名称 = __基站.名称, 经度 = _起始经度, 纬度 = _起始纬度, 覆盖半径 = 5000 });
                }
                if (__基站.Id == 2)
                {
                    添加基站(new M基站区域 { Id = __基站.Id, 名称 = __基站.名称, 经度 = _起始经度 + 0.04, 纬度 = _起始纬度 + 0.04, 覆盖半径 = 5000 });
                }
                if (__基站.Id == 3)
                {
                    添加基站(new M基站区域 { Id = __基站.Id, 名称 = __基站.名称, 经度 = _起始经度 + 0.1, 纬度 = _起始纬度 + 0.08, 覆盖半径 = 5000 });
                }
            }
        }

        #endregion

        #region 列表操作
        void do呼叫_Click(object sender, EventArgs e)
        {
            弹出窗口(new F通话_通话列表());
        }

        void do高级呼叫_Click(object sender, EventArgs e)
        {
            弹出窗口(new F高级呼叫());
        }

        void do关注_合并呼叫_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F通话_合并呼叫();
            弹出窗口(__弹出窗口);

            var __当前选择列表 = this.in资源.查询当前选择();
            this.in资源.开启选择多个();
            this.in资源.增加选择 += __弹出窗口.添加号码;
            this.in资源.删除选择 += __弹出窗口.删除号码;
            取消订阅资源事件();
            __弹出窗口.FormClosed += (sender1, e1) =>
            {
                this.in资源.关闭选择多个(true);
                this.in资源.设置选择(__当前选择列表);
                订阅资源事件();
            };
        }

        private void 订阅资源事件()
        {
            this.in资源.选择业务对象 += in资源_选择业务对象;
            this.in资源.取消选择业务对象 += in资源_取消选择业务对象;
            this.in资源.双击业务对象 += in资源_双击业务对象;
        }

        private void 取消订阅资源事件()
        {
            this.in资源.选择业务对象 -= in资源_选择业务对象;
            this.in资源.取消选择业务对象 -= in资源_取消选择业务对象;
            this.in资源.双击业务对象 -= in资源_双击业务对象;
        }

        void do部门_合并呼叫_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F通话_合并呼叫();
            弹出窗口(__弹出窗口);

            this.in资源.开启选择多个();
            this.in资源.增加选择 += __弹出窗口.添加号码;
            this.in资源.删除选择 += __弹出窗口.删除号码;
            取消订阅资源事件();
            __弹出窗口.FormClosed += (sender1, e1) =>
            {
                this.in资源.关闭选择多个();
                订阅资源事件();
            };
        }

        void do发送短信_Click(object sender, EventArgs e)
        {
            弹出窗口(new F短信_发送短信_弹出窗口());
        }

        void do关注_合并发送短信_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F短信_合并发送短信_弹出窗口();
            弹出窗口(__弹出窗口);

            var __当前选择列表 = this.in资源.查询当前选择();
            this.in资源.开启选择多个();
            this.in资源.增加选择 += __弹出窗口.添加号码;
            this.in资源.删除选择 += __弹出窗口.删除号码;
            取消订阅资源事件();
            __弹出窗口.FormClosed += (sender1, e1) =>
            {
                this.in资源.关闭选择多个(true);
                this.in资源.设置选择(__当前选择列表);
                订阅资源事件();
            };
        }

        void do部门_合并发送短信_Click(object sender, EventArgs e)
        {
            var __弹出窗口 = new F短信_合并发送短信_弹出窗口();
            弹出窗口(__弹出窗口);

            this.in资源.开启选择多个();
            this.in资源.增加选择 += __弹出窗口.添加号码;
            this.in资源.删除选择 += __弹出窗口.删除号码;
            取消订阅资源事件();
            __弹出窗口.FormClosed += (sender1, e1) =>
            {
                this.in资源.关闭选择多个();
                订阅资源事件();
            };
        }

        void do查看成员_Click(object sender, EventArgs e)
        {
            弹出窗口(new F组成员());
        }

        void do查看通话记录_Click(object sender, EventArgs e)
        {
            弹出窗口(new F通话_通话记录());
        }

        void do关注_查看详细信息_Click(object sender, EventArgs e)
        {
            弹出窗口(new F号码详细信息());
        }

        void do部门_查看详细信息_Click(object sender, EventArgs e)
        {
            弹出窗口(new F号码详细信息());
        }

        void do定位_Click(object sender, EventArgs e)
        {
            var __当前业务对象 = this.in资源.获取鼠标位置业务对象();
            if (__当前业务对象 != null)
            {
                this.in资源.设置鼠标位置节点选中状态(true);
                this.in资源_选择业务对象(__当前业务对象);
            }
        }

        void do关注_锁定_Click(object sender, EventArgs e)
        {
            var __当前业务对象 = this.in资源.获取鼠标位置业务对象();
            if (__当前业务对象 != null)
            {
                this.in资源.设置鼠标位置节点选中状态(true);
                this.in资源_选择业务对象(__当前业务对象);
                this.in资源_双击业务对象(__当前业务对象);
                设置地图中心模式("指定标记序列");
            }
        }

        void do关注_取消锁定_Click(object sender, EventArgs e)
        {
            设置地图中心模式("手动");
        }

        void do关注_设置显示样式_Click(object sender, EventArgs e)
        {
            弹出窗口(new F地图_显示样式());
        }

        void do关注_配置定位参数_Click(object sender, EventArgs e)
        {
            弹出窗口(new F地图_定位参数());
        }

        #endregion

        #region 地图操作
        void do地图操作_平移_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            设置地图操作模式(E地图操作方式.移动地图);
        }

        void do地图操作_区域_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            弹出窗口(new F地图_区域操作(this), this.out地图容器.PointToScreen(new Point(20, 0)));
        }

        void do地图操作_标注_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            弹出窗口(new F地图_标注操作(this), this.out地图容器.PointToScreen(new Point(70, 0)));
        }

        void do地图操作_测距_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            弹出窗口(new F地图_测距(this), this.out地图容器.PointToScreen(new Point(120, 0)));
        }

        void do地图操作_查询_编辑器_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var __关键词 = (sender as ButtonEdit).Text;
            this.do地图操作_查询.EditValue = __关键词;
            if (e.Button.Index == 1)
            {
                if (!string.IsNullOrEmpty(__关键词))
                {
                    查询位置(__关键词);
                    do地图操作_查询_编辑器.Buttons[0].Visible = true;
                }
                else
                {
                    关闭查询位置();
                }
            }
            else
            {
                this.do地图操作_查询.EditValue = null;
                关闭查询位置();
                do地图操作_查询_编辑器.Buttons[0].Visible = false;
            }
        }

        void do地图操作_查询_编辑器_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var __关键词 = (sender as ButtonEdit).Text;
                this.do地图操作_查询.EditValue = __关键词;
                if (!string.IsNullOrEmpty(__关键词))
                {
                    查询位置(__关键词);
                    do地图操作_查询_编辑器.Buttons[0].Visible = true;
                }
                else
                {
                    关闭查询位置();
                    do地图操作_查询_编辑器.Buttons[0].Visible = false;
                }
            }
        }

        void do地图操作_轨迹回放_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Program.主窗口.创建内容("轨迹回放");
        }
        #endregion

        #region 浏览器
        private void out浏览器_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            _HtmlDocument = this.out浏览器.Document;
            _HtmlDocument.InvokeScript("初始化地图", new object[] { _城市 });
            查询HTML元素("do触发事件").AttachEventHandler("onclick", 处理WEB请求);
            out浏览器_Resize(null, null);
            this.out浏览器.Resize += out浏览器_Resize;

            new Task(初始化任务).Start();
            new Task(模拟外部数据任务).Start();
            new Task(检测状态任务).Start();
        }

        private void out浏览器_Resize(object sender, EventArgs e)
        {
            _HtmlDocument.InvokeScript("设置地图大小", new object[] { (this.out浏览器.Width - 25) + "px", (this.out浏览器.Height - 10) + "px" });
        }

        private HtmlElement 查询HTML元素(string __ID)
        {
            return _HtmlDocument.GetElementById(__ID);
        }

        private void 处理WEB请求(object sender, EventArgs e)
        {
            var __事件名称 = 查询HTML元素("do触发事件").GetAttribute("value");
            var __事件参数 = 查询HTML元素("in事件参数").GetAttribute("value");
            //H弹出消息.显示(string.Format("处理WEB请求，事件名称：{0}, 事件参数：{1}", __事件名称, __事件参数));
            if (__事件名称 == "删除标记")
            {
                var __Id = int.Parse(__事件参数);
                删除标记(__Id);
                _号码状态缓存.Remove(__Id);
            }
            if (__事件名称 == "呼叫")
            {
                var __Id = int.Parse(__事件参数);
                弹出窗口(new F通话_通话列表());
            }
            if (__事件名称 == "发短信")
            {
                var __Id = int.Parse(__事件参数);
                弹出窗口(new F短信_发送短信_弹出窗口());
            }
            On地图请求(__事件名称, __事件参数);
        }

        private void 初始化任务()
        {
            System.Threading.Thread.Sleep(5000);
            foreach (var __node in this.in资源.获取已选())
            {
                初始绑定业务对象(__node.Tag);
            }
        }

        private void 初始绑定业务对象(object obj)
        {
            var __组号 = obj as M组号;
            if (__组号 != null)
            {
                if (!_组经纬度缓存.ContainsKey(__组号))
                {
                    _组经纬度缓存[__组号] = 生成经纬度();
                }
                foreach (var __个号 in __组号.成员)
                {
                    if (_号码状态缓存.ContainsKey(__个号.Id))
                    {
                        continue;
                    }
                    var __GPS = 模拟初始GPS(__个号, _组经纬度缓存[__组号].Item1, _组经纬度缓存[__组号].Item2);
                    处理外部数据(__GPS);
                }
                return;
            }
            var __个号1 = obj as M个号;
            if (__个号1 != null && !_号码状态缓存.ContainsKey(__个号1.Id))
            {
                var __GPS = 模拟初始GPS(__个号1);
                处理外部数据(__GPS);
            }
        }

        private Tuple<double, double> 生成经纬度()
        {
            var __数量 = _组经纬度缓存.Count;
            switch (__数量)
            {
                case 0:
                    return new Tuple<double, double>(_起始经度 + 0.05, _起始纬度 + 0.05);
                case 1:
                    return new Tuple<double, double>(_起始经度 + 0.05, _起始纬度 + 0.0);
                case 2:
                    return new Tuple<double, double>(_起始经度 + 0.0, _起始纬度 + 0.05);
                case 3:
                    return new Tuple<double, double>(_起始经度 + 0.0, _起始纬度 + 0.0);
                default:
                    return new Tuple<double, double>(_起始经度 - 0.1, _起始纬度 + 0.1);
            }
        }

        private MGPS 模拟初始GPS(M个号 __号码)
        {
            var __随机数 = new Random(Environment.TickCount * 100);
            var __经度 = _起始经度 + __随机数.NextDouble() * 0.1;
            var __纬度 = _起始纬度 + __随机数.NextDouble() * 0.1;
            var __GPS = new MGPS
            {
                号码 = __号码,
                经度 = __经度,
                纬度 = __纬度,
                误差半径 = 50,
                方向 = __随机数.Next(0, 360),
                时间 = DateTime.Now.ToString(),
            };
            return __GPS;
        }

        private MGPS 模拟初始GPS(M个号 __号码, double __起始经度, double __起始维度)
        {
            var __随机数 = new Random(Environment.TickCount * 100);
            var __经度 = __起始经度 + __随机数.NextDouble() * 0.06;
            var __纬度 = __起始维度 + __随机数.NextDouble() * 0.06;
            var __GPS = new MGPS
            {
                号码 = __号码,
                经度 = __经度,
                纬度 = __纬度,
                误差半径 = 50,
                方向 = __随机数.Next(0, 360),
                时间 = DateTime.Now.ToString(),
            };
            return __GPS;
        }

        private void 模拟外部数据任务()
        {
            var __随机数 = new Random();
            while (true)
            {
                try
                {
                    if (_号码状态缓存.Count == 0)
                    {
                        System.Threading.Thread.Sleep(3000);
                        continue;
                    }
                    var __更新序号 = __随机数.Next(0, _号码状态缓存.Count);
                    __更新序号 = Math.Min(__更新序号, _号码状态缓存.Count - 1);
                    var __号码状态 = _号码状态缓存[_号码状态缓存.Keys.ToList()[__更新序号]];
                    var __号码 = __号码状态.号码;
                    var __上次标记 = __号码状态.标记;
                    var __随机数1 = __随机数.NextDouble() * 0.001;
                    var __随机数2 = __随机数.NextDouble() * 0.001;

                    var __GPS = new MGPS
                    {
                        号码 = __号码,
                        经度 = __上次标记.经度 + __随机数1,
                        纬度 = __上次标记.纬度 + __随机数2,
                        误差半径 = 50,
                        方向 = __随机数.Next(0, 360),
                        时间 = DateTime.Now.ToString(),
                    };
                    处理外部数据(__GPS);
                    System.Threading.Thread.Sleep(5 * 1000 / _号码状态缓存.Keys.Count);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message, "模拟外部数据任务");
                }
            }
        }

        private void 检测状态任务()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(3000);
                try
                {
                    foreach (var __kv in _号码状态缓存)
                    {
                        var __Id = __kv.Key;
                        var __标记 = __kv.Value.标记;
                        var __状态 = __kv.Value.状态;
                        DateTime __最后时间;
                        if (!DateTime.TryParse(__标记.时间, out __最后时间))
                        {
                            continue;
                        }
                        if (__最后时间.AddSeconds(_离线间隔) < DateTime.Now)
                        {
                            if (__状态 != "离线")
                            {
                                __kv.Value.状态 = "离线";
                                设置标注样式(__Id, "离线");
                                System.Diagnostics.Debug.WriteLine(__Id + "离线");
                            }
                        }
                        //else if (__最后时间.AddSeconds(_即将离线间隔) < DateTime.Now)
                        //{
                        //    if (__状态 != "即将离线")
                        //    {
                        //        __kv.Value.状态 = "即将离线";
                        //        设置标注样式(__Id, "即将离线");
                        //        System.Diagnostics.Debug.WriteLine(__Id + "即将离线");
                        //    }
                        //}
                        else
                        {
                            __kv.Value.状态 = "在线";
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message, "检测状态任务");
                }
            }
        }

        private void 处理外部数据(MGPS __GPS)
        {
            var __号码 = __GPS.号码;
            var __Id = __GPS.号码.Id;
            if (_号码状态缓存.ContainsKey(__Id))
            {
                删除标记(__Id);
            }
            var __标记 = 生成标记(__GPS);
            _号码状态缓存[__Id] = new M号码状态 { 标记 = __标记, 上次时间 = DateTime.Now, 号码 = __号码, 状态 = "在线" };
            添加标记(__标记);
            if (_当前关注.Contains(__Id))
            {
                设置标注样式(__Id, "关注");
            }
        }

        private static M对讲机 生成标记(MGPS __GPS)
        {
            var __号码 = __GPS.号码;
            var __Id = __GPS.号码.Id;
            var __标记 = new M对讲机
            {
                Id = __Id,
                名称 = string.IsNullOrEmpty(__号码.简称) ? __号码.名称 : __号码.简称,
                全称 = __号码.名称,
                号码 = __号码.号码,
                描述 = __号码.描述,
                经度 = __GPS.经度,
                纬度 = __GPS.纬度,
                打开描述 = false,
                误差半径 = __GPS.误差半径,
                方向 = __GPS.方向,
                时间 = __GPS.时间,
            };
            return __标记;
        }

        private void 添加标记(M对讲机 __标记)
        {
            var __序列化器 = new JavaScriptSerializer();
            var __字符串 = __序列化器.Serialize(__标记);
            try
            {
                this.Invoke(new Action(() =>
                {
                    _HtmlDocument.InvokeScript("添加标记", new object[] { __字符串 });
                }));
            }
            catch (Exception)
            {
                //记录异常，排除窗口关闭时更新界面
            }
        }

        private void 删除标记(int __Id)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    _HtmlDocument.InvokeScript("删除标记", new object[] { __Id });
                }));
            }
            catch (Exception)
            {
                //记录异常，排除窗口关闭时更新界面
            }
        }

        private void 设置标注样式(int __Id, string __样式)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    _HtmlDocument.InvokeScript("设置标注样式", new object[] { __Id, __样式 });
                }));
            }
            catch (Exception)
            {
                //记录异常，排除窗口关闭时更新界面
            }
        }

        private void 设置地图中心标记(List<M个号> __列表)
        {
            var __参数 = string.Join(",", __列表.Select(q => q.Id).ToArray());
            _HtmlDocument.InvokeScript("设置地图中心标记序列", new object[] { __参数 });
        }

        private void 设置地图中心模式(string __模式)
        {
            _HtmlDocument.InvokeScript("设置地图中心模式", new object[] { __模式 });
        }

        private void 添加基站(M基站区域 __基站)
        {
            var __序列化器 = new JavaScriptSerializer();
            var __字符串 = __序列化器.Serialize(__基站);
            try
            {
                this.Invoke(new Action(() =>
                {
                    _HtmlDocument.InvokeScript("添加基站", new object[] { __字符串 });
                }));
            }
            catch (Exception)
            {
                //记录异常，排除窗口关闭时更新界面
            }
        }

        private void 删除基站(int __Id)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    _HtmlDocument.InvokeScript("删除基站", new object[] { __Id });
                }));
            }
            catch (Exception)
            {
                //记录异常，排除窗口关闭时更新界面
            }
        }

        private void 查询位置(string __关键词)
        {
            H弹出消息.显示(__关键词, "查询位置");
            _HtmlDocument.InvokeScript("查询位置", new object[] { __关键词 });
        }

        private void 关闭查询位置()
        {
            H弹出消息.显示("关闭查询位置","");
            _HtmlDocument.InvokeScript("关闭查询位置");
        }

        public void 设置地图操作模式(E地图操作方式 __方法)
        {
            _HtmlDocument.InvokeScript("设置地图操作模式", new object[] { __方法.ToString() });
        }

        /// <summary>
        /// 参数依次为“事件名称”，“事件参数”
        /// </summary>
        public event Action<string, string> 地图请求;

        protected virtual void On地图请求(string __事件名称, string __事件参数)
        {
            var handler = 地图请求;
            if (handler != null) handler(__事件名称, __事件参数);
        }

        #endregion

        public void 弹出窗口(XtraForm __窗口)
        {
            __窗口.TopMost = true;
            __窗口.StartPosition = FormStartPosition.Manual;
            var __窗口位置 = this.out地图容器.PointToScreen(new Point((this.out地图容器.Width - __窗口.Width) / 2, (this.out地图容器.Height - __窗口.Height) / 2));
            __窗口.Location = __窗口位置;
            __窗口.Show();
        }

        public void 弹出窗口(XtraForm __窗口, Point __位置)
        {
            __窗口.TopMost = true;
            __窗口.StartPosition = FormStartPosition.Manual;
            var __窗口位置 = __位置;
            __窗口.Location = __窗口位置;
            __窗口.Show();
        }

    }
}

