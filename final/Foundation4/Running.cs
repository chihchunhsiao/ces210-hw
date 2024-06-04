public class Running : Activity
{
    private double _runningDistance;

    public Running(string date, int durationInMin, double runningDistance) : base(date, durationInMin)
    {
        _runningDistance = runningDistance; 
    }

    public override double GetDistance()
    {        
        return _runningDistance;
    }   

    public override double GetSpeed()
    {
        // Speed (kph) = (distance / minutes) * 60
        return _runningDistance / _durationInMin * 60;
    }   

    public override double GetPace()
    {
        // Pace (min per km)= minutes (min) / distance (km)       
        
        return _durationInMin / _runningDistance ;
    } 

    




}