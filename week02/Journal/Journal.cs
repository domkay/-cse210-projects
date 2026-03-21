using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (var entry in _entries)
        {
            writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];
            _entries.Add(newEntry);
        }
    }
    // Search method to search entries that contains a word
    public void SearchEntries(string keyword)
    {
        Console.WriteLine($"Searching for keyword: {keyword}");
        foreach (var entry in _entries)
        {
            //Console.WriteLine($"Checking entry: {entry._prompt} | {entry._response}");
            if (entry._prompt.ToLower().Contains(keyword.ToLower()) ||
                entry._response.ToLower().Contains(keyword.ToLower()))
            {
                Console.WriteLine("Match found!");
                entry.DisplayEntry();
            }
            else
            {
                Console.WriteLine("No match found! Please loade the journal first...");
            }
        }
    }
}