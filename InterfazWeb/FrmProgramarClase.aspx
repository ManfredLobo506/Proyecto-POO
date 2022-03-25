<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmProgramarClase.aspx.cs" Inherits="InterfazWeb.FrmProgramarClase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
     <h1>Ingresar Horario Profesor</h1>

    <div class="mantenimiento2">
    <div class="mantenimiento">
     <div>
            <asp:Label ID="lblID" runat="server" Text="Id Clase: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtIdClase" runat="server" Width="156px" Enabled="False"></asp:TextBox>
            <br />
            <br />
        </div>
        Id Estudiante :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtId" runat="server" Width="156px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtId" ErrorMessage="El id es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Cod Materia :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtCod" runat="server" Width="156px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtCod" ErrorMessage="El codigo de materia es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        Dia :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<br />
&nbsp;<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <br />
        Hora&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="LstEntrada" runat="server">
            <asp:ListItem>7:00</asp:ListItem>
            <asp:ListItem>8:00</asp:ListItem>
            <asp:ListItem>9:00</asp:ListItem>
            <asp:ListItem>10:00</asp:ListItem>
            <asp:ListItem>11:00</asp:ListItem>
            <asp:ListItem>12:00</asp:ListItem>
            <asp:ListItem>13:00</asp:ListItem>
            <asp:ListItem>14:00</asp:ListItem>
            <asp:ListItem>15:00</asp:ListItem>
            <asp:ListItem>16:00</asp:ListItem>
            <asp:ListItem>17:00</asp:ListItem>
            <asp:ListItem>18:00</asp:ListItem>
            <asp:ListItem>19:00</asp:ListItem>
            <asp:ListItem>20:00</asp:ListItem>
            <asp:ListItem>21:00</asp:ListItem>
            <asp:ListItem>22:00</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button class="btn btn-light" ID="BtnGuardar" runat="server" Text="Guardar" ValidationGroup="ValidarFormulario" OnClick="BtnGuardar_Click" />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="ValidarFormulario" />
        </div>
        </div>
    <div class="gried">
    <asp:TextBox ID="TxtBuscar" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" class="btn btn-light" />
    <asp:GridView ID="GrdClases" runat="server" CellPadding="4" EmptyDataText="No hay registros" ForeColor="#333333" Width="100%" GridLines="None">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
