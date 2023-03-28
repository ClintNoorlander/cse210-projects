using System;
using System.Collections.Generic;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            Running runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3.0);
            Cycling cyclingActivity = new Cycling(new DateTime(2022, 11, 3), 30, 20);
            Swimming swimmingActivity = new Swimming(new DateTime(2022, 11, 3), 30, 30);

            activities.Add(runningActivity);
            activities.Add(cyclingActivity);
            activities.Add(swimmingActivity);

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            Console.ReadKey();
        }
    }
}

