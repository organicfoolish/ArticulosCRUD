namespace ArticulosCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Gestor de Artículos";
            string[] opciones = ["Agregar", "Listar", "BuscarPorID", "BuscarPorNombre","Modificar", "Eliminar"];
            Menu menu = new Menu(titulo, opciones);
            menu.MostrarMenu();
        }
    }
}