public class Cycling : Activity
{
    double _speed;

    public Cycling(string date, double time, double speed) : base(date, time)
    {
        _speed = speed;
    }
     public override double GetDistance()
     {
        return (_speed * _time) / 60;
     }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return _time / _speed;
    }
}