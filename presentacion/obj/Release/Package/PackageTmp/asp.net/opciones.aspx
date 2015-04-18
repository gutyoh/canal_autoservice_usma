<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="opciones.aspx.cs" Inherits="presentacion.asp.net.opciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="..\css\styles.css"/>

</head>
<body>

    <div id="header">
        <div id="header_content">
            <img src="..\img\logo.png"/>

        </div>
    </div>

    <section>
        <form id="form2" runat="server">
            <div style="margin-left: 40px">
                <asp:Label ID="label_Bienvenido" runat="server" Text="Bienvenido, "></asp:Label>
                <asp:Label ID="label_nombreCliente" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
            </div>
         
                <select id="caja_desplegable" name="caja_desplegable" runat="server">
                    <option selected disabled>--Seleccione una opcion--</option>
                    <option value="Crear Cuentas">Crear Cuentas</option>
                    <option value="Consultas">Consultas</option>
                </select>
                
                 <br/><br/>
            
            <asp:Button ID="button2" Text="Ingresar" runat="server" OnClick="button2_Click"/>
                
            <br /><br />

            <div>  <asp:Button ID="button_Salir" runat="server" OnClick="button_Salir_Click" Text="Salir" /> </div>
                
        </form>
    </section>

    <div id="copyright">
        <br/>
        Copyright - USMA&#174;
    </div>

</body>
</html>
