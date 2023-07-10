public class Address
{
    string _address;
    string _city;
    string _state;
    string _country;

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }
    public void DisplayAddress()
    {
        Console.WriteLine($"{_address}\n{_city}, {_state}\n {_country}");
    }
    public string GetAddress()
    {
        return ($"{_address}\n{_city}, {_state}\n{_country}");
    }

}