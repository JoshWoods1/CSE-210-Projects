public abstract class Activity
{
    protected string  _date;
    protected double _time;

    public Activity(string date, double time)
    {
        _date = date;
        _time = time;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        Console.WriteLine("-----------------");
        return $"{_date} -- {GetType().Name} Activity ({_time} mins) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }

}