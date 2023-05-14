using System.IO;

public class Journal
{
    public List<Entry> _Entries;


    public Journal()
    {
        _Entries = new List<Entry>();
    }

     public void AddEntry(Prompt prompt, string text)
    {
            Entry entry = new Entry(prompt, DateTime.Now, text);

        _Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _Entries){
        Console.WriteLine($"Date: {entry._date}\n{entry._prompt}\n {entry._text}");
    }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
            foreach(Entry entry in _Entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._text}");
            }
    }
    public void LoadJournal()
    {
        Console.WriteLine("Please enter a filename:");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        List<Entry> loadedEntries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date =  parts[0];
            string promptText = parts[1];
            string text = parts[2];

            Prompt prompt = new Prompt(promptText, DateTime.Now);
            Entry entry = new Entry(prompt, DateTime.Parse(date), text);
            loadedEntries.Add(entry);
            _Entries = loadedEntries;
        }
    }

}