using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    
    // Virtual so ChecklistGoal can override it to show 0/5 etc.
    public virtual string GetDetailsString()
    {
        string statusSymbol = IsComplete() ? "[X]" : "[ ]";
        return $"{statusSymbol} {_shortName} ({_description})";
    }

    // This is for saving to the .txt file
    public abstract string GetStringRepresentation();

    public string GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _shortName;
    }
}