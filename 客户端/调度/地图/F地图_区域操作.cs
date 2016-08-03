using System;
using System.ComponentModel;
using System.Web.Script.Serialization;
using DTO.调度.地图;
using UI.基础.辅助;
using UI.调度.通话;

namespace UI.调度.地图
{
    public partial class F地图_区域操作 : DevExpress.XtraEditors.XtraForm
    {
        private F地图_实时定位 _地图;

        public F地图_区域操作(F地图_实时定位 __地图)
        {
            InitializeComponent();
            _地图 = __地图;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置属性
            H设置样式.设置基本样式(this.out列表);
            H设置样式.设置基本样式(this.out列表容器.EmbeddedNavigator);
            H设置样式.设置操作列基本样式(this.out操作列1, this.out操作列2);
            this.out列表.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            H设置样式.设置基本样式(this.out列表2);
            H设置样式.设置基本样式(this.out列表容器2.EmbeddedNavigator);
            H设置样式.设置操作列基本样式(this.out操作列3, this.out操作列4);
            this.out列表2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

            this.out号码列表容器.Visible = false;
            this.do折叠展开.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //订阅事件
            this.do移动地图.ItemClick += do移动地图_ItemClick;
            this.do选择矩形.ItemClick += do选择矩形_ItemClick;
            this.do选择圆形.ItemClick += do选择圆形_ItemClick;
            this.do删除上一个区域.ItemClick += do删除上一个区域_ItemClick;
            this.do删除所有区域.ItemClick += do删除所有区域_ItemClick;
            this.do查询已显示号码.ItemClick += do查询已显示号码_ItemClick;
            this.do查询所有号码.ItemClick += do查询所有号码_ItemClick;
            this.do呼叫已选号码.ItemClick += do呼叫已选号码_ItemClick;
            this.do折叠展开.ItemClick += do折叠展开_ItemClick;
            _地图.地图请求 += _地图_地图请求;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _地图.设置地图操作模式(E地图操作方式.移动地图);
        }

        void do折叠展开_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.do折叠展开.Caption == "展开")
            {
                if (this.Height < 400)
                {
                    this.Height += 400;
                }
                this.do折叠展开.Caption = "折叠";
                this.out号码列表容器.Visible = true;
            }
            else
            {
                if (this.Height > 400)
                {
                    this.Height -= 400;
                }
                this.do折叠展开.Caption = "展开";
                this.out号码列表容器.Visible = false;
            }
        }

        void do移动地图_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _地图.设置地图操作模式(E地图操作方式.移动地图);
        }

        void do选择矩形_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _地图.设置地图操作模式(E地图操作方式.绘制长方形区域);
        }

        void do选择圆形_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _地图.设置地图操作模式(E地图操作方式.绘制圆形区域);
        }

        void do删除上一个区域_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            删除上一个区域();
        }

        void do删除所有区域_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            删除所有区域();
        }

        void do查询已显示号码_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Width = 750;
            this.out号码列表容器.Visible = true;
            if (this.Height < 400)
            {
                this.Height += 400;
            }
            this.do折叠展开.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        void do查询所有号码_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Width = 750;
            this.out号码列表容器.Visible = true;
            if (this.Height < 400)
            {
                this.Height += 400;
            }
            this.do折叠展开.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        void do呼叫已选号码_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _地图.弹出窗口(new F通话_通话列表());
        }

        void _地图_地图请求(string __事件名称, string __事件参数)
        {
            if (__事件名称 == E地图操作方式.绘制长方形区域.ToString())
            {
                var __json序列化 = new JavaScriptSerializer();   //实例化一个能够序列化数据的类

                var __结果 = __json序列化.Deserialize<M长方形区域>(__事件参数);    //将json数据转化为对象类型并赋值给list
                //_区域列表.Add(__结果);
                var __长 = GetDistance(__结果.左上角.经度, __结果.左上角.纬度, __结果.右下角.经度, __结果.右下角.纬度);
                var __宽 = GetDistance(__结果.右下角.经度, __结果.左上角.纬度, __结果.右下角.经度, __结果.右下角.纬度);
                //this.out结果.AppendText(string.Format("选择长方形区域，长：{0}米，宽：{1}米{2}", Math.Floor(__长), Math.Floor(__宽), Environment.NewLine));
            }
            if (__事件名称 == E地图操作方式.绘制圆形区域.ToString())
            {
                var __json序列化 = new JavaScriptSerializer();   //实例化一个能够序列化数据的类
                var __结果 = __json序列化.Deserialize<M圆形区域>(__事件参数);    //将json数据转化为对象类型并赋值给list
                //_区域列表.Add(__结果);
                //this.out结果.AppendText(string.Format("选择圆形区域，半径：{0}米{1}", __结果.半径, Environment.NewLine));
            }

        }

        void 删除所有区域()
        {
            //if (_区域列表.Count > 0)
            //{
            _地图.文档.InvokeScript("删除所有选择区域");
            //    _区域列表.Clear();
            //}
        }

        void 删除上一个区域()
        {
            //if (_区域列表.Count > 0)
            //{
            _地图.文档.InvokeScript("删除上一个选择区域");
            //    _区域列表.RemoveAt(_区域列表.Count - 1);
            //}
        }

        /// <summary>
        /// 两点距离
        /// </summary>
        /// <param name="lng1">经度1</param>
        /// <param name="lat1">纬度1</param>
        /// <param name="lng2">经度2</param>
        /// <param name="lat2">纬度2</param>
        /// <returns>距离:米</returns>
        /// <Author>lc</Author>
        /// <FinishT>2009-12-30</FinishT>
        public double GetDistance(double lng1, double lat1, double lng2, double lat2)
        {
            double latRadians1 = lat1 * (Math.PI / 180);
            double latRadians2 = lat2 * (Math.PI / 180);
            double latRadians = latRadians1 - latRadians2;
            double lngRadians = lng1 * (Math.PI / 180) - lng2 * (Math.PI / 180);
            double f = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(latRadians / 2), 2) + Math.Cos(latRadians1) * Math.Cos(latRadians2) * Math.Pow(Math.Sin(lngRadians / 2), 2)));
            return f * 6378137;
        }

    }
}