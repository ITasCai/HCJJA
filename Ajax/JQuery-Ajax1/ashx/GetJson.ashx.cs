using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace Ajax.JQuery_Ajax.ashx
{
    /// <summary>
    /// GetJson 的摘要说明
    /// </summary>
    public class GetJson : IHttpHandler
    {
        //Newtonsoft.Json 是.NET 下开源的json格式序列号和反序列化的类库.官方网站: 
        //http://json.codeplex.com/
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.ContentType = "text/html";
            //context.Response.ContentType = "application/json";

            string action = context.Request["action"];
            object result = null;
            switch (action)
            {
                case "select":
                    result = GetUserInfo();
                    break;
                case "all":
                    result = SelectAll();
                    break;
            }
            string json = JsonConvert.SerializeObject(result);//序列化返回一个json格式的字符串
            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// 返回对象
        /// </summary>
        /// <returns></returns>
        public Student GetUserInfo()
        {
            Student student = new Student();
            student.StuId = 1001;
            student.StuName = "张三";
            student.StuAge = 20;
            return student;
        }

        /// <summary>
        /// 返回集合
        /// </summary>
        /// <returns></returns>
        public List<Student> SelectAll()
        {
            List<Student> list = new List<Student>() {
                new Student() { StuId=1001,StuName="张三",StuAge=20},
                new Student() { StuId=1002,StuName="李四",StuAge=18},
                new Student() { StuId=1003,StuName="王五",StuAge=20}
            };
            return list;
        }
    }
}