using System.Security.Cryptography.X509Certificates;
using System.IO;

public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description): base(name, description)
    {

    }

    public void Execute()
    {
       DisplayStartMsg();
       int duration = SetDuration();
       Console.Write("Get Ready");
       Spinner(7);

       
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (startTime < endTime)
        {
            Console.WriteLine("\n");
            Console.Write("Breath in...");
            ShowCountdown(4);
            Console.Write("\n");
            Console.Write("Breath out...");
            ShowCountdown(6);
            Console.WriteLine("\n");
            startTime = DateTime.Now;
            

        }
        DisplayEndMsg();
    }
}