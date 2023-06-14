public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected string _startingMessage;
    protected string _endingMessage;

    // public Activity(string name, string desc, int dur){
    //     _name = name;
    //     _description = desc;
    //     _duration = dur;
    // }

    public void Intro()
    {
        Console.WriteLine($"Welcome to the {_name} activity. \n {_description} \n  How long would you like the duration to be?");
        _duration = int.Parse(Console.ReadLine());

    }

    public void Outro()
    {
        Console.WriteLine($"{_endingMessage}");
    }
    public void Animation(int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);


            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);

            Console.Write("\b \b");
        }

    }
    public void Countdown()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("3");
            Thread.Sleep(1000);

            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);


            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
        }

    }
}