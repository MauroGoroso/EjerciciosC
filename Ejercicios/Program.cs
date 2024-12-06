

/* 
Ejercicios 3
Bueno, ya entramos en condicionales, así que ahora sí, vamos a codificar ejercicios con condiciones.

Lean atentamente y codifiquen las soluciones. Si van apareciendo dudas, me van consultando.*/

//1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

/* int numero;

Console.WriteLine("Ingresa el numero deseado: ");
numero = int.Parse(Console.ReadLine());   

if (numero < 10)
    {Console.WriteLine("El numero es menor a 10");}
else
    {Console.WriteLine("El numero es mayor a 10");}
 */

//2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero,
 // “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.


/*  int numero;

Console.WriteLine("Ingresa el numero deseado: ");
numero = int.Parse(Console.ReadLine());  

if (numero < 0)
    Console.WriteLine("El numero es Negativo");

    else if (numero > 0)
        Console.WriteLine("El numero es Positivo");
else
   Console.WriteLine("El numero es igual a 0"); */


//3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

//Si el importe es menor a ARS 1000, no hay descuento.
//Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
//Si el importe es ARS 5000 o más, aplica un descuento del 18%.
//Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.


/* float ImporteVenta, ImporteFinal = 0;


    Console.WriteLine("Ingrese el monto de la venta: ");
    ImporteVenta = float.Parse(Console.ReadLine());

    if (ImporteVenta >= 1000 ){

        if (ImporteVenta > 5000)
            ImporteFinal = ImporteVenta * 0.82F;
            else
                ImporteFinal = ImporteVenta * 0.90F;
    }else
        ImporteFinal = ImporteVenta;
    
    Console.WriteLine("El importa a pagar es de: "+ ImporteFinal);
 */

    

//4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

/* int a, b, c, d, menor;


Console.WriteLine("Ingresa el primer numero deseado: ");
a = int.Parse(Console.ReadLine());   

Console.WriteLine("Ingresa el segundo numero deseado: ");
b = int.Parse(Console.ReadLine());   

Console.WriteLine("Ingresa el tercer numero deseado: ");
c = int.Parse(Console.ReadLine());   

Console.WriteLine("Ingresa el cuarto numero deseado: ");
d = int.Parse(Console.ReadLine());   

if ( a < b)
    menor = a;
    else menor = b;

if ( c < menor)
    menor = c;

if ( d < menor )
    menor = d;

Console.WriteLine("El menor numero de todos los elegidos es: " + menor); */


//5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100. 


int a, b, c, d, mayor;


Console.WriteLine("Ingresa el primer numero deseado: ");
a = int.Parse(Console.ReadLine());   

Console.WriteLine("Ingresa el segundo numero deseado: ");
b = int.Parse(Console.ReadLine());   

Console.WriteLine("Ingresa el tercer numero deseado: ");
c = int.Parse(Console.ReadLine());   

Console.WriteLine("Ingresa el cuarto numero deseado: ");
d = int.Parse(Console.ReadLine());   

if (a > 100) 

    Console.WriteLine("El primer valor es mayor a 100: " + a);

if (b > 100) 

    Console.WriteLine("El segundo valor es mayor a 100: " + b);

if (c > 100)

    Console.WriteLine("El tercer valor es mayor a 100: " + c);

if (d > 100) 

    Console.WriteLine("El cuarto valor es mayor a 100: " + d);
