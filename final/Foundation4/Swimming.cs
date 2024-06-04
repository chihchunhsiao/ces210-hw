public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(string date, int durationInMin, double numberOfLaps) : base(date, durationInMin)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        // Distance (km) = swimming laps * 50 (m) / 1000
        return _numberOfLaps * 50 / 1000;
    }   

    public override double GetSpeed()
    {
        // Distance (km) = swimming laps * 50 (m) / 1000
        // Speed (kph) = (distance / minutes) * 60
        double distance = _numberOfLaps * 50 / 1000;
        double speed = (distance / _durationInMin) * 60;

        return speed;
    }   

    public override double GetPace()
    {
        // Distance (km) = swimming laps * 50 (m) / 1000
        // Pace (min per km)= minutes (min) / distance (km) 
        double distance = _numberOfLaps * 50 / 1000;
        double pace = _durationInMin / distance;

        return pace;
    } 

    
}