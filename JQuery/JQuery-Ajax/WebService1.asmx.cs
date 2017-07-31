using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
namespace JQuery.JQuery_Ajax
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]//令WebService成功传入Json参数，并以Json形式返回结果

    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        /// <summary>
        /// 无任何参数
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello";
        }

        //带有参数
        [WebMethod]
        public string Hello(string name)
        {
            return string.Format("Hello {0}", name);
        }

        /// <summary>
        /// 返回对象类型
        /// </summary>
        /// <param name="StuId"></param>
        /// <returns></returns>
        [WebMethod]
        public Student GetStudent(int StuId)
        {
            if (StuId == 1)
            {
                return new Student() { StuId = 1, StuName = "john", StuAge = 20 };
            }
            else
            {
                return new Student() { StuId = 2, StuName = "tina", StuAge = 22 };
            }
        }

        /// <summary>
        /// 返回泛型集合
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Student> GetStuList()
        {
            List<Student> list = new List<Student>() {
                new Student() { StuId=1001,StuName="张三",StuAge=20},
                new Student() { StuId=1002,StuName="李四",StuAge=18},
                new Student() { StuId=1003,StuName="王五",StuAge=20}
            };
            return list;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [WebMethod]
        public bool ValdateLogin(string userName, string password)
        {
            if (userName == "admin" && password == "123")
            {
                return true;
            }
            return false;
        }
    }
}
