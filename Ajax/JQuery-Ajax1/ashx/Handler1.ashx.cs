using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax.JQuery_Ajax
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {
        //.ashx文件适合产生供浏览器处理的、不需要回发处理的数据格式，例如用于生成动态图片、动态文本等内容
        //可以非常轻量级的处理HTTP请求，不用走繁琐的页面生命周期处理各种非必需数据。
        //Newtonsoft.Json 是.NET 下开源的json格式序列号和反序列化的类库.官方网站: 
        //http://json.codeplex.com/
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.ContentType = "text/html";
            //context.Response.ContentType = "application/json";
            //context.Response.Write("Hello World");

            string action = context.Request["action"];//获取data中的action的值
            switch (action)
            {
                case "getTime":
                    context.Response.Write(GetTime());
                    break;
                case "getDate":
                    context.Response.Write(GetDate());
                    break;
            }
            //context.Response.End();//停止Response后续写入动作,保证Response内只有我们写入内容
        }

        //成员IsReusable指定此IhttpHandler的实例是否可以被用来处理多个请求。
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// 获取日期
        /// </summary>
        /// <returns></returns>
        private string GetDate() {
            return DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// 获取时间
        /// </summary>
        /// <returns></returns>
        private string GetTime() {
            return DateTime.Now.ToShortTimeString();
        }
    }
}