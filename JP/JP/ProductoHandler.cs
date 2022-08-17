using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PreEntregaProyectoJuanPablo
{
    public class ProductoHandler : dbHandler
    {
        public List<Producto> TraerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM Producto", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Producto producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripciones = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToInt32(dataReader["Costo"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.PrecioVenta = Convert.ToInt32(dataReader["PrecioVenta"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                                productos.Add(producto);
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }

            return productos;
           
        }

        internal static List<Producto> TraerProductos(int id)
        {
            throw new NotImplementedException();
        }

        public void MostrarProductos ()
        {
            Console.WriteLine("-- Lista de Productos --");
            foreach ( Producto producto in TraerProductos())
            {
                Console.WriteLine(producto.Id);
                Console.WriteLine(producto.Descripciones);
                Console.WriteLine(producto.PrecioVenta);
                Console.WriteLine(producto.Costo);
                Console.WriteLine(producto.IdUsuario);
                Console.WriteLine(producto.Stock);

            }
            Console.WriteLine("--                   --");
        }
    }
}
    


