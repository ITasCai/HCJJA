using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Web.Services;
namespace Ajax.JQuery_Ajax
{
    public partial class POST : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            string result = Login();
            Response.Write(JsonConvert.SerializeObject(result));
            Response.End();
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        public string Login()
        {
            string username = Request["UserName"].ToString();
            string password = Request["UserPwd"].ToString();
            if (username == "admin" && password == "123")
            {
                return "success";
            }
            return "fail";

            //string json = "{\"UserName\":\"" + username + "\",\"UserPwd\":\"" + password + "\"}";
            //return json;
        }

        [WebMethod]
        public static string GetTime(string type)
        {
            if (type == "1")
            {
                return DateTime.Now.ToShortDateString();
            }
            return DateTime.Now.ToShortTimeString();
        }
    }
}