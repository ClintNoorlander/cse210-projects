using System;
public class EternalGoal : Goal
{
    private int count;

    public EternalGoal(string name, int value) : base(name, value)
    {
        count = 0;
    }

    public override void RecordEvent()
    {
        count++;
        Console.WriteLine($"Congratulations! You have completed the eternal goal '{name}' for the {count}th time and gained {value} points.");
    }
}
