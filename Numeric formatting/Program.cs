using System.Globalization;

namespace Numeric_formatting;

class Program
{
    static void Main(string[] args)
    {
        double value = 1000D / 3D;
        System.Console.WriteLine(value.ToString("N2")); // 333.33
        System.Console.WriteLine(value.ToString("C2")); // $333.33
        System.Console.WriteLine(value.ToString("P2")); // 33,333.33 %

        System.Console.WriteLine(value.ToString("C",CultureInfo.CurrentCulture)); //Current culture will decide depending on the system settings
        System.Console.WriteLine(value.ToString("C",CultureInfo.CreateSpecificCulture("en-GB"))); //Create a specific culture for British English
        System.Console.WriteLine(value.ToString("C",CultureInfo.CreateSpecificCulture("en-US"))); //Create a specific culture for US English
        System.Console.WriteLine(value.ToString("C",CultureInfo.CreateSpecificCulture("en-AU"))); //Create a specific culture for Australian English


    }
}
