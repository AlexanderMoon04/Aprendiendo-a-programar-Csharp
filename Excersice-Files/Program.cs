using System.Diagnostics;
using System.Reflection;

namespace Excersice_Files;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, write the name of the file: ");
        string fileCalifications = Console.ReadLine() + ".csv";

        try
        {
            string[] line = File.ReadAllLines(fileCalifications);
            int rows = line.Length;
            int columns = line[0].Split(',').Length;
            string[,] data = new string[rows, columns]; //array of multiple dimensions
            for (int i = 0; i < rows; i++)
            {
                string[] cells = line[i].Split(',');
                for (int j = 0; j < columns; j++)
                {
                    if (j < cells.Length)
                    {
                        data[i, j] = cells[j];
                        System.Console.WriteLine(data[i, j] + "\t");
                    }
                    else
                        data[i, j] = "";
                }
                System.Console.WriteLine();
            }
            Console.WriteLine("Write the name of the group you are looking for: ");
            string search = Console.ReadLine();
            Console.WriteLine(SearchInArray(data, search));
            Console.WriteLine($"The average of the column is:{CalculateAverageColumn(data, search)}");
            

            

        }
        catch (Exception ex)
        {
            Console.WriteLine($"It wasnt possible to read the file: {ex.Message}");
        }
    }
    public static double CalculateProm(int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / (array.Length);
    }
    public static double CalculateAverageColumn(string[,] string search)
    {
        
    }
        public static string SearchInArray(string[,] data, string search)
    {
        int rows = data.GetLength(0);
        int columns = data.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (data[i, j] == search)
                {
                    return $"The group {search} was found at position [{i}, {j}]!";
                }    
            }
        }
        return "-1";
    }

}
