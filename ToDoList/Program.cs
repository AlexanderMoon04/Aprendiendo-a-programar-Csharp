string speech = "He said \"Hello, World!\"";
string filePath = @"C:\Users\Public\Documents\ToDoList.txt";
string path = "C:\\Users\\Public\\Documents\\ToDoList.txt";
Console.WriteLine(filePath);
Console.WriteLine(path);
Console.WriteLine(speech);


string name2;
Console.WriteLine("Whats your name?");
name2 = Console.ReadLine();
Console.WriteLine(name2 != String.Empty ? $"Hello, {name2} :)" : "Name is empty");
Console.WriteLine(name2 == "" ? "Name is empty" : "Name is not empty");
Console.WriteLine(string.IsNullOrEmpty((name2)) ? "Name is empty" : "Name is not empty"); //This is a better way to check for empty strings, it can also check for null values.


string name = "Alice";
int age = 30;
Console.WriteLine("Name: " + name);
Console.WriteLine("age: " + age);
Console.WriteLine("Name: " + name + "\nAge: " + age); 
Console.WriteLine($"Your name is {name} and you are {age} years old.");
Console.WriteLine(name.Equals(name2) ? "Same name" : "Different names");


string message = "Your name is " + name + " and you are " + age + " years old c:";
Console.WriteLine(message);
PrintCharacters(message);


static void PrintCharacters(string msg)
{
    for (int i = 0; i < msg.Length; i++)
    {
        Console.WriteLine(msg[i]);
        Thread.Sleep(10); // Sleep for x milliseconds
    }

    Console.WriteLine("\n"+msg.Contains("A"));
}