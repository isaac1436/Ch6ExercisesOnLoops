class Exercise6_7_8
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number ");
        int c=int.Parse(Console.ReadLine());

        if ((n > 1) && (k > 1) && (n > k))
        {
            //Exercise 6
            double sol1 = (n!) / (k!);
            //Exercise 7
            double sol2 = ((n!) * (k!)) / ((n - k)!);
            Console.WriteLine("The solution for exercise 6 is " + sol1);
            Console.WriteLine("The solution for exercise 7 is " + sol2);
        }
        //Exercise 8
        Console.WriteLine("\n\nA sequence of catalan numbers is ");
        for (int count = 1; count <=c; count++)
        {
            if (n >= 0)
            {
                float catNo = ((2 * count)!) / (((count + 1)!) * (count!));
                Console.Write(catNo + " ");
            }
        }
    }
}