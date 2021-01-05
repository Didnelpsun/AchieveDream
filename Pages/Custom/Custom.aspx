<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Custom.aspx.cs" Inherits="AchieveDream.Pages.Custom.Custom" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    定制
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="Custom.css" />
    <link rel="stylesheet" type="text/css" href="../../Resource/css/alert.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <asp:ImageButton runat="server" ImageUrl="~/Resource/image/custom/clock.png"  ID="Clock" CssClass="clock"/>
    <div id="CustomBoard" class="cc">
        <div class="ra">
            <asp:TextBox runat="server" ID="SearchText" CssClass="searchText"></asp:TextBox>
            <asp:ImageButton runat="server" ImageUrl="~/Resource/image/search.png" ID="Search" CssClass="search"/>
        </div>
        <hr style="width: 40vw;"/>
        <div>
            <span>暂无进程</span>
        </div>
    </div>
</asp:Content>
