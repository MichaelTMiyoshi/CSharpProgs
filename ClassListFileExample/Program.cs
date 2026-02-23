namespace ClassListFileExample;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Class List File Example");
        /* try
        {
            StreamReader reader = new StreamReader("../../../PeopleData.txt");
            String name;
            int age;
            int height; // inches
            int weight; // pounds
            String phone;

            reader.ReadLine();  // read the first line with the labels
            while(!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                String [] data = line.Split(',');
                name = data[0];
                age = Convert.ToInt32(data[1]);
                height = Convert.ToInt32(data[2]);
                weight = Convert.ToInt32(data[3]);
                phone = data[4];
                //Console.WriteLine($"{name, -12} age: {age,4}, height: {height, 5}, weight: {weight, 5}, phone: {phone}");
                Person person = new Person(name, age, height, weight, phone);
                Console.WriteLine(person);
            }

            reader.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        } */
        //ReadData();
        List<Person> people = ReadData("../../../PeopleData.txt");
        for(int i = 0; i < people.Count; i++)
        {
            Console.WriteLine(people[i]);
        }

        // Put a loop around this last part and have the user be able to search
        // based on any of the fields.
        // Have a menu where the user can choose to search by the different fields.
        // You will need to make at least one more function/method because you
        // will be searching for either Strings (name, phone) or ints (age, height, weight).

        Console.WriteLine("\n\nFinding Data...\n\n");

        String findName = "Loretta";
        int who = Find(people, findName);
        if(who != -1)
        {
            Console.WriteLine(people[who]);
        }
        else
        {
            Console.WriteLine($"{findName} not in database.");
        }

        // Loop until the user says to stop.  An exit in the menu would be best.
    }

    private static void ReadData()
    {
        try
        {
            StreamReader reader = new StreamReader("../../../PeopleData.txt");
            String name;
            int age;
            int height; // inches
            int weight; // pounds
            String phone;

            reader.ReadLine();  // read the first line with the labels
            while(!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                String [] data = line.Split(',');
                name = data[0];
                age = Convert.ToInt32(data[1]);
                height = Convert.ToInt32(data[2]);
                weight = Convert.ToInt32(data[3]);
                phone = data[4];
                //Console.WriteLine($"{name, -12} age: {age,4}, height: {height, 5}, weight: {weight, 5}, phone: {phone}");
                Person person = new Person(name, age, height, weight, phone);
                Console.WriteLine(person);
            }

            reader.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }

    private static List<Person> ReadData(String filename)
    {
        List<Person> list = new List<Person>();
        try
        {
            StreamReader reader = new StreamReader(filename);
            String name;
            int age;
            int height; // inches
            int weight; // pounds
            String phone;

            reader.ReadLine();  // read the first line with the labels
            while(!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                String [] data = line.Split(',');
                name = data[0];
                age = Convert.ToInt32(data[1]);
                height = Convert.ToInt32(data[2]);
                weight = Convert.ToInt32(data[3]);
                phone = data[4];
                //Console.WriteLine($"{name, -12} age: {age,4}, height: {height, 5}, weight: {weight, 5}, phone: {phone}");
                Person person = new Person(name, age, height, weight, phone);
                // Console.WriteLine(person);
                list.Add(person);
            }

            reader.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
        return list;
    }

    private static int Find(List<Person> list, String findMe)
    {
        int index = -1;
        for(int i = 0; i < list.Count; i++)
        {
            if (list[i].Name.Equals(findMe))
            {
                index = i;
                break;
            }
        }
        return index;
    }
}
