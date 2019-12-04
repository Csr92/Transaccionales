<%@ Page Language="C#" Title="Producto" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="CRUD.Producto" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    

        <div class="col-md-5">
        <div class="row">
            <div class="col-md-4">
                <asp:Label ID="Label4" runat="server" Text="Producto"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <asp:Label ID="Label1" runat="server" Text="Cantidad"></asp:Label>
                <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <asp:Button ID="btnCrear" runat="server" Text="Crear" CssClass="btn btn-primary" OnClick="btnCrear_Click"/>
            </div>
        </div>
        <asp:Label ID="lblresponse" runat="server" Text="" Style="color: red"></asp:Label>
    </div>
</asp:Content>
