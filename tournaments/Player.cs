public class Player 
{
    private string _fname;
    private string _lname;
    private int _jersey;

    public Player(string firstname, string lastname, int jerseyNumber)
    {
        _fname = firstname;
        _lname = lastname;
        _jersey = jerseyNumber;
    }

    public void UpdateJersey(int newNumber)
    {
        _jersey = newNumber;
    }
    public void Display()
    {
        Console.WriteLine($"{_fname} {_lname}: {_jersey}");
    }
}
