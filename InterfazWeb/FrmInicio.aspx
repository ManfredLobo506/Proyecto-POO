<%@ Page Title="" Language="C#" MasterPageFile="~/Proyecto.Master" AutoEventWireup="true" CodeBehind="FrmInicio.aspx.cs" Inherits="InterfazWeb.FrmInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link rel="stylesheet" href="//code.jquery.com/ui/1.13.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script src="https://code.jquery.com/jquery-3.6.0.js"></script>
  <script src="https://code.jquery.com/ui/1.13.1/jquery-ui.js"></script>
  <script>
  $( function() {
    $( "#datepicker" ).datepicker();
  } );
  </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
     
    <div class="imagen">
    <img src="https://trazoscreativos.com/wp-content/uploads/2020/01/marketing-internacional-1200x773.jpg" alt="Alternate Text" />
    </div>
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
