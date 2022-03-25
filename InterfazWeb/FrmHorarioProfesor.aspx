<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmHorarioProfesor.aspx.cs" Inherits="InterfazWeb.FrmHorarioProfesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h1>Ingresar Horario Profesor</h1>

    <div class="mantenimiento2">
    <div class="mantenimiento">
     <div>
            <asp:Label ID="lblID" runat="server" Text="Id horaio: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtIdHorario" runat="server" Width="156px" Enabled="False"></asp:TextBox>
            <br />
            <br />
        </div>
        Id Profesor :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtId" runat="server" Width="293px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtId" ErrorMessage="El nombre es un espacio requerido" ValidationGroup="ValidarFormulario" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
        <br />
        <br />
        Dia :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="LstDia" runat="server">
            <asp:ListItem>lunes</asp:ListItem>
            <asp:ListItem>martes</asp:ListItem>
            <asp:ListItem>miércoles</asp:ListItem>
            <asp:ListItem>jueves</asp:ListItem>
            <asp:ListItem>viernes</asp:ListItem>
        </asp:DropDownList>
&nbsp;<br />
        <br />
        Hora Entrada :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
        Hora Salida:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="LstSalida" runat="server">
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
        <asp:Button class="btn btn-light" ID="BtnGuardar" runat="server" Text="Guardar" ValidationGroup="ValidarFormulario" OnClick="BtnGuardar_Click" />
         <asp:Button class="btn btn-light" ID="BtnCancelar" runat="server" Text="Cancelar" />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="ValidarFormulario" />
        </div>
        </div>
    <div class="gried">
            <asp:GridView ID="GrdHorarios" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="ID_HORARIO" HeaderText="ID" />
                    <asp:BoundField DataField="IDENTIFICACION_P" HeaderText="Id Profesor" />
                    <asp:BoundField DataField="DIA" HeaderText="Dia" />
                    <asp:BoundField DataField="HORA_ENTRADA" HeaderText="Hora Entrada" />
                    <asp:BoundField DataField="HORA_SALIDA" HeaderText="Hora Salida" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LnkEliminar" runat="server" CommandArgument='<%# Eval("ID_HORARIO").ToString() %>' OnCommand="LnkEliminar_Command">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LnkModificar" runat="server" OnCommand="LnkModificar_Command" CommandArgument='<%# Eval("ID_HORARIO").ToString() %>'>Modificar</asp:LinkButton>
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
