public class Customer
{
    private string _name;
    Address _address;
    bool _inUSA;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool InUSA()
    {
        return _address.IsInUSA();
    }
      public void GetShippingLabel()
    {
        Console.WriteLine("Shipping Label\n -----");
        Console.WriteLine($"{_name} - {_address.DisplayAddress()}");
    }
}