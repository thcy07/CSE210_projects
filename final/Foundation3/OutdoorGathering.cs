public class OutdoorGathering:Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, string type, Address address, string weather)
        : base(title, description, date, time, type, address) // Call the base class constructor
    {
        _weather = weather;
    }
    public override string GetFullDescription()
    {
       return $" Type: {_type}\n {base.GetFullDescription()} \n Holds status: {_weather}";
    }

}