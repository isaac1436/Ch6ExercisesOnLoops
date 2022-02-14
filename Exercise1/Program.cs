class Exercise1_2
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int limit = int.Parse(Console.ReadLine());
        for (int a = 1; a <= limit; a++)
        {
            Console.Write(a + " ");

        }
        Console.WriteLine("\n\nThe numbers listed below are numbers wich are not divisible by both 3 and 7");
        for (int a = 1; a <= limit; a++)
        {
            if (a % (3 * 7) != 0)
            {
                Console.Write(a + " ");
            }
        }

    }

}
