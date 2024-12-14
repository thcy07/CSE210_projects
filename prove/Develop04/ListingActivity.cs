
public class ListingActivity:Activity
{
    private List<string> _prompts = new()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes"
        };

    public ListingActivity(string name, string description): base(name, description)
    {

    }

    public void Execute()
    {
        DisplayStartMsg();
        int duration = SetDuration();
        Console.Write("Get Ready\n");
        Spinner(7);
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);

        Random random = new Random();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        List<string> entries = new List<string>();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Press any other key to exit when done.");
        Console.WriteLine($"Prompt:\n{randomPrompt}\n");

        while (startTime < endTime)
        {          
            entries.Add(Console.ReadLine());
            startTime = DateTime.Now;
        }

        int numEntries = entries.Count;
        Console.WriteLine($"You listed {numEntries} items");
        DisplayEndMsg();
    }

}