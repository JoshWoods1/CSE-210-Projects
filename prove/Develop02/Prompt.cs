public class Prompt 
{
    public string[] _prompt = 
    {
        "What was the best part of your day?",
        "How did your day make you feel?",
        "What would you have changed about today",
        "What about today was special?",
        "If you could have done anything you wanted today, what would you have done?"
    };
    public List<Prompt> randomPrompt = new List<Prompt>();

    public void GetPrompt()
    {
        var random = new Random();
        var randomNumber = random.Next(0,randomPrompt.Count);
    }
}