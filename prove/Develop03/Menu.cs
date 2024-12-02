using System;
 
class Menu
{
    private Memorizer _scripture;
    private StoreScrpiture _scriptureStore;

   public Menu(Memorizer scripture, StoreScrpiture _scriptureStore)
    {
        this._scripture = scripture;
        this._scriptureStore = _scriptureStore;
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
                    _scriptureStore.DisplayScriptures();
                    break;
                case "2":
                    _scripture.PickScriptures();
                    break;
                case "3": 
                    string reference = _scriptureStore.GetReference();
                    string scripture = _scriptureStore.GetScripture();
                    _scriptureStore. WriteScriptureToFile(reference, scripture); 
                    break;
                case "4":
                    _scripture.LoadRandomScripture();
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
 
 
