using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter you number grade (as a whole number):");
        int number_grade = Convert.ToInt32(Console.ReadLine());
        string letter_grade;

        if (number_grade >= 90)
        { letter_grade = "A";}
        else if (number_grade >= 80)
        { letter_grade = "B";}
        else if (number_grade >= 70)
        {letter_grade = "C";}
        else if (number_grade >= 60)
        { letter_grade = "D";}
        else 
        {letter_grade = "F";}

        Console.WriteLine($"Your Grade is {letter_grade}");

        if (number_grade >= 70)
        { Console.WriteLine("Congragulations! You have passed the Class!");}
    }
}