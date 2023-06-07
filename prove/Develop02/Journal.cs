using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts;
    private Random random;

    public Journal()
    {
        _entries = new List<Entry>();
        _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        random = new Random();
    }
     public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    
    public void AddEntry(string response)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string prompt = GetRandomPrompt();
        Entry entry = new Entry(date, prompt, response);
        _entries.Add(entry);
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }

     public void ReplaceEntries(List<Entry> newEntries)
    {
        _entries = newEntries;
    }
}
