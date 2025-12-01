using System.Drawing;
using System.Security.Cryptography.X509Certificates;

/*
    This example shows a few different things.
    
    The main thing is waiting for a key to be pressed.
        You can have an indefinite loop wait for a key to be
        pressed 
            if(Console.KeyAvailable)
        then, grab the key and do something with it.  In this 
        case, I am just exiting the loop when the ESCAPE key 
        is pressed.

    The other thing to notice is the Console.SetCursorPosition().
    You tell it the x and y location of whatever it is you want to 
    write to the screen.  Notice that I use Console.Write().
    You could keep track of the old cursor position and "erase" what
    you wrote there by writing over it with spaces (not shown).

    The last thing is changing colors.  I leave that up to the
    reader of this code to figure out what is going on.

    Actually, I leave the reader to figure out much of the code and
    how you can use it yourself.  This is just an example of a couple 
    neat things you can do with console programs.

    Remember to set the debugger to use an external terminal when using
    VSCode.

    I have some commented code that I was trying to use for some other
    purposes, but they did not work out and I was not going to spend more
    time on them yet.
*/

namespace ConsoleKeyAvailableExample;

class Program
{
    static Random rng;
    static void Main(string[] args)
    {
        rng = new Random();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("ConsoleKeyAvailable Example");

        bool again = true;
        int x = 1;
        int y = 10;

        //Color color = Color.Green;
        //ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        //int numColors = consoleColors.Length;
        //ConsoleColor background = Console.BackgroundColor;
        //ConsoleColor foreground = Console.ForegroundColor;
        //int numColors = Enum.GetValues(typeof(Color)).Length;
        //Console.WriteLine(numColors);
        //Console.ReadKey();
        while (again)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
            x = rng.Next(120);  // width of console window
            y = rng.Next(1, 28);   // height of console window - 2; keep top line
            do
            {
                //int colorNum = rng.Next(numColors);
                //foreground = (Color)consoleColors[colorNum];
                int foregroundcolor = (int)Console.ForegroundColor + 1;
                if (foregroundcolor == (int)ConsoleColor.White + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.ForegroundColor++;

            } while (Console.ForegroundColor == Console.BackgroundColor);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    again = false;
                }
            }
        }
        Console.SetCursorPosition(0, 28);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("Thank you for playing.\nPress the any key to continue.");
        Console.ReadKey();
    }
}
