namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = [1,10,100];
        System.Console.WriteLine("................................");
        for (int i = 0; i < numbers.Length; i++)
        {
            System.Console.WriteLine($"numbers[{i}] = {numbers[i]}");
        }
        System.Console.WriteLine("................................");

        int numberOfangles = 3;
        int[] angles = new int[numberOfangles];
        for (int i = 0; i < angles.Length; i++)
        { 
            System.Console.Write($"Write the angle {i+1} of the triangle: ");
            angles[i]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("................................");



        Array.Sort(angles); // Sort the angles in ascending order
        System.Console.WriteLine("The angles in ascending order are: ");
        foreach (int angle in angles)
        {
            System.Console.Write($"{angle} ");
        }
        System.Console.WriteLine("\n................................");



        Array.Reverse(angles); // Reverse the order to get descending order
        System.Console.WriteLine("The angles in descending order are: ");
        foreach (int angle in angles)
        {
            System.Console.Write($"{angle} ");
        }
        System.Console.WriteLine("\n................................");


        int angleSum = 0;
        foreach (int angle in angles)
        {
            angleSum+=angle;
        }
        Console.WriteLine(angleSum == 180 ? $"\nThe sum of the angles is {angleSum} degrees. Valid triangle." : $"\nThe sum of the angles is {angleSum} degrees. Invalid triangle.");
        System.Console.WriteLine("................................");

        System.Console.WriteLine("Enter an angle to search for: "); 
        int searchAngle = int.Parse(Console.ReadLine());
        // int position = Array.IndexOf(angles,searchAngle);  // This will search for the angle starting from index 0
        // int position = Array.IndexOf(angles,searchAngle,2); //this will search for the angle starting from index 2
        int position = Array.IndexOf(angles,searchAngle,1,2);//this will search for the angle starting from index 1 and will only check the next 2 elements (angles[1] and angles[2])
        if (position >= 0) // If the angle is found, position will be >= 0
            System.Console.WriteLine($"Number {searchAngle} has been found at position {position+1}.");
        else
            System.Console.WriteLine($"Number {searchAngle} has not been found in the array.");
 
        System.Console.WriteLine("................................");

        Array.Clear(angles, 1, 2); // Clear the angles array
        // This will set angles[1] and angles[2] to 0, but angles[0] will remain unchanged
        //It will start from index 1 and clear 2 elements, incluided the index 1 itself

        foreach (var angle in angles)
        {
            System.Console.Write($"{angle} "); //this will print the angles array after clearing
        }
    }
}
