using ConsoleApp5.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.servicio
{
    internal class CompraSrv
    {
        public static string Comparar(Compra c1,Compra c2)
        {
            if(c1.Cantidad>c2.Cantidad)
            {
                return "La primera compra es mayor";
            } else
            {
                return "La segunda compra es mayor";
            }
        }
        public static void Mostrar(Compra c1)
        {
            Console.WriteLine("---Compra:---");
            Console.WriteLine("Producto:"+(c1.Producto??"(sin producto)"));
            Console.WriteLine("Cantidad:"+(c1.Cantidad??0));
            if(c1.Precio==null)
            {
                Console.WriteLine("Precio  :0" );
            } else
            {
                Console.WriteLine("Precio  :" + c1.Precio);
            }
            

        }
    }
}
