<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOn.aspx.cs" Inherits="AchieveDream.Pages.LogOn.LogOn" MasterPageFile="/Templates/Basic/Basic.Master" %>

<asp:Content ContentPlaceHolderID="Head" runat="server">
    <title>注册页面</title>
    <link rel="stylesheet" type="text/css" href="LogOn.css" />
    <link rel="stylesheet" type="text/css" href="../../Resource/css/alert.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="logonBoard cc">
        <asp:TextBox runat="server" ID="userName"></asp:TextBox>
        <asp:TextBox runat="server" ID="passWord"></asp:TextBox>
        <asp:TextBox runat="server" ID="confirmWord"></asp:TextBox>
    </div>
</asp:Content>
