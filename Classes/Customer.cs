namespace Classes;

public class Customer
{
    public int ID;
    public string Name;

    // readonly helps to improve robustness and maintainability of the code.
    public readonly List<Order> Orders = new List<Order>(); //In this list we can add objects of type Order
    public Customer(int ID)
    {
        this.ID = ID;
    }     public Customer(int ID, string name)
        : this(ID) //This is a constructor chaining
    {
        this.Name = name;
    }

    public void Promote()
    {

    }
}
