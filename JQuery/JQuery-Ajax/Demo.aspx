<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="JQuery.JQuery_Ajax.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <p style='color:red;'>
       用户名:<%=Request["username"].ToString() %><br />
       年龄:<%=Request["age"].ToString() %>
   </p>
</body>
</html>
