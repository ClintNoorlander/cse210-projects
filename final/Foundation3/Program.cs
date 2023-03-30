using System;

class Program
{
    static void Main()
    {
        Address location = new Address("123 Main St", "Anytown", "CA", "12345");
        Event genericEvent = new Event("Generic Event", DateTime.Now.AddDays(30), location);
        Concert concert = new Concert("Summer Fest", DateTime.Now.AddDays(60), location, "The Headliners");
        Conference conference = new Conference("Tech Summit", DateTime.Now.AddDays(90), location, "Artificial Intelligence");

        Console.WriteLine(genericEvent.GetMarketingMessage());
        Console.WriteLine(concert.GetMarketingMessage());
        Console.WriteLine(conference.GetMarketingMessage());
    }
}