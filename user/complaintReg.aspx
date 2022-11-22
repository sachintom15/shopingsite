<%@ Page Title="" Language="C#" MasterPageFile="~/user/usermaster.Master" AutoEventWireup="true" CodeBehind="complaintReg.aspx.cs" Inherits="shopingsite.user.complaintReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2>Register Complaint</h2>
         <table>
                <tr>
                    <td>
                        <asp:Label ID="product" runat="server" Text="Your Product:" ></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Style="margin-left: 8px" Width="148px">
                        </asp:DropDownList></td>
                </tr>
                
               
                <tr>
                    <td>
                        <asp:Label ID="msg" runat="server" Text="Your Complaint" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="complaint" runat="server" Style="margin-left: 6px; margin-top: 8px;" Width="442px" Height="94px"></asp:TextBox>
                    </td>
                </tr>
               
               
                </table>
        <br />
        <asp:Button runat="server" Text="Register Complaint" OnClick="Unnamed1_Click" />
    </center>
</asp:Content>
