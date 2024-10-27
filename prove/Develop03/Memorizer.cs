using System.Security.Cryptography.X509Certificates;
using System.IO;


public class Memorizer
{
    private List<Word> words = new List<Word>();
    private Random random = new Random();

    private string scriptureFile = "scriptures.txt";
    private readonly StoreScrpiture sendscripture;


      public Memorizer(StoreScrpiture memorizer) 
    {
        this.sendscripture = memorizer; 
    }

       public void PickScriptures()
    {
        Console.WriteLine("Please enter the reference of the verse you wish to memorize:");
        string reference = Console.ReadLine();

        using (StreamReader reader = new StreamReader(scriptureFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts[0] == reference)
                {
                    string scripture1 = parts[1];
                    LoadScripture(reference, scripture1);
                    return;
                }
            }

            Console.WriteLine("Reference not found. Please enter the scripture:");
            string scripture = Console.ReadLine();
            sendscripture.WriteScriptureToFile(reference, scripture);
            LoadScripture(reference, scripture);
        }

    }

    public void LoadScriptureFromFile()
    {
        using (StreamReader reader = new StreamReader(scriptureFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string reference = parts[0];
                string scripture = parts[1];
                LoadScripture(reference, scripture); 
            }
        }
    }

    public void LoadScripture(string reference, string scripture)
    {
        words.Clear(); 
        string[] wordsArray = scripture.Split("");

        foreach (string word in wordsArray)
        {
            words.Add(new Word(word));
        }
    }

    public void MemorizeScripture()
    {

        while (!CompletelyHidden())
        {
            HideWords();
            Console.WriteLine(GetHiddenText());
            Console.WriteLine("Press Enter to hide more words, or any other key to stop memorizing.");
            if (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                break;
            }
        }
    }
    public string GetHiddenText()
    {
        string hiddenText = "";
        foreach (Word word in words)
        {
            if (word.IsHidden)
            {
                hiddenText += "____ ";
            }
            else
            {
                hiddenText += word.Text + " ";
            }
        }
        return hiddenText;
    }

    public bool CompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }

        return true;
    }

    public void HideWords()
    {
        int numWordsToHide = random.Next(1, words.Count / 2);

        for (int i = 0; i < numWordsToHide; i++)
        {
            int randomIndex = random.Next(words.Count);
            words[randomIndex].Hidden();
        }
    }
}