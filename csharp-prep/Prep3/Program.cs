using System;

class Program
{
    static void Main(string[] args)
    {
       
       
       string guess, response = "";
       int guessNumber = 0, number;
       int attempts;
       do
       {        
        Random randomGenerator = new Random(); 
        number = randomGenerator.Next(1,101);
        attempts = 0;
            while (guessNumber != number)
            {   
                attempts++;
                Console.WriteLine(number);
                Console.Write("What is the magic number:");
                guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                if (guessNumber > number)
                { Console.WriteLine("Lower");}
                else if (guessNumber < number)
                { Console.WriteLine("Higher"); }
                else
                { Console.WriteLine($"You Guessed it! In {attempts} attempts!"); 
                Console.Write("Do you want to continue? ");
                response = Console.ReadLine();
                }
            }   
       
       } while (response == "Yes" || response == "yes");
    }
}