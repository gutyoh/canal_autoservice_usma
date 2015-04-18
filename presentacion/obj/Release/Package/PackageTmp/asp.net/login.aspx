<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="presentacion.asp.net.login" %>

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
            Usuario:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    <asp:TextBox ID="txbox1" runat="server"/> <br/><br/>
            Contrase&ntildea:&nbsp; <asp:TextBox ID="txbox2" TextMode="Password" runat="server" OnTextChanged="txbox2_TextChanged"/> <br/><br/>
            <asp:Button ID="button1" Text="Iniciar Sesion" runat="server" OnClick="button1_Click"/>
        </form>
    </section>

    <div id="copyright">
        <br/>
        Copyright - USMA&#174;
    </div>

</body>
</html>
