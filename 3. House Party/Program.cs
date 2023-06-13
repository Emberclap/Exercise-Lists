namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsNumber = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            for (int i = 0; i < commandsNumber; i++)
            {
                List<string> commands = Console.ReadLine()
                    .Split()
                    .ToList();
                if (commands.Count <= 3)
                {
                    if (guestList.Contains(commands[0]))
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(commands[0]);
                    }
                }+
                else
                {
                    if (guestList.Contains(commands[0]))
                    {
                        guestList.Remove(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }

            }
            for (int i = 0;i < guestList.Count;i++)
            {
                Console.Write(guestList[i]);
                Console.WriteLine();
            }
            
        }
    }
}