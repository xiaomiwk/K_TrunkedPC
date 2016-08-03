using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO.调度.地图
{
    public class M基站区域
    {
        public int Id { get; set; }

        public string 名称 { get; set; }

        public double 经度 { get; set; }

        public double 纬度 { get; set; }

        /// <summary>
        /// 单位：米
        /// </summary>
        public int 覆盖半径 { get; set; }


    }
}
