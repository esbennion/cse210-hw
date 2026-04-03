using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Emily Bennion", "Addition");

        string summary = a1.GetSummary();
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Natasha Smith", "Multiplication", "2.2", "4-14");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Bob Bobby", "American History", "Events Leading to the Civil War");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWrititingInformation());
    }
}