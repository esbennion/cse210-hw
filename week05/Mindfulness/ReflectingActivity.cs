using System.Runtime.InteropServices.Marshalling;

public class ReflectingActivity : Activity
{
    private  List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
        :base("Reflection",
        "This activity will help you reflect on times in your life when you have shown strength and resiliance.")
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience?");
        _questions.Add("What did you learn about yourself?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"{prompt}");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }

    private void DisplayQuestion(string question)
    {
        Console.Write($"> {question} ");
        ShowCountDown(5);
        Console.WriteLine();
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);

        Console.WriteLine("Now ponder on each of the following question: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            DisplayQuestion(question);       
        }   

        DisplayEndingMessage();
        
    }

}