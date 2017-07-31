<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JQuery.JQuery表单.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%= DateTime.Now.ToString("yyyy-MM-dd") %>
            成功
            <label>用户名:<% =Request.Form["username"].ToString() %></label><br />
            <input type="text" name="name" value="<%=Request["password"].ToString() %>" />
        </div>
    </form>
</body>
</html>
