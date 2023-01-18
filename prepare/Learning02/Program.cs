using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Salt Lamp Licker";
        job1._company = "Salt Lamp & Co.";
        job1._startYear = 2015;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "Fiddler";
        job2._company = "The Roof";
        job2._startYear = 1971;
        job2._endYear = 2023; 

        Resume myResume = new Resume();
        myResume._name = "Clinton Noorlander";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}