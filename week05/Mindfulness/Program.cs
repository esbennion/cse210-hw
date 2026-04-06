using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start Brathing Activity");
            Console.WriteLine(" 2. Start Reflection Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit ");
            Console.Write("Select a choice from the following menu: ");

            choice = int.Parse(Console.ReadLine());


        if (choice ==1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
        else if (choice ==2)
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }

        else if (choice ==3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
        else if (choice == 4)
            {
                Console.WriteLine("Thank you for enjoying the activiites!! Come again!");
                break;
            }
        else 
            {
            Console.WriteLine("Try again. Press enter to continue. ");
            Console.ReadLine();
            }
        }
    }
}