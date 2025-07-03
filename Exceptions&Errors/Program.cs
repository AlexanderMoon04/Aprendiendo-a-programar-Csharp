namespace Exceptions_Errors;

class Program
{
    static void Main(string[] args)
    {
        bool yea=true;

        while(yea)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());            
                yea=false;
            }
            catch(OverflowException)
            {
                System.Console.WriteLine("Only numbers and less than 2 billion");
            }
            catch(FormatException)
            {
                System.Console.WriteLine("Please pleaseeee, only numbers!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        Console.WriteLine(new string('-', 50));

         
    }
}
