using System;
using System.Configuration.Assemblies;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Welcome to the Journal Program!!" );
        
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        
        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. QUIT");
            Console.Write("Choose an above option: ");

            choice = Console.ReadLine();
        

        if (choice == "1")
        {
            string prompt = promptGen.GetRandomPrompt();
            Console.WriteLine($"{prompt}");
            Console.Write("");
            string response = Console.ReadLine();

            string date = DateTime.Now.ToShortDateString();

            Entry newEntry = new Entry(date, prompt, response);
            journal.AddEntry(newEntry);

            Console.WriteLine("New Entry added.");
        }
        
        else if (choice == "2")
        {
            journal.DisplayAll();
        }
        
        else if (choice == "3")
        {
            Console.Write("Enter a filename to save: ");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
            Console.WriteLine("Journal successfully saved");
        }

        else if (choice == "4")
        {
            Console.Write("Enter filename to load: ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded");
        }
        
        else if (choice !="5")
        {
            Console.WriteLine("Please try again..");
        }

    }
    Console.WriteLine("Thank you, goodbye!");
    }
}