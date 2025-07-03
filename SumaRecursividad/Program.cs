using System.Xml.XPath;

namespace SumaRecursividad;
class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        // Console.WriteLine(sumRecursiva(x));
        // Console.WriteLine(sumNormal(x));
        System.Console.WriteLine(multiplesof3AND5(10));
        System.Console.WriteLine(multiplesof3AND5(49));
        System.Console.WriteLine(multiplesof3AND5(1000));
        System.Console.WriteLine(multiplesof3AND5(8456));
        System.Console.WriteLine(multiplesof3AND5(19564));
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

    public static int multiplesof3AND5(int number)
    {
        var cont1=0;
        var cont2=0;
        for (int i = 3; i <number; i++)
        {
            if (i%3==0 && !(i%5==0))
            {
            cont1+=i;
            }
            if (i%5==0)
            {
            cont2+=i;
            }
        }
        int result=cont1+cont2;
        return result;

    }
}
