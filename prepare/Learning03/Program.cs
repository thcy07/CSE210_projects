using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction();
        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract1.GetFractionDecimal());

        Fraction fract2 = new Fraction(67);
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetFractionDecimal());

        Fraction fract3 = new Fraction(56, 87);
        Console.WriteLine(fract3.GetFractionString());
        Console.WriteLine(fract3.GetFractionDecimal());

        Fraction fract4 = new Fraction(3, 98);
        Console.WriteLine(fract4.GetFractionString());
        Console.WriteLine(fract4.GetFractionDecimal());
    }
}