<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmAbrirMateria.aspx.cs" Inherits="InterfazWeb.FrmAbrirMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="mantenimiento2">
    <div class="mantenimiento">
     <div>
             Materia :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TxtCodMateria" runat="server" Width="153px" Height="25px"></asp:TextBox>
            <asp:Button ID="BtnBuscar2" runat="server" OnClick="BtnBuscar2_Click" Text="Buscar" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TxtCodMateria" ErrorMessage="La materia es un espacio requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblID" runat="server" Text="Materia Abierta Cod: "></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="TxtMateriaA" runat="server" Width="156px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtMateriaA" ErrorMessage="El codigo de materia abierta es un espacio requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <br />
            <br />
        </div>
        <br />
       
        Identificacion P :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtIdP" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TxtIdP" ErrorMessage="La identificacion del profesor es un espacio requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        Cupo :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TxtCupo" runat="server" Width="163px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtCupo" ErrorMessage="El cupo es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
         Costo :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:TextBox ID="TxtCosto" runat="server" Width="163px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtCosto" ErrorMessage="El costo es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button class="btn btn-light" ID="BtnGuardar" runat="server" Text="Guardar" ValidationGroup="ValidarFormulario" OnClick="BtnGuardar_Click" />

<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="ValidarFormulario" />
</div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
