namespace FIleExample;

/*
    Notice that the output file has an extra newline
    at the end.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("File Example\n");
        try
        {
            StreamReader reader = new StreamReader("../../../text.txt");
            StreamWriter writer = new StreamWriter("../../../OutputFile.txt");

            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                Console.WriteLine(line);
                writer.WriteLine(line);
            }
            writer.Close();
            reader.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
