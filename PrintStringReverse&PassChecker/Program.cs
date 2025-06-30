using System.Runtime.Intrinsics.Arm;

namespace PrintStringReverse_PassChecker;

class Program
{ 
    //Ask user to input message and print it in reverse order.
    static void Main(string[] args)
    {
        Console.WriteLine("Write your message:");
        string message = Console.ReadLine();


        System.Console.WriteLine($"Number of characters: {message.Length}");
        Printacharacters(message);
        System.Console.WriteLine(".................................");
        PrintacharactersReverse(message);
        System.Console.WriteLine(".................................");

        System.Console.WriteLine("Enter a password:");
        string password = Console.ReadLine();
        System.Console.WriteLine("Enter the password again:");
        string password2 = Console.ReadLine();

        if (password.Equals(string.Empty) || password2.Equals(string.Empty))
            System.Console.WriteLine("Password cannot be empty");
        else if (password.Equals(password2))
            System.Console.WriteLine("Password is correct");
          else
            System.Console.WriteLine("Passwords do not match");
    }

    // System.Console.WriteLine(message[0]);
    // System.Console.WriteLine(message.Length);
    // 0-13
    static public void Printacharacters(string msg)
    {
        for (int i = 0; i < msg.Length; i++) //0-13
            Console.WriteLine(msg[i]);
        
    }
    static public void PrintacharactersReverse(string msg)
    {
        for (int i = msg.Length - 1; i >= 0; i--) //13-0
            Console.WriteLine(msg[i]);
    }
}

