class Exercise10
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n=int.Parse(Console.ReadLine());
        int m = 1;
        int o = n;
        for(int i = 0; i < n; i++)
        {
            for(int j = m;j<=o; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
            m++;
            o++;
        }
    }
}