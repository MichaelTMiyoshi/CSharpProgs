namespace BranchSwitch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Write("What is your age?  ");
        int age = Convert.ToInt32(Console.ReadLine());

        switch (age)
        {
            case 0:
            case 1:
            case 2:
            case 3:
                Console.Write("Tots should not play with computers.");
                break;
            case 4:
            case 5:
            case 6:
                Console.Write("Limit your computer usage.");
                break;
            case 7:
            case 8:
            case 9:
                Console.Write("You are the perfect age for this game.");
                break;
            default:
                Console.Write("You are too old for this game.");
                break;
        }
        Console.WriteLine("\n\nThis would be better written with ifs than switches.\n\n");

        Console.WriteLine("press the any key to continue...");
        Console.ReadKey();
    }
}
