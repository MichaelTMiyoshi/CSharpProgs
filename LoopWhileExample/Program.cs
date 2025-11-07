namespace LoopWhileExample;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Looping!  Example of while loop.");
        Console.WriteLine("What does this code do?\n\n");

        int count = 0;
        const int perLine = 10;
        int skip = 1;
        int i = 1;
        while (i <= 200)
        {
            Console.Write($"{i,10}");
            //Console.Write("{0,10}", i);
            count++;
            if (perLine <= count)
            {
                count = 0;
                Console.WriteLine();
            }
            i++;
            skip++;
            if (skip == 7)
            {
                skip = 1;
                i++;
            }
        }
        Console.Write("\n\n\tPress the any key to exit.");
        Console.ReadKey(true);
    }
}
