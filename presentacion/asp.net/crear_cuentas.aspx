<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crear_cuentas.aspx.cs" Inherits="presentacion.asp.net.crear_cuentas" %>

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

    <div id="content_crear_cuenta">
        
        <p> <asp:Label ID="label1" runat="server" Text="Nombre"/>&nbsp;&nbsp; /&nbsp; <asp:Label ID="label2" runat="server" Text="Cedula"/>   </p>


        <form id="form5" runat="server">
            

        <div id="content_line2">
            <div class="linea2" id="debitar1">
                Seleccione la cuenta a debitar <br/><br/>

                &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="dsDropDownListCuenta" DataTextField="id_cuenta" DataValueField="id_cuenta">
                </asp:DropDownList>
                <asp:SqlDataSource ID="dsDropDownListCuenta" runat="server" ConnectionString="<%$ ConnectionStrings:conexionBANCODB %>" ProviderName="<%$ ConnectionStrings:conexionBANCODB.ProviderName %>" SelectCommand="PA_SELECT_CUENTA" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:SessionParameter Name="id_cliente" SessionField="id_cliente" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <br />

                </div>

            <img class="linea2" id="flecha1" src="..\img\arrow.png" />

            <div class="linea2" id="tipo_cuenta1">
                Seleccione el tipo de cuenta <br/><br/>

                <select runat="server" id="seleccion_cuenta1">
                    <option disabled selected>--Seleccione Tipo--</option>
                    <option>Ahorro</option>
                    <option>Corriente</option>
                </select>

            </div>


            <asp:Button ID="button5" Text="Crear Cuenta" runat="server" OnClick="button5_Click"/>


            <div style="margin-left: 10px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_cuenta" DataSourceID="dsGridViewCuentas">
                    <Columns>
                        <asp:BoundField DataField="id_cuenta" HeaderText="Número de Cuenta" InsertVisible="False" ReadOnly="True" SortExpression="id_cuenta" />
                        <asp:BoundField DataField="desc_tipo" HeaderText="Tipo de cuenta" SortExpression="desc_tipo" />
                        <asp:BoundField DataField="balance" HeaderText="Balance" SortExpression="balance" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>


            <asp:SqlDataSource ID="dsGridViewCuentas" runat="server" ConnectionString="<%$ ConnectionStrings:conexionBANCODB %>" ProviderName="<%$ ConnectionStrings:conexionBANCODB.ProviderName %>" SelectCommand="PA_SELECT_DESC_CUENTA" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="id_cliente" SessionField="id_cliente" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>


                &nbsp;</form>


    </div>

    <div id="copyright">
        <br/>
        Copyright - USMA&#174;
    </div>

</body>
</html>