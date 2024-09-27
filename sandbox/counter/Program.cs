// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Bye, World!");

// for(int i = 0; i <= 10; i++)
// { 
//     Console.WriteLine(i);
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new();

        int input = -1;
        while (input != 0)
        {
           Console.WriteLine("Enter a Number [enter a 0 to stop]:");
           string inputString = Console.ReadLine();
           input = int.Parse(inputString);
           if (input != 0)
           {
            numberList.Add(input);
           }
           
        }
        foreach (int item in numberList)
        {
           Console.WriteLine(item);
        }
        
    }
}