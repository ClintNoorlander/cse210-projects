using System;

public static class Program
{
    public static void Main()
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Create simple goal");
            Console.WriteLine("2. Create eternal goal");
            Console.WriteLine("3. Create checklist goal");
            Console.WriteLine("4. Record event");
            Console.WriteLine("5. Display goals");
            Console.WriteLine("6. Save goals");
            Console.WriteLine("7. Load goals");
            Console.WriteLine("8. Quit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string simpleName = Console.ReadLine();
                    Console.Write("Enter point value: ");
                    int simpleValue = int.Parse(Console.ReadLine());
                    manager.CreateSimpleGoal(simpleName, simpleValue);
                    Console.WriteLine($"Created simple goal '{simpleName}' worth {simpleValue} points.");
                    break;
                case "2":
                    Console.Write("Enter goal name: ");
                    string eternalName = Console.ReadLine();
                    Console.Write("Enter point value: ");
                    int eternalValue = int.Parse(Console.ReadLine());
                    manager.CreateEternalGoal(eternalName, eternalValue);
                    Console.WriteLine($"Created eternal goal '{eternalName}' worth {eternalValue} points.");
                    break;
                case "3":
                    Console.Write("Enter goal name: ");
                    string checklistName = Console.ReadLine();
                    Console.Write("Enter point value: ");
                    int checklistValue = int.Parse(Console.ReadLine());
                    Console.Write("Enter target count: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus value: ");
                    int bonusValue = int.Parse(Console.ReadLine());
                    manager.CreateChecklistGoal(checklistName, checklistValue, targetCount, bonusValue);
                    Console.WriteLine($"Created checklist goal '{checklistName}' worth {checklistValue} points, with a target count of {targetCount} and a bonus of {bonusValue} points.");
                    break;
                case "4":
                    Console.Write("Enter goal index: ");
                    int index = int.Parse(Console.ReadLine());
                    manager.RecordEvent(index);
                    Console.WriteLine($"Recorded event for goal '{manager.GetGoalName(index)}'.");
                    break;
                case "5":
                    manager.DisplayGoals();
                    break;
                case "6":
                    Console.Write("Enter file path: ");
                    string savePath = Console.ReadLine();
                    manager.SaveGoals(savePath);
                    Console.WriteLine($"Goals saved to '{savePath}'.");
                    break;
                case "7":
                    Console.Write("Enter file path: ");
                    string loadPath = Console.ReadLine();
                    manager.LoadGoals(loadPath);
                    Console.WriteLine($"Goals loaded from '{loadPath}'.");
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
