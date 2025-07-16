namespace Search_DataSheet;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, write the name of the file: ");
        string animals = Console.ReadLine() + ".csv";
        try
        {
            string[] data = File.ReadAllLines(animals);
            System.Console.Write("Write the animal you want to search for: ");
            string search = Console.ReadLine();

            System.Console.WriteLine(SearchInArray(data, search));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"It wasnt possible to read the file: {ex.Message}");
        }
    }


    public static string SearchInArray(string[] data, string search)
    {

        for (int i = 0; i < data.Length - 1; i++)
        {
            if (data[i] == search)
            {
                return $"The animal {search} was found at position {i}!";
            }
        }
        return "-1";
    }
}
