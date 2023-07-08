public class Address
{
    string _streetAddress;
    string _city;
    string _stateProvince;
    string _country;

    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    public string DisplayAddress()
    {
        return$"{_streetAddress}\n{_city}, {_stateProvince} {_country}";
    }
    
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
}