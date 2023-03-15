using System;
public abstract class Goal
{
    public int Id { get; set; }

    public string name;
    public int value;

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
    }

    public abstract void RecordEvent();

    public override string ToString()
    {
        return $"{name} ({value} points)";
    }
}
