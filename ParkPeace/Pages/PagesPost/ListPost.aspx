<%@ Page Title="Должности" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPost.aspx.cs" Inherits="ParkPeace.Pages.PagesPost.ListPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <br />
    <asp:Button ID="ButtonAdd" runat="server" Text="Добавить должность"  PostBackUrl="~/Pages/PagesPost/AddPost.aspx"/>
    <br />
    <br />
    <asp:GridView ID="GridViewPost" runat="server" CellPadding="3" GridLines="Horizontal" OnRowDeleting="GridViewPost_RowDeleting" OnRowEditing="GridViewPost_RowEditing" OnRowDataBound="GridViewPost_RowDataBound" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px">
         <AlternatingRowStyle BackColor="#F7F7F7" />
         <Columns>
             <asp:BoundField DataField="IdPost" HeaderText="Id"/>
             <asp:BoundField DataField="NamePost" HeaderText="Название должности" SortExpression="NamePost" />
             <asp:BoundField DataField="Salary" HeaderText="Зарплата" SortExpression="Salary" />
             <asp:CommandField HeaderText="Удалить" ShowDeleteButton="True" ShowHeader="True" />
             <asp:CommandField HeaderText="Редактировать" ShowEditButton="True" ShowHeader="True" />
         </Columns>
         <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
         <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
         <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
         <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
         <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
         <SortedAscendingCellStyle BackColor="#F4F4FD" />
         <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
         <SortedDescendingCellStyle BackColor="#D8D8F0" />
         <SortedDescendingHeaderStyle BackColor="#3E3277" />
    </asp:GridView>
</asp:Content>