using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace JQuery.JQuery_Ajax
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
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            Student stu = new Student();
            int id = Convert.ToInt32(context.Request.Form["StuId"]);
            if (id == 1)
            {
                stu.StuName = "john";
            }
            else {
                stu.StuName = "tina";
            }
            string stuJsonString = JsonConvert.SerializeObject(stu);//序列化返回一个json格式的字符串
            context.Response.Write(stuJsonString);
        }

        //成员IsReusable指定此IhttpHandler的实例是否可以被用来处理多个请求。
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

   
}