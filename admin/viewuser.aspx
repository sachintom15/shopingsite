<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="viewuser.aspx.cs" Inherits="shopingsite.admin.viewuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="loginid" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="username" HeaderText="Name" />
            <asp:BoundField DataField="place" HeaderText="place" />
            <asp:BoundField DataField="pin" HeaderText="Pin No." />
            <asp:BoundField DataField="district" HeaderText="District" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="gender" HeaderText="Gender" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:CommandField DeleteText="confirm" HeaderText="Confirm User" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    </center>

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
      <br />
     <br />
    <br />
      <br />
      <br />
      <br />
     <br />
     <br />
   
</asp:Content>
