<%@ Page Title="Редактирование данных о парке" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"CodeBehind="EditPark.aspx.cs" Inherits="ParkPeace.Pages.PagesPark.EditPark" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <asp:Label ID="LabelMessage" runat="server"></asp:Label>
    <br />
    <table>
         <tr>
            <td style="color: white">Название парка:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxNamePark" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: white">Адрес парка:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxAddressPark" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: white">Время открытия:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxOpeningTime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: white">Время закрытия:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxClosingTime" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/PagesPark/ListPark.aspx">Отмена</asp:HyperLink>
    &nbsp;
   <asp:Button ID="ButtonSave" runat="server" Text="Сохранить"  OnClick="ButtonSave_Click"/>
</asp:Content>



