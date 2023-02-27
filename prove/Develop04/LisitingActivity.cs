
using System;
public class ListingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    protected override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    
    protected override void PerformActivity()
    {
        Random random = new Random();
        int promptIndex = random.Next(prompts.Length);

        Console.WriteLine($"Prompt: {prompts[promptIndex]}");

        AnimateSpinner(11);

        Console.WriteLine($"Write as many responses as you can in {duration} seconds");
        Console.WriteLine("");

        Console.WriteLine("Begin listing items:");
        Console.WriteLine("");

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            items.Add(input);
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}
