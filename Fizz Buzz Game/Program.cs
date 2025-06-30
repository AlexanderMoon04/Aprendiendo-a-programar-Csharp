using System.Runtime.InteropServices;

namespace Fizz_Buzz_Game;

class Program
{
    /*
     * FizzBuzz is a simple game where players take turns counting up from 1.
     * For multiples of 3, they say "Fizz" instead of the number.
     * For multiples of 5, they say "Buzz" instead of the number.
     * For multiples of both 3 and 5, they say "FizzBuzz".
     * This program implements the FizzBuzz logic.
     */

    static void Main(string[] args)
    {
        bool threeDiv = false, fiveDiv = false;

        for (int i = 1; i <= 100; i++) // Loop from 1 to 100
        {
            threeDiv = i % 3 == 0;
            fiveDiv = i % 5 == 0;

            if (fiveDiv && threeDiv) // Check for multiples of both 3 and 5
            {
                Console.WriteLine("FizzBuzz"); // Print "FizzBuzz"
            }
            else if (threeDiv) // Check for multiples of 3
            {
                Console.WriteLine("Fizz");
            }
            else if (fiveDiv) // Check for multiples of 5
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i); // Print the number itself if not a multiple of 3 or 5
            }
        }
    }
}
