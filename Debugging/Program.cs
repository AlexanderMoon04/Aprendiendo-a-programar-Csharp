using System.ComponentModel.DataAnnotations;

namespace Debugging;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>{1 ,2};
        var smallests = GetSmallests(numbers,6);

        foreach(var number in smallests)
            System.Console.WriteLine(number);

        Console.WriteLine(new string('-', 50));

        

    }

    public static List<int> GetSmallests(List<int> list, int count)
    {
        var buffer = new List<int>(list);
        var smallests = new List<int>();

        while (smallests.Count < count)
        {
            var min = GetSmallests(buffer);
            smallests.Add(min);
            buffer.Remove(min);
        }
        return smallests;
    }

    public static int GetSmallests (List<int> list)
    {
        var min = list [0];
        for (var i = 1; i < list.Count; i++)
        {
            if (list[i] < min)
                min = list [i];
        }
        return min;
    }
}
