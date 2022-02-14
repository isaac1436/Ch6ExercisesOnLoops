class Exercise4
{
    static void Main()
    {
        string suit1 = " of Spades", suit2 = " of Hearts", suit3 = " of diamonds", suit4 = " of clubs";
        string king = "King", queen = "Queen", ace = "Ace";


        Console.WriteLine(ace + suit1);
        for (int card = 2; card <= 10; card++)
        {
            Console.WriteLine(card + suit1);
        }
        Console.WriteLine(queen + suit1);
        Console.WriteLine(king + suit1);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(ace + suit2);
        for (int card = 2; card <= 10; card++)
        {
            Console.WriteLine(card + suit2);
        }
        Console.WriteLine(queen + suit2);
        Console.WriteLine(king + suit2);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(ace + suit3);
        for (int card = 2; card <= 10; card++)
        {
            Console.WriteLine(card + suit3);
        }
        Console.WriteLine(queen + suit3);
        Console.WriteLine(king + suit3);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(ace + suit4);
        for (int card = 2; card <= 10; card++)
        {
            Console.WriteLine(card + suit4);
        }
        Console.WriteLine(queen + suit4);
        Console.WriteLine(king + suit4);
        Console.WriteLine();
        Console.WriteLine();

    }
}