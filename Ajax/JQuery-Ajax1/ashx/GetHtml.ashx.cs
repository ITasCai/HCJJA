using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Ajax.JQuery_Ajax.ashx
{
    /// <summary>
    /// GetHtml 的摘要说明
    /// </summary>
    public class GetHtml : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //context.Response.Write("Hello World");
            string action = context.Request["action"];
            if (action == "all")
            {
                context.Response.Write(SelectAll());
            }
            else
            {
                context.Response.Write("查无数据");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// 返回html
        /// </summary>
        /// <returns></returns>
        public string SelectAll()
        {
            List<Student> list = new List<Student>() {
                new Student() { StuId=1001,StuName="张三",StuAge=20},
                new Student() { StuId=1002,StuName="李四",StuAge=18},
                new Student() { StuId=1003,StuName="王五",StuAge=20}
            };
            StringBuilder html = new StringBuilder();
            html.AppendLine("<table border='1' width='300px' align='center'>");
            html.AppendLine("<tr>");
            html.AppendLine("<th>学生编号</th>");
            html.AppendLine("<th>学生姓名</th>");
            html.AppendLine("<th>学生年龄</th>");
            html.AppendLine("</tr>");

            foreach (Student stu in list)
            {
                html.AppendLine("<tr>");
                html.AppendLine("<td>" + stu.StuId + "</td>");
                html.AppendLine("<td>" + stu.StuName + "</td>");
                html.AppendLine("<td>" + stu.StuAge + "</td>");
                html.AppendLine("</tr>");
            }
            return html.ToString();
        }
    }
}