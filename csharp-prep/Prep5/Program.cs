using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            string InputNumber = Console.ReadLine();
            int number = int.Parse(InputNumber);

            return number;
        }

        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name} the square of your number is {squaredNumber}! ");
        }

        DisplayMessage();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));

    }
}