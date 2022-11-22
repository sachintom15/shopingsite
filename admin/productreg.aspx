<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="productreg.aspx.cs" Inherits="shopingsite.admin.productreg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h3 align="center">Product Registartion</h3>
    <table align="center">
        
        <tr>
            <td>product name</td>
            <td>
                <asp:TextBox ID="txtproductname" runat="server"></asp:TextBox></td>
        </tr>
        
        
        
        <tr>
            <td>
               <asp:Button ID="btnreg" runat="server" Text="Register" OnClick="btnreg_Click" /></td>
        </tr>
    </table>
    <br />

    <asp:GridView ID="GridView1" align="center" runat="server" AutoGenerateColumns="False" DataKeyNames="productid" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit">
        <Columns>
            <asp:BoundField DataField="productid" HeaderText="product id" />
            <asp:BoundField DataField="productname" HeaderText="product name" />
            <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
            <asp:CommandField HeaderText="delete" ShowDeleteButton="True" />
        </Columns>

    </asp:GridView>
   <br />
    <br />
    <br />
      <br />
      <br />
      <br />
     <br />
    <br />
      <br />
      <br />
      <br />
     <br />
     <br />
    <br />
      <br />
      <br />
      <br /



</asp:Content>
