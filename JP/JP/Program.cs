namespace PreEntregaJuanPabloPeramas
{
    class ProbarObjetos
    {

        static void Main(string[] args)
        {
            ProductoHandler productoHandler = new ProductoHandler();
            productoHandler.TraerProductos();

            UsuarioHandler usuarioHandler = new UsuarioHandler();
            usuarioHandler.TraerUsuarios(); 
            
        }

    }


}