namespace Practica4._1;
class Program
{
    static void Main(string[] args)
    {
        //Crear un código que tome 1 numero y sume todos los numeros pares entre 0 y ese número - Ahora con operador %
        int numero=0,resultado=0,i;

        Console.WriteLine("Ingresa el número que deseas: ");
        numero=int.Parse(Console.ReadLine());

        for(i=0; i<numero+1; i++)
        {
            if((i % 2)==0)
            {
            resultado=resultado+i;
            }
            
        }
        Console.WriteLine("La suma de los numeros pares antes de tu número es: " + resultado); 
    }
}
