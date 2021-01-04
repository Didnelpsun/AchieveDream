<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOn.aspx.cs" Inherits="AchieveDream.Pages.LogOn.LogOn" MasterPageFile="/Templates/Basic/Basic.Master" %>

<asp:Content ContentPlaceHolderID="Title" runat="server">
    注册页面
</asp:Content>

<asp:Content ContentPlaceHolderID="Head" runat="server">
    <link rel="stylesheet" type="text/css" href="LogOn.css" />
    <link rel="stylesheet" type="text/css" href="../../Resource/css/alert.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="logonBoard cc">
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/user.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="UserName" CssClass="textBox" MaxLength="20"></asp:TextBox>
        </div>
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/password.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="PassWord" CssClass="textBox" MaxLength="20"></asp:TextBox>
        </div>
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/confirm.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="ConfirmWord" CssClass="textBox" MaxLength="20"></asp:TextBox>
        </div>
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/job.png" CssClass="icon" />
            <asp:DropDownList runat="server" ID="Job" CssClass="textBox"></asp:DropDownList>
        </div>
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/id-card.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="IDCode" CssClass="textBox" MaxLength="18"></asp:TextBox>
        </div>
        <div class="iconBox c">
            <asp:Image runat="server" ImageUrl="/Resource/image/phone.png" CssClass="icon" />
            <asp:TextBox runat="server" ID="Telephone" CssClass="textBox" MaxLength="11"></asp:TextBox>
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
