public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        :base(shortName, description, points)
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        int earned = GetPoints();
        earned = ApplySupriseBonus(earned);
        return earned;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}

