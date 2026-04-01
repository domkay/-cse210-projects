using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        // To Split text into words and remove empty entries (handles multiple spaces/newlines)
        string[] splitWords = text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Stretch Challenge: Only pick from words that are NOT already hidden
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        // to make sure that we don't try to hide more words than are visible, we take the minimum of the two

        int actualToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < actualToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            // Remove from the list so it won't be picked again in this round
            visibleWords.RemoveAt(index); 
        }
    }

    public string GetDisplayText()
    {
        string verseText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {verseText}";
    }

    public bool IsCompletelyHidden() => _words.All(w => w.IsHidden());
}