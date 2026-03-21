using System;
public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public Entry()
    {

    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}: {_prompt}\n{_response}\n");
    }
}