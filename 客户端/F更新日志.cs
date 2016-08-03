using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.存储;

namespace UI
{
    [ToolboxItem(false)]
    public partial class F更新日志 : UserControl
    {
        public F更新日志()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.pdfViewer1.DocumentFilePath = H路径.获取绝对路径("更新日志.pdf");
            //this.pdfViewer1.LoadDocument(H路径.获取绝对路径("更新日志.pdf"));
        }
    }
}
