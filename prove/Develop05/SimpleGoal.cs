

public class SimpleGoal:Goal
{
    public SimpleGoal()
    {
        
    }
    public SimpleGoal(string name , string description , int points, bool completed ):base( name, description, points, completed)
    {
        
    }

    public override string ToString()
    {
        string entry = $"{GetType().Name}|{_name}|{_description}|{_points}|{_completed}";

        return entry;
    }

    public override int RecordEvent()
    {
       if (!_completed)
        {
           _completed = true;
            return _points;
        }

       else
        {
            return 0;
        }
    }

}