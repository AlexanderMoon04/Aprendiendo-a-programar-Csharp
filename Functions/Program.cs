using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Functions;
class Program
{
    static string name = "Tilin"; // Static variable, accessible in the entire class
    static void Main(string[] args)
    {
        Console.Title=$"Hello {name}!";
        WelcomeMessage();

        Console.WriteLine(new string('-', 50));

        int number = 5; // Local variable, accessible only in Main
        Console.WriteLine($"Addition = {Add(number)}");

        Console.WriteLine(new string('-', 50));

        string nameInput = "yonsina";
        int ageInput = 25;
        string addressInput = "123 Main St";
        PrintDetails(address: addressInput, name: nameInput, age: ageInput);

        Console.WriteLine(new string('-', 50));

        List <string> Products = new List<string>() {
            "Apple",
            "Banana",
            "Cherry",
            "Watermelon",
            "Pineapple",
        };
        System.Console.Write("Enter a product to search for: "); 
        string search = Console.ReadLine();
        if (FindInList(search, Products, out int index))
            Console.WriteLine($"Product {search} has been found at index {index}.");
        else
            Console.WriteLine($"Product {search} has not been found in the list.");
        
        Console.WriteLine(new string ('-', 50));

        System.Console.Write("Enter your new name: ");
        string newName = Console.ReadLine();

        if (ChangeName(ref name, newName))
        Console.WriteLine($"Your new name is {name}");
        else
        Console.WriteLine($"Your new name cannot be empty or null!");        

        Console.WriteLine(new string('-', 50));

        int [] numbers = [1,4,5,823,423,1,123];

        if (SumOfNumbers(numbers,out int result))
            Console.WriteLine($"The sum of the array is {result}");
        else
            System.Console.WriteLine("The array is Empty!");
    }

    public static string ReturnName()
    {
        return "Pierre"; // This function returns the static variable 'name'
    }
    static void WelcomeMessage() //static means that we can access it everywere and everytime
    {
        Console.WriteLine($"Welcome to the Functions program, {ReturnName()}!");
    }
    public static int Add(int a, [Optional] int b)
    {
        System.Console.WriteLine($"Adding {a} and {b}");
        return a + b;
    }

    public static void PrintDetails(string name, int age, string address)
    {
        // This function prints the details of a person
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
    }

    public static bool FindInList(string s, List<string> list, out int index)
    {
        index = -1;

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].ToLower().Equals(s.ToLower()))
            {
                index = i;
            }
        }
        return index >  -1;
    }

    public static bool ChangeName(ref string name, string newName)
    {
        if(!string.IsNullOrEmpty(newName))
        {
            name = newName;
            return true;
        }
        return false;
    }

    public static bool SumOfNumbers(int [] numbers, out int result)
    {
        result = 0;
        if (numbers.Length>0)
        {
            foreach (var item in numbers)
            {
                result += item;
            }
            return true;    
        }
        return false;
    }
}