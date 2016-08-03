using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace UI.设备.核心设备
{
    [ToolboxItem(false)]
    public partial class F网关_列表 : UserControl
    {
        public F网关_列表()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.in网关.SelectedIndex = 0;
            this.do添加基础网关.Click += (sender1, e1) => this.添加设备(this.in网关.SelectedItem.ToString());

            /*
路由
公网电话
数模有线互联
数模无线互联10A/110A
数模无线互联10B/10C
异地容灾
华为LTE
中兴LTE
江苏省调度
浙江省调度
中心网管
PCS100
             */
            this.gridControl1.DataSource = new List<object> {
                new { 设备类型= "路由", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0", 启用 = true },
                new { 设备类型= "公网电话", IP = "10.0.0.10", 标识 = "", 名称 = "PSTN1", 版本 = "1.0.0.0" , 启用 = true },
                new { 设备类型= "公网电话", IP = "10.0.0.11", 标识 = "", 名称 = "PSTN2", 版本 = "1.0.0.0", 启用 = false  },
                new { 设备类型= "数模有线互联", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0" , 启用 = true },
                new { 设备类型= "数模无线互联10A/110A", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0", 启用 = true  },
                new { 设备类型= "数模无线互联10B/10C", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0", 启用 = true  },
                new { 设备类型= "异地容灾", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0", 启用 = true  },
                new { 设备类型= "华为LTE", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0", 启用 = true  },
                new { 设备类型= "中兴LTE", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0", 启用 = true  },
                new { 设备类型= "江苏省调度", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0", 启用 = true  },
                new { 设备类型= "浙江省调度", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0", 启用 = true  },
                new { 设备类型= "省网管", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0", 启用 = true  },
                new { 设备类型= "PCS100", IP = "10.0.0.10", 标识 = "", 名称 = "", 版本 = "1.0.0.0", 启用 = true  },
            };
        }

        void 添加设备(string __设备类型)
        {
            switch (__设备类型)
            {
                case "边界网关":
                    new F网关_添加边界网关().ShowDialog();
                    break;
                default:
                    new F添加通用设备() { Text = string.Format("添加{0}", __设备类型) }.ShowDialog();
                    break;
            }
        }
    }
}
