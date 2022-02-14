class Exercise17
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        bool firstNum = int.TryParse(Console.ReadLine(), out int num1);
        Console.Write("Enter a number: ");
        bool secondNum = int.TryParse(Console.ReadLine(), out int num2);
        int gcd = 0;
        int lcm = 0;

        for (int test = 1; test <= num1; test++)
        {
            if ((num1 % test == 0) && (num2 % test == 0))
            {
                if (test > gcd)
                {
                    gcd = test;
                }
            }
        }
        lcm = (num1 * num2) / gcd;
        Console.WriteLine("The greatest common divisor of " + num1 + " and " + num2 + " is: " + gcd
            +" and their LCM is: "+lcm);

    }
}