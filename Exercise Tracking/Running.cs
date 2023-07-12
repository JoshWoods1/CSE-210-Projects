public class Running : Activity
{
    double _distance;

    public Running(string date, double time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _time) * 60;
    }
    public override double GetPace()
    {
        return _time / _distance;
    }
}