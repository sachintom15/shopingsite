<%@ Page Title="" Language="C#" MasterPageFile="~/guest/guestmaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="shopingsite.guest.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 align="center">Login</h3>
    <table align="center">
        <tr>
            <td>username</td>
            <td>
                <asp:TextBox ID="txtusername" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td>password</td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
       
               <asp:Button ID="btnreg" runat="server" Text="Login" OnClick="btnreg_Click" /></td>
        </tr>
    </table>
</asp:Content>
