using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int value = int.Parse(grade);

        string letter = "";
        string message = "";

        if (value >= 90)
        {
            letter = "an A";
            message = "Congratulations! You did it!";
        }
        else if (value >= 80)
        {
            letter = "a B";
            message = "Congratulations! You did it!";
        }
        else if (value >= 70)
        {
            letter = "a C";
            message = "Congratulations! You did it!";
        }
        else if (value >= 60)
        {
            letter = "a D";
            message = "Close one! You'll get em next time champ.";
        }
        else
        {
            letter = "an F";
            message = "Close one! You'll get em next time champ.";
        }

        Console.WriteLine($"Your grade is {letter}");
        Console.WriteLine($"{message}");

    }
}