<%@ Page Title="Парк" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPark.aspx.cs" Inherits="ParkPeace.Pages.PagesPark.ListPark" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <asp:GridView ID="GridViewPark" runat="server" 
        OnRowDataBound="GridViewPark_RowDataBound" OnRowDeleting="GridViewPark_RowDeleting" OnRowEditing="GridViewPark_RowEditing" CellPadding="3" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" GridLines="Horizontal">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="IdPark" HeaderText="Id"/>
            <asp:BoundField DataField="NamePark" HeaderText="Название парка" SortExpression="NamePark" />
            <asp:BoundField DataField="AddressPark" HeaderText="Адрес парка" SortExpression="AddressPark" />
            <asp:BoundField DataField="OpeningTime" HeaderText="Время открытия" SortExpression="OpeningTime"  DataFormatString = "{0:HH:mm}" />
            <asp:BoundField DataField="ClosingTime" HeaderText="Время закрытия" SortExpression="ClosingTime" DataFormatString = "{0:HH:mm}" />
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