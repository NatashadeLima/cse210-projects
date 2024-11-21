
using System;
using System.Collections.Generic;
using System.Linq;
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.ToString();
        string scriptureText = string.Join(" ", _words);
        return $"{referenceText}\n{scriptureText}";
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            int wordsToHide = Math.Min(3, visibleWords.Count);
            for (int i = 0; i < wordsToHide; i++)
            {
                Word word = visibleWords[random.Next(visibleWords.Count)];
                word.Hide();
                visibleWords.Remove(word);
            }
        }
    }

    public bool IsFullyHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}