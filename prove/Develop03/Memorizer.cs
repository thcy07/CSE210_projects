using System.Security.Cryptography.X509Certificates;
using System.IO;


public class Memorizer
{
    private List<Word> words = new List<Word>();
    private Random random = new Random();
    private static Dictionary<string, string> scriptureLibrary = new Dictionary<string, string>();
    private string scriptureFile = "scriptures.txt";
    private readonly StoreScrpiture sendscripture;
    private string currentReference;


      public Memorizer(StoreScrpiture memorizer) 
    {
        this.sendscripture = memorizer; 
    }

    public void ReadFile()
    {
        if (scriptureLibrary.Count > 0) // Avoid reloading if already populated
        {
            return;
        }

        if (!File.Exists(scriptureFile))
        {
            Console.WriteLine("No scriptures file found.");
            return;
        }

        using (StreamReader reader = new StreamReader(scriptureFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2) // Ensure proper format
                {
                    string reference = parts[0].Trim();
                    string scripture = parts[1].Trim();

                    if (!scriptureLibrary.ContainsKey(reference)) // Avoid duplicates
                    {
                        scriptureLibrary.Add(reference, scripture);
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid entry in scripture file: {line}");
                }
            }
        }
    }


       public void PickScriptures()
    {   
        ReadFile();
        Console.WriteLine("Please enter the reference of the verse you wish to memorize:");
        string reference = Console.ReadLine();
        if (scriptureLibrary.ContainsKey(reference))
        {
            currentReference = reference;
            words.Clear(); 
            string scripture1 = scriptureLibrary[reference];
            string[] wordsArray = scripture1.Split(' ');
            // Console.WriteLine(wordsArray.Length);

            foreach (string word in wordsArray)
            {
                words.Add(new Word(word));
            }
            MemorizeScripture();
        }
        else
        {
            Console.WriteLine("Reference not found. Please enter the scripture:");
            string scripture1 = Console.ReadLine();
            sendscripture.WriteScriptureToFile(reference, scripture1);
        }
        
    }
    private string GetRandomScriptureReference()
    {
        List<string> keys = new List<string>(scriptureLibrary.Keys);
        int randomIndex = random.Next(keys.Count);
        return keys[randomIndex];
    }

    public void LoadRandomScripture()
    {
        ReadFile();
        if (scriptureLibrary.Count == 0)
        {
            Console.WriteLine("No scriptures available in the library.");
            return;
        }

        string randomReference = GetRandomScriptureReference();
        currentReference = randomReference;

        if (scriptureLibrary.ContainsKey(randomReference))
        {
            words.Clear(); 
            string scripture1 = scriptureLibrary[randomReference];
            string[] wordsArray = scripture1.Split(' ');
            // Console.WriteLine(wordsArray.Length);

            foreach (string word in wordsArray)
            {
                words.Add(new Word(word));
            }

            MemorizeScripture();
        }       
        
    }

    public void MemorizeScripture()
    {
        while (!CompletelyHidden())
        {
            HideWords();
            Console.Clear();
            Console.WriteLine($"Memorizing Scripture: {currentReference}");
            DisplayWordList();
            Console.WriteLine("Press Enter to hide more words, or any other key to stop memorizing.");
            if (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                break;
            }
        }
    }
    public void DisplayWordList()
    {        
        foreach (Word word in words)
        {
           Console.Write(word.GetText());
           Console.Write(" "); 
        }
        Console.WriteLine();
    }

    public bool CompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }

        return true;
    }

    public void HideWords()
    {
        int count = 0;
        while (count < 3)
        {
            // Get a random word
            int randomIndex = random.Next(words.Count);
            Word randomWord = words[randomIndex];

            // Check if the word is already hidden
            if (!randomWord.GetIsHidden())
            {
                randomWord.HideWord();
                count++;
            }

            // Break if all words are hidden
            if (CompletelyHidden())
            {
                break;
            }
        }
    }


}