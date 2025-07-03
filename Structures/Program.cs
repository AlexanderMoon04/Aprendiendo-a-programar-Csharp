using System.Data;
using System.Runtime.Intrinsics.Arm;

namespace Structures;

class Program
{
    struct Person
    {
        public string name;
        public int age;
        public int birthMonth;
        public int number;

        public Person (string name, int age, int birthMonth, int number)//This is a constructor
        {
            this.name = name;
            this.age = age;
            this.birthMonth = birthMonth;
            this.number = number;
        }

    }
    static void Main(string[] args)
    {
        // Person person;

        // person.name="Yonsina";
        // person.age=23;
        // person.birthMonth=5;
        // Console.WriteLine($"Person: {person.name} - {person.age} - {person.birthMonth}");

        // Console.WriteLine(new string('-', 50));

        string newName = ReturnPerson(out int newAge);

        Console.WriteLine($"{newName} - {newAge}");
        
        Console.WriteLine(new string('-', 50));

        Person person = ReturnPersonStructure();
        Console.WriteLine($"Person: {person.name} - {person.age} - {person.birthMonth} - {person.number}");



    }
    static string ReturnPerson(out int age)
    {
        System.Console.Write("Enter name: ");
        string name = Console.ReadLine();
        System.Console.Write("Enter age: ");
       age = int.Parse(Console.ReadLine());

       return name;
    }

    static Person ReturnPersonStructure()
    {
        System.Console.Write("Enter name: ");
        string name = Console.ReadLine();
        System.Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        System.Console.Write("Enter birth month: ");
        int birthMonth = int.Parse(Console.ReadLine());
        System.Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        // Person person;
        // person.age=age;
        // person.name=name;
        // person.birthMonth=birthMonth;
        // person.number = number;

        // // return person;

        return new Person(name, age, birthMonth,number); 
    }
} 
