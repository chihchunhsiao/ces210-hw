public class Receptions : Event
{
    private string _emailRSVP;

    public Receptions(string eventTitle, string description, string date, string time, Address address, string emailRSVP) : base(eventTitle, description, date, time, address)
    {
        _emailRSVP = emailRSVP;
    }

    public string GetFullDetails()
    {
        return $"Receptions full details: \nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}\nEmail for RSVP: {_emailRSVP}\n";
    }

    

}   