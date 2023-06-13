using System.Security.Cryptography.X509Certificates;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string commands = "";
            while((commands = Console.ReadLine()) != "end")
            {
                List<string> commandsList = commands.Split().ToList();
                int number = int.Parse(commandsList[1]);
                
                switch (commandsList[0])
                {
                    case "Delete": 
                        
                        for (int i = 0; i < listOfIntegers.Count; i++)
                        {                                                
                            if (listOfIntegers[i] == number)
                            {
                                listOfIntegers.Remove(number);
                                i--;
                            }
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(commandsList[2]);
                        listOfIntegers.Insert(index, number);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", listOfIntegers));
        }
    }
}