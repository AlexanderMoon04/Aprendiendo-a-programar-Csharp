namespace U2Ev3_LoginValidation;
//Access validation for users: Admin, user, guest 
class Program
{
    static void Main(string[] args)
    {
        //Users and passwords by default
        string[] admins = { "admin" };
        string[] passAdmins = { "admin123" };
        string[] users = { "user" };
        string[] passUsers = { "user123" };

        while (true) //Main menu, it cycles until the user select option 4
        {
            Console.WriteLine("Welcome, identify yourself: "); //Main menu
            System.Console.WriteLine("1. Admin");
            System.Console.WriteLine("2. user");
            System.Console.WriteLine("3. I'm a guest");
            System.Console.WriteLine("4. Exit");
            int identify = int.Parse(Console.ReadLine());

            switch (identify)
            {
                case 1: //Admin login
                    if (Login(admins, passAdmins))
                        AdminMenu(users, passUsers);

                    break;

                case 2: //User login
                    if (Login(users, passUsers))
                        UserMenu(users);

                    break;

                case 3: //Guest login
                    Console.Clear();
                    GuestMenu();
                    break;

                case 4: //exit program
                    System.Console.WriteLine("Closing program...");
                    Environment.Exit(0);
                    break;

                default: //Invalid option
                    Console.Clear();
                    System.Console.WriteLine("Invalid opction, please select one of the options displayed in the menu.");
                    break;
            }
        }
    }
    public static bool Login(string[] user, string[] pass) //It checks the username and password to login
    {
        bool Authentication = false;
        while (!Authentication)
        {
            Console.Clear();
            System.Console.WriteLine("Login to your account (Username = exit to return to main menu)");
            System.Console.Write("Username: ");
            string username = Console.ReadLine();
            System.Console.Write("Password: ");
            string password = Console.ReadLine();

            if (username.Equals("exit")) //It returns to the main menu if user types "exit"
            {
                Console.Clear();
                System.Console.WriteLine("Returning to main menu...");
                return false;
            }

            for (int i = 0; i < user.Length; i++) //It checks if the username and password match with the ones in the arrays
            {
                // If the username and password match, it authenticates the user
                if (username.Equals(user[i]) && password.Equals(pass[i]))
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {user[i]}!");
                    Authentication = true; // Set Authentication to true to exit the loop
                }
                else
                {
                    System.Console.WriteLine("Invalid username or password, try again.");
                }
            }
        }
        return true; //Returns true if the user is authenticated
    }
    public static void AdminMenu(string[] users, string[] passUsers) 
    {
        while (true)
        {
            System.Console.WriteLine(">>>>>>>>>Admin menu<<<<<<<<");
            System.Console.WriteLine("1. View users");
            System.Console.WriteLine("2. Add users");
            System.Console.WriteLine("3. Delete users");
            System.Console.WriteLine("4. Logout");
            System.Console.Write("Select an option:");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: //View users
                    ViewUsers(users, passUsers);
                    break;

                case 2: //Add users
                    CreateUser(ref users, ref passUsers);
                    break;

                case 3: //Delete users 
                    DeleteUser(ref users, ref passUsers);
                    break;

                case 4: //Logout
                    return;

                default: //Invalid option
                    System.Console.WriteLine("Invalid option");
                    break;
            }

            System.Console.WriteLine("Press any key to return to admin menu :)");
            Console.ReadKey();
            Console.Clear();
        }

    }
    public static void UserMenu(string [] username)
    {
        while (true)
        {
            System.Console.WriteLine(">>>>>>>>>User menu<<<<<<<<");
            System.Console.WriteLine("1. View my profile");
            System.Console.WriteLine("2. Logout");
            System.Console.Write("Select an option: ");

        System.Console.WriteLine("User not found :(");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine($"Username: {username[0]}. Role: User");
                    break;

                case 2:
                    return;

                default:
                    System.Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
    public static void GuestMenu()
    {
        Console.Clear();
        System.Console.WriteLine(">>>>>>>>>Guest menu<<<<<<<<");
        System.Console.WriteLine("Yo can't do anything, lol");
        System.Console.WriteLine("Press any key to return to main menu :)");
        Console.ReadKey();
        Console.Clear();
    }
    //ref is used to pass arguments to methods by reference instead of by value
    //This allows the method to modify the original array.
    public static void CreateUser(ref string[] users, ref string[] passUsers)
    {
        bool passMatch = false;

        System.Console.WriteLine("Create new user c:");
        System.Console.Write("Enter the username: ");
        string newUsername = Console.ReadLine();
        string newPassword = "";
        do //It checks if the password is empty or if it matches the confirmation password
        {
            System.Console.WriteLine("Enter a password:");
            newPassword = Console.ReadLine();
            System.Console.WriteLine("Enter the password again:");
            string password2 = Console.ReadLine();

            if (newPassword.Equals(string.Empty) || password2.Equals(string.Empty))
                System.Console.WriteLine("Password cannot be empty");
            else if (newPassword.Equals(password2))
                passMatch = true;

            else
                System.Console.WriteLine("Passwords do not match");

        } while (!passMatch); // Loop until the passwords match

        // Resize the arrays to add a new user
        Array.Resize(ref users, users.Length + 1);
        Array.Resize(ref passUsers, passUsers.Length + 1);

        // Add the new user and password to the end of the arrays
        users[users.Length - 1] = newUsername;
        passUsers[passUsers.Length - 1] = newPassword;

        System.Console.WriteLine("User added successfully :)");
    }
    public static void DeleteUser(ref string[] users, ref string[] passUsers) //It deletes a user from the arrays
    {
        System.Console.WriteLine("Delete user");
        System.Console.Write("Enter the username to delete: ");
        string usernameToDelete = Console.ReadLine();

        for (int i = 0; i < users.Length; i++) // Loop through the users array to find the user to delete
        {
            if (users[i].Equals(usernameToDelete)) 
            {
                for (int j = i; j < users.Length - 1; j++) // Shift the elements to the left to remove the user
                {
                    users[j] = users[j + 1]; // Shift usernames
                    passUsers[j] = passUsers[j + 1]; // Shift passwords
                }
                // Resize the arrays to remove the last element
                Array.Resize(ref users, users.Length - 1);
                Array.Resize(ref passUsers, passUsers.Length - 1);
                System.Console.WriteLine("User deleted successfully");
                return;
            }
        }
        System.Console.WriteLine("User not found :(");
    }

    public static void ViewUsers(string[] users, string[] pass)
    {
        Console.Clear();
        System.Console.WriteLine("List of users: ");
        for (int i = 0; i < users.Length; i++) // Loop through the users array to display usernames and passwords
        {
            Console.WriteLine($"Username: {users[i]}, Password: {pass[i]}");
        }
    }
}