using System;
using System.Collections.Generic;
using System.Text;
//seeder = informacion por default 
namespace ArticulosCRUD
{
    internal class ManejadorArticulos
    {
        private List<Producto> ListarProductos;
        public ManejadorArticulos()
        {
            ListarProductos = new List<Producto>();

        }
        public void AgregarProducto(string nombre, int cantidad, decimal precio) 
        {
            Producto producto = new Producto(ListarProductos.Count +1, nombre, cantidad, precio);
            ListarProductos.Add(Producto);            
        }
        public void ListarProductos() 
        {
            foreach (Producto item in ListarProductos)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public Producto BuscarProductoPorID(int id)
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
  }
}