using System.Diagnostics;
using System.Reflection;

namespace Excersice_Files;

class Program
{

    /*Take the name of the file with the keyboard (without extention .csv)
    Calculate the average of data read in the file 
    The file must containt the next:
    Califications DSBIS22M
    5
    4
    8
    1
    3
    5
    And must show:
    -table with title
    -Data inside [5,4,8,1,3,5]
    -The average of data 

     */
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, write the name of the file: ");
        string fileCalifications = Console.ReadLine()+".csv";

        try
        {
            string[] data = File.ReadAllLines(fileCalifications);
            int[] notes = new int[data.Length];
            string title = data[0];
            System.Console.WriteLine(title);
            double prom = 0;
            for (int i = 1; i < data.Length; i++)
                notes[i] = int.Parse(data[i]);
            System.Console.WriteLine($"Read data: {ShowArray(notes)}");
            prom = CalculateProm(notes);
            System.Console.WriteLine($"Average: {prom}");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"An error has ocurred: {ex.Message}");
        }
    }

    public static double CalculateProm(int[] array)
    {
        double sum = 0;
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / (array.Length-1);
    }
        public static string ShowArray(int[] o)
    {
        string result = "[";
        for (int i = 1; i < o.Length; i++)
        {
            result += o[i].ToString();
            if (i < o.Length-1 )
                result += ", ";

        }
        result += "]";
        return result;
    }
}
