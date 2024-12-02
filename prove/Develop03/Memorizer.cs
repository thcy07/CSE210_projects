using System.Security.Cryptography.X509Certificates;
using System.IO;


public class Memorizer
{
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();
    private static Dictionary<string, string> _scriptureLibrary = new Dictionary<string, string>();
    private string _scriptureFile = "scriptures.txt";
    private readonly StoreScrpiture _sendScripture;
    private string _currentReference;


      public Memorizer(StoreScrpiture memorizer) 
    {
        this._sendScripture = memorizer; 
    }

    public void ReadFile()
    {
        if (_scriptureLibrary.Count > 0) // Avoid reloading if already populated
        {
            return;
        }

        if (!File.Exists(_scriptureFile))
        {
            Console.WriteLine("No scriptures file found.");
            return;
        }

        using (StreamReader reader = new StreamReader(_scriptureFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2) // Ensure proper format
                {
                    string reference = parts[0].Trim();
                    string scripture = parts[1].Trim();

                    if (!_scriptureLibrary.ContainsKey(reference)) // Avoid duplicates
                    {
                        _scriptureLibrary.Add(reference, scripture);
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
        if (_scriptureLibrary.ContainsKey(reference))
        {
            _currentReference = reference;
            _words.Clear(); 
            string scripture1 = _scriptureLibrary[reference];
            string[] wordsArray = scripture1.Split(' ');
            // Console.WriteLine(wordsArray.Length);

            foreach (string word in wordsArray)
            {
                _words.Add(new Word(word));
            }
            MemorizeScripture();
        }
        else
        {
            Console.WriteLine("Reference not found. Please enter the scripture:");
            string scripture1 = Console.ReadLine();
            _sendScripture.WriteScriptureToFile(reference, scripture1);
        }
        
    }
    private string GetRandomScriptureReference()
    {
        List<string> keys = new List<string>(_scriptureLibrary.Keys);
        int randomIndex = _random.Next(keys.Count);
        return keys[randomIndex];
    }

    public void LoadRandomScripture()
    {
        ReadFile();
        if (_scriptureLibrary.Count == 0)
        {
            Console.WriteLine("No scriptures available in the library.");
            return;
        }

        string randomReference = GetRandomScriptureReference();
        _currentReference = randomReference;

        if (_scriptureLibrary.ContainsKey(randomReference))
        {
            _words.Clear(); 
            string scripture1 = _scriptureLibrary[randomReference];
            string[] wordsArray = scripture1.Split(' ');
            // Console.WriteLine(wordsArray.Length);

            foreach (string word in wordsArray)
            {
                _words.Add(new Word(word));
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
            Console.WriteLine($"Memorizing Scripture: {_currentReference}");
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
        foreach (Word word in _words)
        {
           Console.Write(word.GetText());
           Console.Write(" "); 
        }
        Console.WriteLine();
    }

    public bool CompletelyHidden()
    {
        foreach (Word word in _words)
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
            int randomIndex = _random.Next(_words.Count);
            Word randomWord = _words[randomIndex];

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