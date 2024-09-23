using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter you frist name:");
        string first_name = Console.ReadLine();

        Console.Write("Enter you last name:");
        string last_name = Console.ReadLine();

        Console.WriteLine();        
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

    }
}