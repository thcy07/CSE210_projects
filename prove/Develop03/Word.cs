using System.Security.Cryptography.X509Certificates;
using System.IO;


public class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hidden()
    {
        IsHidden = true;
    }

}