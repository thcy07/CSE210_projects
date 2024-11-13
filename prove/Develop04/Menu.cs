using System;
 
public class Menu
{
    public void DisplayMenu()
    {
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Refecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.Write("What would you like to do? ");
 
            string choice = Console.ReadLine();
            // string activityName = "";
 
            switch(choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                    break;
                case "3": 
                    // activityName = "Listing";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
    }

