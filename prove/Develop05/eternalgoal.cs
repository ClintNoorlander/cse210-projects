public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    public override string GetGoalType()
    {
        return "Eternal";
    }
}

public class ChecklistGoal : Goal
{
    private int _numTimesCompleted;
    private int _requiredTimes;

    public ChecklistGoal(string name, int points, int requiredTimes) : base(name, points)
    {
        _numTimesCompleted = 0;
        _requiredTimes = requiredTimes;
    }

    public override void MarkCompleted()
    {
        _numTimesCompleted++;

        if (_numTimesCompleted >= _requiredTimes)
        {
            _completed = true;
            _points += 500;
        }
        else
        {
            _points += 50;
        }
    }

    public override string GetGoalType()
    {
        return "Checklist";
    }

    public string GetCompletionStatus()
    {
        return "Completed " + _numTimesCompleted.ToString() + "/" + _requiredTimes.ToString() + " times";
    }
}
