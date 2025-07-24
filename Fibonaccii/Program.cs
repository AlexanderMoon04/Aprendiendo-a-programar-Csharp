namespace Fibonaccii;
class Program
{  
      static void Main(string[] args)
    {
        //1 2 3 4 5 6 7 8  9  10 11 12
        //0 1 1 2 3 5 8 13 21 34 55 89
        Console.WriteLine("Enter a number to get its Fibonacci value: ");
        int number = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Fibonacci value: " + Fibonacci(number));
        System.Console.WriteLine("Fibonacci value (Recursive edition): " + RecursiveFibonacci(number));
    }
    public static int Fibonacci(int x)
    {
        int f1 = 0, f2 = 1, f3 = 0;
        if (x <= 0)
        {
            return -1; //Error for invalid input
        }
        for (int i = 2; i < x; i++)
        {
            f3 = f1 + f2; // Calculate the next Fibonacci number
            f1 = f2; // Update f1 to the previous Fibonacci number
            f2 = f3;    // Update f2 to the current Fibonacci number
        }
        return f3;
    }
    public static int RecursiveFibonacci(int x)
    {
        if (x <= 0)
        {
            return -1; //Error for invalid input
        }
        if (x == 1)
        {
            return 0;
        }
        if (x == 2)
        {
            return 1;
        }
        return RecursiveFibonacci(x - 1) + RecursiveFibonacci(x - 2); // Recursive call to calculate Fibonacci number
    } 
}
