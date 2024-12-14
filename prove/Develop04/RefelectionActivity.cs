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
      private List<string> _questions = new()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    public ReflectingActivity(string name, string description): base(name, description)
    {

    }

    public void Execute()
    {
       DisplayStartMsg();
       int duration = SetDuration();
       Console.Write("Get Ready\n");
       Spinner(7);
    
        Random random = new Random();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (startTime < endTime)
        {
            string randomPrompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine($"Prompt:\n{randomPrompt}\n");

            Spinner(7);
            Thread.Sleep(3000);

            string randomQuestion = _questions[random.Next(_questions.Count)];
            Console.WriteLine($"Question:\n{randomQuestion}\n");

            Spinner(7);
            Thread.Sleep(3000);

            startTime = DateTime.Now;
        }
        DisplayEndMsg();
    }

    

}