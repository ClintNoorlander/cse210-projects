using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("Enter option number:");
            Console.WriteLine("1. Add goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Save goals to file");
            Console.WriteLine("5. Load goals from file");
            Console.WriteLine("6. Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddGoal(goalManager);
                    break;
                case 2:
                    RecordEvent(goalManager);
                    break;
                case 3:
                    DisplayGoals(goalManager);
                    break;
                case 4:
                    SaveGoalsToFile(goalManager);
                    break;
                case 5:
                    LoadGoalsFromFile(goalManager);
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void AddGoal(GoalManager goalManager)
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal type (Simple, Eternal, or Checklist):");
        string type = Console.ReadLine();

        Console.WriteLine("Enter points earned:");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "Simple":
                goalManager.AddSimpleGoal(name, points);
                break;
            case "Eternal":
                goalManager.AddEternalGoal(name, points);
                break;
            case "Checklist":
                Console.WriteLine("Enter number of times to complete:");
                int completionCount = int.Parse(Console.ReadLine());
                goalManager.AddChecklistGoal(name, points, completionCount);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal added.");
    }

    private static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        goalManager.RecordEvent(name);

        Console.WriteLine("Event recorded.");
    }

    private static void DisplayGoals(GoalManager goalManager)
    {
        goalManager.DisplayGoals();
        Console.WriteLine("Total points: " + goalManager.GetTotalPoints().ToString());
    }

    private static void SaveGoalsToFile(GoalManager goalManager)
    {
        FileStream fileStream = new FileStream("goals.dat", FileMode.Create);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, goalManager);
        fileStream.Close();

        Console.WriteLine("Goals saved to file.");
    }

    private static void LoadGoalsFromFile(GoalManager goalManager)
    {
        if (File.Exists("goals.dat"))
        {
            FileStream fileStream = new FileStream("goals.dat", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            goalManager = (GoalManager)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();

            Console.WriteLine("Goals loaded from file.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
