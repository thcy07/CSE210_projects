using System.Security.Cryptography.X509Certificates;
public class Job 
{
    // attributes (member variables)
    public string _jobTitle, _company;
    public int _startYear, _endYear;

    // behaviors (member funstions, or methods.)
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}    