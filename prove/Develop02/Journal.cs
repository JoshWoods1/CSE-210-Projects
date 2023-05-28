using System.IO;

public class Journal
{
    public List<Entry> _Entries = new List<Entry>();
    private string _fileName;

    public Journal()
    {
    }

    public void AddEntry(Entry entry)
    {
        _Entries.Add(entry);
    }
     public void Display()
    {
        Console.WriteLine("---------------------------");
    foreach(Entry entry in _Entries)
    {
        entry.Display();
    }
        Console.WriteLine("---------------------------");
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

            Prompt prompt = new Prompt();
            Entry entry = new Entry();
            loadedEntries.Add(entry);
            _Entries = loadedEntries;
        }
    }
    // public void LoadFromFile(string filename)
    // {
    //     _Entries.Clear();

    //     using (StreamReader reader = new StreamReader(filename))
    //     {
    //         string line;
    //         string prompt = null;
    //         string response = null;
    //         DateTime date = DateTime.MinValue;

    //         while ((line = reader.ReadLine()) != null)
    //         {
    //             if (prompt == null)
    //             {
    //                 prompt = line;
    //             }
    //             else if (response == null)
    //             {
    //                 response = line;
    //             }
    //             else
            //     {
            //         date = DateTime.Parse(line);
            //         AddEntry(new Entry { Prompt = prompt, Response = response, Date = date });
            //         prompt = null;
            //         response = null;
            //         date = DateTime.MinValue;
            //     }
//             // }
//         }
//     }
// }

}