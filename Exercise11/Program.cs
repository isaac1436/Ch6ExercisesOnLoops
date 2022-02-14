class Exercise11
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        bool num = int.TryParse(Console.ReadLine(),out int n);
        int count = 0;
        int nFact = (n!);
        Console.WriteLine(nFact);
        for (int i = 0; ; i++)
        {
            if (nFact % 10 == 0)
            {
                count++;
                nFact /= 10;
            }
            if(nFact % 10 != 0)
            {
                break;
            }
            
        }

        Console.WriteLine("The program was executed to completion and the number of 0\'s at the end of the factorial is " + count);


    }
}