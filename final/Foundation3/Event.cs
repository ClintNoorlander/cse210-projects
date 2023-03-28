using System;
class Event
{
    private string name;
    private DateTime date;
    private Address location;

    public Event(string name, DateTime date, Address location)
    {
        this.name = name;
        this.date = date;
        this.location = location;
    }

    public string GetName()
    {
        return name;
    }

    public DateTime GetDate()
    {
        return date;
    }

    public string GetLocation()
    {
        return location.GetAddress();
    }

    public virtual string GetMarketingMessage()
    {
        return $"Don't miss the {name} event on {date.ToString("MM/dd/yyyy")} at {location.GetAddress()}!";
    }
}
