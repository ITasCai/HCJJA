using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
namespace Ajax.JQuery_Ajax
{
    public partial class GET : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("AJax GET请求方法");
            string action = Request["action"].ToString();
            //清除之前生成的Response内容
            Response.Clear();
            if (!string.IsNullOrEmpty(action))
            {
                switch (action)
                {
                    case "getTime":
                        Response.Write(GetTime());
                        break;
                    case "getDate":
                        Response.Write(GetDate());
                        break;
                    case "json":
                        Response.Write(GetStringJson());
                        break;
                }
            }
            Response.End();//停止Response后续写入动作,保证Response内只有我们写入内容
        }

        /// <summary>
        /// 获取时间
        /// </summary>
        /// <returns></returns>
        public string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }

        /// <summary>
        /// 获取日期
        /// </summary>
        /// <returns></returns>
        public string GetDate()
        {
            return DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// 将集合类型序列化成json字符串类型
        /// </summary>
        /// <returns></returns>
        public string GetStringJson()
        {

            List<Student> ls = new List<Student>() {
                new Student { StuId=1001,StuName="张三"},
                new Student { StuId=1002,StuName="李四"},
                new Student { StuId=1003,StuName="王五"}
            };
            string strJson = JsonConvert.SerializeObject(ls);
            return strJson;
        }
    }
}