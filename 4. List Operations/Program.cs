using System.Reflection.Metadata.Ecma335;

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = " ";
            while ((command = Console.ReadLine()) != "End") 
            { 
                List<string> commandsList = command
                    .Split()
                    .ToList();
               
                switch (commandsList[0])
                {
                    case "Add": 
                    case "Remove":
                        int number = int.Parse(commandsList[1]);
                        if (commandsList[0] == "Add")
                        {
                            integers.Add(number);
                        }
                        else if (OutOfRangeCheck(integers, commandsList))
                        {
                            integers.RemoveAt(number);
                        }
                        break;
                    case "Insert":
                        if (OutOfRangeCheck(integers, commandsList))
                        {
                        integers.Insert(int.Parse(commandsList[2]), int.Parse(commandsList[1]));
                        }
                        break;
                    case "Shift": 
                        Shift(integers, commandsList); break;
                }
            }
            Console.WriteLine(string.Join(" ", integers));
        }
        static void Shift(List<int> integers, List<string> commandsList)
        {
            int count = int.Parse(commandsList[2]);
            if (commandsList[1] == "left")
            {
                
                for (int i = 0; i < count; i++)
                {
                    
                    integers.Add(integers[0]);
                    integers.RemoveAt(0);
                }
            }
            else if (commandsList[1] == "right")
            {
                for (int i = 0; i < count; i++)
                {
                    integers.Insert(0, integers[integers.Count-1]);
                    integers.RemoveAt(integers.Count-1);
                }
            }
        }
        static bool OutOfRangeCheck(List<int> integers, List<string> commandsList)
        {
            bool inRange = true;
            switch (commandsList[0])
            {
                case "Insert": 
                    if (int.Parse(commandsList[2]) > integers.Count || int.Parse(commandsList[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        inRange = false;
                    }
                    break;
                case "Remove":
                    if (int.Parse(commandsList[1]) > integers.Count || int.Parse(commandsList[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        inRange = false;
                    }
                    break;
            }
            return inRange;
        }
    }
}