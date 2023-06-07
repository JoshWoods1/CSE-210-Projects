public class Scripture
{
    List<Word> _words = new List<Word>();
    Reference _reference;

    public Scripture(string words, Reference reference)
    {
        _reference = reference;
        string[] parts = words.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void HideWords()
    {
        for (int i = 0; i < 3; i++)
        {
        // get random number
        Random ranObj = new Random();
        int randNum = ranObj.Next(_words.Count());
        _words[randNum].HideWord();}
    }


    public void Display()
    {
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    public bool CompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() == false)
            {
                return false;
            }
            else if (word.GetIsHidden() != false)
            {
                return true;
            }
        }
        return true;
    }
    
}