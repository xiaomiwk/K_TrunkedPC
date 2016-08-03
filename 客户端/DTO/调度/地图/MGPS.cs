using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.公共;

namespace DTO.调度.地图
{
    public class MGPS
    {
        public M个号 号码 { get; set; }

        public double 经度 { get; set; }

        public double 纬度 { get; set; }

        /// <summary>
        /// 单位：米
        /// </summary>
        public int 误差半径 { get; set; }

        /// <summary>
        /// 范围：0-360
        /// </summary>
        public double 方向 { get; set; }

        public string 时间 { get; set; }
    }
}
