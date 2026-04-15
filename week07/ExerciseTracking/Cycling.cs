public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _name = "Cycling";
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetMinutes())/ 60;
    }

    public override double GetPace()
    {
        return _speed;
    }

    public override double GetSpeed()
    {
        return 60 / _speed;
    }
}