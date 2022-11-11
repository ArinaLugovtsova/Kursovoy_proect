<%@ Page Title="Домашняя" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ParkPeace._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 style="font:normal 80px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033">Парк аттракционов "Мир"</h1>
    </div>
    <div class="col-md-4" style="font:normal 20px bold,Georgia;color:white">
            <h2>Парк</h2>
            <p>
                Здесь вы можете получить информацию о парке.
            </p>
            <p>
                <a class="btn btn-default" href="/Pages/PagesPark/ListPark">Перейти &raquo;</a>
            </p>
        </div>
        <div class="col-md-4" style="font:normal 20px bold,Georgia;color:white">
            <h2>Аттракционы</h2>
            <p>
                Здесь вы можете получить информацию об аттракционах.
            </p>
            <p>
                <a class="btn btn-default" href="/Pages/PagesAttractions/ListAttractions">Перейти &raquo;</a>
            </p>
        </div>
         <div class="col-md-4" style="font:normal 20px bold,Georgia;color:white">
            <h2>Категории аттракционов</h2>
            <p>
                Здесь вы можете получить информацию о категориях аттракционов.
            </p>
            <p>
                <a class="btn btn-default" href="/Pages/PagesCategory/ListCategory">Перейти &raquo;</a>
            </p>
        </div>
        <div class="col-md-4" style="font:normal 20px bold,Georgia;color:white">
            <h2>Сотрудники</h2>
            <p>
                Здесь вы можете получить информацию о сотрудниках.
            </p>
            <p>
                <a class="btn btn-default" href="/Pages/PagesStaff/ListStaff">Перейти &raquo;</a>
            </p>
        </div>
        <div class="col-md-4" style="font:normal 20px bold,Georgia;color:white">
            <h2>Должности</h2>
            <p>
                Здесь вы можете получить информацию о должностях сотрудников.
            </p>
            <p>
                <a class="btn btn-default" href="/Pages/PagesPost/ListPost">Перейти &raquo;</a>
            </p>
        </div>
        <div class="col-md-4" style="font:normal 20px bold,Georgia;color:white">
            <h2>Билеты</h2>
            <p>
                Здесь вы можете получить информацию о билетах.
            </p>
            <p>
                <a class="btn btn-default" href="/Pages/PagesTicket/ListTicket">Перейти &raquo;</a>
            </p>
        </div>
</asp:Content>
