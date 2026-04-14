using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create at least one activity of each type
        Running run = new Running("03 Nov 2022", 30, 3.0);
        StationaryBicycle bike = new StationaryBicycle("04 Nov 2022", 45, 15.5);
        Swimming swim = new Swimming("05 Nov 2022", 20, 20);

        // Put activities in a list
        List<Activity> activities = new List<Activity>();
        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        // Iterate and display summaries
        Console.WriteLine("Exercise Tracking Summary:");
        Console.WriteLine("--------------------------");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}