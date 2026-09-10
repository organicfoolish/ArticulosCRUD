
//Deprecado, se reemplazó por Menu.cs
+-------------------------------------+
namespace ArticulosCRUD
{
    internal class Menu
    {
        public Menu()
        {

        }
        public void MostrarBuscarNombre()
        {
            Console.Clear();
            Console.WriteLine("Buscar Por Nombre");
            Console.WriteLine("=================");
            Console.WriteLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            foreach(Producto item in Manejador.BuscarProductosPorNombre(nombre))
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

        }

        public void MostrarAgregar()
        {
            Console.Clear();
            Console.WriteLine("Agregar Producto");
            Console.ReadLine();
        }
        
        public void MostrarListar()
        {
            Console.Clear();
            Console.WriteLine("Opcion Agregar Seleccionada");
            Console.ReadLine();
        }
        
        public void MostrarBuscar()
        {
            Console.Clear();
            Console.WriteLine("Buscar Producto por ID");
            Console.WriteLine("======================");
            id = PedirValorEntero("ID");
            Producto resultado = Manejador.BuscarProductoPorID(id);
            if(resultado != null)
            {
                Console.WriteLine($"ID: {resultado.id}, Nombre: {resultado.Nombre},Precio: {resultado.Precio}, Cantidad: {resultado.Cantidad}");
            } 
            else
            Console.ReadLine();
        }
        
        public void MostrarModificar()
        {
            Console.Clear();
            Console.WriteLine("Opcion Agregar Seleccionada");
            Console.ReadLine();
        }
        
        public void MostrarEliminar()
        {
            Console.Clear();
            Console.WriteLine("Opcion Agregar Seleccionada");
            Console.ReadLine();
        }

        public void MostrarMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Gestor de Articulos");
                Console.WriteLine("===================");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Listar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Modificar");
                Console.WriteLine("5. Eliminar");
                Console.WriteLine("0. Salir");
                string opcion = Console.ReadLine() ?? "";
                switch (opcion)
                {
                    case "0":
                        continuar = false;
                        break;
                    case "1":
                        MostrarAgregar();
                        break;
                    case "2":
                        MostrarListar();
                        break;
                    case "3":
                        MostrarBuscar();
                        break;
                    case "4":
                        MostrarModificar();
                        break;
                    case "5":
                        MostrarEliminar();
                        break;

                    default: 
                        Console.WriteLine("Opcion Invalida");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
namespace ArticulosCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        Menu menu = new Menu();
        menu.MostrarMenu();
    }
}

