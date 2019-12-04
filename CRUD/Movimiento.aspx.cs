using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD
{
    public partial class Movimiento : System.Web.UI.Page
    {
        List<ProductoDTO> productos = new List<ProductoDTO>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarDll();
            }
        }
        private void CargarDll()
        {
            productos = new Data.Producto().Read();
            ddlProductos.DataSource = productos;
            ddlProductos.DataValueField = "IdProducto";
            ddlProductos.DataTextField = "Nombre";
            ddlProductos.DataBind();
        }
        protected void btnComprar_Click(object sender, EventArgs e)
        {
            var idProducto = ddlProductos.SelectedValue;
            //productos = new Data.Producto().Read();
            //var prod = productos.FirstOrDefault(p => p.IdProducto.ToString() == producto);
            var movimiento = new MovimientoDto
            {
                Cantidad = Convert.ToInt32(txtCantidad.Text),
                IdProducto = Convert.ToInt32(idProducto),
                TipoMovimiento = 1
            };
            var response = new Data.Producto().CrearMovimiento(movimiento);
            if (response)
                lblresponse.Text = "Compra exitosa";
            else
                lblresponse.Text = "No hay cantidad suficiente en stock";

            CargarDll();
        }

        protected void btnVender_Click(object sender, EventArgs e)
        {
            var idProducto = ddlProductos.SelectedValue;
            //productos = new Data.Producto().Read();
            //var prod = productos.FirstOrDefault(p => p.IdProducto.ToString() == producto);
            var movimiento = new MovimientoDto
            {
                Cantidad = Convert.ToInt32(txtCantidad.Text),
                IdProducto = Convert.ToInt32(idProducto),
                TipoMovimiento = 2
            };
            var response = new Data.Producto().CrearMovimiento(movimiento);
            if (response)
                lblresponse.Text = "Compra exitosa";
            else
                lblresponse.Text = "No hay cantidad suficiente en stock";

            CargarDll();
        }

        protected void ddlProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var producto = ddlProductos.SelectedValue;
            productos = new Data.Producto().Read();
            var prod = productos.FirstOrDefault(p => p.IdProducto.ToString() == producto);
            lblCantidad.Text = prod.Cantidad.ToString();
        }
    }
}