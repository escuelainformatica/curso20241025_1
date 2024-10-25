using ConsolaEjercicio.modelos;
using ConsolaEjercicio.servicios;

var alumno1 = new Alumno("john", 4, 4, 4);
var alumno2 = new Alumno("Susan", 6, 6, 6);

// promedio
Console.WriteLine(AlumnoServicio.Promedio(alumno1));
Console.WriteLine(AlumnoServicio.Promedio(alumno2));
// aprobado
Console.WriteLine(AlumnoServicio.EstaAprobado(alumno1));
Console.WriteLine(AlumnoServicio.EstaAprobado(alumno2));
// comparar
Console.WriteLine(AlumnoServicio.AlumnoMejorPromedio(alumno1, alumno2));