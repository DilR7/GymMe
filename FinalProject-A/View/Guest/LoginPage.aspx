<%@ Page Title="" Language="C#" MasterPageFile="~/View/Guest/GuestLayout.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FinalProject_A.View.Guest.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Login Page</h1>
    </div>
    <div>
        <asp:Label ID="usernamelbl" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="usernametb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="passwordlbl" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="passwordtb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:CheckBox ID="CheckBox" runat="server" Text="Remember Me" />
    </div>
    <div>
        Don't have an account yet?
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/View/Guest/RegisterPage.aspx">Register</asp:HyperLink>
    </div>
    <asp:Button ID="loginbtn" runat="server" Text="Login" OnClick="loginbtn_Click" />
    <asp:Label ID="errorlbl" runat="server" Text=""></asp:Label>
</asp:Content>
