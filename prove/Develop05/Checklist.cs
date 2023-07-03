public class Checklist : Goal
{
    private int _amountNeeded;
    private int _timesCompleted;
    private int _bonusPoints;


public Checklist(string name, int points, bool isFisnished, string description, int timeCompleted, int amountNeeded, int bonusPoints)
    {
        _name = name;
        _points = points;
        _isFinished = isFisnished;
        _description = description;
        _timesCompleted = timeCompleted;
        _amountNeeded = amountNeeded;
        _bonusPoints = bonusPoints;
    }

    public override void Display()
    {
        if (_timesCompleted == _amountNeeded)
        {
        Console.WriteLine($"[X] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_amountNeeded}");
        }
        else 
        {
        Console.WriteLine($"[ ] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_amountNeeded}");
        }
    }

    public override string DisplayToFile()
    {
        return $"Checklist Goal: {_name}, {_description},{_points}, {_bonusPoints}, {_amountNeeded}, {_timesCompleted}, {_isFinished} ";
    }

    public override void Complete()
    {
        if (_timesCompleted == _amountNeeded)
        {
            _isFinished = true;
        }
        else
        {
            _timesCompleted += 1;
        }
    }

    public override int GivePoints()
    {
        if (_isFinished == false)
        {
        if (_timesCompleted == _amountNeeded)
        {
            return _bonusPoints + _points;
        }
        else
        {
            return _points;
        }
        }
        else
        {
            Console.WriteLine("Goal already completed");
            return 0;
        }
    }
    public override string Point(int _points)
    {
        return $"You earned {_points} points!";
    }
}