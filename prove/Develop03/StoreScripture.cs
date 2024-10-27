using System.Security.Cryptography.X509Certificates;
using System.IO;

public class StoreScrpiture
{
    private string reference;
    private string scripture;
    private static readonly string scriptureFile = "scriptures.txt";
    private static readonly Dictionary<string, string> ScriptureRepository = new Dictionary<string, string>(); 

  
    public string GetReference()
    {
        Console.WriteLine("Please enter the reference of the verse you wish to memorize:");
        reference = Console.ReadLine();
        return reference;
    }

    public string GetScripture()
    {
        Console.WriteLine("Please enter the scripture of the verse you wish to memorize:");
        scripture = Console.ReadLine();
        return scripture;
    }
    public void WriteScriptureToFile(string reference, string scripture)
    {
        string entry = $"{reference}|{scripture}";

        using (StreamWriter writer = File.AppendText(scriptureFile))
        {
            writer.WriteLine(entry);
            Console.WriteLine("Scripture Loaded Successfully");
        }
    }
    
    public void DisplayScriptures()
    {
         using (StreamReader reader = new StreamReader(scriptureFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');

                string reference = parts[0];
                string scripture = parts[1];

                Console.WriteLine($"{reference} {scripture}");
            }
        }
    }

   
}

    