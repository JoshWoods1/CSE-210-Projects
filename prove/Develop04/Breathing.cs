public class Breathing : Activity
{
    public Breathing()
    {
        _name = "breathing";

        _description = "This activity will help you relax by controlling your breathing. Clear your mind and focus on the program.";
    }

    public void DoBreathingActivity()
    {
        Intro();
        Console.WriteLine("Get Ready...");
        Animation(5);
        for (int i = 0; i < _duration / 10; i++)
        {
            Console.WriteLine("Breathe in...");
            Countdown();
            Console.WriteLine("Breathe Out...");
            Countdown();
        }
        Outro();
    }
}
