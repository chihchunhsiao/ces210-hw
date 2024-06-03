public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity) : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"Lecture full details: \nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}\nSpeaker: {_speaker}\nCapacity: {_capacity}\n";
            
    }

   


}   