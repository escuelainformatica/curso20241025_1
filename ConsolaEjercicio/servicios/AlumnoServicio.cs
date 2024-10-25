using ConsolaEjercicio.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaEjercicio.servicios
{
    internal class AlumnoServicio
    {
        public static double Promedio(Alumno alumno)
        {
            return (alumno.NotaCastellano + alumno.NotaMatematica 
                + alumno.NotaHistoria) / 3;
        }
        public static string EstaAprobado(Alumno alumno)
        {
            if(alumno.NotaHistoria>=4 && alumno.NotaMatematica>=4 &&
                alumno.NotaCastellano>=4)
            {
                return "aprobado";
            }
            return "reprobado";
        }
        public static string AlumnoMejorPromedio(Alumno alumno1,Alumno alumno2)
        {
            var promedio1 = Promedio(alumno1);
            var promedio2 = Promedio(alumno2);
            if(promedio1>promedio2)
            {
                return alumno1.Nombre;
            } else if(promedio2 >promedio1 )
            {
                return alumno2.Nombre;
            } else
            {
                return "Tienen el mismo promedio";
            }
        }
    }
}
