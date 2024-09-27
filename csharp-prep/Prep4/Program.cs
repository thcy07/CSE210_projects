using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new();
        int input = -1;
        while (input != 0)
        {
           Console.Write("Enter a Number [enter a 0 to stop]:");
           string inputString = Console.ReadLine();
           input = int.Parse(inputString);
           if (input != 0)
           {
            numberList.Add(input);
           }
           
        }
        int sum = 0;
        foreach (int number in numberList)
        {
           sum += number;
        }
        int numElements = numberList.Count;
        float average = ((float)sum)/numElements;
        int largestNumber = numberList.Max();
        Console.WriteLine("The sum of the numbers is: " + sum);
        Console.WriteLine("The average of the numbers is: " + average);
        Console.WriteLine("The largest number is: " + largestNumber);

    }
}