using System.Runtime.Intrinsics.Arm;

namespace Primos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a number bb: ");
        int num = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Is your number prime? "+numPrime(num));
    }
    public static bool numPrime(int x)
    {
        bool nPrime;
        if (x % 2 == 0 && x != 2  || x == 1)
        {
            return nPrime = false;
        }
        return nPrime = true; 
    }
}
