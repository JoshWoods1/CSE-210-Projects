public class Entry{

    public Prompt _prompt;

    public DateTime _date;

    public string _text;

    public Entry(Prompt prompt, DateTime date, string text)
    {
        _prompt = prompt;
        _date = date;
        _text = text;
        
    }
}