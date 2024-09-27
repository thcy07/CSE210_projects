using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }
    static double PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        string input = Console.ReadLine();
        double number = double.Parse(input);
        return number;
    }
    static double SquareNumber( double num)
    {
        double squareNum = num*num;
        return squareNum;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        double userNumb = PromptUserNumber();
        double squareNum = SquareNumber(userNumb);
        Console.WriteLine($"{userName}, the square of you number is {squareNum}.");
 

    }
}