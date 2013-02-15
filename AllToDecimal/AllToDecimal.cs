using System;

class AllToDecimal
{
    static void Main()
    {
        string number = Console.ReadLine();
        int rad = int.Parse(Console.ReadLine());

        const string Digits = "0123456789ABCDEF";

        if (rad < 2 || rad > Digits.Length)
            Console.WriteLine("The radix must be >= 2 and <= " + Digits.Length);

        if (String.IsNullOrEmpty(number))
            Console.WriteLine("0"); 

        number = number.ToUpperInvariant();

        long result = 0;
        long multiplier = 1;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            char c = number[i];
            if (i == 0 && c == '-')
            {
                result = -result;
                break;
            }

            int digit = Digits.IndexOf(c);
            if (digit == -1)
                Console.WriteLine("Invalid character in the arbitrary numeral system number","number");

            result += digit * multiplier;
            multiplier *= rad;
        }
        Console.WriteLine(result);
    }
}

