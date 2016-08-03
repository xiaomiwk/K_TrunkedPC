using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;
using UI.基础.辅助;

namespace UI.基础.外观设置
{
    [ToolboxItem(false)]
    public partial class F外观设置 : XtraUserControl
    {
        public F外观设置()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //设置皮肤
            var __所有皮肤 = new List<M皮肤>();
            var __图片索引 = 0;
            foreach (var tuple in H外观设置.单一实例.获取所有皮肤())
            {
                this.out图片列表.AddImage(tuple.Item2);
                __所有皮肤.Add(new M皮肤 { 描述 = tuple.Item1, 图片索引 = __图片索引 });
                __图片索引++;
            }

            in皮肤列表.DataSource = __所有皮肤;
            in皮肤列表.DisplayMember = "描述";
            in皮肤列表.ValueMember = "描述";
            in皮肤列表.ImageIndexMember = "图片索引";
            in皮肤列表.SelectedIndex = __所有皮肤.FindIndex(q => q.描述 == H外观设置.单一实例.皮肤名称);
            in皮肤列表.SelectedIndexChanged += in皮肤列表_SelectedIndexChanged;

            //设置背景
            var __所有背景 = new List<M背景图片>();
            __所有背景.Add(new M背景图片 { 图片名称 = "无", 图片 = null });
            foreach (var tuple in H外观设置.单一实例.获取所有背景图片())
            {
                __所有背景.Add(new M背景图片 { 图片名称 = tuple.Item1, 图片 = tuple.Item2 });
            }
            this.out列表容器.DataSource = __所有背景;
            var __选择背景索引 = __所有背景.FindIndex(q => q.图片名称 == H外观设置.单一实例.背景图片名称);
            this.out列表.FocusedRowHandle = __选择背景索引;
            this.out列表.RowClick += out列表_RowClick;
        }

        void out列表_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var __绑定 = this.out列表.GetFocusedRow() as M背景图片;
                H外观设置.单一实例.背景图片名称 = __绑定.图片名称;
            }
        }

        void in皮肤列表_SelectedIndexChanged(object sender, EventArgs e)
        {
            H外观设置.单一实例.皮肤名称 = (in皮肤列表.SelectedValue as string);
        }

        private class M皮肤
        {
            public string 描述 { get; set; }
            public int 图片索引 { get; set; }
        }

        private class M背景图片
        {
            public string 图片名称 { get; set; }
            public Image 图片 { get; set; }
        }
    }
}

