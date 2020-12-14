<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AchieveDream.Pages.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录页面</title>
    <link rel="stylesheet" type="text/css" href="Login.css"/>
</head>
<body>
    <form id="login" runat="server">
        <div id="backBoard">
            <div id="loginBoard">
                <asp:TextBox runat="server" ID="username" CssClass="textBox"></asp:TextBox>
                <asp:TextBox runat="server" ID="password" CssClass="textBox" TextMode="Password"></asp:TextBox>
                <asp:Button runat="server" ID="submit" CssClass="submit" Text="登录"/>
            </div>
        </div>
    </form>
</body>
</html>
