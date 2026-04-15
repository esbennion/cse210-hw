using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("12 April 2026", 30, 3.0));
        activities.Add(new Cycling("12 April 2026", 40, 6.0));
        activities.Add(new Swimming("12 April 2026", 30, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}