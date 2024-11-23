

public class GoalHandler:Goal 
{
    private List<Goal> goals = new();
    public int _totalPoints = 0;
    string defaultFileName = "Goals.txt";

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayGoals()
    {
        //loop through and display goals
        int index = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in goals)
        {
            if (goal.IsCompleted() == false)
            {               
                Console.WriteLine($"{index}. [ ] {goal.DisplayGoalList()}");
            }
            else if (goal.GetType().Name == "EternalGoal")
            {
                Console.WriteLine($"{index}. [ ] {goal.DisplayGoalList()}");
            }
            else if (goal.GetType().Name == "EternalGoal")
            {
                Console.WriteLine($"{index}. [ ] {goal.DisplayGoalList()}");
            }
            else
            {
                Console.WriteLine($"{index}. [X] {goal.DisplayGoalList()}");

            }
            index += 1;            
        }
    }

    public void SaveGoals()
    {
        //loop and save to file
        Console.WriteLine("Press Enter to save to default file or press any other key to enter the file name:");
        if (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            string fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(_totalPoints);

                foreach (Goal goal in goals)
                {  
                    outputFile.WriteLine(goal.ToString());
                }

            }

            Console.WriteLine($"Goals saved successfully to {fileName}");
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(defaultFileName))
            {
                outputFile.WriteLine(_totalPoints);
                foreach (Goal goal in goals)
                {  
                    outputFile.WriteLine(goal.ToString());
                }
            }
            
            Console.WriteLine($"Goals saved successfully to {defaultFileName}");

        }
    }
    public void LoadGoals()
    {
        //loop and read from file
        // and put to Goals list
        Console.WriteLine("Press Enter to load from a default file or press any other key to enter the file name:");
        if (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            string fileName = Console.ReadLine();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    if (parts[0] == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        goals.Add(simpleGoal);
                    }
                    if (parts[0] == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
                        goals.Add(eternalGoal);
                    }
                    if (parts[0] == "CheckListGoal")
                    {
                        CheckListGoal checkListGoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
                        goals.Add(checkListGoal);
                    }
                    else
                    {
                        _totalPoints = int.Parse(parts[0]);
                    }

                }
            }
        }

        else
        {
            using (StreamReader reader = new StreamReader(defaultFileName))
            {
                string firstLine = reader.ReadLine()?.Trim(); 
                if (!int.TryParse(firstLine, out _totalPoints))
                {
                    Console.WriteLine("Error: Invalid total points in the file. Defaulting to 0.");
                    _totalPoints = 0;
                }

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim(); 
                    if (string.IsNullOrWhiteSpace(line)) continue; 

                    string[] parts = line.Split('|');

                    if (parts[0] == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        goals.Add(simpleGoal);
                    }
                    if (parts[0] == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
                        goals.Add(eternalGoal);
                    }
                    if (parts[0] == "CheckListGoal")
                    {
                        CheckListGoal checkListGoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
                        goals.Add(checkListGoal);
                    }
                    

                }
            }
 
        }

    }
    public void RecordGoals()
    {
        //pick a goal and call record event
        int index = 1;

        if (goals.Count()> 0)
        {
            
            foreach (Goal goal in goals)
            {
                if (goal.IsCompleted() == false)
                {               
                    Console.WriteLine($"{index}. {goal.GetName()}");
                }
                index += 1;    
            }

            Console.WriteLine("Which goal would you like to record?");
            int choice  = int.Parse(Console.ReadLine());
            Goal recordingGoal = goals[choice - 1];

            int pointsGained = recordingGoal.RecordEvent();
            Console.WriteLine($"\nCongratulations you have earned {pointsGained} points!");

            _totalPoints += pointsGained;

            Console.WriteLine();
            DisplayGoals();
        }

        else
        {
            Console.WriteLine("No Goals to record.");
        }
    }
}