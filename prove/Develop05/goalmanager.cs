using System;

public class GoalManager
{
    public List<Goal> goals;
    public int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void CreateSimpleGoal(string name, int value)
    {
        goals.Add(new SimpleGoal(name, value));
    }

    public void CreateEternalGoal(string name, int value)
    {
        goals.Add(new EternalGoal(name, value));
    }

    public void CreateChecklistGoal(string name, int value, int targetCount, int bonusValue)
    {
        goals.Add(new ChecklistGoal(name, value, targetCount, bonusValue));
    }

    

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }
        goals[index].RecordEvent();
        score += goals[index].value;
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"[{(goals[i] is ChecklistGoal && ((ChecklistGoal)goals[i]).count == ((ChecklistGoal)goals[i]).targetCount ? "X" : " ")}] ");
            Console.WriteLine(goals[i]);
        }

        Console.WriteLine($"Score: {score}");
    }
    public string GetGoalName(int id)
    {
        foreach (Goal goal in goals)
        {
            if (goal.Id == id)
            {
                return goal.Name;
            }
        }
        
        return null;
    }

    public void SaveGoals(List<Goal> goals)
    {

    }

    public void LoadGoals()
    {
        
    }

}


