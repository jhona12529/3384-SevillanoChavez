/* Area del triangulo */
using System;
class Ejercicio2
{
    static void Main()
    {
        Console.WriteLine("Ingrese la altura del triangulo: ");
        float altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la base del triangulo:");
        float baseTri = float.Parse(Console.ReadLine());
        /*
        Aplicando la formula del area del triangulo.
        */
        float area = (baseTri * altura) / 2;
        Console.WriteLine("El area del triangulo es " + area + " m2");
        Console.ReadKey();
    }
}

