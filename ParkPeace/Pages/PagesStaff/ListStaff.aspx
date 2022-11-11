<%@ Page Title="Сотрудники" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListStaff.aspx.cs" Inherits="ParkPeace.Pages.PagesStaff.ListStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <br />
    <asp:Button ID="ButtonAdd" runat="server" Text="Добавить сотрудника" PostBackUrl="~/Pages/PagesStaff/AddStaff.aspx"/>
    <br />
    <br />
    <asp:GridView ID="GridViewStaff" runat="server" CellPadding="3"
         OnRowDeleting="GridViewStaff_RowDeleting" OnRowEditing="GridViewStaff_RowEditing" OnRowDataBound="GridViewStaff_RowDataBound" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" GridLines="Horizontal" Height="236px" Width="1331px">
         <AlternatingRowStyle BackColor="#F7F7F7" />
         <Columns>
             <asp:BoundField DataField="IdStaff" HeaderText="Id"/>
             <asp:BoundField DataField="NameStaff" HeaderText="Имя сотрудника" SortExpression="NameStaff" />
             <asp:BoundField DataField="Number" HeaderText="Номер телефона" SortExpression="Number" />
             <asp:BoundField DataField="Mail" HeaderText="Электронная почта" SortExpression="Mail" />
             <asp:BoundField DataField="BirthDate" HeaderText="Дата рождения" SortExpression="BirthDate"   DataFormatString = "{0:dd, MMM yyyy}" />
             <asp:BoundField DataField="AddressStaff" HeaderText="Адрес сотрудника" SortExpression="AddressStaff" />
              <asp:TemplateField HeaderText="Должность">
                <itemtemplate>
                    <asp:Label ID="Role" runat="server" Text="<%# GetStaffPost(Container.DataItem) %>"/>
                </itemtemplate>
            </asp:TemplateField>
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
