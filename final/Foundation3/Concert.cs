using System;
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
