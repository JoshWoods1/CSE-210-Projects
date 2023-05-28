public class Scripture
{
    List<Word> _words;
    Reference _reference;

    public Scripture(List<Word> words, Reference reference)
    {
        _words = words;
        _reference = reference;
    }

    public void HideWords(List<Word> words)
    {
        // get random number
        Random number = new Random();
        _words[number.Next(7)].HideWord();
    }

}