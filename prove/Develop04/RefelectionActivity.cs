using System.Security.Cryptography.X509Certificates;
using System.IO;

public class ReflectingActivity : Activity
{
      private List<string> _prompts = new()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless",
        };

    public ReflectingActivity(string name, string description): base(name, description)
    {

    }

     public void Excecute()
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