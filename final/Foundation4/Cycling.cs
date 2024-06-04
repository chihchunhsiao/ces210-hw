public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int durationInMin, double speed) : base(date, durationInMin)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Speed (kph) = (distance / minutes) * 60
        // Distance (km) = Speed (kph) / 60 * minutes
        return _speed / 60 * _durationInMin ;
    }   

    public override double GetSpeed()
    {
        return _speed;
    }   

    public override double GetPace()
    {
        // Distance (km) = Speed (kph) / 60 * minutes
        // Pace (min per km)= minutes (min) / distance (km) 
        double distance = _speed / 60 * _durationInMin;
        double pace = _durationInMin / distance;

        return pace;
    } 

    

}