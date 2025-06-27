namespace Classes;

public class Person
    {
    public string Name;

    public void Introduce(string to)
    {
        Console.WriteLine("Hello {0}, Je m'apelle {1}", to, Name);
    }

    public static Person Parse(string str)
    {
        var Person = new Person();
        Person.Name = str;

        return Person;
    }
    }