using System;

class Swimming : Activity
{
    public int laps; // number of laps

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0; // distance in km
    }

    public override double GetSpeed()
    {
        return GetDistance() / (base.length / 60.0); // speed in kph
    }

    public override double GetPace()
    {
        return length / GetDistance(); // pace in minutes per km
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string summary = base.GetSummary();
        summary += $", Distance: {distance:F1} km, Speed: {speed:F1} kph, Pace: {pace:F1} min/km";

        return summary;
    }
}
