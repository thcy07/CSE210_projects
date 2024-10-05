using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Sandbox World!");

        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.gloves = "latex gloves";
        nurse.shoes = "orthopedic shoes";
        nurse.upperGarment = "Scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new();
        detective.headWear = "fedora";
        detective.gloves = "leather gloves";
        detective.shoes = "loafers";
        detective.upperGarment = "trenchcoat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass";

         Costume rancher = new();
        rancher.headWear = "cowboy hat";
        rancher.gloves = "work";
        rancher.shoes = "boots";
        rancher.upperGarment = "vest";
        rancher.lowerGarment = "jeans";
        rancher.accessory = "lasso";

        nurse.ShowWadrobe();
        detective.ShowWadrobe();
       rancher.ShowWadrobe();

        
    }
}