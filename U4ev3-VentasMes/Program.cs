namespace U4ev3_VentasMes;

class Program
{
    static void Main(string[] args)
    {
        string[] months = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto",
            "septiembre", "octubre", "noviembre", "diciembre" };
        double[] salesTotal = new double[months.Length];
        double salesMonth = 0;
        double maxSales = 0;
        string bestMonth = "";
        System.Console.WriteLine("Sales report anual");
        try
        {
            for (int i = 0; i < months.Length; i++)
            {
                string[] lines = File.ReadAllLines($"{months[i]}.csv");
                int rows = lines.Length;
                int columns = lines[0].Split(',').Length;
                string[,] data = new string[rows, columns];

                for (int j = 0; j < rows; j++)
                {
                    string[] cells = lines[j].Split(',');
                    for (int k = 0; k < columns; k++)
                    {
                        if (k < cells.Length)
                            data[j, k] = cells[k];
                    }
                }
                salesMonth = CalculateSumColumn(data, "ventas");

                if (salesMonth > maxSales)
                {
                    bestMonth = months[i];
                    maxSales = salesMonth;
                }

                salesTotal[i] = CalculateSumColumn(data, "ventas");
                Console.WriteLine($"The total of sales for {months[i]} is {salesMonth}");
                Console.WriteLine($"Average of sales for {months[i]} is {CalculateAverageColumn(data, "ventas")}");
                System.Console.WriteLine("====================================================");
            }
            Console.WriteLine($"Month with more sales: {bestMonth}");
            Console.WriteLine($"Total sales for the year: {CalculateSum(salesTotal)}");
            Console.WriteLine($"Average monthly sales: {CalculateProm(salesTotal)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    public static double CalculateSum(double [] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    public static double CalculateProm(double[] array)
    {
        return CalculateSum(array) / array.Length;
    }
    public static double CalculateAverageColumn(string[,] data, string search)
    {
        int columns = data.GetLength(1);
        int rows = data.GetLength(0);

        for (int j = 0; j < columns; j++)
        {
            if (data[0, j] == search)
            {
                double[] values = new double[rows - 1];

                for (int i = 1; i < rows; i++)
                {
                    values[i - 1] = int.Parse(data[i, j]);
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
                double[] values = new double[rows - 1];

                for (int i = 1; i < rows; i++)
                {
                    values[i - 1] = int.Parse(data[i, j]);
                }

                return CalculateSum(values);
            }
        }
        return -1; // Not found
    }
}
