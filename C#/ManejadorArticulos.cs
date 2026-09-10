using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//seeder = informacion por default 
namespace ArticulosCRUD
{
    internal class ManejadorArticulos
    {
        private List<Producto> ListaProductos;
        public ManejadorArticulos()
        {
            ListaProductos = new List<Producto>();

        }
        public void AgregarProducto(string nombre, int cantidad, decimal precio) 
        {
            Producto producto = new Producto(ListaProductos.Count +1, nombre, cantidad, precio);
            ListaProductos.Add(Producto);            
        }
        public void Listar() 
        {
            foreach (Producto item in ListaProductos)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public Producto? BuscarProductoPorID(int id)
        {
            foreach(Producto producto in ListaProductos)
            {
                if(producto.Id == id)
                {
                    return producto;
                }

            }
            return null;
        }
        public List <Producto> BuscarProductosPorNombre(string nombre)
        {
            return ListaProductos.Where(p => p.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList(); //busqueda, es un método abstracto que busca un string y regresa una lista
                          
        }
        public void ModificarProducto(int id,string nombre, decimal precio, int cantidad) //Cuando se modifica se tiene que mandar el ID
        {
            Producto? producto = BuscarProductoPorID(id); //paso por referencia (cuando es así, crea un objeto nuevo) ! 
            if(producto is not null)
            {
                producto.Nombre = nombre;
                producto.Precio = precio;
                producto.Cantidad = cantidad;
            }
        }
        public void EliminarProducto(int id)
        {
            Producto? producto = BuscarProductoPorID(id);
            if(producto is not null)
            {
                ListaProductos.Remove(producto);
            }
        }
  }
}