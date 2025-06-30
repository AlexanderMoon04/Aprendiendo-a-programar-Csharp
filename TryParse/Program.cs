namespace TryParse;

class Program
{
    static void Main(string[] args)
    {
        bool success = true;

        while(success)
        {
            System.Console.WriteLine("Enter a number:");
            string input = System.Console.ReadLine();

            if (int.TryParse(input, out int num)) // Try to parse the input as an integer
            {
                System.Console.WriteLine(num); // If parsing is successful, print the number
                success = false; // Exit the loop if parsing is successful
            }
            else
            {
                System.Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
