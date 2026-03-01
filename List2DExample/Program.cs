namespace List2DExample;

class Program
{
    static Random rng;
    static void Main(string[] args)
    {
        rng = new Random();
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.CursorVisible = false;
        Console.Clear();
        Console.SetCursorPosition(0,24);
        Console.Write("2D Lists and Arrays");

        UseList();
        //UseArray();

        Console.ReadKey();
    }

    static void UseList()
    {
        Console.Write(" using a 2D list.");
        List<List<ConsoleColor>> colors = new List<List<ConsoleColor>>();
        for(int r = 0; r < 20; r++)
        {
            List<ConsoleColor> row = new List<ConsoleColor>();
            for(int c = 0; c < 40; c++)
            {
                row.Add((ConsoleColor)rng.Next(1,16));
            }
            colors.Add(row);
        }

        for(int r = 0; r < colors.Count; r++)
        {
            for(int c = 0; c < colors[r].Count; c++)
            {
                Console.ForegroundColor = colors[r][c];
                Console.SetCursorPosition(c,r);
                Console.Write("\u2588");
            }
        }
    }

    static void UseArray()
    {
        Console.Write(" using a 2D array.");
        ConsoleColor [,] colors = new ConsoleColor[20, 40]; // 20 rows, 40 columns
        for(int r = 0; r < 20; r++)
        {
            for(int c = 0; c < 40; c++)
            {
                colors[r,c] = (ConsoleColor)rng.Next(1,16);
            }
        }

        for(int r = 0; r < colors.GetLength(0); r++)
        {
            for(int c = 0; c < colors.GetLength(1); c++)
            {
                Console.ForegroundColor = colors[r,c];
                Console.SetCursorPosition(c,r);
                Console.Write("\u2588");
            }
        }
    }

/* Note:
        Console.SetCursorPosition uses (column, row).
        Column is x.  Row is y.
        Remember that positive y is down.
*/
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.SetCursorPosition(6,3);
//        Console.Write("\u2588");
}
