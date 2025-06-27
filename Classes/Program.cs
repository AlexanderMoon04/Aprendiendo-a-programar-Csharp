using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;

namespace Classes;

   
    class Program
    {
        static void Main(string[] args)
        {
        var customer = new Customer(1, "Tilin");
        customer.Orders.Add(new Order());
        customer.Orders.Add(new Order());
        customer.Promote();
        Console.WriteLine(customer.Orders.Count);
        Console.WriteLine(customer.ID);
        Console.WriteLine(customer.Name);

  


        var order = new Order();
        customer.Orders.Add(order);

        var person = Person.Parse("Mr. Dickson");
        person.Introduce("Tilin");
        }
    }
