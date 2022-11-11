<%@ Page Title="Категории аттракционов" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListCategory.aspx.cs" Inherits="ParkPeace.Pages.PagesCategory.ListCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <br />
    <asp:Button ID="ButtonAdd" runat="server" Text="Добавить категорию" PostBackUrl="~/Pages/PagesCategory/AddCategory.aspx"/>
    <br />
    <br />
    <asp:GridView ID="GridViewCategory" runat="server" CellPadding="3" GridLines="Horizontal" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
        OnRowDeleting="GridViewCategory_RowDeleting"  OnRowEditing="GridViewCategory_RowEditing"   >
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="IdCategory" HeaderText="Id"/>
            <asp:BoundField DataField="NameCategory" HeaderText="Название категории" SortExpression="NameCategory" />
            <asp:BoundField DataField="Description" HeaderText="Описание" SortExpression="Description" />
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