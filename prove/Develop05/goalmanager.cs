using System;
using System.Collections.Generic;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();

    public void AddSimpleGoal(string name, int points)
    {
        Goal goal = new SimpleGoal(name, points);
        goals.Add(goal);
    }

    public void AddEternalGoal(string name, int points)
    {
        Goal goal = new EternalGoal(name, points);
        goals.Add(goal);
    }

    public void AddChecklistGoal(string name, int pointsPerCompletion, int requiredCompletions, int bonusPoints)
    {
        Goal goal = new ChecklistGoal(name, pointsPerCompletion, requiredCompletions, bonusPoints);
        goals.Add(goal);
    }

    public void RecordEvent(string name)
    {
        foreach (Goal goal in goals)
        {
            if (goal.Name == name)
            {
                goal.RecordEvent();
            }
        }
    }

    public void PrintGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.Write("[");
            if (goal.Completed)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write(" ");
            }
            Console.Write("] ");
            Console.Write(goal.Name);

            if (goal is ChecklistGoal)
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                Console.Write(" (Completed {0}/{1} times)", checklistGoal.Completions, checklistGoal.RequiredCompletions);
            }

            Console.WriteLine();
        }
    }

    public void PrintScore()
    {
        int score = 0;
        foreach (Goal goal in goals)
        {
            score += goal.Score;
        }
        Console.WriteLine("Score: {0}", score);
    }

    public void SaveGoals()
    {
        // TODO: Implement save functionality
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        // TODO: Implement load functionality
        Console.WriteLine("Goals loaded.");
    }
}
