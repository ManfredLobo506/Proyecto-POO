<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmCertificados.aspx.cs" Inherits="InterfazWeb.FrmCertificados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h1>Ingresar Certificado Profesor</h1>

    <div class="mantenimiento2">
    <div class="mantenimiento">
     <div>
            <asp:Label ID="LblCod" runat="server" Text="Cod Certificado: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtIdCertificado" runat="server" Width="156px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtIdCertificado" ErrorMessage="El cod de certifiado es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            <br />
            <br />
        </div>
        Id Profesor :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtId" runat="server" Width="293px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtId" ErrorMessage="El Id es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Nombre Certificado :&nbsp;&nbsp;<asp:TextBox ID="TxtNombre" runat="server" Width="290px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtNombre" ErrorMessage="El nombre es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
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
