<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursalesSeleccionados.aspx.cs" Inherits="TP7_Grupo_Nro_3.ListadoSucursalesSeleccionados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listado Sucursales Seleccionados</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 226px;
        }
        .auto-style5 {
            width: 206px;
        }
        .auto-style6 {
            width: 305px;
        }
        .auto-style7 {
            width: 7px;
        }
        .auto-style13 {
            width: 550px;
        }
        .auto-style15 {
            width: 191px;
            margin-right: 7px;
            margin-bottom: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style13">
                        <asp:HyperLink ID="hlbtnListadoSucursalesSelec" runat="server">Listado de sucursales</asp:HyperLink>
                    </td>

                    <td class="auto-style6">
                        <asp:HyperLink ID="hlbtnSucursalesSelec" runat="server">Mostrar sucursales seleccionadas</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style13"><strong><FONT SIZE=6>Mostrar Sucursales Seleccionadas</font></strong></td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>                    
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <div style="margin-left: 180px; margin-top: 40px;" class="auto-style15">
                <asp:GridView ID="grdSucursales" runat="server"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
