using System;

class Program
{
    static void Main(string[] args)
    {

        Reference Proverbs = new Reference("Proverbs", 3, 5,6);
        Console.WriteLine("Press enter to hide words or type quit to end the program.");
        string response = Console.ReadLine();

        Scripture scripture = new Scripture("Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy paths.", Proverbs);

        while (!scripture.CompletelyHidden() && response != "quit")
        {
        Console.Clear();
        Proverbs.Display(); 
        scripture.Display();

        scripture.HideWords(); 
        response = Console.ReadLine();

        }

    }
}