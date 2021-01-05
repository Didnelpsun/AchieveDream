<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="AchieveDream.Pages.Forum.Forum" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    论坛
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="Forum.css" />
    <link rel="stylesheet" type="text/css" href="../../Resource/css/alert.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <div id="ForumBoard" class="cc">
        <div class="ra">
            <asp:TextBox runat="server" ID="SearchText" CssClass="searchText"></asp:TextBox>
            <asp:ImageButton runat="server" ImageUrl="~/Resource/image/search.png" ID="Search" CssClass="search"/>
        </div>
        <hr style="width: 40vw;"/>
        <div>
            <span>暂无内容</span>
        </div>
    </div>
</asp:Content>
