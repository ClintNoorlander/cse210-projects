using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a series of numbers, enter 0 when finished:");

        List<int> values = new List<int>();

        string done;

        do
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                done = "yes";
            }
            else
            {
                values.Add(number);
                done = "no";
            }
        }while (done == "no");

        int size = values.Count;
        int total = values.Sum();
        int avg = total / size;
        int max = values.Max();

        Console.WriteLine("");

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The maximum is: {max}");
        }
}