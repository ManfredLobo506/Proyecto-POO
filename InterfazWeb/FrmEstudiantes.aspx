<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmEstudiantes.aspx.cs" Inherits="InterfazWeb.FrmClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">

    <div class="gried">
    <asp:TextBox ID="TxtBuscar" runat="server"></asp:TextBox> <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" class="btn btn-light"/><asp:Button ID="Button1" runat="server" Text="Agregar Nuevo" OnClick="Button1_Click" class="btn btn-light" />
    <asp:GridView ID="GrdEstudiante" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Width="100%" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="IDENTIFICACION_E" HeaderText="ID" />
            <asp:BoundField DataField="NOMBRE_E" HeaderText="Nombre" />
            <asp:BoundField DataField="APELLIDO1_E" HeaderText="Apellido1" />
            <asp:BoundField DataField="APELLIDO2_E" HeaderText="Apellido 2" />
            <asp:BoundField DataField="CORREO_ELECTRONICO_E" HeaderText="Correo" />
            <asp:BoundField DataField="NUMERO_TELEFONICO" HeaderText="Telefono" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LnkEliminar" runat="server" CommandArgument='<%# Eval("IDENTIFICACION_E").ToString() %>' OnCommand="LnkEliminar_Command">Eliminar</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LnkModificar" runat="server" OnCommand="LnkModificar_Command" CommandArgument='<%# Eval("IDENTIFICACION_E").ToString() %>'>Modificar</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
 </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
