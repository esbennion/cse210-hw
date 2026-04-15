using System.Diagnostics.Contracts;

public abstract class Activity
{
    private string _date;
    private int _minutes;
    protected string _name;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes; 
    }

    public int GetMinutes() => _minutes;
    public string GetDate() => _date;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} minutes) - "  +   
               $"Distance {GetDistance(): 0.0} miles, " +  
               $"Speed {GetSpeed(): 0.0} mph, " +  
               $" Pace {GetPace(): 0.0} minutes per mile";
    }
}