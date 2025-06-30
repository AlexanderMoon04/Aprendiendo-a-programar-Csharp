using System.Data;

namespace NumberSplit_ArrayOfMultiples;

class Program
{
    static void Main(string[] args)
    {
        //lists are dinamic arrays, they can grow and shrink in size
        /*Create two list with integer data tipe, one for even numbers, one for odd
        loop from 0 to 20
            if number is even, add to even list
            if number is odd, add to odd list
        print even list
        print odd list
        */
        // Call the function to split even and odd numbers in the range 0 to 20
        SplitEvenOddNumbers(0, 20);
        System.Console.WriteLine("\n----------------------------------");

        /*Define and initialise two integers (num, lenght)
        (7,5) -> [7, 14, 21, 28, 35]
        create int array with size lenght
        loop thrpugh and insert the (loop counter x  num) into the array
        print the final array */

        int num = 7;
        int length = 5;
        multiplicationArray(num, length);
        System.Console.WriteLine("\n----------------------------------");
       
    }

    // Function to split and print even and odd numbers in a range
    public static void SplitEvenOddNumbers(int start, int end)
    {
        List<int> odd = new List<int>();
        List<int> even = new List<int>();

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
                even.Add(i);
            else
                odd.Add(i);
        }

        System.Console.WriteLine("Printing even numbers:");
        foreach (var item in even)
        {
            System.Console.Write($"{item} ");
        }

        System.Console.WriteLine("\nPrinting odd numbers:");
        foreach (var item in odd)
        {
         System.Console.Write($"{item} ");
        }
    }

    public static void multiplicationArray(int num, int length)
    {
        int [] result = new int [length];
        int counter = 0;

        for (int i = 1; i <= length; i++,counter++)
        {
            result[counter] = i* num;
        }
        foreach (var item in result)
        {
            System.Console.Write($"{item} ");
        }
    }
}
