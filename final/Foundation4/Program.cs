using System;

class Program
{
    static void Main(string[] args)
    {
        // Running runningActivity = new Running(30, new DateTime(2022, 11, 3), 4.8f);
        // Console.WriteLine(runningActivity.GetSummary());

        // Swimming swimmingActivity = new Swimming(40, new DateTime(2022, 11, 3), 20);
        // Console.WriteLine(swimmingActivity.GetSummary());

        // Cycling cyclingActivity = new Cycling(30, new DateTime(2022, 11, 3), 25);
        // Console.WriteLine(cyclingActivity.GetSummary());

        List<Activity> activities = new List<Activity>
        {
            new Running(30, new DateTime(2022, 11, 3), 4.8f),
            new Swimming(40, new DateTime(2022, 11, 3), 20),
            new Cycling(30, new DateTime(2022, 11, 3), 25)
        };

        // Iterate through the list and print the summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}