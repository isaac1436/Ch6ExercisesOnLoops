class Exercise12
{

    static void Main()
    {
        Console.WriteLine("This is a program to convert from any base to decimal");
        Console.WriteLine("Enter 1 for bianry to decimal");
        Console.WriteLine("Enter 2 for octal to decimal");
        Console.WriteLine("Enter 3 for hexadecimal to decimal");
        Console.Write("\n\nPlease enter your choice: ");
        int choice=int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter a binary number: ");
                string bin1 = Console.ReadLine();
                double result1 = Binary2Decimal(bin1);
                Console.WriteLine(Math.Round(result1));
                break;
            case 2:
                Console.Write("Please enter an octal number: ");
                string bin2 = Console.ReadLine();
                double result2 = Octal2Decimal(bin2);
                Console.WriteLine(Math.Round(result2));
                break;
            case 3:
                Console.Write("Please enter a hexadecimal number: ");
                string bin3 = Console.ReadLine();
                double result3 = Hex2Decimal(bin3);
                Console.WriteLine(Math.Round(result3));
                break;
        }

    }

    static double Binary2Decimal(string binaryNum)
    {
        int count = binaryNum.Length;
        int[] digits = new int[count];
        double decimalNo = 0;
        int binNo = int.Parse(binaryNum);
        int divisor = (int)Math.Pow(10, count);
        for (int j = 0; j < count; j++)
        {
            digits[j] = (binNo / divisor) % 10;
            decimalNo += (int)(digits[j] * (Math.Pow(2, count)));
            count--;
            divisor /= 10;
        }
        return decimalNo;
    }

    static double Octal2Decimal(string octalNum)
    {
        int count = octalNum.Length;
        int[] digits = new int[count];
        double decimalNo = 0;
        int octalNo = int.Parse(octalNum);
        count -= 1;
        int divisor = (int)Math.Pow(10, count);
        for (int j = 0; j <= count; j++)
        {
            digits[j] = (octalNo / divisor) % 10;
            decimalNo += (digits[j] * (Math.Pow(8, count)));
            count--;
            divisor /= 10;
        }
        return decimalNo;
    }

    static double Hex2Decimal(string hexNum)
    {
        int count = hexNum.Length;
        int[] digits = new int[count];
        double decimalNo = 0;
        int hexNo = int.Parse(hexNum);
        count -= 1;
        int divisor = (int)Math.Pow(10, count);
        for (int j = 0; j <= count; j++)
        {
            digits[j] = (hexNo / divisor) % 10;
            decimalNo += (int)(digits[j] * (Math.Pow(16, count)));
            count--;
            divisor /= 10;
        }
        return decimalNo;
    }
}
