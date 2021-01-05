<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Friends.aspx.cs" Inherits="AchieveDream.Pages.Friends.Friends" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    我的好友
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="Friends.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <div id="FriendsBoard">
        <div id="RefreshBox">
            <asp:ImageButton runat="server" ImageUrl="~/Resource/image/mine/refresh.png" CssClass="refresh"/>
        </div>
        <hr />
        <span>
            您的好友列表为空
        </span>
    </div>
</asp:Content>
