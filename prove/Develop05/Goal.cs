

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public Goal()
    {
        
    }

    public Goal(string name , string description , int points, bool completed  )
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    } 

    public string GetName()
    {
        return _name;
    }

     public virtual void CreateGoal()
    {
        Console.WriteLine("What is the name of the you would like to create?");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of the goal?");
        _description = Console.ReadLine();
        Console.WriteLine("How many points would you like to award the goal?");
        _points= Convert.ToInt32(Console.ReadLine());
        _completed = false;

    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public bool IsCompleted()
    {
       return  _completed;
    }

  
      public virtual string DisplayGoalList()
    {
        
       return $"{_name}:{_description} ";
        
    }
    
}
