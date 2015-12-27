<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Demo03._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
        function validarDatos() {
            var usuario = document.getElementById("txtUsuario");
            var clave = document.getElementById("txtClave");

            if (usuario.value.length == 0) {
                alert("Ingrese el usuario");
                usuario.focus();
                return false;
            }
            if (clave.value,length == 0) {
                alert("Ingrese la clave");
                clave.focus();
                return false;
            }
            return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return validarDatos()">
    <div>
    
        <asp:Literal ID="Literal1" runat="server" Text="Usuario:"></asp:Literal>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Literal ID="Literal2" runat="server" Text="Password"></asp:Literal>
        <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
    
    </div>
    </form>
</body>
</html>
