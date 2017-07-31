<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="POST.aspx.cs" Inherits="Ajax.Ajax.POST" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style='color: red;'>
                用户名:<%=Request["username"].ToString() %><br />
                年龄:<%=Request["age"].ToString() %>
            </p>
        </div>
    </form>
</body>
</html>
