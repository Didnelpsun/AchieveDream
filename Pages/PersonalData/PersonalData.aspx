<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalData.aspx.cs" Inherits="AchieveDream.Pages.PersonalData.PersonalData" MasterPageFile="/Templates/Navigation/Navigation.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="NavigationTitle">
    个人资料
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="NavigationHead">
    <link rel="stylesheet" type="text/css" href="PersonalData.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="NavigationContant" runat="server">
    <div id="PersonalDataBoard" class="cc">
        <img class="userHead" src="../../Resource/image/user.png" style="margin: 0px;" />
        <hr style="width: 45vw;" />
        <div style="display: block; width: 45vw; margin-top: 10px;">
            <div>
                <span style="font-weight:bold;">账号信息</span>
                <hr />
                <div class="cs">
                    <span class="inputLabel">昵称：</span>
                    <asp:TextBox runat="server" CssClass="inputText" ID="NickName"></asp:TextBox>
                </div>
                <div class="cs">
                    <span class="inputLabel">自我介绍：</span>
                    <asp:TextBox runat="server" CssClass="inputMultText" TextMode="MultiLine" ID="Description"></asp:TextBox>
                </div>
            </div>
            <hr />
            <div>
                <span style="font-weight:bold;">个人信息</span>
                <hr />
                <div class="cs">
                    <span class="inputLabel">性别：</span>
                    <asp:DropDownList runat="server" CssClass="inputText" ID="Sex">
                        <asp:ListItem Text="男" Value="1"></asp:ListItem>
                        <asp:ListItem Text="女" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="cs">
                    <span class="inputLabel">生日：</span>
                    <asp:TextBox runat="server" CssClass="inputText" TextMode="Month" ID="Birthday"></asp:TextBox>
                </div>
                <div class="cs">
                    <span class="inputLabel">所在地：</span>
                    <asp:TextBox runat="server" CssClass="inputText" ID="Location"></asp:TextBox>
                </div>
                <div class="cs">
                    <span class="inputLabel">现所在学校：</span>
                    <asp:TextBox runat="server" CssClass="inputText" ID="NowSchool"></asp:TextBox>
                </div>
                <div class="cs">
                    <span class="inputLabel">梦想院校：</span>
                    <asp:TextBox runat="server" CssClass="inputText" ID="DreamSchool"></asp:TextBox>
                </div>
            </div>
        </div>
        <asp:Button runat="server" Text="编辑" CssClass="submit" ID="Submit" OnClick="Submit_Click"/>
    </div>
</asp:Content>
