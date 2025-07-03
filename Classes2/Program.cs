using System.Reflection;

namespace Classes2;

class Program
{
    /*
    struct Person //To use Struct you must assign values
    {
        public string name;
        public int age;

        public Person (string name, int age)
        {
            this.name = name;
            this.age=age;
        }
    }*/

    class Person //Class let you do overload of constructors and create them without assign any values.
    {

        public string Name {get; set; } //auto-property
        public int Age {get; set; }
        // private string name;
        // private int age;

        
        // public string Name
        // {
        //     get => name;
        //     set => name =!string.IsNullOrEmpty(value) ? value : string.Empty; //You dont have to specify a value, it just get simply asigned in
        // }
        // public int Age
        // {
        //     get => age;
        //     set => age = value >= 0 && value <= 150 ? value : -1;
           
        // }
    
        // public string Name {get => name; set => name= value;}
        // public int Age {get => age; set => age= value;}



        // //Overload of constructors
        // public Person() 
        // {
        // }
        // public Person(string name)
        // {
        //     this.name = name;
        // }
        // public Person(int age)
        // {
        //     this.age=age;
        // }
        public Person (string name, int age)
        {
            // this.name = name;
            // this.age = age;
            Name =name;
            Age = age;
        }

        /*
        public void SetName(string name)
        {
            // if (!string.IsNullOrEmpty(name))
            //     this.name = name;
            // else
            //     this.name=string.Empty;
           
            this.name =!string.IsNullOrEmpty(name) ? name : string.Empty;
        }

        */
        // public void SetName(string name) => this.name =!string.IsNullOrEmpty(name) ? name : string.Empty;
     
        /*
        public void SetAge()
        {
            this.age = age >= 0 && age <= 150 ? age : -1;
        }
        */
        
        // public void SetAge() => this.age = age >= 0 && age <= 150 ? age : -1;


        /*
        public int GetAge()
        {
            return age;
        }
        */
        // public int GetAge() => age; //Arrow function to return one simple line, is the same as the other function GetAge()
        // public string GetName() => name; //Arrow function to return one simple line, is the same as the other function GetAge()

        //Properties make easier to do notations

        public string ReturnDetails()
        {
            return $"Name: {Name}\nAge: {Age}";
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}";
        }
        public override bool Equals(object obj) //Test if 2 objects are equals each other
        {
            if (obj is Person)
            {
                Person person = obj as Person; //Convert the object into a person
                return Name.Equals(person.Name) && Age == person.Age;
            }
            return false;
        }
    }

    static void Main(string[] args)
    {
        Person person = new ("aleps",23);
        // Console.WriteLine($"Name: {person.name}, Age: {person.age}");
        System.Console.WriteLine(person.ReturnDetails());
        Console.WriteLine(new string('-', 50));
        // person.name = "Underteiker";
        // person.age= 25;

        // person.SetName("Miguelon");
        // System.Console.WriteLine(person.ReturnDetails());

        person.Name = "Harry";
        person.Age=24;
        System.Console.WriteLine(person.ReturnDetails());
        Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}"); //Here the data is shown using properties
        Console.WriteLine(new string('-', 50));

        System.Console.WriteLine(person.ToString());

        Person test = new ("El Dui",69);
        System.Console.WriteLine(test);

        if (person.Equals(test))
            System.Console.WriteLine("Same");
        else
            System.Console.WriteLine("Not same");
    }
}
