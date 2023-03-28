class Concert : Event
{
    private string artist;

    public Concert(string name, DateTime date, Address location, string artist) : base(name, date, location)
    {
        this.artist = artist;
    }

    public string GetArtist()
    {
        return artist;
    }

    public override string GetMarketingMessage()
    {
        return $"Come see {artist} live in concert at the {GetName()} on {GetDate().ToString("MM/dd/yyyy")} at {GetLocation()}!";
    }
}

class Conference : Event
{
    private string topic;

    public Conference(string name, DateTime date, Address location, string topic) : base(name, date, location)
    {
        this.topic = topic;
    }

    public string GetTopic()
    {
        return topic;
    }

    public override string GetMarketingMessage()
    {
        return $"Join us at the {GetName()} on {GetDate().ToString("MM/dd/yyyy")} in {GetLocation()} to learn more about {topic}!";
    }
}
