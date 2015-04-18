<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="presentacion.asp.net.Calendario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="..\css\pikaday.css" rel ="stylesheet" type="text/css" />
    <link href="..\css\site.css" rel="stylesheet" type="text/css" />
    <link href="..\css\theme.css" rel="stylesheet" type="text/css" />
    <script src ="pikaday.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" > </asp:TextBox>
                    <script type="text/javascript">
                        var picker = new Pikaday(
                            {
                                field: document.getElementById('TextBox1'),
                                firstDay1: 1,
                                minDate: new Date('2000-01-01'),
                                maxDate: new Date('2020-12-31'),
                                yearRange: [2000, 2020],
                                numberOfMonths: 1,
                                theme: 'dark-theme'
                            });
                    </script>   
    </div>
    </form>
</body>
</html>
