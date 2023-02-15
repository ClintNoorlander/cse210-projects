using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment firstTest = new Assignment("Clinton Noorlander","Physics");
        Console.WriteLine(firstTest.GetSummary());

        MathAssignment mathTest = new MathAssignment("Clinton Noorlander", "Integration", "4.6", "9-20");
        Console.WriteLine(mathTest.GetSummary());
        Console.WriteLine(mathTest.GetHomeworkList());

        WritingAssignment writingTest = new WritingAssignment("Clinton Noorlander", "Art History", "The History of Art Things");
        Console.WriteLine(writingTest.GetSummary());
        Console.WriteLine(writingTest.GetWritingInformation());
    }
}