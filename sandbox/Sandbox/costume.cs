using System.Security.Cryptography.X509Certificates;

class Costume 
{
    // attributes (member variables)
    public string headWear, gloves, shoes, upperGarment, lowerGarment, accessory;

    // behaviors (member funstions, or methods.)
    public void ShowWadrobe()
    {
        string result = "";
        result += "Head gear: " + headWear;
        result += "\n Hand gear: " + gloves;
        result += "\nFoot gear: " + shoes;
        result += "\n Torso covering: " + upperGarment;
        result += "\n Leg gear: " + lowerGarment;
        result += "\n Accessory: " + accessory;
        Console.WriteLine(result);

    }
}