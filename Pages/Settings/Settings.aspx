<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="AchieveDream.Pages.Settings.Settings" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    设置
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="Settings.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <div>
        <hr />
         <asp:Button runat="server" Text="黑名单管理" CssClass="clickCard"/>
        <asp:Button runat="server" Text="消息清理" CssClass="clickCard"/>
         <asp:Button runat="server" Text="隐私政策" CssClass="clickCard"/>
        <asp:Button runat="server" Text="帮助" CssClass="clickCard"/>
        <asp:Button runat="server" Text="反馈：WX：Didnelpsun" CssClass="clickCard"/>
    </div>
</asp:Content>
