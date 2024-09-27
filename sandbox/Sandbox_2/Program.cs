namespace Sandbox_2;

class Program
{
    static void Main(string[] args)
    {
    // Computer throws 3 dice
    Random randomGenerator = new();
    int dice1 = randomGenerator.Nexr(1, 7);
    int dice2 = randomGenerator.Nexr(1, 7);
    int dice3 = randomGenerator.Nexr(1, 7);

    }
}
