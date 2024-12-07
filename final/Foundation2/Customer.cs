

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetName()
    {
        return _customerName;
    }

    public string GetAddressString()
    {
        return _address.FormatAddress();
    }

    public bool InUSA()
    {
        return _address.InUSA();
    }

}