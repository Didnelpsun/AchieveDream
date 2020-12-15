<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="AchieveDream.Pages.LogIn.LogIn" MasterPageFile="/Templates/Basic/Basic.Master" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>登录界面</title>
    <link rel="stylesheet" type="text/css" href="Login.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="content" runat="server">
    <div class="loginBoard cc">
        <div class="iconBox c">
            <asp:TextBox runat="server" ID="username" CssClass="textBox" MaxLength="20"></asp:TextBox>
            <asp:Image runat="server" ID="lIcon1" ImageUrl="/Resource/image/user.png" CssClass="l icon" />
        </div>
        <div class="iconBox c">
            <asp:TextBox runat="server" ID="password" CssClass="textBox" TextMode="Password" MaxLength="30"></asp:TextBox>
            <asp:Image runat="server" ID="lIcon2" ImageUrl="/Resource/image/password.png" CssClass="l icon" />
            <asp:ImageButton runat="server" ID="rIcon" ImageUrl="/Resource/image/eye-close.png" CssClass="r icon" OnClick="TextMode_Change"/>
        </div>
        <div class="middle text">
            
            <asp:LinkButton runat="server" CssClass="pointer" ID="patternButton" OnClick="Pattern_Change">手机号登录 →</asp:LinkButton>
        </div>
        <asp:Button runat="server" ID="submit" CssClass="submit" Text="登录" OnClick="Submit_Click" />
        <div class="text ca">
            <asp:LinkButton runat="server" CssClass="pointer" ID="logon" OnClick="Logon_Click">注册</asp:LinkButton>
            <asp:LinkButton runat="server" ID="forget" CssClass="pointer" Visible="true" OnClick="Forget_Click">忘记密码？</asp:LinkButton>
            <asp:LinkButton runat="server" ID="changePhone" CssClass="pointer" Visible="false">更换手机？</asp:LinkButton>
        </div>
    </div>
</asp:Content>

