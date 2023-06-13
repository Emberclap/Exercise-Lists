namespace _5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bombDetails = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int bomb = bombDetails[0];
            int bombPower = bombDetails[1];

           
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == bomb)
                {
                    for (int j = 0; j < bombPower; j++)
                    {
                        if (i-1 >= 0)
                        {
                        numbers.RemoveAt(i-1);
                            i--;
                        }
                        else
                        {
                            break;
                        }
                    }
                    for (int j = 0;j < bombPower; j++)
                    {
                        if (i + 1 < numbers.Count)
                        {
                            numbers.RemoveAt(i + 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                    numbers.Remove(numbers[i]);
                    i--;

                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}