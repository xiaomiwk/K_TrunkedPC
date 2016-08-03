using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DTO.调度.地图;

namespace UI.调度.地图
{
    public partial class F地图_标注操作 : DevExpress.XtraEditors.XtraForm
    {
        private readonly F地图_实时定位 _地图;

        private readonly List<M标注> _标注列表 = new List<M标注>();

        private static int _标注Id;

        public F地图_标注操作(F地图_实时定位 __地图)
        {
            InitializeComponent();
            _地图 = __地图;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _地图.地图请求 += _地图_地图请求;
            this.do删除当前.ItemClick += do删除当前_ItemClick;
            this.do添加标注.ItemClick += do添加标注_ItemClick;
            this.out标注列表.ItemCheck += out标注列表_ItemCheck;
            this.out标注列表.SelectedValueChanged += out标注列表_SelectedValueChanged;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _地图.设置地图操作模式(E地图操作方式.移动地图);
        }

        void out标注列表_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.out标注列表.SelectedItems.Count == 1)
            {
                var __item = this.out标注列表.Items[this.out标注列表.SelectedIndex];
                var __标注 = (M标注)__item.Value;
                if (__item.CheckState == CheckState.Checked)
                {
                    删除标注(__标注.Id);
                    添加标注(__标注);
                }
            }
        }

        void out标注列表_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            var __标注 = (M标注)this.out标注列表.Items[e.Index].Value;
            if (e.State == CheckState.Checked)
            {
                添加标注(__标注);
            }
            else
            {
                删除标注(__标注.Id);
            }
        }

        void do添加标注_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _地图.设置地图操作模式(E地图操作方式.绘制标记);
        }

        void do删除当前_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (CheckedListBoxItem __item in this.out标注列表.SelectedItems)
            {
                var __标注 = (M标注)__item.Value;
                if (__item.CheckState == CheckState.Checked)
                {
                    删除标注(__标注.Id);
                }
                _标注列表.RemoveAll(q => q.Id == __标注.Id);
            }
            var __数量 = this.out标注列表.SelectedItems.Count;
            var __缓存 = this.out标注列表.SelectedItems;
            for (int i = 0; i < __数量; i++)
            {
                this.out标注列表.Items.Remove(__缓存[i]);
            }
        }

        void _地图_地图请求(string __事件名称, string __事件参数)
        {
            if (__事件名称 != E地图操作方式.绘制标记.ToString())
            {
                return;
            }
            var __名称 = (string)this.in标注名称.EditValue;
            if (string.IsNullOrEmpty(__名称))
            {
                return;
            }

            var __json序列化 = new JavaScriptSerializer();   //实例化一个能够序列化数据的类
            var __结果 = __json序列化.Deserialize<M点>(__事件参数);    //将json数据转化为对象类型并赋值给list
            var __标注 = new M标注
                {
                    Id = _标注Id++,
                    经度 = __结果.经度,
                    纬度 = __结果.纬度,
                    名称 = __名称,
                };
            添加标注(__标注);
            _标注列表.Add(__标注);
            this.out标注列表.Items.Add(new CheckedListBoxItem(__标注, __标注.名称, CheckState.Checked));
        }

        private void 添加标注(M标注 __标注)
        {
            var __序列化器 = new JavaScriptSerializer();
            var __字符串 = __序列化器.Serialize(__标注);
            try
            {
                this.Invoke(new Action(() =>
                {
                    _地图.文档.InvokeScript("添加标注", new object[] { __字符串 });
                }));
            }
            catch (Exception)
            {
                //记录异常，排除窗口关闭时更新界面
            }
        }

        private void 删除标注(int __Id)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    _地图.文档.InvokeScript("删除标注", new object[] { __Id });
                }));
            }
            catch (Exception)
            {
                //记录异常，排除窗口关闭时更新界面
            }
        }

    }
}