using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaEjercicio.modelos
{
    internal class Alumno
    {
        public string Nombre { set; get; }
        public int NotaCastellano { set; get; }
        public int NotaMatematica { set; get; }
        public int NotaHistoria { set; get; }

        public Alumno()
        {
        }

        public Alumno(string nombre, int notaCastellano, int notaMatematica, int notaHistoria)
        {
            Nombre = nombre;
            NotaCastellano = notaCastellano;
            NotaMatematica = notaMatematica;
            NotaHistoria = notaHistoria;
        }
    }
}
