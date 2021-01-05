<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AchieveDream.Pages.Home.Home" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    圆梦首页
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="Home.css" />
    <link rel="stylesheet" type="text/css" href="../../Resource/css/alert.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <asp:Button runat="server" CssClass="topButton top1" Text="高校查询" />
    <asp:Button runat="server" CssClass="topButton top2" Text="专业查询" />
    <asp:Button runat="server" CssClass="topButton top3" Text="专家指导" />
    <div id="HomeBoard" class="cc">
        <div class="mainBoard cc">
            <span style="font-weight:bold">智能推荐</span>
            <hr style="width:40vw;"/>
            <span>暂无推荐</span>
        </div>
        <div class="mainBoard cc">
            <span style="font-weight:bold">热门话题</span>
            <hr style="width:40vw;"/>
            <span>暂无推荐</span>
        </div>
        <div class="mainBoard cc">
            <span style="font-weight:bold">高考新闻</span>
            <hr style="width:40vw;"/>
            <span>暂无推荐</span>
        </div>
    </div>
</asp:Content>
