<%@ Page Title="Добавление сотрудника" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="ParkPeace.Pages.PagesStaff.AddStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <asp:Label ID="LabelMessage" runat="server"></asp:Label>
    <br />
    <table>
        <tr>
            <td style="color: white">Должность:&nbsp;</td>
            <td><asp:DropDownList ID="DropDownListIdPost" runat="server" /></td>
        </tr>
         <tr>
            <td style="color: white">Имя сотрудника:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxNameStaff" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: white">Номер телефона:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: white">Адрес электронной почты:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxMail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: white">Дата рождения:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxBirthDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: white">Адрес сотрудника:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxAddressStaff" runat="server"></asp:TextBox>
            </td>
        </tr>
         
    </table>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/PagesStaff/ListStaff.aspx">Отмена</asp:HyperLink>
    &nbsp;
   <asp:Button ID="ButtonSave" runat="server" Text="Сохранить"  OnClick="ButtonSave_Click"/>
</asp:Content>
