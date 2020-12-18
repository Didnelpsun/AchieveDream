﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="AchieveDream.Pages.LogIn.LogIn" MasterPageFile="/Templates/Basic/Basic.Master" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>登录界面</title>
    <link rel="stylesheet" type="text/css" href="Login.css" />
    <link rel="stylesheet" type="text/css" href="../../Resource/css/alert.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="content" runat="server">
    <div class="loginBoard cc">
        <div class="iconBox c">
            <asp:TextBox runat="server" ID="textBox1" CssClass="textBox" MaxLength="20"></asp:TextBox>
            <asp:Image runat="server" ID="lIcon1" ImageUrl="/Resource/image/user.png" CssClass="l icon" />
            <asp:ImageButton runat="server" ID="clear" ImageUrl="/Resource/image/clear.png" CssClass="r icon" OnClick="Clear_Text"/>
        </div>
        <div class="iconBox c">
            <asp:TextBox runat="server" ID="textBox2" CssClass="textBox" TextMode="Password" MaxLength="30"></asp:TextBox>
            <asp:Image runat="server" ID="lIcon2" ImageUrl="/Resource/image/password.png" CssClass="l icon" />
            <asp:ImageButton runat="server" ID="changeMode" ImageUrl="/Resource/image/eye-close.png" CssClass="r icon" OnClick="TextMode_Change" Visible="true"/>
            <asp:LinkButton runat="server" ID="sendMsgBox" CssClass="r sendMsg" Visible="false">获取验证码</asp:LinkButton> 
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
    <asp:Panel runat="server" Visible ="false" ID="alertBoard" CssClass="alertBoard">
        <div class="cc"> 
            <asp:Label runat="server" ID="alertTitle" CssClass="alertTitle">登录失败！</asp:Label>
            <hr class="alertHr"/>
        </div>
        <asp:Label runat="server" ID="alertText" CssClass="alertText"></asp:Label>
        <asp:Button runat="server" Text="确定" ID="alertConfirm" CssClass="alertConfirm" OnClick="Alert_Confirm"/>
    </asp:Panel>
</asp:Content>

