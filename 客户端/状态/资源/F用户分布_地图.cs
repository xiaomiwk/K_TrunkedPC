using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Utility.存储;
using 显示地图;

namespace UI.业务.状态
{
    public partial class F用户分布_地图 : Form
    {
        private IF地图 _I地图;

        double _初始地图中心经度 = 118.818035;            //南京: 经度="118.818035" 纬度="32.027785"

        double _初始地图中心纬度 = 32.027785;

        private readonly List<UInt64> _点索引 = new List<UInt64>();

        private readonly List<UInt64> _线索引 = new List<UInt64>();

        public F用户分布_地图()
        {
            SplashScreenManager.ShowForm(this.FindForm(), typeof(DevExpress.XtraWaitForm.DemoWaitForm), false, true, false);
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _I地图 = f地图1;
            _初始地图中心经度 = 118.818035;
            _初始地图中心纬度 = 32.027785;
            _I地图.加载地图(H路径.获取绝对路径("离线地图\\南京市_谷歌2D图_9-18.gmdb",true));

            var __机房位置 = new M经纬度(_初始地图中心经度, _初始地图中心纬度);
            var __地图标识 = _I地图.添加点(__机房位置, 创建图标("设备", "正常"), "机房1");
            _点索引.Add(__地图标识);
            var __数量 = 10;
            for (int i = 0; i < __数量; i++)
            {
                double __经度;
                double __纬度;
                if (i < __数量 / 2)
                {
                    __经度 = _初始地图中心经度 - 0.05 * i;
                    __纬度 = _初始地图中心纬度 + 0.05;
                }
                else
                {
                    __经度 = _初始地图中心经度 - 0.05 * (i - __数量 / 2);
                    __纬度 = _初始地图中心纬度 - 0.05;
                }
                var __基站位置 = new M经纬度(__经度, __纬度);
                __地图标识 = _I地图.添加点(__基站位置, 创建图标("基站", "正常"), "基站" + i);
                _点索引.Add(__地图标识);
                __地图标识 = _I地图.添加线(new List<M经纬度> { __机房位置, __基站位置 }, 2, Color.Green);
                _线索引.Add(__地图标识);
            }
            //添加随机用户麻点
            var r = new Random();
            var __麻点 = 创建图标("对讲机", "正常", false);
            var __位置列表 = new List<M经纬度>();
            for (int i = 0; i < 5000; i++)
            {
                var __经度 = _初始地图中心经度 - 0.5 + r.NextDouble() * 1;
                var __纬度 = _初始地图中心纬度 - 0.5 + r.NextDouble() * 1;
                //_I地图.添加点(new M经纬度(__经度, __纬度), __麻点);
                __位置列表.Add(new M经纬度(__经度, __纬度));
            }
            _I地图.添加麻点图(__位置列表, __麻点);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SplashScreenManager.CloseForm(false);
        }

        private Bitmap 创建图标(string __类型, string __样式, bool __合成 = true)
        {
            var __路径 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), string.Format("images\\{0}-{1}.png", __类型, __样式));
            var __图片 = new Bitmap(__路径);

            if (__合成)
            {
                var __随机数 = new Random();
                return 合成图片(__图片, 5, new List<int> { __随机数.Next(1, 20), __随机数.Next(1, 20), __随机数.Next(1, 20) }, new List<Color> { Color.Green, Color.Red, Color.Indigo });
            }
            return __图片;
        }

        /// <param name="__柱形宽度">单位:像素</param>
        /// <param name="__柱形高度列表">单位:像素</param>
        private Bitmap 合成图片(Bitmap __图片, int __柱形宽度, List<int> __柱形高度列表, List<Color> __颜色列表, bool __带边框 = false)
        {
            //状态值
            var __状态图宽度 = __柱形高度列表.Count * (__柱形宽度 + 1);  //加1像素起分割间隔作用
            var __合成图片 = new Bitmap(__图片.Width + __状态图宽度, Math.Max(__图片.Height, __柱形高度列表.Max()));
            var __绘图 = Graphics.FromImage(__合成图片);
            var __x轴当前位置 = 0;
            for (int i = 0; i < __柱形高度列表.Count; i++)
            {
                绘制柱状图(__绘图, __x轴当前位置, __合成图片.Height, __柱形宽度, __柱形高度列表[i], __颜色列表[i]);
                __x轴当前位置 += __柱形宽度 + 1;
            }

            //边框
            if (__带边框)
            {
                var __直线 = new Pen(Color.Gold);
                __绘图.DrawRectangle(__直线, 0, 0, __合成图片.Width - 1, __合成图片.Height - 1);
            }

            __绘图.DrawImage(__图片, __状态图宽度, __合成图片.Height - __图片.Height, __图片.Width, __图片.Height);
            return __合成图片;
        }

        private void 绘制柱状图(Graphics __绘图, int __起始X坐标, int __图片高度, int __柱状图1宽度, int __柱状图1高度, Color __填充色)
        {
            var __填充刷 = new SolidBrush(__填充色);
            __绘图.FillRectangle(__填充刷, __起始X坐标, __图片高度 - __柱状图1高度, __柱状图1宽度, __柱状图1高度);
        }

    }
}
