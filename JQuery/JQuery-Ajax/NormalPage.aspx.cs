using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JQuery.JQuery_Ajax
{
    public partial class NormalPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Request.QueryString["action"];
            Response.Clear();//清除所有之前生成的Response内容
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

        private string GetDate()
        {
            return DateTime.Now.ToShortDateString();
        }

        private string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}