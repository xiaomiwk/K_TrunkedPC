using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraBars.Helpers;
using Utility.存储;

namespace UI.基础.外观设置
{
    public interface I外观设置
    {
        List<Tuple<string, Image>> 获取所有背景图片();

        string 背景图片名称 { get; set; }

        Image 背景图片 { get;  }

        event Action<Image> 背景图片变化;

        List<Tuple<string, Image>> 获取所有皮肤();

        string 皮肤名称 { get; set; }

        event Action<string> 皮肤变化;
    }

    internal class B外观设置 : I外观设置
    {
        readonly string __目录路径 = H路径.获取绝对路径("背景图片");

        readonly List<M皮肤> __皮肤列表 = new List<M皮肤>();

        public B外观设置()
        {
            int __皮肤图片索引 = 0;
            foreach (SkinContainer __skin in SkinManager.Default.Skins)
            {
                var __类别 = "Standard";
                if (SkinCollectionHelper.IsBonusSkin(__skin.SkinName))
                {
                    __类别 = "Bonus";
                }
                if (SkinCollectionHelper.IsThemeSkin(__skin.SkinName))
                {
                    __类别 = "Theme";
                }
                if (SkinCollectionHelper.IsCustomSkin(__skin.SkinName))
                {
                    __类别 = "Custom";
                }

                __皮肤列表.Add(new M皮肤
                {
                    名称 = __skin.SkinName,
                    描述 = SkinHelper.GetSkinCaptionBySkinName(__skin.SkinName),
                    顺序 = SkinCollectionHelper.GetSkinOrder(__skin.SkinName),
                    图片 = SkinCollectionHelper.GetSkinIcon(__skin.SkinName, SkinIconsSize.Small),
                    图片索引 = __皮肤图片索引,
                    类别 = __类别
                });
                __皮肤图片索引++;
            }
        }

        public List<Tuple<string, Image>> 获取所有背景图片()
        {
            var __结果 = new List<Tuple<string, Image>>();
            if (H路径.验证目录是否存在(__目录路径))
            {
                foreach (var __文件 in new DirectoryInfo(__目录路径).GetFiles("*.png", SearchOption.TopDirectoryOnly))
                {
                    __结果.Add(new Tuple<string, Image>(__文件.Name, Image.FromFile(__文件.FullName)));
                }
            }
            return __结果;
        }

        public string 背景图片名称
        {
            get { return H程序配置.获取字符串("背景图片"); }
            set
            {
                if (value != 背景图片名称)
                {
                    H程序配置.设置("背景图片", value);
                    if (背景图片名称 == "无")
                    {
                        触发背景图片变化(null);
                        return;
                    }
                    try
                    {
                        触发背景图片变化(Image.FromFile(Path.Combine(H路径.获取绝对路径("背景图片"), value)));
                    }
                    catch (Exception)
                    {
                        触发背景图片变化(null);
                        return;
                    }
                }
            }
        }

        public Image 背景图片
        {
            get
            {
                if(背景图片名称 == "无")
                {
                    return null;
                }
                try
                {
                    return Image.FromFile(Path.Combine(H路径.获取绝对路径("背景图片"), 背景图片名称));
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public event Action<Image> 背景图片变化;

        void 触发背景图片变化(Image obj)
        {
            var handler = 背景图片变化;
            if (handler != null) handler(obj);
        }

        public List<Tuple<string, Image>> 获取所有皮肤()
        {
            var __结果 = new List<Tuple<string, Image>>();
            __皮肤列表.ForEach(q => __结果.Add(new Tuple<string, Image>(q.名称, q.图片)));
            return __结果;
        }

        public string 皮肤名称
        {
            get
            {
                return H程序配置.获取字符串("界面样式");
            }
            set
            {
                var __名称 = "";
                var __匹配皮肤 = __皮肤列表.Find(q => q.名称 == value);
                if (__匹配皮肤 != null)
                {
                    __名称 = __匹配皮肤.名称;
                }
                else
                {
                    __名称 = __皮肤列表[0].名称;
                }
                UserLookAndFeel.Default.SkinName = __名称;
                //UserLookAndFeel.Default.SetSkinStyle(__名称);
                if (value != 皮肤名称)
                {
                    H程序配置.设置("界面样式", value);
                    触发皮肤变化(value);
                }
            }
        }

        public event Action<string> 皮肤变化;

        void 触发皮肤变化(string obj)
        {
            var handler = 皮肤变化;
            if (handler != null) handler(obj);
        }


        class M皮肤 : IComparable
        {
            public int 图片索引 { get; set; }

            public Image 图片 { get; set; }

            public string 名称 { get; set; }

            public int 顺序 { get; set; }

            public string 类别 { get; set; }

            public string 描述 { get; set; }

            public int CompareTo(object obj)
            {
                var skinInfo = obj as M皮肤;
                if (skinInfo == null)
                {
                    return 0;
                }
                if (skinInfo.图片索引 == -1 && this.图片索引 == -1)
                {
                    return this.名称.CompareTo(skinInfo.名称);
                }
                if (skinInfo.图片索引 == -1)
                {
                    return -1;
                }
                if (this.图片索引 == -1)
                {
                    return 1;
                }
                return this.图片索引.CompareTo(skinInfo.图片索引);
            }
        }

    }

}
