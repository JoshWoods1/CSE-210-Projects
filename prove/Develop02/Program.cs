using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal);
                    break;
                case "2":
                    DisplayJournal(journal);
                    break;
                case "3":
                    SaveJournalToFile(journal);
                    break;
                case "4":
                    LoadJournalFromFile(journal);
                    break;
                case "5":
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void WriteNewEntry(Journal journal)
    {
        Console.WriteLine("Prompt: {0}", journal.GetRandomPrompt());
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        journal.AddEntry(response);
        Console.WriteLine("Entry added successfully.");
    }

    private static void DisplayJournal(Journal journal)
    {
        List<Entry> entries = journal.GetEntries();
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found in the journal.");
        }
        else
        {
            Console.WriteLine("Journal entries:");
            foreach (Entry entry in entries)
            {
                Console.WriteLine("Date: {0}", entry._date);
                Console.WriteLine("Prompt: {0}", entry._prompt);
                Console.WriteLine("Response: {0}", entry._response);
                Console.WriteLine();
            }
        }
    }

    private static void SaveJournalToFile(Journal journal)
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                List<Entry> entries = journal.GetEntries();
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
                }
            }

            Console.WriteLine("Journal saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while saving the journal: " + ex.Message);
        }
    }

    private static void LoadJournalFromFile(Journal journal)
    {
        Console.Write("Enter the filename to load the journal from: ");
        string filename = Console.ReadLine();

        try
        {
            List<Entry> entries = new List<Entry>();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[0], parts[1], parts[2]);
                        entries.Add(entry);
                    }
                }
            }

            journal.ReplaceEntries(entries);
            Console.WriteLine("Journal loaded from file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while loading the journal: " + ex.Message);
        }
    }
}