public class Eternal : Goal
{


    public Eternal(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _description = description;
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }
    public override string DisplayToFile()
    {
        return $"Eternal Goal: {_name}, {_description}, {_points}";
    }
}