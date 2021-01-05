<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Safety.aspx.cs" Inherits="AchieveDream.Pages.Safety.Safety" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    账户安全
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="Safety.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <div>
        <div style="padding:15px;">
            <span>当前用户名：</span>
            <asp:Label runat="server" ID="UserName"></asp:Label>
        </div>
        <hr />
         <asp:Button runat="server" Text="修改用户名" CssClass="clickCard"/>
        <asp:Button runat="server" Text="修改密码" CssClass="clickCard"/>
         <asp:Button runat="server" Text="更换绑定手机号" CssClass="clickCard"/>
        <asp:Button runat="server" Text="注销账号" CssClass="clickCard"/>
        <asp:Button runat="server" Text="退出当前登录账号" CssClass="clickCard"/>
    </div>
</asp:Content>
