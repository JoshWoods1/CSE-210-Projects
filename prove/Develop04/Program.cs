using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Breathing breathing = new Breathing();

        breathing.Intro();
        breathing.Animation(5);
    }
}