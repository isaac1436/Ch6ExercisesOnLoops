using System.Numerics;
class Exercise11
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int count = 0;
        BigInteger nFact = 1;
        while (true)
        {
            if (num <= 1)
            {
                break;
            }
            nFact *= num;
            num--;
        }
        
        Console.WriteLine(nFact);
        for (int i = 0; ; i++)
        {
            if (nFact % 10 == 0)
            {
                count++;
                nFact /= 10;
            }
            if (nFact % 10 != 0)
            {
                break;
            }

        }

        Console.WriteLine("The program was executed to completion and the number of 0\'s at the end of the factorial is " + count);


    }
}