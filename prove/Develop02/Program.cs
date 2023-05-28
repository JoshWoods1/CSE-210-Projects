using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static Journal journal = new Journal();
    static void Main(string[] args)
    {
        List<Prompt> _prompt = new List<Prompt>();
        {

        }

        bool running = true;
        while (running)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Prompt randomPrompt = _prompt[new Random().Next(_prompt.Count)];
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    Console.WriteLine("What is the filename");
                    string filename = Console.ReadLine();
                    journal.SaveJournal(filename);
                    break;
                case 4:
                    journal.LoadJournal();
                    break;
                case 5:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }
    }
}
