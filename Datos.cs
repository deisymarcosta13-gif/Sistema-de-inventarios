using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sistema_Inventarios.PruductosList;

namespace Sistema_Inventarios
{
    class Datos
    {
        public static List<Producto> Productos = new List<Producto>();
        public static List<Categorias> Categorias = new List<Categorias>();
        public static List<Venta> Ventas = new List<Venta>();
    }
    public class Categorias
    {
        public string Nombre { get; set; }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public Categorias Categoria { get; set; }
        public double Precio { get; set; }
    }
    public class Venta
    {
        public DateTime Fecha { get; set; }
        public string Categoria { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Total { get; set; }
    }
}
