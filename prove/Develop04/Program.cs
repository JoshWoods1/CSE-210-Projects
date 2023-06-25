using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        Breathing breathing = new Breathing();

        // breathing.DoBreathingActivity();

        Reflecting reflecting = new Reflecting();
        // reflecting.DoRefecltionActivity();

        Listing listing = new Listing();
        // listing.DoListingActivity();
        while (true)
        {
         Console.WriteLine("Mindfulness App");
        Console.WriteLine("----------------");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                breathing.DoBreathingActivity();
                break;
            case 2:
                reflecting.DoRefecltionActivity();
                break;
            case 3:
                listing.DoListingActivity();
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
        }
    }
}