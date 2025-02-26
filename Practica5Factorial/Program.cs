namespace Practica5Factorial;
class Program
{
    //Crear un código que calcula el factorial de un número, manejar factorial 0 y factorial negativo (No existe)
    static void Main(string[] args)
    {
        int i,factorial,total=0,n=0;
        int[] arreglo = new int[n];
        Console.WriteLine("Ingresa el número a obtener factorial");
        factorial=int.Parse(Console.ReadLine());

        for(i=1; i<factorial; i++)
        {
            total=factorial*(factorial-i);
            Console.WriteLine("Total: "+ total);
        }
        Console.WriteLine("Factorial del número ingresado:"+ total);
    }
}
