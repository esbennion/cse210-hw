using System.Diagnostics;
using System.IO.Compression;
using System.Xml.Linq;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

public void Start()
{
    bool running = true;
    while (running)
    {
        DisplayPlayerInfo();
        Console.WriteLine();
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goal Details ");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.Write("Choose an option: ");
        Console.WriteLine();

        string choice = Console.ReadLine();

        switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": running = false; break;
            }

    }
}
private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} total points");
    }

private void ListGoalNames()
    {
        for (int i =0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
private void ListGoalDetails()
    {
        Console.WriteLine("\nYour Goals: ");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{_goals[i].GetDetailsString()}");
        }
    }
private void CreateGoal()
    {
        Console.WriteLine("\nSelect Goal Type");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Your choice: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Descritption: ");
        string descritpion = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if ( type == "1")
        {
            _goals.Add(new SimpleGoal(name, descritpion,points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, descritpion, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("BONUS POINTS: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, descritpion, points, target, bonus));
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("\nWhich goal were you able to accomplish? ");
        ListGoalNames();

        Console.Write("Enter number:  ");
        int index = int.Parse(Console.ReadLine()) -1;

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You have earned {earned} POINTS.");
    }

    private void SaveGoals()
    {
        Console.Write("Filename:  ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        } 
        Console.WriteLine("Goals saved. Thank you.");
    }

    private void LoadGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i ++)
        {
            string [] parts = lines[i].Split(":");
            string type = parts[0];
            string [] fields = parts[1].Split("|");

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(fields[0], fields[1], int.Parse(fields[2]), bool.Parse(fields[3])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(fields[0], fields[1], int.Parse(fields[2])));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(fields[0], fields[1], int.Parse(fields[2]),
                int.Parse(fields[5]), int.Parse(fields[3]), int.Parse(fields[4])));
            }
        }
        Console.WriteLine("Goals loaded.");
    }
}