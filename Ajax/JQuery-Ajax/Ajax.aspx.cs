using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
namespace Ajax.JQuery_Ajax
{
    public partial class Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Ajax请求");

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
                }
            }
            Response.End();//停止Response后续写入动作,保证Response内只有我们写入内容
        }


        /// <summary>
        /// 获取时间
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public static string GetTime()
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
    }
}