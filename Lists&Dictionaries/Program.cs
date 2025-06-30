namespace Lists_Dictionaries;

class Program
{
    static void Main(string[] args)
    {
        int [] numbers = [4,5,3];

        List<int> listNumbers = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            System.Console.Write("Enter a number: ");
            listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
        }
        for (int i = 0; i < listNumbers.Count; i++)
        {
            System.Console.WriteLine($"Number {i+1} is {listNumbers[i]}");
        }
        System.Console.WriteLine("................................");

        listNumbers.RemoveAt(0); // Remove the first element
        listNumbers.Remove(5); // Remove the first occurrence of the number 5
        foreach (var item in listNumbers)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("................................");

        //Dictionaries are collections of key-value pairs
        Dictionary<int, string> names = new Dictionary<int, string>
        {
            {4, "Adam"}, //KeyValuePair with key 4 and value "Adam"
            {2, "Eve"}, //KeyValuePair with key 2 and value "Eve"
            {3, "John"} //KeyValuePair with key 3 and value "John"
        };
        names.Add(1,"Addamantium"); //KeyValuePair with key 1 and value "Addamantium", they key must be unique

        for (int i = 0; i<names.Count; i++) // Iterate through the dictionary using a for loop
        {
            KeyValuePair<int,string> pair =names.ElementAt(i); // Get the KeyValuePair at index i
            System.Console.WriteLine($"{pair.Key} - {pair.Value}"); // Print the key and value 
        }
        System.Console.WriteLine("................................");
        // Alternatively, you can use a foreach loop to iterate through the dictionary
        foreach (var item in names)
        {
            System.Console.WriteLine($"{item.Key} - {item.Value}"); // Print the key and value 
        }
        System.Console.WriteLine("................................");

        Dictionary<string, string> teachers = new Dictionary<string, string>
        {
            {"Adam", "Math"},
            {"Eve", "Science"},
            {"John", "History"},
            {"Memo", "Programming"}
        };

        System.Console.WriteLine(teachers["Adam"]); // Access the value associated with the key "Math"
        
        if(teachers.TryGetValue("Adam", out string teacher))
        {
            System.Console.WriteLine(teacher); // Print the value associated with the key "Math"
            teachers["Adam"] = "Electronic"; // Update the value associated with the key "Adam"
        }
        else
            System.Console.WriteLine("Math teacher not found.");

        // teachers.Remove("Memo"); // Remove the key-value pair with key "Memo"

        if (teachers.ContainsKey("Memo")) // Check if the key "Memo" exists in the dictionary
            teachers.Remove("Memo"); // Remove the key-value pair with key "Memo"
        else
        System.Console.WriteLine("Memo teacher not found.");

        foreach (var item in teachers)
        {   
            System.Console.WriteLine(item); // Print each character in the string
        }



        




    } 
}
