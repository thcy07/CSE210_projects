using System;
 
public class Menu
{
    public void DisplayMenu()
    {
        string choice = "";

        while(choice != "4")
        {
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");
 
            choice = Console.ReadLine();
 
            switch(choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    Console.Clear();
                    breathingActivity.Execute();
                    Console.Clear();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    Console.Clear();
                    reflectingActivity.Execute();
                    Console.Clear();
                    break;
                case "3": 
                    ListingActivity listingActivity = new ListingActivity("Listening", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    Console.Clear();
                    listingActivity.Execute();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
    }

}