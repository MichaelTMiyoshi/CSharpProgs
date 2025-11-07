namespace RandomNum;

class Program
{
    static Random rng;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        rng = new Random();

        int dice = rng.Next(6);
        dice = 1 + dice;
        Console.WriteLine(dice);
        dice = rng.Next(1, 7);
        Console.WriteLine(dice);

        Console.ReadKey();
    }
}
