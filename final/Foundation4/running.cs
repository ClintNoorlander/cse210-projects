
using System;
class Running : Activity
{
    public double distance; // distance in miles or km

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (length / 60.0); // speed in mph or kph
    }

    public override double GetPace()
    {
        return length / distance; // pace in minutes per mile or kilometer
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
                summary += $": Distance {distance:F1} km";
            }
            else
            {
                summary += $": Distance {distance:F1} miles";
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