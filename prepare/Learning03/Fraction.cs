using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class Fraction 
{
   private int _top, _bottom;

   public Fraction()
   {
    _top = 1;
    _bottom = 1;
   }

   public Fraction(int wholeNumber)
   {
    _top = wholeNumber;
    _bottom = 1;
   }

   public Fraction( int top, int bottom)
   {
    _top = top;
    _bottom = bottom;
   }

   public string GetFractionString()
   {
    string textFraction = $"{_top}/{_bottom}";
    return textFraction;
   }

   public double GetFractionDecimal()
   {
    double decimalValue = (double)_top/(double)_bottom;
    return decimalValue;
   }
}
