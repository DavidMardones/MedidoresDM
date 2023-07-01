<%@ Page Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="IngresarMedidor.aspx.cs" Inherits="MedidoresDM.IngresarMedidor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <h1>Ingresar Medidor</h1>
    <form runat="server">
        <div>
            <asp:Label ID="lblNumeroSerie" runat="server" Text="Número de Serie:"></asp:Label>
            <asp:TextBox ID="txtNumeroSerie" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNumeroSerie" runat="server" ControlToValidate="txtNumeroSerie" ErrorMessage="El número de serie es requerido"></asp:RequiredFieldValidator>
            <br />

            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>
    </form>
</asp:Content>
