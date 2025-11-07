namespace IntroMath;

/*
    Author: Miyoshi
    Program: IntroMath
    Pseudocode:
        Create some variables and constants
        Do some addition, subtraction, multiplication, division
    Maintenance Log:
        09/22/2025  

    Note: Make sure to understand:
                int division
                modulus (int)
                float (double) division
                mixed division
                order of operations
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int a = 7;
        int b = 3;
        double c = 7.8;
        double d = 3.4;
        int iAns = a + b;
        double fAns = c + d;

        Console.WriteLine($"a = {a}\t\tb = {b}\nc = {c}\t\td = {d}\n");
        Console.WriteLine("a + b = " + iAns);
        Console.WriteLine($"{c} + {d} = {fAns}");

        /* Do subtraction, multiplication, division */

        iAns = a / b;
        fAns = c / d;
        Console.WriteLine("a / b = " + iAns);
        iAns = a % b;
        Console.WriteLine("a % b = " + iAns);
        Console.WriteLine($"{c} / {d} = {fAns}");

        iAns = a / (int) c; // typecasting (casting)
        fAns = b / d;
        Console.WriteLine("a / c = " + iAns);
        Console.WriteLine($"{b} / {d} = {fAns}");

        Console.ReadKey();
    }
}
