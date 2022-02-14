using System.Numerics;
class Exercise5
{
    static void Main()
    {
        BigInteger num = 0;
        BigInteger num2 = 1;
        BigInteger num3 = 0;
        BigInteger sum = 0;
        Console.Write("Enter a number: ");
        int seqNo = int.Parse(Console.ReadLine());
        Console.WriteLine("The first "+seqNo+" numbers in the fibonacci sequence are");
        for (int count = 0; count <= seqNo; count++)
        {
            sum += num;
            Console.Write(num + ", ");
            num3 = num;
            num += num2;
            num2 = num3;
            
        }
        Console.WriteLine();
        Console.WriteLine("The sum of the first " + seqNo + " numbers in the Fibonacci Sequence is " + sum);
    }
}