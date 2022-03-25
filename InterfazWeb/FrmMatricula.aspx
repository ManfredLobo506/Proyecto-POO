<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmMatricula.aspx.cs" Inherits="InterfazWeb.FrmMatricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="mantenimiento2">
    <div class="mantenimiento">
     <div>
             Materia :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TxtCodMateria" runat="server" Width="153px" Height="25px"></asp:TextBox>
            <asp:Button ID="BtnBuscar2" runat="server" OnClick="BtnBuscar2_Click" Text="Buscar" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TxtCodMateria" ErrorMessage="La materia es un espacio requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblID" runat="server" Text="Identificacion: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtId" runat="server" Width="156px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtId" ErrorMessage="La identificacion es un espacio requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <br />
            <br />
        </div>
        <br />
       
        Cancelado :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>PENDIENTE</asp:ListItem>
            <asp:ListItem>CANCELADO</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        Encargado :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtEncargado" runat="server" Width="163px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtEncargado" ErrorMessage="El encargado es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
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
