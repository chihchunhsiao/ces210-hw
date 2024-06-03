public class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string eventTitle, string description, string date, string time, Address address, string weatherForecast) : base(eventTitle, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetFullDetails()
    {
        return $"Lecture Full details: \nTitle: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}\nWeather Forecast: {_weatherForecast}\n";
    }

    
}   