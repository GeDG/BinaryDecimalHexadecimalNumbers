using System;

class DecimalToHex
{
    static void Main()
    {
        long decimalN = long.Parse(Console.ReadLine());
        int rad = int.Parse(Console.ReadLine());

        const int Bits = 64;
        const string Digits = "0123456789ABCDEF";

        if (rad < 2 || rad > Digits.Length)
            Console.WriteLine("The radix must be >= 2 and <= " + Digits.Length); 

        if (decimalN == 0)
            Console.WriteLine("0");

        int index = Bits - 1;
        long currentN = Math.Abs(decimalN);
        char[] charArray = new char[Bits];

        while (currentN != 0)
        {
            int remainder = (int)(currentN % rad);
            charArray[index--] = Digits[remainder];
            currentN = currentN / rad;
        }

        string result = new String(charArray, index + 1, Bits - index - 1);
        if (decimalN < 0)
        {
            result = "-" + result;
        }

        Console.WriteLine(result);
    }
}

