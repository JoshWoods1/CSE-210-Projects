public class Listing : Activity
{
    string[] _prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    public Listing()
    {
        _name = "listing";
        _description = "This activity will help you think of the good things in your life by listing as many things as you can.";
    }

    public void DoListingActivity()
    {
        Intro();
        Console.WriteLine("Get Ready...");
        Animation(3);
        Console.Write("List as many responses as you can to the following prompt.\nYou may begin in:");
        Countdown();
        Console.WriteLine(GetPrompt());
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);

        int count = 0;
        while (DateTime.Now < futureTime)
        {
            string item = Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!\n");
        Outro();
    }

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());
        return _prompts[index];
    } 
}