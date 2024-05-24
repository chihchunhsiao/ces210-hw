using System;
using System.ComponentModel;

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

    public string GetShortName()
    {
        return _shortName;
    }

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }


    public abstract void RecordEvent();
   
    public abstract bool IsComplete();
   

    public virtual string GetDetailsString()
    {
        
        return $"{_shortName} ({_description})";
               
    }

    public abstract string GetStringRepresentation();
  
}