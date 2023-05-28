public class Word 
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;

    }
    
    public void HideWord()
    {
        _isHidden = true;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }

    public void Display()
    {
        if (_isHidden == true)
        {
            Console.WriteLine("____");
        }
        else {
            Console.WriteLine($"{_word}");
        }
    }
    
}