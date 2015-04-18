<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consultas.aspx.cs" Inherits="presentacion.asp.net.consultas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="..\css\styles.css"/>


</head>
<body>

    <form id="form1" runat="server">

    <div id="header">
        <div id="header_content">
            <img src="..\img\logo.png"/>
            <br />
            <asp:Label ID="label_Consulta" runat="server" Text="Consulta de la cuenta: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="label_Nombre" runat="server" Text="Nombre"></asp:Label>
&nbsp; /&nbsp;
            <asp:Label ID="label_Cedula" runat="server" Text="Cedula"></asp:Label>
            <br />

        </div>
    </div>

    <div id="display_content">
             <asp:GridView ID="dgvCuenta" runat="server" AutoGenerateColumns="False" DataKeyNames="id_cuenta" DataSourceID="dsGrid_cuenta" Width="1424px" CssClass="linea2">
                 <Columns>
                     <asp:BoundField DataField="id_cuenta" HeaderText="Número de cuenta" InsertVisible="False" ReadOnly="True" SortExpression="id_cuenta" />
                     <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" Visible="False" />
                     <asp:BoundField DataField="desc_tipo" HeaderText="Tipo de cuenta" SortExpression="desc_tipo" />
                     <asp:BoundField DataField="balance" HeaderText="Balance" SortExpression="balance" />
                 </Columns>
                 </asp:GridView>
             <asp:SqlDataSource ID="dsGrid_cuenta" runat="server" ConnectionString="<%$ ConnectionStrings:conexionBANCODB %>" ProviderName="<%$ ConnectionStrings:conexionBANCODB.ProviderName %>" SelectCommand="PA_SELECT_DESC_CUENTA" SelectCommandType="StoredProcedure">
                 <SelectParameters>
                     <asp:SessionParameter DefaultValue="" Name="id_cliente" SessionField="id_cliente" Type="Int32" />
                 </SelectParameters>
             </asp:SqlDataSource>
    </div>

    <div id="copyright">
        <br/>
        Copyright - USMA&#174;
    </div>

    </form>

</body>
</html>