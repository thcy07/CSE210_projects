
public class Swimming:Activity
{
    private float _lapLength = 50;
    private int _laps;
    public Swimming(float duration, DateTime date, int laps, float lapLength = 50)
        : base(duration, date)
    {
        _laps = laps;
        _lapLength = lapLength;
    }

    public override float GetDistance()
    {
        return _laps * _lapLength / 1000;
    }

    public override float GetPace()
    {
        return GetDuration()/GetDistance();
    }
    public override float GetSpeed()
    {
        return (GetDistance()/GetDuration())*60;
    }

    public override string GetSummary()
    {
        return $"Swimming {base.GetSummary()}" ;
    }
}