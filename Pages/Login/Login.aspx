<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="AchieveDream.Pages.LogIn.LogIn" MasterPageFile="/Templates/Basic/Basic.Master" %>

<asp:Content ContentPlaceHolderID="Title" runat="server">
    登录界面
</asp:Content>

<asp:Content ContentPlaceHolderID="Head" runat="server">
    <link rel="stylesheet" type="text/css" href="LogIn.css" />
    <link rel="stylesheet" type="text/css" href="../../Resource/css/alert.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="loginBoard cc">
        <div class="iconBox c">
            <asp:TextBox runat="server" ID="TextBox1" CssClass="textBox" MaxLength="20"></asp:TextBox>
            <asp:Image runat="server" ID="LIcon1" ImageUrl="/Resource/image/user.png" CssClass="l icon" />
            <asp:ImageButton runat="server" ID="Clear" ImageUrl="/Resource/image/clear.png" CssClass="r icon" OnClick="Clear_Text"/>
        </div>
        <div class="iconBox c">
            <asp:TextBox runat="server" ID="TextBox2" CssClass="textBox" TextMode="Password" MaxLength="30"></asp:TextBox>
            <asp:Image runat="server" ID="LIcon2" ImageUrl="/Resource/image/password.png" CssClass="l icon" />
            <asp:ImageButton runat="server" ID="ChangeMode" ImageUrl="/Resource/image/eye-close.png" CssClass="r icon" OnClick="TextMode_Change" Visible="true"/>
            <asp:LinkButton runat="server" ID="SendMsgBox" CssClass="r sendMsg" Visible="false">获取验证码</asp:LinkButton> 
        </div>
        <div class="middle text">
            <asp:LinkButton runat="server" CssClass="pointer" ID="PatternButton" OnClick="Pattern_Change">手机号登录 →</asp:LinkButton>
        </div>
        <asp:Button runat="server" ID="Submit" CssClass="submit" Text="登录" OnClick="Submit_Click" />
        <div class="text ra">
            <asp:LinkButton runat="server" CssClass="pointer" ID="Logon" OnClick="Logon_Click">注册</asp:LinkButton>
            <asp:LinkButton runat="server" ID="Forget" CssClass="pointer" Visible="true" OnClick="Forget_Click">忘记密码？</asp:LinkButton>
            <asp:LinkButton runat="server" ID="ChangePhone" CssClass="pointer" Visible="false">更换手机？</asp:LinkButton>
        </div>
    </div>
    <asp:Panel runat="server" Visible ="false" ID="AlertBoard" CssClass="alertBoard">
        <div class="cc"> 
            <asp:Label runat="server" ID="AlertTitle" CssClass="alertTitle">登录失败！</asp:Label>
            <hr class="alertHr"/>
        </div>
        <asp:Label runat="server" ID="AlertText" CssClass="alertText"></asp:Label>
        <asp:Button runat="server" Text="确定" ID="AlertConfirm" CssClass="alertConfirm" OnClick="Alert_Confirm"/>
    </asp:Panel>
</asp:Content>

