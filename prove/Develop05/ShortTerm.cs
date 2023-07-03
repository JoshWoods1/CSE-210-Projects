public class ShortTerm : Goal
{
    public ShortTerm(string name, int points, bool isFisnished, string description)
    {
        _name = name;
        _points = points;
        _isFinished = isFisnished;
        _description = description;
    }

    public override void Display()
    {
        if (_isFinished == true)
        {
        Console.WriteLine($"[X] {_name} ({_description})");
        }
        else 
        {
        Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }

    public override string DisplayToFile()
    {
        return $"Simple Goal: {_name}, {_description}, {_points}, {_isFinished}";
    }

    public override void Complete()
    {
        _isFinished = true;
    }

    public override int GivePoints()
    {
        if (_isFinished == false)
       {
        return _points;
        }
       else 
       {
        Console.WriteLine("Goal is already complete.");
        return 0;
       }

    }
    public override string Point(int _points)
    {
        return $"You earned {_points} points!";
    }

}