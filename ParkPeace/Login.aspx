<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ParkPeace.Login" %>
<style>
  body 
  { background: url('/Images/park.jpg');
    background-size: cover; 
  }
</style>
<body">
    <form id="form1" runat="server">
        <div >
            <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
                <asp:TableRow>
                    <asp:TableCell ColumnSpan ="2">
                        <asp:Label ID="Label1" runat="server"  style="font:normal 40px bold,Georgia;color:white; text-shadow: 3px 3px 3px #990066,
             4px 4px 4px #990033" Text="Авторизация"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label2" runat="server" style="font:normal 20px bold,Georgia;color:white" Text="Логин"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label3" runat="server" style="font:normal 20px bold,Georgia;color:white" Text="Пароль"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Right">
                        <asp:Button ID="Button1" runat="server" Height="34" Width="60" Text="Войти" OnClick="Button1_Click" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>

