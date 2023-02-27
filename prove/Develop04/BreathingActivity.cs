using System;

public class BreathingActivity : Activity
{
    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    
    protected override void PerformActivity()
    {
        for (int i = 0; i < duration; i += 10)
        {
            Console.WriteLine("Breathe in...");
            AnimateCountdown(5);
            
            Console.WriteLine("Breathe out...");
            AnimateCountdown(5);
        }
    }
}