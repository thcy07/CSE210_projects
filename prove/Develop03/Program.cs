using System;

class Program
{
    static void Main(string[] args)
    {
        StoreScrpiture scriptureStore = new StoreScrpiture();
        Memorizer scriptureMemorizer = new Memorizer(scriptureStore);
        Menu menu = new Menu(scriptureMemorizer, scriptureStore);
        menu.DisplayMenu();
    }
}