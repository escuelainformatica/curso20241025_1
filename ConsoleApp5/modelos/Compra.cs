using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.modelos
{
    internal class Compra
    {
        // propiedades
        public string Producto { set; get; }
        public int? Cantidad { set; get; }
        public int? Precio { set; get; }

        public Compra()
        {
        }

        public Compra(string producto, int cantidad, int precio)
        {
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
