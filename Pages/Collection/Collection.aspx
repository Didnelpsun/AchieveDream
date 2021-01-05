<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Collection.aspx.cs" Inherits="AchieveDream.Pages.Collection.Collection" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    收藏
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="Collection.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <div class="cc">
        <div style="width:50vw;" class="ra">
            <asp:Button runat="server" Text="收藏文章" CssClass="messageSwitch" OnClick="Switch" ID="CollectArticle"/>
            <asp:Button runat="server" Text="关注用户" CssClass="messageSwitch notSelected" OnClick="Switch" ID="ColllectUser"/>
        </div>
        <hr />
        <asp:Panel runat="server" ID="MessageContent" CssClass="MessageContent">
            <span>暂无消息</span>
        </asp:Panel>
    </div>
</asp:Content>
