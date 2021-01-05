<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="AchieveDream.Pages.Message.Message" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    消息
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="Message.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <div class="cc">
        <div style="width:50vw;" class="ra">
            <asp:Button runat="server" Text="论坛评论" CssClass="messageSwitch" OnClick="Switch" ID="MessageComment"/>
            <asp:Button runat="server" Text="聊天回复" CssClass="messageSwitch notSelected" OnClick="Switch" ID="MessageReply"/>
        </div>
        <hr />
        <asp:Panel runat="server" ID="MessageContent" CssClass="MessageContent">
            <span>暂无消息</span>
        </asp:Panel>
    </div>
</asp:Content>
