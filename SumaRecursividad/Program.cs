namespace SumaRecursividad;
class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        Console.WriteLine(sumRecursiva(x));
        Console.WriteLine(sumNormal(x));
    }

    public static int sumNormal(int n)
    {
        int suma = 0;
        for (int i =1; i <= n; i++)
        {
            suma += i;
        }
        return suma;
    }

    public static int sumRecursiva(int n)
    {
        if (n == 0)
            return 0;
        else
            return n + sumRecursiva(n - 1);
    }
}
