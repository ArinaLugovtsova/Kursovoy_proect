<%@ Page Title="Связаться" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ParkPeace.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033"><%: Title %></h1>
    <address style="font:normal 17px bold,Georgia;color:white" >
        <strong>Контактная информация:</strong> <br />  
        Адрес: г.Ялта, пгт. Массандра, ул. Стахановская 11<br />
        Телефон: 8 919 895-03-02<br />
    </address>
    <address style="font:normal 17px bold,Georgia;color:white">
        <strong>Поддержка:</strong>   
        <a style="color:white" href="arinalugovtsova@gmail.com">arinalugovtsova@gmail.com</a><br />
    </address>
</asp:Content>
