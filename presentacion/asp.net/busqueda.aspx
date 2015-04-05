<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="busqueda.aspx.cs" Inherits="presentacion.asp.net.busqueda" %>

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
            <div id="text_in_form">
                &nbsp;Ingrese Cédula del cliente <br/><br/>
                <asp:TextBox ID="txbox_Cedula" runat="server"/> <br/><br/>
            </div>
            <asp:Button ID="button2" Text="Buscar" runat="server" OnClick="button2_Click"/>
        </form>
    </section>

    <div id="copyright">
        <br/>
        Copyright - USMA&#174;
    </div>

</body>
</html>