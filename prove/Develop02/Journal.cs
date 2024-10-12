using System.Security.Cryptography.X509Certificates;
using System.IO;
public class Journal
{
    public List<JournalEntry> _journalEntries = new();    
    private List<string> _prompts = new()
    {
        "If you had one thing you could so differently today what would it be?",
        "Who was one interesting person you met today?",
        "What was something new you learned today?",
        "Did you try something new today?",
        "What was the best part of your day?",
        "How did you enrich a relationship you have?",
        "Recount a fun incident today.",
        "Are you enjoying any kind of content recently?",
        "Recount a random incident.",
    };
    private Random random = new Random();

    private List<string> challenges = new List<string>()
    {
        "Try a new recipe today",
        "Learn something new about a hobby you enjoy",
        "Spend quality time with a loved one",
        "FInd a New Hobby",
        "Talk to one new person",
        "Eat at a new Restraunt",
        "Visit the Temple"
    };
    private Random challengeRandom = new Random();
    public string CurrentFilename { get; set; }


    public void CreateNewJournalEntry()
    {
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        
        string challenge = challenges[challengeRandom.Next(challenges.Count)];
        Console.WriteLine(challenge);
        string challengeResponse = Console.ReadLine();

        JournalEntry newEntry = new JournalEntry(DateTime.Now.ToString("MM/dd/yyyy"), prompt, response, challenge, challengeResponse);
        _journalEntries.Add(newEntry);      
        
    }

    public void DisplayJournalEntries()
    {
        if (_journalEntries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (JournalEntry entry in _journalEntries)
        {
            Console.WriteLine($"Date: {entry.DateString}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine($"Challenge: {entry.Challenge}");
            Console.WriteLine($"Experience: {entry.ChallengeResponse}");            
            Console.WriteLine();
        }
    }

    public void SaveLoadJournal(bool isLoad)
    {
        string filename = GetFilename();

        if (isLoad)
        {
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
            string[] parts = line.Split('|');   

            _journalEntries.Add(new JournalEntry(parts[0], parts[1], parts[2], parts[3], parts[4]));
            }
        }
        Console.WriteLine("Journal loaded successfully!");
        CurrentFilename = filename;
        }
        else
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                foreach (JournalEntry entry in _journalEntries)
                {
                    writer.WriteLine($"{entry.DateString}|{entry.Prompt}|{entry.Response}|{entry.Challenge}|{entry.ChallengeResponse}");
                }
            }
            Console.WriteLine("Journal entries saved successfully!");
        }
    }

  private string GetFilename()
    {
    string defaultPath = @"C:\Users\camer\Programming with Classes (CSE 210)\CSE210_projects\prove\Develop02\bin\Debug\net8.0";
    Console.Write("Enter the filename (press Enter to use the default path to save): ");
    string filename = Console.ReadLine();

        if (string.IsNullOrEmpty(filename))
        {
            filename = Path.Combine(defaultPath, "MyJournal.txt");
        }

    return filename;
    }
    public string GetChallengeOfTheDay()
    {
        int newChallenge = challengeRandom.Next(challenges.Count);
        return challenges[newChallenge];
    }
}