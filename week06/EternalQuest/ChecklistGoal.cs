using System.ComponentModel;

public class ChecklistGoal : Goal
{   

private int _amountCompleted;
private int _target;
private int _bonus;

public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted = 0)
    :base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int earned = GetPoints();
        if (_amountCompleted == _target)
        {
            earned += _bonus;
        }
        earned = ApplySupriseBonus(earned);
        return earned;
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {GetShortName()} ({GetDescription()}) -- Completed {_amountCompleted}|{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {GetShortName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_amountCompleted}|{_target}";
    }
}