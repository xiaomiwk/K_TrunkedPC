using System;
using System.Windows.Forms;

namespace UI.调度.通话
{
    public partial class F高级呼叫 : DevExpress.XtraEditors.XtraForm
    {
        public F高级呼叫()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.do呼叫.Click += do呼叫_Click;
            this.do手动输入号码.Click += do手动输入号码_Click;
        }

        void do手动输入号码_Click(object sender, EventArgs e)
        {
            this.out容器.Controls.Remove(this.out默认号码);
            var __键盘 = new F通话_键盘输入 {Dock = DockStyle.Top};
            this.out容器.Controls.Add(__键盘);
            this.Height += __键盘.Height - this.out默认号码.Height;
        }

        void do呼叫_Click(object sender, EventArgs e)
        {
            On开始呼叫(null);
            this.Close();
        }

        public event Action<object> 开始呼叫;

        protected virtual void On开始呼叫(object obj)
        {
            Action<object> handler = 开始呼叫;
            if (handler != null) handler(obj);
        }

    }
}