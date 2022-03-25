<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmProfesores.aspx.cs" Inherits="InterfazWeb.FrmProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <nav class="navbar navbar-light bg-light justify-content-center ">
   <ul class="nav justify-content-center light">
  <li class="nav-item ">
    <a class="nav-link active" aria-current="page" href="FrmHorarioProfesor.aspx">Agregar Horario</a>
  </li>
  <li class="nav-item ">
    <a class="nav-link " href="FrmCertificados.aspx">Agregar Certificado</a>
  </li>
  <li class="nav-item ">
    <a class="nav-link" href="FrmNoLectivoProfesor.aspx">Agregar Dia no Lectivo</a>
  </li>
</ul>
</nav>

    <div class="gried">
    <asp:TextBox ID="Txtbuscar" runat="server"></asp:TextBox> <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" class="btn btn-light" /><asp:Button ID="Button1" runat="server" Text="Agregar Nuevo" OnClick="Button1_Click" class="btn btn-light"/>
    <asp:GridView ID="GrdProfesores" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Width="100%" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="IDENTIFICACION_P" HeaderText="ID" />
            <asp:BoundField DataField="NOMBRE_P" HeaderText="Nombre" />
            <asp:BoundField DataField="APELLIDO1_P" HeaderText="Apellido1" />
            <asp:BoundField DataField="APELLIDO2_P" HeaderText="Apellido 2" />
            <asp:BoundField DataField="CORREO_ELECTRONICO_P" HeaderText="Correo" />
            <asp:BoundField DataField="NUMERO_TELEFONICO_P" HeaderText="Telefono" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LnkEliminar" runat="server" CommandArgument='<%# Eval("IDENTIFICACION_P").ToString() %>' OnCommand="LnkEliminar_Command">Eliminar</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LnkModificar" runat="server" CommandArgument='<%# Eval("IDENTIFICACION_P").ToString() %>' OnCommand="LnkModificar_Command">Modificar</asp:LinkButton>
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
