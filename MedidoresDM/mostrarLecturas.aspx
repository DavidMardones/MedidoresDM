<%@ Page Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLecturas.aspx.cs" Inherits="MedidoresDM.MostrarLecturas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mostrar Lecturas</title>
    <!-- Aquí puedes agregar tus referencias a Bootstrap u otras librerías de CSS o JavaScript -->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Mostrar Lecturas</h1>
            <asp:DropDownList ID="ddlMedidor" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlMedidor_SelectedIndexChanged">

            </asp:DropDownList>
            <asp:GridView ID="gvLecturas" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="Hora" HeaderText="Hora" DataFormatString="{0:hh:mm tt}" />
                    <asp:BoundField DataField="Consumo" HeaderText="Consumo" />

                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
