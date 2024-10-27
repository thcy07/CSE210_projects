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
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Display Scriptures ");
            Console.WriteLine("2. Pick Scripture");
            Console.WriteLine("3. Load Scripture");
            Console.WriteLine("4. Memorize Scripture");
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
                    Scripture.MemorizeScripture();
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
 
 
