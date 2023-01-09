using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int myNum = -1;
        while (myNum != 0) {
            
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            
            string response = Console.ReadLine();
            myNum = int.Parse(response);

            if (myNum != 0) {
                numbers.Add(myNum);
            }
        }

        Console.WriteLine("");
        int sum = 0;
        foreach (int number in numbers) {
            sum = sum + number;
        }

        Console.WriteLine($"The sum is {sum}.");
    
        int max = 0;
        foreach (int number in numbers) {
            if (number > max) {
                max = number;
            }
        }

        Console.WriteLine($"The max is {max}.");
    }   
}