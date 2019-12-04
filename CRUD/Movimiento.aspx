<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Movimiento.aspx.cs" Inherits="CRUD.Movimiento" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    
 <div class="col-md-5">
        <div class="row">
            <div class="col-md-4">
                <asp:Label ID="Label4" runat="server" Text="Producto"></asp:Label>
                <asp:DropDownList ID="ddlProductos" runat="server" OnSelectedIndexChanged="ddlProductos_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
        </div>
      <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label3" runat="server" Text="Cantidad Disponible: "></asp:Label>
              <asp:Label ID="lblCantidad" runat="server" ></asp:Label>
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
                <asp:Button ID="btnComprar" runat="server" Text="Comprar" CssClass="btn btn-primary" OnClick="btnComprar_Click"/>
            </div>
            <div class="col-md-4">
                <asp:Button ID="btnVender" runat="server" Text="Vender" CssClass="btn btn-primary" OnClick="btnVender_Click"/>
            </div>
        </div>
        <asp:Label ID="lblresponse" runat="server" Text="" Style="color: red"></asp:Label>
    </div>
</asp:Content>