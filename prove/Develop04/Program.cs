using System;

class Program
{
    static void Main(string[] args)
    {
        // Activity activity = new Activity();
        // Menu menu = new Menu();
        // menu.DisplayMenu();
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // breathingActivity.DisplayStartMsg();
        // breathingActivity.SetDuration();
        // breathingActivity.DisplayEndMsg();
        // breathingActivity.ShowCountdown(5);
        breathingActivity.Excecute();
    }
}