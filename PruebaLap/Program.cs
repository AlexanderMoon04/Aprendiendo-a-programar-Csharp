using System;

namespace PruebaArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            float promedio,total=0;
        
            Console.WriteLine("Numero de datos a ingresar: ");
            n=int.Parse(Console.ReadLine());

            float[] arreglo = new float[n];
            for (i=0;i<n;i++)
            {
                Console.WriteLine("Introduce calificación:");
                arreglo[i]=float.Parse(Console.ReadLine());
                total=total+arreglo[i];
                
            }
            promedio=total/n;
            for(i=0;i<n;i++)
            {
                Console.WriteLine("La calificación "+(i+1) +" es:"+arreglo[i]);
            }
            Console.WriteLine("Suma de calificaciones: " + total);
            Console.WriteLine("Promedio de calificaciones: "+promedio);

        }
    }
}