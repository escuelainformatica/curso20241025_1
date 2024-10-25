// arreglos y listado
using ConsolaLista.modelos;

var paises = new string[3]; // un arreglo
paises[0] = "Chile";
paises[1] = "Argentina";
paises[2] = "Peru";
// Los arreglos SON FINITOS Y ESTATICOS.
// Queue
// Stack
// Dictionary
// Hashset = List

// <string> <--- OVNI. no se indica que es menor o mayor.
var paises2 = new List<string>(); // una lista
paises2.Add("Chile");
paises2.Add("Argentina");
paises2.Add("Peru");
Console.WriteLine(paises2[0]); // Chile.
// Las listas
// Se pueden agregar datos dinamicamente (no es finita ni es estatica)
// En teoria, los arreglos son mas rapidos que la lista.
// arreglo vs lista (0.001s)
var numeros = new List<int> { 1,2,3,4,5};

// crear una lista de alumnos:
var alumnos = new List<Alumno>();
// para agregar datos
var alumno = new Alumno("john", 4, 4, 4);
alumnos.Add(alumno);
alumnos.Add(new Alumno("Susan", 6, 6, 6));


// quiero generar una lista de libros.
var listas = new List<Libro>();
listas.Add(new Libro { Titulo = "Harry Potter", Autor = "JKR", NumPagina = 300, Precio = 45000 });
listas.Add(new Libro { Titulo = "titulo2", Autor = "Otro2", NumPagina = 300, Precio = 45000 });
listas.Add(new Libro { Titulo = "titulo3", Autor = "Otro3", NumPagina = 300, Precio = 45000 });


