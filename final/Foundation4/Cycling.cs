public class Cycling:Activity
{
    private float _speed;

    public Cycling(float duration, DateTime date, float speed)
        : base(duration, date)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return (GetSpeed() * GetDuration()) / 60;
    }

    public override float GetPace()
    {
        return GetDuration() / GetDistance();
    }
    public override float GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"Cycling {base.GetSummary()}";
    }
}