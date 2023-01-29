using System;

class Program
{
    static void Main(string[] args)
    {
        string done = "no";
        while (done == "no") 
        {
            //Console.WriteLine("Hello Develop02 World!");
            
            Console.WriteLine("Please Select an option using the number key:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                List<string> promptList = new List<string> 
                { 
                    "What was your favorite thing you did today?", 
                    "What was the toughest thing you did today?",
                    "Who were you most grateful for today? Why?",
                    "What was the coolest animal you saw today? Where did you see it?",
                    "Did you have any good meals today? If so, what where they?",
                    "What event inspired you the most today?",
                    "What person inspired you the most today? How did they do this?"
                };

                RandomPromptGenerator generator = new RandomPromptGenerator(promptList);
                string randomString = generator.GetRandomPrompt();

                Console.WriteLine("");
                Console.WriteLine(randomString);
                string prompt = Console.ReadLine();

                Entry entry = new Entry(randomString, prompt);

                Journal.entryList.Add($"{entry}");

                done = "no";
            }
            else if (choice == 2)
            {    
                foreach (string line in Journal.fullEntryList)
                {
                    Console.WriteLine(line);
                }

                done = "no";
            }

            else if (choice == 3)
            {
                Journal.fullEntryList.Clear();
                string[] lines = System.IO.File.ReadAllLines("journal.txt");

                foreach (string line in lines)
                {
                    Journal.fullEntryList.Add(line);
                }

                done = "no";
            }

            else if (choice == 4)
            {
                File.AppendAllLines("journal.txt", Journal.entryList);
                
                done = "no";
            }

            else
            {
                done = "yes";

            }

        }
    }
}