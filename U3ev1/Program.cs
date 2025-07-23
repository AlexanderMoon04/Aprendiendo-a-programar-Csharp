using System.Globalization;
namespace U3ev1;
class Program
{
    static void Main(string[] args)
    {
        double[] ArregloRandom = { 2, 3, 0, 1, 5, 3, 2, 3, 0, 0, 2, 1, 2, 1, 0, 2, 1, 1, 1, 3, 4, 0, 0, 2, 1 };
        Console.WriteLine($"Media : {Media(ArregloRandom)}");
        Console.WriteLine($"Numero mayor: {NumeroMayor(ArregloRandom)}");
        Console.WriteLine($"Arreglo ordenado:");
        ImprimirArreglo(Ordenar(ArregloRandom));
        Console.WriteLine($"Ingresa un numero para saber si es primo: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Es primo? {NumPrime(num)}");
        Console.WriteLine($"Arreglo invertido:");
        ImprimirArreglo(ImprimirArregloInvertido(ArregloRandom));
    }
    static public double Media(double[] a) 
    {
        double media = 0;
        for (int i = 0; i < a.Length; i++) // Sumar todos los valores del arreglo
        {
            media += a[i]; // Sumar cada valor del arreglo a la variable media
        }
        media /= a.Length; // Dividir la suma total entre la cantidad de valores del arreglo para obtener la media
        return media; 
    }
    static public double[] Ordenar(double[] a)
    {
        /*
        Básicamente, el primer for es para los (25) valores que vamos a ordenar
        En el segundo for, se ordena por lo menos un numero, haciendo que con las (25x24) repeticiones
        sea suficiente para ordenar todos los números.
        En cada repetición del segundo for se compara cierto valor del arreglo con el que tiene
        enseguida a la "derecha", si es mayor que el, cambian de lugar, mandando al mayor a
        la "derecha" y el menor a la "izquierda", con suficientes repeticiones, los valores menores quedan
        a la izquierda y los mayores a la derecha, ordenando exitosamente el arreglo yey :D
       */
        double valorTemp;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                valorTemp = a[j];
                if (a[j] > a[j + 1])
                {
                    a[j] = a[j + 1];
                    a[j + 1] = valorTemp;
                }
            }
        }
        return a;
    }
    public static bool NumPrime(int x)
    {
        bool nPrime; // Variable para determinar si el número es primo o no
        if (x % 2 == 0 && x != 2 || x == 1) // Si el número es par y no es 2, o si es 1, no es primo
        {
            return nPrime = false; 
        }
        return nPrime = true;
    }
    static public double[] ImprimirArregloInvertido(double[] a)
    {
        double[] b = new double[a.Length]; // Crea un nuevo arreglo para almacenar los valores invertidos
        int j = 0;
        for (int i = a.Length - 1; i >= 0; i--, j++) // Recorre el arreglo original desde el final hasta el principio
        {
            b[j] = a[i]; // Asigna el valor al nuevo arreglo en orden inverso
        }
        return b;
    }
    public static double NumeroMayor(double[] a)
    {
        double mayor = 0;
        for (int i = 0; i < a.Length; i++) // Recorre el arreglo para encontrar el número mayor
        {
            if (a[i] > mayor) // Si el número actual es mayor que el mayor encontrado hasta ahora
            {
                mayor = a[i]; // Actualiza el numero mayor
            }
        }
        return mayor;
    }
    static void ImprimirArreglo(double[] a)
    {
        for (int i = 0; i < a.Length; i++) // Recorre el arreglo para imprimir sus valores
        {
            Console.Write($"{a[i]} "); // Imprime cada valor del arreglo en la misma línea
        }
        System.Console.WriteLine(); //Da mejor formato
    }
}

