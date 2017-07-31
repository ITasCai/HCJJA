<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ajax.JQuery_Ajax.Login" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>用户登录</title>
    <style>
        .login {
            margin: 10px auto;
            width: 400px;
            padding-top:30px;
        }

        fieldset {
            height: 200px;
        }

        .items {
            width: 100%;
            height: 30px;
            margin-left: 30px;
        }

        label {
            display: inline-block;
            width: 60px;
        }
    </style>
    <script src="../Scripts/jquery-3.1.1.js"></script>
    <script>
        $(document).ready(function () {
            $("#btnLogin").click(function () {
                var username = $("#username").val();//用户名
                var userpwd = $("#userpwd").val();//密码
                $.ajax({
                    type: "post",
                    contentType: "application/json",
                    url: "WebService1.asmx/ValdateLogin",
                    data: "{userName:'" + username + "',password:'" + userpwd + "'}",
                    //dataType: "json",
                    beforeSend: function (xhr) {
                        $("#msg1").text("");
                        $("#msg2").text("");
                        if (username.trim().length == 0) {
                            $("#msg1").text("请输入用户名!").css("color", "red");
                            return false;
                        } else if (userpwd.trim().length == 0) {
                            $("#msg2").text("请输入密码!").css("color", "red");
                            return false;
                        }
                    },
                    success: function (data, status) {
                        if (data.d==true) {
                            window.location.href = "Success.aspx";
                        } else {
                            alert("用户名或密码错误!");
                        }
                    }
                });
            });
        });
        function CheckUserName() {
            var username = $("#username").val();
            alert(username);
        }
    </script>
</head>
<body>
    <div class="login">
        <fieldset>
            <legend>用户登录</legend>
            <form id="form1" runat="server">
                <div class="items">
                    <label for="username">用户名:</label>
                    <input type="text" name="username" id="username" value="" placeholder="输入用户名" />
                    <span id="msg1"></span>
                </div>
                <div class="items">
                    <label for="userpwd">密码:</label>
                    <input type="password" name="userpwd" id="userpwd" value="" placeholder="输入密码" />
                    <span id="msg2"></span>
                </div>
                <div class="items">
                    <input type="button" name="name" id="btnLogin" value="登录" />
                </div>
            </form>
        </fieldset>
    </div>
</body>
</html>
