<%@ Page Title="" Language="C#" MasterPageFile="~/View/Guest/GuestLayout.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="FinalProject_A.View.Guest.RegisterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Register Page</h1>
    </div>
    <div>
        <asp:Label ID="usernamelbl" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="usernametb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="emaillbl" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailtb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="genderlbl" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="GenderGroup" Text="Male" Value="1" />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="GenderGroup" Text="Female" Value="2" />
    </div>
    <div>
        <asp:Label ID="passwordlbl" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="passwordtb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="cpasswordlbl" runat="server" Text="Confirmation Password"></asp:Label>
        <asp:TextBox ID="cpasswordtb" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="doblbl" runat="server" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="dobtb" runat="server" type="Date"></asp:TextBox>
    </div>
    <div>
        Already have an account yet?
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/View/Guest/LoginPage.aspx">Login</asp:HyperLink>
    </div>
    <asp:Button ID="Registerbtn" runat="server" Text="Register" OnClick="Registerbtn_Click" />
    <asp:Label ID="errorlbl" runat="server" Text=""></asp:Label>
</asp:Content>
