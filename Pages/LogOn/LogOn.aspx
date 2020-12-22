<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOn.aspx.cs" Inherits="AchieveDream.Pages.LogOn.LogOn" MasterPageFile="/Templates/Basic/Basic.Master" %>

<asp:Content ContentPlaceHolderID="Head" runat="server">
    <title>注册页面</title>
    <link rel="stylesheet" type="text/css" href="LogOn.css" />
    <link rel="stylesheet" type="text/css" href="../../Resource/css/alert.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="logonBoard cc">
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/user.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="userName" CssClass="textBox" MaxLength="20"></asp:TextBox>
        </div>
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/password.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="passWord" CssClass="textBox" MaxLength="20"></asp:TextBox>
        </div>
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/confirm.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="confirmWord" CssClass="textBox" MaxLength="20"></asp:TextBox>
        </div>
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/job.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="job" CssClass="textBox" MaxLength="20"></asp:TextBox>
        </div>
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/idCard.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="idCode" CssClass="textBox" MaxLength="18"></asp:TextBox>
        </div>
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/phone.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="telephone" CssClass="textBox" MaxLength="11"></asp:TextBox>
        </div>
        <asp:Button runat="server" ID="Submit" CssClass="submit" Text="登录" OnClick="Submit_Click" />
    </div>

    <asp:Panel runat="server" Visible ="false" ID="AlertBoard" CssClass="alertBoard">
        <div class="cc"> 
            <asp:Label runat="server" ID="AlertTitle" CssClass="alertTitle">注册失败！</asp:Label>
            <hr class="alertHr"/>
        </div>
        <asp:Label runat="server" ID="AlertText" CssClass="alertText"></asp:Label>
        <asp:Button runat="server" Text="确定" ID="AlertConfirm" CssClass="alertConfirm" OnClick="Alert_Confirm"/>
    </asp:Panel>
</asp:Content>
