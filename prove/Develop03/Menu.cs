using System;
 
class Menu
{
    private Memorizer Scripture;
    private StoreScrpiture scriptureStore;

   public Menu(Memorizer scripture, StoreScrpiture scriptureStore)
    {
        this.Scripture = scripture;
        this.scriptureStore = scriptureStore;
    }
    public void DisplayMenu()
    {
        while(true)
        {
            Console.WriteLine("\n Please select one of the following choices: ");
            Console.WriteLine("1. Display All the Scriptures ");
            Console.WriteLine("2. Pick Scripture to Memorize");
            Console.WriteLine("3. Load Scripture to File");
            Console.WriteLine("4. Memorize Random Scripture");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
 
            string choice = Console.ReadLine();
 
            switch(choice)
            {
                case "1":
                    scriptureStore.DisplayScriptures();
                    break;
                case "2":
                    Scripture.PickScriptures();
                    break;
                case "3": 
                    string reference = scriptureStore.GetReference();
                    string scripture = scriptureStore.GetScripture();
                    scriptureStore. WriteScriptureToFile(reference, scripture); 
                    break;
                case "4":
                    Scripture.LoadRandomScripture();
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
 
 
