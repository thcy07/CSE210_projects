

public class EternalGoal:Goal
{
    private int _bonusPoints;
    private int  _totalReps;
    private int _repsCompleted;

    public EternalGoal()
    {
        
    }
    public EternalGoal(string name , string description , int points, int repsCompleted, int totalReps, int bonusPoints, bool completed ):base( name, description, points, completed)
    {
        _repsCompleted = repsCompleted;
        _totalReps = totalReps;
        _bonusPoints = bonusPoints;
    }

    public override void CreateGoal()
    {
        base.CreateGoal();

        Console.WriteLine("How many completions are required to unlock the bonus for this goal?");
         _totalReps = int.Parse(Console.ReadLine());
        Console.WriteLine("How nuch bonus points do you want to assign for this goal?");
        _bonusPoints = int.Parse(Console.ReadLine());

    }

    public override string ToString()
    {
        string entry = $"{GetType().Name}|{_name}|{_description}|{_points}|{_repsCompleted}|{ _totalReps}|{_bonusPoints}|{_completed}";

        return entry;
    }

    public override string DisplayGoalList()
    {
        return $"{base.DisplayGoalList()} -- Currently Completed: {_repsCompleted}/{ _totalReps}";
    }

    public override int RecordEvent()
    {
        if (_repsCompleted < _totalReps)
        {
            _repsCompleted ++;

            if (_repsCompleted == _totalReps)
            {
                return _points + _bonusPoints;
                
            }

        }
        
        return _points;

     }

}