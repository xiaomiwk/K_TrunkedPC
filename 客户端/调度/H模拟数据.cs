using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using DTO.公共;
using Utility.存储;

namespace UI.公共
{
    public static class H模拟数据
    {
        private static int _标识 = 0;

        public static M部门 根部门;

        public static List<M组号> 关注组号列表 = new List<M组号>();

        public static List<M个号> 关注个号列表 = new List<M个号>();

        static H模拟数据()
        {
            var __绝对路径 = H路径.获取绝对路径("调度\\部门.xml");
            var __doc = XDocument.Load(__绝对路径);
            根部门 = 查询部门结构(__doc.Root);
        }

        private static M部门 查询部门结构(XElement __部门节点)
        {
            var __结果 = new M部门
                {
                    Id = _标识++,
                    名称 = __部门节点.Attribute("名称").Value,
                    描述 = "",
                };

            foreach (XElement __子部门节点 in __部门节点.Elements("部门"))
            {
                var __下属部门 = 查询部门结构(__子部门节点);
                __结果.下属部门.Add(__下属部门);
            }

            var __组号列表节点 = __部门节点.Element("组号列表");
            if (__组号列表节点 != null)
            {
                foreach (XElement __组号节点 in __组号列表节点.Elements("组号"))
                {
                    var __组号 = new M组号
                    {
                        Id = _标识++,
                        名称 = __组号节点.Attribute("名称").Value,
                        简称 = __组号节点.Attribute("简称") == null ? string.Empty : __组号节点.Attribute("简称").Value,
                        描述 = "",
                        号码 = __组号节点.Attribute("号码").Value,
                        关注 = __组号节点.Attribute("关注") != null && bool.Parse(__组号节点.Attribute("关注").Value)
                    };
                    __结果.组号列表.Add(__组号);
                    if (__组号.关注)
                    {
                        关注组号列表.Add(__组号);
                    }

                    foreach (XElement __个号节点 in __组号节点.Elements("个号"))
                    {
                        var __个号 = new M个号
                        {
                            Id = _标识++,
                            名称 = __个号节点.Attribute("名称").Value,
                            简称 = __个号节点.Attribute("简称") == null ? string.Empty : __个号节点.Attribute("简称").Value,
                            描述 = "",
                            号码 = __个号节点.Attribute("号码").Value,
                        };
                        __组号.成员.Add(__个号);
                    }
                }
            }

            var __个号列表节点 = __部门节点.Element("个号列表");
            if (__个号列表节点 != null)
            {
                foreach (XElement __个号节点 in __个号列表节点.Elements("个号"))
                {
                    var __个号 = new M个号
                    {
                        Id = _标识++,
                        名称 = __个号节点.Attribute("名称").Value,
                        简称 = __个号节点.Attribute("简称") == null ? string.Empty : __个号节点.Attribute("简称").Value,
                        描述 = "",
                        号码 = __个号节点.Attribute("号码").Value,
                        关注 = __个号节点.Attribute("关注") != null && bool.Parse(__个号节点.Attribute("关注").Value)
                    };
                    __结果.个号列表.Add(__个号);
                    if (__个号.关注)
                    {
                        关注个号列表.Add(__个号);
                    }
                }
            }

            return __结果;
        }
    }
}
