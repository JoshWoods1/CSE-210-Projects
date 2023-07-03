public class Goal
{
    protected int _points;
    protected string _name;
    protected string _description;
    protected bool _isFinished;
    

    public virtual void Display()
    {

    }

    public virtual string  DisplayToFile()
    {
        return "";
    }

    public virtual void Complete()
    {

    }

    public virtual int GivePoints()
    {
        return 0;
    }
    public virtual string Point(int _points)
    {
        return $"You earned {_points} points!";
    }
}