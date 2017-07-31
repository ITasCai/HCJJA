//绑定出生年月
function yearList() {
    var year = document.getElementById("year");
    var month = document.getElementById("month");
    for (var i = 1901; i <= 2017; i++) {
        var option = new Option(i, i);
        year.options.add(option);
    }
    for (var i = 1; i <= 12; i++) {
        var option = new Option(i, i);
        month.options.add(option);
    }
}
//验证码
function createCode() {
    var code = "";
    var codelength = 4;//验证码的长度
    var checkCode = document.getElementById("checkCode");
    var codeChars = new Array(0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
         'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z');
    for (var i = 0; i < codelength; i++) {
        var num = Math.floor(Math.random() * 36);
        code += codeChars[num];
    }
    checkCode.innerText = code;
}

//验证用户名
function ValUserName() {
    var pattern = /^[a-zA-Z]{1}[a-zA-Z0-9]{5,19}$/;
    var username = document.getElementById("userName");
    var errorId = document.getElementById("errorName");
    if (username.value.trim().length == 0) {
        errMsg(errorId, "请输入用户名");
        return false;
    }
    else if (!pattern.test(username.value)) {
        errMsg(errorId, "用户名格式不正确");
        return false;
    }
    else {
        successMsg(errorId);
        return true;
    }
}

//验证密码
function ValUserPwd() {
    var pattern = /^[a-zA-Z0-9]{6,20}$/;
    var password = document.getElementById("userPwd");
    var errorId = document.getElementById("errorPwd");
    if (password.value.trim().length < 6 || password.value.trim().length > 20) {
        errMsg(errorId, "密码必须是6-20位");
        return false;
    }
    else if (!pattern.test(password.value)) {
        errMsg(errorId, "密码中含有非法字符");
        return false;
    }
    else {
        successMsg(errorId);
        return true;
    }
}

//确认密码
function ValSPwd() {
    var password = document.getElementById("userPwd");
    var spwd = document.getElementById("userSPwd");
    var errorId = document.getElementById("errorSpwd");
    if (password.value != spwd.value) {
        errMsg(errorId, "两次密码不一致");
        return false;
    }
    else {
        successMsg(errorId);
        return true;
    }
}

//验证邮箱
function ValEmail() {
    var email = document.getElementById("email");
    var pattern = /\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/;
    var errorId = document.getElementById("errorEmail");
    if (email.value.trim().length == 0) {
        errMsg(errorId, "请输入邮箱");
        return false;
    }
    else if (!pattern.test(email.value)) {
        errMsg(errorId, "邮箱格式不正确");
        return false;
    }
    else {
        successMsg(errorId);
        return true;
    }

}

//验证手机号
function ValTelphone() {
    //var pattern = /^1(3[3]|4[9]|53|7[037]|8[019])\\d{8}$/;
    var pattern = /^[1-9]\d{10}$/;
    var phone = document.getElementById("phone");
    var errorId = document.getElementById("errorPhone");
    if (phone.value.trim().length == 0) {
        errMsg(errorId, "请输入手机号");
        return false;
    }
    else if (!pattern.test(phone.value)) {
        errMsg(errorId, "请输入正确的手机号");
        return false;
    }
    else {
        successMsg(errorId);
        return true;
    }
}

//验证验证码是否正确
function ValCode() {
    var inputcode = document.getElementById("showcode");
    var compare = document.getElementById("checkCode");
    var errorId = document.getElementById("errorCode");
    if (inputcode.value.trim().length == 0) {
        errMsg(errorId, "请输入验证码");
        return false;
    }
    else if (inputcode.value != compare.innerText) {
        errMsg(errorId, "验证码不正确");
        return false;
    }
    else {
        successMsg(errorId);
        return true;
    }
}

//验证失败提示信息
function errMsg(controlId, content) {
    controlId.innerHTML = content;
}

//验证通过执行的方法
function successMsg(controlId) {
    controlId.innerHTML = "<img style='height:20px;width:20px' src='../image/duihao.png'/>";
}
//清空提示信息
function clearMsg(controlId) {
    controlId.innerHTML = "";
}

//验证全部
function CheckAll() {

    if (ValUserName() == true && ValUserPwd() == true && ValSPwd() == true &&
        ValEmail() == true && ValTelphone() == true && ValCode() == true) {
        return true;
    }
    return false;
}