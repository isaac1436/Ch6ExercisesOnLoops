using System.Numerics;
class Exercise6_7_8
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number: ");
        int k = int.Parse(Console.ReadLine());
        
        if ((n > 1) && (k > 1) && (n > k))
        {
            //Exercise 6
            double sol1 = (double) ( (Factorial(n)) / (Factorial(k)));
            //Exercise 7
            double sol2 = (double)(((Factorial(n)) * (Factorial(k))) / (Factorial(n-k)));
            Console.WriteLine("The solution for exercise 6 is " + sol1);
            Console.WriteLine("The solution for exercise 7 is " + sol2);
        }
        //Exercise 8
        Console.WriteLine("\n\nA sequence of catalan numbers is ");
        for (int count = 0; count <=n; count++)
        {
            if (n >= 0)
            {
                BigInteger catNo = (Factorial(2*count)) / ((Factorial(count+1)) * (Factorial(count)));
                Console.Write(catNo + " ");
            }
        }
    }

    static BigInteger Factorial(BigInteger d)
    {
        BigInteger factorial = 1;
        while (true)
        {
            if (d <= 1)
            {
                break;
            }
             factorial*= d;
            d--;
        }
        return factorial;
    }
}