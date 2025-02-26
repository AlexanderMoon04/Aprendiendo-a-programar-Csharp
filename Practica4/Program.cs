using System;
namespace Practica4
{
    class Programa
    {
        static void Main()
        {
        //Crear un código que tome 1 numero y sume todos los numeros pares entre 0 y ese número
        int i,numero=0,resultado=0;

        Console.WriteLine("Ingresa el número que deseas: ");
        numero=int.Parse(Console.ReadLine());

        for(i=2; i<numero+1; i+=2)
        {
            resultado=resultado+i;
        }
        Console.WriteLine("La suma de los numeros pares antes de tu número es:" + resultado);    
        }
    }
}