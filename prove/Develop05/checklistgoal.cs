using System;
public class ChecklistGoal : Goal
{
    public int count;
    public int targetCount;
    public int bonusValue;

    public ChecklistGoal(string name, int value, int targetCount, int bonusValue) : base(name, value)
    {
        this.targetCount = targetCount;
        this.bonusValue = bonusValue;
        count = 0;
    }

    public override void RecordEvent()
    {
        count++;
        Console.WriteLine($"Congratulations! You have completed the checklist goal '{name}' for the {count}th time and gained {value} points.");
        if (count == targetCount)
        {
            value += bonusValue;
            Console.WriteLine($"You have reached the target count of {targetCount} and gained an additional {bonusValue} bonus points!");
        }
    }

    public override string ToString()
    {
        return $"{name} ({value} points, Completed {count}/{targetCount} times)";
    }
}
