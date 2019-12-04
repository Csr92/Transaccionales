using System;
using System.Web.UI;

namespace CRUD
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnMovimiento_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Movimiento.aspx");
        }

        protected void btnProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Producto.aspx");
        }

        protected void btnCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cliente.aspx");
        }
    }
}