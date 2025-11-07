namespace BranchIf;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Write("What is your name?  ");
        String name = Console.ReadLine();
        Console.Write("What is your quest?  ");
        String quest = Console.ReadLine();
        if (quest.ToLower() == "grail")
        {
            Console.WriteLine("Imposter!  You do not know the quest!");
        }
        else if (quest.ToLower().Contains("grail") && quest.ToLower().Contains("seek"))
        {
            Console.Write("What will you do if you find the grail?  ");
            String detail = Console.ReadLine();
            if (detail.ToLower().Contains("sell"))
            {
                Console.WriteLine("Argh!  Off with his head!");
            }
            else if (detail.ToLower().Contains("king") && detail.ToLower().Contains("give"))
            {
                Console.WriteLine("Be sure to bring it back then.");
            }
            else
            {
                Console.WriteLine("To the dungeon!");
            }
        }
        else
        {
            if (name.ToLower() == "arthur")
            {
                Console.WriteLine("Hail!  King Arthur!");
            }
            else
            {
                Console.WriteLine("Off with your head.");
            }
        }

        Console.WriteLine("Press the any key to continue...");
        Console.ReadKey();
    }
}
