using System.Reflection.Metadata.Ecma335;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal (string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetShortName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;
    

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: ({_description})";
    }
    
    protected int ApplySupriseBonus(int earned)
    {
        Random random = new Random();
        if (random.Next(1, 11) == 1)
        {
            Console.WriteLine("SUPRISE BONUS!!! +25 POINTS!!!");
            earned += 20;
        }
        return earned;
    }

}
