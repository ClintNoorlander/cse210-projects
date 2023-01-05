using System;

class Program
{
    static void Main(string[] args)
    {
        Random number = new Random();
        int magic_number = number.Next(1, 101);

        Console.WriteLine("I am thinking of a magic number between 1 and 100");

        string answer;

        do
        {
            Console.WriteLine("");
            Console.Write("What is your guess? ");
            string guess_string = Console.ReadLine();
            int guess = int.Parse(guess_string);

            if (guess == magic_number)
            {
                answer = "correct";
            }
            else
            {
                answer = "incorrect";
                if (guess < magic_number)
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

        Console.WriteLine($"Congratulations! you guessed that the magic number was {magic_number}");
    }
}