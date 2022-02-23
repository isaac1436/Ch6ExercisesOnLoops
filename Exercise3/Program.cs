class Exercise3
{
    static void Main()
    {
        Console.Write("Please enter the number of values you'd like to use: ");
        int limit = int.Parse(Console.ReadLine());
        int maxVal = int.MinValue;
        int minVal = int.MaxValue;
        for (int a = 0; a < limit; a++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num > maxVal)
            {
                maxVal = num;
            }

            if (num < minVal)
            {
                minVal = num;
            }


        }

        Console.WriteLine("The maximum Value entered is " + maxVal + ", and the minimum value entered is " + minVal);
    }
}