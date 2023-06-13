using System.Security.Cryptography.X509Certificates;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int passengerPerWagon = int.Parse(Console.ReadLine());
            string commands = "";
            while((commands = Console.ReadLine()) != "end")
            {
                List<string> command = commands.Split().ToList();
                int newPassengers = 0;
                if (command[0] == "Add")
                {
                    newPassengers = int.Parse(command[1]);
                    wagons.Add(newPassengers);
                    continue;
                }
                else
                {
                    newPassengers = int.Parse(command[0]);
                }
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i] + newPassengers <= passengerPerWagon)
                    {
                        wagons[i] += newPassengers;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}