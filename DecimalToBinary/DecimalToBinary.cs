using System;

class DecimalToBinary
{
    static void Main()
    {
        int decimalN = int.Parse(Console.ReadLine());
        int remainder;
        string result = string.Empty;

        while (decimalN > 0)
        {
            remainder = decimalN % 2;
            decimalN /= 2;
            result += remainder.ToString();
        }
        Console.WriteLine(result);
    }
}

