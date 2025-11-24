namespace FunctionExample;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int a = 4;
        Console.WriteLine($"a = {a}");
        int ans = fn1(ref a);
        Console.Write($"a = {a}\nans = {ans}");

        Console.Write("\n\nPress the any key to continue...");
        Console.ReadKey();
    }

    static int fn1(ref int a)
    {
        a = a * 3;
        int b = a - 7;
        return b;
    }
}
