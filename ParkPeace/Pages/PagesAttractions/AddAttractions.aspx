<%@ Page Title="Добавление аттракциона" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAttractions.aspx.cs" Inherits="ParkPeace.Pages.PagesAttractions.AddAttractions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <asp:Label ID="LabelMessage" runat="server"></asp:Label>
    <br />
    <table>
         <tr>
            <td style="color: white">Название аттракциона:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxNameAttraction" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td style="color: white">Категория:&nbsp;</td>
            <td><asp:DropDownList ID="DropDownListIdCategory" runat="server" /></td>
        </tr>
        <tr>
            <td style="color: white">Цена:&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/PagesAttractions/ListAttractions.aspx">Отмена</asp:HyperLink>
    &nbsp;
   <asp:Button ID="ButtonSave" runat="server" Text="Сохранить"  OnClick="ButtonSave_Click"/>
</asp:Content>















