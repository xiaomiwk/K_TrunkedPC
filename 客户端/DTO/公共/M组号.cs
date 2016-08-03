using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO.公共
{
    public class M组号
    {
        public int Id { get; set; }

        public string 号码 { get; set; }

        public string 名称 { get; set; }

        public string 简称 { get; set; }

        public string 描述 { get; set; }

        public List<M个号> 成员 { get; set; }

        public bool 关注 { get; set; }

        public M组号()
        {
            this.成员 = new List<M个号>();
        }

    }

}
