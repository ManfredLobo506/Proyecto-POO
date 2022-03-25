<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmCatalogoElementos.aspx.cs" Inherits="InterfazWeb.FrmCatalogoElementos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h1>Catalogo de los programas disponibles</h1>
    <div class="gried">
    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox><asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" />
    <asp:GridView ID="GridCatalogo" runat="server" CellPadding="4" ForeColor="#333333" Width="100%" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="LnkSelect" runat="server" CommandArgument='<%# Eval("COD_MATERIA_ABIERTA").ToString() %>' OnCommand="LnkSelect_Command">Seleccionar</asp:LinkButton>
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
