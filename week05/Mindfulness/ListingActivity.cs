public class ListingActivity : Activity
{
        private List<string>  _prompts = new List<string>();

        public ListingActivity()
            :base("Listing",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ")
        {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        }

        private string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }

        private List<string>GetListFromUser(DateTime endTime)
        {
            List<string> items = new List<string>();

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string item = Console.ReadLine();
                items.Add(item);
            }
            return items;
        }

        public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt");
        Console.WriteLine($"{prompt}");
        Console.WriteLine();

        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        List<string> items = GetListFromUser(endTime);

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items.");

        DisplayEndingMessage();
    }
}