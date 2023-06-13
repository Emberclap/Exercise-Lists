namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();
            List<int> result = new List<int>();
            foreach (string chars in arrays)
            {
                result.AddRange(chars.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList());

            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}