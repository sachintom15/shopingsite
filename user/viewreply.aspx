<%@ Page Title="" Language="C#" MasterPageFile="~/user/usermaster.Master" AutoEventWireup="true" CodeBehind="viewreply.aspx.cs" Inherits="shopingsite.user.viewreply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>

     <br />

    <h3 align="center">View Reply</h3>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="productname" HeaderText="Product Name" />
            <asp:BoundField DataField="details" HeaderText="your Querry" />
            <asp:BoundField DataField="reply" HeaderText="Admin's Reply" />
        </Columns>
     </asp:GridView>
        </center>
</asp:Content>
