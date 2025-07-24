using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;

namespace U2Ev3_LoginValidation;
//Access validation for users: Admin, user, guest 
class Program
{
    string[] admins = {"admin"};
    string[] passAdmins = {"admin123"};
    string[] users = {"user"};
    string[] passUsers = {"user123"};
    static void Main(string[] args)
    {

        int identify = 0;
        do
        {
            Console.WriteLine("Welcome, identify yourself: ");
            System.Console.WriteLine("1. Login");
            System.Console.WriteLine("2. I'm a guest");
            System.Console.WriteLine("3. Close progran");
            identify = int.Parse(Console.ReadLine());

            switch (identify)
            {
                case 1:
                    Login();
                    break;

                case 2:
                    System.Console.WriteLine("Menu for guest: ");
                    break;


                case 3:
                    System.Console.WriteLine("Closing program...");
                    return;

                default:
                    System.Console.WriteLine("Invalid opction, pleas select one of the options displayed in the menu.");
                    break;
            }
        } while (identify > 0 && identify < 4);

    }
    public static int Login()
    {
        bool pass = false;
        do
        {
            System.Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            System.Console.Write("Enter your password:");
            string password = Console.ReadLine();
            if (username.Equals("admin") && password.Equals("admin123"))
            {
                System.Console.WriteLine("Welcome admin!");
                return 1;
            }
            else if (username.Equals("user") && password.Equals("user123"))
            {
                System.Console.WriteLine("Welcome user!");
                return 2;
            }
            else
            {
                System.Console.WriteLine("Invalid username or password.");
                pass = true;
            }
        } while (!pass);

    }
    public static void CreateUser()
    {
        bool isAdmin = false;
        bool passMatch = false;

        System.Console.WriteLine("Create new user c:");
        System.Console.WriteLine("Enter your user: ");
        string username = Console.ReadLine();

        do
        {
            System.Console.WriteLine("Enter a password:");
            string password = Console.ReadLine();
            System.Console.WriteLine("Enter the password again:");
            string password2 = Console.ReadLine();

            if (password.Equals(string.Empty) || password2.Equals(string.Empty))
                System.Console.WriteLine("Password cannot be empty");
            else if (password.Equals(password2))
                passMatch = true;
            else
                System.Console.WriteLine("Passwords do not match");    

        } while (!passMatch);
    }
    public static void DeleteUser()
    {
        
    }

}
