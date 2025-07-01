namespace DataTable;

class Program
{
    static void Main(string[] args)
    {
        string PathFile = "viral.csv";
        //When you open a file, it will read it as a string
        try
        {
            string[] data = File.ReadAllLines(PathFile);
            int[] numbers = new int[data.Length];
            double prom = 0;
            for (int i = 0; i < data.Length; i++)
                numbers[i] = int.Parse(data[i]);
            System.Console.WriteLine($"The read data are: {EraseArray(numbers)}");
            prom = CalculateProm(numbers);
            System.Console.WriteLine($"The average is: {prom}");
        }
        catch (System.Exception ex) //Error management
        {
            System.Console.WriteLine($"An error has occurred: {ex.Message}");
        }
        
    }

    public static double CalculateProm(int[] array)
    {
        double sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }
        return sum / array.Length;
    }
        public static string EraseArray(int[] o)
    {
        string result = "[";
        for (int i = 0; i < o.Length; i++)
        {
            result += o[i].ToString();
            if (i < o.Length - 1)
                result += ", ";

        }
        result += "]";
        return result;
    }
}
