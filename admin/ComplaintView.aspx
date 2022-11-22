<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="ComplaintView.aspx.cs" Inherits="shopingsite.admin.ComplaintView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <center>
        <h3 align="center"> Registered Complaints</h3>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="cmpid" >
            <Columns>
                <asp:BoundField DataField="username" HeaderText="Customer Name" />
                <asp:BoundField DataField="productname" HeaderText="Product Name" />
                <asp:BoundField DataField="details" HeaderText="Complaint" />
                <asp:BoundField DataField="status" HeaderText="Status" />
                <asp:CommandField DeleteText="approve" HeaderText="Confirmation" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <h3 align="center"> In Process and Closed Complaints</h3>

        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="cmpid" OnRowDeleting="GridView2_RowDeleting" >
            <Columns>
                <asp:BoundField DataField="username" HeaderText="User Anme" />
                <asp:BoundField DataField="productname" HeaderText="Product Name" />
                <asp:BoundField DataField="details" HeaderText="complaint" />
                <asp:BoundField DataField="status" HeaderText="Status" />
                <asp:CommandField DeleteText="close" HeaderText="Confirmation" ShowDeleteButton="True" />
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
    
</asp:Content>
