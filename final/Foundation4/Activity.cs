public abstract class Activity
{
    protected string _date;
    protected int _durationInMin;

    public Activity(string date, int durationInMin)
    {
        _date = date;
        _durationInMin = durationInMin;
    }

    public abstract double GetDistance();
    

    public abstract double GetSpeed();
    

    public abstract double GetPace();
    

    public virtual string GetSummary(Activity activity)
    {
        return $"{_date} {activity} ({_durationInMin} min) - Distance: {activity.GetDistance()} km, Speed: {activity.GetSpeed()} kph, Pace: {activity.GetPace()} min per km";
    }  

}