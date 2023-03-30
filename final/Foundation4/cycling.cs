using System;

class Cycling : Activity
{
    public double _speed;

    public Cycling(DateTime date, int length, double speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return base.length * _speed / 60.0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        string activityType = this.GetType().Name;
        string summary = $"{date.ToShortDateString()} {activityType} ({length} min)";

        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        if (distance > 0)
        {
            if (IsMetric())
            {
                summary += $": Distance {distance:F2} km";
            }
            else
            {
                summary += $": Distance {distance:F2} miles";
            }
        }

        if (speed > 0)
        {
            if (IsMetric())
            {
                summary += $", Speed {speed:F1} kph";
            }
            else
            {
                summary += $", Speed {speed:F1} mph";
            }
        }

        if (pace > 0)
        {
            if (IsMetric())
            {
                summary += $", Pace: {pace:F1} min/km";
            }
            else
            {
                summary += $", Pace: {pace:F1} min/mile";
            }
        }

        return summary;
    }
}