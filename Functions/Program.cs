using System.Runtime.CompilerServices;

namespace Functions;
class Program
{
    static string name = "Tilin"; // Static variable, accessible in the entire class
    static void Main(string[] args)
    {
        Console.Title=$"Hello {name}!";
        WelcomeMessage();
    }


    public static string ReturnName()
    {
        return "Pierre"; // This function returns the static variable 'name'
    }
    static void WelcomeMessage() //static means that we can access it everywere and everytime
    {
        Console.WriteLine($"Welcome to the Functions program, {ReturnName()}!");
    }
}
