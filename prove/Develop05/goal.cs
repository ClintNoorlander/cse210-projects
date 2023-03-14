public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _completed;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _completed = false;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool IsCompleted()
    {
        return _completed;
    }

    public virtual void MarkCompleted()
    {
        _completed = true;
    }

    public abstract string GetGoalType();
}
