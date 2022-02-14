class Exercise3
{
    static void Main()
    {
        Console.Write("Please enter a series of numbers, input 0 to quit: ");
        int endSeq = 0;
        int maxVal = int.MinValue;
        int minVal = int.MaxValue;
        for (int a = 1; a != endSeq;)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                a = 0;
            }

            if (num > maxVal&&num!=0)
            {
                maxVal = num;
            }

            if (num < minVal&&num!=0)
            {
                minVal = num;
            }
        }

        Console.WriteLine("The maximum Value entered is "+maxVal+ ", and the minimum value entered is "+minVal);
    }
}