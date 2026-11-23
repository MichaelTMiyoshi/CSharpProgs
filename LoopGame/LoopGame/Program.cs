namespace LoopGame;
/*
    Note:   This works best on an external terminal/console.
            Go to settings and search for "external".
            Then in C# -> debugger select externalTerminal from the dropdown.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Game Loop");

        bool done = false;
        do
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        done = true;
                        break;
                    case ConsoleKey.C:
                        int fgc = (int) Console.ForegroundColor + 1;
                        if(fgc == (int) ConsoleColor.White + 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;    // DarkBlue = 1
                        }
                        else
                        {
                            Console.ForegroundColor++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine();
                        break;
                    default:
                        Console.Write(key.KeyChar);
                        break;
                }
            }
        }while(!done);
        Console.Write("Press the any key to exit.");
        Console.ReadKey(true);
    }
}
