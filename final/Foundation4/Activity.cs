

public class Activity
{
    private float _duration;
    private DateTime _date;

      public Activity(float duration, DateTime date, float lapLength = 50)
    {
        _duration = duration;
        _date = date;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public float GetDuration()
    {
        return _duration;
    }
    public virtual float GetDistance()
    {
        return 0;
    }
    public virtual float GetSpeed()
    {
        // float speed = (GetDistance()/_duration)*60;
        // float speed= 60/GetPace();
        return 0;
    }
    public virtual float GetPace()
    {
        // float pace = 60/GetSpeed();
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} ({GetDuration()} min)- Distance {GetDistance()} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km\n";;
    }
}