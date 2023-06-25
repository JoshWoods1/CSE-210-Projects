public class Reflecting : Activity
{
    private string[] _prompt = 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    private string[] _questions =  
        {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
        };
    public Reflecting()
    {
        _name = "reflecting";
        _description = "This activity will help you reflect on your recent and past experiences. It will help you recognize the power that you have over your life";
    }

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count());
        return _prompt[index];
    }

    public string GetQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count());
        return _questions[index];
    }
    public void DoRefecltionActivity()
    {
        Intro();
        Console.WriteLine("Get Ready...");
        Animation(3);

        Console.WriteLine("Consider the following prompt...\n");
        Console.WriteLine(GetPrompt(), "\n\n");

        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        Console.ReadLine();
        
        Console.Write("Ponder on this question as it relates to the experience. \nYou may begin in:");
        Countdown();
        for (int i = 0; i < _duration / 5; i++)
        {
        Console.WriteLine(GetQuestion());
        Console.WriteLine();
        Animation(5);

        }
        Outro();

    }
}