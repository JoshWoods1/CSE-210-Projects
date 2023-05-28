using System;
public class Prompt 
{
    public static string[] _prompt = 
    {
        "What was the best part of your day?",
        "How did your day make you feel?",
        "What would you have changed about today",
        "What about today was special?",
        "If you could have done anything you wanted today, what would you have done?"
    };
    public List<string> _randomPrompt = new List<string>(_prompt);
    public Prompt()
    {

    }
    public void Display()
    {
        var random = new Random();
        int index = random.Next(_randomPrompt.Count);
        string randomPrompt = _randomPrompt[index];
        Console.WriteLine($"{randomPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_randomPrompt.Count);
        string prompt = _randomPrompt[index];

        return prompt;
    }
}