<%@ Page Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="MedidoresDM.IngresarLectura" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ingresar Lectura</title>
    <!-- Aquí puedes agregar tus referencias a Bootstrap u otras librerías de CSS o JavaScript -->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Ingresar Lectura</h1>
            <asp:Label ID="lblMedidor" runat="server" Text="Medidor"></asp:Label>
            <asp:DropDownList ID="ddlMedidor" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlMedidor_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblFecha" runat="server" Text="Fecha de Lectura"></asp:Label>
            <asp:Calendar ID="calFecha" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="lblHora" runat="server" Text="Hora de Lectura"></asp:Label>
            <asp:TextBox ID="txtHora" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtMinutos" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="rvHora" runat="server" ControlToValidate="txtHora" MinimumValue="0" MaximumValue="23"
                ErrorMessage="La hora debe estar entre 0 y 23"></asp:RangeValidator>
            <asp:RangeValidator ID="rvMinutos" runat="server" ControlToValidate="txtMinutos" MinimumValue="0" MaximumValue="59"
                ErrorMessage="Los minutos deben estar entre 0 y 59"></asp:RangeValidator>
            <br />
            <asp:Label ID="lblConsumo" runat="server" Text="Valor de Consumo"></asp:Label>
            <asp:TextBox ID="txtConsumo" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="rvConsumo" runat="server" ControlToValidate="txtConsumo" MinimumValue="0" MaximumValue="600"
                ErrorMessage="El valor de consumo debe estar entre 0 y 600"></asp:RangeValidator>
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </form>
</body>
</html>