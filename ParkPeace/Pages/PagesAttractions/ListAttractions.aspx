<%@ Page Title="Аттракционы" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListAttractions.aspx.cs" Inherits="ParkPeace.Pages.PagesAttractions.ListAttractions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <br />
    <asp:Button ID="ButtonAdd" runat="server" Text="Добавить аттракцион" PostBackUrl="~/Pages/PagesAttractions/AddAttractions.aspx"/>
    <br />
    <br />
    <asp:GridView ID="GridViewAttractions" runat="server" CellPadding="3"  
        OnRowDeleting="GridViewAttractions_RowDeleting" OnRowEditing="GridViewAttractions_RowEditing" OnRowDataBound="GridViewAttractions_RowDataBound" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" GridLines="Horizontal">
         <AlternatingRowStyle BackColor="#F7F7F7" />
         <Columns>
            <asp:BoundField DataField="IdAttraction" HeaderText="Id"/>
            <asp:BoundField DataField="NameAttraction" HeaderText="Название аттракциона" SortExpression="NameAttraction" />
            <asp:TemplateField HeaderText="Категория">
                <itemtemplate>
                    <asp:Label ID="Role" runat="server" Text="<%# GetAttractionCategory(Container.DataItem) %>"/>
                </itemtemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Price" HeaderText="Цена" SortExpression="Price" />
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

