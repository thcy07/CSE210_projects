using System.Security.Cryptography.X509Certificates;
using System.IO;

public class StoreScrpiture
{
    private string _reference;
    private string _scripture;
    private static readonly string scriptureFile = "scriptures.txt";
    private static readonly Dictionary<string, string> ScriptureRepository = new Dictionary<string, string>(); 

  
    public string GetReference()
    {
        Console.WriteLine("Please enter the reference of the verse you wish to memorize:");
        _reference = Console.ReadLine();
        return _reference;
    }

    public string GetScripture()
    {
        Console.WriteLine("Please enter the scripture of the verse you wish to memorize:");
        _scripture = Console.ReadLine();
        return _scripture;
    }
    public void WriteScriptureToFile(string _reference, string _scripture)
    {
        string entry = $"{_reference}|{_scripture}";

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

                string _reference = parts[0];
                string _scripture = parts[1];

                Console.WriteLine($"{reference} {scripture}\n");
            }
        }
    }

   
}

    