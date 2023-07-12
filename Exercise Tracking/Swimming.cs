public class Swimming : Activity
{
    int _laps;

    public Swimming(string date, double time, int laps) : base(date, time)
    {
        _laps = laps;
    }
     public override double GetDistance()
     {
        return (_laps * 50) / 1000 * 0.62;
     }
    public override double GetSpeed()
    {
        return GetDistance()/ _time * 60;

    }
    public override double GetPace()
    {
        return _time / GetDistance();
    }
}