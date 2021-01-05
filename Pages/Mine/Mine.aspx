<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mine.aspx.cs" Inherits="AchieveDream.Pages.Mine.Mine" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    我的
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="Mine.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <div id="MineBoard">
        <asp:ImageButton runat="server" ImageUrl="~/Resource/image/user.png" CssClass="userHead mineHead" />
        <hr/>
        <div style="margin-top:15px;" class="ra">
            <div class="mineButton cc">
                <asp:ImageButton runat="server" cssClass="mineImage" ImageUrl="../../Resource/image/mine/个人资料.png" OnClick="Page_Turn"/>
                <span class="mineButtonText">个人资料</span>
            </div>
            <div class="mineButton cc">
                <asp:ImageButton runat="server" cssClass="mineImage" ImageUrl="../../Resource/image/mine/发布.png" OnClick="Page_Turn" />
                <span class="mineButtonText">发布</span>
            </div>
            <div class="mineButton cc">
                <asp:ImageButton runat="server" cssClass="mineImage" ImageUrl="../../Resource/image/mine/好友.png" OnClick="Page_Turn" />
                <span class="mineButtonText">好友</span>
            </div>
            <div class="mineButton cc">
                <asp:ImageButton runat="server" cssClass="mineImage" ImageUrl="../../Resource/image/mine/消息.png" OnClick="Page_Turn" />
                <span class="mineButtonText">消息</span>
            </div>
            <div class="mineButton cc">
                <asp:ImageButton runat="server" cssClass="mineImage" ImageUrl="../../Resource/image/mine/账号安全.png" OnClick="Page_Turn" />
                <span class="mineButtonText">账号安全</span>
            </div>
            <div class="mineButton cc">
                <asp:ImageButton runat="server" cssClass="mineImage" ImageUrl="../../Resource/image/mine/收藏.png" OnClick="Page_Turn" />
                <span class="mineButtonText">收藏</span>
            </div>
            <div class="mineButton cc">
                <asp:ImageButton runat="server" cssClass="mineImage" ImageUrl="../../Resource/image/mine/设置.png" OnClick="Page_Turn" />
                <span class="mineButtonText">设置</span>
            </div>
        </div>
    </div>
</asp:Content>
