<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HTML5.HTML表单.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" action="index.aspx" method="post" runat="server">
    <div>
       <div id="login">
            <fieldset>
                <legend>用户登录</legend>
                <p>
                    <label for="userName">账号:</label>
                    <input type="text" name="userName" id="userName" placeholder="请输入用户名"
                           required="required" oninvalid="setCustomValidity('用户名不能为空')"
                           oninput="setCustomValidity('')" autofocus="autofocus" size="20" maxlength="15" />
                </p>
                <p>
                    <label for="userPwd">密码:</label>
                    <input type="password" name="userPwd" id="userPwd" required="required" placeholder="请输入密码"
                           size="20" maxlength="15" />
                </p>
                <p>
                    <input type="submit" name="login" value="登录" />
                    <input type="reset" name="reset" value="重置" />
                </p>
            </fieldset>
        </div>
    </div>
    </form>
</body>
</html>
