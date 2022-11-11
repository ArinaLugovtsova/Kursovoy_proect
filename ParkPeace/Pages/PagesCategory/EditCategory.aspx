<%@ Page Title="Редактирование категории" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCategory.aspx.cs" Inherits="ParkPeace.Pages.PagesCategory.EditCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <asp:Label ID="LabelMessage" runat="server"></asp:Label>
    <br />
    <table>
         <tr>
            <td style="color: white">Название категории:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxNameCategory" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="color: white">Описание:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxDescription" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/PagesCategory/ListCategory.aspx">Отмена</asp:HyperLink>
    &nbsp;
   <asp:Button ID="ButtonSave" runat="server" Text="Сохранить"  OnClick="ButtonSave_Click"/>
</asp:Content>