

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

     public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }

        return false;
    }

    public string FormatAddress()
    {
        return $"{_street}\n{_city}, {_state}, {_country}";
    }

}