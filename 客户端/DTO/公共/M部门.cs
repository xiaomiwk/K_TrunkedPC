using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO.公共
{
    public class M部门
    {
        public int Id { get; set; }

        public string 名称 { get; set; }

        public string 描述 { get; set; }

        public List<M组号> 组号列表 { get; set; }

        public List<M个号> 个号列表 { get; set; }

        public List<M部门> 下属部门 { get; set; }

        public M部门()
        {
            this.组号列表 = new List<M组号>();
            this.个号列表 = new List<M个号>();
            this.下属部门 = new List<M部门>();
        }
    }
}
