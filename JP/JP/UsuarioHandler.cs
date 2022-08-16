
using System.Data.SqlClient;

namespace PreEntregaJuanPabloPeramas
{
    public class UsuarioHandler : dbHandler
    {
        public List<Usuario> TraerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Usuario", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Usuario usuario = new Usuario();

                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Contraseña = dataReader["Contraseña"].ToString();
                                usuario.Mail = dataReader["Mail"].ToString();
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }
            return usuarios;
        }
        public void MostrarUsuarios()
        {
            Console.WriteLine("-- Usuarios --");
            foreach (Usuario usuario in TraerUsuarios())
            {
                Console.WriteLine(usuario.Id);
                Console.WriteLine(usuario.Nombre);
                Console.WriteLine(usuario.Apellido);
                Console.WriteLine(usuario.NombreUsuario);
                Console.WriteLine(usuario.Contraseña);
                Console.WriteLine(usuario.Mail);
            }
            Console.WriteLine("--                   --");
        }
    }
}
