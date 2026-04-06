public class BreathingActivity : Activity
{
    public BreathingActivity()
        :base ("Breathing:",
                "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breating. ")
    {
    
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in ...");
            ShowCountDown(5);

            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }
}