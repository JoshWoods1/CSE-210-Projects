public class DVD: Loanable
{
    private string _title;


    public DVD(string title)
    {
        _title = title;
    }

    public override void Display()
    {
        Console.WriteLine($"Title: {_title}");
        base.Display();
    }
}