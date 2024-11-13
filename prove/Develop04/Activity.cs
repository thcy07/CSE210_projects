using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    public void DisplayStartMsg()
    {
       Console.WriteLine($"Welcome to the {_name} Activity!\n {_description}");
    }

    public int SetDuration()
    {
        Console.WriteLine("How long do you want you duration?");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        return _duration;

    }

    public void ShowCountdown(int length)
    {
        for (int i = length; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

    public void Spinner(int time)
    {
        for (int i = 0; i < time; i++)
        {            
            Console.Write(">");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("-"); 
        }
    }
    public void DisplayEndMsg()
    {
       Console.WriteLine($"You just completed {_duration} seconds of {_name} Activity!");

    }
}
        