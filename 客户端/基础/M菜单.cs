using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace UI.基础
{
    public class M一级菜单
    {
        public string 名称 { get; set; }

        public string 描述 { get; set; }

        public Image 图片 { get; set; }

        public List<M二级菜单> 子菜单 { get; set; }

        public M一级菜单()
        {
            子菜单 = new List<M二级菜单>();
        }
    }

    public class M二级菜单
    {
        public string 名称 { get; set; }

        public string 描述 { get; set; }

        public Image 图片 { get; set; }

        public List<M三级菜单> 子菜单 { get; set; }

        public M二级菜单()
        {
            子菜单 = new List<M三级菜单>();
        }

    }

    public class M三级菜单
    {
        public string 名称 { get; set; }

        public string 描述 { get; set; }

        public Image 图片 { get; set; }

        public Function<UserControl> 创建窗口 { get; set; }

        public Action 执行方法 { get; set; }

        public UserControl 实例 { get; set; }

        public bool 允许关闭 { get; set; }

        public bool 允许停靠 { get; set; }

        public M三级菜单()
        {
            允许停靠 = true;
            允许关闭 = true;
        }

    }

}
