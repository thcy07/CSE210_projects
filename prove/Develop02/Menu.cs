using System;
 
class Menu
{
    private Journal _journal;
 
    public Menu(Journal journal)
    {
        this._journal = journal;
    }
 
    public void DisplayMenu()
    {
        while(true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
 
            string choice = Console.ReadLine();
 
            switch(choice)
            {
                case "1":
                    _journal.CreateNewJournalEntry();
                    break;
                case "2":
                    _journal.DisplayJournalEntries();
                    break;
                case "3":
                    _journal.SaveLoadJournal(true);
                    break;
                case "4":
                    _journal.SaveLoadJournal(false);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
 
 
