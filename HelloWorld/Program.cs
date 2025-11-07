using System.Linq.Expressions;

namespace HelloWorld;

/*
    Author: Miyoshi
    Program: Hello World
    Pseudocode:
        Output a few lines
        Get info from the user
        Output user data
    Maintenance Log:
        09/22/2025  Setup VSCode to use externalTerminal
                    Some stuff does not work with internalConsole
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        const char sqrtSym = '\u221A';  // unicode square root symbol
        Console.WriteLine(sqrtSym + "" + 7);

        Console.Write("What is your name?  >> ");
        String name = Console.ReadLine();
        Console.WriteLine("Hello " + name);

        Console.Write("What is your age?   >> ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("age: " + age);

        Console.SetCursorPosition(10, 15);
        Console.Write(name);
        Console.SetCursorPosition(10, 16);
        Console.Write(age);
        Console.ReadKey();
    }
}
