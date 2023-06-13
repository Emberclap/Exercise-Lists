namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count > 0) 
            {
                int i = 0;

                if (firstPlayerDeck[i] > secondPlayerDeck[i])
                {
                    firstPlayerDeck.Add(secondPlayerDeck[i]);
                    firstPlayerDeck.Add(firstPlayerDeck[i]);
                    firstPlayerDeck.RemoveAt(0);
                    secondPlayerDeck.RemoveAt(0);
                    
                }
                else if (firstPlayerDeck[i] < secondPlayerDeck[i])
                {
                    secondPlayerDeck.Add(firstPlayerDeck[i]);
                    secondPlayerDeck.Add(secondPlayerDeck[i]);
                    secondPlayerDeck.RemoveAt(0);
                    firstPlayerDeck.RemoveAt(0);
                   
                }
                else
                {
                    secondPlayerDeck.RemoveAt(0);
                    firstPlayerDeck.RemoveAt(0);
                  
                }
            }
            
            if (firstPlayerDeck.Count > secondPlayerDeck.Count) 
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerDeck.Sum()}");
            }
        }
    }
}