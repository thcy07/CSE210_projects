
public class Running:Activity
{
    private float _distance;

     public Running(float duration, DateTime date, float distance)
        : base(duration, date)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
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
        return $"Running {base.GetSummary()}";
    }
}