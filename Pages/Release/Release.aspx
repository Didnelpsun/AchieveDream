<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Release.aspx.cs" Inherits="AchieveDream.Pages.Release.Release" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    发布
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="Release.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <div >
        <div id="RefreshBox">
            <asp:ImageButton runat="server" ImageUrl="~/Resource/image/mine/refresh.png" CssClass="refresh"/>
        </div>
         <hr />
        <asp:Panel runat="server" ID="MessageContent" CssClass="MessageContent">
            <span>暂无发布信息</span>
        </asp:Panel>
    </div>
</asp:Content>

