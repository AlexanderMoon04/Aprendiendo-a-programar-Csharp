namespace Factorial;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Obtencion del factorial, suma de numeros pares y suma de 1 hasta n con metodos recursivos");
        int n;
        Console.Write("Ingresa el numero: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Factorial de {n}: {FactosFactoriaRecursivo(n)}");
        Console.WriteLine($"Factorial de {n} (iterativo): {FactosFactoria(n)}");
        Console.WriteLine($"Suma numeros pares hasta n: {SumaParesRecursivo(n)}");
        Console.WriteLine($"Suma numero de 1 hasta n: {SumaRecursiva(n)}");

    }
    static int FactosFactoria(int x)
    {
        if (x < 0)
        {
            return -1; // Indicate an error for negative input
        }

        int chiffre = 1;
        for (int i = 1; i <= x; i++)
        {
            chiffre *= i;
        }
        return chiffre;
    }
    static int FactosFactoriaRecursivo(int x)
    {
        if (x < 0)
        {
            return -1; // Indicate an error for negative input
        }

        if (x == 0 || x == 1)
            return 1;
        else
            return x * FactosFactoriaRecursivo(x - 1);
    }
    static int SumaParesRecursivo(int n)
    {
        if (n % 2 == 0 && n > 0)
        {
            return n+SumaParesRecursivo(n - 2);
        }
        else if (n > 0)
            return SumaParesRecursivo(n - 1);

        return n;
    }
        static int SumaRecursiva(int x)
    {
        if (x == 0)
        {
            return 0;
        }
        return x + SumaRecursiva(x - 1);
    }
}
