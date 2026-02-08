namespace FileDelimitedExample;

/*
    Notice that the output file has an extra newline
    at the end.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Formatted Data Example!");
        try
        {
            StreamReader reader = new StreamReader("../../../CommaDelimited.txt");
            StreamWriter writer = new StreamWriter("../../../TabDelimted.txt");

            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                Console.WriteLine(line);
                String [] data = line.Split(',');
                String name = data[0];
                char ch = Convert.ToChar(data[1]);
                int i = Convert.ToInt32(data[2]);
                writer.WriteLine($"{name}\t{ch}\t{i}");
                //writer.WriteLine(name + '\t' + ch + '\t' + i);
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
