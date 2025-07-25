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
                string[] cells = line[i].Split(','); // Split each line into cells
                for (int j = 0; j < columns; j++) // Loop through each cell in the row
                {
                    if (j < cells.Length)
                    {
                        data[i, j] = cells[j]; // Assign the cell value to the array
                        Console.Write($"{data[i, j]} "); 
                    }
                    else
                        data[i, j] = "";
                }
                System.Console.WriteLine();
            }
            Console.WriteLine("Write the name of the group you are looking for: ");
            string search = Console.ReadLine();
            Console.WriteLine(SearchInArray(data, search));
            Console.WriteLine($"Quantity of valid data analyzed: {data.GetLength(0) - 1}");
            Console.WriteLine($"The sum of the column selected is: {CalculateSumColumn(data, search)}");
            Console.WriteLine($"The average of the column is: {CalculateAverageColumn(data, search)}");
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"It wasnt possible to read the file: {ex.Message}");
        }
    }
    public static double CalculateProm(int[] array)
    {
        return CalculateSum(array) / array.Length;
    }
    public static double CalculateSum(int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    public static double CalculateAverageColumn(string[,] data, string search)
    {
        int columns = data.GetLength(1); 
        int rows = data.GetLength(0);  

        for (int j = 0; j < columns; j++) // Loop through each column
        {
            if (data[0, j] == search) // Check if the first row matches the search term
            {
                int[] values = new int[rows - 1]; // Create an array to hold the values in the column

                for (int i = 1; i < rows; i++) // Loop through each row starting from the second row
                {
                    values[i - 1] = int.Parse(data[i, j]); // Store the value into the array
                }

                return CalculateProm(values);
            }
        }
        return -1; // Not found
    }
    public static double CalculateSumColumn(string[,] data, string search)
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

                return CalculateSum(values);
            }
        }
        return -1; // Not found
    }
    public static string SearchInArray(string[,] data, string search) 
    {
        int rows = data.GetLength(0); //To get number of rows
        int columns = data.GetLength(1); //To get number of columns

        for (int i = 0; i < rows; i++) // Loop through each row
        {
            for (int j = 0; j < columns; j++) // Loop through each column
            {
                if (data[i, j] == search) // Check if the current cell matches the search term
                {
                    return $"The group {search} was found at position [{i}, {j}]!"; // Return the position if found
                }
            }
        }
        return "-1";
    }
}
