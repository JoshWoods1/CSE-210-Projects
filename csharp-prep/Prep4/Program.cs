using System;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        int inputNum = -1;

        while (inputNum != 0)
        {
            Console.Write("Please enter some numbers.");
            string numStr = Console.ReadLine();
            inputNum = int.Parse(numStr);

            if (inputNum != 0)
            {
                numbers.Add(inputNum);
            }
        }
        // Get the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        //  Get the average
        float avg = ((float)sum)/ numbers.Count(); 
        Console.WriteLine($"The average is {avg}");
        int max = 0;
        foreach (int number in numbers)
        if (number > max)
        {
            max = number;
        }
        Console.Write($"The largest number is {max}.");
    }
}