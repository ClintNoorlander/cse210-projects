using System;// Base Activity class with shared attributes and behaviors
public abstract class Activity
{
    protected int duration;
    
    public Activity()
    {
        duration = 0;
    }
    
    public void Start()
    {
        Console.WriteLine($"Starting {GetType().Name} activity...");
        Console.WriteLine(GetDescription());
        SetDuration();
        Console.WriteLine($"Get ready to begin in 3 seconds...");
        AnimateCountdown(3);
        PerformActivity();
        Console.WriteLine($"Great job! You completed the {GetType().Name} activity for {duration} seconds.");
        Console.WriteLine();
    }
    
    protected virtual string GetDescription()
    {
        return "No description provided for this activity.";
    }
    
    private void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }
    
    protected abstract void PerformActivity();
    
    protected void AnimateCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void AnimateSpinner(int seconds)
    {
        string[] spinners = new string[] { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        for (int i = seconds; i > 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($" {spinners[spinnerIndex]} ");
            spinnerIndex = (spinnerIndex + 1) % spinners.Length;
            Thread.Sleep(500);
        }
        
        Console.WriteLine();
    }
}
