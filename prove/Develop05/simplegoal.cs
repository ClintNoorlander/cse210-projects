using System;
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have completed the goal '{name}' and gained {value} points.");
    }
}
