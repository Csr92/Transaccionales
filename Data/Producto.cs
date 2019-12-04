using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Producto
    {
        string connectionString = "Server=tcp:csrtraining.database.windows.net,1433;Initial Catalog=Transaccionales;Persist Security Info=False;User ID=csr;Password=Azure.Cesar-92*11$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public bool Create(ProductoDTO producto)
        {
            var result = false;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var sqlComm = new SqlCommand("CreateProduct", conn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@Cantidad", SqlDbType.Int);
                sqlComm.Parameters["@Cantidad"].Value = producto.Cantidad;

                sqlComm.Parameters.Add("@Nombre", SqlDbType.VarChar);
                sqlComm.Parameters["@Nombre"].Value = producto.Nombre;

                /*sqlComm.Parameters.Add("@response", SqlDbType.VarChar, 50);
                sqlComm.Parameters["@response"].Value = string.Empty;
                sqlComm.Parameters["@response"].Direction = ParameterDirection.Output;
                */
                result = sqlComm.ExecuteNonQuery() > 0;
                //result = sqlComm.Parameters["@response"].Value.ToString();
            }
            return result;
        }
        public List<ProductoDTO> Read()
        {
            var listaProductos = new List<ProductoDTO>();
            using (var conn = new SqlConnection(connectionString))
            {
                var sqlComm = new SqlCommand("ReadProduct", conn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                var ds = new DataSet();
                da.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    var producto = new ProductoDTO();
                    producto.IdProducto = Convert.ToInt32(row["IdProducto"]);
                    producto.Cantidad = Convert.ToInt32(row["Cantidad"]);
                    producto.Nombre = Convert.ToString(row["Nombre"]);
                    listaProductos.Add(producto);
                }
            }
            return listaProductos;
        }

        public bool Update(ProductoDTO producto)
        {
            var result = false;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var sqlComm = new SqlCommand("UpdateProduct", conn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@idProducto", SqlDbType.Int);
                sqlComm.Parameters["@idProducto"].Value = producto.IdProducto;

                sqlComm.Parameters.Add("@Cantidad", SqlDbType.Int);
                sqlComm.Parameters["@Cantidad"].Value = producto.Cantidad;

                sqlComm.Parameters.Add("@Nombre", SqlDbType.VarChar);
                sqlComm.Parameters["@Nombre"].Value = producto.Nombre;

                /*sqlComm.Parameters.Add("@response", SqlDbType.VarChar, 50);
                sqlComm.Parameters["@response"].Value = string.Empty;
                sqlComm.Parameters["@response"].Direction = ParameterDirection.Output;
                */
                result = sqlComm.ExecuteNonQuery() > 0;
                //result = sqlComm.Parameters["@response"].Value.ToString();
            }
            return result;
        }

        public bool Delete(int idProducto)
        {
            var result = false;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var sqlComm = new SqlCommand("UpdateProduct", conn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@idProducto", SqlDbType.Int);
                sqlComm.Parameters["@idProducto"].Value = idProducto;
                result = sqlComm.ExecuteNonQuery() > 0;
            }
            return result;
        }

        public bool CrearMovimiento(MovimientoDto movimiento)
        {
            var result = false;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var sqlComm = new SqlCommand("CreateMovimiento", conn);
                sqlComm.CommandType = CommandType.StoredProcedure;

                sqlComm.Parameters.Add("@IdProducto", SqlDbType.Int);
                sqlComm.Parameters["@IdProducto"].Value = movimiento.IdProducto;

                sqlComm.Parameters.Add("@TipoMovimiento", SqlDbType.Char);
                sqlComm.Parameters["@TipoMovimiento"].Value = movimiento.TipoMovimiento;

                sqlComm.Parameters.Add("@Cantidad", SqlDbType.Int);
                sqlComm.Parameters["@Cantidad"].Value = movimiento.Cantidad;


                result = sqlComm.ExecuteNonQuery() > 0;
            }
            return result;
        }

    }
}
