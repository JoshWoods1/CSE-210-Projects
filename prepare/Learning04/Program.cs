using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment a1 = new Assignment("Samuel Bennet", "multiplication");
       Console.WriteLine(a1.GetSummary());

       MathAssignment b1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.4", "8-19");
       Console.WriteLine(b1.GetSummary());
       Console.WriteLine(b1.GetHomeworkList());

       WritingAssignment c1 = new WritingAssignment("Mary Waters", "European History", "Causes of WW1");
       Console.WriteLine(c1.GetWritingInfo());
    }
}