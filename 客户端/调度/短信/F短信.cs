using System;
using System.ComponentModel;
using UI.基础;

namespace UI.调度.短信
{
    [ToolboxItem(false)]
    public partial class F短信 : F多模块功能窗口
    {
        private static readonly string _类型名 = typeof(F短信).Name;

        //private F短信_发送短信 _F短信_发送短信;

        private F短信_短信箱 _F短信_短信箱;

        private F短信_短信模板 _F短信_短信模板;

        public F短信()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //_F短信_发送短信 = new F短信_发送短信 {};
            //this.增加子功能("发短信", _F短信_发送短信);

            _F短信_短信箱 = new F短信_短信箱 {};
            this.增加子功能("短信箱", _F短信_短信箱);

            _F短信_短信模板 = new F短信_短信模板 {};
            this.增加子功能("短信模板", _F短信_短信模板);

            this.激活子功能("短信箱"); //需要后台运行
        }

    }
}
