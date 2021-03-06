﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JavaScript.JavaScript表单验证及正则表达式
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request["userName"].ToString();
            Response.Write("用户名:" + name);
            string password = Request["userPwd"].ToString();
            Response.Write("密码:" + password);
            Response.Write(Request.QueryString["type"]);
        }
//FORM中的get post方法区别Form中的get和post方法，在数据传输过程中分别对应了HTTP协议中的GET和POST方法。二者主要区别如下：  
//1、Get是用来从服务器上获得数据，而Post是用来向服务器上传递数据。  
//2、 Get将表单中数据的按照variable=value的形式，添加到action所指向的URL后面，并且两者使用“?”连接，而各个变量之间使用 “&”连接；Post是将表单中的数据放在form的数据体中，按照变量和值相对应的方式，传递到action所指向URL。  
//3、 Get是不安全的，因为在传输过程，数据被放在请求的URL中，而如今现有的很多服务器、代理服务器或者用户代理都会将请求URL记录到日志文件中，然后 放在某个地方，这样就可能会有一些隐私的信息被第三方看到。另外，用户也可以在浏览器上直接看到提交的数据，一些系统内部消息将会一同显示在用户面前。 Post的所有操作对用户来说都是不可见的。  
//4、Get传输的数据量小，这主要是因为受URL长度限制；而Post可以传输大量的数据，所以在上传文件只能使用Post（当然还有一个原因，将在后面的提到）。  
//5、Get限制Form表单的数据集的值必须为ASCII字符；而Post支持整个ISO10646字符集。  
//6、Get是Form的默认方法。  
    }
}