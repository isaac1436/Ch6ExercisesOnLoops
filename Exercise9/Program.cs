class Exercise9
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        double n=double.Parse(Console.ReadLine());
        Console.Write("Please enter a number: ");
        double x = double.Parse(Console.ReadLine());
        double sum = 1;

        for(int num = 1; num <= n; num++)
        {
            sum += (num!) / (Math.Pow(x, num));
        }
        Console.WriteLine("\n\nThe sum of the sequence to the " + n + "th position is " + sum);
    }
}