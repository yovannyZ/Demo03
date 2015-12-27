<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crearcategoria.aspx.cs" Inherits="Demo03.crearcategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Literal ID="Literal1" runat="server">Nombre categoria:</asp:Literal> 
    
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
     <br />
        <asp:Button ID="btnGrabar" runat="server" Text="Grabar" OnClick="btnGrabar_Click" />
    </div>
       
    </form>
</body>
</html>
