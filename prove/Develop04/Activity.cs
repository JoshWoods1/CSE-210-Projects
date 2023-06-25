public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void Intro()
    {
        Console.WriteLine($"Welcome to the {_name} activity. \n\n{_description} \n \nHow long would you like the duration to be? (In seconds)");
        _duration = int.Parse(Console.ReadLine());

    }

    public void Outro()
    {
        Animation(3);
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity!");
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
        for (int i = 0; i < 1; i++)
        {
             Console.Write("5");
            Thread.Sleep(1000); 
            Console.Write("\b \b");

            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            Console.Write("3");
            Thread.Sleep(1000);

            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);


            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            
            Console.Clear();


        }

    }
}