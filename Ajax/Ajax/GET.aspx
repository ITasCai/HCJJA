<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GET.aspx.cs" Inherits="Ajax.Ajax.GET" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            姓名:<%=Request.QueryString["name"].ToString() %><br />
            年龄:<%=Request.QueryString["age"].ToString() %>
        </div>
    </form>
</body>
</html>
