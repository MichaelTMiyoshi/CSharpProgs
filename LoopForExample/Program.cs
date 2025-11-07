namespace LoopForExample;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Looping!  Example of for loop.");
        Console.WriteLine("What does this code do?\n\n");

        int count = 0;
        const int perLine = 10;
        for (int i = 1; i <= 200; i++)
        {
            //Console.Write($"{i,10}");
            Console.Write("{0,10}", i);
            count++;
            if (perLine <= count)
            {
                count = 0;
                Console.WriteLine();
            }
        }
        Console.Write("\n\n\tPress the any key to exit.");
        Console.ReadKey(true);
    }
}
