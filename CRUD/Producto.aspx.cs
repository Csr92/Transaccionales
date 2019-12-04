using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
        protected void btnCrear_Click(object sender, EventArgs e)
        {
            var producto = new ProductoDTO
            {
                Cantidad = Convert.ToInt32(txtCantidad.Text),
                Nombre = txtNombre.Text

            };
            var response = new Data.Producto().Create(producto);
            if (response)
                lblresponse.Text = "Producto creado con éxito";
        }
    }
}