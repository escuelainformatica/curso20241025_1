// logica (condiciones)
// listados y ciclos
// LINQ



using ConsoleApp5.modelos;
using ConsoleApp5.servicio;

var num1 = 2;
var num2 = 3;

// <  ejemplo 10<20 
// >  ejemplo 20>10
// <= >=  ejemplo 10<=20 20>=10
// == ejemplo 10==10 iguales
// != ejemplo 10!=20 diferente


// version #1
if(num1<num2)
{
    Console.WriteLine("num1 es menor");
} else if(num1>num2)
{
    Console.WriteLine("num2 es menor");
} else
{
    Console.WriteLine("son iguales");
}
// version #2
if(num1<num2)
{
    Console.WriteLine("num1 es menor");
} else
{
    if (num1 > num2)
    {
        Console.WriteLine("num2 es menor");
    }
    else
    {
        Console.WriteLine("son iguales");
    }
}
// version #3
if (num1 < num2)
{
    Console.WriteLine("num1 es menor");
}
if (num1 > num2)
{
    Console.WriteLine("num2 es menor");
}
if (num1 == num2) {
    Console.WriteLine("son iguales");
}
var num3 = 30;
// quiero saber el valor menor
if(num1<num2 && num1<num3)
{
    Console.WriteLine("num1 es menor");
}
if (num2 < num1 && num2 < num3)
{
    Console.WriteLine("num2 es menor");
}
if (num3 < num1 && num3 < num2)
{
    Console.WriteLine("num3 es menor");
}
// quiero saber si alguno de los valores son iguales.
if (num1 == num2 || num1 == num3 || num2 == num3)
{
    Console.WriteLine("algunos son iguales");
}

switch(num1)
{
    case 1:
        Console.WriteLine("num1 es uno");
        break; // sale del bloque de codigo
    case 2:
        Console.WriteLine("num1 es dos");
        break;
    case 3:
        Console.WriteLine("num1 es tres");
        break;
    default:
        Console.WriteLine("num1 es otro valor");
        break;
}

// operador ternario?
// <condicion> ? <devuelve un valor> : <devuelve otro valor>

Console.WriteLine(num1 > 100 ? "es mayor a 100" : "no es mayor a 100");

var resultado = (num1 == num2) ? 10 : (num1 < num2) ? 5 : 3;

if(num1>100)
{
    Console.WriteLine("es mayor a 100");
} else
{
    Console.WriteLine("no es mayor a 100");
}

// operador de nulo
// objeto (una variable definida por una clase)
Console.WriteLine("Ejemplo Compra--------------------------");
var compra1 = new Compra("cocacola", 10, 1500);
var compra2 = new Compra("fanta", 3, 2000);
Compra compra3; // <-- no esta asignada y no tiene memoria = null
compra3 = new Compra();
Console.WriteLine(compra3.Producto??"(sin producto)");
Console.WriteLine(compra3.Producto==null ? "(sin producto)" : compra3.Producto);
// variable primitiva
var entero = 20;

CompraSrv.Mostrar(compra3);

Console.WriteLine(CompraSrv.Comparar(compra1, compra2));


// NULO ES UN VALOR QUE NO SE HA INGRESADO.
// Como no se ha ingresado, no tiene memoria y no puede asignarse valor o usarse.
// Los textos (string) pueden ser nulo.
// nulo != ""
