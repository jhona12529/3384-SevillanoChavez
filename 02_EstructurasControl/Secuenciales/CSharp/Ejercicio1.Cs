/* Ejercicio1: Volumen, Area de un Cilindro */
using System;
class Ejercicio1
{
    static void Main()
    {
        Console.WriteLine("Ingrese el radio del cilindro: ");
        float radio = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del cilindro:");
        float altura = float.Parse(Console.ReadLine());
        /*
        Aplicando la formula del volumen del cilindro y del area. 
        */
        float volum = Math.PI * (radio * radio) * altura;
        float area = 2 * Math.PI * radio * (radio + altura);
        Console.WriteLine("El volumen del cilindro es " + volum + " m3");
        Console.WriteLine("El area del cilindro es " + area + " m2");
        Console.ReadKey();
    }
}

