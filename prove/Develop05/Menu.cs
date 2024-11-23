using System;
 
public class Menu
{
    private GoalHandler _goalHandler = new GoalHandler();
    public void DisplayMenu()
    {
        string choice = "";

        while(choice != "6")
        {
            Console.WriteLine($"\nYou have {_goalHandler._totalPoints} point!\n");
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine("1. Creat New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do?  ");
 
            choice = Console.ReadLine();
 
            switch(choice)
            {
                case "1":
                    GoalMenu();             
                    break;
                case "2":
                    _goalHandler.DisplayGoals();
                    break;
                case "3": 
                    _goalHandler.SaveGoals();
                    break;
                case "4": 
                    _goalHandler.LoadGoals();
                    break;
                case "5": 
                    _goalHandler.RecordGoals();
                    break;
                case "6": 
                    break;
                default:
            
                Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
    }

        public void GoalMenu()
    {
        Console.WriteLine("Please pick one kind of goal to create: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("What type of goal would you like to create?  ");


        string choice = Console.ReadLine();
 
            switch(choice)
            {
                case "1":
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.CreateGoal();
                    _goalHandler.AddGoal(simpleGoal);

                    break;
                case "2":
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateGoal();
                    _goalHandler.AddGoal(eternalGoal);

                    break;
                case "3": 
                    CheckListGoal checkListGoal = new CheckListGoal();
                    checkListGoal.CreateGoal();
                    _goalHandler.AddGoal(checkListGoal);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
    }
    }

