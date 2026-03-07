using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 3 Project.");
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;
        
        while(guess != magicNumber)
        {
            Console.Write("Try and pick what number I am thinking. What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Go higher!");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Try lower!");
            }
            else
            {
                Console.WriteLine("Correct, You guessed right!");
            }

        }

    }
}