# curso20241025_1

Apuntes de clase 2024-10-25

## condicion if

```c#
if(condicion) {
    // si la condicion se cumple
} else {
    // si la condicion no se cunple
}
```

Un ejemplo con mas condiciones

```c#
if(condicion) {
    // si la condicion se cumple
} else if (condicion2) {
    // si la condicion #2 se cumple
} else {
    // si ninguna condicion se cumple
}
```

## condicion switch y case

```c#
switch(variable) {
    case valor1:
        // hace algo si variable es igual a valor1
        break;
    case valor2:
        // hace algo si variable es igual a valor2
        break;
    case valor3:
        // hace algo si variable es igual a valor3
        break;
    default:
        // hace algo si la variable no es igual a las otras condiciones.
        break;
}
```

## operaciones ternarias

```c#
var resultado= condicion ? "la condicion se cumplio" : "la condicion no se cumplio";
```

## operador de nulos 

```c#
var resultado= valor ?? "el valor es nulo";
```





