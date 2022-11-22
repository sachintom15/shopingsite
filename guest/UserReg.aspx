<%@ Page Title="" Language="C#" MasterPageFile="~/guest/guestmaster.Master" AutoEventWireup="true" CodeBehind="UserReg.aspx.cs" Inherits="shopingsite.guest.UserReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 align="center">User Registartion</h3>
    <table align="center">
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>username</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>password</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Gender</td>
        <td>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
               <asp:ListItem >Male</asp:ListItem>
               <asp:ListItem >Female</asp:ListItem>
            </asp:RadioButtonList><br /><br />
          </td>
        </tr>



            <tr>
            <td>Place</td>
            <td>
                <asp:TextBox ID="txtplace" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Pin.No</td>
            <td>
                <asp:TextBox ID="txtpin" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>District</td>
            <td>
                <asp:TextBox ID="txtdistrict" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtmail" runat="server"></asp:TextBox></td>
        </tr>
         
           
        
        <tr>
            <td>
               <asp:Button ID="btnreg" runat="server" Text="Register" OnClick="btnreg_Click" /></td>
        </tr>
    </table>
</asp:Content>
