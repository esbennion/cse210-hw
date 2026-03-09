using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
       
        Console.WriteLine("Hello World! This is the Exercise 4 Project.");
       
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        Console.Write("Enter number: ");
        int userNumber = int.Parse(Console.ReadLine());
        
        while (userNumber != 0)
        {
           numbers.Add(userNumber);

           Console.Write("Enter number: ");
           userNumber = int.Parse(Console.ReadLine());
        }

        //Compute the sum
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }

        //Compute the average
        float average = ((float)sum)/ numbers.Count;

        //Find the maximum number 
        int max = numbers[0];
        foreach (int i in numbers)
        {
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");



    }
}