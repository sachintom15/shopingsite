<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.Master" AutoEventWireup="true" CodeBehind="queryview.aspx.cs" Inherits="shopingsite.admin.queryview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h3 align="center"> View Querys</h3>
    <br />
    <center>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="querryid">
        <Columns>
            <asp:BoundField DataField="details" HeaderText="Query" />
            <asp:BoundField DataField="username" HeaderText="Customer Name" />
            <asp:BoundField DataField="date" HeaderText="Date" />
            <asp:HyperLinkField DataNavigateUrlFields="querryid" HeaderText="Reply" Text="Go" DataNavigateUrlFormatString="Reply.aspx?qid={0}" />
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
      <br /
          <br />
      <br />
      <br /

</asp:Content>
