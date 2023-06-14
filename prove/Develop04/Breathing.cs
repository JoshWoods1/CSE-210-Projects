public class Breathing : Activity
{
    public Breathing()
    {
        _name = "breathing";

        _description = "Do breathing stuff";
    }

    public void DoBreathingActivity()
    {
        Intro();

        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000);
            Console.WriteLine("Breathe Out...");
            Thread.Sleep(3000);
        }
        Animation(5);

        Outro();
    }
}
