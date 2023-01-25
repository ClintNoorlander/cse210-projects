using System;

public class Prompt
{
    public static void main()
    {
        string[] prompts = 
        {
        "What was the coolest animal you saw today?", 
        "Who did you serve today?", 
        "How where you blessed today?",
        "What were you grateful for today?",
        "What music genre did you listen to most today?",
        "How were your assignments today?"
        };

    Random rand = new Random(); 
    int index = rand.Next(prompts.Length);
    Console.WriteLine($"{prompts[index]}"); 
    }


}