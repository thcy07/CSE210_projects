using System.Security.Cryptography.X509Certificates;
using System.IO;


public class Word
{
    private string _text;
    private bool _isHidden ;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetText()
    {
        return _text;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

      public void HideWord()
    {
        _isHidden = true;
        _text = "___";
    }

}