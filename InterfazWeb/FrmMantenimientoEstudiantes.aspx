<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmMantenimientoEstudiantes.aspx.cs" Inherits="InterfazWeb.FrmEstudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">

    <h1>Ingresar Estudiantes</h1>

    <div class="mantenimiento2">
    <div class="mantenimiento">
     <div>
            <asp:Label ID="lblID" runat="server" Text="Identificacion: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtId" runat="server" Width="156px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtId" ErrorMessage="La identificacion es un espacio requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <br />
            <br />
        </div>
        Nombre :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtNombre" runat="server" Width="293px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtNombre" ErrorMessage="El nombre es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Primer Apellido :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TxtApellido1" runat="server" Width="293px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TxtApellido1" ErrorMessage="El primer apellido es un espacio requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Segundo Apellido :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtApellido2" runat="server" Width="293px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtApellido2" ErrorMessage="El segundo apellido es una espacio requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Telefono:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TxtTelefono" runat="server" Width="163px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtTelefono" ErrorMessage="El telefono es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
        CorreoElectronico:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtEmail" runat="server" Width="161px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtEmail" ErrorMessage="La direccion es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button class="btn btn-light" ID="BtnGuardar" runat="server" Text="Guardar" ValidationGroup="ValidarFormulario" OnClick="BtnGuardar_Click" />
         <asp:Button class="btn btn-light" ID="BtnCancelar" runat="server" Text="Cancelar" OnClick="BtnCancelar_Click" />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="ValidarFormulario" />
</div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
