using System;

class Program
{
    static void Main(string[] args)
    {
        //call the functions
        DisplayWelcomeMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }
        
     //display the welcome message
     static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello World! This is the Exercise 5 Project.");
        Console.WriteLine("Welcome to the Program!");
    }

    //ask the user for the username
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?  ");
        return Console.ReadLine(); 
    }

    //ask for the users favorite number
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    //takes favorite number and returns it squared
    static int SquareNumber(int number)
    {
        return number * number;
    }

    //takes user's name and the squared number and returns  both
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}