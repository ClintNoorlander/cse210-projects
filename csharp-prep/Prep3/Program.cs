using System;

class Program
{
    static void Main(string[] args)
    {
        Random number = new Random();
        int magicNumber = number.Next(1, 101);

        Console.WriteLine("I am thinking of a magic number between 1 and 100");

        string answer;

        do
        {
            Console.WriteLine("");
            Console.Write("What is your guess? ");
            string guess_string = Console.ReadLine();
            int guess = int.Parse(guess_string);

            if (guess == magicNumber)
            {
                answer = "correct";
            }
            else
            {
                answer = "incorrect";
                if (guess < magicNumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Try guessing higher");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Try guessing lower");
                }
            }

        } while (answer == "incorrect");

        Console.WriteLine($"Congratulations! you guessed that the magic number was {magicNumber}");
    }
}