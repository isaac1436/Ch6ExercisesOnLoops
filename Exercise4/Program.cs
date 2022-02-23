class Exercise4
{
    static void Main()
    {
        string king = "King", queen = "Queen", ace = "Ace";
        string[] suits = { " of Spades", " of Hearts", " of Diamonds", " of Clubs" };

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(ace + suits[i]);
            for (int card = 2; card <= 10; card++)
            {
                Console.WriteLine(card + suits[i]);
            }
            Console.WriteLine(queen + suits[i]);
            Console.WriteLine(king + suits[i]);
            Console.WriteLine();
            Console.WriteLine();
        }
     
    }
}