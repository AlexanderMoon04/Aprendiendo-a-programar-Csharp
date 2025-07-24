namespace Excersice_Files;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, write the name of the file: ");
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
                        Console.Write($"{data[i,j]} ");
                    }
                    else
                        data[i, j] = "";
                }
                System.Console.WriteLine();
            }
            Console.WriteLine("Write the name of the group you are looking for: ");
            string search = Console.ReadLine();
            Console.WriteLine(SearchInArray(data, search));
            Console.WriteLine($"The average of the column is: {CalculateAverageColumn(data, search)}");
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
        return sum / array.Length;
    }
    public static double CalculateAverageColumn(string[,] data, string search)
    {
        int columns = data.GetLength(1); 
        int rows = data.GetLength(0);  

        for (int j = 0; j < columns; j++)
        {
            if (data[0, j] == search)
            {
                int[] values = new int[rows - 1];

                for (int i = 1; i < rows; i++)
                {
                    values[i - 1] = int.Parse(data[i, j]);
                }

                return CalculateProm(values);
            }
        }
        return -1; // Not found
    }
    public static string SearchInArray(string[,] data, string search)
    {
        int rows = data.GetLength(0); //To get number of rows
        int columns = data.GetLength(1); //To get number of columns

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
