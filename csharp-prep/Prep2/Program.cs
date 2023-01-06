using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("");
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int intGrade = int.Parse(grade);

        string letter = "";
        Console.WriteLine("");

        if (intGrade >= 90) {
            letter = "A";
        }
        else if (intGrade >= 80) {
            letter = "B";
        }
        else if (intGrade >= 70) {
            letter = "C";
        }
        else if (intGrade >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }
        Console.WriteLine($"Your percentage is {letter}");
        if (letter == "A" || letter == "B" || letter == "C") {
            Console.WriteLine($"You have a {letter}! Nice try!");
        }
        else {
            Console.WriteLine("Sorry, You don't pass.");
        }
        
    }
}