public class Entry{

    public string _prompt;

    public string _date;

    public string _text;

    public Entry()
    {        
    }

    public void Display()
    {
        Console.WriteLine($"Date:{_date}");
        Console.WriteLine($"Prompt:{_prompt}");
        Console.WriteLine($"Entry:{_text}");


    }
}