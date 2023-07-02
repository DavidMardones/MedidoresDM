<%@ Page Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeBehind="MostrarLecturas.aspx.cs" Inherits="MedidoresDM.MostrarLecturas" Title="Mostrar Lecturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" Runat="Server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" Runat="Server">
    <h1>Mostrar Lecturas</h1>

    <asp:DropDownList ID="ddlMedidores" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlMedidores_SelectedIndexChanged">
        <asp:ListItem Text="Todos" Value="0"></asp:ListItem>
    </asp:DropDownList>

    <br /><br />

    <asp:GridView ID="gvLecturas" runat="server" AutoGenerateColumns="False" Width="600px">
        <Columns>
            <asp:BoundField DataField="Fecha" HeaderText="Fecha" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField DataField="Hora" HeaderText="Hora" DataFormatString="{0:HH:mm}" />
            <asp:BoundField DataField="ValorConsumo" HeaderText="Valor de Consumo" />
        </Columns>
    </asp:GridView>
</asp:Content>
