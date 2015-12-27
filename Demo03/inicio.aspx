<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Demo03.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Bienvenido</h1>
        <h2>Listado de Categorías</h2>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/crearcategoria.aspx">Agregar</asp:LinkButton>
        <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
    </div>
    </form>
</body>
</html>
