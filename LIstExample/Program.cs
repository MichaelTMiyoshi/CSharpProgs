namespace LIstExample;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("List Example");

        List<int> scores = new List<int>();
        OutputList(scores, 10);
        List<double> doubles = new List<double>();
        OutputList(doubles);
        List<bool> TFAnswers = new List<bool>();
        OutputList(TFAnswers);
        List<int> nums = new List<int>{10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
        OutputList(nums, 5);
        List<double> health = new List<double>{10.5, 9.6, 8.7, 7.6, 6.5,};
        OutputList(health);
        List<int> moreNums = new List<int>(50);
        OutputList(moreNums, 7);
        List<int> zeroes = Enumerable.Repeat(0, 100).ToList();
        OutputList(zeroes);

        Console.WriteLine("Original intList");
        List<int> intList = new List<int>();
        for(int i = 0; i < 100; i++)
        {
            intList.Add(i + 1);
        }

        OutputList(intList);

        intList.Remove(10);     // remove the number 10
        intList.Remove(20);     // remove the number 20
        intList.RemoveAt(33);   // removes the element at spot 33 (36)
        intList.RemoveAt(33);   // removes the elements at spot 33 (37)

        Console.WriteLine("intList with removals");
        OutputList(intList);
        Console.WriteLine();

        List<String> strings = new List<String>();
        strings.Add("Hello there.");
        strings.Add("Goodbye...");
        strings.Add("What?");
        OutputList(strings);

        Console.WriteLine("Press the any key to exit...");
        Console.ReadKey();
    }

    static void OutputList<T> (List<T> list, int perLine = 10)
    {
        int counter = 0;
        for(int i = 0; i < list.Count; i++)
        {
            if(typeof(T) == typeof(String))
            {
                Console.WriteLine($"{list[i]}");
            }
            else
            {
                if(typeof(T) == typeof(int))
                {
                    Console.Write($"{list[i],8}");
                }
                else if(typeof(T) == typeof(double))
                {
                    Console.Write($"{list[i],8:0.00}");
                }
                else
                {
                    Console.Write($"{list[i],8}");
                }
                counter++;
                if(perLine <= counter)
                {
                    counter = 0;
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine();
    }
}
