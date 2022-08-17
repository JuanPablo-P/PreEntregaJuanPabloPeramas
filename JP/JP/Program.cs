using System;

namespace PreEntregaProyectoJuanPablo
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************************************");
            ProductoHandler productoHandler = new ProductoHandler();
            //productoHandler.TraerProductos();

            UsuarioHandler usuarioHandler = new UsuarioHandler();
            usuarioHandler.TraerUsuarios(); 
            
        }
    }
    }