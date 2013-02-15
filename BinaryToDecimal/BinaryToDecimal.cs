using System;


class BinaryToDecimal
{
    static void Main()
    {
        int DecimalN = 0;
        int pow = 1;
        int BinaryN = int.Parse(Console.ReadLine());

        while (BinaryN > 0)
        {
            DecimalN += BinaryN % 10 * pow;
            BinaryN = BinaryN / 10;
            pow = pow * 2;
        }
        Console.WriteLine(DecimalN);
    }
}
