

public class Reception:Event
{
    private string _rsvpEmail;

      public Reception(string title, string description, string date, string time, string type, Address address, string rsvpEmail)
        : base(title, description, date, time, type, address) // Call the base class constructor
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDescription()
    {
       return $" Type: {_type}\n {base.GetFullDescription()}\n RSVP Email:{_rsvpEmail}";
    }
} 