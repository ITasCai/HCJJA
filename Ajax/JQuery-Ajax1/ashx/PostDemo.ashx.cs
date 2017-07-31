using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace Ajax.JQuery_Ajax.ashx
{
    /// <summary>
    /// PostDemo 的摘要说明
    /// </summary>
    public class PostDemo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            context.Response.ContentType = "application/json";
            User user = new User();
            user.UserName = context.Request["UserName"];
            user.Password = context.Request["Password"];
            user.UserAge = Convert.ToInt32(context.Request["UserAge"]);
            context.Response.Write(Register(user));

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public string Register(User user)
        {
            string strJson = JsonConvert.SerializeObject(user);
            return strJson;
        }
    }
}