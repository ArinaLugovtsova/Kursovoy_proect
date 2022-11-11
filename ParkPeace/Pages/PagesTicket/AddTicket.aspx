<%@ Page Title="Добавление билета" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddTicket.aspx.cs" Inherits="ParkPeace.Pages.PagesTicket.AddTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <asp:Label ID="LabelMessage" runat="server"></asp:Label>
    <br />
    <table>
         <tr>
            <td style="color: white">Аттракцион:&nbsp;</td>
            <td><asp:DropDownList ID="DropDownListIdAttraction" runat="server" /></td>
        </tr>
    </table>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/PagesTicket/ListTicket.aspx">Отмена</asp:HyperLink>
    &nbsp;
   <asp:Button ID="ButtonSave" runat="server" Text="Сохранить"  OnClick="ButtonSave_Click"/>
</asp:Content>

