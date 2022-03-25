<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmNoLectivoProfesor.aspx.cs" Inherits="InterfazWeb.FrmNoLectivoProfesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
     <h1>Ingresar Dia No Lectivo</h1>
<div class="mantenimiento2">
    <div class="mantenimiento">
        <div style="margin-top: 0px">
            <br />
            <br />
        </div>
        Id Profesor :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtId" runat="server" Width="156px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtId" ErrorMessage="El id es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Motivo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtMotivo" runat="server" Width="156px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtMotivo" ErrorMessage="El motivo es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        Dia :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<br />
&nbsp;<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <asp:Button class="btn btn-light" ID="BtnGuardar" runat="server" Text="Guardar" ValidationGroup="ValidarFormulario" OnClick="BtnGuardar_Click" />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="ValidarFormulario" />
        </div>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
