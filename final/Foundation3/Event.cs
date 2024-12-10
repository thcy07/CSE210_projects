public class Event
{
    protected string _title;
    protected string _description;
    private string _date;
    private string _time;
    protected string _type;
    private Address _address;

     public Event(string title, string description, string date, string time, string type, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }
    public string GetStandardDescription()
    {
        return $" {_title}: {_description}\n {_date} at {_time} \n {_address.FormatAddress()}";
    }
    public virtual string GetFullDescription()
    {
        return $"{_title}: {_description}\n {_date} at {_time} \n {_address.FormatAddress()}";
    }
    public string GetShortDescription()
    {
        return $" Type: {_type}\n {_title}\n {_date}";
    }

}