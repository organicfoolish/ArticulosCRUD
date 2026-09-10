using System;
using System.Collections.Generic;
using System.Text;

namespace ArticulosCRUD
{
    internal class Menu
    {
        private readonly string Titulo;
        private readonly string[] Opciones;
        public ManejadorArticulos Manejador {get; set;}

        public Menu(string titulo, string[] opciones)
        {
            Titulo = titulo;
            Opciones = opciones;
            Manejador = new ManejadorArticulos();
        }

        public void MostrarMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine(Titulo);
                Console.WriteLine(new string('=', Titulo.Length));
                for (int i = 0; i < Opciones.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Opciones[i]}");
                }
                Console.WriteLine("0. Salir");
                //Console.WriteLine("Gestor de Artículos");
                //Console.WriteLine("===================");
                //Console.WriteLine("1. Agregar");
                //Console.WriteLine("2. Listar");
                //Console.WriteLine("3. Buscar");
                //Console.WriteLine("4. Modificar");
                //Console.WriteLine("5. Eliminar");
                //Console.WriteLine("0. Salir");
                string opcion = Console.ReadLine() ?? "";
                switch (opcion)
                {
                    case "0":
                        continuar= false;
                        break;
                    case "1":
                        MostrarAgregar();
                        break;
                    case "2":
                        MostrarListar();
                        break;
                    case "3":
                        MostrarMenuBuscar();
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
            Console.WriteLine("================");
            Console.WriteLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precio = (decimal.TryParse(Console.ReadLine(), out decimal valor))?valor:0;
            Console.Write("Cantidad: ");
            int cantidad = (int.TryParse(Console.ReadLine(), out int valor2)) ? valor2 : 0;
            Manejador.AgregarProducto(nombre, cantidad, precio);
            Console.WriteLine("Producto creado correctamente");
            Console.ReadLine();
        }
        public void MostrarListar()
        {
            Console.Clear();
            Console.WriteLine("Listar Productos");
            Console.WriteLine("================");
            Manejador.ListarProductos();
            foreach (Producto item in ListaProductos)
            {
                Console.WriteLine(item.Nombre);
            }
            Console.ReadLine();
        }
        public void MostrarBuscar()
        {
            Console.WriteLine("Buscar Producto por ID");
            Console.WriteLine("======================");
            id = PedirValorEntero("ID");
            Producto resultado = Manejador.BuscarProductoPorID(id);
            if(resultado != null)
            {
                Console.WriteLine(resultado.ToString());
            } 
            else
            {
                Console.WriteLine("Producto ono encontrado.");
            }
            Console.ReadLine();
        }
        public int PedirValorEntero(string titulo)
        {
            while (true)
            {  
                Console.WriteLine($"{titulo}: ");
                if(int.TryParse(Console.ReadLine(), out int valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor no permitido. Ingresa nuevamente");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        public void MostrarModificar()
        {
            Console.Clear();
            Console.WriteLine("Modificar Producto");
            Console.WriteLine("==================");
            Console.WriteLine();
            int id = PedirValorEntero("ID de producto");
            Producto? producto = Manejador.BuscarProductoPorID(id); //? para indicar que probablemente la variable sea nula
            if(producto is null)
            {
                Console.WriteLine("Producto no encontrado.");
                return;
            }
            Console.WriteLine(producto.ToString());
            Console.WriteLine("Ingrese los datos nuevos.");
            //Copiado de arriba
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precio = (decimal.TryParse(Console.ReadLine(), out decimal valor))?valor:0;
            Console.Write("Cantidad: ");
            int cantidad = (int.TryParse(Console.ReadLine(), out int valor2)) ? valor2 : 0;
            // hasta aquí
            Manejador.ModificarProducto(id, nombre, precioq, cantidad);
            Console.WriteLine("Producto modificado correctamente");

            Console.ReadLine();
        }
        public void MostrarEliminar()
        {
            Console.Clear();
            Console.WriteLine("Eliminar producto");
            Console.WriteLine("=================");
            int id  = PedirValorEntero("ID del producto");
            Producto? producto = Manejador.BuscarProductoPorID(id);
            if(producto is null)
            {
                Console.WriteLine("Producto no encontrado");
                return;
            }
            Console.WriteLine(producto.ToString());
            Console.WriteLine("Deseas eliminar el producto? (s/n)");
            string respuesta = Console.ReadLine()?.Trim() ?? "n";
            if (!respuesta.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Operacion cancelada. Presione cualquier tecla para continuar...");
                return;
            }
            Manejador.EliminarProducto(id);
            Console.WriteLine("Producto eliminado correctamente.");
            Console.ReadLine();
        }
        public void MostrarMenuBuscar()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Buscar articulos");
                Console.WriteLine("=================");
                Console.WriteLine("1. Por ID");
                Console.WriteLine("2. Por Nombre");
                Console.WriteLine("0. Regresar");
                //Console.WriteLine("Gestor de Artículos");
                //Console.WriteLine("===================");
                //Console.WriteLine("1. Agregar");
                //Console.WriteLine("2. Listar");
                //Console.WriteLine("3. Buscar");
                //Console.WriteLine("4. Modificar");
                //Console.WriteLine("5. Eliminar");
                //Console.WriteLine("0. Salir");
                string opcion = Console.ReadLine() ?? "";
                switch (opcion)
                {
                    case "0":
                        continuar= false;
                        break;
                    case "1":
                        MostrarBuscar();
                        break;
                    case "2":
                        MostrarBuscarNombre();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadLine();
                }

            }
            
            
        }
    }
}