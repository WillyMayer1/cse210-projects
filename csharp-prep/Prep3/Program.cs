using System;

class Program
{
    static void Main(string[] args)
    {   
            string playAgain = "yes";

            while (playAgain == "yes") {

    
                Random randomGen = new Random();
                int ranNum = randomGen.Next(1, 101);

                int myNum = 0;

                while (myNum != ranNum) {

                    Console.WriteLine("What is the magic number? ");
                    myNum = int.Parse(Console.ReadLine());

                    if (myNum > ranNum) {
                        Console.WriteLine("Higher");
                    }

                    else if (myNum < ranNum) {
                        Console.WriteLine("Lower");
                    }

                    else {
                        Console.WriteLine("You got it!");

                    }
                }
            Console.WriteLine("");
            Console.WriteLine("Do you want to play again? ");
            playAgain = (Console.ReadLine());
        }
    }
}